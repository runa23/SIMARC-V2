Imports System.Windows.Forms

Namespace My


    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Dim loSplash As New SplashScreen
            Dim loLogin As New SCLogin()
            Dim loResult As DialogResult

            loResult = loSplash.ShowDialog()
            If loResult = DialogResult.Abort Then
                e.Cancel = True
                Exit Sub
            End If

            loResult = loLogin.ShowDialog()
            If loResult = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End Sub

    End Class

End Namespace