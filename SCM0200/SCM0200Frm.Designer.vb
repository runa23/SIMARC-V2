<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SCM0200Frm
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
        Dim COMPANY_IDLabel As System.Windows.Forms.Label
        Dim COMPANY_NAMELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SCM0200Frm))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim REGIONAL_NAMELabel As System.Windows.Forms.Label
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.SC_ExportCSV1 = New SC_Win_FrontEnd.SC_ExportCSV(Me.components)
        Me.SC_Conductor1 = New SC_Win_FrontEnd.SC_Conductor(Me.components)
        Me.SCM0200DTO02SC_DataGridView = New SC_Win_FrontEnd.SC_DataGridView()
        Me.SC_Save1 = New SC_Win_FrontEnd.SC_Save()
        Me.SC_Delete1 = New SC_Win_FrontEnd.SC_Delete()
        Me.SC_Edit1 = New SC_Win_FrontEnd.SC_Edit()
        Me.SC_Refresh1 = New SC_Win_FrontEnd.SC_Refresh()
        Me.SC_Cancel1 = New SC_Win_FrontEnd.SC_Cancel()
        Me.SC_Add1 = New SC_Win_FrontEnd.SC_Add()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabList = New System.Windows.Forms.TabPage()
        Me.SC_GridSearch1 = New SC_Win_FrontEnd.SC_GridSearch()
        Me.TabData = New System.Windows.Forms.TabPage()
        Me.COMPANY_NAMESC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.COMPANY_IDSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.SC_ErrorProvider1 = New SC_Win_FrontEnd.SC_ErrorProvider(Me.components)
        Me.SCM0200DTO02BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SCM0200DTO01BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LKM_RegionalDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REGIONAL_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REGIONAL_NAMESC_ComboBox = New SC_Win_FrontEnd.SC_ComboBox()
        COMPANY_IDLabel = New System.Windows.Forms.Label()
        COMPANY_NAMELabel = New System.Windows.Forms.Label()
        REGIONAL_NAMELabel = New System.Windows.Forms.Label()
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCM0200DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabList.SuspendLayout()
        Me.TabData.SuspendLayout()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCM0200DTO02BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SCM0200DTO01BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LKM_RegionalDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'COMPANY_IDLabel
        '
        COMPANY_IDLabel.AutoSize = True
        COMPANY_IDLabel.Location = New System.Drawing.Point(37, 36)
        COMPANY_IDLabel.Name = "COMPANY_IDLabel"
        COMPANY_IDLabel.Size = New System.Drawing.Size(82, 13)
        COMPANY_IDLabel.TabIndex = 2
        COMPANY_IDLabel.Text = "* Company ID :"
        '
        'COMPANY_NAMELabel
        '
        COMPANY_NAMELabel.AutoSize = True
        COMPANY_NAMELabel.Location = New System.Drawing.Point(27, 62)
        COMPANY_NAMELabel.Name = "COMPANY_NAMELabel"
        COMPANY_NAMELabel.Size = New System.Drawing.Size(89, 13)
        COMPANY_NAMELabel.TabIndex = 4
        COMPANY_NAMELabel.Text = "Company Name :"
        '
        'VersionLabel
        '
        Me.VersionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VersionLabel.Location = New System.Drawing.Point(798, 9)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(165, 42)
        Me.VersionLabel.TabIndex = 15
        Me.VersionLabel.Text = "Label1"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SC_ExportCSV1
        '
        Me.SC_ExportCSV1.Image = CType(resources.GetObject("SC_ExportCSV1.Image"), System.Drawing.Image)
        Me.SC_ExportCSV1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_ExportCSV1.Location = New System.Drawing.Point(384, 12)
        Me.SC_ExportCSV1.Name = "SC_ExportCSV1"
        Me.SC_ExportCSV1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_ExportCSV1.SC_DataGridView = Me.SCM0200DTO02SC_DataGridView
        Me.SC_ExportCSV1.SC_DefaultFileName = "Master Company"
        Me.SC_ExportCSV1.Size = New System.Drawing.Size(61, 39)
        Me.SC_ExportCSV1.TabIndex = 14
        Me.SC_ExportCSV1.Text = "E&xport"
        Me.SC_ExportCSV1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_ExportCSV1.UseVisualStyleBackColor = True
        '
        'SC_Conductor1
        '
        Me.SC_Conductor1.SC_BindingSource = Me.SCM0200DTO01BindingSource
        Me.SC_Conductor1.SC_ParentBindingSource = Me.SCM0200DTO02BindingSource
        Me.SC_Conductor1.SC_ParentKey = "COMPANY_ID"
        '
        'SCM0200DTO02SC_DataGridView
        '
        Me.SCM0200DTO02SC_DataGridView.AllowUserToAddRows = False
        Me.SCM0200DTO02SC_DataGridView.AllowUserToDeleteRows = False
        Me.SCM0200DTO02SC_DataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCM0200DTO02SC_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.SCM0200DTO02SC_DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SCM0200DTO02SC_DataGridView.AutoGenerateColumns = False
        Me.SCM0200DTO02SC_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SCM0200DTO02SC_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.REGIONAL_ID, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.SCM0200DTO02SC_DataGridView.DataSource = Me.SCM0200DTO02BindingSource
        Me.SCM0200DTO02SC_DataGridView.Location = New System.Drawing.Point(6, 6)
        Me.SCM0200DTO02SC_DataGridView.Name = "SCM0200DTO02SC_DataGridView"
        Me.SCM0200DTO02SC_DataGridView.ReadOnly = True
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SCM0200DTO02SC_DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.SCM0200DTO02SC_DataGridView.SC_ConductorSource = Nothing
        Me.SCM0200DTO02SC_DataGridView.Size = New System.Drawing.Size(931, 352)
        Me.SCM0200DTO02SC_DataGridView.TabIndex = 0
        '
        'SC_Save1
        '
        Me.SC_Save1.Image = CType(resources.GetObject("SC_Save1.Image"), System.Drawing.Image)
        Me.SC_Save1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_Save1.Location = New System.Drawing.Point(260, 12)
        Me.SC_Save1.Name = "SC_Save1"
        Me.SC_Save1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_Save1.Size = New System.Drawing.Size(61, 39)
        Me.SC_Save1.TabIndex = 13
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
        Me.SC_Delete1.TabIndex = 12
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
        Me.SC_Edit1.TabIndex = 11
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
        Me.SC_Refresh1.TabIndex = 10
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
        Me.SC_Cancel1.TabIndex = 9
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
        Me.SC_Add1.TabIndex = 8
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
        Me.TabControl1.Size = New System.Drawing.Size(951, 426)
        Me.TabControl1.TabIndex = 16
        '
        'TabList
        '
        Me.TabList.Controls.Add(Me.SC_GridSearch1)
        Me.TabList.Controls.Add(Me.SCM0200DTO02SC_DataGridView)
        Me.TabList.Location = New System.Drawing.Point(4, 22)
        Me.TabList.Name = "TabList"
        Me.TabList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabList.Size = New System.Drawing.Size(943, 400)
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
        Me.SC_GridSearch1.Location = New System.Drawing.Point(6, 362)
        Me.SC_GridSearch1.Name = "SC_GridSearch1"
        Me.SC_GridSearch1.SC_BindingSource = Me.SCM0200DTO02BindingSource
        Me.SC_GridSearch1.Size = New System.Drawing.Size(931, 32)
        Me.SC_GridSearch1.TabIndex = 1
        '
        'TabData
        '
        Me.TabData.Controls.Add(Me.REGIONAL_NAMESC_ComboBox)
        Me.TabData.Controls.Add(REGIONAL_NAMELabel)
        Me.TabData.Controls.Add(COMPANY_NAMELabel)
        Me.TabData.Controls.Add(Me.COMPANY_NAMESC_TextBox)
        Me.TabData.Controls.Add(COMPANY_IDLabel)
        Me.TabData.Controls.Add(Me.COMPANY_IDSC_TextBox)
        Me.TabData.Location = New System.Drawing.Point(4, 22)
        Me.TabData.Name = "TabData"
        Me.TabData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabData.Size = New System.Drawing.Size(943, 400)
        Me.TabData.TabIndex = 1
        Me.TabData.Text = "Data"
        Me.TabData.UseVisualStyleBackColor = True
        '
        'COMPANY_NAMESC_TextBox
        '
        Me.COMPANY_NAMESC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.COMPANY_NAMESC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCM0200DTO01BindingSource, "COMPANY_NAME", True))
        Me.COMPANY_NAMESC_TextBox.Location = New System.Drawing.Point(120, 59)
        Me.COMPANY_NAMESC_TextBox.Name = "COMPANY_NAMESC_TextBox"
        Me.COMPANY_NAMESC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.COMPANY_NAMESC_TextBox.SC_EnableADD = True
        Me.COMPANY_NAMESC_TextBox.SC_EnableEDIT = True
        Me.COMPANY_NAMESC_TextBox.Size = New System.Drawing.Size(328, 21)
        Me.COMPANY_NAMESC_TextBox.TabIndex = 5
        '
        'COMPANY_IDSC_TextBox
        '
        Me.COMPANY_IDSC_TextBox.BackColor = System.Drawing.Color.White
        Me.COMPANY_IDSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.COMPANY_IDSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SCM0200DTO01BindingSource, "COMPANY_ID", True))
        Me.COMPANY_IDSC_TextBox.Location = New System.Drawing.Point(120, 33)
        Me.COMPANY_IDSC_TextBox.Name = "COMPANY_IDSC_TextBox"
        Me.COMPANY_IDSC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.COMPANY_IDSC_TextBox.SC_EnableADD = True
        Me.COMPANY_IDSC_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.COMPANY_IDSC_TextBox.TabIndex = 2
        '
        'SC_ErrorProvider1
        '
        Me.SC_ErrorProvider1.ContainerControl = Me
        '
        'REGIONAL_NAMELabel
        '
        REGIONAL_NAMELabel.AutoSize = True
        REGIONAL_NAMELabel.Location = New System.Drawing.Point(55, 10)
        REGIONAL_NAMELabel.Name = "REGIONAL_NAMELabel"
        REGIONAL_NAMELabel.Size = New System.Drawing.Size(64, 13)
        REGIONAL_NAMELabel.TabIndex = 0
        REGIONAL_NAMELabel.Text = "* Regional :"
        '
        'SCM0200DTO02BindingSource
        '
        Me.SCM0200DTO02BindingSource.DataSource = GetType(SCM0200.SCM0200SvcRef.SCM0200DTO02)
        '
        'SCM0200DTO01BindingSource
        '
        Me.SCM0200DTO01BindingSource.DataSource = GetType(SCM0200.SCM0200SvcRef.SCM0200DTO01)
        '
        'LKM_RegionalDTOBindingSource
        '
        Me.LKM_RegionalDTOBindingSource.DataSource = GetType(SCM0200.SCM0200SvcRef.LKM_RegionalDTO)
        '
        'REGIONAL_ID
        '
        Me.REGIONAL_ID.DataPropertyName = "REGIONAL_ID"
        Me.REGIONAL_ID.HeaderText = "Regional"
        Me.REGIONAL_ID.Name = "REGIONAL_ID"
        Me.REGIONAL_ID.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "COMPANY_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Company ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "COMPANY_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Company Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
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
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UPD_BY"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Update By"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UPD_DATE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Update Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'REGIONAL_NAMESC_ComboBox
        '
        Me.REGIONAL_NAMESC_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SCM0200DTO01BindingSource, "REGIONAL_ID", True))
        Me.REGIONAL_NAMESC_ComboBox.DataSource = Me.LKM_RegionalDTOBindingSource
        Me.REGIONAL_NAMESC_ComboBox.DisplayMember = "REGIONAL_NAME"
        Me.REGIONAL_NAMESC_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.REGIONAL_NAMESC_ComboBox.FormattingEnabled = True
        Me.REGIONAL_NAMESC_ComboBox.Location = New System.Drawing.Point(120, 6)
        Me.REGIONAL_NAMESC_ComboBox.Name = "REGIONAL_NAMESC_ComboBox"
        Me.REGIONAL_NAMESC_ComboBox.SC_ConductorSource = Me.SC_Conductor1
        Me.REGIONAL_NAMESC_ComboBox.SC_EnableADD = True
        Me.REGIONAL_NAMESC_ComboBox.SC_EnableEDIT = True
        Me.REGIONAL_NAMESC_ComboBox.Size = New System.Drawing.Size(247, 21)
        Me.REGIONAL_NAMESC_ComboBox.TabIndex = 1
        Me.REGIONAL_NAMESC_ComboBox.ValueMember = "REGIONAL_ID"
        '
        'SCM0200Frm
        '
        Me.ClientSize = New System.Drawing.Size(975, 495)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.SC_ExportCSV1)
        Me.Controls.Add(Me.SC_Save1)
        Me.Controls.Add(Me.SC_Delete1)
        Me.Controls.Add(Me.SC_Edit1)
        Me.Controls.Add(Me.SC_Refresh1)
        Me.Controls.Add(Me.SC_Cancel1)
        Me.Controls.Add(Me.SC_Add1)
        Me.Name = "SCM0200Frm"
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCM0200DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        Me.TabData.ResumeLayout(False)
        Me.TabData.PerformLayout()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCM0200DTO02BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SCM0200DTO01BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LKM_RegionalDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VersionLabel As System.Windows.Forms.Label
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
    Friend WithEvents SCM0200DTO02SC_DataGridView As SC_Win_FrontEnd.SC_DataGridView
    Friend WithEvents SCM0200DTO02BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SC_Conductor1 As SC_Win_FrontEnd.SC_Conductor
    Friend WithEvents COMPANY_NAMESC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents SCM0200DTO01BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMPANY_IDSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents SC_ErrorProvider1 As SC_Win_FrontEnd.SC_ErrorProvider
    Friend WithEvents SC_GridSearch1 As SC_Win_FrontEnd.SC_GridSearch
    Friend WithEvents LKM_RegionalDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REGIONAL_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REGIONAL_NAMESC_ComboBox As SC_Win_FrontEnd.SC_ComboBox

End Class
