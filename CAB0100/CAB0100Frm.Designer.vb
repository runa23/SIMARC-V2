<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAB0100Frm
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
        Dim COMPANY_OFFICELabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAB0100Frm))
        Me.SC_BtnImport = New SC_Win_FrontEnd.SC_Button()
        Me.LKM_CompanyOfficeDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMPANY_OFFICESC_ComboBox = New SC_Win_FrontEnd.SC_ComboBox()
        Me.FileNameTextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.SC_BtnFile = New SC_Win_FrontEnd.SC_Button()
        Me.VersionLabel = New System.Windows.Forms.Label()
        COMPANY_OFFICELabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.LKM_CompanyOfficeDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'COMPANY_OFFICELabel
        '
        COMPANY_OFFICELabel.AutoSize = True
        COMPANY_OFFICELabel.Location = New System.Drawing.Point(20, 91)
        COMPANY_OFFICELabel.Name = "COMPANY_OFFICELabel"
        COMPANY_OFFICELabel.Size = New System.Drawing.Size(91, 13)
        COMPANY_OFFICELabel.TabIndex = 2
        COMPANY_OFFICELabel.Text = "Company Office :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(38, 117)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(73, 13)
        Label1.TabIndex = 2
        Label1.Text = "Source Data :"
        '
        'SC_BtnImport
        '
        Me.SC_BtnImport.Image = CType(resources.GetObject("SC_BtnImport.Image"), System.Drawing.Image)
        Me.SC_BtnImport.Location = New System.Drawing.Point(12, 12)
        Me.SC_BtnImport.Name = "SC_BtnImport"
        Me.SC_BtnImport.SC_ConductorSource = Nothing
        Me.SC_BtnImport.Size = New System.Drawing.Size(61, 47)
        Me.SC_BtnImport.TabIndex = 0
        Me.SC_BtnImport.Text = "Import"
        Me.SC_BtnImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_BtnImport.UseVisualStyleBackColor = True
        '
        'LKM_CompanyOfficeDTOBindingSource
        '
        Me.LKM_CompanyOfficeDTOBindingSource.DataSource = GetType(CAB0100.CAB0100SvcRef.LKM_CompanyOfficeDTO)
        '
        'COMPANY_OFFICESC_ComboBox
        '
        Me.COMPANY_OFFICESC_ComboBox.DataSource = Me.LKM_CompanyOfficeDTOBindingSource
        Me.COMPANY_OFFICESC_ComboBox.DisplayMember = "COMPANY_OFFICE"
        Me.COMPANY_OFFICESC_ComboBox.FormattingEnabled = True
        Me.COMPANY_OFFICESC_ComboBox.Location = New System.Drawing.Point(117, 87)
        Me.COMPANY_OFFICESC_ComboBox.Name = "COMPANY_OFFICESC_ComboBox"
        Me.COMPANY_OFFICESC_ComboBox.SC_ConductorSource = Nothing
        Me.COMPANY_OFFICESC_ComboBox.Size = New System.Drawing.Size(199, 21)
        Me.COMPANY_OFFICESC_ComboBox.TabIndex = 3
        Me.COMPANY_OFFICESC_ComboBox.ValueMember = "COMPANY_OFFICE_ID"
        '
        'FileNameTextBox
        '
        Me.FileNameTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.FileNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FileNameTextBox.Location = New System.Drawing.Point(117, 114)
        Me.FileNameTextBox.Name = "FileNameTextBox"
        Me.FileNameTextBox.ReadOnly = True
        Me.FileNameTextBox.SC_ConductorSource = Nothing
        Me.FileNameTextBox.Size = New System.Drawing.Size(273, 21)
        Me.FileNameTextBox.TabIndex = 4
        '
        'SC_BtnFile
        '
        Me.SC_BtnFile.Location = New System.Drawing.Point(396, 113)
        Me.SC_BtnFile.Name = "SC_BtnFile"
        Me.SC_BtnFile.SC_ConductorSource = Nothing
        Me.SC_BtnFile.Size = New System.Drawing.Size(34, 23)
        Me.SC_BtnFile.TabIndex = 5
        Me.SC_BtnFile.Text = "..."
        Me.SC_BtnFile.UseVisualStyleBackColor = True
        '
        'VersionLabel
        '
        Me.VersionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VersionLabel.Location = New System.Drawing.Point(341, 9)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(165, 42)
        Me.VersionLabel.TabIndex = 15
        Me.VersionLabel.Text = "Label1"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CAB0100Frm
        '
        Me.ClientSize = New System.Drawing.Size(518, 472)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.SC_BtnFile)
        Me.Controls.Add(Me.FileNameTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(COMPANY_OFFICELabel)
        Me.Controls.Add(Me.COMPANY_OFFICESC_ComboBox)
        Me.Controls.Add(Me.SC_BtnImport)
        Me.Name = "CAB0100Frm"
        CType(Me.LKM_CompanyOfficeDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SC_BtnImport As SC_Win_FrontEnd.SC_Button
    Friend WithEvents LKM_CompanyOfficeDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMPANY_OFFICESC_ComboBox As SC_Win_FrontEnd.SC_ComboBox
    Friend WithEvents FileNameTextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents SC_BtnFile As SC_Win_FrontEnd.SC_Button
    Friend WithEvents VersionLabel As System.Windows.Forms.Label

End Class
