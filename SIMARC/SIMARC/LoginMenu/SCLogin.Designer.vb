<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SCLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SCLogin))
        Me.UserIDSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.UserIDLabel = New System.Windows.Forms.Label()
        Me.PasswodLabel = New System.Windows.Forms.Label()
        Me.PasswordSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.LoginBtn = New SC_Win_FrontEnd.SC_Button()
        Me.CancelBtn = New SC_Win_FrontEnd.SC_Button()
        Me.SC_ErrorProvider1 = New SC_Win_FrontEnd.SC_ErrorProvider(Me.components)
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIDSC_TextBox
        '
        Me.UserIDSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UserIDSC_TextBox.Location = New System.Drawing.Point(12, 91)
        Me.UserIDSC_TextBox.Name = "UserIDSC_TextBox"
        Me.UserIDSC_TextBox.SC_ConductorSource = Nothing
        Me.UserIDSC_TextBox.Size = New System.Drawing.Size(226, 20)
        Me.UserIDSC_TextBox.TabIndex = 1
        '
        'UserIDLabel
        '
        Me.UserIDLabel.AutoSize = True
        Me.UserIDLabel.BackColor = System.Drawing.Color.Transparent
        Me.UserIDLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDLabel.ForeColor = System.Drawing.Color.White
        Me.UserIDLabel.Location = New System.Drawing.Point(12, 72)
        Me.UserIDLabel.Name = "UserIDLabel"
        Me.UserIDLabel.Size = New System.Drawing.Size(55, 16)
        Me.UserIDLabel.TabIndex = 1
        Me.UserIDLabel.Text = "User ID"
        '
        'PasswodLabel
        '
        Me.PasswodLabel.AutoSize = True
        Me.PasswodLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswodLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswodLabel.ForeColor = System.Drawing.Color.White
        Me.PasswodLabel.Location = New System.Drawing.Point(12, 114)
        Me.PasswodLabel.Name = "PasswodLabel"
        Me.PasswodLabel.Size = New System.Drawing.Size(71, 16)
        Me.PasswodLabel.TabIndex = 1
        Me.PasswodLabel.Text = "Password"
        '
        'PasswordSC_TextBox
        '
        Me.PasswordSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.PasswordSC_TextBox.Location = New System.Drawing.Point(12, 133)
        Me.PasswordSC_TextBox.Name = "PasswordSC_TextBox"
        Me.PasswordSC_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordSC_TextBox.SC_ConductorSource = Nothing
        Me.PasswordSC_TextBox.Size = New System.Drawing.Size(226, 20)
        Me.PasswordSC_TextBox.TabIndex = 2
        '
        'LoginBtn
        '
        Me.LoginBtn.Location = New System.Drawing.Point(40, 159)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.SC_ConductorSource = Nothing
        Me.LoginBtn.Size = New System.Drawing.Size(75, 23)
        Me.LoginBtn.TabIndex = 3
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Location = New System.Drawing.Point(121, 159)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.SC_ConductorSource = Nothing
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 4
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'SC_ErrorProvider1
        '
        Me.SC_ErrorProvider1.ContainerControl = Me
        '
        'SCLogin
        '
        Me.AcceptButton = Me.LoginBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SIMARC.My.Resources.Resources.LoginPage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(651, 282)
        Me.ControlBox = False
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.PasswodLabel)
        Me.Controls.Add(Me.UserIDLabel)
        Me.Controls.Add(Me.PasswordSC_TextBox)
        Me.Controls.Add(Me.UserIDSC_TextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SCLogin"
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserIDSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents UserIDLabel As System.Windows.Forms.Label
    Friend WithEvents PasswodLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents LoginBtn As SC_Win_FrontEnd.SC_Button
    Friend WithEvents CancelBtn As SC_Win_FrontEnd.SC_Button
    Friend WithEvents SC_ErrorProvider1 As SC_Win_FrontEnd.SC_ErrorProvider

End Class
