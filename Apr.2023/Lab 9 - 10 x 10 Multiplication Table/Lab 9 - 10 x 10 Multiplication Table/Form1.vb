Public Class Form1
    'Shiyu Chen
    '4/10/2023
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'Clear the multiplication table
        txtTable.Clear()

        'Declare Variables
        Dim i As Integer
        Dim j As Integer

        'Start the outer loop
        For i = 1 To 10

            'Start the inner loop
            For j = 1 To 10

                'Print the table
                txtTable.Text = txtTable.Text & i * j & ControlChars.Tab
            Next
            txtTable.Text = txtTable.Text & ControlChars.NewLine
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Welcome User
        MsgBox("Welcome " & System.Environment.UserName & ControlChars.NewLine & "I hope you enjoy this crazy program!", MsgBoxStyle.OkOnly, "Welcome!")
    End Sub
End Class
