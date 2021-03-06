﻿Imports SC_BackEnd
Imports SC_Common
Imports System.Data.Common
Imports System.Data.SqlClient
Public Class CAB0100Cls

    Function getCompany(poparam As List(Of Object)) As List(Of LKM_CompanyOfficeDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loCompany As String
        Dim Company() As String
        Dim loReturn As List(Of LKM_CompanyOfficeDTO)

        Try
            loCompany = poparam.Item(0)

            lcCmd = "SELECT DISTINCT [COMPANY_OFFICE], [COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[M_COMPANY_OFFICE] (NOLOCK)"

            If loCompany IsNot Nothing And Right(loCompany, 2) <> "HO" Then
                lcCmd = lcCmd & " WHERE COMPANY_OFFICE_ID = '" & loCompany & "'"
            Else
                Company = Split(loCompany, ".")
                lcCmd = lcCmd & " WHERE COMPANY_ID = '" & Company(0) & "'"
            End If

            loReturn = loDb.SQLExecObjectQuery(Of LKM_CompanyOfficeDTO)(lcCmd, loDb.GetConnection, True)
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Sub Import(DataTable As DataSet, company_office As String, user As String)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim loConn As DbConnection
        Dim lcCmd As String

        Try
            loConn = loDb.GetConnection

            lcCmd = "SELECT  [COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",[BARCODE]"
            lcCmd = lcCmd & ",[TYPE_ID]"
            lcCmd = lcCmd & ",[MERK_ID]"
            lcCmd = lcCmd & ",[MODEL_ID]"
            lcCmd = lcCmd & ",[SIZE]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE] "
            lcCmd = lcCmd & "INTO #TEMP "
            lcCmd = lcCmd & "FROM M_ASET (NOLOCK) "
            lcCmd = lcCmd & "WHERE 1 = 0 "

            loDb.SqlExecNonQuery(lcCmd, loConn, False)

            For Each Drr As DataRow In DataTable.Tables(0).Rows
                lcCmd = "INSERT INTO #TEMP ("
                lcCmd = lcCmd & "[COMPANY_OFFICE_ID]"
                lcCmd = lcCmd & ",[BARCODE]"
                lcCmd = lcCmd & ",[TYPE_ID]"
                lcCmd = lcCmd & ",[MERK_ID]"
                lcCmd = lcCmd & ",[MODEL_ID]"
                lcCmd = lcCmd & ",[SIZE]"
                lcCmd = lcCmd & ",[CREA_BY]"
                lcCmd = lcCmd & ",[CREA_DATE]"
                lcCmd = lcCmd & ",[UPD_BY]"
                lcCmd = lcCmd & ",[UPD_DATE]"
                lcCmd = lcCmd & ") VALUES ('"
                lcCmd = lcCmd & company_office & "'"
                lcCmd = lcCmd & ",'" & Drr(0).ToString & "'"
                lcCmd = lcCmd & ",'" & Drr(1).ToString & "'"
                lcCmd = lcCmd & ",'" & Drr(2).ToString & "'"
                lcCmd = lcCmd & ",'" & Drr(3).ToString & "'"
                lcCmd = lcCmd & ",'" & Drr(4).ToString & "'"
                lcCmd = lcCmd & ",'" & user & "'"
                lcCmd = lcCmd & ",GETDATE()"
                lcCmd = lcCmd & ",'" & user & "'"
                lcCmd = lcCmd & ",GETDATE())"

                loDb.SqlExecNonQuery(lcCmd, loConn, False)
            Next

            lcCmd = "MERGE M_ASET AS T "
            lcCmd = lcCmd & "USING #TEMP AS S "
            lcCmd = lcCmd & "ON T.COMPANY_OFFICE_ID = S.COMPANY_OFFICE_ID "
            lcCmd = lcCmd & "AND T.BARCODE = S.BARCODE "
            lcCmd = lcCmd & "WHEN MATCHED THEN "
            lcCmd = lcCmd & "UPDATE SET "
            lcCmd = lcCmd & "T.TYPE_ID = S.TYPE_ID,"
            lcCmd = lcCmd & "T.MERK_ID = S.MERK_ID,"
            lcCmd = lcCmd & "T.MODEL_ID = S.MODEL_ID,"
            lcCmd = lcCmd & "T.SIZE = S.SIZE,"
            lcCmd = lcCmd & "T.UPD_BY = S.UPD_BY,"
            lcCmd = lcCmd & "T.UPD_DATE = S.UPD_DATE "
            lcCmd = lcCmd & "WHEN NOT MATCHED BY TARGET THEN "
            lcCmd = lcCmd & "INSERT ("
            lcCmd = lcCmd & " [COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",[BARCODE]"
            lcCmd = lcCmd & ",[TYPE_ID]"
            lcCmd = lcCmd & ",[MERK_ID]"
            lcCmd = lcCmd & ",[MODEL_ID]"
            lcCmd = lcCmd & ",[SIZE]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE]"
            lcCmd = lcCmd & ") VALUES ("
            lcCmd = lcCmd & "S.COMPANY_OFFICE_ID"
            lcCmd = lcCmd & ",S.BARCODE"
            lcCmd = lcCmd & ",S.TYPE_ID"
            lcCmd = lcCmd & ",S.MERK_ID"
            lcCmd = lcCmd & ",S.MODEL_ID"
            lcCmd = lcCmd & ",S.SIZE"
            lcCmd = lcCmd & ",S.CREA_BY"
            lcCmd = lcCmd & ",GETDATE()"
            lcCmd = lcCmd & ",S.UPD_BY"
            lcCmd = lcCmd & ",GETDATE());"
            'lcCmd = lcCmd & "WHEN NOT MATCHED BY SOURCE "
            'lcCmd = lcCmd & "THEN DELETE;"

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Function getParamDoc(param As String) As List(Of LKM_ParamDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim loConn As DbConnection
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_ParamDTO)

        Try
            loConn = loDb.GetConnection

            lcCmd = "SELECT PARAMETER_VALUE "
            lcCmd = lcCmd & "FROM SYS_PARAMETER "
            lcCmd = lcCmd & "WHERE PARAMETER_CODE = '" & param & "'"

            loReturn = loDb.SQLExecObjectQuery(Of LKM_ParamDTO)(lcCmd, loConn, True)
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ThrowExceptionIfErrors()
    End Function


End Class
