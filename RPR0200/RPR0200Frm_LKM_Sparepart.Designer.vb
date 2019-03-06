<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPR0200Frm_LKM_Sparepart
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LKM_SparepartDTOSC_DataGridView = New SC_Win_FrontEnd.SC_DataGridView()
        Me.LKM_SparepartDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SC_GridSearch1 = New SC_Win_FrontEnd.SC_GridSearch()
        Me.CancelSC_Button = New SC_Win_FrontEnd.SC_Button()
        Me.OKSC_Button = New SC_Win_FrontEnd.SC_Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PILIH = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LKM_SparepartDTOSC_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LKM_SparepartDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LKM_SparepartDTOSC_DataGridView
        '
        Me.LKM_SparepartDTOSC_DataGridView.AllowUserToAddRows = False
        Me.LKM_SparepartDTOSC_DataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LKM_SparepartDTOSC_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.LKM_SparepartDTOSC_DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LKM_SparepartDTOSC_DataGridView.AutoGenerateColumns = False
        Me.LKM_SparepartDTOSC_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LKM_SparepartDTOSC_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PILIH, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.LKM_SparepartDTOSC_DataGridView.DataSource = Me.LKM_SparepartDTOBindingSource
        Me.LKM_SparepartDTOSC_DataGridView.Location = New System.Drawing.Point(12, 12)
        Me.LKM_SparepartDTOSC_DataGridView.Name = "LKM_SparepartDTOSC_DataGridView"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LKM_SparepartDTOSC_DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.LKM_SparepartDTOSC_DataGridView.SC_ConductorSource = Nothing
        Me.LKM_SparepartDTOSC_DataGridView.Size = New System.Drawing.Size(613, 415)
        Me.LKM_SparepartDTOSC_DataGridView.TabIndex = 1
        '
        'LKM_SparepartDTOBindingSource
        '
        Me.LKM_SparepartDTOBindingSource.DataSource = GetType(RPR0200.RPR0200SvcRef.LKM_SparepartDTO)
        '
        'SC_GridSearch1
        '
        Me.SC_GridSearch1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SC_GridSearch1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SC_GridSearch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SC_GridSearch1.Location = New System.Drawing.Point(12, 433)
        Me.SC_GridSearch1.Name = "SC_GridSearch1"
        Me.SC_GridSearch1.SC_BindingSource = Me.LKM_SparepartDTOBindingSource
        Me.SC_GridSearch1.Size = New System.Drawing.Size(611, 32)
        Me.SC_GridSearch1.TabIndex = 6
        '
        'CancelSC_Button
        '
        Me.CancelSC_Button.Location = New System.Drawing.Point(548, 471)
        Me.CancelSC_Button.Name = "CancelSC_Button"
        Me.CancelSC_Button.SC_ConductorSource = Nothing
        Me.CancelSC_Button.Size = New System.Drawing.Size(75, 23)
        Me.CancelSC_Button.TabIndex = 7
        Me.CancelSC_Button.Text = "Cancel"
        Me.CancelSC_Button.UseVisualStyleBackColor = True
        '
        'OKSC_Button
        '
        Me.OKSC_Button.Location = New System.Drawing.Point(467, 471)
        Me.OKSC_Button.Name = "OKSC_Button"
        Me.OKSC_Button.SC_ConductorSource = Nothing
        Me.OKSC_Button.Size = New System.Drawing.Size(75, 23)
        Me.OKSC_Button.TabIndex = 8
        Me.OKSC_Button.Text = "OK"
        Me.OKSC_Button.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "STOCK_PART"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'PILIH
        '
        Me.PILIH.DataPropertyName = "PILIH"
        Me.PILIH.HeaderText = "Pilih"
        Me.PILIH.Name = "PILIH"
        Me.PILIH.Width = 35
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "KD_PART"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kode"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NAMA_PART"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 225
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "HARGA_PART"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Harga"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SATUAN_PART"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Satuan"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "STOCK_PART"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'RPR0200Frm_LKM_Sparepart
        '
        Me.ClientSize = New System.Drawing.Size(635, 514)
        Me.Controls.Add(Me.OKSC_Button)
        Me.Controls.Add(Me.CancelSC_Button)
        Me.Controls.Add(Me.SC_GridSearch1)
        Me.Controls.Add(Me.LKM_SparepartDTOSC_DataGridView)
        Me.Name = "RPR0200Frm_LKM_Sparepart"
        CType(Me.LKM_SparepartDTOSC_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LKM_SparepartDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LKM_SparepartDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LKM_SparepartDTOSC_DataGridView As SC_Win_FrontEnd.SC_DataGridView
    Friend WithEvents SC_GridSearch1 As SC_Win_FrontEnd.SC_GridSearch
    Friend WithEvents CancelSC_Button As SC_Win_FrontEnd.SC_Button
    Friend WithEvents OKSC_Button As SC_Win_FrontEnd.SC_Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PILIH As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
