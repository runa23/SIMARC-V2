Imports System.Configuration
Imports System
Imports System.Windows.Forms
Imports SIMARC.SCStartUpSvcRef
Imports System.ServiceModel.Configuration
Imports System.Collections.Generic
Imports SC_Common
Imports System.Reflection

Public Class SplashScreen
    Dim lbUpdated As Boolean = False
    Public Const lcSIMARCVersion As String = "2.00.000"

    Private Sub ChangeConfiguration()
        Dim lcSIMARCServiceUrl As String
        Dim lcServiceUrl As String = ""
        Dim loConfig As Configuration
        Dim loUserConfig As Configuration = Nothing
        Dim loConfigFromServer As Configuration = Nothing
        Dim loClientSection As ClientSection
        Dim loConfigFromServerClientSection As ClientSection
        Dim loUriIn As Uri = Nothing
        Dim lcRelAddr As String = ""
        Dim loUriOut As Uri = Nothing
        Dim lcWebConfigPath As String
        Dim loService As SCStartUpSvcClient
        Dim loRtn As String

        Try
            loUserConfig = GetUserConfig()

            Try
                lcSIMARCServiceUrl = loUserConfig.AppSettings.Settings.Item("SIMARCServiceUrl").Value.ToString.Trim
            Catch ex As Exception
                Throw New Exception("Konfigurasi ServiceUrl tidak ditemukan")
            End Try

            loConfig = ConfigurationManager.OpenExeConfiguration(Assembly.GetEntryAssembly().Location)
            loClientSection = CType(loConfig.GetSection("system.serviceModel/client"), ClientSection)


            For Each x As ChannelEndpointElement In loClientSection.Endpoints
                lcServiceUrl = lcSIMARCServiceUrl

                With x.Address
                    loUriIn = New Uri(lcServiceUrl)
                    lcRelAddr = .AbsolutePath

                    If Uri.TryCreate(loUriIn, lcRelAddr, loUriOut) Then
                        If lcRelAddr <> "/SIMARCBack/SCStartUpSvc.svc" Then
                            loClientSection.Endpoints.Remove(x)
                        Else
                            x.Address = loUriOut
                        End If
                    End If

                End With

            Next


            loConfigFromServer = GetConfigFromServer()
            loConfigFromServerClientSection = CType(loConfigFromServer.GetSection("system.serviceModel/client"), ClientSection)

            For Each x As ChannelEndpointElement In loConfigFromServerClientSection.Endpoints
                lcServiceUrl = lcSIMARCServiceUrl

                With x.Address
                    loUriIn = New Uri(lcServiceUrl)
                    lcRelAddr = .AbsolutePath

                    If Uri.TryCreate(loUriIn, lcRelAddr, loUriOut) Then
                        x.Address = loUriOut
                        loClientSection.Endpoints.Add(x)
                    End If

                End With

            Next

            ConfigurationManager.RefreshSection("system.serviceModel/client")
            loConfig.Save()

            lcWebConfigPath = Application.StartupPath & "\dll\"
            loService = New SCStartUpSvcClient

            loRtn = loService.UpdateAppDllPath(lcWebConfigPath)

            loService.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.DialogResult = System.Windows.Forms.DialogResult.Abort
        End Try

    End Sub

    Private Sub CheckUpdatefileSupport()
        Dim loException As New SC_Exception
        Dim loService As SCStartUpSvcClient
        Dim loList As List(Of FileSupportDTO)
        Dim loAppFile As Byte()
        Dim loUserConfig As Configuration
        Dim loUpdateTempFile As IO.FileInfo
        Dim lcPath As String

        Try
            loService = New SCStartUpSvcClient
            loList = loService.GetListFileSupportVersion

            lcPath = My.Application.Info.DirectoryPath + "\temp\DeleteWhenStartUp\UpdateFileSupport\"
            If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\temp\DeleteWhenStartUp\") Then
                My.Computer.FileSystem.DeleteDirectory(My.Application.Info.DirectoryPath + "\temp\DeleteWhenStartUp\", Microsoft.VisualBasic.FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If

            If Not My.Computer.FileSystem.DirectoryExists(lcPath) Then
                My.Computer.FileSystem.CreateDirectory(lcPath)
            End If

            loUserConfig = GetUserConfig()
            For Each row As FileSupportDTO In loList
                If loUserConfig.AppSettings.Settings("VERSION_" + row.FILESUPPORT_ID) Is Nothing Then
                    BackgroundWorker1.ReportProgress(3)
                    loAppFile = loService.UpdateFile(row.FILESUPPORT_ID, row.FILESUPPORT_NAME)
                    ConvertByteToFile(lcPath + row.FILESUPPORT_NAME, loAppFile)
                    loUserConfig.AppSettings.Settings.Add("VERSION_" + row.FILESUPPORT_ID, row.VERSION)
                    lbUpdated = True
                ElseIf loUserConfig.AppSettings.Settings("VERSION_" + row.FILESUPPORT_ID).Value < row.VERSION Then
                    BackgroundWorker1.ReportProgress(3)
                    loAppFile = loService.UpdateFile(row.FILESUPPORT_ID, row.FILESUPPORT_NAME)
                    ConvertByteToFile(lcPath + row.FILESUPPORT_NAME, loAppFile)
                    loUserConfig.AppSettings.Settings("VERSION_" + row.FILESUPPORT_ID).Value = row.VERSION
                    lbUpdated = True
                End If
            Next

            Dim loUpdateTempFolder As New IO.DirectoryInfo(lcPath)
            For Each loUpdateTempFile In loUpdateTempFolder.GetFiles
                If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\" + loUpdateTempFile.Name) Then _
                    My.Computer.FileSystem.MoveFile(My.Application.Info.DirectoryPath + "\" + loUpdateTempFile.Name, My.Application.Info.DirectoryPath + "\temp\DeleteWhenStartUp\OldFileSupport\" + loUpdateTempFile.Name)
                My.Computer.FileSystem.MoveFile(loUpdateTempFile.FullName, My.Application.Info.DirectoryPath + "\" + loUpdateTempFile.Name)
            Next

            loService.Close()

            If lbUpdated Then
                loUserConfig.Save()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.DialogResult = System.Windows.Forms.DialogResult.Abort
        End Try
    End Sub

    Private Function GetUserConfig() As Configuration
        Dim loRtn As Configuration
        Dim loFileMap As New ExeConfigurationFileMap()

        loFileMap.ExeConfigFilename = My.Application.Info.DirectoryPath + "\User.config"
        loRtn = ConfigurationManager.OpenMappedExeConfiguration(loFileMap, ConfigurationUserLevel.None)

        Return loRtn
    End Function

    Private Function GetConfigFromServer() As Configuration
        Dim loRtn As Configuration
        Dim loFileMap As New ExeConfigurationFileMap()

        loFileMap.ExeConfigFilename = My.Application.Info.DirectoryPath + "\ConfigFromServer.config"
        loRtn = ConfigurationManager.OpenMappedExeConfiguration(loFileMap, ConfigurationUserLevel.None)

        Return loRtn
    End Function

    Public Shared Sub ConvertByteToFile(ByVal pcFile As String, ByVal pbData() As Byte)
        Dim loFileStream As System.IO.FileStream = Nothing

        Try

            If My.Computer.FileSystem.FileExists(pcFile) Then
                My.Computer.FileSystem.DeleteFile(pcFile)
            End If
            loFileStream = New System.IO.FileStream(pcFile, System.IO.FileMode.Create)
            loFileStream.Write(pbData, 0, pbData.Length)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            If loFileStream IsNot Nothing Then
                loFileStream.Close()
            End If
        End Try

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        BackgroundWorker1.ReportProgress(1)
        ChangeConfiguration()
        BackgroundWorker1.ReportProgress(2)
        CheckUpdatefileSupport()
        BackgroundWorker1.ReportProgress(100)
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Select Case e.ProgressPercentage
            Case 1
                ProgressLabel.Text = "Read Configuration..."
            Case 2
                ProgressLabel.Text = "Checking Update..."
            Case 3
                ProgressLabel.Text = "Updating..."
            Case 100
                ProgressLabel.Text = "Finish..."
        End Select
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If lbUpdated Then
            MessageBox.Show("Update SIMARC selesai. SIMARC akan ditutup, dan silahkan buka kembali untuk melanjutkan pekerjaan", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = System.Windows.Forms.DialogResult.Abort
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = "Ver. " + SplashScreen.lcSIMARCVersion
        BackgroundWorker1.RunWorkerAsync()
    End Sub
End Class
