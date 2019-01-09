Imports SC_BackEnd
Imports SC_Common
Imports System.Data.Common
Imports System.Data.SqlClient
Public Class SYS0200Cls
    Inherits SC_BusinessObject(Of SYS0200DTO01)

    Protected Overrides Sub SC_Deleting(poEntity As SYS0200DTO01)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection

        Try
            loConn = loDb.GetConnection

            lcCmd = "EXEC SYS0200 'DELETE"
            lcCmd = lcCmd & "','" & poEntity.MODULE_ID
            lcCmd = lcCmd & "','" & poEntity.MODULE_NAME
            lcCmd = lcCmd & "','" & poEntity.CREA_BY.Trim
            lcCmd = lcCmd & "','" & poEntity.UPD_BY.Trim & "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Protected Overrides Function SC_Display(poEntity As SYS0200DTO01, poCRUDMode As eCRUDMode, plWithLock As Boolean) As SYS0200DTO01
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As SYS0200DTO01

        Try
            lcCmd = "Select [MODULE_ID]"
            lcCmd = lcCmd & ",[MODULE_NAME]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_MODULE] (NOLOCK)"
            lcCmd = lcCmd & " WHERE MODULE_ID = '" & poEntity.MODULE_ID & "'"

            loReturn = loDb.SQLExecObjectQuery(Of SYS0200DTO01)(lcCmd, loDb.GetConnection, True).FirstOrDefault
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Protected Overrides Sub SC_Saving(poNewEntity As SYS0200DTO01, poOldEntity As SYS0200DTO01, poCRUDMode As eCRUDMode)
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
                lcCmd = "Select [MODULE_ID]"
                lcCmd = lcCmd & ",[MODULE_NAME]"
                lcCmd = lcCmd & ",[CREA_BY]"
                lcCmd = lcCmd & ",[CREA_DATE]"
                lcCmd = lcCmd & ",[UPD_BY]"
                lcCmd = lcCmd & ",[UPD_DATE]"
                lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_MODULE] (NOLOCK)"
                lcCmd = lcCmd & " WHERE MODULE_ID = '" & poNewEntity.MODULE_ID & "'"

                If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count > 0 Then
                    loException.Add("Validasi", "Data tidak dapat disimpan. Data Group Application " & poNewEntity.MODULE_ID & " sudah ada")
                    Exit Try
                End If

                lcCmd = "EXEC SYS0200 'INSERT"
                lcCmd = lcCmd & "','" & poNewEntity.MODULE_ID
                lcCmd = lcCmd & "','" & poNewEntity.MODULE_NAME
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

            Else

                lcCmd = "EXEC SYS0200 'UPDATE"
                lcCmd = lcCmd & "','" & poNewEntity.MODULE_ID
                lcCmd = lcCmd & "','" & poNewEntity.MODULE_NAME
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

            End If

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Function getList(poparam As List(Of Object)) As List(Of SYS0200DTO02)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of SYS0200DTO02)

        Try
            lcCmd = "Select [MODULE_ID]"
            lcCmd = lcCmd & ",[MODULE_NAME]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_MODULE] (NOLOCK)"

            loReturn = loDb.SQLExecObjectQuery(Of SYS0200DTO02)(lcCmd, loDb.GetConnection, True)
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

End Class
