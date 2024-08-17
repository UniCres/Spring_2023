Imports System.Runtime.CompilerServices

Public Class Form1
    'Shiyu Chen
    '3/7/2023
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear TextBoxes and Lables
        txtOne.Clear()
        txtTwo.Clear()
        lblHighPrint.Text = "Print"
        lblLowPrint.Text = "Print"

        'Focus on txtOne
        txtOne.Focus()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Close()
    End Sub
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        'Validate for non-numeric data
        If IsNumeric(txtOne.Text) = False Or IsNumeric(txtTwo.Text) = False Then
            MsgBox("Please enter numeric data in the textboxes!", MsgBoxStyle.Critical, "Data Validation Warning!")

            'If txtOne equals to txtTwo
        ElseIf CDec(txtOne.Text) = CDec(txtTwo.Text) Then
            MsgBox("Please enter two different numbers!", MsgBoxStyle.Critical, "Data Validation Warning!")

            'If txtOne higher than txtTwo
        ElseIf CDec(txtOne.Text) > CDec(txtTwo.Text) Then
            lblHighPrint.Text = txtOne.Text
            lblLowPrint.Text = txtTwo.Text

            'If txtOne lower than txtTwo
        Else
            lblHighPrint.Text = txtTwo.Text
            lblLowPrint.Text = txtOne.Text
        End If
    End Sub
End Class
