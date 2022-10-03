<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetting))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLongitude = New System.Windows.Forms.TextBox()
        Me.txtLatitude = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtMatrixWidth = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAuto = New System.Windows.Forms.CheckBox()
        Me.cbStartMini = New System.Windows.Forms.CheckBox()
        Me.txtIPAddresses = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbOffOnClose = New System.Windows.Forms.CheckBox()
        Me.cbOnOnStart = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 15)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Latitude/Longitude"
        '
        'txtLongitude
        '
        Me.txtLongitude.Location = New System.Drawing.Point(318, 12)
        Me.txtLongitude.Name = "txtLongitude"
        Me.txtLongitude.Size = New System.Drawing.Size(174, 23)
        Me.txtLongitude.TabIndex = 1
        Me.txtLongitude.Text = "101.74"
        '
        'txtLatitude
        '
        Me.txtLatitude.Location = New System.Drawing.Point(138, 12)
        Me.txtLatitude.Name = "txtLatitude"
        Me.txtLatitude.Size = New System.Drawing.Size(174, 23)
        Me.txtLatitude.TabIndex = 0
        Me.txtLatitude.Text = "3.12"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(417, 215)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtMatrixWidth
        '
        Me.txtMatrixWidth.Location = New System.Drawing.Point(138, 41)
        Me.txtMatrixWidth.Name = "txtMatrixWidth"
        Me.txtMatrixWidth.Size = New System.Drawing.Size(174, 23)
        Me.txtMatrixWidth.TabIndex = 2
        Me.txtMatrixWidth.Text = "100"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Matrix Width"
        '
        'cbAuto
        '
        Me.cbAuto.AutoSize = True
        Me.cbAuto.Location = New System.Drawing.Point(138, 70)
        Me.cbAuto.Name = "cbAuto"
        Me.cbAuto.Size = New System.Drawing.Size(128, 19)
        Me.cbAuto.TabIndex = 3
        Me.cbAuto.Text = "Start with Windows"
        Me.cbAuto.UseVisualStyleBackColor = True
        '
        'cbStartMini
        '
        Me.cbStartMini.AutoSize = True
        Me.cbStartMini.Location = New System.Drawing.Point(138, 95)
        Me.cbStartMini.Name = "cbStartMini"
        Me.cbStartMini.Size = New System.Drawing.Size(109, 19)
        Me.cbStartMini.TabIndex = 4
        Me.cbStartMini.Text = "Start Minimized"
        Me.cbStartMini.UseVisualStyleBackColor = True
        '
        'txtIPAddresses
        '
        Me.txtIPAddresses.Location = New System.Drawing.Point(138, 120)
        Me.txtIPAddresses.Name = "txtIPAddresses"
        Me.txtIPAddresses.Size = New System.Drawing.Size(354, 23)
        Me.txtIPAddresses.TabIndex = 5
        Me.txtIPAddresses.Text = "192.168.0.5,192.168.0.6"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Devices IP Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(135, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 15)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Separate with comma (,)"
        '
        'cbOffOnClose
        '
        Me.cbOffOnClose.AutoSize = True
        Me.cbOffOnClose.Location = New System.Drawing.Point(138, 189)
        Me.cbOffOnClose.Name = "cbOffOnClose"
        Me.cbOffOnClose.Size = New System.Drawing.Size(193, 19)
        Me.cbOffOnClose.TabIndex = 7
        Me.cbOffOnClose.Text = "Send Toggle Off signal on Close"
        Me.cbOffOnClose.UseVisualStyleBackColor = True
        '
        'cbOnOnStart
        '
        Me.cbOnOnStart.AutoSize = True
        Me.cbOnOnStart.Location = New System.Drawing.Point(138, 164)
        Me.cbOnOnStart.Name = "cbOnOnStart"
        Me.cbOnOnStart.Size = New System.Drawing.Size(187, 19)
        Me.cbOnOnStart.TabIndex = 6
        Me.cbOnOnStart.Text = "Send Toggle On signal on Start"
        Me.cbOnOnStart.UseVisualStyleBackColor = True
        '
        'frmSetting
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 250)
        Me.Controls.Add(Me.cbOffOnClose)
        Me.Controls.Add(Me.cbOnOnStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIPAddresses)
        Me.Controls.Add(Me.cbStartMini)
        Me.Controls.Add(Me.cbAuto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMatrixWidth)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLongitude)
        Me.Controls.Add(Me.txtLatitude)
        Me.Controls.Add(Me.btnSave)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtLongitude As TextBox
    Friend WithEvents txtLatitude As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtMatrixWidth As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbAuto As CheckBox
    Friend WithEvents cbStartMini As CheckBox
    Friend WithEvents txtIPAddresses As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbOffOnClose As CheckBox
    Friend WithEvents cbOnOnStart As CheckBox
End Class
