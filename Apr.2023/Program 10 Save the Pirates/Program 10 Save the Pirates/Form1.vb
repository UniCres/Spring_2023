Imports System.DirectoryServices.ActiveDirectory

Public Class Form1
    'Shiyu Chen
    '4/26/2023
    '4/28/2023
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load the starting players when the form loads
        Load_Players()
    End Sub
    Private Sub Load_Players()
        'Set the starting players
        lblLO.Text = "Morgan"
        lblCen.Text = "McLouth"
        lblRO.Text = "Pierce"
        lblSS.Text = "Wilson"
        lblSB.Text = "Sanchez"
        lblTB.Text = "Andy LaRoche"
        lblPit.Text = "Shultz"
        lblFB.Text = "Adam LaRoche"
        lblCat.Text = "Doumit"
    End Sub
    Private Function Prompt_User(ByRef NewPlayer As String, ByVal Position As String)
        'Add value the string
        Dim strInput As String = InputBox("Please enter a new " & Position & ":", "Program 10 Save the Pirates Program")

        'Trim the string
        strInput = Trim(strInput)

        'Validate the string
        If IsNumeric(strInput) = True Then
            MsgBox("Please enter a name, not a number.", MsgBoxStyle.Critical, "Please Enter A Name!")
        ElseIf strInput = "" Then
            MsgBox("Please enter a name!", MsgBoxStyle.Critical, "Please Enter A Name!")
        Else
            NewPlayer = strInput
        End If
        Return NewPlayer
    End Function
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Prompts the user to verify they want to submit or not
        Dim result As Windows.Forms.DialogResult = MsgBox("Are you sure you want to submit your lineup?", MsgBoxStyle.YesNo, "Confirmation")

        'Close the program if the user clicks yes
        If result = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    'Change the Left Outfielder
    Private Sub lblLO_Click(sender As Object, e As EventArgs) Handles lblLO.Click
        Prompt_User(lblLO.Text, "Left Outfielder")
    End Sub
    'Change the Center
    Private Sub lblCen_Click(sender As Object, e As EventArgs) Handles lblCen.Click
        Prompt_User(lblCen.Text, "Center")
    End Sub
    'Change the Right Outfielder
    Private Sub lblRO_Click(sender As Object, e As EventArgs) Handles lblRO.Click
        Prompt_User(lblRO.Text, "Right Outfielder")
    End Sub
    'Change the Short Stop
    Private Sub lblSS_Click(sender As Object, e As EventArgs) Handles lblSS.Click
        Prompt_User(lblSS.Text, "Short Stop")
    End Sub
    'Change the 2nd Baseman
    Private Sub lblSB_Click(sender As Object, e As EventArgs) Handles lblSB.Click
        Prompt_User(lblSB.Text, "2nd Baseman")
    End Sub
    'Change the 3rd Baseman
    Private Sub lblTB_Click(sender As Object, e As EventArgs) Handles lblTB.Click
        Prompt_User(lblTB.Text, "3rd Baseman")
    End Sub
    'Change the Pitcher
    Private Sub lblPit_Click(sender As Object, e As EventArgs) Handles lblPit.Click
        Prompt_User(lblPit.Text, "Pitcher")
    End Sub
    'Change the 1st Baseman
    Private Sub lblFB_Click(sender As Object, e As EventArgs) Handles lblFB.Click
        Prompt_User(lblFB.Text, "1st Baseman")
    End Sub
    'Change the Catcher
    Private Sub lblCat_Click(sender As Object, e As EventArgs) Handles lblCat.Click
        Prompt_User(lblCat.Text, "Catcher")
    End Sub
End Class
