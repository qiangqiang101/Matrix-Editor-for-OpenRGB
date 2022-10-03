Imports System.Globalization
Imports System.IO
Imports System.Text

Public Class frmMain

    Dim mode As Integer = 0
    Dim maxMode As Integer = 0
    Public pause As Boolean = False

    Public LastEditingItem As ListViewItem = Nothing

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Read from bin
        TextStylesList = UserSettings.Data

        If TextStylesList IsNot Nothing Then
            For Each ts As TextStyles In TextStylesList
                Dim item As New ListViewItem({ts.TextType.TextTypeString, ts.TextString, ts.Interval}) With {.Tag = ts}
                lvData.Items.Add(item)
            Next

            maxMode = TextStylesList.Count - 1

            Timer1.Interval = 5000
            Timer1.Start()
        Else
            Dim newUserSettings As New UserSettingData(UserSettingFile)
            With newUserSettings
                .Data = New List(Of TextStyles)
                .Latitude = "52.52"
                .Longitude = "13.41"
                .MatrixWidth = 28
                .SaveSilent()
            End With
            UserSettings = New UserSettingData(UserSettingFile).Instance

            TextStylesList = UserSettings.Data

            maxMode = TextStylesList.Count - 1

            Timer1.Interval = 5000
            Timer1.Start()
        End If

        lvData.Load()
        lvData.Striped()

        Helper.openMeteo = GetData(UserSettings.Latitude, UserSettings.Longitude)
        wTimer.Start()

        If UserSettings.StartMinimized Then Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lvData_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvData.MouseDoubleClick
        Dim item As ListViewItem = lvData.SelectedItems.Item(0)
        LastEditingItem = item
        Dim ts As TextStyles = item.Tag
        Select Case ts.TextType
            Case TextType.CustomText
                Dim newCT As New frmAddNormal
                With newCT
                    .Label5.Text = "Text"
                    .Text = "Edit Text"
                    .EditMode = True
                    .txtCustomText.Text = ts.TextString
                    .txtInterval.Text = ts.Interval
                End With
                newCT.Show()
            Case TextType.Datetime
                Dim newCT As New frmAddDatetime
                With newCT
                    .Text = "Edit Standard Date Time"
                    .Label3.Text = "Date Time format"
                    .EditMode = True
                    .DateTimeMode = True
                    .txtDateFormat.Text = ts.TextString
                    .txtInterval.Text = ts.Interval
                End With
                newCT.Show()
            Case TextType.Weather
                Dim newCT As New frmAddDatetime
                With newCT
                    .Text = "Edit Weather"
                    .Label3.Text = "Weather format"
                    .EditMode = True
                    .DateTimeMode = False
                    .txtDateFormat.Text = ts.TextString
                    .txtInterval.Text = ts.Interval
                End With
                newCT.Show()
            Case TextType.Countdown
                Dim newCT As New frmAddCountdown
                With newCT
                    .Text = "Edit Countdown"
                    .EditMode = True
                    .txtDateFormat.Text = ts.TextString
                    .dtpDate.Value = ts.DateTime
                    .txtInterval.Text = ts.Interval
                End With
                newCT.Show()
        End Select
        Me.Hide()
        pause = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not pause Then
            mode += 1
            If mode > maxMode Then mode = 0

            If lvData.Items.Count > 0 Then
                Dim nextTS As TextStyles = lvData.Items(mode).Tag
                Select Case nextTS.TextType
                    Case TextType.CustomText
                        SaveFile(nextTS.TextString)
                    Case TextType.Datetime
                        SaveFile(Now.ToString(nextTS.TextString))
                    Case TextType.Weather
                        Dim stringBuilder As String = nextTS.TextString.Replace("<temp>", $"{Helper.openMeteo.Temperature}°C").Replace("<weather>", Helper.openMeteo.WeatherName).
                            Replace("<code>", Helper.openMeteo.WeatherCode).Replace("<speed>", $"{Helper.openMeteo.WindSpeed}Km/h").Replace("<direction>", $"{Helper.openMeteo.WindDirection}°")

                        SaveFile(stringBuilder)
                    Case TextType.Countdown
                        Dim timeSpan As TimeSpan = (nextTS.DateTime - Now)
                        Dim stringBuilder As String = nextTS.TextString.Replace("<day>", timeSpan.Days).Replace("<hour>", timeSpan.Hours).Replace("<minute>", timeSpan.Minutes).
                            Replace("<second>", timeSpan.Seconds).Replace("<millisecond>", timeSpan.Milliseconds).Replace("<tick>", timeSpan.Ticks)
                        SaveFile(stringBuilder)
                End Select
                Timer1.Interval = nextTS.Interval
            End If
        End If
    End Sub

    Private Sub SaveFile(text As String)
        Try
            Using fs As FileStream = File.Create(OutputFile)
                Using sr As New StreamWriter(fs, Encoding.UTF8) 'Encoding.GetEncoding("Windows-1252"))
                    sr.WriteLine($"{text.PadLeft((UserSettings.MatrixWidth / 2) + (text.Length / 2))}")
                End Using
            End Using
        Catch ex As Exception
            Threading.Thread.Sleep(500)
            SaveFile(text)
        End Try
    End Sub

    Private Sub wTimer_Tick(sender As Object, e As EventArgs) Handles wTimer.Tick
        Helper.openMeteo = GetData(UserSettings.Latitude, UserSettings.Longitude)
    End Sub

    Private Sub TextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextToolStripMenuItem.Click
        Dim newCT As New frmAddNormal
        With newCT
            .Label5.Text = "Text"
            .Text = "Add Text"
            .EditMode = False
            .txtCustomText.Text = Nothing
            .txtInterval.Text = 5000
        End With
        newCT.Show()
        Hide()
        pause = True
    End Sub

    Private Sub WeatherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeatherToolStripMenuItem.Click
        Dim newCT As New frmAddDatetime
        With newCT
            .Text = "Add Weather"
            .Label3.Text = "Weather format"
            .EditMode = False
            .DateTimeMode = False
            .txtDateFormat.Text = "<temp> <weather>"
            .txtInterval.Text = 5000
        End With
        newCT.Show()
        Hide()
        pause = True
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Dim item As ListViewItem = lvData.SelectedItems.Item(0)
        LastEditingItem = item
        Dim ts As TextStyles = item.Tag
        Select Case ts.TextType
            Case TextType.CustomText
                Dim newCT As New frmAddNormal
                With newCT
                    .Label5.Text = "Text"
                    .Text = "Edit Text"
                    .EditMode = True
                    .txtCustomText.Text = ts.TextString
                    .txtInterval.Text = ts.Interval
                End With
                newCT.Show()
            Case TextType.Datetime
                Dim newCT As New frmAddDatetime
                With newCT
                    .Text = "Edit Standard Date Time"
                    .Label3.Text = "Date Time format"
                    .EditMode = True
                    .DateTimeMode = True
                    .txtDateFormat.Text = ts.TextString
                    .txtInterval.Text = ts.Interval
                End With
                newCT.Show()
            Case TextType.Weather
                Dim newCT As New frmAddDatetime
                With newCT
                    .Text = "Edit Weather"
                    .Label3.Text = "Weather format"
                    .EditMode = True
                    .DateTimeMode = False
                    .txtDateFormat.Text = ts.TextString
                    .txtInterval.Text = ts.Interval
                End With
                newCT.Show()
            Case TextType.Countdown
                Dim newCT As New frmAddCountdown
                With newCT
                    .Text = "Edit Countdown"
                    .EditMode = True
                    .txtDateFormat.Text = ts.TextString
                    .dtpDate.Value = ts.DateTime
                    .txtInterval.Text = ts.Interval
                End With
                newCT.Show()
        End Select
        Me.Hide()
        pause = True
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        If lvData.SelectedItems.Count <> 0 Then
            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then lvData.Items.Remove(lvData.SelectedItems.Item(0))
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            Dim newListOfData As New List(Of TextStyles)
            For Each item As ListViewItem In lvData.Items
                newListOfData.Add(item.Tag)
            Next

            Dim newUserSettings As New UserSettingData(UserSettingFile)
            With newUserSettings
                .Data = newListOfData
                .Latitude = UserSettings.Latitude
                .Longitude = UserSettings.Longitude
                .MatrixWidth = UserSettings.MatrixWidth
                .AutoStart = UserSettings.AutoStart
                .Save()
            End With
            UserSettings = New UserSettingData(UserSettingFile).Instance
            TextStylesList = newListOfData

            maxMode = TextStylesList.Count - 1
        Catch ex As Exception
            Logger.Log(ex)
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Yikes!")
        End Try
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If WindowState = FormWindowState.Minimized Then
            niNotify.Visible = True
            Me.Hide()
            niNotify.ShowBalloonTip(500)
        End If
    End Sub

    Private Sub niNotify_Click(sender As Object, e As EventArgs) Handles niNotify.Click
        Show()
        ShowInTaskbar = True
        WindowState = FormWindowState.Normal
        niNotify.Visible = False
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        frmSetting.Show()
    End Sub

    Private Sub CountdownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountdownToolStripMenuItem.Click
        Dim newCT As New frmAddCountdown
        With newCT
            .Text = "Add Countdown"
            .EditMode = False
            .txtDateFormat.Text = "dd HH:mm:ss"
            .txtInterval.Text = 5000
            .dtpDate.Value = Now
            .dtpDate.MinDate = Now
        End With
        newCT.Show()
        Hide()
        pause = True
    End Sub

    Private Sub DateTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateTimeToolStripMenuItem.Click
        Dim newCT As New frmAddDatetime
        With newCT
            .Text = "Add Standard Date Time"
            .Label3.Text = "Date Time format"
            .EditMode = False
            .DateTimeMode = True
            .txtDateFormat.Text = "hh:mmtt dddd, dd MMM"
            .txtInterval.Text = 5000
        End With
        newCT.Show()
        Hide()
        pause = True
    End Sub

    Private Sub ToggleWLEDOnOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToggleWLEDOnOffToolStripMenuItem.Click
        Try
            For Each device In UserSettings.IPAddresses.Split(","c)
                ToggleWLED(device)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
