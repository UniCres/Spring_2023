Public Class Form1
    'Shiyu Chen
    '3/21/2023
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Trim textbox
        txtGrade.Text = Trim(txtGrade.Text)

        'Declare variable to hold string value from textbox
        Dim strGrade As String = txtGrade.Text

        'Force input to all CAPITALIZED
        strGrade = UCase(strGrade)

        'Call the validate function
        If Validate_Form() = True Then

            'Build Case Statement of label grade
            Select Case strGrade
                Case "A"
                    txtDes.Text = "Superior Achievement"
                Case "B"
                    txtDes.Text = "Work is above average"
                Case "C"
                    txtDes.Text = "Average Achievement"
                Case "D"
                    txtDes.Text = "Work is below Average"
                Case "E"
                    txtDes.Text = "Achievement is not acceptable"

                Case Else
                    MsgBox("You did not enter a valid grade", MsgBoxStyle.Critical, "Warning!")
                    txtGrade.Clear()
                    txtDes.Clear()
                    txtGrade.Focus()
            End Select
        End If
    End Sub

    Private Function Validate_Form() As Boolean
        'Trim textboxes
        txtGrade.Text = Trim(txtGrade.Text)

        If IsNumeric(txtGrade.Text) = True Then
            MsgBox("Enter a Grade, not a number", MsgBoxStyle.OkOnly, "Grade Descriptions")
            txtGrade.Clear()
            txtDes.Clear()
            txtGrade.Focus()
            Return False
        End If
        Return True
    End Function
End Class
