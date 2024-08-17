Public Class Form1
    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        btnRight.Visible = False
        btnBottom.Visible = True
        btnTop.Visible = True
        btnLeft.Visible = True
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        btnRight.Visible = True
        btnBottom.Visible = True
        btnTop.Visible = True
        btnLeft.Visible = False
    End Sub

    Private Sub btnTop_Click(sender As Object, e As EventArgs) Handles btnTop.Click
        btnRight.Visible = True
        btnBottom.Visible = True
        btnTop.Visible = False
        btnLeft.Visible = True
    End Sub

    Private Sub btnBottom_Click(sender As Object, e As EventArgs) Handles btnBottom.Click
        btnRight.Visible = True
        btnBottom.Visible = False
        btnTop.Visible = True
        btnLeft.Visible = True
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

End Class
