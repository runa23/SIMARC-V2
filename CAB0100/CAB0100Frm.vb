Imports SC_Common
Imports SC_Win_FrontEnd
Imports CAB0100.CAB0100SvcRef
Imports System.ServiceModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class CAB0100Frm
    Public Const SysAppId As String = "CAB0100"
    Public Const SysAppVersion As String = "0.00.001"

    Private Sub CAB0100Frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        VersionLabel.Text = SysAppId & " V. " & SysAppVersion

        Dim loException As New SC_Exception
        Dim loService As CAB0100SvcClient
        Dim poparam As New List(Of Object)
        Dim loCompanyOffice As New List(Of LKM_CompanyOfficeDTO)

        Try
            poparam.Clear()

            With poparam
                .Add(SC_GlobalVar.CompanyOfficeId)
            End With

            loService = New CAB0100SvcClient

            loCompanyOffice = loService.getCompany(poparam)
            LKM_CompanyOfficeDTOBindingSource.DataSource = New SC_BindingListView(Of LKM_CompanyOfficeDTO)(loCompanyOffice)

            loService.Close()

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

    Private Sub SC_BtnFile_Click(sender As Object, e As EventArgs) Handles SC_BtnFile.Click
        Dim loException As New SC_Exception
        Dim Browse As New OpenFileDialog
        Dim fname As String

        Try
            With Browse
                .Filter = "Excel Files(*.xlsx)|*.xlsx|All Files (*.*)|*.*"
                .FilterIndex = 1
                .Title = "Import Data From Excel File"
            End With

            If Browse.ShowDialog() = Windows.Forms.DialogResult.OK Then
                fname = Browse.FileName
                FileNameTextBox.Text = fname
            End If

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

    Private Sub SC_BtnImport_Click(sender As Object, e As EventArgs) Handles SC_BtnImport.Click
        Dim loException As New SC_Exception
        Dim ConnExcel As OleDbConnection
        Dim DTSet As DataSet
        Dim CommExcel As OleDbDataAdapter
        Dim loService As CAB0100SvcClient
        Dim StrConn As String
        Dim lcCmd As String
        Dim loDoc As New List(Of LKM_ParamDTO)

        Try

            loService = New CAB0100SvcClient

            loDoc = loService.getParamDoc("DOC_CAB")

            StrConn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & FileNameTextBox.Text & " '; " & "Extended Properties=""Excel 12.0;HDR=YES;IMEX=1"""
            ConnExcel = New OleDbConnection(StrConn)

            'lcCmd = "SELECT [BARCODE],[TYPE_ID],[MERK_ID],[MODEL_ID],[SIZE] FROM [" & loDoc(0).ToString & "$] WHERE [BARCODE] IS NOT NULL"
            lcCmd = "SELECT [BARCODE],[Nama Tipe Aset],[Nama Merek Aset],[Nama Model Aset],[Nama Ukuran Aset] FROM [" & loDoc(0).PARAMETER_VALUE & "$] WHERE [BARCODE] IS NOT NULL"
            CommExcel = New OleDbDataAdapter(lcCmd, ConnExcel)
            DTSet = New DataSet
            CommExcel.Fill(DTSet)
            ConnExcel.Close()



            loService.Import(DTSet, COMPANY_OFFICESC_ComboBox.SelectedValue, SC_GlobalVar.UserId)
            loService.Close()

            FileNameTextBox.Text = ""
            MsgBox("Proses Import Selesai", vbInformation, "Import Cabinet")

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
End Class
