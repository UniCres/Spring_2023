Public Class Form1
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        'Declare variables and give values
        Dim strOrder As String = txtOrder.Text
        Dim strSide As String = txtSide.Text
        Dim strDrink As String = txtDrink.Text

        'Call the sub
        Change_Order(strOrder, strSide, strDrink)

        'Print order in Messagebox
        MsgBox(strOrder & " " & strSide & " " & strDrink, MsgBoxStyle.Information, "New Order")
    End Sub

    Private Sub Change_Order(ByRef Order As String, ByRef Side As String, ByRef Drink As String)
        Order = "Pancakes"
        Side = "Bacon"
        Drink = "Coffee"
    End Sub
End Class
