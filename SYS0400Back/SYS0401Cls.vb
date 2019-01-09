Imports SC_BackEnd
Imports SC_Common
Imports System.Data.Common
Imports System.Data.SqlClient
Public Class SYS0401Cls
    Inherits SC_BusinessObject(Of SYS0401DTO01)
    Protected Overrides Sub SC_Deleting(poEntity As SYS0401DTO01)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection

        Try
            loConn = loDb.GetConnection

            lcCmd = "EXEC SYS0410 'DELETE"
            lcCmd = lcCmd & "','" & poEntity.APP_ID
            lcCmd = lcCmd & "','" & poEntity.ROLE_ID
            lcCmd = lcCmd & "'," & poEntity.ADD_PERMIT
            lcCmd = lcCmd & "," & poEntity.EDIT_PERMIT
            lcCmd = lcCmd & "," & poEntity.DELETE_PERMIT
            lcCmd = lcCmd & "," & poEntity.READ_PERMIT
            lcCmd = lcCmd & ",'" & poEntity.CREA_BY.Trim
            lcCmd = lcCmd & "','" & poEntity.UPD_BY.Trim & "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Protected Overrides Function SC_Display(poEntity As SYS0401DTO01, poCRUDMode As eCRUDMode, plWithLock As Boolean) As SYS0401DTO01
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As SYS0401DTO01

        Try
            lcCmd = "SELECT A.[APP_ID]"
            lcCmd = lcCmd & ",B.[APP_NAME]"
            lcCmd = lcCmd & ",A.[ROLE_ID]"
            lcCmd = lcCmd & ",A.[ADD_PERMIT]"
            lcCmd = lcCmd & ",A.[EDIT_PERMIT]"
            lcCmd = lcCmd & ",A.[DELETE_PERMIT]"
            lcCmd = lcCmd & ",A.[READ_PERMIT]"
            lcCmd = lcCmd & ",A.[CREA_BY]"
            lcCmd = lcCmd & ",A.[CREA_DATE]"
            lcCmd = lcCmd & ",A.[UPD_BY]"
            lcCmd = lcCmd & ",A.[UPD_DATE]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_ROLE_APP] A (NOLOCK)"
            lcCmd = lcCmd & " INNER JOIN SYS_APP B (NOLOCK)"
            lcCmd = lcCmd & " ON A.APP_ID = B.APP_ID"
            lcCmd = lcCmd & " WHERE A.APP_ID = '" & poEntity.APP_ID & "'"
            lcCmd = lcCmd & " AND A.ROLE_ID = '" & poEntity.ROLE_ID & "'"

            loReturn = loDb.SQLExecObjectQuery(Of SYS0401DTO01)(lcCmd, loDb.GetConnection, True).FirstOrDefault
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Protected Overrides Sub SC_Saving(poNewEntity As SYS0401DTO01, poOldEntity As SYS0401DTO01, poCRUDMode As eCRUDMode)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection

        Try
            loConn = loDb.GetConnection

            If poCRUDMode = eCRUDMode.AddMode Then
                lcCmd = "SELECT [APP_ID]"
                lcCmd = lcCmd & ",[ROLE_ID]"
                lcCmd = lcCmd & ",[ADD_PERMIT]"
                lcCmd = lcCmd & ",[EDIT_PERMIT]"
                lcCmd = lcCmd & ",[DELETE_PERMIT]"
                lcCmd = lcCmd & ",[READ_PERMIT]"
                lcCmd = lcCmd & ",[CREA_BY]"
                lcCmd = lcCmd & ",[CREA_DATE]"
                lcCmd = lcCmd & ",[UPD_BY]"
                lcCmd = lcCmd & ",[UPD_DATE]"
                lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_ROLE_APP] (NOLOCK)"
                lcCmd = lcCmd & " WHERE APP_ID = '" & poNewEntity.APP_ID & "'"
                lcCmd = lcCmd & " AND ROLE_ID = '" & poNewEntity.ROLE_ID & "'"

                If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count > 0 Then
                    loException.Add("Validasi", "Data tidak dapat disimpan. Data Role " & poNewEntity.ROLE_ID & " dan " _
                                    & poNewEntity.APP_ID & " sudah ada")
                    Exit Try
                End If

                lcCmd = "EXEC SYS0410 'INSERT"
                lcCmd = lcCmd & "','" & poNewEntity.APP_ID
                lcCmd = lcCmd & "','" & poNewEntity.ROLE_ID
                lcCmd = lcCmd & "'," & poNewEntity.ADD_PERMIT
                lcCmd = lcCmd & "," & poNewEntity.EDIT_PERMIT
                lcCmd = lcCmd & "," & poNewEntity.DELETE_PERMIT
                lcCmd = lcCmd & "," & poNewEntity.READ_PERMIT
                lcCmd = lcCmd & ",'" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

            Else

                lcCmd = "EXEC SYS0410 'UPDATE"
                lcCmd = lcCmd & "','" & poNewEntity.APP_ID
                lcCmd = lcCmd & "','" & poNewEntity.ROLE_ID
                lcCmd = lcCmd & "'," & poNewEntity.ADD_PERMIT
                lcCmd = lcCmd & "," & poNewEntity.EDIT_PERMIT
                lcCmd = lcCmd & "," & poNewEntity.DELETE_PERMIT
                lcCmd = lcCmd & "," & poNewEntity.READ_PERMIT
                lcCmd = lcCmd & ",'" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

            End If

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Function getList(RoleID As String) As List(Of SYS0401DTO02)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loList As List(Of SYS0401DTO02)

        Try
            lcCmd = "SELECT A.[APP_ID]"
            lcCmd = lcCmd & ",B.[APP_NAME]"
            lcCmd = lcCmd & ",A.[ROLE_ID]"
            lcCmd = lcCmd & ",A.[ADD_PERMIT]"
            lcCmd = lcCmd & ",A.[EDIT_PERMIT]"
            lcCmd = lcCmd & ",A.[DELETE_PERMIT]"
            lcCmd = lcCmd & ",A.[READ_PERMIT]"
            lcCmd = lcCmd & ",A.[CREA_BY]"
            lcCmd = lcCmd & ",A.[CREA_DATE]"
            lcCmd = lcCmd & ",A.[UPD_BY]"
            lcCmd = lcCmd & ",A.[UPD_DATE]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_ROLE_APP] A (NOLOCK)"
            lcCmd = lcCmd & " INNER JOIN SYS_APP B (NOLOCK)"
            lcCmd = lcCmd & " ON A.APP_ID = B.APP_ID"
            lcCmd = lcCmd & " WHERE ROLE_ID = '" & RoleID & "'"

            loList = loDb.SQLExecObjectQuery(Of SYS0401DTO02)(lcCmd, loDb.GetConnection, True)

            Return loList
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ThrowExceptionIfErrors()
    End Function

    Function GetList_App(RoleID As String) As List(Of LKMSys_AppDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loList As List(Of LKMSys_AppDTO)

        Try
            lcCmd = "SELECT [APP_ID]"
            lcCmd = lcCmd & ",[APP_GROUP_ID]"
            lcCmd = lcCmd & ",[MODULE_ID]"
            lcCmd = lcCmd & ",[VERSION]"
            lcCmd = lcCmd & ",[APP_NAME]"
            lcCmd = lcCmd & ",[APP_DESC]"
            lcCmd = lcCmd & ",[APP_TYPE]"
            lcCmd = lcCmd & ",[CREA_BY]"
            lcCmd = lcCmd & ",[CREA_DATE]"
            lcCmd = lcCmd & ",[UPD_BY]"
            lcCmd = lcCmd & ",[UPD_DATE]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_APP] (NOLOCK)"
            lcCmd = lcCmd & " WHERE APP_ID NOT IN ("
            lcCmd = lcCmd & " SELECT APP_ID FROM SYS_ROLE_APP X (NOLOCK)"
            lcCmd = lcCmd & " WHERE X.ROLE_ID ='" & RoleID & "')"

            loList = loDb.SQLExecObjectQuery(Of LKMSys_AppDTO)(lcCmd, loDb.GetConnection, True)

            Return loList
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ThrowExceptionIfErrors()
    End Function

End Class
