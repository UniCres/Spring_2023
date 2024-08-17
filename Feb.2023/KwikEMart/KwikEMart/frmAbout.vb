Public Class frmAbout
    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        'Show Profile Picture
        picProfile.Visible = False
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'Hide Profile Picture
        picProfile.Visible = True
    End Sub

    Private Sub mnsExit_Click(sender As Object, e As EventArgs) Handles mnsExit.Click
        'Close About Form
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close About Form
        Me.Close()
    End Sub
End Class