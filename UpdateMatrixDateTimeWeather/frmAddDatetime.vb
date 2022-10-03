Imports System.ComponentModel

Public Class frmAddDatetime

    Public Property EditMode() As Boolean
    Public Property DateTimeMode() As Boolean

    Private Sub frmAddDatetime_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not frmMain.Visible Then
            frmMain.Show()
            frmMain.pause = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If EditMode Then
            If DateTimeMode Then
                Dim ts As New TextStyles()
                With ts
                    .Interval = CInt(txtInterval.Text)
                    .TextString = txtDateFormat.Text
                    .TextType = TextType.Datetime
                End With
                With frmMain.LastEditingItem
                    .SubItems(0).Text = ts.TextType.TextTypeString
                    .SubItems(1).Text = ts.TextString
                    .SubItems(2).Text = ts.Interval
                    .Tag = ts
                End With
                With frmMain.lvData
                    .Load()
                    .Striped()
                End With
            Else
                Dim ts As New TextStyles()
                With ts
                    .Interval = CInt(txtInterval.Text)
                    .TextString = txtDateFormat.Text
                    .TextType = TextType.Weather
                End With
                With frmMain.LastEditingItem
                    .SubItems(0).Text = ts.TextType.TextTypeString
                    .SubItems(1).Text = ts.TextString
                    .SubItems(2).Text = ts.Interval
                    .Tag = ts
                End With
                With frmMain.lvData
                    .Load()
                    .Striped()
                End With
            End If
        Else
            If DateTimeMode Then
                Dim ts As New TextStyles()
                With ts
                    .Interval = CInt(txtInterval.Text)
                    .TextString = txtDateFormat.Text
                    .TextType = TextType.Datetime
                End With
                Dim newLVI As New ListViewItem({ts.TextType.TextTypeString, ts.TextString, ts.Interval}) With {.Tag = ts}
                frmMain.lvData.Items.Add(newLVI)
                With frmMain.lvData
                    .Load()
                    .Striped()
                End With
            Else
                Dim ts As New TextStyles()
                With ts
                    .Interval = CInt(txtInterval.Text)
                    .TextString = txtDateFormat.Text
                    .TextType = TextType.Weather
                End With
                Dim newLVI As New ListViewItem({ts.TextType.TextTypeString, ts.TextString, ts.Interval}) With {.Tag = ts}
                frmMain.lvData.Items.Add(newLVI)
                With frmMain.lvData
                    .Load()
                    .Striped()
                End With
            End If
        End If
        Close()
    End Sub

    Private Sub txtInterval_TextChanged(sender As Object, e As EventArgs) Handles txtInterval.TextChanged
        If IsNumeric(txtInterval.Text) Then
            Dim int As Integer = CInt(txtInterval.Text)
            If int <= 1000 Then int = 1000
        Else
            txtInterval.Text = 5000
        End If
    End Sub

    Private Sub frmAddDatetime_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles Me.HelpButtonClicked
        If DateTimeMode Then
            Dim dtm As String = "d -> Represents the day of the month as a number from 1 through 31.
dd -> Represents the day of the month as a number from 01 through 31.
ddd-> Represents the abbreviated name of the day (Mon, Tues, Wed, etc).
dddd-> Represents the full name of the day (Monday, Tuesday, etc).
h-> 12-hour clock hour (e.g. 4).
hh-> 12-hour clock, with a leading 0 (e.g. 06)
H-> 24-hour clock hour (e.g. 15)
HH-> 24-hour clock hour, with a leading 0 (e.g. 22)
m-> Minutes
mm-> Minutes with a leading zero
M-> Month number(eg.3)
MM-> Month number with leading zero(eg.04)
MMM-> Abbreviated Month Name (e.g. Dec)
MMMM-> Full month name (e.g. December)
s-> Seconds
ss-> Seconds with leading zero
t-> Abbreviated AM / PM (e.g. A or P)
tt-> AM / PM (e.g. AM or PM
y-> Year, no leading zero (e.g. 2015 would be 15)
yy-> Year, leading zero (e.g. 2015 would be 015)
yyy-> Year, (e.g. 2015)
yyyy-> Year, (e.g. 2015)
K-> Represents the time zone information of a date and time value (e.g. +05:00)
z-> With DateTime values represents the signed offset of the local operating system's time zone from
Coordinated Universal Time (UTC), measured in hours. (e.g. +6)
zz-> As z, but with leading zero (e.g. +06)
zzz-> With DateTime values represents the signed offset of the local operating system's time zone from UTC, measured in hours and minutes. (e.g. +06:00)
f-> Represents the most significant digit of the seconds' fraction; that is, it represents the tenths of a second in a date and time value.
ff-> Represents the two most significant digits of the seconds' fraction in date and time
fff-> Represents the three most significant digits of the seconds' fraction; that is, it represents the milliseconds in a date and time value.
ffff-> Represents the four most significant digits of the seconds' fraction; that is, it represents the ten-thousandths of a second in a date and time value. While it is possible to display the ten-thousandths of a second component of a time value, that value may not be meaningful.
fffff-> Represents the five most significant digits of the seconds' fraction; that is, it represents the hundred-thousandths of a second in a date and time value.
ffffff-> Represents the six most significant digits of the seconds' fraction; that is, it represents the millionths of a second in a date and time value.
fffffff-> Represents the seven most significant digits of the second's fraction; that is, it represents the ten-millionths of a second in a date and time value."
            MsgBox(dtm, MsgBoxStyle.Information, "Help")
        Else
            MsgBox($"Temperature: <temp>{vbNewLine}Weather: <weather>{vbNewLine}Weather Code: <code>{vbNewLine}Wind Speed: <speed>{vbNewLine}Wind Direction: <direction>", MsgBoxStyle.Information, "Help")
        End If

    End Sub
End Class