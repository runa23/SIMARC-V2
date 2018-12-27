Imports System.Collections.Generic
Imports SIMARC.SCMenuSvcRef
Imports DevExpress.XtraTreeList.Nodes
Imports SC_Common
Imports SC_Win_FrontEnd
Imports SC_BackEnd
Imports System.ServiceModel
Imports System
Imports System.Windows.Forms
Imports System.Reflection
Imports System.IO
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports System.Configuration
Imports DevExpress.XtraTreeList.StyleFormatConditions
Public Class SCMenu
    Public _Default_App As String
    Public _Default_App_Name As String

    Sub GenerateMenu(ByVal poApps As List(Of sys_appDTO))
        Dim loModule As TreeListNode
        Dim loGroup As TreeListNode
        Dim loGroupItem As TreeListNode
        Dim lcLastModule As String = ""
        Dim lcLastGroup As String = ""

        TreeList1.Nodes.Clear()

        For Each loApp As sys_appDTO In poApps

            If lcLastModule <> loApp.MODULE_NAME Then
                loModule = TreeList1.AppendNode(New Object() {loApp.MODULE_NAME, "", "MODULE", 0}, -1)
                loModule.ExpandAll()
                lcLastGroup = ""
            End If

            If lcLastGroup <> loApp.APP_GROUP_NAME Then
                loGroup = TreeList1.AppendNode(New Object() {loApp.APP_GROUP_NAME, "", "GROUP", 1}, loModule)
                loGroup.ExpandAll()
                lcLastGroup = loApp.APP_GROUP_NAME
            End If

            loGroupItem = TreeList1.AppendNode(New Object() {loApp.APP_NAME.Trim, loApp.APP_ID.Trim, "APP", 2}, loGroup)
            loGroupItem.ExpandAll()

            lcLastModule = loApp.MODULE_NAME
            If lcLastModule <> loApp.MODULE_NAME Then
                loModule.Expanded = True
            End If
        Next
    End Sub

    Private Sub SCMenu_Activated(sender As Object, e As EventArgs) Handles Me.Load
        loadApp()
    End Sub

    Sub loadApp()
        Dim loException As New SC_Exception
        Dim loService As SCMenuSvcClient
        Dim loApps As List(Of sys_appDTO)

        Try

            Dim loUserConfig As System.Configuration.Configuration = Nothing
            Dim lcCTAMSServiceUrl As String

            VersionLabel.Text = "Ver. " + SplashScreen.lcSIMARCVersion
            UserLabel.Text = "User Id : " + SC_GlobalVar.UserId.ToLower + " | Office Id : " + SC_GlobalVar.CompanyOfficeId + " | Office Map : " + SC_GlobalVar.CompanyOfficeMapId


            loUserConfig = GetUserConfig()
            lcCTAMSServiceUrl = loUserConfig.AppSettings.Settings.Item("SIMARCServiceUrl").Value.ToString.Trim

            loService = New SCMenuSvcClient

            'Load Role

            'Load Menu
            loApps = loService.GetListApp(SC_GlobalVar.UserId)
            loService.Close()

            GenerateMenu(loApps)

            If _Default_App IsNot Nothing Then
                'open_form(_Default_App)
            End If

            TreeList1.ExpandAll()

        Catch ex As FaultException(Of SC_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            SC_DisplayException(loException)
        End If
    End Sub

    Private Function GetUserConfig() As System.Configuration.Configuration
        Dim loRtn As System.Configuration.Configuration
        Dim loFileMap As New ExeConfigurationFileMap()

        loFileMap.ExeConfigFilename = My.Application.Info.DirectoryPath + "\User.config"
        loRtn = ConfigurationManager.OpenMappedExeConfiguration(loFileMap, ConfigurationUserLevel.None)

        Return loRtn
    End Function
    Private Sub TreeList1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeList1.DoubleClick
        prePreOpenForm()
    End Sub

    Sub prePreOpenForm()
        If TreeList1.FocusedNode.GetValue("colAppId").ToString > "" Then
            Dim lcAppId As String = TreeList1.FocusedNode.GetValue("colAppId").ToString
            Dim lcAppName As String = TreeList1.FocusedNode.GetValue("colName").ToString

            open_form(lcAppId, lcAppName)
        End If
    End Sub

    Private Function DynamicallyLoadedObject(ByVal objectName As String, Optional ByVal args() As Object = Nothing) As Form
        Dim loAsm As Assembly
        Dim lcPath As String
        Dim loType As Type
        Dim returnObj As Object = Nothing
        Dim lcNameSpace As String = Me.GetType().Namespace()


        lcPath = My.Application.Info.DirectoryPath + "\" + objectName.Trim + ".dll"
        If Not File.Exists(lcPath) Then Return Nothing

        loType = Assembly.GetExecutingAssembly().GetType(lcNameSpace.Trim + "." + objectName)

        If loType Is Nothing Then
            loAsm = Assembly.LoadFrom(lcPath)
            loType = loAsm.GetType(objectName.Trim + "." + objectName.Trim + "Frm", False, True)
            If loType Is Nothing Then
                Return Nothing
            End If
        End If
        returnObj = Activator.CreateInstance(loType, args)

        Return returnObj
    End Function

    Private Sub open_form(ByVal pcAppId As String, ByVal pcAppName As String)
        Dim loException As New SC_Exception
        Dim loForm As New Form
        Dim lcAppId As String
        Dim loService As SCMenuSvcClient
        Dim loAppFile As Byte()
        Dim lcDllVersionLocal As String
        Dim lcDllVersionServer As String
        Dim loTab As XtraTabPage
        Try



            lcAppId = pcAppId

            loService = New SCMenuSvcClient

            'Get Server Version
            lcDllVersionServer = loService.AppDllLatestVersion(lcAppId)

            loForm = DynamicallyLoadedObject(lcAppId)
            'Get Lokal Version
            If loForm Is Nothing Then
                lcDllVersionLocal = "blank"
            Else
                Try
                    lcDllVersionLocal = CType(loForm, Object).SysAppVersion
                Catch ex As Exception
                    lcDllVersionLocal = "0"
                End Try
            End If

            'Update jika lokal < server
            If lcDllVersionLocal = "blank" OrElse lcDllVersionLocal < lcDllVersionServer Then

                DownloadBackgroundWorker.RunWorkerAsync()

                loAppFile = loService.UpdateAppDll(lcAppId)
                ConvertByteToFile(My.Application.Info.DirectoryPath + "\" + lcAppId.Trim + ".dll", loAppFile)

                DownloadBackgroundWorker.CancelAsync()

                If lcDllVersionLocal <> "blank" Then
                    If MessageBox.Show("Update Aplikasi selesai. Silahkan restart SIMARC. Tekan Yes untuk keluar sekarang", "Download Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Close()
                    End If
                    Exit Sub
                End If

                loForm = DynamicallyLoadedObject(lcAppId)

            End If

            loService.Close()

            loTab = New XtraTabPage
            loTab.Text = pcAppName
            loTab.Name = pcAppId

            TabControl1.TabPages.Add(loTab)

            loForm.TopLevel = False
            loTab.Controls.Add(loForm)

            loForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            loForm.Dock = DockStyle.Fill

            loForm.Show()

            TabControl1.SelectedTabPage = loTab

        Catch ex As FaultException(Of SC_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        Catch ex As Exception
            loException.Add(ex)
        Finally
            If DownloadBackgroundWorker.IsBusy Then
                DownloadBackgroundWorker.CancelAsync()
            End If
        End Try

        If loException.Haserror Then
            SC_DisplayException(loException)
        End If
    End Sub


    Public Shared Sub ConvertByteToFile(ByVal pcFile As String, ByVal pbData() As Byte)
        Dim loFileStream As System.IO.FileStream = Nothing
        Dim lcNewPath As String

        Try

            If My.Computer.FileSystem.FileExists(pcFile) Then
                lcNewPath = My.Computer.FileSystem.GetParentPath(pcFile) + "\temp\DeleteWhenStartUp\oldDllApp\" + My.Computer.FileSystem.GetName(pcFile) + DateTime.Now.ToString("yyyyMMdd HHmmss")
                My.Computer.FileSystem.MoveFile(pcFile, lcNewPath)
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

    Sub SC_DisplayException(ByVal loException As SC_Exception)
        MessageBox.Show(loException.ErrorList(0).ErrDescp)
    End Sub

    Private Sub XtraTabControl1_CloseButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.CloseButtonClick
        Dim arg As ClosePageButtonEventArgs = TryCast(e, ClosePageButtonEventArgs)
        TryCast(arg.Page, XtraTabPage).PageVisible = False
    End Sub

    Private Sub DownloadBackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles DownloadBackgroundWorker.ProgressChanged
        DownloadProcess.ShowDialog(Me)
    End Sub

    Private Sub DownloadBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles DownloadBackgroundWorker.DoWork
        DownloadBackgroundWorker.ReportProgress(0)
        While DownloadBackgroundWorker.CancellationPending = False
            System.Threading.Thread.Sleep(1000)
        End While
    End Sub

    Private Sub DownloadBackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles DownloadBackgroundWorker.RunWorkerCompleted
        DownloadProcess.Close()
    End Sub

    'Private Sub VersionLabel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles VersionLabel.ItemClick
    '    loadApp()
    'End Sub


    Private Sub TreeList1_FilterNode(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FilterNodeEventArgs) Handles TreeList1.FilterNode
        If String.IsNullOrWhiteSpace(TreeList1.FindFilterText) Then
            Exit Sub
        End If

        If e.Node.GetValue("colMenuType").ToString = "MODULE" Or e.Node.GetValue("colMenuType").ToString = "GROUP" Then
            If findFilterNode(e.Node.Nodes) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If
    End Sub

    Function findFilterNode(ByVal poNodes As TreeListNodes) As Boolean
        For Each n As TreeListNode In poNodes
            If n.GetValue("colMenuType").ToString = "GROUP" Then
                For Each n2 As TreeListNode In n.Nodes
                    If n2.GetValue("colMenuType").ToString = "APP" AndAlso n2.GetValue("colName").ToString.ToUpper.Contains(TreeList1.FindFilterText.ToUpper) Then
                        Return True
                    End If
                Next
            End If

            If n.GetValue("colMenuType").ToString = "APP" AndAlso n.GetValue("colName").ToString.ToUpper.Contains(TreeList1.FindFilterText.ToUpper) Then
                Return True
            End If

        Next
        Return False
    End Function

    Private Sub TreeList1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TreeList1.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            prePreOpenForm()
        End If
    End Sub

    Private Sub TreeList1_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList1.FocusedNodeChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub ChangePasswordLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ChangePasswordLinkLabel.LinkClicked
        ChangePassword.ShowDialog(Me)
    End Sub
End Class