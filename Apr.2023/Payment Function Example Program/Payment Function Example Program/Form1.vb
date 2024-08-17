Public Class Form1
    'Shiyu Chen
    '4/12/2023
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Call the validate function
        If Validate_Form() = True Then

            'Declare variable to hold monthly payment
            Dim decMonthlyPayment As Decimal

            'Calculate monthly payment
            decMonthlyPayment = -1 * Pmt((nudInterest.Value * 0.01) / 12, nudTerm.Value * 12, txtLoan.Text)

            'Display monthly payment in message box
            MsgBox("Your monthly payment will be: " & Format(decMonthlyPayment, "currency"), MsgBoxStyle.Information, "Monthly Payment")
        End If
    End Sub
    Private Function Validate_Form() As Boolean
        'Trim textboxes
        txtLoan.Text = Trim(txtLoan.Text)

        'Validate for positive amount and term of loan
        If IsNumeric(txtLoan.Text) = False Then
            MsgBox("Please enter a number for Amount of Loan!", MsgBoxStyle.Critical, "Please Enter a Number")
            txtLoan.Clear()
            nudInterest.Value = 0
            nudTerm.Value = 0
            Return False

        ElseIf txtLoan.Text <= 0 Then
            MsgBox("Please enter a positive number for Amount of Loan!", MsgBoxStyle.Critical, "Please Enter a Positive Number")
            txtLoan.Clear()
            nudInterest.Value = 0
            nudTerm.Value = 0
            Return False

        ElseIf nudTerm.Value = 0 Then
            MsgBox("Please enter a positive number for Term of Loan!", MsgBoxStyle.Critical, "Please Enter a Positive Number")
            txtLoan.Clear()
            nudInterest.Value = 0
            nudTerm.Value = 0
            Return False
        End If
        Return True
    End Function
End Class
