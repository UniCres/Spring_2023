Public Class Form1
    'Shiyu Chen
    '3rd Period
    '2/6/2023
    Private Sub mnsExit_Click(sender As Object, e As EventArgs) Handles mnsExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intPer As Integer
        Dim intBox As Integer
        Dim intTotal As Integer

        intPer = nudPer.Value
        intBox = nudBox.Value

        intTotal = intPer * intBox

        lblTotal.Text = intTotal

    End Sub

    Private Sub mnsAbout_Click(sender As Object, e As EventArgs) Handles mnsAbout.Click
        Dim About As New frmAbout

        About.ShowDialog()

        About.Close()
    End Sub
End Class
