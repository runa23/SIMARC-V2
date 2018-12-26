<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
    Inherits SC_Win_FrontEnd.SC_FormBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OldPasswordSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.NewPasswordSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.ConfirmSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.SaveSC_Button = New SC_Win_FrontEnd.SC_Button()
        Me.CancelSC_Button = New SC_Win_FrontEnd.SC_Button()
        Me.SC_ErrorProvider1 = New SC_Win_FrontEnd.SC_ErrorProvider(Me.components)
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Old Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "*New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "*Confim New Password"
        '
        'OldPasswordSC_TextBox
        '
        Me.OldPasswordSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.OldPasswordSC_TextBox.Location = New System.Drawing.Point(141, 16)
        Me.OldPasswordSC_TextBox.Name = "OldPasswordSC_TextBox"
        Me.OldPasswordSC_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.OldPasswordSC_TextBox.SC_ConductorSource = Nothing
        Me.OldPasswordSC_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.OldPasswordSC_TextBox.TabIndex = 3
        '
        'NewPasswordSC_TextBox
        '
        Me.NewPasswordSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NewPasswordSC_TextBox.Location = New System.Drawing.Point(141, 59)
        Me.NewPasswordSC_TextBox.Name = "NewPasswordSC_TextBox"
        Me.NewPasswordSC_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.NewPasswordSC_TextBox.SC_ConductorSource = Nothing
        Me.NewPasswordSC_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.NewPasswordSC_TextBox.TabIndex = 4
        '
        'ConfirmSC_TextBox
        '
        Me.ConfirmSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ConfirmSC_TextBox.Location = New System.Drawing.Point(141, 87)
        Me.ConfirmSC_TextBox.Name = "ConfirmSC_TextBox"
        Me.ConfirmSC_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.ConfirmSC_TextBox.SC_ConductorSource = Nothing
        Me.ConfirmSC_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.ConfirmSC_TextBox.TabIndex = 5
        '
        'SaveSC_Button
        '
        Me.SaveSC_Button.Location = New System.Drawing.Point(188, 130)
        Me.SaveSC_Button.Name = "SaveSC_Button"
        Me.SaveSC_Button.SC_ConductorSource = Nothing
        Me.SaveSC_Button.Size = New System.Drawing.Size(75, 23)
        Me.SaveSC_Button.TabIndex = 6
        Me.SaveSC_Button.Text = "&Save"
        Me.SaveSC_Button.UseVisualStyleBackColor = True
        '
        'CancelSC_Button
        '
        Me.CancelSC_Button.Location = New System.Drawing.Point(266, 130)
        Me.CancelSC_Button.Name = "CancelSC_Button"
        Me.CancelSC_Button.SC_ConductorSource = Nothing
        Me.CancelSC_Button.Size = New System.Drawing.Size(75, 23)
        Me.CancelSC_Button.TabIndex = 7
        Me.CancelSC_Button.Text = "&Cancel"
        Me.CancelSC_Button.UseVisualStyleBackColor = True
        '
        'SC_ErrorProvider1
        '
        Me.SC_ErrorProvider1.ContainerControl = Me
        '
        'ChangePassword
        '
        Me.ClientSize = New System.Drawing.Size(374, 171)
        Me.Controls.Add(Me.CancelSC_Button)
        Me.Controls.Add(Me.SaveSC_Button)
        Me.Controls.Add(Me.ConfirmSC_TextBox)
        Me.Controls.Add(Me.NewPasswordSC_TextBox)
        Me.Controls.Add(Me.OldPasswordSC_TextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePassword"
        Me.Text = "Change Password"
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OldPasswordSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents NewPasswordSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents ConfirmSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents SaveSC_Button As SC_Win_FrontEnd.SC_Button
    Friend WithEvents CancelSC_Button As SC_Win_FrontEnd.SC_Button
    Friend WithEvents SC_ErrorProvider1 As SC_Win_FrontEnd.SC_ErrorProvider

End Class
