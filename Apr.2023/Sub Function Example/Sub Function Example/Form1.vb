Public Class Form1
    'Shiyu Chen
    '4/24/2023
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Call sub to prompt user for sides
        prompt_user()

        'Call function to calculate the area of the triangle
        Dim decArea As Decimal
        decArea = return_area()
        'Output the area in msgbox
        MsgBox("The area of your right triangle is: " & decArea, MsgBoxStyle.Information, "Area of Triangle")

        'Call sub to clear out the form
        clear_form()
    End Sub

    'Prompt user to enter values for sides (Base & Height)
    Private Sub prompt_user()
        'Add values to textboxes
        txtBase.Text = InputBox("Please enter the base of a triangle", "Enter the Base")
        txtHeight.Text = InputBox("Please enter the height of a triangle", "Enter the Height")
    End Sub

    'Calculate the area of the triangle
    Private Function return_area() As Decimal
        Dim decArea As Decimal
        decArea = txtBase.Text * txtHeight.Text / 2
        Return decArea
    End Function

    'Clear out the form
    Private Sub clear_form()
        txtBase.Clear()
        txtHeight.Clear()
    End Sub
End Class
