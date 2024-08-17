Public Class Form1
    'Shiyu Chen
    '4/13/2023
    Private Sub btnHighest_Click(sender As Object, e As EventArgs) Handles btnHighest.Click
        'Declare variables
        Dim strInput As String
        Dim intHighNumber As Integer

        'Start the Do While Loop
        Do
            'Grab a number from the user
            strInput = InputBox("Enter a test score" & ControlChars.NewLine & "** Type -1 to Quit **")


            'Convert string to integer
            If strInput <> "" Then
                If CInt(strInput > intHighNumber) Then

                    'Replace it
                    intHighNumber = CInt(strInput)
                End If
            End If
            'Keep Looping until user puts -1
        Loop While (strInput <> -1)

        'Print in MessageBox
        MsgBox("The Highest Number Entered Was: " & intHighNumber, MsgBoxStyle.Information, "Highest Number")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Welcome the user
        MsgBox("Welcome " & System.Environment.UserName, MsgBoxStyle.OkOnly, "Welcome!")
    End Sub
End Class
