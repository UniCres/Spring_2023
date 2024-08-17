Public Class Form1
    'Shiyu Chen
    '3/20/2023
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        'Determine passing stats
        Select Case nudYard.Value
            Case 0 To 199
                MsgBox("Bad Game!", MsgBoxStyle.Information, "Passing Stats")
                nudYard.Value = 0

            Case 200 To 399
                MsgBox("OK game!", MsgBoxStyle.Information, "Passing Stats")
                nudYard.Value = 0

            Case Is > 399
                MsgBox("Great game!", MsgBoxStyle.Information, "Passing Stats")
                nudYard.Value = 0
        End Select
    End Sub
End Class
