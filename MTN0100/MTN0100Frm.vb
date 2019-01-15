Imports SC_Common
Imports SC_Win_FrontEnd
Imports MTN0100.MTN0100SvcRef
Imports System.ServiceModel

Public Class MTN0100Frm
    Public Const SysAppId As String = "MTN0100"
    Public Const SysAppVersion As String = "0.00.001"

    Private Sub MTN0100Frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = SysAppId & "V. " & SysAppVersion

        Dim loException As New SC_Exception
        Dim loService As MTN0100SvcClient
        Dim poparam As New List(Of Object)
        Dim loCompany As New List(Of LKM_CompanyDTO)

        Try
            loService = New MTN0100SvcClient
            MTN0100DTO02BindingSource.DataSource = New SC_BindingListView(Of MTN0100DTO02)(New List(Of MTN0100DTO02))

            poparam.Add(SC_GlobalVar.UserId)

        Catch ex As Exception

        End Try
    End Sub
End Class
