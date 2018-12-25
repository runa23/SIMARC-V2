<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SCMenu
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim TreeListFormatRule1 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim TreeListFormatRule2 As DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule = New DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SCMenu))
        Me.colMenuType = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.colAppId = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colImageIndex = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.VersionLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ChangePasswordLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.DownloadBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colMenuType
        '
        Me.colMenuType.Caption = "colMenuType"
        Me.colMenuType.FieldName = "colMenuType"
        Me.colMenuType.Name = "colMenuType"
        '
        'colName
        '
        Me.colName.Caption = "colName"
        Me.colName.FieldName = "colName"
        Me.colName.MinWidth = 34
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 0
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 72)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.TreeList1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(845, 356)
        Me.SplitContainerControl1.SplitterPosition = 196
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colName, Me.colAppId, Me.colMenuType, Me.colImageIndex})
        Me.TreeList1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TreeList1.Dock = System.Windows.Forms.DockStyle.Fill
        TreeListFormatRule1.Column = Me.colMenuType
        TreeListFormatRule1.ColumnApplyTo = Me.colName
        TreeListFormatRule1.Name = "FormatModule"
        FormatConditionRuleValue1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleValue1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        FormatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        FormatConditionRuleValue1.Appearance.Options.UseFont = True
        FormatConditionRuleValue1.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.Value1 = "MODULE"
        FormatConditionRuleValue1.Value2 = "MODULE"
        TreeListFormatRule1.Rule = FormatConditionRuleValue1
        TreeListFormatRule2.Column = Me.colMenuType
        TreeListFormatRule2.ColumnApplyTo = Me.colName
        TreeListFormatRule2.Name = "Format Group"
        FormatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        FormatConditionRuleValue2.Appearance.Options.UseForeColor = True
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.Value1 = "GROUP"
        FormatConditionRuleValue2.Value2 = "GROUP"
        TreeListFormatRule2.Rule = FormatConditionRuleValue2
        Me.TreeList1.FormatRules.Add(TreeListFormatRule1)
        Me.TreeList1.FormatRules.Add(TreeListFormatRule2)
        Me.TreeList1.Location = New System.Drawing.Point(0, 0)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
        Me.TreeList1.OptionsBehavior.Editable = False
        Me.TreeList1.OptionsFilter.FilterMode = DevExpress.XtraTreeList.FilterMode.Extended
        Me.TreeList1.OptionsFind.AllowIncrementalSearch = True
        Me.TreeList1.OptionsFind.AlwaysVisible = True
        Me.TreeList1.OptionsFind.ExpandNodesOnIncrementalSearch = True
        Me.TreeList1.OptionsFind.FindNullPrompt = "Ketik untuk mencari aplikasi..."
        Me.TreeList1.OptionsFind.ShowClearButton = False
        Me.TreeList1.OptionsFind.ShowCloseButton = False
        Me.TreeList1.OptionsFind.ShowFindButton = False
        Me.TreeList1.OptionsView.ShowColumns = False
        Me.TreeList1.OptionsView.ShowHorzLines = False
        Me.TreeList1.OptionsView.ShowIndentAsRowStyle = True
        Me.TreeList1.OptionsView.ShowIndicator = False
        Me.TreeList1.OptionsView.ShowVertLines = False
        Me.TreeList1.Size = New System.Drawing.Size(196, 356)
        Me.TreeList1.TabIndex = 2
        '
        'colAppId
        '
        Me.colAppId.Caption = "colAppId"
        Me.colAppId.FieldName = "colAppId"
        Me.colAppId.Name = "colAppId"
        '
        'colImageIndex
        '
        Me.colImageIndex.Caption = "ImageIndex"
        Me.colImageIndex.FieldName = "ImageIndex"
        Me.colImageIndex.Name = "colImageIndex"
        '
        'TabControl1
        '
        Me.TabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageAndTabControlHeader
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(637, 356)
        Me.TabControl1.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.VersionLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(845, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(751, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Powered By SIMARC Dev Team"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VersionLabel
        '
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(48, 17)
        Me.VersionLabel.Text = "Version "
        '
        'ChangePasswordLinkLabel
        '
        Me.ChangePasswordLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChangePasswordLinkLabel.AutoSize = True
        Me.ChangePasswordLinkLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePasswordLinkLabel.Location = New System.Drawing.Point(727, 9)
        Me.ChangePasswordLinkLabel.Name = "ChangePasswordLinkLabel"
        Me.ChangePasswordLinkLabel.Size = New System.Drawing.Size(106, 13)
        Me.ChangePasswordLinkLabel.TabIndex = 19
        Me.ChangePasswordLinkLabel.TabStop = True
        Me.ChangePasswordLinkLabel.Text = "Change Password"
        '
        'UserLabel
        '
        Me.UserLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UserLabel.Location = New System.Drawing.Point(283, 7)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(438, 16)
        Me.UserLabel.TabIndex = 18
        Me.UserLabel.Text = "User Id :"
        Me.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = Global.SIMARC.My.Resources.Resources.Wall_s_logo
        Me.PictureEdit1.Location = New System.Drawing.Point(7, 6)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit1.Size = New System.Drawing.Size(86, 59)
        Me.PictureEdit1.TabIndex = 20
        '
        'DownloadBackgroundWorker
        '
        Me.DownloadBackgroundWorker.WorkerReportsProgress = True
        Me.DownloadBackgroundWorker.WorkerSupportsCancellation = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "S I M A R C"
        '
        'SCMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 453)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.ChangePasswordLinkLabel)
        Me.Controls.Add(Me.UserLabel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SCMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents colName As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colAppId As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colMenuType As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colImageIndex As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents ChangePasswordLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents UserLabel As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents VersionLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents DownloadBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
