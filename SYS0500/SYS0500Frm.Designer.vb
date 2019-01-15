<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SYS0500Frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SYS0500Frm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim USER_IDLabel As System.Windows.Forms.Label
        Dim COMPANY_NAMELabel As System.Windows.Forms.Label
        Dim REGIONAL_NAMELabel As System.Windows.Forms.Label
        Me.SC_Conductor1 = New SC_Win_FrontEnd.SC_Conductor(Me.components)
        Me.SC_ErrorProvider1 = New SC_Win_FrontEnd.SC_ErrorProvider(Me.components)
        Me.SC_ExportCSV1 = New SC_Win_FrontEnd.SC_ExportCSV(Me.components)
        Me.SC_Save1 = New SC_Win_FrontEnd.SC_Save()
        Me.SC_Delete1 = New SC_Win_FrontEnd.SC_Delete()
        Me.SC_Edit1 = New SC_Win_FrontEnd.SC_Edit()
        Me.SC_Refresh1 = New SC_Win_FrontEnd.SC_Refresh()
        Me.SC_Cancel1 = New SC_Win_FrontEnd.SC_Cancel()
        Me.SC_Add1 = New SC_Win_FrontEnd.SC_Add()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabList = New System.Windows.Forms.TabPage()
        Me.TabData = New System.Windows.Forms.TabPage()
        Me.SYS0500DTO02BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SYS0500DTO02SC_DataGridView = New SC_Win_FrontEnd.SC_DataGridView()
        Me.SYS0500DTO01BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USER_IDSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.SC_GridSearch1 = New SC_Win_FrontEnd.SC_GridSearch()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LKM_CompanyDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMPANY_NAMESC_ComboBox = New SC_Win_FrontEnd.SC_ComboBox()
        Me.LKM_RegionalDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REGIONAL_NAMESC_ComboBox = New SC_Win_FrontEnd.SC_ComboBox()
        USER_IDLabel = New System.Windows.Forms.Label()
        COMPANY_NAMELabel = New System.Windows.Forms.Label()
        REGIONAL_NAMELabel = New System.Windows.Forms.Label()
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabList.SuspendLayout()
        Me.TabData.SuspendLayout()
        CType(Me.SYS0500DTO02BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYS0500DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYS0500DTO01BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LKM_CompanyDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LKM_RegionalDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SC_Conductor1
        '
        Me.SC_Conductor1.SC_BindingSource = Me.SYS0500DTO01BindingSource
        Me.SC_Conductor1.SC_ParentBindingSource = Me.SYS0500DTO02BindingSource
        Me.SC_Conductor1.SC_ParentKey = "USER_ID"
        '
        'SC_ErrorProvider1
        '
        Me.SC_ErrorProvider1.ContainerControl = Me
        '
        'SC_ExportCSV1
        '
        Me.SC_ExportCSV1.Image = CType(resources.GetObject("SC_ExportCSV1.Image"), System.Drawing.Image)
        Me.SC_ExportCSV1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_ExportCSV1.Location = New System.Drawing.Point(384, 12)
        Me.SC_ExportCSV1.Name = "SC_ExportCSV1"
        Me.SC_ExportCSV1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_ExportCSV1.SC_DataGridView = Nothing
        Me.SC_ExportCSV1.SC_DefaultFileName = "Master System Role"
        Me.SC_ExportCSV1.Size = New System.Drawing.Size(61, 39)
        Me.SC_ExportCSV1.TabIndex = 49
        Me.SC_ExportCSV1.Text = "E&xport"
        Me.SC_ExportCSV1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_ExportCSV1.UseVisualStyleBackColor = True
        '
        'SC_Save1
        '
        Me.SC_Save1.Image = CType(resources.GetObject("SC_Save1.Image"), System.Drawing.Image)
        Me.SC_Save1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_Save1.Location = New System.Drawing.Point(260, 12)
        Me.SC_Save1.Name = "SC_Save1"
        Me.SC_Save1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_Save1.Size = New System.Drawing.Size(61, 39)
        Me.SC_Save1.TabIndex = 48
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
        Me.SC_Delete1.TabIndex = 47
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
        Me.SC_Edit1.TabIndex = 46
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
        Me.SC_Refresh1.TabIndex = 45
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
        Me.SC_Cancel1.TabIndex = 44
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
        Me.SC_Add1.TabIndex = 43
        Me.SC_Add1.Text = "&Add"
        Me.SC_Add1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_Add1.UseVisualStyleBackColor = True
        '
        'VersionLabel
        '
        Me.VersionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VersionLabel.Location = New System.Drawing.Point(918, 9)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(165, 42)
        Me.VersionLabel.TabIndex = 50
        Me.VersionLabel.Text = "Label1"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabList)
        Me.TabControl1.Controls.Add(Me.TabData)
        Me.TabControl1.Location = New System.Drawing.Point(12, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1071, 439)
        Me.TabControl1.TabIndex = 51
        '
        'TabList
        '
        Me.TabList.Controls.Add(Me.SC_GridSearch1)
        Me.TabList.Controls.Add(Me.SYS0500DTO02SC_DataGridView)
        Me.TabList.Location = New System.Drawing.Point(4, 22)
        Me.TabList.Name = "TabList"
        Me.TabList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabList.Size = New System.Drawing.Size(1063, 413)
        Me.TabList.TabIndex = 0
        Me.TabList.Text = "List"
        Me.TabList.UseVisualStyleBackColor = True
        '
        'TabData
        '
        Me.TabData.Controls.Add(REGIONAL_NAMELabel)
        Me.TabData.Controls.Add(Me.REGIONAL_NAMESC_ComboBox)
        Me.TabData.Controls.Add(COMPANY_NAMELabel)
        Me.TabData.Controls.Add(Me.COMPANY_NAMESC_ComboBox)
        Me.TabData.Controls.Add(USER_IDLabel)
        Me.TabData.Controls.Add(Me.USER_IDSC_TextBox)
        Me.TabData.Location = New System.Drawing.Point(4, 22)
        Me.TabData.Name = "TabData"
        Me.TabData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabData.Size = New System.Drawing.Size(1063, 413)
        Me.TabData.TabIndex = 1
        Me.TabData.Text = "Data"
        Me.TabData.UseVisualStyleBackColor = True
        '
        'SYS0500DTO02BindingSource
        '
        Me.SYS0500DTO02BindingSource.DataSource = GetType(SYS0500.SYS0500SvcRef.SYS0500DTO02)
        '
        'SYS0500DTO02SC_DataGridView
        '
        Me.SYS0500DTO02SC_DataGridView.AllowUserToAddRows = False
        Me.SYS0500DTO02SC_DataGridView.AllowUserToDeleteRows = False
        Me.SYS0500DTO02SC_DataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYS0500DTO02SC_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.SYS0500DTO02SC_DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SYS0500DTO02SC_DataGridView.AutoGenerateColumns = False
        Me.SYS0500DTO02SC_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SYS0500DTO02SC_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.SYS0500DTO02SC_DataGridView.DataSource = Me.SYS0500DTO02BindingSource
        Me.SYS0500DTO02SC_DataGridView.Location = New System.Drawing.Point(6, 6)
        Me.SYS0500DTO02SC_DataGridView.Name = "SYS0500DTO02SC_DataGridView"
        Me.SYS0500DTO02SC_DataGridView.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYS0500DTO02SC_DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.SYS0500DTO02SC_DataGridView.SC_ConductorSource = Nothing
        Me.SYS0500DTO02SC_DataGridView.Size = New System.Drawing.Size(1051, 363)
        Me.SYS0500DTO02SC_DataGridView.TabIndex = 0
        '
        'SYS0500DTO01BindingSource
        '
        Me.SYS0500DTO01BindingSource.DataSource = GetType(SYS0500.SYS0500SvcRef.SYS0500DTO01)
        '
        'USER_IDLabel
        '
        USER_IDLabel.AutoSize = True
        USER_IDLabel.Location = New System.Drawing.Point(63, 9)
        USER_IDLabel.Name = "USER_IDLabel"
        USER_IDLabel.Size = New System.Drawing.Size(51, 13)
        USER_IDLabel.TabIndex = 0
        USER_IDLabel.Text = "USER ID:"
        '
        'USER_IDSC_TextBox
        '
        Me.USER_IDSC_TextBox.BackColor = System.Drawing.Color.White
        Me.USER_IDSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.USER_IDSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SYS0500DTO01BindingSource, "USER_ID", True))
        Me.USER_IDSC_TextBox.Location = New System.Drawing.Point(120, 6)
        Me.USER_IDSC_TextBox.Name = "USER_IDSC_TextBox"
        Me.USER_IDSC_TextBox.SC_ConductorSource = Nothing
        Me.USER_IDSC_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.USER_IDSC_TextBox.TabIndex = 1
        '
        'SC_GridSearch1
        '
        Me.SC_GridSearch1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SC_GridSearch1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SC_GridSearch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SC_GridSearch1.Location = New System.Drawing.Point(6, 375)
        Me.SC_GridSearch1.Name = "SC_GridSearch1"
        Me.SC_GridSearch1.SC_BindingSource = Me.SYS0500DTO02BindingSource
        Me.SC_GridSearch1.Size = New System.Drawing.Size(1051, 32)
        Me.SC_GridSearch1.TabIndex = 3
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "USER_ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "User ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "COMPANY_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Company"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "COMPANY_OFFICE_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Office"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "COMPANY_OFFICE_MAP_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Office Map"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "VALID_FROM"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Valid From"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "VALID_TO"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Valid To"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CREA_BY"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Create By"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CREA_DATE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Create Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
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
        'LKM_CompanyDTOBindingSource
        '
        Me.LKM_CompanyDTOBindingSource.DataSource = GetType(SYS0500.SYS0500SvcRef.LKM_CompanyDTO)
        '
        'COMPANY_NAMELabel
        '
        COMPANY_NAMELabel.AutoSize = True
        COMPANY_NAMELabel.Location = New System.Drawing.Point(23, 63)
        COMPANY_NAMELabel.Name = "COMPANY_NAMELabel"
        COMPANY_NAMELabel.Size = New System.Drawing.Size(91, 13)
        COMPANY_NAMELabel.TabIndex = 2
        COMPANY_NAMELabel.Text = "COMPANY NAME:"
        '
        'COMPANY_NAMESC_ComboBox
        '
        Me.COMPANY_NAMESC_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LKM_CompanyDTOBindingSource, "COMPANY_NAME", True))
        Me.COMPANY_NAMESC_ComboBox.FormattingEnabled = True
        Me.COMPANY_NAMESC_ComboBox.Location = New System.Drawing.Point(120, 60)
        Me.COMPANY_NAMESC_ComboBox.Name = "COMPANY_NAMESC_ComboBox"
        Me.COMPANY_NAMESC_ComboBox.SC_ConductorSource = Nothing
        Me.COMPANY_NAMESC_ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.COMPANY_NAMESC_ComboBox.TabIndex = 3
        '
        'LKM_RegionalDTOBindingSource
        '
        Me.LKM_RegionalDTOBindingSource.DataSource = GetType(SYS0500.SYS0500SvcRef.LKM_RegionalDTO)
        '
        'REGIONAL_NAMELabel
        '
        REGIONAL_NAMELabel.AutoSize = True
        REGIONAL_NAMELabel.Location = New System.Drawing.Point(21, 36)
        REGIONAL_NAMELabel.Name = "REGIONAL_NAMELabel"
        REGIONAL_NAMELabel.Size = New System.Drawing.Size(93, 13)
        REGIONAL_NAMELabel.TabIndex = 4
        REGIONAL_NAMELabel.Text = "REGIONAL NAME:"
        '
        'REGIONAL_NAMESC_ComboBox
        '
        Me.REGIONAL_NAMESC_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LKM_RegionalDTOBindingSource, "REGIONAL_NAME", True))
        Me.REGIONAL_NAMESC_ComboBox.FormattingEnabled = True
        Me.REGIONAL_NAMESC_ComboBox.Location = New System.Drawing.Point(120, 33)
        Me.REGIONAL_NAMESC_ComboBox.Name = "REGIONAL_NAMESC_ComboBox"
        Me.REGIONAL_NAMESC_ComboBox.SC_ConductorSource = Nothing
        Me.REGIONAL_NAMESC_ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.REGIONAL_NAMESC_ComboBox.TabIndex = 5
        '
        'SYS0500Frm
        '
        Me.ClientSize = New System.Drawing.Size(1095, 508)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.SC_ExportCSV1)
        Me.Controls.Add(Me.SC_Save1)
        Me.Controls.Add(Me.SC_Delete1)
        Me.Controls.Add(Me.SC_Edit1)
        Me.Controls.Add(Me.SC_Refresh1)
        Me.Controls.Add(Me.SC_Cancel1)
        Me.Controls.Add(Me.SC_Add1)
        Me.Name = "SYS0500Frm"
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        Me.TabData.ResumeLayout(False)
        Me.TabData.PerformLayout()
        CType(Me.SYS0500DTO02BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYS0500DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYS0500DTO01BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LKM_CompanyDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LKM_RegionalDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SC_Conductor1 As SC_Win_FrontEnd.SC_Conductor
    Friend WithEvents SC_ErrorProvider1 As SC_Win_FrontEnd.SC_ErrorProvider
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
    Friend WithEvents SYS0500DTO01BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SYS0500DTO02BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SYS0500DTO02SC_DataGridView As SC_Win_FrontEnd.SC_DataGridView
    Friend WithEvents USER_IDSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents SC_GridSearch1 As SC_Win_FrontEnd.SC_GridSearch
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REGIONAL_NAMESC_ComboBox As SC_Win_FrontEnd.SC_ComboBox
    Friend WithEvents LKM_RegionalDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMPANY_NAMESC_ComboBox As SC_Win_FrontEnd.SC_ComboBox
    Friend WithEvents LKM_CompanyDTOBindingSource As System.Windows.Forms.BindingSource

End Class
