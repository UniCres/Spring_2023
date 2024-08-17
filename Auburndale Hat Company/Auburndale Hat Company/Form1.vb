Public Class Form1
    'Shiyu Chen
    '2/15/2023
    '2/17/2023
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare Constants
        Const WHITE_HAT As Decimal = 8.25
        Const BLUE_HAT As Decimal = 9
        Const GREEN_HAT As Decimal = 9
        Const RED_HAT As Decimal = 9.5

        'Declare Variables & Give Variables Value
        Dim intWhite As Integer = txtWhite.Text
        Dim intBlue As Integer = txtBlue.Text
        Dim intGreen As Integer = txtGreen.Text
        Dim intRed As Integer = txtRed.Text
        Dim decPrice As Decimal

        'Calculate Total Hats Sold & Print Answer in Total Hats Sold Text Box
        txtSold.Text = intWhite + intBlue + intGreen + intRed

        'Calculate Total Price
        decPrice = (intWhite * WHITE_HAT) + (intBlue * BLUE_HAT) + (intGreen * GREEN_HAT) + (intRed * RED_HAT)

        'Print Answer in Total Price Text Box
        txtPrice.Text = Format(decPrice, "currency")

        'Change Visibility of Check Out Button to True
        btnCheck.Visible = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear All Text Boxes
        txtName.Text = ""
        txtCity.Text = ""
        txtAddress.Text = ""
        txtState.Text = ""
        txtZip.Text = ""
        txtWhite.Text = ""
        txtBlue.Text = ""
        txtGreen.Text = ""
        txtRed.Text = ""
        txtSold.Text = ""
        txtPrice.Text = ""

        'Change Visibility of Check Out Button to False
        btnCheck.Visible = False
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'Declare Variable

        Dim strReciept As String

        'Give Variable Value
        strReciept = "CUSTOMER RECIEPT" & ControlChars.NewLine & ControlChars.NewLine & txtName.Text & ControlChars.NewLine & txtAddress.Text & ControlChars.NewLine & txtCity.Text & ", " & txtState.Text & " " & txtZip.Text & ControlChars.NewLine & ControlChars.NewLine & "HATS ORDERED: " & txtSold.Text & ControlChars.NewLine & "TOTAL PRICE: " & txtPrice.Text

        'Print Answer & Customize Message Box
        MsgBox(strReciept, MsgBoxStyle.OkOnly, "Check Out")

        'Change Visibility of Check Out Button to False
        btnCheck.Visible = False
    End Sub

    Private Sub mnsQuit_Click(sender As Object, e As EventArgs) Handles mnsQuit.Click
        'Close Form
        Me.Close()
    End Sub

    Private Sub mnsAbout_Click(sender As Object, e As EventArgs) Handles mnsAbout.Click
        'Deblare New Form
        Dim About As New frmAbout

        'Show Form
        About.ShowDialog()

        'Close Form
        About.Close()
    End Sub
End Class
