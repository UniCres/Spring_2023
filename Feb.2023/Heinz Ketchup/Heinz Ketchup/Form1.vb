Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decCost As Decimal
        Dim decDiscount As Decimal
        Dim decPrice As Decimal

        decCost = nudCost.Value
        decDiscount = nudDiscount.Value / 100

        decPrice = decCost - (decCost * decDiscount)

        lblPrice.Text = Format(decPrice, "currency")
    End Sub
End Class
