Public Class frmAbout
    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        picProfile.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        picProfile.Visible = True
    End Sub

    Private Sub Button2_Hover(sender As Object, e As EventArgs) Handles btnExit.MouseHover
        btnExit.Visible = False
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnsExit.Click
        Me.Close()
    End Sub
End Class