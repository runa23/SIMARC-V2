Imports SC_BackEnd
Imports SC_Common
Imports System.Data.Common
Imports System.Data.SqlClient
Public Class SYS0501Cls
    Inherits SC_BusinessObject(Of SYS0501DTO01)

    Protected Overrides Sub SC_Deleting(poEntity As SYS0501DTO01)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection

        Try
            loConn = loDb.GetConnection

            lcCmd = "EXEC SYS0500 'DELETE"
            lcCmd = lcCmd & "','" & poEntity.USER_ID
            lcCmd = lcCmd & "','" & poEntity.ROLE_ID
            lcCmd = lcCmd & "','" & poEntity.CREA_BY.Trim
            lcCmd = lcCmd & "','" & poEntity.UPD_BY.Trim & "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, True)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Protected Overrides Function SC_Display(poEntity As SYS0501DTO01, poCRUDMode As eCRUDMode, plWithLock As Boolean) As SYS0501DTO01
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As SYS0501DTO01

        Try
            lcCmd = "SELECT [USER_ID]"
            lcCmd = lcCmd & ",[ROLE_ID]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_USER_ROLE] (NOLOCK)"
            lcCmd = lcCmd & " WHERE USER_ID = '" & poEntity.USER_ID & "'"
            lcCmd = lcCmd & " AND ROLE_ID = '" & poEntity.ROLE_ID & "'"

            loReturn = loDb.SQLExecObjectQuery(Of SYS0501DTO01)(lcCmd, loDb.GetConnection, True).FirstOrDefault
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Protected Overrides Sub SC_Saving(poNewEntity As SYS0501DTO01, poOldEntity As SYS0501DTO01, poCRUDMode As eCRUDMode)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection

        Try
            loConn = loDb.GetConnection

            If poCRUDMode = eCRUDMode.AddMode Then
                lcCmd = "SELECT [USER_ID]"
                lcCmd = lcCmd & ",[ROLE_ID]"
                lcCmd = lcCmd & ",[CREA_BY]"
                lcCmd = lcCmd & ",[CREA_DATE]"
                lcCmd = lcCmd & ",[UPD_BY]"
                lcCmd = lcCmd & ",[UPD_DATE]"
                lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_USER_ROLE] (NOLOCK)"
                lcCmd = lcCmd & " WHERE USER_ID = '" & poNewEntity.USER_ID & "'"
                lcCmd = lcCmd & " AND ROLE_ID = '" & poNewEntity.ROLE_ID & "'"

                If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count > 0 Then
                    loException.Add("Validasi", "Data tidak dapat disimpan. Data Role User " & poNewEntity.USER_ID & " sudah ada")
                    Exit Try
                End If

                lcCmd = "EXEC SYS0500 'DELETE"
                lcCmd = lcCmd & "','" & poNewEntity.USER_ID
                lcCmd = lcCmd & "','" & poNewEntity.ROLE_ID
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

                loDb.SqlExecNonQuery(lcCmd, loConn, True)

                loConn.Close()
            End If
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Function getList(poparam As String) As List(Of SYS0501DTO02)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of SYS0501DTO02)

        Try
            lcCmd = "SELECT A.USER_ID"
            lcCmd = lcCmd & ",B.ROLE_ID"
            lcCmd = lcCmd & ",B.crea_by"
            lcCmd = lcCmd & ",B.crea_date"
            lcCmd = lcCmd & ",B.upd_date"
            lcCmd = lcCmd & ",B.upd_by"
            lcCmd = lcCmd & " FROM SYS_USER A (NOLOCK)"
            lcCmd = lcCmd & " INNER JOIN SYS_USER_ROLE B ON A.USER_ID = B.USER_ID"
            lcCmd = lcCmd & " INNER JOIN SYS_ROLE C ON B.ROLE_ID = C.ROLE_ID"
            lcCmd = lcCmd & " WHERE B.ROLE_ID = '" & poparam & "'"

            loReturn = loDb.SQLExecObjectQuery(Of SYS0501DTO02)(lcCmd, loDb.GetConnection, True)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getRole() As List(Of LKM_RoleDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_RoleDTO)

        Try
            lcCmd = "SELECT [USER_ID]"
            lcCmd = lcCmd & ",[ROLE_ID]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_USER_ROLE] (NOLOCK)"

            loReturn = loDb.SQLExecObjectQuery(Of LKM_RoleDTO)(lcCmd, loDb.GetConnection, True)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

End Class
