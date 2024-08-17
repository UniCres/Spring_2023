Public Class Form1
    'Shiyu Chen
    '3/15/2023

    Private Sub mnsAbout_Click(sender As Object, e As EventArgs) Handles mnsAbout.Click
        'Deblare New Form
        Dim About As New frmAbout

        'Show Form
        About.ShowDialog()

        'Close Form
        About.Close()
    End Sub

    Private Sub mnsQuit_Click(sender As Object, e As EventArgs) Handles mnsQuit.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'Call the validation function
        If Validate_Form() = True Then

            'Declare constants to hold rates
            Const DEC_LAWN_CUT As Decimal = 30.0
            Const DEC_HOURLY_RATE As Decimal = 15.0

            'Declare variable to hold total
            Dim decTotal As Decimal

            'Calculate the total
            decTotal = txtCut.Text * DEC_LAWN_CUT + txtHours.Text * DEC_HOURLY_RATE

            'Print total in lblTotal
            lblTotal.Text = "You earned a total of: " & Format(decTotal, "currency")
        End If
    End Sub

    Private Function Validate_Form() As Boolean
        'Trim textboxes
        txtCut.Text = Trim(txtCut.Text)
        txtHours.Text = Trim(txtHours.Text)
        If IsNumeric(txtCut.Text) = False Or IsNumeric(txtHours.Text) = False Then
            MsgBox("Please enter a valid number!", MsgBoxStyle.Critical, "Warning!")
            txtCut.Clear()
            txtHours.Clear()
            txtCut.Focus()
            lblTotal.Text = "How Much I Made Today!"
            Return False

        ElseIf txtCut.Text < 0 Or txtHours.Text < 0 Then
            MsgBox("Please enter a positive number!", MsgBoxStyle.Critical, "Warning!")
            txtCut.Clear()
            txtHours.Clear()
            txtCut.Focus()
            lblTotal.Text = "How Much I Made Today!"
            Return False
        End If
        Return True
    End Function
End Class
