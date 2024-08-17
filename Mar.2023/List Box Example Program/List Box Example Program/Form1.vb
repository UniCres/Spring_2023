Public Class Form1
    'Shiyu Chen
    '3/30/2023
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Clear out the Listbox
        lbxNames.Items.Clear()

        'Declare a variable to hold name of player
        Dim strPlayer As String

        'Give variable a value
        strPlayer = "Fluery"

        'Use variable to add an item to listbox
        lbxNames.Items.Add(strPlayer)

        'Add names to the listbox
        lbxNames.Items.Add("Crosby")
        lbxNames.Items.Add("Malkin")
        lbxNames.Items.Add("Kunitz")
        lbxNames.Items.Add("Gonchar")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear out the listbox
        lbxNames.Items.Clear()
    End Sub
End Class
