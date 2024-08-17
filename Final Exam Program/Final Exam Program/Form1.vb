Public Class Form1
    'Shiyu Chen
    '5/10/2023
    '5/12/2023
    Private Sub btnYFC_Click(sender As Object, e As EventArgs) Handles btnYFC.Click
        'Deblare New Form
        Dim frmFuelCost As New frmFuelCost

        'Show Form
        frmFuelCost.ShowDialog()

        'Close Form
        frmFuelCost.Close()
    End Sub

    Private Sub btnTFE_Click(sender As Object, e As EventArgs) Handles btnTFE.Click
        'Deblare New Form
        Dim BestFuelEconomy As New frmBestFuelEconomy

        'Show Form
        BestFuelEconomy.ShowDialog()

        'Close Form
        BestFuelEconomy.Close()
    End Sub

    Private Sub mnsAbout_Click(sender As Object, e As EventArgs) Handles mnsAbout.Click
        'Deblare New Form
        Dim About As New frmAbout

        'Show Form
        About.ShowDialog()

        'Close Form
        About.Close()
    End Sub

    Private Sub mnsExit_Click(sender As Object, e As EventArgs) Handles mnsExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class
