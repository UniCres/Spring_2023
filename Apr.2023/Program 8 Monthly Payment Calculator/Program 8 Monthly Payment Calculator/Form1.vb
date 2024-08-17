Public Class Form1
    'Shiyu Chen
    '4/14/2023
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Call the validate function
        If Validate_Form() = True Then

            'Clear the Textbox
            txtMP.Clear()

            'Declare variables
            Dim i As Integer
            Dim j As Integer
            Dim decMP As Decimal

            'Print column headers
            txtMP.Text = ControlChars.Tab & "3 years" & ControlChars.Tab & "4 years" & ControlChars.Tab & "5 years" & ControlChars.Tab & "6 years" & ControlChars.NewLine

            'Start the outer loop
            For i = 5 To 10

                'Print the interest rate before each inner loop start
                txtMP.Text = txtMP.Text & Format(i * 0.01, "percent")

                'Start the inner loop
                For j = 3 To 6

                    'Calculate the monthly payment
                    decMP = -1 * Pmt(i * 0.01 / 12, j * 12, txtP.Text)

                    'Print answer in the Textbox
                    txtMP.Text = txtMP.Text & ControlChars.Tab & Format(decMP, "currency")

                Next
                'Change to a newline after each inner loop
                txtMP.Text = txtMP.Text & ControlChars.NewLine
            Next
        End If
    End Sub
    Private Function Validate_Form() As Boolean
        'Trim textboxes
        txtP.Text = Trim(txtP.Text)

        'Validate for positive amount and term of loan
        If IsNumeric(txtP.Text) = False Then
            MsgBox("Please enter a number for Amount of principal!", MsgBoxStyle.Critical, "Please Enter a Number")
            txtP.Clear()
            txtP.Focus()
            Return False

        ElseIf txtP.Text <= 0 Then
            MsgBox("Please enter a positive number for Amount of principal!", MsgBoxStyle.Critical, "Please Enter a Positive Number")
            txtP.Clear()
            txtP.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub mnsExit_Click(sender As Object, e As EventArgs) Handles mnsExit.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub mnsAbout_Click(sender As Object, e As EventArgs) Handles mnsAbout.Click
        'Deblare New Form
        Dim About As New frmAbout

        'Show Form
        About.ShowDialog()

        'Close Form
        About.Close()
    End Sub
End Class
