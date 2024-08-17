Public Class Form1
    'Shiyu Chen
    '4/25/2023
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        'Declare variable to hold value from function
        'Also, pass values from textboxes down to function
        If Validate_Numeric() = True Then
            Dim decArea As Decimal = Return_Area(txtLength.Text, txtWidth.Text)

            'Print areea in Messagebox
            MsgBox("The area of your room is: " & decArea & " square units", MsgBoxStyle.Information, "Area of Room")

            'Clear Textboxes and set focus back to length textbox
            Clear_Form()
        End If
    End Sub

    'Create private function to calculate area
    Private Function Return_Area(ByVal Length As Decimal, ByVal Width As Decimal) As Decimal
        'Declare variable to hold area
        Dim decArea As Decimal = Length * Width

        'Return area of room
        Return decArea
    End Function

    'Create private sub to validate
    Private Function Validate_Numeric() As Boolean
        If IsNumeric(txtLength.Text) = False Or IsNumeric(txtWidth.Text) = False Then
            MsgBox("Please enter a number!", MsgBoxStyle.Critical, "Please Enter A Number!")
            Clear_Form()
            Return False
        ElseIf txtLength.Text <= 0 Or txtWidth.Text <= 0 Then
            MsgBox("Please enter a positive number!", MsgBoxStyle.Critical, "Please Enter A Positive Number!")
            Clear_Form()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Clear_Form()
        txtLength.Clear()
        txtWidth.Clear()
        txtLength.Focus()
    End Sub
End Class
