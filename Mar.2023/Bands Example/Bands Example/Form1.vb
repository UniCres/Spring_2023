Public Class Form1
    'Shiyu Chen
    '3/16/2023
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        'Declare vaiable to hold string value from textbox
        Dim strBand As String = txtName.Text

        'Force input to all UPPERCASE
        strBand = UCase(strBand)

        'Build Case Statement of Band Names
        Select Case strBand
            Case "DEF LEPPARD"
                MsgBox("Classic Rock", MsgBoxStyle.Information, "Genre")

            Case "THE OFFSPRING"
                MsgBox("Alternative", MsgBoxStyle.Information, "Genre")

            Case "FORTNITE MUSIC"
                MsgBox("Hard Rock", MsgBoxStyle.Information, "Genre")

            Case "TLC"
                MsgBox("R&B", MsgBoxStyle.Information, "Genre")

            Case "KORN"
                MsgBox("Nu Metal", MsgBoxStyle.Information, "Genre")

            Case "MORGAN WALLEN"
                MsgBox("Country", MsgBoxStyle.Information, "Genre")

            Case "ELEVATION WORSHIP"
                MsgBox("Gospel", MsgBoxStyle.Information, "Genre")

            Case "CITY GIRLS"
                MsgBox("Hip hop", MsgBoxStyle.Information, "Genre")

            Case Else
                MsgBox("Band not found!", MsgBoxStyle.Critical, "Genre")
        End Select
    End Sub
End Class
