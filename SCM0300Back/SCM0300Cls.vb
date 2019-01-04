Imports SC_BackEnd
Imports SC_Common
Imports System.Data.Common
Imports System.Data.SqlClient
Public Class SCM0300Cls
    Inherits SC_BusinessObject(Of SCM0300DTO01)

    Protected Overrides Sub SC_Deleting(poEntity As SCM0300DTO01)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection

        Try
            loConn = loDb.GetConnection

            lcCmd = "EXEC SCM0300 'DELETE"
            lcCmd = lcCmd & "','" & poEntity.COMPANY_OFFICE_ID
            lcCmd = lcCmd & "','" & poEntity.COMPANY_OFFICE
            lcCmd = lcCmd & "','" & poEntity.COMPANY_ID
            lcCmd = lcCmd & "','" & poEntity.CREA_BY.Trim
            lcCmd = lcCmd & "','" & poEntity.UPD_BY.Trim & "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Protected Overrides Function SC_Display(poEntity As SCM0300DTO01, poCRUDMode As eCRUDMode, plWithLock As Boolean) As SCM0300DTO01
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As SCM0300DTO01

        Try
            lcCmd = "SELECT [COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",[COMPANY_OFFICE]"
            lcCmd = lcCmd & ",[COMPANY_ID]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[M_COMPANY_OFFICE] (NOLOCK)"
            lcCmd = lcCmd & " WHERE COMPANY_OFFICE_ID = '" & poEntity.COMPANY_OFFICE_ID.Trim & "'"

            loReturn = loDb.SQLExecObjectQuery(Of SCM0300DTO01)(lcCmd, loDb.GetConnection, True).FirstOrDefault
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Protected Overrides Sub SC_Saving(poNewEntity As SCM0300DTO01, poOldEntity As SCM0300DTO01, poCRUDMode As eCRUDMode)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection
        Dim loHelper As New SC_Helper
        Dim loCmd As DbCommand

        Try
            loConn = loDb.GetConnection
            loCmd = loDb.GetCommand

            If poCRUDMode = eCRUDMode.AddMode Then
                lcCmd = "SELECT [COMPANY_OFFICE_ID]"
                lcCmd = lcCmd & ",[COMPANY_OFFICE]"
                lcCmd = lcCmd & ",[COMPANY_ID]"
                lcCmd = lcCmd & ",[CREA_BY]"
                lcCmd = lcCmd & ",[CREA_DATE]"
                lcCmd = lcCmd & ",[UPD_BY]"
                lcCmd = lcCmd & ",[UPD_DATE]"
                lcCmd = lcCmd & " FROM [SIMARC].[dbo].[M_COMPANY_OFFICE] (NOLOCK)"
                lcCmd = lcCmd & " WHERE COMPANY_OFFICE_ID = '" & poNewEntity.COMPANY_OFFICE_ID.Trim & "'"

                If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count > 0 Then
                    loException.Add("Validasi", "Data tidak dapat disimpan. Data Company Office " & poNewEntity.COMPANY_OFFICE_ID & " sudah ada")
                    Exit Try
                End If

                lcCmd = "EXEC SCM0300 'INSERT"
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_OFFICE_ID
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_OFFICE
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_ID
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

            Else

                lcCmd = "EXEC SCM0300 'UPDATE"
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_OFFICE_ID
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_OFFICE
                lcCmd = lcCmd & "','" & poNewEntity.COMPANY_ID
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

            End If

            loDb.SqlExecNonQuery(lcCmd, loConn, True)


        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Function getList(poparam As List(Of Object)) As List(Of SCM0300DTO02)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of SCM0300DTO02)

        Try
            lcCmd = "SELECT [COMPANY_OFFICE_ID]"
            lcCmd = lcCmd & ",[COMPANY_OFFICE]"
            lcCmd = lcCmd & ",[COMPANY_ID]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[M_COMPANY_OFFICE] (NOLOCK)"

            loReturn = loDb.SQLExecObjectQuery(Of SCM0300DTO02)(lcCmd, loDb.GetConnection, True)
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getCompany() As List(Of LKM_CompanyDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_CompanyDTO)

        Try
            lcCmd = "SELECT [COMPANY_ID]"
            lcCmd = lcCmd & ",[COMPANY_NAME]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[M_COMPANY] (NOLOCK)"

            loReturn = loDb.SQLExecObjectQuery(Of LKM_CompanyDTO)(lcCmd, loDb.GetConnection, True)
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

End Class
