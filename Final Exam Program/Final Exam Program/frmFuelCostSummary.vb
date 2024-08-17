Public Class frmFuelCostSummary
    'Shiyu Chen
    '5/10/2023
    '5/12/2023
    Private Sub mnsExit_Click(sender As Object, e As EventArgs) Handles mnsExit.Click
        'Close the Form
        Me.Close()
    End Sub

    Private Sub mnsAbout_Click(sender As Object, e As EventArgs) Handles mnsAbout.Click
        'Deblare New Form
        Dim About As New frmAbout

        'Show Form
        About.ShowDialog()

        'Close Form
        About.Close()
    End Sub

End Class