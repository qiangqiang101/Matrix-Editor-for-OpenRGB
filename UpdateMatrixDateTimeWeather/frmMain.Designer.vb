<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.wTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeatherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lvData = New UpdateMatrixDateTimeWeather.ListViewX()
        Me.chType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chText = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDuration = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.niNotify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'wTimer
        '
        Me.wTimer.Interval = 1200000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(498, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextToolStripMenuItem, Me.DateTimeToolStripMenuItem, Me.WeatherToolStripMenuItem})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'TextToolStripMenuItem
        '
        Me.TextToolStripMenuItem.Name = "TextToolStripMenuItem"
        Me.TextToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.TextToolStripMenuItem.Text = "Text"
        '
        'DateTimeToolStripMenuItem
        '
        Me.DateTimeToolStripMenuItem.Name = "DateTimeToolStripMenuItem"
        Me.DateTimeToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.DateTimeToolStripMenuItem.Text = "Date Time"
        '
        'WeatherToolStripMenuItem
        '
        Me.WeatherToolStripMenuItem.Name = "WeatherToolStripMenuItem"
        Me.WeatherToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.WeatherToolStripMenuItem.Text = "Weather"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(52, 20)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'lvData
        '
        Me.lvData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chType, Me.chText, Me.chDuration})
        Me.lvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvData.FullRowSelect = True
        Me.lvData.GridLines = True
        Me.lvData.Location = New System.Drawing.Point(0, 24)
        Me.lvData.Name = "lvData"
        Me.lvData.Size = New System.Drawing.Size(498, 401)
        Me.lvData.SortColumn = 0
        Me.lvData.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.lvData.TabIndex = 19
        Me.lvData.UseCompatibleStateImageBehavior = False
        Me.lvData.View = System.Windows.Forms.View.Details
        '
        'chType
        '
        Me.chType.Text = "Type"
        Me.chType.Width = 100
        '
        'chText
        '
        Me.chText.Text = "Text"
        Me.chText.Width = 300
        '
        'chDuration
        '
        Me.chDuration.Tag = "Numeric"
        Me.chDuration.Text = "Duration"
        Me.chDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'niNotify
        '
        Me.niNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.niNotify.BalloonTipText = "Matrix Editor is still running on the background"
        Me.niNotify.BalloonTipTitle = "Matrix Editor"
        Me.niNotify.Icon = CType(resources.GetObject("niNotify.Icon"), System.Drawing.Icon)
        Me.niNotify.Text = "Matrix Editor"
        Me.niNotify.Visible = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 425)
        Me.Controls.Add(Me.lvData)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matrix Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents wTimer As Timer
    Friend WithEvents lvData As ListViewX
    Friend WithEvents chType As ColumnHeader
    Friend WithEvents chText As ColumnHeader
    Friend WithEvents chDuration As ColumnHeader
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WeatherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents niNotify As NotifyIcon
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
End Class
