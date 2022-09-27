Imports System.ComponentModel

Public Class frmAddCountdown

    Public Property EditMode() As Boolean

    Private Sub frmAddCountdown_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not frmMain.Visible Then frmMain.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If EditMode Then
            Dim ts As New TextStyles()
            With ts
                .Interval = CInt(txtInterval.Text)
                .TextString = txtDateFormat.Text
                .TextType = TextType.Countdown
                .DateTime = dtpDate.Value
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
                .TextType = TextType.Countdown
                .DateTime = dtpDate.Value
            End With
            Dim newLVI As New ListViewItem({ts.TextType.TextTypeString, ts.TextString, ts.Interval}) With {.Tag = ts}
            frmMain.lvData.Items.Add(newLVI)
            With frmMain.lvData
                .Load()
                .Striped()
            End With
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

    Private Sub frmAddCountdown_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles Me.HelpButtonClicked
        MsgBox($"Day: <day>{vbNewLine}Hour: <hour>{vbNewLine}Minute: <minute>{vbNewLine}Second: <second>{vbNewLine}Millisecond: <millisecond>{vbNewLine}Tick: <tick>", MsgBoxStyle.Information, "Help")
    End Sub
End Class