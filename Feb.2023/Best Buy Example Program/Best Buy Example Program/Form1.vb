Public Class Form1
    'Shiyu Chen
    '2/2/2023
    '3rd Period
    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        'Step 1 Declare Variables
        Dim intQty As Integer
        Dim decTotal As Decimal

        'Step 2 Give Variable Value
        intQty = nudQty.Value

        'Step 3 Calculate
        decTotal = intQty * 125.95 + 0.07 * intQty * 125.95

        'Step 4 Print Answer
        lblPrice.Text = Format(decTotal, "currency")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Close Program
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        'Deblare new form
        Dim About As New frmAbout
        'Show Form
        About.ShowDialog()
        'Close Form
        About.Close()
    End Sub
End Class
