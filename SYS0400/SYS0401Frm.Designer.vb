<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SYS0401Frm
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
        Dim ROLE_IDLabel As System.Windows.Forms.Label
        Dim ROLE_NAMELabel As System.Windows.Forms.Label
        Dim APP_IDLabel As System.Windows.Forms.Label
        Dim READ_PERMITLabel As System.Windows.Forms.Label
        Dim ADD_PERMITLabel As System.Windows.Forms.Label
        Dim EDIT_PERMITLabel As System.Windows.Forms.Label
        Dim DELETE_PERMITLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SYS0401Frm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ROLE_NAMESC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.SYS0400DTO02BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ROLE_IDSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabList = New System.Windows.Forms.TabPage()
        Me.SYS0401DTO02SC_DataGridView = New SC_Win_FrontEnd.SC_DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SYS0401DTO02BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabData = New System.Windows.Forms.TabPage()
        Me.DELETE_PERMITSC_CheckBox = New SC_Win_FrontEnd.SC_CheckBox()
        Me.SYS0401DTO01BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SC_Conductor1 = New SC_Win_FrontEnd.SC_Conductor(Me.components)
        Me.EDIT_PERMITSC_CheckBox = New SC_Win_FrontEnd.SC_CheckBox()
        Me.ADD_PERMITSC_CheckBox = New SC_Win_FrontEnd.SC_CheckBox()
        Me.READ_PERMITSC_CheckBox = New SC_Win_FrontEnd.SC_CheckBox()
        Me.AppSC_LookUp = New SC_Win_FrontEnd.SC_LookUp()
        Me.APP_NAMESC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.APP_IDSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.SC_ExportCSV1 = New SC_Win_FrontEnd.SC_ExportCSV(Me.components)
        Me.SC_Save1 = New SC_Win_FrontEnd.SC_Save()
        Me.SC_Delete1 = New SC_Win_FrontEnd.SC_Delete()
        Me.SC_Edit1 = New SC_Win_FrontEnd.SC_Edit()
        Me.SC_Refresh1 = New SC_Win_FrontEnd.SC_Refresh()
        Me.SC_Cancel1 = New SC_Win_FrontEnd.SC_Cancel()
        Me.SC_Add1 = New SC_Win_FrontEnd.SC_Add()
        Me.SC_ErrorProvider1 = New SC_Win_FrontEnd.SC_ErrorProvider(Me.components)
        ROLE_IDLabel = New System.Windows.Forms.Label()
        ROLE_NAMELabel = New System.Windows.Forms.Label()
        APP_IDLabel = New System.Windows.Forms.Label()
        READ_PERMITLabel = New System.Windows.Forms.Label()
        ADD_PERMITLabel = New System.Windows.Forms.Label()
        EDIT_PERMITLabel = New System.Windows.Forms.Label()
        DELETE_PERMITLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SYS0400DTO02BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabList.SuspendLayout()
        CType(Me.SYS0401DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYS0401DTO02BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabData.SuspendLayout()
        CType(Me.SYS0401DTO01BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ROLE_IDLabel
        '
        ROLE_IDLabel.AutoSize = True
        ROLE_IDLabel.Location = New System.Drawing.Point(26, 99)
        ROLE_IDLabel.Name = "ROLE_IDLabel"
        ROLE_IDLabel.Size = New System.Drawing.Size(49, 13)
        ROLE_IDLabel.TabIndex = 0
        ROLE_IDLabel.Text = "Role ID :"
        '
        'ROLE_NAMELabel
        '
        ROLE_NAMELabel.AutoSize = True
        ROLE_NAMELabel.Location = New System.Drawing.Point(9, 126)
        ROLE_NAMELabel.Name = "ROLE_NAMELabel"
        ROLE_NAMELabel.Size = New System.Drawing.Size(65, 13)
        ROLE_NAMELabel.TabIndex = 2
        ROLE_NAMELabel.Text = "Role Name :"
        '
        'APP_IDLabel
        '
        APP_IDLabel.AutoSize = True
        APP_IDLabel.Location = New System.Drawing.Point(66, 25)
        APP_IDLabel.Name = "APP_IDLabel"
        APP_IDLabel.Size = New System.Drawing.Size(53, 13)
        APP_IDLabel.TabIndex = 0
        APP_IDLabel.Text = "*App ID :"
        '
        'READ_PERMITLabel
        '
        READ_PERMITLabel.AutoSize = True
        READ_PERMITLabel.Location = New System.Drawing.Point(47, 54)
        READ_PERMITLabel.Name = "READ_PERMITLabel"
        READ_PERMITLabel.Size = New System.Drawing.Size(72, 13)
        READ_PERMITLabel.TabIndex = 4
        READ_PERMITLabel.Text = "Read Permit :"
        '
        'ADD_PERMITLabel
        '
        ADD_PERMITLabel.AutoSize = True
        ADD_PERMITLabel.Location = New System.Drawing.Point(53, 84)
        ADD_PERMITLabel.Name = "ADD_PERMITLabel"
        ADD_PERMITLabel.Size = New System.Drawing.Size(66, 13)
        ADD_PERMITLabel.TabIndex = 6
        ADD_PERMITLabel.Text = "Add Permit :"
        '
        'EDIT_PERMITLabel
        '
        EDIT_PERMITLabel.AutoSize = True
        EDIT_PERMITLabel.Location = New System.Drawing.Point(54, 114)
        EDIT_PERMITLabel.Name = "EDIT_PERMITLabel"
        EDIT_PERMITLabel.Size = New System.Drawing.Size(65, 13)
        EDIT_PERMITLabel.TabIndex = 8
        EDIT_PERMITLabel.Text = "Edit Permit :"
        '
        'DELETE_PERMITLabel
        '
        DELETE_PERMITLabel.AutoSize = True
        DELETE_PERMITLabel.Location = New System.Drawing.Point(41, 144)
        DELETE_PERMITLabel.Name = "DELETE_PERMITLabel"
        DELETE_PERMITLabel.Size = New System.Drawing.Size(78, 13)
        DELETE_PERMITLabel.TabIndex = 10
        DELETE_PERMITLabel.Text = "Delete Permit :"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.SplitContainer1.Panel1.Controls.Add(ROLE_NAMELabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ROLE_NAMESC_TextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ROLE_IDLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ROLE_IDSC_TextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SC_ExportCSV1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SC_Save1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SC_Delete1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SC_Edit1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SC_Refresh1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SC_Cancel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SC_Add1)
        Me.SplitContainer1.Size = New System.Drawing.Size(843, 478)
        Me.SplitContainer1.SplitterDistance = 275
        Me.SplitContainer1.TabIndex = 0
        '
        'ROLE_NAMESC_TextBox
        '
        Me.ROLE_NAMESC_TextBox.BackColor = System.Drawing.SystemColors.Control
        Me.ROLE_NAMESC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ROLE_NAMESC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SYS0400DTO02BindingSource, "ROLE_NAME", True))
        Me.ROLE_NAMESC_TextBox.Location = New System.Drawing.Point(83, 123)
        Me.ROLE_NAMESC_TextBox.Name = "ROLE_NAMESC_TextBox"
        Me.ROLE_NAMESC_TextBox.ReadOnly = True
        Me.ROLE_NAMESC_TextBox.SC_ConductorSource = Nothing
        Me.ROLE_NAMESC_TextBox.Size = New System.Drawing.Size(180, 21)
        Me.ROLE_NAMESC_TextBox.TabIndex = 3
        '
        'SYS0400DTO02BindingSource
        '
        Me.SYS0400DTO02BindingSource.DataSource = GetType(SYS0400.SYS0400SvcRef.SYS0400DTO02)
        '
        'ROLE_IDSC_TextBox
        '
        Me.ROLE_IDSC_TextBox.BackColor = System.Drawing.SystemColors.Control
        Me.ROLE_IDSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ROLE_IDSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SYS0400DTO02BindingSource, "ROLE_ID", True))
        Me.ROLE_IDSC_TextBox.Location = New System.Drawing.Point(83, 96)
        Me.ROLE_IDSC_TextBox.Name = "ROLE_IDSC_TextBox"
        Me.ROLE_IDSC_TextBox.ReadOnly = True
        Me.ROLE_IDSC_TextBox.SC_ConductorSource = Nothing
        Me.ROLE_IDSC_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.ROLE_IDSC_TextBox.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabList)
        Me.TabControl1.Controls.Add(Me.TabData)
        Me.TabControl1.Location = New System.Drawing.Point(3, 55)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(549, 411)
        Me.TabControl1.TabIndex = 50
        '
        'TabList
        '
        Me.TabList.Controls.Add(Me.SYS0401DTO02SC_DataGridView)
        Me.TabList.Location = New System.Drawing.Point(4, 22)
        Me.TabList.Name = "TabList"
        Me.TabList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabList.Size = New System.Drawing.Size(541, 385)
        Me.TabList.TabIndex = 0
        Me.TabList.Text = "List"
        Me.TabList.UseVisualStyleBackColor = True
        '
        'SYS0401DTO02SC_DataGridView
        '
        Me.SYS0401DTO02SC_DataGridView.AllowUserToAddRows = False
        Me.SYS0401DTO02SC_DataGridView.AllowUserToDeleteRows = False
        Me.SYS0401DTO02SC_DataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYS0401DTO02SC_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.SYS0401DTO02SC_DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SYS0401DTO02SC_DataGridView.AutoGenerateColumns = False
        Me.SYS0401DTO02SC_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SYS0401DTO02SC_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.SYS0401DTO02SC_DataGridView.DataSource = Me.SYS0401DTO02BindingSource
        Me.SYS0401DTO02SC_DataGridView.Location = New System.Drawing.Point(6, 6)
        Me.SYS0401DTO02SC_DataGridView.Name = "SYS0401DTO02SC_DataGridView"
        Me.SYS0401DTO02SC_DataGridView.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYS0401DTO02SC_DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.SYS0401DTO02SC_DataGridView.SC_ConductorSource = Nothing
        Me.SYS0401DTO02SC_DataGridView.Size = New System.Drawing.Size(529, 373)
        Me.SYS0401DTO02SC_DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "APP_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "App ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "APP_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "App Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "READ_PERMIT"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "Read Permit"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "ADD_PERMIT"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Add Permit"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "EDIT_PERMIT"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Edit Permit"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "DELETE_PERMIT"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Delete Permit"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CREA_BY"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Create By"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CREA_DATE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Create Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UPD_BY"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Update By"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UPD_DATE"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Update Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'SYS0401DTO02BindingSource
        '
        Me.SYS0401DTO02BindingSource.DataSource = GetType(SYS0400.SYS0401SvcRef.SYS0401DTO02)
        '
        'TabData
        '
        Me.TabData.Controls.Add(DELETE_PERMITLabel)
        Me.TabData.Controls.Add(Me.DELETE_PERMITSC_CheckBox)
        Me.TabData.Controls.Add(EDIT_PERMITLabel)
        Me.TabData.Controls.Add(Me.EDIT_PERMITSC_CheckBox)
        Me.TabData.Controls.Add(ADD_PERMITLabel)
        Me.TabData.Controls.Add(Me.ADD_PERMITSC_CheckBox)
        Me.TabData.Controls.Add(READ_PERMITLabel)
        Me.TabData.Controls.Add(Me.READ_PERMITSC_CheckBox)
        Me.TabData.Controls.Add(Me.AppSC_LookUp)
        Me.TabData.Controls.Add(Me.APP_NAMESC_TextBox)
        Me.TabData.Controls.Add(APP_IDLabel)
        Me.TabData.Controls.Add(Me.APP_IDSC_TextBox)
        Me.TabData.Location = New System.Drawing.Point(4, 22)
        Me.TabData.Name = "TabData"
        Me.TabData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabData.Size = New System.Drawing.Size(541, 385)
        Me.TabData.TabIndex = 1
        Me.TabData.Text = "Data"
        Me.TabData.UseVisualStyleBackColor = True
        '
        'DELETE_PERMITSC_CheckBox
        '
        Me.DELETE_PERMITSC_CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SYS0401DTO01BindingSource, "DELETE_PERMIT", True))
        Me.DELETE_PERMITSC_CheckBox.Location = New System.Drawing.Point(125, 139)
        Me.DELETE_PERMITSC_CheckBox.Name = "DELETE_PERMITSC_CheckBox"
        Me.DELETE_PERMITSC_CheckBox.SC_ConductorSource = Me.SC_Conductor1
        Me.DELETE_PERMITSC_CheckBox.SC_EnableADD = True
        Me.DELETE_PERMITSC_CheckBox.SC_EnableEDIT = True
        Me.DELETE_PERMITSC_CheckBox.Size = New System.Drawing.Size(104, 24)
        Me.DELETE_PERMITSC_CheckBox.TabIndex = 11
        Me.DELETE_PERMITSC_CheckBox.UseVisualStyleBackColor = True
        '
        'SYS0401DTO01BindingSource
        '
        Me.SYS0401DTO01BindingSource.DataSource = GetType(SYS0400.SYS0401SvcRef.SYS0401DTO01)
        '
        'SC_Conductor1
        '
        Me.SC_Conductor1.SC_BindingSource = Me.SYS0401DTO01BindingSource
        Me.SC_Conductor1.SC_ParentBindingSource = Me.SYS0401DTO02BindingSource
        Me.SC_Conductor1.SC_ParentKey = "App_ID"
        '
        'EDIT_PERMITSC_CheckBox
        '
        Me.EDIT_PERMITSC_CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SYS0401DTO01BindingSource, "EDIT_PERMIT", True))
        Me.EDIT_PERMITSC_CheckBox.Location = New System.Drawing.Point(125, 109)
        Me.EDIT_PERMITSC_CheckBox.Name = "EDIT_PERMITSC_CheckBox"
        Me.EDIT_PERMITSC_CheckBox.SC_ConductorSource = Me.SC_Conductor1
        Me.EDIT_PERMITSC_CheckBox.SC_EnableADD = True
        Me.EDIT_PERMITSC_CheckBox.SC_EnableEDIT = True
        Me.EDIT_PERMITSC_CheckBox.Size = New System.Drawing.Size(104, 24)
        Me.EDIT_PERMITSC_CheckBox.TabIndex = 9
        Me.EDIT_PERMITSC_CheckBox.UseVisualStyleBackColor = True
        '
        'ADD_PERMITSC_CheckBox
        '
        Me.ADD_PERMITSC_CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SYS0401DTO01BindingSource, "ADD_PERMIT", True))
        Me.ADD_PERMITSC_CheckBox.Location = New System.Drawing.Point(125, 79)
        Me.ADD_PERMITSC_CheckBox.Name = "ADD_PERMITSC_CheckBox"
        Me.ADD_PERMITSC_CheckBox.SC_ConductorSource = Me.SC_Conductor1
        Me.ADD_PERMITSC_CheckBox.SC_EnableADD = True
        Me.ADD_PERMITSC_CheckBox.SC_EnableEDIT = True
        Me.ADD_PERMITSC_CheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ADD_PERMITSC_CheckBox.TabIndex = 7
        Me.ADD_PERMITSC_CheckBox.UseVisualStyleBackColor = True
        '
        'READ_PERMITSC_CheckBox
        '
        Me.READ_PERMITSC_CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SYS0401DTO01BindingSource, "READ_PERMIT", True))
        Me.READ_PERMITSC_CheckBox.Location = New System.Drawing.Point(125, 49)
        Me.READ_PERMITSC_CheckBox.Name = "READ_PERMITSC_CheckBox"
        Me.READ_PERMITSC_CheckBox.SC_ConductorSource = Me.SC_Conductor1
        Me.READ_PERMITSC_CheckBox.SC_EnableADD = True
        Me.READ_PERMITSC_CheckBox.SC_EnableEDIT = True
        Me.READ_PERMITSC_CheckBox.Size = New System.Drawing.Size(104, 24)
        Me.READ_PERMITSC_CheckBox.TabIndex = 5
        Me.READ_PERMITSC_CheckBox.UseVisualStyleBackColor = True
        '
        'AppSC_LookUp
        '
        Me.AppSC_LookUp.Location = New System.Drawing.Point(440, 21)
        Me.AppSC_LookUp.Name = "AppSC_LookUp"
        Me.AppSC_LookUp.SC_ConductorSource = Me.SC_Conductor1
        Me.AppSC_LookUp.SC_EnableADD = True
        Me.AppSC_LookUp.SC_Field_Description = ""
        Me.AppSC_LookUp.SC_Field_Value = ""
        Me.AppSC_LookUp.SC_TextBox_Description = Nothing
        Me.AppSC_LookUp.SC_TextBox_Value = Nothing
        Me.AppSC_LookUp.Size = New System.Drawing.Size(26, 23)
        Me.AppSC_LookUp.TabIndex = 4
        Me.AppSC_LookUp.UseVisualStyleBackColor = True
        '
        'APP_NAMESC_TextBox
        '
        Me.APP_NAMESC_TextBox.BackColor = System.Drawing.SystemColors.Control
        Me.APP_NAMESC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.APP_NAMESC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SYS0401DTO01BindingSource, "APP_NAME", True))
        Me.APP_NAMESC_TextBox.Location = New System.Drawing.Point(231, 22)
        Me.APP_NAMESC_TextBox.Name = "APP_NAMESC_TextBox"
        Me.APP_NAMESC_TextBox.ReadOnly = True
        Me.APP_NAMESC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.APP_NAMESC_TextBox.Size = New System.Drawing.Size(203, 21)
        Me.APP_NAMESC_TextBox.TabIndex = 3
        '
        'APP_IDSC_TextBox
        '
        Me.APP_IDSC_TextBox.BackColor = System.Drawing.Color.White
        Me.APP_IDSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.APP_IDSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SYS0401DTO01BindingSource, "APP_ID", True))
        Me.APP_IDSC_TextBox.Location = New System.Drawing.Point(125, 22)
        Me.APP_IDSC_TextBox.Name = "APP_IDSC_TextBox"
        Me.APP_IDSC_TextBox.SC_ConductorSource = Nothing
        Me.APP_IDSC_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.APP_IDSC_TextBox.TabIndex = 1
        '
        'SC_ExportCSV1
        '
        Me.SC_ExportCSV1.Image = CType(resources.GetObject("SC_ExportCSV1.Image"), System.Drawing.Image)
        Me.SC_ExportCSV1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_ExportCSV1.Location = New System.Drawing.Point(380, 10)
        Me.SC_ExportCSV1.Name = "SC_ExportCSV1"
        Me.SC_ExportCSV1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_ExportCSV1.SC_DataGridView = Me.SYS0401DTO02SC_DataGridView
        Me.SC_ExportCSV1.SC_DefaultFileName = "Master System Role App"
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
        Me.SC_Save1.Location = New System.Drawing.Point(256, 10)
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
        Me.SC_Delete1.Location = New System.Drawing.Point(194, 10)
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
        Me.SC_Edit1.Location = New System.Drawing.Point(132, 10)
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
        Me.SC_Refresh1.Location = New System.Drawing.Point(8, 10)
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
        Me.SC_Cancel1.Location = New System.Drawing.Point(318, 10)
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
        Me.SC_Add1.Location = New System.Drawing.Point(70, 10)
        Me.SC_Add1.Name = "SC_Add1"
        Me.SC_Add1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_Add1.Size = New System.Drawing.Size(61, 39)
        Me.SC_Add1.TabIndex = 43
        Me.SC_Add1.Text = "&Add"
        Me.SC_Add1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_Add1.UseVisualStyleBackColor = True
        '
        'SC_ErrorProvider1
        '
        Me.SC_ErrorProvider1.ContainerControl = Me
        '
        'SYS0401Frm
        '
        Me.ClientSize = New System.Drawing.Size(843, 478)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SYS0401Frm"
        Me.Text = "System Role Application"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SYS0400DTO02BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        CType(Me.SYS0401DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYS0401DTO02BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabData.ResumeLayout(False)
        Me.TabData.PerformLayout()
        CType(Me.SYS0401DTO01BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ROLE_NAMESC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents SYS0400DTO02BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ROLE_IDSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents SC_ExportCSV1 As SC_Win_FrontEnd.SC_ExportCSV
    Friend WithEvents SC_Save1 As SC_Win_FrontEnd.SC_Save
    Friend WithEvents SC_Delete1 As SC_Win_FrontEnd.SC_Delete
    Friend WithEvents SC_Edit1 As SC_Win_FrontEnd.SC_Edit
    Friend WithEvents SC_Refresh1 As SC_Win_FrontEnd.SC_Refresh
    Friend WithEvents SC_Cancel1 As SC_Win_FrontEnd.SC_Cancel
    Friend WithEvents SC_Add1 As SC_Win_FrontEnd.SC_Add
    Friend WithEvents SYS0401DTO01BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabList As System.Windows.Forms.TabPage
    Friend WithEvents TabData As System.Windows.Forms.TabPage
    Friend WithEvents SC_Conductor1 As SC_Win_FrontEnd.SC_Conductor
    Friend WithEvents SC_ErrorProvider1 As SC_Win_FrontEnd.SC_ErrorProvider
    Friend WithEvents SYS0401DTO02SC_DataGridView As SC_Win_FrontEnd.SC_DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SYS0401DTO02BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AppSC_LookUp As SC_Win_FrontEnd.SC_LookUp
    Friend WithEvents APP_NAMESC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents APP_IDSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents DELETE_PERMITSC_CheckBox As SC_Win_FrontEnd.SC_CheckBox
    Friend WithEvents EDIT_PERMITSC_CheckBox As SC_Win_FrontEnd.SC_CheckBox
    Friend WithEvents ADD_PERMITSC_CheckBox As SC_Win_FrontEnd.SC_CheckBox
    Friend WithEvents READ_PERMITSC_CheckBox As SC_Win_FrontEnd.SC_CheckBox

End Class
