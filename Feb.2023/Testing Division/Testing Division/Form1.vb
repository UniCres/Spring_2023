Public Class Form1
    'Shiyu Chen
    '2/24/2023
    Private Sub btnRegular_Click(sender As Object, e As EventArgs) Handles btnRegular.Click
        'Using regular division
        lblRegular.Text = 20 / 3
    End Sub

    Private Sub btnInteger_Click(sender As Object, e As EventArgs) Handles btnInteger.Click
        'Using integer division
        lblInteger.Text = 20 \ 3
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        'Using MOD
        lblMod.Text = 20 Mod 3
    End Sub
End Class
