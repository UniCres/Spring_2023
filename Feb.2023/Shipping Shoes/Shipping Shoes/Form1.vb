Public Class Form1
    'Shiyu Chen
    '2/24/2023
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtShoes.Clear()
        lblCrates.Text = "Crates"
        lblBoxes.Text = "Boxes"
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare variables
        Dim intPairsofShoes As Integer = txtShoes.Text
        Dim intCrates As Integer

        'Calculate crates and boxes needed
        intCrates = intPairsofShoes \ 100

        'Declare variable to hold the remainder
        Dim intRemainder As Integer = intPairsofShoes Mod 100

        'Print values in labels
        lblCrates.Text = intCrates
        lblBoxes.Text = intRemainder
    End Sub
End Class
