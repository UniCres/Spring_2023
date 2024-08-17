Public Class frmBestFuelEconomy
    'Shiyu Chen
    '5/10/2023
    '5/12/2023
    Private Sub mnsExit_Click(sender As Object, e As EventArgs) Handles mnsExit.Click
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

    Private Sub cmbVehicle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVehicle.SelectedIndexChanged

        If cmbVehicle.SelectedItem = "Mitsubishi Mirage" Then
            lblCMPG.Text = "36"
            lblHMPG.Text = "43"
            lblCost.Text = "$34.00"
        ElseIf cmbVehicle.SelectedItem = "Hyundai Elantra" Then
            lblCMPG.Text = "33"
            lblHMPG.Text = "43"
            lblCost.Text = "$45.00"
        ElseIf cmbVehicle.SelectedItem = "Honda Civic" Then
            lblCMPG.Text = "33"
            lblHMPG.Text = "42"
            lblCost.Text = "$44.00"
        ElseIf cmbVehicle.SelectedItem = "Hyundai Accent" Then
            lblCMPG.Text = "33"
            lblHMPG.Text = "41"
            lblCost.Text = "$42.00"
        ElseIf cmbVehicle.SelectedItem = "Toyota Corolla Hatchback" Then
            lblCMPG.Text = "32"
            lblHMPG.Text = "41"
            lblCost.Text = "$48.00"
        End If
    End Sub
End Class