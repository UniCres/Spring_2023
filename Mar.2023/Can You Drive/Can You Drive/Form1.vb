Public Class Form1
    'Shiyu Chen
    '3/1/2023
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        'Declare variable to hold message
        Dim strMessage As String = "No, you are not old enough to drive."

        'Check to see if the person is old enough to drive
        'If they are, update strMessage with a new message
        If nudAge.Value >= 16 Then
            strMessage = "Yes, you are old enough to drive!"
        End If

        'Print message in MsgBox
        MsgBox(strMessage, MsgBoxStyle.Information, "Driving Status")
    End Sub
End Class
