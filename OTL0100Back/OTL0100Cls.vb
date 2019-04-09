Imports SC_BackEnd
Imports SC_Common
Imports System.Data.Common
Imports System.Data.SqlClient
Public Class OTL0100Cls

    Function getCompany(poparam As List(Of Object)) As List(Of LKM_CompanyOfficeDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loCompanyOffice As String
        Dim Company() As String
        Dim loReturn As List(Of LKM_CompanyOfficeDTO)

        Try
            loCompanyOffice = poparam.Item(0)

            lcCmd = "SELECT DISTINCT COMPANY_OFFICE, COMPANY_OFFICE_ID "
            lcCmd = lcCmd & "FROM SIMARC.DBO.M_COMPANY_OFFICE (NOLOCK)"

            If loCompanyOffice IsNot Nothing And Right(loCompanyOffice, 2) <> "HO" Then
                lcCmd = lcCmd & " WHERE COMPANY_OFFICE_ID = '" & loCompanyOffice & "'"
            Else
                Company = Split(loCompanyOffice, ".")
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
        Dim loCmd As DbCommand

        Try
            loConn = loDb.GetConnection
            loCmd = loDb.GetCommand

            lcCmd = "SELECT [COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",[OUTLET_ID]"
            lcCmd = lcCmd & ",[OUTLET_NAME]"
            lcCmd = lcCmd & ",[OUTLET_ADDRESS]"
            lcCmd = lcCmd & ",[OUTLET_PHONE]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE] "
            lcCmd = lcCmd & "INTO #TEMP "
            lcCmd = lcCmd & "FROM M_OUTLET (NOLOCK) "
            lcCmd = lcCmd & "WHERE 1 = 0 "

            loDb.SqlExecNonQuery(lcCmd, loConn, False)

            For Each Drr As DataRow In DataTable.Tables(0).Rows
                lcCmd = "INSERT INTO #TEMP ("
                lcCmd = lcCmd & "[COMPANY_OFFICE_ID]"
                lcCmd = lcCmd & ",[OUTLET_ID]"
                lcCmd = lcCmd & ",[OUTLET_NAME]"
                lcCmd = lcCmd & ",[OUTLET_ADDRESS]"
                lcCmd = lcCmd & ",[OUTLET_PHONE]"
                lcCmd = lcCmd & ",[CREA_BY]"
                lcCmd = lcCmd & ",[CREA_DATE]"
                lcCmd = lcCmd & ",[UPD_BY]"
                lcCmd = lcCmd & ",[UPD_DATE]"
                lcCmd = lcCmd & ") VALUES ('"
                lcCmd = lcCmd & company_office & "'"
                lcCmd = lcCmd & ",'" & Right(Drr(0).ToString, 8) & "'"
                lcCmd = lcCmd & ",'" & Replace(Drr(1).ToString, "'", "''") & "'"
                lcCmd = lcCmd & ",'" & Replace(Drr(2).ToString, "'", "''") & "'"
                lcCmd = lcCmd & ",'" & Drr(3).ToString & "'"
                lcCmd = lcCmd & ",'" & user & "'"
                lcCmd = lcCmd & ",GETDATE()"
                lcCmd = lcCmd & ",'" & user & "'"
                lcCmd = lcCmd & ",GETDATE())"

                loDb.SqlExecNonQuery(lcCmd, loConn, False)
            Next

            lcCmd = "MERGE M_OUTLET AS T "
            lcCmd = lcCmd & "USING #TEMP AS S "
            lcCmd = lcCmd & "ON T.COMPANY_OFFICE_ID = S.COMPANY_OFFICE_ID "
            lcCmd = lcCmd & "AND T.OUTLET_ID = S.OUTLET_ID "
            lcCmd = lcCmd & "WHEN MATCHED THEN "
            lcCmd = lcCmd & "UPDATE SET "
            lcCmd = lcCmd & "T.OUTLET_NAME = S.OUTLET_NAME,"
            lcCmd = lcCmd & "T.OUTLET_ADDRESS = S.OUTLET_ADDRESS,"
            lcCmd = lcCmd & "T.OUTLET_PHONE = S.OUTLET_PHONE,"
            lcCmd = lcCmd & "T.UPD_BY = S.UPD_BY,"
            lcCmd = lcCmd & "T.UPD_DATE = S.UPD_DATE "
            lcCmd = lcCmd & "WHEN NOT MATCHED BY TARGET THEN "
            lcCmd = lcCmd & "INSERT ("
            lcCmd = lcCmd & "[COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",[OUTLET_ID]"
            lcCmd = lcCmd & ",[OUTLET_NAME]"
            lcCmd = lcCmd & ",[OUTLET_ADDRESS]"
            lcCmd = lcCmd & ",[OUTLET_PHONE]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE]"
            lcCmd = lcCmd & ") VALUES ("
            lcCmd = lcCmd & "S.COMPANY_OFFICE_ID,"
            lcCmd = lcCmd & "S.OUTLET_ID,"
            lcCmd = lcCmd & "S.OUTLET_NAME,"
            lcCmd = lcCmd & "S.OUTLET_ADDRESS,"
            lcCmd = lcCmd & "S.OUTLET_PHONE,"
            lcCmd = lcCmd & "S.CREA_BY,"
            lcCmd = lcCmd & "GETDATE(),"
            lcCmd = lcCmd & "S.UPD_BY,"
            lcCmd = lcCmd & "GETDATE()); "
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
