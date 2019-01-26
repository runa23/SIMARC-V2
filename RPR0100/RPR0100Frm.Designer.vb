<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPR0100Frm
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
        Dim KD_PARTLabel As System.Windows.Forms.Label
        Dim NAMA_PARTLabel As System.Windows.Forms.Label
        Dim HARGA_PARTLabel As System.Windows.Forms.Label
        Dim STOCK_PARTLabel As System.Windows.Forms.Label
        Dim SATUAN_PARTLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RPR0100Frm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabList = New System.Windows.Forms.TabPage()
        Me.SC_GridSearch1 = New SC_Win_FrontEnd.SC_GridSearch()
        Me.RPR0100DTO02BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RPR0100DTO02SC_DataGridView = New SC_Win_FrontEnd.SC_DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabData = New System.Windows.Forms.TabPage()
        Me.SATUAN_PARTSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.RPR0100DTO01BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SC_Conductor1 = New SC_Win_FrontEnd.SC_Conductor(Me.components)
        Me.STOCK_PARTSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.HARGA_PARTSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.NAMA_PARTSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.KD_PARTSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.SC_ErrorProvider1 = New SC_Win_FrontEnd.SC_ErrorProvider(Me.components)
        Me.SC_ExportCSV1 = New SC_Win_FrontEnd.SC_ExportCSV(Me.components)
        Me.SC_Save1 = New SC_Win_FrontEnd.SC_Save()
        Me.SC_Delete1 = New SC_Win_FrontEnd.SC_Delete()
        Me.SC_Edit1 = New SC_Win_FrontEnd.SC_Edit()
        Me.SC_Refresh1 = New SC_Win_FrontEnd.SC_Refresh()
        Me.SC_Cancel1 = New SC_Win_FrontEnd.SC_Cancel()
        Me.SC_Add1 = New SC_Win_FrontEnd.SC_Add()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        KD_PARTLabel = New System.Windows.Forms.Label()
        NAMA_PARTLabel = New System.Windows.Forms.Label()
        HARGA_PARTLabel = New System.Windows.Forms.Label()
        STOCK_PARTLabel = New System.Windows.Forms.Label()
        SATUAN_PARTLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabList.SuspendLayout()
        CType(Me.RPR0100DTO02BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RPR0100DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabData.SuspendLayout()
        CType(Me.RPR0100DTO01BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KD_PARTLabel
        '
        KD_PARTLabel.AutoSize = True
        KD_PARTLabel.Location = New System.Drawing.Point(25, 10)
        KD_PARTLabel.Name = "KD_PARTLabel"
        KD_PARTLabel.Size = New System.Drawing.Size(95, 13)
        KD_PARTLabel.TabIndex = 0
        KD_PARTLabel.Text = "*Kode Sparepart :"
        '
        'NAMA_PARTLabel
        '
        NAMA_PARTLabel.AutoSize = True
        NAMA_PARTLabel.Location = New System.Drawing.Point(28, 37)
        NAMA_PARTLabel.Name = "NAMA_PARTLabel"
        NAMA_PARTLabel.Size = New System.Drawing.Size(92, 13)
        NAMA_PARTLabel.TabIndex = 2
        NAMA_PARTLabel.Text = "Nama Sparepart :"
        '
        'HARGA_PARTLabel
        '
        HARGA_PARTLabel.AutoSize = True
        HARGA_PARTLabel.Location = New System.Drawing.Point(77, 64)
        HARGA_PARTLabel.Name = "HARGA_PARTLabel"
        HARGA_PARTLabel.Size = New System.Drawing.Size(43, 13)
        HARGA_PARTLabel.TabIndex = 4
        HARGA_PARTLabel.Text = "Harga :"
        '
        'STOCK_PARTLabel
        '
        STOCK_PARTLabel.AutoSize = True
        STOCK_PARTLabel.Location = New System.Drawing.Point(80, 91)
        STOCK_PARTLabel.Name = "STOCK_PARTLabel"
        STOCK_PARTLabel.Size = New System.Drawing.Size(40, 13)
        STOCK_PARTLabel.TabIndex = 6
        STOCK_PARTLabel.Text = "Stock :"
        '
        'SATUAN_PARTLabel
        '
        SATUAN_PARTLabel.AutoSize = True
        SATUAN_PARTLabel.Location = New System.Drawing.Point(72, 118)
        SATUAN_PARTLabel.Name = "SATUAN_PARTLabel"
        SATUAN_PARTLabel.Size = New System.Drawing.Size(48, 13)
        SATUAN_PARTLabel.TabIndex = 8
        SATUAN_PARTLabel.Text = "Satuan :"
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
        Me.TabControl1.Size = New System.Drawing.Size(935, 408)
        Me.TabControl1.TabIndex = 0
        '
        'TabList
        '
        Me.TabList.Controls.Add(Me.SC_GridSearch1)
        Me.TabList.Controls.Add(Me.RPR0100DTO02SC_DataGridView)
        Me.TabList.Location = New System.Drawing.Point(4, 22)
        Me.TabList.Name = "TabList"
        Me.TabList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabList.Size = New System.Drawing.Size(927, 382)
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
        Me.SC_GridSearch1.Location = New System.Drawing.Point(6, 344)
        Me.SC_GridSearch1.Name = "SC_GridSearch1"
        Me.SC_GridSearch1.SC_BindingSource = Me.RPR0100DTO02BindingSource
        Me.SC_GridSearch1.Size = New System.Drawing.Size(915, 32)
        Me.SC_GridSearch1.TabIndex = 1
        '
        'RPR0100DTO02BindingSource
        '
        Me.RPR0100DTO02BindingSource.DataSource = GetType(RPR0100.RPR0100SvcRef.RPR0100DTO02)
        '
        'RPR0100DTO02SC_DataGridView
        '
        Me.RPR0100DTO02SC_DataGridView.AllowUserToAddRows = False
        Me.RPR0100DTO02SC_DataGridView.AllowUserToDeleteRows = False
        Me.RPR0100DTO02SC_DataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RPR0100DTO02SC_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.RPR0100DTO02SC_DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RPR0100DTO02SC_DataGridView.AutoGenerateColumns = False
        Me.RPR0100DTO02SC_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RPR0100DTO02SC_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.RPR0100DTO02SC_DataGridView.DataSource = Me.RPR0100DTO02BindingSource
        Me.RPR0100DTO02SC_DataGridView.Location = New System.Drawing.Point(6, 6)
        Me.RPR0100DTO02SC_DataGridView.Name = "RPR0100DTO02SC_DataGridView"
        Me.RPR0100DTO02SC_DataGridView.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RPR0100DTO02SC_DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.RPR0100DTO02SC_DataGridView.SC_ConductorSource = Nothing
        Me.RPR0100DTO02SC_DataGridView.Size = New System.Drawing.Size(915, 332)
        Me.RPR0100DTO02SC_DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "KD_PART"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Kode Sparepart"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NAMA_PART"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nama Sparepart"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "HARGA_PART"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "Harga"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SATUAN_PART"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Satuan"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CREA_BY"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Create By"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CREA_DATE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Create Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UPD_BY"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Update By"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "UPD_DATE"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Update Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'TabData
        '
        Me.TabData.Controls.Add(SATUAN_PARTLabel)
        Me.TabData.Controls.Add(Me.SATUAN_PARTSC_TextBox)
        Me.TabData.Controls.Add(STOCK_PARTLabel)
        Me.TabData.Controls.Add(Me.STOCK_PARTSC_TextBox)
        Me.TabData.Controls.Add(HARGA_PARTLabel)
        Me.TabData.Controls.Add(Me.HARGA_PARTSC_TextBox)
        Me.TabData.Controls.Add(NAMA_PARTLabel)
        Me.TabData.Controls.Add(Me.NAMA_PARTSC_TextBox)
        Me.TabData.Controls.Add(KD_PARTLabel)
        Me.TabData.Controls.Add(Me.KD_PARTSC_TextBox)
        Me.TabData.Location = New System.Drawing.Point(4, 22)
        Me.TabData.Name = "TabData"
        Me.TabData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabData.Size = New System.Drawing.Size(927, 382)
        Me.TabData.TabIndex = 1
        Me.TabData.Text = "Data"
        Me.TabData.UseVisualStyleBackColor = True
        '
        'SATUAN_PARTSC_TextBox
        '
        Me.SATUAN_PARTSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SATUAN_PARTSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RPR0100DTO01BindingSource, "SATUAN_PART", True))
        Me.SATUAN_PARTSC_TextBox.Location = New System.Drawing.Point(120, 114)
        Me.SATUAN_PARTSC_TextBox.Name = "SATUAN_PARTSC_TextBox"
        Me.SATUAN_PARTSC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.SATUAN_PARTSC_TextBox.SC_EnableADD = True
        Me.SATUAN_PARTSC_TextBox.SC_EnableEDIT = True
        Me.SATUAN_PARTSC_TextBox.Size = New System.Drawing.Size(141, 21)
        Me.SATUAN_PARTSC_TextBox.TabIndex = 9
        '
        'RPR0100DTO01BindingSource
        '
        Me.RPR0100DTO01BindingSource.DataSource = GetType(RPR0100.RPR0100SvcRef.RPR0100DTO01)
        '
        'SC_Conductor1
        '
        Me.SC_Conductor1.SC_BindingSource = Me.RPR0100DTO01BindingSource
        Me.SC_Conductor1.SC_ParentBindingSource = Me.RPR0100DTO02BindingSource
        Me.SC_Conductor1.SC_ParentKey = "KD_PART"
        '
        'STOCK_PARTSC_TextBox
        '
        Me.STOCK_PARTSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.STOCK_PARTSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RPR0100DTO01BindingSource, "STOCK_PART", True))
        Me.STOCK_PARTSC_TextBox.Location = New System.Drawing.Point(120, 87)
        Me.STOCK_PARTSC_TextBox.Name = "STOCK_PARTSC_TextBox"
        Me.STOCK_PARTSC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.STOCK_PARTSC_TextBox.SC_EnableADD = True
        Me.STOCK_PARTSC_TextBox.SC_EnableEDIT = True
        Me.STOCK_PARTSC_TextBox.Size = New System.Drawing.Size(61, 21)
        Me.STOCK_PARTSC_TextBox.TabIndex = 7
        Me.STOCK_PARTSC_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'HARGA_PARTSC_TextBox
        '
        Me.HARGA_PARTSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.HARGA_PARTSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RPR0100DTO01BindingSource, "HARGA_PART", True))
        Me.HARGA_PARTSC_TextBox.Location = New System.Drawing.Point(120, 60)
        Me.HARGA_PARTSC_TextBox.Name = "HARGA_PARTSC_TextBox"
        Me.HARGA_PARTSC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.HARGA_PARTSC_TextBox.SC_EnableADD = True
        Me.HARGA_PARTSC_TextBox.SC_EnableEDIT = True
        Me.HARGA_PARTSC_TextBox.Size = New System.Drawing.Size(141, 21)
        Me.HARGA_PARTSC_TextBox.TabIndex = 5
        Me.HARGA_PARTSC_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NAMA_PARTSC_TextBox
        '
        Me.NAMA_PARTSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NAMA_PARTSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RPR0100DTO01BindingSource, "NAMA_PART", True))
        Me.NAMA_PARTSC_TextBox.Location = New System.Drawing.Point(120, 33)
        Me.NAMA_PARTSC_TextBox.Name = "NAMA_PARTSC_TextBox"
        Me.NAMA_PARTSC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.NAMA_PARTSC_TextBox.SC_EnableADD = True
        Me.NAMA_PARTSC_TextBox.SC_EnableEDIT = True
        Me.NAMA_PARTSC_TextBox.Size = New System.Drawing.Size(359, 21)
        Me.NAMA_PARTSC_TextBox.TabIndex = 3
        '
        'KD_PARTSC_TextBox
        '
        Me.KD_PARTSC_TextBox.BackColor = System.Drawing.SystemColors.Control
        Me.KD_PARTSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.KD_PARTSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RPR0100DTO01BindingSource, "KD_PART", True))
        Me.KD_PARTSC_TextBox.Location = New System.Drawing.Point(120, 6)
        Me.KD_PARTSC_TextBox.Name = "KD_PARTSC_TextBox"
        Me.KD_PARTSC_TextBox.ReadOnly = True
        Me.KD_PARTSC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.KD_PARTSC_TextBox.Size = New System.Drawing.Size(61, 21)
        Me.KD_PARTSC_TextBox.TabIndex = 1
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
        Me.SC_ExportCSV1.SC_DataGridView = Me.RPR0100DTO02SC_DataGridView
        Me.SC_ExportCSV1.SC_DefaultFileName = "Sparepart"
        Me.SC_ExportCSV1.Size = New System.Drawing.Size(61, 39)
        Me.SC_ExportCSV1.TabIndex = 20
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
        'VersionLabel
        '
        Me.VersionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VersionLabel.Location = New System.Drawing.Point(782, 9)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(165, 42)
        Me.VersionLabel.TabIndex = 21
        Me.VersionLabel.Text = "Label1"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "STOCK_PART"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'RPR0100Frm
        '
        Me.ClientSize = New System.Drawing.Size(959, 477)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.SC_ExportCSV1)
        Me.Controls.Add(Me.SC_Save1)
        Me.Controls.Add(Me.SC_Delete1)
        Me.Controls.Add(Me.SC_Edit1)
        Me.Controls.Add(Me.SC_Refresh1)
        Me.Controls.Add(Me.SC_Cancel1)
        Me.Controls.Add(Me.SC_Add1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "RPR0100Frm"
        Me.TabControl1.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        CType(Me.RPR0100DTO02BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RPR0100DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabData.ResumeLayout(False)
        Me.TabData.PerformLayout()
        CType(Me.RPR0100DTO01BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabList As System.Windows.Forms.TabPage
    Friend WithEvents TabData As System.Windows.Forms.TabPage
    Friend WithEvents RPR0100DTO02SC_DataGridView As SC_Win_FrontEnd.SC_DataGridView
    Friend WithEvents RPR0100DTO02BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KD_PARTSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents RPR0100DTO01BindingSource As System.Windows.Forms.BindingSource
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
    Friend WithEvents SC_GridSearch1 As SC_Win_FrontEnd.SC_GridSearch
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMA_PARTSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents SATUAN_PARTSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents STOCK_PARTSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents HARGA_PARTSC_TextBox As SC_Win_FrontEnd.SC_TextBox

End Class
