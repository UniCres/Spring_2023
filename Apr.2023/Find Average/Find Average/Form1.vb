Public Class Form1
    'Shiyu Chen
    '4/13/2023
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        'Declare variables
        Dim strPoints As String
        Dim intPoints As Integer
        Dim intNumGrades As Integer
        Dim intTotalPoints As Integer

        'Start the Loop
        Do
            'Add 1 to the number of grades entered
            intNumGrades = intNumGrades + 1

            'Prompt user to enter grades
            strPoints = InputBox("Enter a grade" & ControlChars.NewLine & "** Type -1 to Quit **", "Test Grades")

            'Convert string to integer
            intPoints = CInt(strPoints)

            'Keep a running total of points
            If intPoints <> -1 Then
                intTotalPoints = intTotalPoints + intPoints
            End If

        Loop While (intPoints <> -1)

        'Display average test grade in MessageBox
        MsgBox("Your average test grade is: " & Format(intTotalPoints / (intNumGrades - 1), "0.00"), MsgBoxStyle.Information, "Average Grade")
    End Sub
End Class
