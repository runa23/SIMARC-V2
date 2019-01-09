Imports SC_Common
Imports SC_BackEnd
Imports System.IO
Imports System.Configuration
Imports System.Web.Configuration
Public Class SCStartUpSvc
    Implements ISCStartUpSvc

    Public Function GetListFileSupportVersion() As List(Of FIleSupportDTO) Implements ISCStartUpSvc.GetListFileSupportVersion
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim loList As List(Of FIleSupportDTO)

        Try
            lcCmd = "select FILESUPPORT_ID, FILESUPPORT_NAME, VERSION "
            lcCmd = lcCmd + "from sys_filesupport (nolock) "

            loList = loDb.SQLExecObjectQuery(Of FIleSupportDTO)(lcCmd, loDb.GetConnection, True)

            Return loList
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ThrowExceptionIfErrors()
    End Function

    Public Function UpdateFile(pcFileSupportId As String, pcFileSupportName As String) As Byte() Implements ISCStartUpSvc.UpdateFile
        Dim loException As New SC_Exception
        Dim lcPath As String
        Dim lcFile As String

        Try
            lcPath = System.Configuration.ConfigurationManager.AppSettings("FileSupportPath")
            lcFile = lcPath + pcFileSupportName

            If Not File.Exists(lcFile) Then
                loException.Add("001", "Download file '" + pcFileSupportName + "' gagal. File tidak ditemukan diserver")
                Exit Try
            End If

            Return SC_Utility.GetByteFromFile(lcFile)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function UpdateAppDllPath(AppPath As String) As String Implements ISCStartUpSvc.UpdateAppDllPath
        Dim loException As New SC_Exception
        Dim loConfig As Configuration
        Dim loAppDllPath As String
        Dim loRtn As String

        Try
            loConfig = WebConfigurationManager.OpenWebConfiguration("~")

            loAppDllPath = WebConfigurationManager.AppSettings("AppDllPath")

            If loAppDllPath <> AppPath Or loAppDllPath = "" Then

                loConfig.AppSettings.Settings("AppDllPath").Value = AppPath
                loConfig.Save(ConfigurationSaveMode.Modified)
                ConfigurationManager.RefreshSection("AppSettings")
            End If

            loRtn = WebConfigurationManager.AppSettings("AppDllPath")
            Return loRtn

        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
