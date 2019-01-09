Imports SC_BackEnd
Imports SC_Common
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class SYS0400Cls
    Inherits SC_BusinessObject(Of SYS0400DTO01)

    Protected Overrides Sub SC_Deleting(poEntity As SYS0400DTO01)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection

        Try
            loConn = loDb.GetConnection

            lcCmd = "EXEC SYS0400 'DELETE"
            lcCmd = lcCmd & "','" & poEntity.ROLE_ID
            lcCmd = lcCmd & "','" & poEntity.ROLE_NAME
            lcCmd = lcCmd & "','" & poEntity.CREA_BY.Trim
            lcCmd = lcCmd & "','" & poEntity.UPD_BY.Trim & "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Protected Overrides Function SC_Display(poEntity As SYS0400DTO01, poCRUDMode As eCRUDMode, plWithLock As Boolean) As SYS0400DTO01
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As SYS0400DTO01

        Try
            lcCmd = "SELECT [ROLE_ID]"
            lcCmd = lcCmd & ",[ROLE_NAME]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_ROLE] (NOLOCK)"
            lcCmd = lcCmd & " WHERE ROLE_ID = '" & poEntity.ROLE_ID & "'"

            loReturn = loDb.SQLExecObjectQuery(Of SYS0400DTO01)(lcCmd, loDb.GetConnection, True).FirstOrDefault
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Protected Overrides Sub SC_Saving(poNewEntity As SYS0400DTO01, poOldEntity As SYS0400DTO01, poCRUDMode As eCRUDMode)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection

        Try
            loConn = loDb.GetConnection

            If poCRUDMode = eCRUDMode.AddMode Then
                lcCmd = "SELECT [ROLE_ID]"
                lcCmd = lcCmd & ",[ROLE_NAME]"
                lcCmd = lcCmd & ",[CREA_BY]"
                lcCmd = lcCmd & ",[CREA_DATE]"
                lcCmd = lcCmd & ",[UPD_BY]"
                lcCmd = lcCmd & ",[UPD_DATE]"
                lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_ROLE] (NOLOCK)"
                lcCmd = lcCmd & " WHERE ROLE_ID = '" & poNewEntity.ROLE_ID & "'"

                If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count > 0 Then
                    loException.Add("Validasi", "Data tidak dapat disimpan. Data Role " & poNewEntity.ROLE_ID & " sudah ada")
                    Exit Try
                End If

                lcCmd = "EXEC SYS0400 'INSERT"
                lcCmd = lcCmd & "','" & poNewEntity.ROLE_ID
                lcCmd = lcCmd & "','" & poNewEntity.ROLE_NAME
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

            Else

                lcCmd = "EXEC SYS0400 'UPDATE"
                lcCmd = lcCmd & "','" & poNewEntity.ROLE_ID
                lcCmd = lcCmd & "','" & poNewEntity.ROLE_NAME
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

            End If

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Function getList(poparam As List(Of Object)) As List(Of SYS0400DTO02)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of SYS0400DTO02)

        Try
            lcCmd = "SELECT [ROLE_ID]"
            lcCmd = lcCmd & ",[ROLE_NAME]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_ROLE] (NOLOCK)"

            loReturn = loDb.SQLExecObjectQuery(Of SYS0400DTO02)(lcCmd, loDb.GetConnection, True)
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

End Class
