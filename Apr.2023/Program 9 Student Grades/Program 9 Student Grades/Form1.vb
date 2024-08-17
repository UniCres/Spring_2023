Public Class Form1
    'Shiyu Chen
    '4/17/2023
    '4/19/2023
    Private Sub btnGPA_Click(sender As Object, e As EventArgs) Handles btnGPA.Click
        'Deblare New Form
        Dim GPA As New frmGPA

        'Show Form
        GPA.ShowDialog()

        'Close Form
        GPA.Close()
    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        'Declare variables
        Dim strInput As String
        Dim intPoints As Integer
        Dim intNumGrades As Integer
        Dim intTotalPoints As Integer

        'Start the Loop
        intNumGrades = 1

        Do
            'Prompt user to enter grades
            strInput = InputBox("Enter the Test Grade #" & intNumGrades & ControlChars.NewLine & "** Enter a -1 to Quit **", "Calculate Average")

            'Validate the input
            If IsNumeric(strInput) = True Then

                'Convert string to integer
                intPoints = CInt(strInput)

                'Keep a running total of points
                If intPoints <> -1 Then
                    intTotalPoints = intTotalPoints + intPoints
                    intNumGrades = intNumGrades + 1
                End If

            Else
                MsgBox("Please enter a number", MsgBoxStyle.Critical, "Enter a number")
            End If


        Loop While (intPoints <> -1)

        'Display average test grade in MessageBox
        MsgBox("The average test grade is: " & Format(intTotalPoints / (intNumGrades - 1), "0.00"), MsgBoxStyle.Information, "Average Grade")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome " & System.Environment.UserName & " !"
    End Sub
End Class
