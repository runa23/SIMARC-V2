<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SYS0300Frm
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
        Dim APP_IDLabel As System.Windows.Forms.Label
        Dim APP_GROUP_IDLabel As System.Windows.Forms.Label
        Dim PARAMETER_VALUELabel As System.Windows.Forms.Label
        Dim MODULE_IDLabel As System.Windows.Forms.Label
        Dim APP_NAMELabel As System.Windows.Forms.Label
        Dim VERSIONLabel1 As System.Windows.Forms.Label
        Dim APP_DESCLabel As System.Windows.Forms.Label
        Dim DLL_FILELabel As System.Windows.Forms.Label
        Dim DLL_FILE_VERSIONLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SYS0300Frm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SC_Conductor1 = New SC_Win_FrontEnd.SC_Conductor(Me.components)
        Me.SYS0300DTO01BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SYS0300DTO02BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SC_ErrorProvider1 = New SC_Win_FrontEnd.SC_ErrorProvider(Me.components)
        Me.SC_ExportCSV1 = New SC_Win_FrontEnd.SC_ExportCSV(Me.components)
        Me.SYS0300DTO02SC_DataGridView = New SC_Win_FrontEnd.SC_DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabData = New System.Windows.Forms.TabPage()
        Me.DllFileBrowseSC_Button = New SC_Win_FrontEnd.SC_Button()
        Me.DLL_FILE_VERSIONSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.DLL_FILESC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.UPDATE_DLL_FILESC_CheckBox = New SC_Win_FrontEnd.SC_CheckBox()
        Me.APP_DESCSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.VERSIONSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.APP_NAMESC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.MODULE_IDSC_ComboBox = New SC_Win_FrontEnd.SC_ComboBox()
        Me.LKM_SysModuleDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_TYPESC_ComboBox = New SC_Win_FrontEnd.SC_ComboBox()
        Me.LKM_SysAppTypeDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_GROUP_IDSC_ComboBox = New SC_Win_FrontEnd.SC_ComboBox()
        Me.LKM_SysAppGroupDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.APP_IDSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        APP_IDLabel = New System.Windows.Forms.Label()
        APP_GROUP_IDLabel = New System.Windows.Forms.Label()
        PARAMETER_VALUELabel = New System.Windows.Forms.Label()
        MODULE_IDLabel = New System.Windows.Forms.Label()
        APP_NAMELabel = New System.Windows.Forms.Label()
        VERSIONLabel1 = New System.Windows.Forms.Label()
        APP_DESCLabel = New System.Windows.Forms.Label()
        DLL_FILELabel = New System.Windows.Forms.Label()
        DLL_FILE_VERSIONLabel = New System.Windows.Forms.Label()
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYS0300DTO01BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYS0300DTO02BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYS0300DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabList.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabData.SuspendLayout()
        CType(Me.LKM_SysModuleDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LKM_SysAppTypeDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LKM_SysAppGroupDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'APP_IDLabel
        '
        APP_IDLabel.AutoSize = True
        APP_IDLabel.Location = New System.Drawing.Point(58, 9)
        APP_IDLabel.Name = "APP_IDLabel"
        APP_IDLabel.Size = New System.Drawing.Size(56, 13)
        APP_IDLabel.TabIndex = 0
        APP_IDLabel.Text = "* App ID :"
        '
        'APP_GROUP_IDLabel
        '
        APP_GROUP_IDLabel.AutoSize = True
        APP_GROUP_IDLabel.Location = New System.Drawing.Point(49, 36)
        APP_GROUP_IDLabel.Name = "APP_GROUP_IDLabel"
        APP_GROUP_IDLabel.Size = New System.Drawing.Size(65, 13)
        APP_GROUP_IDLabel.TabIndex = 2
        APP_GROUP_IDLabel.Text = "App Group :"
        '
        'PARAMETER_VALUELabel
        '
        PARAMETER_VALUELabel.AutoSize = True
        PARAMETER_VALUELabel.Location = New System.Drawing.Point(54, 63)
        PARAMETER_VALUELabel.Name = "PARAMETER_VALUELabel"
        PARAMETER_VALUELabel.Size = New System.Drawing.Size(60, 13)
        PARAMETER_VALUELabel.TabIndex = 4
        PARAMETER_VALUELabel.Text = "App Type :"
        '
        'MODULE_IDLabel
        '
        MODULE_IDLabel.AutoSize = True
        MODULE_IDLabel.Location = New System.Drawing.Point(66, 90)
        MODULE_IDLabel.Name = "MODULE_IDLabel"
        MODULE_IDLabel.Size = New System.Drawing.Size(48, 13)
        MODULE_IDLabel.TabIndex = 6
        MODULE_IDLabel.Text = "Module :"
        '
        'APP_NAMELabel
        '
        APP_NAMELabel.AutoSize = True
        APP_NAMELabel.Location = New System.Drawing.Point(51, 117)
        APP_NAMELabel.Name = "APP_NAMELabel"
        APP_NAMELabel.Size = New System.Drawing.Size(63, 13)
        APP_NAMELabel.TabIndex = 8
        APP_NAMELabel.Text = "App Name :"
        '
        'VERSIONLabel1
        '
        VERSIONLabel1.AutoSize = True
        VERSIONLabel1.Location = New System.Drawing.Point(65, 171)
        VERSIONLabel1.Name = "VERSIONLabel1"
        VERSIONLabel1.Size = New System.Drawing.Size(49, 13)
        VERSIONLabel1.TabIndex = 12
        VERSIONLabel1.Text = "Version :"
        '
        'APP_DESCLabel
        '
        APP_DESCLabel.AutoSize = True
        APP_DESCLabel.Location = New System.Drawing.Point(55, 144)
        APP_DESCLabel.Name = "APP_DESCLabel"
        APP_DESCLabel.Size = New System.Drawing.Size(59, 13)
        APP_DESCLabel.TabIndex = 10
        APP_DESCLabel.Text = "App Desc :"
        '
        'DLL_FILELabel
        '
        DLL_FILELabel.AutoSize = True
        DLL_FILELabel.Location = New System.Drawing.Point(411, 36)
        DLL_FILELabel.Name = "DLL_FILELabel"
        DLL_FILELabel.Size = New System.Drawing.Size(52, 13)
        DLL_FILELabel.TabIndex = 15
        DLL_FILELabel.Text = "DLL FILE:"
        '
        'DLL_FILE_VERSIONLabel
        '
        DLL_FILE_VERSIONLabel.AutoSize = True
        DLL_FILE_VERSIONLabel.Location = New System.Drawing.Point(364, 63)
        DLL_FILE_VERSIONLabel.Name = "DLL_FILE_VERSIONLabel"
        DLL_FILE_VERSIONLabel.Size = New System.Drawing.Size(99, 13)
        DLL_FILE_VERSIONLabel.TabIndex = 17
        DLL_FILE_VERSIONLabel.Text = "DLL FILE VERSION:"
        '
        'SC_Conductor1
        '
        Me.SC_Conductor1.SC_BindingSource = Me.SYS0300DTO01BindingSource
        Me.SC_Conductor1.SC_ParentBindingSource = Me.SYS0300DTO02BindingSource
        Me.SC_Conductor1.SC_ParentKey = "APP_ID"
        '
        'SYS0300DTO01BindingSource
        '
        Me.SYS0300DTO01BindingSource.DataSource = GetType(SYS0300.SYS0300SvcRef.SYS0300DTO01)
        '
        'SYS0300DTO02BindingSource
        '
        Me.SYS0300DTO02BindingSource.DataSource = GetType(SYS0300.SYS0300SvcRef.SYS0300DTO02)
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
        Me.SC_ExportCSV1.SC_DataGridView = Me.SYS0300DTO02SC_DataGridView
        Me.SC_ExportCSV1.SC_DefaultFileName = "Application"
        Me.SC_ExportCSV1.Size = New System.Drawing.Size(61, 39)
        Me.SC_ExportCSV1.TabIndex = 42
        Me.SC_ExportCSV1.Text = "E&xport"
        Me.SC_ExportCSV1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_ExportCSV1.UseVisualStyleBackColor = True
        '
        'SYS0300DTO02SC_DataGridView
        '
        Me.SYS0300DTO02SC_DataGridView.AllowUserToAddRows = False
        Me.SYS0300DTO02SC_DataGridView.AllowUserToDeleteRows = False
        Me.SYS0300DTO02SC_DataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYS0300DTO02SC_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.SYS0300DTO02SC_DataGridView.AutoGenerateColumns = False
        Me.SYS0300DTO02SC_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SYS0300DTO02SC_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.SYS0300DTO02SC_DataGridView.DataSource = Me.SYS0300DTO02BindingSource
        Me.SYS0300DTO02SC_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SYS0300DTO02SC_DataGridView.Location = New System.Drawing.Point(3, 134)
        Me.SYS0300DTO02SC_DataGridView.Name = "SYS0300DTO02SC_DataGridView"
        Me.SYS0300DTO02SC_DataGridView.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYS0300DTO02SC_DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.SYS0300DTO02SC_DataGridView.SC_ConductorSource = Nothing
        Me.SYS0300DTO02SC_DataGridView.Size = New System.Drawing.Size(962, 279)
        Me.SYS0300DTO02SC_DataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "APP_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "App ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "APP_GROUP_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "App Group ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "APP_TYPE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "App Type"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "MODULE_ID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Module"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "APP_NAME"
        Me.DataGridViewTextBoxColumn4.HeaderText = "App Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "APP_DESC"
        Me.DataGridViewTextBoxColumn1.HeaderText = "App Desc"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "VERSION"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Version"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CREA_BY"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Create By"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CREA_DATE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Create Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
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
        'SC_Save1
        '
        Me.SC_Save1.Image = CType(resources.GetObject("SC_Save1.Image"), System.Drawing.Image)
        Me.SC_Save1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_Save1.Location = New System.Drawing.Point(260, 12)
        Me.SC_Save1.Name = "SC_Save1"
        Me.SC_Save1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_Save1.Size = New System.Drawing.Size(61, 39)
        Me.SC_Save1.TabIndex = 41
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
        Me.SC_Delete1.TabIndex = 40
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
        Me.SC_Edit1.TabIndex = 39
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
        Me.SC_Refresh1.TabIndex = 38
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
        Me.SC_Cancel1.TabIndex = 37
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
        Me.SC_Add1.TabIndex = 36
        Me.SC_Add1.Text = "&Add"
        Me.SC_Add1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_Add1.UseVisualStyleBackColor = True
        '
        'VersionLabel
        '
        Me.VersionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VersionLabel.Location = New System.Drawing.Point(823, 9)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(165, 42)
        Me.VersionLabel.TabIndex = 43
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
        Me.TabControl1.Size = New System.Drawing.Size(976, 442)
        Me.TabControl1.TabIndex = 44
        '
        'TabList
        '
        Me.TabList.AutoScroll = True
        Me.TabList.Controls.Add(Me.SYS0300DTO02SC_DataGridView)
        Me.TabList.Controls.Add(Me.SC_GridSearch1)
        Me.TabList.Controls.Add(Me.Panel1)
        Me.TabList.Location = New System.Drawing.Point(4, 22)
        Me.TabList.Name = "TabList"
        Me.TabList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabList.Size = New System.Drawing.Size(968, 416)
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
        Me.SC_GridSearch1.Location = New System.Drawing.Point(6, 378)
        Me.SC_GridSearch1.Name = "SC_GridSearch1"
        Me.SC_GridSearch1.SC_BindingSource = Nothing
        Me.SC_GridSearch1.Size = New System.Drawing.Size(956, 32)
        Me.SC_GridSearch1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 131)
        Me.Panel1.TabIndex = 3
        Me.Panel1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Query Data>>"
        '
        'TabData
        '
        Me.TabData.Controls.Add(Me.DllFileBrowseSC_Button)
        Me.TabData.Controls.Add(DLL_FILE_VERSIONLabel)
        Me.TabData.Controls.Add(Me.DLL_FILE_VERSIONSC_TextBox)
        Me.TabData.Controls.Add(DLL_FILELabel)
        Me.TabData.Controls.Add(Me.DLL_FILESC_TextBox)
        Me.TabData.Controls.Add(Me.UPDATE_DLL_FILESC_CheckBox)
        Me.TabData.Controls.Add(APP_DESCLabel)
        Me.TabData.Controls.Add(Me.APP_DESCSC_TextBox)
        Me.TabData.Controls.Add(VERSIONLabel1)
        Me.TabData.Controls.Add(Me.VERSIONSC_TextBox)
        Me.TabData.Controls.Add(APP_NAMELabel)
        Me.TabData.Controls.Add(Me.APP_NAMESC_TextBox)
        Me.TabData.Controls.Add(MODULE_IDLabel)
        Me.TabData.Controls.Add(Me.MODULE_IDSC_ComboBox)
        Me.TabData.Controls.Add(PARAMETER_VALUELabel)
        Me.TabData.Controls.Add(Me.APP_TYPESC_ComboBox)
        Me.TabData.Controls.Add(APP_GROUP_IDLabel)
        Me.TabData.Controls.Add(Me.APP_GROUP_IDSC_ComboBox)
        Me.TabData.Controls.Add(APP_IDLabel)
        Me.TabData.Controls.Add(Me.APP_IDSC_TextBox)
        Me.TabData.Location = New System.Drawing.Point(4, 22)
        Me.TabData.Name = "TabData"
        Me.TabData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabData.Size = New System.Drawing.Size(968, 416)
        Me.TabData.TabIndex = 1
        Me.TabData.Text = "Data"
        Me.TabData.UseVisualStyleBackColor = True
        '
        'DllFileBrowseSC_Button
        '
        Me.DllFileBrowseSC_Button.Enabled = False
        Me.DllFileBrowseSC_Button.Location = New System.Drawing.Point(773, 31)
        Me.DllFileBrowseSC_Button.Name = "DllFileBrowseSC_Button"
        Me.DllFileBrowseSC_Button.SC_ConductorSource = Nothing
        Me.DllFileBrowseSC_Button.Size = New System.Drawing.Size(75, 23)
        Me.DllFileBrowseSC_Button.TabIndex = 19
        Me.DllFileBrowseSC_Button.Text = "Browse"
        Me.DllFileBrowseSC_Button.UseVisualStyleBackColor = True
        '
        'DLL_FILE_VERSIONSC_TextBox
        '
        Me.DLL_FILE_VERSIONSC_TextBox.BackColor = System.Drawing.SystemColors.Control
        Me.DLL_FILE_VERSIONSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DLL_FILE_VERSIONSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SYS0300DTO01BindingSource, "DLL_FILE_VERSION", True))
        Me.DLL_FILE_VERSIONSC_TextBox.Enabled = False
        Me.DLL_FILE_VERSIONSC_TextBox.Location = New System.Drawing.Point(469, 60)
        Me.DLL_FILE_VERSIONSC_TextBox.Name = "DLL_FILE_VERSIONSC_TextBox"
        Me.DLL_FILE_VERSIONSC_TextBox.ReadOnly = True
        Me.DLL_FILE_VERSIONSC_TextBox.SC_ConductorSource = Nothing
        Me.DLL_FILE_VERSIONSC_TextBox.Size = New System.Drawing.Size(131, 21)
        Me.DLL_FILE_VERSIONSC_TextBox.TabIndex = 18
        '
        'DLL_FILESC_TextBox
        '
        Me.DLL_FILESC_TextBox.BackColor = System.Drawing.SystemColors.Control
        Me.DLL_FILESC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DLL_FILESC_TextBox.Enabled = False
        Me.DLL_FILESC_TextBox.Location = New System.Drawing.Point(469, 33)
        Me.DLL_FILESC_TextBox.Name = "DLL_FILESC_TextBox"
        Me.DLL_FILESC_TextBox.ReadOnly = True
        Me.DLL_FILESC_TextBox.SC_ConductorSource = Nothing
        Me.DLL_FILESC_TextBox.Size = New System.Drawing.Size(298, 21)
        Me.DLL_FILESC_TextBox.TabIndex = 16
        '
        'UPDATE_DLL_FILESC_CheckBox
        '
        Me.UPDATE_DLL_FILESC_CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SYS0300DTO01BindingSource, "UPDATE_DLL_FILE", True))
        Me.UPDATE_DLL_FILESC_CheckBox.Location = New System.Drawing.Point(469, 6)
        Me.UPDATE_DLL_FILESC_CheckBox.Name = "UPDATE_DLL_FILESC_CheckBox"
        Me.UPDATE_DLL_FILESC_CheckBox.SC_ConductorSource = Nothing
        Me.UPDATE_DLL_FILESC_CheckBox.Size = New System.Drawing.Size(104, 24)
        Me.UPDATE_DLL_FILESC_CheckBox.TabIndex = 15
        Me.UPDATE_DLL_FILESC_CheckBox.Text = "Update dll File"
        Me.UPDATE_DLL_FILESC_CheckBox.UseVisualStyleBackColor = True
        '
        'APP_DESCSC_TextBox
        '
        Me.APP_DESCSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.APP_DESCSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SYS0300DTO01BindingSource, "APP_DESC", True))
        Me.APP_DESCSC_TextBox.Location = New System.Drawing.Point(120, 141)
        Me.APP_DESCSC_TextBox.Name = "APP_DESCSC_TextBox"
        Me.APP_DESCSC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.APP_DESCSC_TextBox.SC_EnableADD = True
        Me.APP_DESCSC_TextBox.SC_EnableEDIT = True
        Me.APP_DESCSC_TextBox.Size = New System.Drawing.Size(247, 21)
        Me.APP_DESCSC_TextBox.TabIndex = 11
        '
        'VERSIONSC_TextBox
        '
        Me.VERSIONSC_TextBox.BackColor = System.Drawing.SystemColors.Control
        Me.VERSIONSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.VERSIONSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SYS0300DTO01BindingSource, "VERSION", True))
        Me.VERSIONSC_TextBox.Enabled = False
        Me.VERSIONSC_TextBox.Location = New System.Drawing.Point(120, 168)
        Me.VERSIONSC_TextBox.Name = "VERSIONSC_TextBox"
        Me.VERSIONSC_TextBox.ReadOnly = True
        Me.VERSIONSC_TextBox.SC_ConductorSource = Nothing
        Me.VERSIONSC_TextBox.Size = New System.Drawing.Size(141, 21)
        Me.VERSIONSC_TextBox.TabIndex = 13
        '
        'APP_NAMESC_TextBox
        '
        Me.APP_NAMESC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.APP_NAMESC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SYS0300DTO01BindingSource, "APP_NAME", True))
        Me.APP_NAMESC_TextBox.Location = New System.Drawing.Point(120, 114)
        Me.APP_NAMESC_TextBox.Name = "APP_NAMESC_TextBox"
        Me.APP_NAMESC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.APP_NAMESC_TextBox.SC_EnableADD = True
        Me.APP_NAMESC_TextBox.SC_EnableEDIT = True
        Me.APP_NAMESC_TextBox.Size = New System.Drawing.Size(247, 21)
        Me.APP_NAMESC_TextBox.TabIndex = 9
        '
        'MODULE_IDSC_ComboBox
        '
        Me.MODULE_IDSC_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SYS0300DTO01BindingSource, "MODULE_ID", True))
        Me.MODULE_IDSC_ComboBox.DataSource = Me.LKM_SysModuleDTOBindingSource
        Me.MODULE_IDSC_ComboBox.DisplayMember = "MODULE_NAME"
        Me.MODULE_IDSC_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MODULE_IDSC_ComboBox.FormattingEnabled = True
        Me.MODULE_IDSC_ComboBox.Location = New System.Drawing.Point(120, 87)
        Me.MODULE_IDSC_ComboBox.Name = "MODULE_IDSC_ComboBox"
        Me.MODULE_IDSC_ComboBox.SC_ConductorSource = Me.SC_Conductor1
        Me.MODULE_IDSC_ComboBox.SC_EnableADD = True
        Me.MODULE_IDSC_ComboBox.SC_EnableEDIT = True
        Me.MODULE_IDSC_ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MODULE_IDSC_ComboBox.TabIndex = 7
        Me.MODULE_IDSC_ComboBox.ValueMember = "MODULE_ID"
        '
        'LKM_SysModuleDTOBindingSource
        '
        Me.LKM_SysModuleDTOBindingSource.DataSource = GetType(SYS0300.SYS0300SvcRef.LKM_SysModuleDTO)
        '
        'APP_TYPESC_ComboBox
        '
        Me.APP_TYPESC_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SYS0300DTO01BindingSource, "APP_TYPE", True))
        Me.APP_TYPESC_ComboBox.DataSource = Me.LKM_SysAppTypeDTOBindingSource
        Me.APP_TYPESC_ComboBox.DisplayMember = "PARAMETER_VALUE"
        Me.APP_TYPESC_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.APP_TYPESC_ComboBox.FormattingEnabled = True
        Me.APP_TYPESC_ComboBox.Location = New System.Drawing.Point(120, 60)
        Me.APP_TYPESC_ComboBox.Name = "APP_TYPESC_ComboBox"
        Me.APP_TYPESC_ComboBox.SC_ConductorSource = Me.SC_Conductor1
        Me.APP_TYPESC_ComboBox.SC_EnableADD = True
        Me.APP_TYPESC_ComboBox.SC_EnableEDIT = True
        Me.APP_TYPESC_ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.APP_TYPESC_ComboBox.TabIndex = 5
        Me.APP_TYPESC_ComboBox.ValueMember = "PARAMETER_VALUE"
        '
        'LKM_SysAppTypeDTOBindingSource
        '
        Me.LKM_SysAppTypeDTOBindingSource.DataSource = GetType(SYS0300.SYS0300SvcRef.LKM_SysAppTypeDTO)
        '
        'APP_GROUP_IDSC_ComboBox
        '
        Me.APP_GROUP_IDSC_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SYS0300DTO01BindingSource, "APP_GROUP_ID", True))
        Me.APP_GROUP_IDSC_ComboBox.DataSource = Me.LKM_SysAppGroupDTOBindingSource
        Me.APP_GROUP_IDSC_ComboBox.DisplayMember = "APP_GROUP_NAME"
        Me.APP_GROUP_IDSC_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.APP_GROUP_IDSC_ComboBox.FormattingEnabled = True
        Me.APP_GROUP_IDSC_ComboBox.Location = New System.Drawing.Point(120, 33)
        Me.APP_GROUP_IDSC_ComboBox.Name = "APP_GROUP_IDSC_ComboBox"
        Me.APP_GROUP_IDSC_ComboBox.SC_ConductorSource = Me.SC_Conductor1
        Me.APP_GROUP_IDSC_ComboBox.SC_EnableADD = True
        Me.APP_GROUP_IDSC_ComboBox.SC_EnableEDIT = True
        Me.APP_GROUP_IDSC_ComboBox.Size = New System.Drawing.Size(152, 21)
        Me.APP_GROUP_IDSC_ComboBox.TabIndex = 3
        Me.APP_GROUP_IDSC_ComboBox.ValueMember = "APP_GROUP_ID"
        '
        'LKM_SysAppGroupDTOBindingSource
        '
        Me.LKM_SysAppGroupDTOBindingSource.DataSource = GetType(SYS0300.SYS0300SvcRef.LKM_SysAppGroupDTO)
        '
        'APP_IDSC_TextBox
        '
        Me.APP_IDSC_TextBox.BackColor = System.Drawing.Color.White
        Me.APP_IDSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.APP_IDSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SYS0300DTO01BindingSource, "APP_ID", True))
        Me.APP_IDSC_TextBox.Location = New System.Drawing.Point(120, 6)
        Me.APP_IDSC_TextBox.Name = "APP_IDSC_TextBox"
        Me.APP_IDSC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.APP_IDSC_TextBox.SC_EnableADD = True
        Me.APP_IDSC_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.APP_IDSC_TextBox.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SYS0300Frm
        '
        Me.ClientSize = New System.Drawing.Size(1000, 511)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.SC_ExportCSV1)
        Me.Controls.Add(Me.SC_Save1)
        Me.Controls.Add(Me.SC_Delete1)
        Me.Controls.Add(Me.SC_Edit1)
        Me.Controls.Add(Me.SC_Refresh1)
        Me.Controls.Add(Me.SC_Cancel1)
        Me.Controls.Add(Me.SC_Add1)
        Me.Name = "SYS0300Frm"
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYS0300DTO01BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYS0300DTO02BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYS0300DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabData.ResumeLayout(False)
        Me.TabData.PerformLayout()
        CType(Me.LKM_SysModuleDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LKM_SysAppTypeDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LKM_SysAppGroupDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SC_GridSearch1 As SC_Win_FrontEnd.SC_GridSearch
    Friend WithEvents SYS0300DTO02BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SYS0300DTO02SC_DataGridView As SC_Win_FrontEnd.SC_DataGridView
    Friend WithEvents SYS0300DTO01BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents APP_IDSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents APP_GROUP_IDSC_ComboBox As SC_Win_FrontEnd.SC_ComboBox
    Friend WithEvents LKM_SysAppGroupDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents APP_TYPESC_ComboBox As SC_Win_FrontEnd.SC_ComboBox
    Friend WithEvents LKM_SysAppTypeDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MODULE_IDSC_ComboBox As SC_Win_FrontEnd.SC_ComboBox
    Friend WithEvents LKM_SysModuleDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VERSIONSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents APP_NAMESC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents APP_DESCSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DLL_FILE_VERSIONSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents DLL_FILESC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents UPDATE_DLL_FILESC_CheckBox As SC_Win_FrontEnd.SC_CheckBox
    Friend WithEvents DllFileBrowseSC_Button As SC_Win_FrontEnd.SC_Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
