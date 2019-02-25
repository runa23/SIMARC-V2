<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SCM0300Frm
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
        Dim COMPANY_OFFICE_IDLabel As System.Windows.Forms.Label
        Dim COMPANY_OFFICELabel As System.Windows.Forms.Label
        Dim COMPANY_NAMELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SCM0300Frm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SC_ExportCSV1 = New SC_Win_FrontEnd.SC_ExportCSV(Me.components)
        Me.SC_Conductor1 = New SC_Win_FrontEnd.SC_Conductor(Me.components)
        Me.SCM0300DTO01BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCM0300DTO02BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SC_Save1 = New SC_Win_FrontEnd.SC_Save()
        Me.SC_Delete1 = New SC_Win_FrontEnd.SC_Delete()
        Me.SC_Edit1 = New SC_Win_FrontEnd.SC_Edit()
        Me.SC_Refresh1 = New SC_Win_FrontEnd.SC_Refresh()
        Me.SC_Cancel1 = New SC_Win_FrontEnd.SC_Cancel()
        Me.SC_Add1 = New SC_Win_FrontEnd.SC_Add()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabList = New System.Windows.Forms.TabPage()
        Me.SC_GridSearch1 = New SC_Win_FrontEnd.SC_GridSearch()
        Me.SCM0300DTO02SC_DataGridView = New SC_Win_FrontEnd.SC_DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabData = New System.Windows.Forms.TabPage()
        Me.COMPANY_NAMESC_ComboBox = New SC_Win_FrontEnd.SC_ComboBox()
        Me.LKM_CompanyDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMPANY_OFFICESC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.COMPANY_OFFICE_IDSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.SC_ErrorProvider1 = New SC_Win_FrontEnd.SC_ErrorProvider(Me.components)
        COMPANY_OFFICE_IDLabel = New System.Windows.Forms.Label()
        COMPANY_OFFICELabel = New System.Windows.Forms.Label()
        COMPANY_NAMELabel = New System.Windows.Forms.Label()
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCM0300DTO01BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCM0300DTO02BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabList.SuspendLayout()
        CType(Me.SCM0300DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabData.SuspendLayout()
        CType(Me.LKM_CompanyDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'COMPANY_OFFICE_IDLabel
        '
        COMPANY_OFFICE_IDLabel.AutoSize = True
        COMPANY_OFFICE_IDLabel.Location = New System.Drawing.Point(38, 9)
        COMPANY_OFFICE_IDLabel.Name = "COMPANY_OFFICE_IDLabel"
        COMPANY_OFFICE_IDLabel.Size = New System.Drawing.Size(114, 13)
        COMPANY_OFFICE_IDLabel.TabIndex = 0
        COMPANY_OFFICE_IDLabel.Text = "* Company Office ID :"
        '
        'COMPANY_OFFICELabel
        '
        COMPANY_OFFICELabel.AutoSize = True
        COMPANY_OFFICELabel.Location = New System.Drawing.Point(28, 35)
        COMPANY_OFFICELabel.Name = "COMPANY_OFFICELabel"
        COMPANY_OFFICELabel.Size = New System.Drawing.Size(121, 13)
        COMPANY_OFFICELabel.TabIndex = 2
        COMPANY_OFFICELabel.Text = "Company Office Name :"
        '
        'COMPANY_NAMELabel
        '
        COMPANY_NAMELabel.AutoSize = True
        COMPANY_NAMELabel.Location = New System.Drawing.Point(90, 61)
        COMPANY_NAMELabel.Name = "COMPANY_NAMELabel"
        COMPANY_NAMELabel.Size = New System.Drawing.Size(59, 13)
        COMPANY_NAMELabel.TabIndex = 4
        COMPANY_NAMELabel.Text = "Company :"
        '
        'SC_ExportCSV1
        '
        Me.SC_ExportCSV1.Image = CType(resources.GetObject("SC_ExportCSV1.Image"), System.Drawing.Image)
        Me.SC_ExportCSV1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_ExportCSV1.Location = New System.Drawing.Point(384, 12)
        Me.SC_ExportCSV1.Name = "SC_ExportCSV1"
        Me.SC_ExportCSV1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_ExportCSV1.SC_DataGridView = Nothing
        Me.SC_ExportCSV1.SC_DefaultFileName = "Master Company Office"
        Me.SC_ExportCSV1.Size = New System.Drawing.Size(61, 39)
        Me.SC_ExportCSV1.TabIndex = 21
        Me.SC_ExportCSV1.Text = "E&xport"
        Me.SC_ExportCSV1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_ExportCSV1.UseVisualStyleBackColor = True
        '
        'SC_Conductor1
        '
        Me.SC_Conductor1.SC_BindingSource = Me.SCM0300DTO01BindingSource
        Me.SC_Conductor1.SC_ParentBindingSource = Me.SCM0300DTO02BindingSource
        Me.SC_Conductor1.SC_ParentKey = "COMPANY_OFFICE_ID"
        '
        'SCM0300DTO01BindingSource
        '
        Me.SCM0300DTO01BindingSource.DataSource = GetType(SCM0300.SCM0300SvcRef.SCM0300DTO01)
        '
        'SCM0300DTO02BindingSource
        '
        Me.SCM0300DTO02BindingSource.DataSource = GetType(SCM0300.SCM0300SvcRef.SCM0300DTO02)
        '
        'SC_Save1
        '
        Me.SC_Save1.Image = CType(resources.GetObject("SC_Save1.Image"), System.Drawing.Image)
        Me.SC_Save1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_Save1.Location = New System.Drawing.Point(260, 12)
        Me.SC_Save1.Name = "SC_Save1"
        Me.SC_Save1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_Save1.Size = New System.Drawing.Size(61, 39)
        Me.SC_Save1.TabIndex = 20
        Me.SC_Save1.Text = "&Save"
        Me.SC_Save1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_Save1.UseVisualStyleBackColor = True
        '
        'SC_Delete1
        '
        Me.SC_Delete1.Image = CType(resources.GetObject("SC_Delete1.Image"), System.Drawing.Image)
        Me.SC_Delete1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_Delete1.Location = New System.Drawing.Point(198, 12)
        Me.SC_Delete1.Name = "SC_Delete1"
        Me.SC_Delete1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_Delete1.Size = New System.Drawing.Size(61, 39)
        Me.SC_Delete1.TabIndex = 19
        Me.SC_Delete1.Text = "&Delete"
        Me.SC_Delete1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_Delete1.UseVisualStyleBackColor = True
        '
        'SC_Edit1
        '
        Me.SC_Edit1.Image = CType(resources.GetObject("SC_Edit1.Image"), System.Drawing.Image)
        Me.SC_Edit1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_Edit1.Location = New System.Drawing.Point(136, 12)
        Me.SC_Edit1.Name = "SC_Edit1"
        Me.SC_Edit1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_Edit1.Size = New System.Drawing.Size(61, 39)
        Me.SC_Edit1.TabIndex = 18
        Me.SC_Edit1.Text = "&Edit"
        Me.SC_Edit1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_Edit1.UseVisualStyleBackColor = True
        '
        'SC_Refresh1
        '
        Me.SC_Refresh1.Image = CType(resources.GetObject("SC_Refresh1.Image"), System.Drawing.Image)
        Me.SC_Refresh1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_Refresh1.Location = New System.Drawing.Point(12, 12)
        Me.SC_Refresh1.Name = "SC_Refresh1"
        Me.SC_Refresh1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_Refresh1.Size = New System.Drawing.Size(61, 39)
        Me.SC_Refresh1.TabIndex = 17
        Me.SC_Refresh1.Text = "&Refresh"
        Me.SC_Refresh1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_Refresh1.UseVisualStyleBackColor = True
        '
        'SC_Cancel1
        '
        Me.SC_Cancel1.Image = CType(resources.GetObject("SC_Cancel1.Image"), System.Drawing.Image)
        Me.SC_Cancel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_Cancel1.Location = New System.Drawing.Point(322, 12)
        Me.SC_Cancel1.Name = "SC_Cancel1"
        Me.SC_Cancel1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_Cancel1.Size = New System.Drawing.Size(61, 39)
        Me.SC_Cancel1.TabIndex = 16
        Me.SC_Cancel1.Text = "&Cancel"
        Me.SC_Cancel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_Cancel1.UseVisualStyleBackColor = True
        '
        'SC_Add1
        '
        Me.SC_Add1.Image = CType(resources.GetObject("SC_Add1.Image"), System.Drawing.Image)
        Me.SC_Add1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_Add1.Location = New System.Drawing.Point(74, 12)
        Me.SC_Add1.Name = "SC_Add1"
        Me.SC_Add1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_Add1.Size = New System.Drawing.Size(61, 39)
        Me.SC_Add1.TabIndex = 15
        Me.SC_Add1.Text = "&Add"
        Me.SC_Add1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_Add1.UseVisualStyleBackColor = True
        '
        'VersionLabel
        '
        Me.VersionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VersionLabel.Location = New System.Drawing.Point(836, 9)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(165, 42)
        Me.VersionLabel.TabIndex = 22
        Me.VersionLabel.Text = "Label1"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabList)
        Me.TabControl1.Controls.Add(Me.TabData)
        Me.TabControl1.Location = New System.Drawing.Point(12, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(989, 441)
        Me.TabControl1.TabIndex = 23
        '
        'TabList
        '
        Me.TabList.AutoScroll = True
        Me.TabList.Controls.Add(Me.SC_GridSearch1)
        Me.TabList.Controls.Add(Me.SCM0300DTO02SC_DataGridView)
        Me.TabList.Location = New System.Drawing.Point(4, 22)
        Me.TabList.Name = "TabList"
        Me.TabList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabList.Size = New System.Drawing.Size(981, 415)
        Me.TabList.TabIndex = 0
        Me.TabList.Text = "List"
        Me.TabList.UseVisualStyleBackColor = True
        '
        'SC_GridSearch1
        '
        Me.SC_GridSearch1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SC_GridSearch1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SC_GridSearch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SC_GridSearch1.Location = New System.Drawing.Point(6, 377)
        Me.SC_GridSearch1.Name = "SC_GridSearch1"
        Me.SC_GridSearch1.SC_BindingSource = Me.SCM0300DTO02BindingSource
        Me.SC_GridSearch1.Size = New System.Drawing.Size(969, 32)
        Me.SC_GridSearch1.TabIndex = 2
        '
        'SCM0300DTO02SC_DataGridView
        '
        Me.SCM0300DTO02SC_DataGridView.AllowUserToAddRows = False
        Me.SCM0300DTO02SC_DataGridView.AllowUserToDeleteRows = False
        Me.SCM0300DTO02SC_DataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCM0300DTO02SC_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.SCM0300DTO02SC_DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SCM0300DTO02SC_DataGridView.AutoGenerateColumns = False
        Me.SCM0300DTO02SC_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SCM0300DTO02SC_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.SCM0300DTO02SC_DataGridView.DataSource = Me.SCM0300DTO02BindingSource
        Me.SCM0300DTO02SC_DataGridView.Location = New System.Drawing.Point(6, 6)
        Me.SCM0300DTO02SC_DataGridView.Name = "SCM0300DTO02SC_DataGridView"
        Me.SCM0300DTO02SC_DataGridView.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCM0300DTO02SC_DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.SCM0300DTO02SC_DataGridView.SC_ConductorSource = Nothing
        Me.SCM0300DTO02SC_DataGridView.Size = New System.Drawing.Size(969, 367)
        Me.SCM0300DTO02SC_DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "COMPANY_OFFICE_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Company Office ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "COMPANY_OFFICE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Company Office Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "COMPANY_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Company ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CREA_BY"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Create By"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CREA_DATE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Create Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UPD_BY"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Update By"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "UPD_DATE"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Update Date"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'TabData
        '
        Me.TabData.Controls.Add(COMPANY_NAMELabel)
        Me.TabData.Controls.Add(Me.COMPANY_NAMESC_ComboBox)
        Me.TabData.Controls.Add(COMPANY_OFFICELabel)
        Me.TabData.Controls.Add(Me.COMPANY_OFFICESC_TextBox)
        Me.TabData.Controls.Add(COMPANY_OFFICE_IDLabel)
        Me.TabData.Controls.Add(Me.COMPANY_OFFICE_IDSC_TextBox)
        Me.TabData.Location = New System.Drawing.Point(4, 22)
        Me.TabData.Name = "TabData"
        Me.TabData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabData.Size = New System.Drawing.Size(981, 415)
        Me.TabData.TabIndex = 1
        Me.TabData.Text = "Data"
        Me.TabData.UseVisualStyleBackColor = True
        '
        'COMPANY_NAMESC_ComboBox
        '
        Me.COMPANY_NAMESC_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SCM0300DTO01BindingSource, "COMPANY_ID", True))
        Me.COMPANY_NAMESC_ComboBox.DataSource = Me.LKM_CompanyDTOBindingSource
        Me.COMPANY_NAMESC_ComboBox.DisplayMember = "COMPANY_NAME"
        Me.COMPANY_NAMESC_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMPANY_NAMESC_ComboBox.FormattingEnabled = True
        Me.COMPANY_NAMESC_ComboBox.Location = New System.Drawing.Point(153, 58)
        Me.COMPANY_NAMESC_ComboBox.Name = "COMPANY_NAMESC_ComboBox"
        Me.COMPANY_NAMESC_ComboBox.SC_ConductorSource = Me.SC_Conductor1
        Me.COMPANY_NAMESC_ComboBox.SC_EnableADD = True
        Me.COMPANY_NAMESC_ComboBox.SC_EnableEDIT = True
        Me.COMPANY_NAMESC_ComboBox.Size = New System.Drawing.Size(276, 21)
        Me.COMPANY_NAMESC_ComboBox.TabIndex = 5
        Me.COMPANY_NAMESC_ComboBox.ValueMember = "COMPANY_ID"
        '
        'LKM_CompanyDTOBindingSource
        '
        Me.LKM_CompanyDTOBindingSource.DataSource = GetType(SCM0300.SCM0300SvcRef.LKM_CompanyDTO)
        '
        'COMPANY_OFFICESC_TextBox
        '
        Me.COMPANY_OFFICESC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.COMPANY_OFFICESC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCM0300DTO01BindingSource, "COMPANY_OFFICE", True))
        Me.COMPANY_OFFICESC_TextBox.Location = New System.Drawing.Point(153, 32)
        Me.COMPANY_OFFICESC_TextBox.Name = "COMPANY_OFFICESC_TextBox"
        Me.COMPANY_OFFICESC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.COMPANY_OFFICESC_TextBox.SC_EnableADD = True
        Me.COMPANY_OFFICESC_TextBox.SC_EnableEDIT = True
        Me.COMPANY_OFFICESC_TextBox.Size = New System.Drawing.Size(247, 21)
        Me.COMPANY_OFFICESC_TextBox.TabIndex = 3
        '
        'COMPANY_OFFICE_IDSC_TextBox
        '
        Me.COMPANY_OFFICE_IDSC_TextBox.BackColor = System.Drawing.Color.White
        Me.COMPANY_OFFICE_IDSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.COMPANY_OFFICE_IDSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCM0300DTO01BindingSource, "COMPANY_OFFICE_ID", True))
        Me.COMPANY_OFFICE_IDSC_TextBox.Location = New System.Drawing.Point(153, 6)
        Me.COMPANY_OFFICE_IDSC_TextBox.Name = "COMPANY_OFFICE_IDSC_TextBox"
        Me.COMPANY_OFFICE_IDSC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.COMPANY_OFFICE_IDSC_TextBox.SC_EnableADD = True
        Me.COMPANY_OFFICE_IDSC_TextBox.Size = New System.Drawing.Size(152, 21)
        Me.COMPANY_OFFICE_IDSC_TextBox.TabIndex = 1
        '
        'SC_ErrorProvider1
        '
        Me.SC_ErrorProvider1.ContainerControl = Me
        '
        'SCM0300Frm
        '
        Me.ClientSize = New System.Drawing.Size(1013, 510)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.SC_ExportCSV1)
        Me.Controls.Add(Me.SC_Save1)
        Me.Controls.Add(Me.SC_Delete1)
        Me.Controls.Add(Me.SC_Edit1)
        Me.Controls.Add(Me.SC_Refresh1)
        Me.Controls.Add(Me.SC_Cancel1)
        Me.Controls.Add(Me.SC_Add1)
        Me.Name = "SCM0300Frm"
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCM0300DTO01BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCM0300DTO02BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        CType(Me.SCM0300DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabData.ResumeLayout(False)
        Me.TabData.PerformLayout()
        CType(Me.LKM_CompanyDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SC_ExportCSV1 As SC_Win_FrontEnd.SC_ExportCSV
    Friend WithEvents SC_Save1 As SC_Win_FrontEnd.SC_Save
    Friend WithEvents SC_Delete1 As SC_Win_FrontEnd.SC_Delete
    Friend WithEvents SC_Edit1 As SC_Win_FrontEnd.SC_Edit
    Friend WithEvents SC_Refresh1 As SC_Win_FrontEnd.SC_Refresh
    Friend WithEvents SC_Cancel1 As SC_Win_FrontEnd.SC_Cancel
    Friend WithEvents SC_Add1 As SC_Win_FrontEnd.SC_Add
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabList As System.Windows.Forms.TabPage
    Friend WithEvents TabData As System.Windows.Forms.TabPage
    Friend WithEvents COMPANY_OFFICE_IDSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents SCM0300DTO01BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SC_Conductor1 As SC_Win_FrontEnd.SC_Conductor
    Friend WithEvents COMPANY_OFFICESC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents COMPANY_NAMESC_ComboBox As SC_Win_FrontEnd.SC_ComboBox
    Friend WithEvents LKM_CompanyDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SC_ErrorProvider1 As SC_Win_FrontEnd.SC_ErrorProvider
    Friend WithEvents SCM0300DTO02BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SCM0300DTO02SC_DataGridView As SC_Win_FrontEnd.SC_DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SC_GridSearch1 As SC_Win_FrontEnd.SC_GridSearch

End Class
