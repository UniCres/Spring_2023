Public Class Form1
    'Shiyu Chen
    '3/30/2023
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Declare variables for the counters
        Dim i As Integer
        Dim j As Integer
        'Start the outer loop
        For i = nudOStart.Value To nudOStop.Value
            'Print out the value of the outer loop
            MsgBox(i, MsgBoxStyle.Information, "Outer Loop")
            'Start the inner loop
            For j = nudIStart.Value To nudIStop.Value
                'Print out the value of the inner loop
                MsgBox(j, MsgBoxStyle.Information, "Inner Loop")
            Next
        Next
    End Sub
End Class
