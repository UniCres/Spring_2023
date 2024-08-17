Public Class Form1
    'Shiyu Chen
    '2/3/2023
    '3rd Period
    Private Sub btnNow_Click(sender As Object, e As EventArgs) Handles btnNow.Click
        txtNow.Text = nudAge.Value
    End Sub

    Private Sub btnFifty_Click(sender As Object, e As EventArgs) Handles btnOld.Click
        'Step 1 Declare Variables
        Dim intFifty As Integer
        'Step 2 Give Vaiable Value
        'Step 3 Calculate
        intFifty = 50 + nudAge.Value
        'Step 4 Print Answer
        txtOld.Text = intFifty
    End Sub

    Private Sub btnTen_Click(sender As Object, e As EventArgs) Handles btnYoung.Click
        'Step 1 Declare Variables
        Dim intTen As Integer
        'Step 2 Give Vaiable Value
        'Step 3 Calculate
        intTen = nudAge.Value - 10
        'Step 4 Print Answer
        txtYoung.Text = intTen
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
