Public Class frmGPA
    'Shiyu Chen
    '4/17/2023
    '4/20/2023
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Make sure the user entered numbers
        If IsNumeric(mtbA.Text) = False Or IsNumeric(mtbB.Text) = False Or IsNumeric(mtbC.Text) = False Or IsNumeric(mtbD.Text) = False Or IsNumeric(mtbF.Text) = False Then

            MsgBox("Please enter a number", MsgBoxStyle.Critical, "Enter a number")

        Else
            'Declare variables and calculate the GPA
            Dim intTotal As Integer = (mtbA.Text * 4 + mtbB.Text * 3 + mtbC.Text * 2 + mtbD.Text * 1 + mtbF.Text * 0)
            Dim intTerm As Integer = CInt(mtbA.Text) + CInt(mtbB.Text) + CInt(mtbC.Text) + CInt(mtbD.Text) + CInt(mtbF.Text)

            'Validate the denominator for non-0 number
            If intTerm = 0 Then
                MsgBox("Please at least enter 1 grade", MsgBoxStyle.Critical, "Enter a grade")
                mtbA.Focus()
            Else
                Dim decGPA As Decimal = intTotal / intTerm

                'Print the GPA out
                MsgBox("Your GPA is: " & Format(decGPA, "0.0"), MsgBoxStyle.OkOnly, "Grade Point Average")

            End If
        End If
    End Sub
End Class