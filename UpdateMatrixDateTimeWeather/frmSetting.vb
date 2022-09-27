Public Class frmSetting

    Dim hiddenAutoStart As Boolean = False

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtLatitude.Text = UserSettings.Latitude
        txtLongitude.Text = UserSettings.Longitude
        txtMatrixWidth.Text = UserSettings.MatrixWidth
        cbAuto.Checked = UserSettings.AutoStart
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim newUserSettings As New UserSettingData(UserSettingFile)
            With newUserSettings
                .Data = UserSettings.Data
                .Latitude = txtLatitude.Text
                .Longitude = txtLongitude.Text
                .MatrixWidth = txtMatrixWidth.Text
                .AutoStart = cbAuto.Checked

                .Save()
            End With
            UserSettings = New UserSettingData(UserSettingFile).Instance

            Helper.openMeteo = GetData(UserSettings.Latitude, UserSettings.Longitude)

            If hiddenAutoStart Then
                If cbAuto.Checked Then CreateShortcutInStartUp() Else DeleteShortcutInStartup()
            End If
        Catch ex As Exception
            Logger.Log(ex)
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Yikes!")
        End Try
    End Sub

    Private Sub CreateShortcutInStartUp()
        Try
            Dim regKey = My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regKey.SetValue(Application.ProductName, Application.ExecutablePath, Microsoft.Win32.RegistryValueKind.String)
            regKey.Flush()
            regKey.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DeleteShortcutInStartup()
        Try
            Dim regKey = My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regKey.DeleteValue(Application.ProductName)
            regKey.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbAuto_CheckedChanged(sender As Object, e As EventArgs) Handles cbAuto.CheckedChanged
        hiddenAutoStart = True
    End Sub
End Class