Public Class Form1
    'Shiyu Chen
    '4/11/2023
    Private Sub btnTry_Click(sender As Object, e As EventArgs) Handles btnTry.Click
        'Declare variables to hold output
        Dim strOutput As String

        'Print output in Textbox
        strOutput = "I hope"
        strOutput = strOutput & ControlChars.NewLine
        strOutput = strOutput & "This helps"
        txtOut.Text = strOutput
    End Sub
End Class
