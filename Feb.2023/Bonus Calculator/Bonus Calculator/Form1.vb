Public Class Form1
    'Shiyu Chen
    '2/13/2023
    '2/14/2023
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'Close Form
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare Variables
        Dim decSales As Decimal
        Dim decRate As Decimal
        Dim decBonus As Decimal

        'Give Variables Value
        decSales = txtSales.Text
        decRate = txtRate.Text

        'Calculate The Bonus Amount
        decBonus = decSales * decRate

        'Print Answer In The Bonus Amount Textbox
        txtBonus.Text = Format(decBonus, "currency")
    End Sub
End Class
