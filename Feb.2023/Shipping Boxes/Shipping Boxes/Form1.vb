Public Class Form1
    'Shiyu Chen
    '2/27/2023
    Private Sub mnsExit_Click(sender As Object, e As EventArgs) Handles mnsExit.Click
        Me.Close()
    End Sub

    Private Sub mnsAbout_Click(sender As Object, e As EventArgs) Handles mnsAbout.Click
        Dim About As New frmAbout

        About.ShowDialog()

        About.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intItems As Integer = nudItems.Value
        Dim intLarge As Integer
        Dim intMedium As Integer
        Dim intSmall As Integer
        Dim intIndividual As Integer

        intLarge = intItems \ 50
        intMedium = (intItems Mod 50) \ 30
        intSmall = ((intItems Mod 50) Mod 30) \ 10
        intIndividual = intItems Mod 10

        txtLarge.Text = intLarge
        txtMedium.Text = intMedium
        txtSmall.Text = intSmall
        txtIndividual.Text = intIndividual

        lblThanks.Visible = True
    End Sub
End Class
