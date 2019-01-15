Imports SC_BackEnd
Imports SC_Common
Imports MTN0100Back
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class MTN0100Cls
    Inherits SC_BusinessObject(Of MTN0100DTO01)

    Protected Overrides Sub SC_Deleting(poEntity As MTN0100DTO01)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection

        Try
            loConn = loDb.GetConnection

            lcCmd = "EXEC MTN0100 'DELETE"
            lcCmd = lcCmd & "','" & poEntity.MAINTENANCE_ID
            lcCmd = lcCmd & "','" & poEntity.COMPANY_ID
            lcCmd = lcCmd & "','" & poEntity.COMPANY_OFFICE_ID
            lcCmd = lcCmd & "','" & Format(poEntity.FROM_DATE, "yyyyMMdd")
            lcCmd = lcCmd & "','" & Format(poEntity.TO_DATE, "yyyyMMdd")
            lcCmd = lcCmd & "','" & poEntity.BARCODE
            lcCmd = lcCmd & "','" & poEntity.OUTLET_ID
            lcCmd = lcCmd & "','" & poEntity.CREA_BY.Trim
            lcCmd = lcCmd & "','" & poEntity.UPD_BY.Trim & "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, False)

            lcCmd = "DELETE FROM T_MAINTENANCE_DETAIL WHERE MAINTENANCE_ID = '" & poEntity.MAINTENANCE_ID & "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, True)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Protected Overrides Function SC_Display(poEntity As MTN0100DTO01, poCRUDMode As eCRUDMode, plWithLock As Boolean) As MTN0100DTO01
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As MTN0100DTO01

        Try
            lcCmd = "SELECT [MAINTENANCE_ID]"
            lcCmd = lcCmd & ",[COMPANY_ID]"
            lcCmd = lcCmd & ",[COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",[FROM_DATE]"
            lcCmd = lcCmd & ",[TO_DATE]"
            lcCmd = lcCmd & ",[BARCODE]"
            lcCmd = lcCmd & ",[OUTLET_ID]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE] "
            lcCmd = lcCmd & "FROM [SIMARC].[dbo].[T_MAINTENANCE]"
            lcCmd = lcCmd & " WHERE MAINTENANCE_ID = '" & poEntity.MAINTENANCE_ID.Trim & "'"

            loReturn = loDb.SQLExecObjectQuery(Of MTN0100DTO01)(lcCmd, loDb.GetConnection, True).FirstOrDefault
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Protected Overrides Sub SC_Saving(poNewEntity As MTN0100DTO01, poOldEntity As MTN0100DTO01, poCRUDMode As eCRUDMode)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection
        Dim loHelper As New SC_Helper
        Dim Kode As String

        Try
            loConn = loDb.GetConnection

            If poCRUDMode = eCRUDMode.AddMode Then

                Kode = Format(poNewEntity.FROM_DATE, "yyMM")
                Kode = "MTN" & Kode & loHelper.SC_GenerateKey(Kode, 3, loConn)
                poNewEntity.MAINTENANCE_ID = Kode

                lcCmd = "SELECT [MAINTENANCE_ID]"
                lcCmd = lcCmd & ",[COMPANY_ID]"
                lcCmd = lcCmd & ",[COMPANY_OFFICE_ID]"
                lcCmd = lcCmd & ",[FROM_DATE]"
                lcCmd = lcCmd & ",[TO_DATE]"
                lcCmd = lcCmd & ",[BARCODE]"
                lcCmd = lcCmd & ",[OUTLET_ID]"
                lcCmd = lcCmd & ",[CREA_BY]"
                lcCmd = lcCmd & ",[CREA_DATE]"
                lcCmd = lcCmd & ",[UPD_BY]"
                lcCmd = lcCmd & ",[UPD_DATE] "
                lcCmd = lcCmd & "FROM [SIMARC].[dbo].[T_MAINTENANCE]"
                lcCmd = lcCmd & " WHERE MAINTENANCE_ID = '" & poNewEntity.MAINTENANCE_ID.Trim & "'"

                If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count > 0 Then
                    loException.Add("Validasi", "Data tidak dapat disimpan. Data Maintenance " & poNewEntity.MAINTENANCE_ID & " sudah ada")
                    Exit Try
                End If

                lcCmd = "EXEC MTN0100 'INSERT"
                lcCmd = lcCmd & "','" & poNewEntity.MAINTENANCE_ID
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_ID
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_OFFICE_ID
                lcCmd = lcCmd & "','" & Format(poNewEntity.FROM_DATE, "yyyyMMdd")
                lcCmd = lcCmd & "','" & Format(poNewEntity.TO_DATE, "yyyyMMdd")
                lcCmd = lcCmd & "','" & poNewEntity.BARCODE
                lcCmd = lcCmd & "','" & poNewEntity.OUTLET_ID
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

            Else

                lcCmd = "EXEC MTN0100 'UPDATE"
                lcCmd = lcCmd & "','" & poNewEntity.MAINTENANCE_ID
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_ID
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_OFFICE_ID
                lcCmd = lcCmd & "','" & Format(poNewEntity.FROM_DATE, "yyyyMMdd")
                lcCmd = lcCmd & "','" & Format(poNewEntity.TO_DATE, "yyyyMMdd")
                lcCmd = lcCmd & "','" & poNewEntity.BARCODE
                lcCmd = lcCmd & "','" & poNewEntity.OUTLET_ID
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

                loDb.SqlExecNonQuery(lcCmd, loConn, False)

                If poNewEntity.MAINTENANCE_ID IsNot Nothing Then

                    lcCmd = "SELECT [MAINTENANCE_ID]"
                    lcCmd = lcCmd & ",[CASE_ID]"
                    lcCmd = lcCmd & ",[GOOD]"
                    lcCmd = lcCmd & ",[MINOR]"
                    lcCmd = lcCmd & ",[MAJOR]"
                    lcCmd = lcCmd & ",[BROKEN]"
                    lcCmd = lcCmd & ",[CREA_BY]"
                    lcCmd = lcCmd & ",[CREA_DATE]"
                    lcCmd = lcCmd & ",[UPD_BY]"
                    lcCmd = lcCmd & ",[UPD_DATE]"
                    lcCmd = lcCmd & " FROM [SIMARC].[dbo].[T_MAINTENANCE_DETAIL] (NOLOCK)"
                    lcCmd = lcCmd & " WHERE MAINTENANCE_ID = '" & poNewEntity.MAINTENANCE_ID & "'"

                    If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count <= 0 Then
                        For Each row In poNewEntity.MAINTENANCE_DETAIL
                            lcCmd = "EXEC MTN110 'INSERT"
                            lcCmd = lcCmd & "','" & poNewEntity.MAINTENANCE_ID
                            lcCmd = lcCmd & "'," & row.CASE_ID
                            lcCmd = lcCmd & "," & row.GOOD
                            lcCmd = lcCmd & "," & row.MINOR
                            lcCmd = lcCmd & "," & row.MAJOR
                            lcCmd = lcCmd & "," & row.BROKEN
                            lcCmd = lcCmd & ",'" & poNewEntity.CREA_BY.Trim
                            lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

                            loDb.SqlExecNonQuery(lcCmd, loConn, True)
                        Next
                    End If

                Else


                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Function getCompany(poParam As List(Of Object)) As List(Of LKM_CompanyDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_CompanyDTO)
        Dim loUser As String

        Try
            loUser = poParam.Item(0)

            lcCmd = "SELECT A.COMPANY_ID, A.COMPANY_NAME "
            lcCmd = lcCmd & "FROM M_COMPANY A (NOLOCK) "
            lcCmd = lcCmd & "JOIN SYS_USER B ON B.COMPANY_ID = A.COMPANY_ID "

            If loUser IsNot Nothing Then
                lcCmd = lcCmd & "WHERE B.USER_ID = '" & loUser & "'"
            End If

            loReturn = loDb.SQLExecObjectQuery(Of LKM_CompanyDTO)(lcCmd, loDb.GetConnection, True)

            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getList(poParam As List(Of Object)) As List(Of MTN0100DTO02)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of MTN0100DTO02)

        Try
            lcCmd = "SELECT [MAINTENANCE_ID]"
            lcCmd = lcCmd & ",[COMPANY_ID]"
            lcCmd = lcCmd & ",[COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",[FROM_DATE]"
            lcCmd = lcCmd & ",[TO_DATE]"
            lcCmd = lcCmd & ",[BARCODE]"
            lcCmd = lcCmd & ",[OUTLET_ID]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE] "
            lcCmd = lcCmd & "FROM [SIMARC].[dbo].[T_MAINTENANCE]"

            loReturn = loDb.SQLExecObjectQuery(Of MTN0100DTO02)(lcCmd, loDb.GetConnection, True)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getList_Detail(poParam As MTN0100DTO01) As List(Of Maintenance_DetailDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of Maintenance_DetailDTO)

        Try
            lcCmd = "SELECT A.[MAINTENANCE_ID]"
            lcCmd = lcCmd & ",A.[CASE_ID]"
            lcCmd = lcCmd & ",B.[CASE_NAME]"
            lcCmd = lcCmd & ",A.[GOOD]"
            lcCmd = lcCmd & ",A.[MINOR]"
            lcCmd = lcCmd & ",A.[MAJOR]"
            lcCmd = lcCmd & ",A.[BROKEN]"
            lcCmd = lcCmd & ",A.[CREA_BY]"
            lcCmd = lcCmd & ",A.[CREA_DATE]"
            lcCmd = lcCmd & ",A.[UPD_BY]"
            lcCmd = lcCmd & ",A.[UPD_DATE] "
            lcCmd = lcCmd & "FROM [SIMARC].[dbo].[T_MAINTENANCE_DETAIL] A (NOLOCK) "
            lcCmd = lcCmd & "JOIN M_CASE B ON A.CASE_ID = B.CASE_ID "
            lcCmd = lcCmd & "WHERE A.MAINTENANCE_ID = '" & poParam.MAINTENANCE_ID & "'"

            loReturn = loDb.SQLExecObjectQuery(Of Maintenance_DetailDTO)(lcCmd, loDb.GetConnection, True)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getOffice(poParam As List(Of Object)) As List(Of LKM_CompanyOfficeDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_CompanyOfficeDTO)
        Dim loUser As String

        Try
            loUser = poParam.Item(0)

            lcCmd = "SELECT A.COMPANY_OFFICE_ID, A.COMPANY_OFFICE "
            lcCmd = lcCmd & "FROM M_COMPANY_OFFICE A (NOLOCK) "
            lcCmd = lcCmd & "JOIN M_COMPANY_OFFICE_MAP B (NOLOCK) ON A.COMPANY_OFFICE_ID = B.COMPANY_OFFICE_ID "
            lcCmd = lcCmd & "JOIN SYS_USER C (NOLOCK) ON B.COMPANY_OFFICE_MAP_ID = C.COMPANY_OFFICE_MAP_ID "

            If loUser IsNot Nothing Then
                lcCmd = lcCmd & "WHERE C.USER_ID = '" & loUser & "'"
            End If

            loReturn = loDb.SQLExecObjectQuery(Of LKM_CompanyOfficeDTO)(lcCmd, loDb.GetConnection, True)

            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

End Class
