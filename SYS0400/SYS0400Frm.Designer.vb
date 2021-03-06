﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SYS0400Frm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SYS0400Frm))
        Me.SC_Conductor1 = New SC_Win_FrontEnd.SC_Conductor(Me.components)
        Me.SC_ErrorProvider1 = New SC_Win_FrontEnd.SC_ErrorProvider(Me.components)
        Me.SC_ExportCSV1 = New SC_Win_FrontEnd.SC_ExportCSV(Me.components)
        Me.SYS0400DTO02SC_DataGridView = New SC_Win_FrontEnd.SC_DataGridView()
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
        Me.TabData = New System.Windows.Forms.TabPage()
        Me.ROLE_NAMESC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.ROLE_IDSC_TextBox = New SC_Win_FrontEnd.SC_TextBox()
        Me.SYS0400DTO01BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SYS0400DTO02BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleAppSC_Detail = New SC_Win_FrontEnd.SC_Detail()
        ROLE_IDLabel = New System.Windows.Forms.Label()
        ROLE_NAMELabel = New System.Windows.Forms.Label()
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYS0400DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabList.SuspendLayout()
        Me.TabData.SuspendLayout()
        CType(Me.SYS0400DTO01BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SYS0400DTO02BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ROLE_IDLabel
        '
        ROLE_IDLabel.AutoSize = True
        ROLE_IDLabel.Location = New System.Drawing.Point(56, 9)
        ROLE_IDLabel.Name = "ROLE_IDLabel"
        ROLE_IDLabel.Size = New System.Drawing.Size(58, 13)
        ROLE_IDLabel.TabIndex = 0
        ROLE_IDLabel.Text = "* Role ID :"
        '
        'ROLE_NAMELabel
        '
        ROLE_NAMELabel.AutoSize = True
        ROLE_NAMELabel.Location = New System.Drawing.Point(46, 36)
        ROLE_NAMELabel.Name = "ROLE_NAMELabel"
        ROLE_NAMELabel.Size = New System.Drawing.Size(65, 13)
        ROLE_NAMELabel.TabIndex = 2
        ROLE_NAMELabel.Text = "Role Name :"
        '
        'SC_Conductor1
        '
        Me.SC_Conductor1.SC_BindingSource = Me.SYS0400DTO01BindingSource
        Me.SC_Conductor1.SC_ParentBindingSource = Me.SYS0400DTO02BindingSource
        Me.SC_Conductor1.SC_ParentKey = "ROLE_ID"
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
        Me.SC_ExportCSV1.SC_DataGridView = Me.SYS0400DTO02SC_DataGridView
        Me.SC_ExportCSV1.SC_DefaultFileName = "Master System Role"
        Me.SC_ExportCSV1.Size = New System.Drawing.Size(61, 39)
        Me.SC_ExportCSV1.TabIndex = 42
        Me.SC_ExportCSV1.Text = "E&xport"
        Me.SC_ExportCSV1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SC_ExportCSV1.UseVisualStyleBackColor = True
        '
        'SYS0400DTO02SC_DataGridView
        '
        Me.SYS0400DTO02SC_DataGridView.AllowUserToAddRows = False
        Me.SYS0400DTO02SC_DataGridView.AllowUserToDeleteRows = False
        Me.SYS0400DTO02SC_DataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYS0400DTO02SC_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.SYS0400DTO02SC_DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SYS0400DTO02SC_DataGridView.AutoGenerateColumns = False
        Me.SYS0400DTO02SC_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SYS0400DTO02SC_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.SYS0400DTO02SC_DataGridView.DataSource = Me.SYS0400DTO02BindingSource
        Me.SYS0400DTO02SC_DataGridView.Location = New System.Drawing.Point(6, 6)
        Me.SYS0400DTO02SC_DataGridView.Name = "SYS0400DTO02SC_DataGridView"
        Me.SYS0400DTO02SC_DataGridView.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYS0400DTO02SC_DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.SYS0400DTO02SC_DataGridView.SC_ConductorSource = Nothing
        Me.SYS0400DTO02SC_DataGridView.Size = New System.Drawing.Size(912, 355)
        Me.SYS0400DTO02SC_DataGridView.TabIndex = 0
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
        Me.VersionLabel.Location = New System.Drawing.Point(779, 9)
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
        Me.TabControl1.Size = New System.Drawing.Size(932, 431)
        Me.TabControl1.TabIndex = 44
        '
        'TabList
        '
        Me.TabList.Controls.Add(Me.SC_GridSearch1)
        Me.TabList.Controls.Add(Me.SYS0400DTO02SC_DataGridView)
        Me.TabList.Location = New System.Drawing.Point(4, 22)
        Me.TabList.Name = "TabList"
        Me.TabList.Padding = New System.Windows.Forms.Padding(3)
        Me.TabList.Size = New System.Drawing.Size(924, 405)
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
        Me.SC_GridSearch1.Location = New System.Drawing.Point(6, 367)
        Me.SC_GridSearch1.Name = "SC_GridSearch1"
        Me.SC_GridSearch1.SC_BindingSource = Me.SYS0400DTO02BindingSource
        Me.SC_GridSearch1.Size = New System.Drawing.Size(912, 32)
        Me.SC_GridSearch1.TabIndex = 2
        '
        'TabData
        '
        Me.TabData.Controls.Add(ROLE_NAMELabel)
        Me.TabData.Controls.Add(Me.ROLE_NAMESC_TextBox)
        Me.TabData.Controls.Add(ROLE_IDLabel)
        Me.TabData.Controls.Add(Me.ROLE_IDSC_TextBox)
        Me.TabData.Location = New System.Drawing.Point(4, 22)
        Me.TabData.Name = "TabData"
        Me.TabData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabData.Size = New System.Drawing.Size(924, 405)
        Me.TabData.TabIndex = 1
        Me.TabData.Text = "Data"
        Me.TabData.UseVisualStyleBackColor = True
        '
        'ROLE_NAMESC_TextBox
        '
        Me.ROLE_NAMESC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ROLE_NAMESC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SYS0400DTO01BindingSource, "ROLE_NAME", True))
        Me.ROLE_NAMESC_TextBox.Location = New System.Drawing.Point(120, 33)
        Me.ROLE_NAMESC_TextBox.Name = "ROLE_NAMESC_TextBox"
        Me.ROLE_NAMESC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.ROLE_NAMESC_TextBox.SC_EnableADD = True
        Me.ROLE_NAMESC_TextBox.SC_EnableEDIT = True
        Me.ROLE_NAMESC_TextBox.Size = New System.Drawing.Size(247, 21)
        Me.ROLE_NAMESC_TextBox.TabIndex = 3
        '
        'ROLE_IDSC_TextBox
        '
        Me.ROLE_IDSC_TextBox.BackColor = System.Drawing.Color.White
        Me.ROLE_IDSC_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ROLE_IDSC_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SYS0400DTO01BindingSource, "ROLE_ID", True))
        Me.ROLE_IDSC_TextBox.Location = New System.Drawing.Point(120, 6)
        Me.ROLE_IDSC_TextBox.Name = "ROLE_IDSC_TextBox"
        Me.ROLE_IDSC_TextBox.SC_ConductorSource = Me.SC_Conductor1
        Me.ROLE_IDSC_TextBox.SC_EnableADD = True
        Me.ROLE_IDSC_TextBox.Size = New System.Drawing.Size(100, 21)
        Me.ROLE_IDSC_TextBox.TabIndex = 1
        '
        'SYS0400DTO01BindingSource
        '
        Me.SYS0400DTO01BindingSource.DataSource = GetType(SYS0400.SYS0400SvcRef.SYS0400DTO01)
        '
        'SYS0400DTO02BindingSource
        '
        Me.SYS0400DTO02BindingSource.DataSource = GetType(SYS0400.SYS0400SvcRef.SYS0400DTO02)
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
        Me.DataGridViewTextBoxColumn4.Width = 150
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
        'RoleAppSC_Detail
        '
        Me.RoleAppSC_Detail.Image = CType(resources.GetObject("RoleAppSC_Detail.Image"), System.Drawing.Image)
        Me.RoleAppSC_Detail.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RoleAppSC_Detail.Location = New System.Drawing.Point(445, 12)
        Me.RoleAppSC_Detail.Name = "RoleAppSC_Detail"
        Me.RoleAppSC_Detail.SC_ConductorSource = Me.SC_Conductor1
        Me.RoleAppSC_Detail.Size = New System.Drawing.Size(61, 39)
        Me.RoleAppSC_Detail.TabIndex = 45
        Me.RoleAppSC_Detail.Text = "Role App"
        Me.RoleAppSC_Detail.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RoleAppSC_Detail.UseVisualStyleBackColor = True
        '
        'SYS0400Frm
        '
        Me.ClientSize = New System.Drawing.Size(956, 500)
        Me.Controls.Add(Me.RoleAppSC_Detail)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.SC_ExportCSV1)
        Me.Controls.Add(Me.SC_Save1)
        Me.Controls.Add(Me.SC_Delete1)
        Me.Controls.Add(Me.SC_Edit1)
        Me.Controls.Add(Me.SC_Refresh1)
        Me.Controls.Add(Me.SC_Cancel1)
        Me.Controls.Add(Me.SC_Add1)
        Me.Name = "SYS0400Frm"
        CType(Me.SC_Conductor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SC_ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYS0400DTO02SC_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabList.ResumeLayout(False)
        Me.TabData.ResumeLayout(False)
        Me.TabData.PerformLayout()
        CType(Me.SYS0400DTO01BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SYS0400DTO02BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SYS0400DTO02SC_DataGridView As SC_Win_FrontEnd.SC_DataGridView
    Friend WithEvents SYS0400DTO02BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ROLE_IDSC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents SYS0400DTO01BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SC_GridSearch1 As SC_Win_FrontEnd.SC_GridSearch
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ROLE_NAMESC_TextBox As SC_Win_FrontEnd.SC_TextBox
    Friend WithEvents RoleAppSC_Detail As SC_Win_FrontEnd.SC_Detail

End Class
