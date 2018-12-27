Imports SC_BackEnd
Imports SC_Common
Imports System.Data.Common
Imports System.IO
' NOTE: You can use the "Rename" command on the context menu to change the class name "SCMenuSvc" in code, svc and config file together.
Public Class SCMenuSvc
    Implements ISCMenuSvc
    Public Function AppDllLatestVersion(pcAppId As String) As String Implements ISCMenuSvc.AppDllLatestVersion
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String

        Try
            lcCmd = "select a.version "
            lcCmd = lcCmd + "from sys_app a  (nolock) "
            lcCmd = lcCmd + "where app_id='" + pcAppId.Trim + "'"

            Return loDb.SqlExecQuery(lcCmd, loDb.GetConnection, True).Rows(0)(0).ToString
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ThrowExceptionIfErrors()
    End Function

    Public Sub ChangePassword(pcUserId As String, pcOldPassword As String, pcNewPassword As String) Implements ISCMenuSvc.ChangePassword
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim lcEncryptPassword As String
        Dim loConn As DbConnection
        Try

            loConn = loDb.GetConnection

            lcEncryptPassword = SC_Utility.Encrypt(pcUserId, pcOldPassword)

            lcCmd = "SELECT USER_ID "
            lcCmd = lcCmd + "FROM SYS_USER (nolock) "
            lcCmd = lcCmd + "WHERE  USER_ID = '" + pcUserId.Trim + "' and PASSWORD='" + lcEncryptPassword.Trim + "' "

            If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count = 0 Then
                loException.Add("001", "Old password salah")
                Exit Try
            End If

            lcEncryptPassword = SC_Utility.Encrypt(pcUserId, pcNewPassword)
            lcCmd = "UPDATE SYS_USER "
            lcCmd = lcCmd + "SET PASSWORD='" + lcEncryptPassword.Trim + "'"
            lcCmd = lcCmd + "WHERE USER_ID='" + pcUserId.Trim + "'"

            loDb.SqlExecNonQuery(lcCmd, loConn, True)

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function GetListApp(pcUserId As String) As List(Of sys_appDTO) Implements ISCMenuSvc.GetListApp
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of sys_appDTO)

        Try

            lcCmd = "SELECT DISTINCT SYS_APP.APP_ID, SYS_APP.APP_NAME, SYS_APP.APP_DESC, SYS_MODULE.MODULE_ID, SYS_MODULE.MODULE_NAME, SYS_APP_GROUP.APP_GROUP_ID, "
            lcCmd = lcCmd + "SYS_APP_GROUP.APP_GROUP_NAME "
            lcCmd = lcCmd + "FROM SYS_APP (nolock) INNER JOIN  "
            lcCmd = lcCmd + "SYS_ROLE_APP (nolock) ON SYS_APP.APP_ID = SYS_ROLE_APP.APP_ID INNER JOIN "
            lcCmd = lcCmd + "SYS_MODULE (nolock) ON SYS_APP.MODULE_ID = SYS_MODULE.MODULE_ID INNER JOIN "
            lcCmd = lcCmd + "SYS_APP_GROUP (nolock) ON SYS_APP.APP_GROUP_ID = SYS_APP_GROUP.APP_GROUP_ID INNER JOIN "
            lcCmd = lcCmd + "SYS_USER_ROLE (nolock) ON SYS_ROLE_APP.ROLE_ID = SYS_USER_ROLE.ROLE_ID "
            lcCmd = lcCmd + "WHERE SYS_USER_ROLE.USER_ID = {0} "
            lcCmd = lcCmd + "ORDER BY SYS_MODULE.MODULE_NAME, SYS_APP_GROUP.APP_GROUP_NAME, SYS_APP.APP_NAME"

            loReturn = loDb.SQLExecObjectQuery(Of sys_appDTO)(lcCmd, loDb.GetConnection, True, pcUserId.Trim)

            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function GetRoleApp(pcUserId As String) As List(Of RoleAppDTO) Implements ISCMenuSvc.GetRoleApp
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As List(Of RoleAppDTO)

        Try
            lcCmd = "SELECT "
            lcCmd = lcCmd + "SYS_ROLE_APP.APP_ID, "
            lcCmd = lcCmd + "ADD_PERMIT =  CONVERT(bit, max(Convert(Int, SYS_ROLE_APP.ADD_PERMIT))), "
            lcCmd = lcCmd + "EDIT_PERMIT = CONVERT(bit, max(Convert(Int, SYS_ROLE_APP.EDIT_PERMIT))), "
            lcCmd = lcCmd + "DELETE_PERMIT = CONVERT(bit, max(Convert(Int, SYS_ROLE_APP.DELETE_PERMIT))), "
            lcCmd = lcCmd + "READ_PERMIT = CONVERT(bit, max(Convert(Int, SYS_ROLE_APP.READ_PERMIT))) "
            lcCmd = lcCmd + "FROM SYS_USER_ROLE WITH (nolock) INNER JOIN "
            lcCmd = lcCmd + "SYS_ROLE_APP WITH (nolock) ON SYS_ROLE_APP.ROLE_ID = SYS_USER_ROLE.ROLE_ID "
            lcCmd = lcCmd + "WHERE SYS_USER_ROLE.[USER_ID] = {0} "
            lcCmd = lcCmd + "group by SYS_USER_ROLE.[USER_ID],SYS_ROLE_APP.APP_ID"

            loReturn = loDb.SQLExecObjectQuery(Of RoleAppDTO)(lcCmd, loDb.GetConnection, True, pcUserId.Trim)
            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Login(pcUserId As String, pcPassword As String) As loginDTO Implements ISCMenuSvc.Login
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loReturn As loginDTO
        Dim lcPassword As String
        Try
            lcPassword = SC_Utility.Encrypt(pcUserId.Trim, pcPassword.Trim)
            lcCmd = "select a.user_id, USER_NAME=a.user_id, a.company_id,a.company_office_id,a.company_office_map_id "
            lcCmd = lcCmd + " ,b.COMPANY_NAME "
            lcCmd = lcCmd + " ,COMPANY_OFFICE_NAME=c.COMPANY_OFFICE "
            lcCmd = lcCmd + " from sys_user a (nolock) "
            lcCmd = lcCmd + " JOIN M_COMPANY b (nolock) on a.COMPANY_ID=b.COMPANY_ID"
            lcCmd = lcCmd + " JOIN M_COMPANY_OFFICE c (nolock) on a.COMPANY_OFFICE_ID=c.COMPANY_OFFICE_ID"
            lcCmd = lcCmd + " where user_id={0} and [password]={1} "

            loReturn = loDb.SQLExecObjectQuery(Of loginDTO)(lcCmd, loDb.GetConnection, True, pcUserId.Trim, lcPassword.Trim).FirstOrDefault

            If loReturn Is Nothing Then
                loException.Add("001", "Username atau password salah")
                Exit Try
            End If

            Return loReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function UpdateAppDll(pcAppId As String) As Byte() Implements ISCMenuSvc.UpdateAppDll
        Dim loException As New SC_Exception
        Dim lcPath As String
        Dim lcFile As String

        Try
            lcPath = System.Configuration.ConfigurationManager.AppSettings("AppDllPath")
            lcFile = lcPath + pcAppId + ".dll"

            If Not File.Exists(lcFile) Then
                loException.Add("001", "Download aplikasi '" + pcAppId + "' gagal. File tidak ditemukan diserver")
                Exit Try
            End If

            Return SC_Utility.GetByteFromFile(lcFile)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
