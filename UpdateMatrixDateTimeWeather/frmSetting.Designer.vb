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
        Me.btnSave.Location = New System.Drawing.Point(417, 96)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
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
        'frmSetting
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 131)
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
End Class
