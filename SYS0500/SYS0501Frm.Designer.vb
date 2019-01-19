<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SYS0501Frm
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
        Dim USER_IDLabel As System.Windows.Forms.Label
        Dim ROLE_NAMELabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SYS0501Frm))
        Me.SC_ErrorProvider1 = New SC_Win_FrontEnd.SC_ErrorProvider(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.USER_IDSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.SYS0500DTO02BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabList = New System.Windows.Forms.TabPage()
        Me.SYS0501DTO02SC_DataGridView = New SC_Win_FrontEnd.SC_DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SYS0501DTO02BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabData = New System.Windows.Forms.TabPage()
        Me.ROLE_NAMESC_ComboBox = New SC_Win_FrontEnd.SC_ComboBox()
        Me.SYS0501DTO01BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LKM_RoleDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SC_Save1 = New SC_Win_FrontEnd.SC_Save()
        Me.SC_Conductor1 = New SC_Win_FrontEnd.SC_Conductor(Me.components)
        Me.SC_Delete1 = New SC_Win_FrontEnd.SC_Delete()
        Me.SC_Refresh1 = New SC_Win_FrontEnd.SC_Refresh()
        Me.SC_Cancel1 = New SC_Win_FrontEnd.SC_Cancel()
        Me.SC_Add1 = New SC_Win_FrontEnd.SC_Add()
        USER_IDLabel = New System.Windows.Forms.Label()
        ROLE_NAMELabel = New System.Windows.Forms.Label()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SYS0500DTO02BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabList.SuspendLayout()
        CType(Me.SYS0501DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYS0501DTO02BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabData.SuspendLayout()
        CType(Me.SYS0501DTO01BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LKM_RoleDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'USER_IDLabel
        '
        USER_IDLabel.AutoSize = True
        USER_IDLabel.Location = New System.Drawing.Point(18, 135)
        USER_IDLabel.Name = "USER_IDLabel"
        USER_IDLabel.Size = New System.Drawing.Size(50, 13)
        USER_IDLabel.TabIndex = 0
        USER_IDLabel.Text = "User ID :"
        '
        'ROLE_NAMELabel
        '
        ROLE_NAMELabel.AutoSize = True
        ROLE_NAMELabel.Location = New System.Drawing.Point(51, 54)
        ROLE_NAMELabel.Name = "ROLE_NAMELabel"
        ROLE_NAMELabel.Size = New System.Drawing.Size(65, 13)
        ROLE_NAMELabel.TabIndex = 0
        ROLE_NAMELabel.Text = "Role Name :"
        '
        'SC_ErrorProvider1
        '
        Me.SC_ErrorProvider1.ContainerControl = Me
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.SplitContainer1.Panel1.Controls.Add(USER_IDLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.USER_IDSC_TextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SC_Save1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SC_Delete1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SC_Refresh1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SC_Cancel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SC_Add1)
        Me.SplitContainer1.Size = New System.Drawing.Size(843, 478)
        Me.SplitContainer1.SplitterDistance = 266
        Me.SplitContainer1.TabIndex = 0
        '
        'USER_IDSC_TextBox
        '
        Me.USER_IDSC_TextBox.BackColor = System.Drawing.SystemColors.Control
        Me.USER_IDSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.USER_IDSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SYS0500DTO02BindingSource, "USER_ID", True))
        Me.USER_IDSC_TextBox.Enabled = False
        Me.USER_IDSC_TextBox.Location = New System.Drawing.Point(75, 131)
        Me.USER_IDSC_TextBox.Name = "USER_IDSC_TextBox"
        Me.USER_IDSC_TextBox.ReadOnly = True
        Me.USER_IDSC_TextBox.SC_ConductorSource = Nothing
        Me.USER_IDSC_TextBox.Size = New System.Drawing.Size(177, 21)
        Me.USER_IDSC_TextBox.TabIndex = 1
        '
        'SYS0500DTO02BindingSource
        '
        Me.SYS0500DTO02BindingSource.DataSource = GetType(SYS0500.SYS0500SvcRef.SYS0500DTO02)
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
        Me.TabControl1.Size = New System.Drawing.Size(567, 411)
        Me.TabControl1.TabIndex = 55
        '
        'TabList
        '
        Me.TabList.Controls.Add(Me.SYS0501DTO02SC_DataGridView)
        Me.TabList.Location = New System.Drawing.Point(4, 22)
        Me.TabList.Name = "TabList"
        Me.TabList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabList.Size = New System.Drawing.Size(559, 385)
        Me.TabList.TabIndex = 0
        Me.TabList.Text = "List"
        Me.TabList.UseVisualStyleBackColor = True
        '
        'SYS0501DTO02SC_DataGridView
        '
        Me.SYS0501DTO02SC_DataGridView.AllowUserToAddRows = False
        Me.SYS0501DTO02SC_DataGridView.AllowUserToDeleteRows = False
        Me.SYS0501DTO02SC_DataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYS0501DTO02SC_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.SYS0501DTO02SC_DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SYS0501DTO02SC_DataGridView.AutoGenerateColumns = False
        Me.SYS0501DTO02SC_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SYS0501DTO02SC_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.SYS0501DTO02SC_DataGridView.DataSource = Me.SYS0501DTO02BindingSource
        Me.SYS0501DTO02SC_DataGridView.Location = New System.Drawing.Point(6, 6)
        Me.SYS0501DTO02SC_DataGridView.Name = "SYS0501DTO02SC_DataGridView"
        Me.SYS0501DTO02SC_DataGridView.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYS0501DTO02SC_DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.SYS0501DTO02SC_DataGridView.SC_ConductorSource = Nothing
        Me.SYS0501DTO02SC_DataGridView.Size = New System.Drawing.Size(547, 373)
        Me.SYS0501DTO02SC_DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "USER_ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "User ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ROLE_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Role ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ROLE_NAME"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Role Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
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
        'SYS0501DTO02BindingSource
        '
        Me.SYS0501DTO02BindingSource.DataSource = GetType(SYS0500.SYS0501SvcRef.SYS0501DTO02)
        '
        'TabData
        '
        Me.TabData.Controls.Add(ROLE_NAMELabel)
        Me.TabData.Controls.Add(Me.ROLE_NAMESC_ComboBox)
        Me.TabData.Location = New System.Drawing.Point(4, 22)
        Me.TabData.Name = "TabData"
        Me.TabData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabData.Size = New System.Drawing.Size(559, 385)
        Me.TabData.TabIndex = 1
        Me.TabData.Text = "Data"
        Me.TabData.UseVisualStyleBackColor = True
        '
        'ROLE_NAMESC_ComboBox
        '
        Me.ROLE_NAMESC_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SYS0501DTO01BindingSource, "ROLE_ID", True))
        Me.ROLE_NAMESC_ComboBox.DataSource = Me.LKM_RoleDTOBindingSource
        Me.ROLE_NAMESC_ComboBox.DisplayMember = "ROLE_NAME"
        Me.ROLE_NAMESC_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ROLE_NAMESC_ComboBox.FormattingEnabled = True
        Me.ROLE_NAMESC_ComboBox.Location = New System.Drawing.Point(125, 50)
        Me.ROLE_NAMESC_ComboBox.Name = "ROLE_NAMESC_ComboBox"
        Me.ROLE_NAMESC_ComboBox.SC_ConductorSource = Nothing
        Me.ROLE_NAMESC_ComboBox.Size = New System.Drawing.Size(247, 21)
        Me.ROLE_NAMESC_ComboBox.TabIndex = 1
        Me.ROLE_NAMESC_ComboBox.ValueMember = "ROLE_ID"
        '
        'SYS0501DTO01BindingSource
        '
        Me.SYS0501DTO01BindingSource.DataSource = GetType(SYS0500.SYS0501SvcRef.SYS0501DTO01)
        '
        'LKM_RoleDTOBindingSource
        '
        Me.LKM_RoleDTOBindingSource.DataSource = GetType(SYS0500.SYS0501SvcRef.LKM_RoleDTO)
        '
        'SC_Save1
        '
        Me.SC_Save1.Image = CType(resources.GetObject("SC_Save1.Image"), System.Drawing.Image)
        Me.SC_Save1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_Save1.Location = New System.Drawing.Point(194, 10)
        Me.SC_Save1.Name = "SC_Save1"
        Me.SC_Save1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_Save1.Size = New System.Drawing.Size(61, 39)
        Me.SC_Save1.TabIndex = 54
        Me.SC_Save1.Text = "&Save"
        Me.SC_Save1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_Save1.UseVisualStyleBackColor = True
        '
        'SC_Conductor1
        '
        Me.SC_Conductor1.SC_BindingSource = Me.SYS0501DTO01BindingSource
        Me.SC_Conductor1.SC_ParentBindingSource = Me.SYS0501DTO02BindingSource
        Me.SC_Conductor1.SC_ParentKey = "User_ID"
        '
        'SC_Delete1
        '
        Me.SC_Delete1.Image = CType(resources.GetObject("SC_Delete1.Image"), System.Drawing.Image)
        Me.SC_Delete1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_Delete1.Location = New System.Drawing.Point(132, 10)
        Me.SC_Delete1.Name = "SC_Delete1"
        Me.SC_Delete1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_Delete1.Size = New System.Drawing.Size(61, 39)
        Me.SC_Delete1.TabIndex = 53
        Me.SC_Delete1.Text = "&Delete"
        Me.SC_Delete1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_Delete1.UseVisualStyleBackColor = True
        '
        'SC_Refresh1
        '
        Me.SC_Refresh1.Image = CType(resources.GetObject("SC_Refresh1.Image"), System.Drawing.Image)
        Me.SC_Refresh1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_Refresh1.Location = New System.Drawing.Point(8, 10)
        Me.SC_Refresh1.Name = "SC_Refresh1"
        Me.SC_Refresh1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_Refresh1.Size = New System.Drawing.Size(61, 39)
        Me.SC_Refresh1.TabIndex = 51
        Me.SC_Refresh1.Text = "&Refresh"
        Me.SC_Refresh1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_Refresh1.UseVisualStyleBackColor = True
        '
        'SC_Cancel1
        '
        Me.SC_Cancel1.Image = CType(resources.GetObject("SC_Cancel1.Image"), System.Drawing.Image)
        Me.SC_Cancel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SC_Cancel1.Location = New System.Drawing.Point(256, 10)
        Me.SC_Cancel1.Name = "SC_Cancel1"
        Me.SC_Cancel1.SC_ConductorSource = Me.SC_Conductor1
        Me.SC_Cancel1.Size = New System.Drawing.Size(61, 39)
        Me.SC_Cancel1.TabIndex = 50
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
        Me.SC_Add1.TabIndex = 49
        Me.SC_Add1.Text = "&Add"
        Me.SC_Add1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_Add1.UseVisualStyleBackColor = True
        '
        'SYS0501Frm
        '
        Me.ClientSize = New System.Drawing.Size(843, 478)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "SYS0501Frm"
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SYS0500DTO02BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        CType(Me.SYS0501DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYS0501DTO02BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabData.ResumeLayout(False)
        Me.TabData.PerformLayout()
        CType(Me.SYS0501DTO01BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LKM_RoleDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SC_ErrorProvider1 As SC_Win_FrontEnd.SC_ErrorProvider
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SC_Conductor1 As SC_Win_FrontEnd.SC_Conductor
    Friend WithEvents SC_Save1 As SC_Win_FrontEnd.SC_Save
    Friend WithEvents SC_Delete1 As SC_Win_FrontEnd.SC_Delete
    Friend WithEvents SC_Refresh1 As SC_Win_FrontEnd.SC_Refresh
    Friend WithEvents SC_Cancel1 As SC_Win_FrontEnd.SC_Cancel
    Friend WithEvents SC_Add1 As SC_Win_FrontEnd.SC_Add
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabList As System.Windows.Forms.TabPage
    Friend WithEvents TabData As System.Windows.Forms.TabPage
    Friend WithEvents SYS0501DTO02BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SYS0501DTO01BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents USER_IDSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents SYS0500DTO02BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SYS0501DTO02SC_DataGridView As SC_Win_FrontEnd.SC_DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ROLE_NAMESC_ComboBox As SC_Win_FrontEnd.SC_ComboBox
    Friend WithEvents LKM_RoleDTOBindingSource As System.Windows.Forms.BindingSource

End Class
