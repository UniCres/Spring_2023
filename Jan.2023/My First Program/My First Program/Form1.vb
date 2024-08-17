Public Class Form1
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        lblMessage.Visible = True
        btnAppear.Visible = True
    End Sub

    Private Sub btnAppear_Click(sender As Object, e As EventArgs) Handles btnAppear.Click
        picMHHS.Visible = True
        lblClick.Visible = True
    End Sub

    Private Sub picMHHS_Click(sender As Object, e As EventArgs) Handles picMHHS.Click
        lblHello.Visible = True
        btnHide.Visible = True
        btnRemove.Visible = True
        btnDone.Visible = True
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        picMHHS.Visible = False
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        lblMessage.Visible = False
    End Sub
End Class
