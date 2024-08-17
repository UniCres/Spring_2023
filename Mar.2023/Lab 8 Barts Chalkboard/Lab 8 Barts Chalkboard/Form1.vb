Public Class Form1
    'Shiyu Chen
    '3/30/2023
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lbxRepeat.Items.Clear()
        txtPhrase.Clear()
        nudTime.Value = 0
    End Sub

    Private Sub btnDo_Click(sender As Object, e As EventArgs) Handles btnDo.Click

        lbxRepeat.Items.Clear()

        Dim i As Integer
        Dim strPhrase As String = txtPhrase.Text

        For i = 1 To nudTime.Value
            lbxRepeat.Items.Add(i & ".) " & strPhrase)
        Next
    End Sub
End Class
