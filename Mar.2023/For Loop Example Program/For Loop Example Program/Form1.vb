Public Class Form1
    'Shiyu Chen
    '3/30/2023
    Private Sub btnUp1_Click(sender As Object, e As EventArgs) Handles btnUp1.Click
        'Declare variable for the counter
        Dim i As Integer
        'Loop up by 1
        'Start the Loop
        For i = 20 To 25
            MsgBox(i, MsgBoxStyle.Information, "Looping Up")
        Next
        Me.Close()
    End Sub

    Private Sub btnDown1_Click(sender As Object, e As EventArgs) Handles btnDown1.Click
        'Declare variable to hold counter
        Dim i As Integer
        'Loop down by 1
        'Start the Loop
        For i = 10 To 0 Step -1
            MsgBox(i, MsgBoxStyle.Information, "Looping Down")
        Next
    End Sub

    Private Sub btnUp2_Click(sender As Object, e As EventArgs) Handles btnUp2.Click
        'Declare variable to hold counter
        Dim i As Integer
        'Loop up by 2
        'Start the Loop
        For i = 0 To 10 Step 2
            MsgBox(i, MsgBoxStyle.Information, "Looping Up by 2")
        Next
    End Sub
End Class
