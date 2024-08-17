Public Class Form1
    'Shiyu Chen
    '2/17/2023
    '2/23/2023
    Private Sub mnsExit_Click(sender As Object, e As EventArgs) Handles mnsExit.Click
        'Close Form
        Me.Close()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear All NumericUpDown & TextBox
        nudGas.Value = 0
        nudBooks.Value = 0
        nudCola.Value = 0
        nudSquishie.Value = 0
        nudCereal.Value = 0
        txtPrice.Text = ""

        'Hide Check Out Button
        btnCheck.Visible = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Show Check Out Button
        btnCheck.Visible = True

        'Declare Constants
        Const GAS_PRICE As Decimal = 3.19
        Const COLA_PRICE As Decimal = 1.19
        Const SQUISHIE_PRICE As Decimal = 0.99
        Const CEREAL_PRICE As Decimal = 3.49
        Const BOOKS_PRICE As Decimal = 3.1

        'Declare Variables
        Dim intGas As Integer = nudGas.Value
        Dim decGas As Decimal
        Dim intCola As Integer = nudCola.Value
        Dim decCola As Decimal
        Dim intSquishie As Integer = nudSquishie.Value
        Dim decSquishie As Decimal
        Dim intCereal As Integer = nudCereal.Value
        Dim decCereal As Decimal
        Dim intBooks As Integer = nudBooks.Value
        Dim decBooks As Decimal
        Dim decTotal As Decimal

        'Calculate
        decGas = intGas * GAS_PRICE
        decCola = intCola * COLA_PRICE
        decSquishie = intSquishie * SQUISHIE_PRICE
        decCereal = intCereal * CEREAL_PRICE
        decBooks = intBooks * BOOKS_PRICE
        decTotal = decGas + decCola + decSquishie + decCereal + decBooks

        'Print Answer
        txtPrice.Text = Format(decTotal, "currency")
    End Sub
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'Declare Variable
        Dim strReceipt As String

        'Give Variable Value
        strReceipt = "Kwik-E-Mart" & ControlChars.NewLine & ControlChars.NewLine & nudGas.Value & " Gallon(s) of Gas: " & Format(3.19 * nudGas.Value, "currency") & ControlChars.NewLine & nudCola.Value & " Bottle(s) of Buzz Cola: " & Format(1.19 * nudCola.Value, "currency") & ControlChars.NewLine & nudSquishie.Value & " Squishie(s): " & Format(0.99 * nudSquishie.Value, "currency") & ControlChars.NewLine & nudCereal.Value & " Box(es) of Krusty-O's Cereal: " & Format(3.49 * nudCereal.Value, "currency") & ControlChars.NewLine & nudBooks.Value & " Radioactive Man Comic Book(s): " & Format(3.1 * nudBooks.Value, "currency") & ControlChars.NewLine & ControlChars.NewLine & "Total Price: " & txtPrice.Text & ControlChars.NewLine & ControlChars.NewLine & "Thank You"

        'Create Messsge Box
        MsgBox(strReceipt, MsgBoxStyle.OkOnly, "Check Out")

        'Hide Check Out Button
        btnCheck.Visible = False
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
