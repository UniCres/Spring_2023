Public Class Form1
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()

    End Sub

    Private Sub btnBatman_Click(sender As Object, e As EventArgs) Handles btnBatman.Click
        picDuo.Visible = True
    End Sub

    Private Sub btnRobin_Click(sender As Object, e As EventArgs) Handles btnRobin.Click
        picDorthy.Visible = True
    End Sub
End Class
