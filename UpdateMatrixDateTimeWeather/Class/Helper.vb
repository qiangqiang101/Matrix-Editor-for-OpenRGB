Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text

Module Helper

    Public UserSettingFile As String = $"{My.Application.Info.DirectoryPath}\UserSettings.bin"
    Public UserSettings As UserSettingData = New UserSettingData(UserSettingFile).Instance
    Public OutputFile As String = $"{My.Application.Info.DirectoryPath}\output.txt"

    Public TextStylesList As List(Of TextStyles)
    Public openMeteo As OpenMeteo

    <Extension>
    Public Sub Striped(listview As ListView, Optional color1 As Color = Nothing, Optional color2 As Color = Nothing)
        If color2 = Nothing Then color2 = SystemColors.ButtonFace
        If color1 = Nothing Then color1 = SystemColors.Window

        Dim alternator As Integer = 0
        For Each lvi As ListViewItem In listview.Items
            If lvi.Group Is Nothing Then
                If alternator Mod 2 = 0 Then
                    For i As Integer = 0 To lvi.SubItems.Count - 1
                        If Not lvi.SubItems(i).BackColor = Color.LightSalmon Then lvi.SubItems(i).BackColor = color1
                    Next
                Else
                    For i As Integer = 0 To lvi.SubItems.Count - 1
                        If Not lvi.SubItems(i).BackColor = Color.LightSalmon Then lvi.SubItems(i).BackColor = color2
                    Next
                End If
                alternator += 1
            End If
        Next
        For Each gp As ListViewGroup In listview.Groups
            For Each lvi As ListViewItem In gp.Items
                If alternator Mod 2 = 0 Then
                    For i As Integer = 0 To lvi.SubItems.Count - 1
                        If Not lvi.SubItems(i).BackColor = Color.LightSalmon Then lvi.SubItems(i).BackColor = color1
                    Next
                Else
                    For i As Integer = 0 To lvi.SubItems.Count - 1
                        If Not lvi.SubItems(i).BackColor = Color.LightSalmon Then lvi.SubItems(i).BackColor = color2
                    Next
                End If
                alternator += 1
            Next
        Next
    End Sub

    <Extension>
    Public Function TextTypeString(tt As TextType) As String
        Select Case tt
            Case TextType.CustomText
                Return "Custom Text"
            Case TextType.Datetime
                Return "Date Time"
            Case TextType.Weather
                Return "Weather"
            Case TextType.Countdown
                Return "Countdown"
            Case Else
                Return "Unknown"
        End Select
    End Function

    Private xx As Encoding = Encoding.GetEncoding("GB2312")
    <Extension>
    Public Function IsWideEastAsianWidth(ByVal c As Char) As Boolean
        Dim byteCount As Integer = xx.GetByteCount(c.ToString())
        Return byteCount = 2
    End Function

    <Extension>
    Public Function LengthX(str As String) As Integer
        Dim textLength As Integer = 0
        For Each c As Char In str
            If c.IsWideEastAsianWidth Then textLength += 2 Else textLength += 1
        Next
        Return textLength
    End Function

    Public Sub ToggleWLED(ip As String, Optional timeout As Integer = 5000, Optional toggle As Integer = 2)
        Dim xml As String = ""

        Dim query As String = $"http://{ip}/win&T={toggle}"

        Try
            Dim req As HttpWebRequest = WebRequest.Create(query)
            With req
                .Timeout = timeout
                .Credentials = CredentialCache.DefaultCredentials
                .Accept = "*/*"
                .Method = "POST"
            End With
            Dim res As HttpWebResponse = req.GetResponse()
            Dim reader As New StreamReader(res.GetResponseStream)
            xml = reader.ReadToEnd
        Catch ex As Exception
            Logger.Log(ex)
            ToggleWLED(ip, timeout, toggle)
        End Try
    End Sub

    Public Sub TurnOnWLED(ip As String, Optional timeout As Integer = 5000)
        ToggleWLED(ip, timeout, 1)
    End Sub

    Public Sub TurnOffWLED(ip As String, Optional timeout As Integer = 5000)
        ToggleWLED(ip, timeout, 0)
    End Sub

End Module
