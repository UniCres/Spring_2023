Public Class Form1
    'Shiyu Chen
    '2/14/2023
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the Form
        Me.Close()
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        'Declare Variables
        Dim decSales As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal

        'Give Variables Value
        decSales = txtSales.Text

        'Calculate Tax and Total
        decTax = decSales * 0.06
        decTotal = decSales + decTax

        'Print Answer in Textboxes
        txtTax.Text = Format(decTax, "currency")
        txtTotal.Text = Format(decTotal, "currency")
        txtSales.Text = Format(decSales, "currency")
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        'Declare Variables
        Dim decSales As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal

        'Give Variables Value
        decSales = txtSales.Text

        'Calculate Tax and Total
        decTax = decSales * 0.07
        decTotal = decSales + decTax

        'Print Answer in Textboxes
        txtTax.Text = Format(decTax, "currency")
        txtTotal.Text = Format(decTotal, "currency")
        txtSales.Text = Format(decSales, "currency")
    End Sub
End Class
