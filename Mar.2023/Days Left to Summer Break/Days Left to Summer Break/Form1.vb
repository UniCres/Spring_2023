Public Class Form1
    'Shiyu Chen
    '3/23/2023
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        'Calculate how many days are left
        Dim dateLastDayofSchool As Date = "6/3/2023"
        Dim intDaysLeft As Integer

        'Check to see if checkbox is checked
        If chbToday.Checked = True Then

            'Use today's date to calculate
            intDaysLeft = DateDiff(DateInterval.Day, Now, dateLastDayofSchool)

            'Print days left in message box
            MsgBox("We have " & intDaysLeft & " days left!", MsgBoxStyle.Information, "Days Left")
        Else
            'Use date from date time picker
            intDaysLeft = DateDiff(DateInterval.Day, dtpDate.Value, dateLastDayofSchool)
            MsgBox("We have " & intDaysLeft & " days left!", MsgBoxStyle.Information, "Days Left")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display welcome message
        MsgBox("Welcome to the Days Left to Summer Break Calculator" & ControlChars.NewLine & "Today is: " & Format(Now, "Short Date"), MsgBoxStyle.Information, "Days Left")
    End Sub

    Private Sub chbToday_CheckedChanged(sender As Object, e As EventArgs) Handles chbToday.CheckedChanged
        If chbToday.Checked = True Then
            dtpDate.Enabled = False
        Else
            dtpDate.Enabled = True
        End If
    End Sub
End Class
