﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPR0200Frm
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
        Dim BARCODELabel As System.Windows.Forms.Label
        Dim COMPANY_IDLabel As System.Windows.Forms.Label
        Dim COMPANY_OFFICE_IDLabel As System.Windows.Forms.Label
        Dim FROM_DATELabel As System.Windows.Forms.Label
        Dim TO_DATELabel As System.Windows.Forms.Label
        Dim OUTLET_IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RPR0200Frm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SC_Conductor1 = New SC_Win_FrontEnd.SC_Conductor(Me.components)
        Me.RPR0200DTO01BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RPR0200DTO02BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SC_ExportCSV1 = New SC_Win_FrontEnd.SC_ExportCSV(Me.components)
        Me.RPR0200DTO02SC_DataGridView = New SC_Win_FrontEnd.SC_DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SC_Save1 = New SC_Win_FrontEnd.SC_Save()
        Me.SC_Delete1 = New SC_Win_FrontEnd.SC_Delete()
        Me.SC_Edit1 = New SC_Win_FrontEnd.SC_Edit()
        Me.SC_Refresh1 = New SC_Win_FrontEnd.SC_Refresh()
        Me.SC_Cancel1 = New SC_Win_FrontEnd.SC_Cancel()
        Me.SC_Add1 = New SC_Win_FrontEnd.SC_Add()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabList = New System.Windows.Forms.TabPage()
        Me.TxtLimit = New SC_Win_FrontEnd.SC_TextBox()
        Me.CheckLimit = New SC_Win_FrontEnd.SC_CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KeSC_DateTimePicker = New SC_Win_FrontEnd.SC_DateTimePicker()
        Me.DariSC_DateTimePicker = New SC_Win_FrontEnd.SC_DateTimePicker()
        Me.TanggalSC_CheckBox = New SC_Win_FrontEnd.SC_CheckBox()
        Me.SC_GridSearch1 = New SC_Win_FrontEnd.SC_GridSearch()
        Me.TabData = New System.Windows.Forms.TabPage()
        Me.COMPANY_IDSC_ComboBox = New SC_Win_FrontEnd.SC_ComboBox()
        Me.LKM_CompanyDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabDetail = New System.Windows.Forms.TabPage()
        Me.Repair_DetailDTOSC_DataGridView = New SC_Win_FrontEnd.SC_DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Repair_DetailDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SparepartSC_Detail = New SC_Win_FrontEnd.SC_Detail()
        Me.OutletSC_LookUp = New SC_Win_FrontEnd.SC_LookUp()
        Me.OUTLET_NAMESC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.OUTLET_IDSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.TO_DATESC_DateTimePicker = New SC_Win_FrontEnd.SC_DateTimePicker()
        Me.FROM_DATESC_DateTimePicker = New SC_Win_FrontEnd.SC_DateTimePicker()
        Me.COMPANY_OFFICE_IDSC_ComboBox = New SC_Win_FrontEnd.SC_ComboBox()
        Me.LKM_CompanyOfficeDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BARCODESC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.SC_ErrorProvider1 = New SC_Win_FrontEnd.SC_ErrorProvider(Me.components)
        BARCODELabel = New System.Windows.Forms.Label()
        COMPANY_IDLabel = New System.Windows.Forms.Label()
        COMPANY_OFFICE_IDLabel = New System.Windows.Forms.Label()
        FROM_DATELabel = New System.Windows.Forms.Label()
        TO_DATELabel = New System.Windows.Forms.Label()
        OUTLET_IDLabel = New System.Windows.Forms.Label()
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RPR0200DTO01BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RPR0200DTO02BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RPR0200DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabList.SuspendLayout()
        Me.TabData.SuspendLayout()
        CType(Me.LKM_CompanyDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabDetail.SuspendLayout()
        CType(Me.Repair_DetailDTOSC_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Repair_DetailDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LKM_CompanyOfficeDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BARCODELabel
        '
        BARCODELabel.AutoSize = True
        BARCODELabel.Location = New System.Drawing.Point(52, 10)
        BARCODELabel.Name = "BARCODELabel"
        BARCODELabel.Size = New System.Drawing.Size(62, 13)
        BARCODELabel.TabIndex = 0
        BARCODELabel.Text = "* Barcode :"
        '
        'COMPANY_IDLabel
        '
        COMPANY_IDLabel.AutoSize = True
        COMPANY_IDLabel.Location = New System.Drawing.Point(55, 37)
        COMPANY_IDLabel.Name = "COMPANY_IDLabel"
        COMPANY_IDLabel.Size = New System.Drawing.Size(59, 13)
        COMPANY_IDLabel.TabIndex = 2
        COMPANY_IDLabel.Text = "Company :"
        '
        'COMPANY_OFFICE_IDLabel
        '
        COMPANY_OFFICE_IDLabel.AutoSize = True
        COMPANY_OFFICE_IDLabel.Location = New System.Drawing.Point(23, 64)
        COMPANY_OFFICE_IDLabel.Name = "COMPANY_OFFICE_IDLabel"
        COMPANY_OFFICE_IDLabel.Size = New System.Drawing.Size(91, 13)
        COMPANY_OFFICE_IDLabel.TabIndex = 4
        COMPANY_OFFICE_IDLabel.Text = "Company Office :"
        '
        'FROM_DATELabel
        '
        FROM_DATELabel.AutoSize = True
        FROM_DATELabel.Location = New System.Drawing.Point(428, 10)
        FROM_DATELabel.Name = "FROM_DATELabel"
        FROM_DATELabel.Size = New System.Drawing.Size(74, 13)
        FROM_DATELabel.TabIndex = 6
        FROM_DATELabel.Text = "Dari Tanggal :"
        '
        'TO_DATELabel
        '
        TO_DATELabel.AutoSize = True
        TO_DATELabel.Location = New System.Drawing.Point(435, 37)
        TO_DATELabel.Name = "TO_DATELabel"
        TO_DATELabel.Size = New System.Drawing.Size(67, 13)
        TO_DATELabel.TabIndex = 8
        TO_DATELabel.Text = "Ke Tanggal :"
        '
        'OUTLET_IDLabel
        '
        OUTLET_IDLabel.AutoSize = True
        OUTLET_IDLabel.Location = New System.Drawing.Point(458, 63)
        OUTLET_IDLabel.Name = "OUTLET_IDLabel"
        OUTLET_IDLabel.Size = New System.Drawing.Size(44, 13)
        OUTLET_IDLabel.TabIndex = 10
        OUTLET_IDLabel.Text = "Outlet :"
        '
        'SC_Conductor1
        '
        Me.SC_Conductor1.SC_BindingSource = Me.RPR0200DTO01BindingSource
        Me.SC_Conductor1.SC_ParentBindingSource = Me.RPR0200DTO02BindingSource
        Me.SC_Conductor1.SC_ParentKey = "REPAIR_ID"
        '
        'RPR0200DTO01BindingSource
        '
        Me.RPR0200DTO01BindingSource.DataSource = GetType(RPR0200.RPR0200SvcRef.RPR0200DTO01)
        '
        'RPR0200DTO02BindingSource
        '
        Me.RPR0200DTO02BindingSource.DataSource = GetType(RPR0200.RPR0200SvcRef.RPR0200DTO02)
        '
        'SC_ExportCSV1
        '
        Me.SC_ExportCSV1.Image = CType(resources.GetObject("SC_ExportCSV1.Image"), System.Drawing.Image)
        Me.SC_ExportCSV1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_ExportCSV1.Location = New System.Drawing.Point(384, 12)
        Me.SC_ExportCSV1.Name = "SC_ExportCSV1"
        Me.SC_ExportCSV1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_ExportCSV1.SC_DataGridView = Me.RPR0200DTO02SC_DataGridView
        Me.SC_ExportCSV1.SC_DefaultFileName = "Repair Aset"
        Me.SC_ExportCSV1.Size = New System.Drawing.Size(61, 39)
        Me.SC_ExportCSV1.TabIndex = 20
        Me.SC_ExportCSV1.Text = "E&xport"
        Me.SC_ExportCSV1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_ExportCSV1.UseVisualStyleBackColor = True
        '
        'RPR0200DTO02SC_DataGridView
        '
        Me.RPR0200DTO02SC_DataGridView.AllowUserToAddRows = False
        Me.RPR0200DTO02SC_DataGridView.AllowUserToDeleteRows = False
        Me.RPR0200DTO02SC_DataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RPR0200DTO02SC_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.RPR0200DTO02SC_DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RPR0200DTO02SC_DataGridView.AutoGenerateColumns = False
        Me.RPR0200DTO02SC_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RPR0200DTO02SC_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.RPR0200DTO02SC_DataGridView.DataSource = Me.RPR0200DTO02BindingSource
        Me.RPR0200DTO02SC_DataGridView.Location = New System.Drawing.Point(6, 60)
        Me.RPR0200DTO02SC_DataGridView.Name = "RPR0200DTO02SC_DataGridView"
        Me.RPR0200DTO02SC_DataGridView.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RPR0200DTO02SC_DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.RPR0200DTO02SC_DataGridView.SC_ConductorSource = Nothing
        Me.RPR0200DTO02SC_DataGridView.Size = New System.Drawing.Size(1009, 263)
        Me.RPR0200DTO02SC_DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "REPAIR_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Repair ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BARCODE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Barcode Aset"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "COMPANY_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Company"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "COMPANY_OFFICE_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Company Office"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "OUTLET_ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Outlet ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "OUTLET_NAME"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Outlet Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FROM_DATE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Dari Tanggal"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TO_DATE"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Ke Tanggal"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 130
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
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "UPD_BY"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Update By"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "UPD_DATE"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Update Date"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'SC_Save1
        '
        Me.SC_Save1.Image = CType(resources.GetObject("SC_Save1.Image"), System.Drawing.Image)
        Me.SC_Save1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_Save1.Location = New System.Drawing.Point(260, 12)
        Me.SC_Save1.Name = "SC_Save1"
        Me.SC_Save1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_Save1.Size = New System.Drawing.Size(61, 39)
        Me.SC_Save1.TabIndex = 19
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
        Me.SC_Delete1.TabIndex = 18
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
        Me.SC_Edit1.TabIndex = 17
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
        Me.SC_Refresh1.TabIndex = 16
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
        Me.SC_Cancel1.TabIndex = 15
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
        Me.SC_Add1.TabIndex = 14
        Me.SC_Add1.Text = "&Add"
        Me.SC_Add1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_Add1.UseVisualStyleBackColor = True
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
        Me.TabControl1.Size = New System.Drawing.Size(1029, 393)
        Me.TabControl1.TabIndex = 21
        '
        'TabList
        '
        Me.TabList.Controls.Add(Me.TxtLimit)
        Me.TabList.Controls.Add(Me.CheckLimit)
        Me.TabList.Controls.Add(Me.Label1)
        Me.TabList.Controls.Add(Me.KeSC_DateTimePicker)
        Me.TabList.Controls.Add(Me.DariSC_DateTimePicker)
        Me.TabList.Controls.Add(Me.TanggalSC_CheckBox)
        Me.TabList.Controls.Add(Me.SC_GridSearch1)
        Me.TabList.Controls.Add(Me.RPR0200DTO02SC_DataGridView)
        Me.TabList.Location = New System.Drawing.Point(4, 22)
        Me.TabList.Name = "TabList"
        Me.TabList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabList.Size = New System.Drawing.Size(1021, 367)
        Me.TabList.TabIndex = 0
        Me.TabList.Text = "List"
        Me.TabList.UseVisualStyleBackColor = True
        '
        'TxtLimit
        '
        Me.TxtLimit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLimit.Location = New System.Drawing.Point(81, 33)
        Me.TxtLimit.Name = "TxtLimit"
        Me.TxtLimit.SC_ConductorSource = Nothing
        Me.TxtLimit.Size = New System.Drawing.Size(69, 21)
        Me.TxtLimit.TabIndex = 13
        '
        'CheckLimit
        '
        Me.CheckLimit.AutoSize = True
        Me.CheckLimit.Location = New System.Drawing.Point(21, 35)
        Me.CheckLimit.Name = "CheckLimit"
        Me.CheckLimit.SC_ConductorSource = Nothing
        Me.CheckLimit.Size = New System.Drawing.Size(54, 17)
        Me.CheckLimit.TabIndex = 12
        Me.CheckLimit.Text = "Limit :"
        Me.CheckLimit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(249, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ke"
        '
        'KeSC_DateTimePicker
        '
        Me.KeSC_DateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.KeSC_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.KeSC_DateTimePicker.Location = New System.Drawing.Point(273, 6)
        Me.KeSC_DateTimePicker.Name = "KeSC_DateTimePicker"
        Me.KeSC_DateTimePicker.SC_ConductorSource = Nothing
        Me.KeSC_DateTimePicker.Size = New System.Drawing.Size(156, 21)
        Me.KeSC_DateTimePicker.TabIndex = 10
        '
        'DariSC_DateTimePicker
        '
        Me.DariSC_DateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.DariSC_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DariSC_DateTimePicker.Location = New System.Drawing.Point(113, 6)
        Me.DariSC_DateTimePicker.Name = "DariSC_DateTimePicker"
        Me.DariSC_DateTimePicker.SC_ConductorSource = Nothing
        Me.DariSC_DateTimePicker.Size = New System.Drawing.Size(130, 21)
        Me.DariSC_DateTimePicker.TabIndex = 9
        '
        'TanggalSC_CheckBox
        '
        Me.TanggalSC_CheckBox.AutoSize = True
        Me.TanggalSC_CheckBox.Location = New System.Drawing.Point(21, 8)
        Me.TanggalSC_CheckBox.Name = "TanggalSC_CheckBox"
        Me.TanggalSC_CheckBox.SC_ConductorSource = Nothing
        Me.TanggalSC_CheckBox.Size = New System.Drawing.Size(86, 17)
        Me.TanggalSC_CheckBox.TabIndex = 8
        Me.TanggalSC_CheckBox.Text = "Dari Tanggal"
        Me.TanggalSC_CheckBox.UseVisualStyleBackColor = True
        '
        'SC_GridSearch1
        '
        Me.SC_GridSearch1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SC_GridSearch1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SC_GridSearch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SC_GridSearch1.Location = New System.Drawing.Point(6, 329)
        Me.SC_GridSearch1.Name = "SC_GridSearch1"
        Me.SC_GridSearch1.SC_BindingSource = Me.RPR0200DTO02BindingSource
        Me.SC_GridSearch1.Size = New System.Drawing.Size(1009, 32)
        Me.SC_GridSearch1.TabIndex = 2
        '
        'TabData
        '
        Me.TabData.AutoScroll = True
        Me.TabData.Controls.Add(Me.COMPANY_IDSC_ComboBox)
        Me.TabData.Controls.Add(Me.TabControl2)
        Me.TabData.Controls.Add(Me.OutletSC_LookUp)
        Me.TabData.Controls.Add(Me.OUTLET_NAMESC_TextBox)
        Me.TabData.Controls.Add(OUTLET_IDLabel)
        Me.TabData.Controls.Add(Me.OUTLET_IDSC_TextBox)
        Me.TabData.Controls.Add(TO_DATELabel)
        Me.TabData.Controls.Add(Me.TO_DATESC_DateTimePicker)
        Me.TabData.Controls.Add(FROM_DATELabel)
        Me.TabData.Controls.Add(Me.FROM_DATESC_DateTimePicker)
        Me.TabData.Controls.Add(COMPANY_OFFICE_IDLabel)
        Me.TabData.Controls.Add(Me.COMPANY_OFFICE_IDSC_ComboBox)
        Me.TabData.Controls.Add(COMPANY_IDLabel)
        Me.TabData.Controls.Add(BARCODELabel)
        Me.TabData.Controls.Add(Me.BARCODESC_TextBox)
        Me.TabData.Location = New System.Drawing.Point(4, 22)
        Me.TabData.Name = "TabData"
        Me.TabData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabData.Size = New System.Drawing.Size(1021, 367)
        Me.TabData.TabIndex = 1
        Me.TabData.Text = "Data"
        Me.TabData.UseVisualStyleBackColor = True
        '
        'COMPANY_IDSC_ComboBox
        '
        Me.COMPANY_IDSC_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RPR0200DTO01BindingSource, "COMPANY_ID", True))
        Me.COMPANY_IDSC_ComboBox.DataSource = Me.LKM_CompanyDTOBindingSource
        Me.COMPANY_IDSC_ComboBox.DisplayMember = "COMPANY_NAME"
        Me.COMPANY_IDSC_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMPANY_IDSC_ComboBox.FormattingEnabled = True
        Me.COMPANY_IDSC_ComboBox.Location = New System.Drawing.Point(120, 33)
        Me.COMPANY_IDSC_ComboBox.Name = "COMPANY_IDSC_ComboBox"
        Me.COMPANY_IDSC_ComboBox.SC_ConductorSource = Me.SC_Conductor1
        Me.COMPANY_IDSC_ComboBox.SC_EnableADD = True
        Me.COMPANY_IDSC_ComboBox.SC_EnableEDIT = True
        Me.COMPANY_IDSC_ComboBox.Size = New System.Drawing.Size(247, 21)
        Me.COMPANY_IDSC_ComboBox.TabIndex = 2
        Me.COMPANY_IDSC_ComboBox.ValueMember = "COMPANY_ID"
        '
        'LKM_CompanyDTOBindingSource
        '
        Me.LKM_CompanyDTOBindingSource.DataSource = GetType(RPR0200.RPR0200SvcRef.LKM_CompanyDTO)
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabDetail)
        Me.TabControl2.Location = New System.Drawing.Point(6, 100)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1009, 261)
        Me.TabControl2.TabIndex = 15
        '
        'TabDetail
        '
        Me.TabDetail.AutoScroll = True
        Me.TabDetail.Controls.Add(Me.Repair_DetailDTOSC_DataGridView)
        Me.TabDetail.Controls.Add(Me.SparepartSC_Detail)
        Me.TabDetail.Location = New System.Drawing.Point(4, 22)
        Me.TabDetail.Name = "TabDetail"
        Me.TabDetail.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDetail.Size = New System.Drawing.Size(1001, 235)
        Me.TabDetail.TabIndex = 0
        Me.TabDetail.Text = "Detail"
        Me.TabDetail.UseVisualStyleBackColor = True
        '
        'Repair_DetailDTOSC_DataGridView
        '
        Me.Repair_DetailDTOSC_DataGridView.AllowUserToAddRows = False
        Me.Repair_DetailDTOSC_DataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Repair_DetailDTOSC_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Repair_DetailDTOSC_DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Repair_DetailDTOSC_DataGridView.AutoGenerateColumns = False
        Me.Repair_DetailDTOSC_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Repair_DetailDTOSC_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn20})
        Me.Repair_DetailDTOSC_DataGridView.DataSource = Me.Repair_DetailDTOBindingSource
        Me.Repair_DetailDTOSC_DataGridView.Location = New System.Drawing.Point(85, 6)
        Me.Repair_DetailDTOSC_DataGridView.Name = "Repair_DetailDTOSC_DataGridView"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Repair_DetailDTOSC_DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.Repair_DetailDTOSC_DataGridView.SC_ConductorSource = Nothing
        Me.Repair_DetailDTOSC_DataGridView.Size = New System.Drawing.Size(910, 223)
        Me.Repair_DetailDTOSC_DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "KD_PART"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Kode Sparepart"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NAMA_PART"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Nama Sparepart"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 200
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "HARGA_PART"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn15.HeaderText = "Harga Sparepart"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "QTY_PART"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn18.HeaderText = "Qty Part"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "SATUAN_PART"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Satuan"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'Repair_DetailDTOBindingSource
        '
        Me.Repair_DetailDTOBindingSource.DataSource = GetType(RPR0200.RPR0200SvcRef.Repair_DetailDTO)
        '
        'SparepartSC_Detail
        '
        Me.SparepartSC_Detail.Image = CType(resources.GetObject("SparepartSC_Detail.Image"), System.Drawing.Image)
        Me.SparepartSC_Detail.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SparepartSC_Detail.Location = New System.Drawing.Point(6, 6)
        Me.SparepartSC_Detail.Name = "SparepartSC_Detail"
        Me.SparepartSC_Detail.SC_ConductorSource = Nothing
        Me.SparepartSC_Detail.Size = New System.Drawing.Size(73, 39)
        Me.SparepartSC_Detail.TabIndex = 0
        Me.SparepartSC_Detail.Text = "Sparepart"
        Me.SparepartSC_Detail.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SparepartSC_Detail.UseVisualStyleBackColor = True
        '
        'OutletSC_LookUp
        '
        Me.OutletSC_LookUp.Location = New System.Drawing.Point(807, 58)
        Me.OutletSC_LookUp.Name = "OutletSC_LookUp"
        Me.OutletSC_LookUp.SC_ConductorSource = Me.SC_Conductor1
        Me.OutletSC_LookUp.SC_EnableADD = True
        Me.OutletSC_LookUp.SC_EnableEDIT = True
        Me.OutletSC_LookUp.SC_Field_Description = ""
        Me.OutletSC_LookUp.SC_Field_Value = ""
        Me.OutletSC_LookUp.SC_TextBox_Description = Nothing
        Me.OutletSC_LookUp.SC_TextBox_Value = Nothing
        Me.OutletSC_LookUp.Size = New System.Drawing.Size(26, 23)
        Me.OutletSC_LookUp.TabIndex = 8
        Me.OutletSC_LookUp.UseVisualStyleBackColor = True
        '
        'OUTLET_NAMESC_TextBox
        '
        Me.OUTLET_NAMESC_TextBox.BackColor = System.Drawing.SystemColors.Control
        Me.OUTLET_NAMESC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.OUTLET_NAMESC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RPR0200DTO01BindingSource, "OUTLET_NAME", True))
        Me.OUTLET_NAMESC_TextBox.Location = New System.Drawing.Point(614, 59)
        Me.OUTLET_NAMESC_TextBox.Name = "OUTLET_NAMESC_TextBox"
        Me.OUTLET_NAMESC_TextBox.ReadOnly = True
        Me.OUTLET_NAMESC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.OUTLET_NAMESC_TextBox.Size = New System.Drawing.Size(187, 21)
        Me.OUTLET_NAMESC_TextBox.TabIndex = 7
        '
        'OUTLET_IDSC_TextBox
        '
        Me.OUTLET_IDSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.OUTLET_IDSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RPR0200DTO01BindingSource, "OUTLET_ID", True))
        Me.OUTLET_IDSC_TextBox.Location = New System.Drawing.Point(508, 59)
        Me.OUTLET_IDSC_TextBox.Name = "OUTLET_IDSC_TextBox"
        Me.OUTLET_IDSC_TextBox.SC_ConductorSource = Nothing
        Me.OUTLET_IDSC_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.OUTLET_IDSC_TextBox.TabIndex = 6
        '
        'TO_DATESC_DateTimePicker
        '
        Me.TO_DATESC_DateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.TO_DATESC_DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RPR0200DTO01BindingSource, "TO_DATE", True))
        Me.TO_DATESC_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TO_DATESC_DateTimePicker.Location = New System.Drawing.Point(508, 33)
        Me.TO_DATESC_DateTimePicker.Name = "TO_DATESC_DateTimePicker"
        Me.TO_DATESC_DateTimePicker.SC_ConductorSource = Nothing
        Me.TO_DATESC_DateTimePicker.Size = New System.Drawing.Size(100, 21)
        Me.TO_DATESC_DateTimePicker.TabIndex = 5
        '
        'FROM_DATESC_DateTimePicker
        '
        Me.FROM_DATESC_DateTimePicker.CustomFormat = "dd/MM/yyyy"
        Me.FROM_DATESC_DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RPR0200DTO01BindingSource, "FROM_DATE", True))
        Me.FROM_DATESC_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FROM_DATESC_DateTimePicker.Location = New System.Drawing.Point(508, 6)
        Me.FROM_DATESC_DateTimePicker.Name = "FROM_DATESC_DateTimePicker"
        Me.FROM_DATESC_DateTimePicker.SC_ConductorSource = Nothing
        Me.FROM_DATESC_DateTimePicker.Size = New System.Drawing.Size(100, 21)
        Me.FROM_DATESC_DateTimePicker.TabIndex = 4
        '
        'COMPANY_OFFICE_IDSC_ComboBox
        '
        Me.COMPANY_OFFICE_IDSC_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RPR0200DTO01BindingSource, "COMPANY_OFFICE_ID", True))
        Me.COMPANY_OFFICE_IDSC_ComboBox.DataSource = Me.LKM_CompanyOfficeDTOBindingSource
        Me.COMPANY_OFFICE_IDSC_ComboBox.DisplayMember = "COMPANY_OFFICE"
        Me.COMPANY_OFFICE_IDSC_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMPANY_OFFICE_IDSC_ComboBox.FormattingEnabled = True
        Me.COMPANY_OFFICE_IDSC_ComboBox.Location = New System.Drawing.Point(120, 60)
        Me.COMPANY_OFFICE_IDSC_ComboBox.Name = "COMPANY_OFFICE_IDSC_ComboBox"
        Me.COMPANY_OFFICE_IDSC_ComboBox.SC_ConductorSource = Me.SC_Conductor1
        Me.COMPANY_OFFICE_IDSC_ComboBox.SC_EnableADD = True
        Me.COMPANY_OFFICE_IDSC_ComboBox.SC_EnableEDIT = True
        Me.COMPANY_OFFICE_IDSC_ComboBox.Size = New System.Drawing.Size(185, 21)
        Me.COMPANY_OFFICE_IDSC_ComboBox.TabIndex = 3
        Me.COMPANY_OFFICE_IDSC_ComboBox.ValueMember = "COMPANY_OFFICE_ID"
        '
        'LKM_CompanyOfficeDTOBindingSource
        '
        Me.LKM_CompanyOfficeDTOBindingSource.DataSource = GetType(RPR0200.RPR0200SvcRef.LKM_CompanyOfficeDTO)
        '
        'BARCODESC_TextBox
        '
        Me.BARCODESC_TextBox.BackColor = System.Drawing.Color.White
        Me.BARCODESC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.BARCODESC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RPR0200DTO01BindingSource, "BARCODE", True))
        Me.BARCODESC_TextBox.Location = New System.Drawing.Point(120, 6)
        Me.BARCODESC_TextBox.Name = "BARCODESC_TextBox"
        Me.BARCODESC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.BARCODESC_TextBox.SC_EnableADD = True
        Me.BARCODESC_TextBox.Size = New System.Drawing.Size(185, 21)
        Me.BARCODESC_TextBox.TabIndex = 1
        '
        'VersionLabel
        '
        Me.VersionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VersionLabel.Location = New System.Drawing.Point(929, 9)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(112, 42)
        Me.VersionLabel.TabIndex = 22
        Me.VersionLabel.Text = "Label1"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SC_ErrorProvider1
        '
        Me.SC_ErrorProvider1.ContainerControl = Me
        '
        'RPR0200Frm
        '
        Me.ClientSize = New System.Drawing.Size(1053, 462)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.SC_ExportCSV1)
        Me.Controls.Add(Me.SC_Save1)
        Me.Controls.Add(Me.SC_Delete1)
        Me.Controls.Add(Me.SC_Edit1)
        Me.Controls.Add(Me.SC_Refresh1)
        Me.Controls.Add(Me.SC_Cancel1)
        Me.Controls.Add(Me.SC_Add1)
        Me.Name = "RPR0200Frm"
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RPR0200DTO01BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RPR0200DTO02BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RPR0200DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        Me.TabList.PerformLayout()
        Me.TabData.ResumeLayout(False)
        Me.TabData.PerformLayout()
        CType(Me.LKM_CompanyDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabDetail.ResumeLayout(False)
        CType(Me.Repair_DetailDTOSC_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Repair_DetailDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LKM_CompanyOfficeDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SC_Conductor1 As SC_Win_FrontEnd.SC_Conductor
    Friend WithEvents SC_ExportCSV1 As SC_Win_FrontEnd.SC_ExportCSV
    Friend WithEvents SC_Save1 As SC_Win_FrontEnd.SC_Save
    Friend WithEvents SC_Delete1 As SC_Win_FrontEnd.SC_Delete
    Friend WithEvents SC_Edit1 As SC_Win_FrontEnd.SC_Edit
    Friend WithEvents SC_Refresh1 As SC_Win_FrontEnd.SC_Refresh
    Friend WithEvents SC_Cancel1 As SC_Win_FrontEnd.SC_Cancel
    Friend WithEvents SC_Add1 As SC_Win_FrontEnd.SC_Add
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabList As System.Windows.Forms.TabPage
    Friend WithEvents TabData As System.Windows.Forms.TabPage
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
    Friend WithEvents RPR0200DTO02SC_DataGridView As SC_Win_FrontEnd.SC_DataGridView
    Friend WithEvents RPR0200DTO02BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SC_GridSearch1 As SC_Win_FrontEnd.SC_GridSearch
    Friend WithEvents RPR0200DTO01BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BARCODESC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents COMPANY_OFFICE_IDSC_ComboBox As SC_Win_FrontEnd.SC_ComboBox
    Friend WithEvents FROM_DATESC_DateTimePicker As SC_Win_FrontEnd.SC_DateTimePicker
    Friend WithEvents TO_DATESC_DateTimePicker As SC_Win_FrontEnd.SC_DateTimePicker
    Friend WithEvents OUTLET_NAMESC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents OUTLET_IDSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents OutletSC_LookUp As SC_Win_FrontEnd.SC_LookUp
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabDetail As System.Windows.Forms.TabPage
    Friend WithEvents Repair_DetailDTOSC_DataGridView As SC_Win_FrontEnd.SC_DataGridView
    Friend WithEvents Repair_DetailDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SparepartSC_Detail As SC_Win_FrontEnd.SC_Detail
    Friend WithEvents TxtLimit As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents CheckLimit As SC_Win_FrontEnd.SC_CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KeSC_DateTimePicker As SC_Win_FrontEnd.SC_DateTimePicker
    Friend WithEvents DariSC_DateTimePicker As SC_Win_FrontEnd.SC_DateTimePicker
    Friend WithEvents TanggalSC_CheckBox As SC_Win_FrontEnd.SC_CheckBox
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LKM_CompanyOfficeDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LKM_CompanyDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SC_ErrorProvider1 As SC_Win_FrontEnd.SC_ErrorProvider
    Friend WithEvents COMPANY_IDSC_ComboBox As SC_Win_FrontEnd.SC_ComboBox
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
