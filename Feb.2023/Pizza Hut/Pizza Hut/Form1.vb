Public Class Form1
    'Shiyu Chen
    '2/9/2023-2/10/2023
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Step 1
        Dim decTotal As Decimal

        'Step 2 & Step 3
        decTotal = CDec(txtPizza.Text) + CDec(txtWings.Text) + CDec(txtBread.Text)

        'Step 4
        txtCost.Text = Format(decTotal, "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBread.Text = ""
        txtWings.Text = ""
        txtPizza.Text = ""
        txtCost.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strWelcome As String
        strWelcome = "Hello, and welcome to our Pizza Hut Program"
        MsgBox(strWelcome)
    End Sub
End Class
