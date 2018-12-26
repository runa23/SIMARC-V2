Imports SC_Common
Imports SC_Win_FrontEnd
Imports SIMARC.SCMenuSvcRef
Imports System
Imports System.ServiceModel
Imports System.Windows.Forms
Public Class ChangePassword

    Private Sub SaveSC_Button_Click(sender As Object, e As EventArgs) Handles SaveSC_Button.Click
        Dim loException As New SC_Exception
        Dim loService As SCMenuSvcClient
        Dim lcErr As String

        Try
            'Validasi
            If String.IsNullOrEmpty(NewPasswordSC_TextBox.Text.Trim) Then
                lcErr = "New Password harus diisi"
                loException.Add("001", lcErr)
                SC_ErrorProvider1.SetError(NewPasswordSC_TextBox, lcErr)
            Else
                If NewPasswordSC_TextBox.Text.Trim <> ConfirmSC_TextBox.Text.Trim Then
                    lcErr = "Confirm New Password harus sama dengan New Password"
                    loException.Add("002", lcErr)
                    SC_ErrorProvider1.SetError(ConfirmSC_TextBox, lcErr)
                End If
            End If

            If loException.Haserror Then
                Exit Try
            End If

            'Save
            loService = New SCMenuSvcClient
            loService.ChangePassword(SC_GlobalVar.UserId, OldPasswordSC_TextBox.Text, NewPasswordSC_TextBox.Text)
            loService.Close()

            MessageBox.Show("New Password Saved")
            Me.Close()

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

    Private Sub CancelSC_Button_Click(sender As Object, e As EventArgs) Handles CancelSC_Button.Click
        Me.Close()
    End Sub
End Class