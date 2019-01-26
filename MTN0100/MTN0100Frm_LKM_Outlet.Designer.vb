<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MTN0100Frm_LKM_Outlet
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LKM_OutletDTOSC_DataGridView = New SC_Win_FrontEnd.SC_DataGridView()
        Me.SC_GridSearch1 = New SC_Win_FrontEnd.SC_GridSearch()
        Me.SC_ReturnLookUpAndFind1 = New SC_Win_FrontEnd.SC_ReturnLookUpAndFind()
        Me.LKM_OutletDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LKM_OutletDTOSC_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LKM_OutletDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LKM_OutletDTOSC_DataGridView
        '
        Me.LKM_OutletDTOSC_DataGridView.AllowUserToAddRows = False
        Me.LKM_OutletDTOSC_DataGridView.AllowUserToDeleteRows = False
        Me.LKM_OutletDTOSC_DataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LKM_OutletDTOSC_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.LKM_OutletDTOSC_DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LKM_OutletDTOSC_DataGridView.AutoGenerateColumns = False
        Me.LKM_OutletDTOSC_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LKM_OutletDTOSC_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.LKM_OutletDTOSC_DataGridView.DataSource = Me.LKM_OutletDTOBindingSource
        Me.LKM_OutletDTOSC_DataGridView.Location = New System.Drawing.Point(12, 12)
        Me.LKM_OutletDTOSC_DataGridView.Name = "LKM_OutletDTOSC_DataGridView"
        Me.LKM_OutletDTOSC_DataGridView.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LKM_OutletDTOSC_DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.LKM_OutletDTOSC_DataGridView.SC_ConductorSource = Nothing
        Me.LKM_OutletDTOSC_DataGridView.Size = New System.Drawing.Size(372, 375)
        Me.LKM_OutletDTOSC_DataGridView.TabIndex = 1
        '
        'SC_GridSearch1
        '
        Me.SC_GridSearch1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SC_GridSearch1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SC_GridSearch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SC_GridSearch1.Location = New System.Drawing.Point(12, 393)
        Me.SC_GridSearch1.Name = "SC_GridSearch1"
        Me.SC_GridSearch1.SC_BindingSource = Me.LKM_OutletDTOBindingSource
        Me.SC_GridSearch1.Size = New System.Drawing.Size(372, 32)
        Me.SC_GridSearch1.TabIndex = 2
        '
        'SC_ReturnLookUpAndFind1
        '
        Me.SC_ReturnLookUpAndFind1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SC_ReturnLookUpAndFind1.Location = New System.Drawing.Point(222, 431)
        Me.SC_ReturnLookUpAndFind1.Name = "SC_ReturnLookUpAndFind1"
        Me.SC_ReturnLookUpAndFind1.SC_BindingSource = Me.LKM_OutletDTOBindingSource
        Me.SC_ReturnLookUpAndFind1.Size = New System.Drawing.Size(162, 31)
        Me.SC_ReturnLookUpAndFind1.TabIndex = 3
        '
        'LKM_OutletDTOBindingSource
        '
        Me.LKM_OutletDTOBindingSource.DataSource = GetType(MTN0100.MTN0100SvcRef.LKM_OutletDTO)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "OUTLET_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Outlet ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OUTLET_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Outlet Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'MTN0100Frm_LKM_Outlet
        '
        Me.ClientSize = New System.Drawing.Size(396, 473)
        Me.Controls.Add(Me.SC_ReturnLookUpAndFind1)
        Me.Controls.Add(Me.SC_GridSearch1)
        Me.Controls.Add(Me.LKM_OutletDTOSC_DataGridView)
        Me.Name = "MTN0100Frm_LKM_Outlet"
        CType(Me.LKM_OutletDTOSC_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LKM_OutletDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LKM_OutletDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LKM_OutletDTOSC_DataGridView As SC_Win_FrontEnd.SC_DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SC_GridSearch1 As SC_Win_FrontEnd.SC_GridSearch
    Friend WithEvents SC_ReturnLookUpAndFind1 As SC_Win_FrontEnd.SC_ReturnLookUpAndFind

End Class
