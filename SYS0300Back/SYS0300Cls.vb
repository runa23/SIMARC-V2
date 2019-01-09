Imports SC_Common
Imports SC_BackEnd
Imports System.Data.Common
Imports System.Data.SqlClient
Public Class SYS0300Cls
    Inherits SC_BusinessObject(Of SYS0300DTO01)
    Protected Overrides Sub SC_Deleting(poEntity As SYS0300DTO01)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection

        Try
            loConn = loDb.GetConnection

            lcCmd = "EXEC SYS0300 'DELETE"
            lcCmd = lcCmd & "','" & poEntity.APP_ID
            lcCmd = lcCmd & "','" & poEntity.APP_GROUP_ID
            lcCmd = lcCmd & "','" & poEntity.MODULE_ID
            lcCmd = lcCmd & "','" & poEntity.VERSION
            lcCmd = lcCmd & "','" & poEntity.APP_NAME
            lcCmd = lcCmd & "','" & poEntity.APP_DESC
            lcCmd = lcCmd & "','" & poEntity.APP_TYPE
            lcCmd = lcCmd & "','" & poEntity.CREA_BY.Trim
            lcCmd = lcCmd & "','" & poEntity.UPD_BY.Trim & "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Protected Overrides Function SC_Display(poEntity As SYS0300DTO01, poCRUDMode As eCRUDMode, plWithLock As Boolean) As SYS0300DTO01
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As SYS0300DTO01

        Try
            lcCmd = "Select [APP_ID]"
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
            lcCmd = lcCmd & " WHERE APP_ID = '" & poEntity.APP_ID & "'"

            loReturn = loDb.SQLExecObjectQuery(Of SYS0300DTO01)(lcCmd, loDb.GetConnection, True).FirstOrDefault
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Protected Overrides Sub SC_Saving(poNewEntity As SYS0300DTO01, poOldEntity As SYS0300DTO01, poCRUDMode As eCRUDMode)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loConn As DbConnection
        Dim lcPathDll As String

        Try
            loConn = loDb.GetConnection

            If poCRUDMode = eCRUDMode.AddMode Then
                lcCmd = "Select [APP_ID]"
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
                lcCmd = lcCmd & " WHERE APP_ID = '" & poNewEntity.APP_ID & "'"

                If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count > 0 Then
                    loException.Add("Validasi", "Data tidak dapat disimpan. Data Group Application " & poNewEntity.APP_ID & " sudah ada")
                    Exit Try
                End If

                lcCmd = "EXEC SYS0300 'INSERT"
                lcCmd = lcCmd & "','" & poNewEntity.APP_ID
                lcCmd = lcCmd & "','" & poNewEntity.APP_GROUP_ID
                lcCmd = lcCmd & "','" & poNewEntity.MODULE_ID
                lcCmd = lcCmd & "','" & poNewEntity.VERSION
                lcCmd = lcCmd & "','" & poNewEntity.APP_NAME
                lcCmd = lcCmd & "','" & poNewEntity.APP_DESC
                lcCmd = lcCmd & "','" & poNewEntity.APP_TYPE
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

            Else

                lcCmd = "EXEC SYS0300 'UPDATE"
                lcCmd = lcCmd & "','" & poNewEntity.APP_ID
                lcCmd = lcCmd & "','" & poNewEntity.APP_GROUP_ID
                lcCmd = lcCmd & "','" & poNewEntity.MODULE_ID
                lcCmd = lcCmd & "','" & poNewEntity.VERSION
                lcCmd = lcCmd & "','" & poNewEntity.APP_NAME
                lcCmd = lcCmd & "','" & poNewEntity.APP_DESC
                lcCmd = lcCmd & "','" & poNewEntity.APP_TYPE
                lcCmd = lcCmd & "','" & poNewEntity.CREA_BY.Trim
                lcCmd = lcCmd & "','" & poNewEntity.UPD_BY.Trim & "'"

            End If

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

            If poNewEntity.UPDATE_DLL_FILE AndAlso poNewEntity.DLL_FILE IsNot Nothing Then
                lcCmd = "Update SYS_APP set"
                lcCmd = lcCmd & " VERSION = '" & poNewEntity.DLL_FILE_VERSION.Trim & "'"
                lcCmd = lcCmd & " where APP_ID = '" & poNewEntity.APP_ID.Trim & "'"
                loDb.SqlExecNonQuery(lcCmd, loConn, False)

                'lcPathDll = My.Application.Info.DirectoryPath & "\dll\"
                lcPathDll = System.Configuration.ConfigurationManager.AppSettings("AppDllPath")
                SC_Utility.ConvertByteToFile(lcPathDll & poNewEntity.APP_ID & ".dll", poNewEntity.DLL_FILE)
            End If

            loConn.Close()
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Function getList(poparam As List(Of Object)) As List(Of SYS0300DTO02)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of SYS0300DTO02)

        Try
            lcCmd = "Select [APP_ID]"
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

            loReturn = loDb.SQLExecObjectQuery(Of SYS0300DTO02)(lcCmd, loDb.GetConnection, True)
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getModule() As List(Of LKM_SysModuleDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_SysModuleDTO)

        Try
            lcCmd = "Select [MODULE_ID]"
            lcCmd = lcCmd & ",[MODULE_NAME]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_MODULE] (NOLOCK)"

            loReturn = loDb.SQLExecObjectQuery(Of LKM_SysModuleDTO)(lcCmd, loDb.GetConnection, True)
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getAppGroup() As List(Of LKM_SysAppGroupDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_SysAppGroupDTO)

        Try
            lcCmd = "Select [APP_GROUP_ID]"
            lcCmd = lcCmd & ",[APP_GROUP_NAME]"
            lcCmd = lcCmd & " FROM [SIMARC].[dbo].[SYS_APP_GROUP] (NOLOCK)"

            loReturn = loDb.SQLExecObjectQuery(Of LKM_SysAppGroupDTO)(lcCmd, loDb.GetConnection, True)
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

    Function getAppType() As List(Of LKM_SysAppTypeDTO)
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of LKM_SysAppTypeDTO)

        Try
            lcCmd = "SELECT PARAMETER_VALUE"
            lcCmd = lcCmd & " FROM SYS_PARAMETER"
            lcCmd = lcCmd & " WHERE PARAMETER = 'SYS_APP'"

            loReturn = loDb.SQLExecObjectQuery(Of LKM_SysAppTypeDTO)(lcCmd, loDb.GetConnection, True)
            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Function

End Class
