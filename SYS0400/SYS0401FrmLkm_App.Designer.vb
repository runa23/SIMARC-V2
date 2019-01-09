<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SYS0401FrmLkm_App
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LKMSys_AppDTOSC_DataGridView = New SC_Win_FrontEnd.SC_DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LKMSys_AppDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SC_GridSearch1 = New SC_Win_FrontEnd.SC_GridSearch()
        Me.SC_ReturnLookUpAndFind1 = New SC_Win_FrontEnd.SC_ReturnLookUpAndFind()
        CType(Me.LKMSys_AppDTOSC_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LKMSys_AppDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LKMSys_AppDTOSC_DataGridView
        '
        Me.LKMSys_AppDTOSC_DataGridView.AllowUserToAddRows = False
        Me.LKMSys_AppDTOSC_DataGridView.AllowUserToDeleteRows = False
        Me.LKMSys_AppDTOSC_DataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LKMSys_AppDTOSC_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.LKMSys_AppDTOSC_DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LKMSys_AppDTOSC_DataGridView.AutoGenerateColumns = False
        Me.LKMSys_AppDTOSC_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LKMSys_AppDTOSC_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.LKMSys_AppDTOSC_DataGridView.DataSource = Me.LKMSys_AppDTOBindingSource
        Me.LKMSys_AppDTOSC_DataGridView.Location = New System.Drawing.Point(12, 12)
        Me.LKMSys_AppDTOSC_DataGridView.Name = "LKMSys_AppDTOSC_DataGridView"
        Me.LKMSys_AppDTOSC_DataGridView.ReadOnly = True
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LKMSys_AppDTOSC_DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.LKMSys_AppDTOSC_DataGridView.SC_ConductorSource = Nothing
        Me.LKMSys_AppDTOSC_DataGridView.Size = New System.Drawing.Size(344, 310)
        Me.LKMSys_AppDTOSC_DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "APP_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "App ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "APP_NAME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "App Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'LKMSys_AppDTOBindingSource
        '
        Me.LKMSys_AppDTOBindingSource.DataSource = GetType(SYS0400.SYS0401SvcRef.LKMSys_AppDTO)
        '
        'SC_GridSearch1
        '
        Me.SC_GridSearch1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SC_GridSearch1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SC_GridSearch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SC_GridSearch1.Location = New System.Drawing.Point(12, 328)
        Me.SC_GridSearch1.Name = "SC_GridSearch1"
        Me.SC_GridSearch1.SC_BindingSource = Me.LKMSys_AppDTOBindingSource
        Me.SC_GridSearch1.Size = New System.Drawing.Size(344, 32)
        Me.SC_GridSearch1.TabIndex = 2
        '
        'SC_ReturnLookUpAndFind1
        '
        Me.SC_ReturnLookUpAndFind1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SC_ReturnLookUpAndFind1.Location = New System.Drawing.Point(194, 366)
        Me.SC_ReturnLookUpAndFind1.Name = "SC_ReturnLookUpAndFind1"
        Me.SC_ReturnLookUpAndFind1.SC_BindingSource = Me.LKMSys_AppDTOBindingSource
        Me.SC_ReturnLookUpAndFind1.Size = New System.Drawing.Size(162, 31)
        Me.SC_ReturnLookUpAndFind1.TabIndex = 3
        '
        'SYS0401FrmLkm_App
        '
        Me.ClientSize = New System.Drawing.Size(368, 409)
        Me.Controls.Add(Me.SC_ReturnLookUpAndFind1)
        Me.Controls.Add(Me.SC_GridSearch1)
        Me.Controls.Add(Me.LKMSys_AppDTOSC_DataGridView)
        Me.Name = "SYS0401FrmLkm_App"
        Me.Text = "Look Up App"
        CType(Me.LKMSys_AppDTOSC_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LKMSys_AppDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LKMSys_AppDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LKMSys_AppDTOSC_DataGridView As SC_Win_FrontEnd.SC_DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SC_GridSearch1 As SC_Win_FrontEnd.SC_GridSearch
    Friend WithEvents SC_ReturnLookUpAndFind1 As SC_Win_FrontEnd.SC_ReturnLookUpAndFind

End Class
