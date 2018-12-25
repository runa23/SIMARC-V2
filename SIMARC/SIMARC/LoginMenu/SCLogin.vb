Imports SC_Common
Imports SC_Win_FrontEnd
Imports SIMARC.SCMenuSvcRef
Imports SIMARC.SCStartUpSvcRef
Imports System
Imports System.Windows.Forms
Imports System.ServiceModel
Imports System.ServiceModel.Configuration
Imports System.Configuration
Imports System.Reflection
Imports System.Collections.Generic
Public Class SCLogin

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim loService As New SCMenuSvcClient
        Dim loRtn As loginDTO
        Dim loException As New SC_Exception
        Dim loInitialize As New _Initiator()
        Dim loRoleAppList As List(Of RoleAppDTO)

        Try
            'validate
            If String.IsNullOrEmpty(UserIDSC_TextBox.Text) Then
                SC_ErrorProvider1.SetError(UserIDLabel, "Harus diisi")
                Exit Sub
            End If

            'Run login Service
            loRtn = loService.Login(UserIDSC_TextBox.Text, PasswordSC_TextBox.Text)
            loRoleAppList = loService.GetRoleApp(loRtn.USER_ID)
            loService.Close()

            'Set Global Variable
            With loInitialize
                .Set_UserId(loRtn.USER_ID)
                .Set_UserName(loRtn.USER_NAME)
                .Set_CompanyId(loRtn.COMPANY_ID)
                .Set_CompanyName(loRtn.COMPANY_NAME)
                .Set_CompanyOfficeId(loRtn.COMPANY_OFFICE_ID)
                .Set_CompanyOfficeName(loRtn.COMPANY_OFFICE_NAME)
                .Set_CompanyOfficeMapId(loRtn.COMPANY_OFFICE_MAP_ID)
                .Set_RoleAppList(loRoleAppList)
            End With

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As TimeoutException
            loException.Add("001", "Connection Remote Time Out")
        Catch ex As FaultException(Of SC_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add("001", "Remote gagal")
        Catch ex As CommunicationException
            loException.Add("001", "Komunikasi Remote gagal")
        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            MessageBox.Show(loException.ErrorList(0).ErrDescp)
        End If
    End Sub
End Class
