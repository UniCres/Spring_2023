Public Class frmFuelCost
    'Shiyu Chen
    '5/10/2023
    '5/12/2023
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If Validate_Form() = True Then
            Unknown_Made_Year()
            'Deblare New Form
            Dim frmFuelCostSummary As New frmFuelCostSummary

            'Bring informations to the summary form and do calculations
            frmFuelCostSummary.lblCar.Text = txtCar.Text & " (" & Unknown_Made_Year() & ")"

            'City GroupBox part
            frmFuelCostSummary.txtCMile.Text = nudCMile.Value * 52
            frmFuelCostSummary.txtCGallon.Text = Format(frmFuelCostSummary.txtCMile.Text / nudCMPG.Value, ".00")
            frmFuelCostSummary.txtCCost.Text = Format(frmFuelCostSummary.txtCGallon.Text * txtPrice.Text, "currency")

            'Highway GroupBox part
            frmFuelCostSummary.txtHMile.Text = nudHMile.Value * 52
            frmFuelCostSummary.txtHGallon.Text = Format(frmFuelCostSummary.txtHMile.Text / nudHMPG.Value, ".00")
            frmFuelCostSummary.txtHCost.Text = Format(frmFuelCostSummary.txtHGallon.Text * txtPrice.Text, "currency")

            'Total Cost
            frmFuelCostSummary.lblTotalCost.Text = Format(frmFuelCostSummary.txtHGallon.Text * txtPrice.Text + frmFuelCostSummary.txtCGallon.Text * txtPrice.Text, "currency")

            'Show Form
            frmFuelCostSummary.ShowDialog()

            'Close Form
            frmFuelCostSummary.Close()
        End If
    End Sub

    Private Sub mnsExit_Click(sender As Object, e As EventArgs) Handles mnsExit.Click
        'Close the form
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
    Private Function Validate_Form() As Boolean
        'Validate for non-numeric value and empty value
        If IsNumeric(txtPrice.Text) = False Or txtPrice.Text = "" Then
            MsgBox("Please enter a NUMBER for gas price!", MsgBoxStyle.Critical, "Please Enter A NUMBER For Gas Price!")
            txtPrice.Clear()
            txtPrice.Focus()
            Return False

            'Validate for non-positive value
        ElseIf txtPrice.Text <= 0 Then
            MsgBox("Please enter a POSITIVE number for gas price!", MsgBoxStyle.Critical, "Please Enter A POSITIVE Number For Gas Price!")
            txtPrice.Clear()
            txtPrice.Focus()
            Return False

            'Validate for car name
        ElseIf Trim(txtCar.Text) = "" Then
            MsgBox("Please enter a vehicle name!", MsgBoxStyle.Critical, "Please Enter A Vehicle Name!")
            txtCar.Clear()
            txtCar.Focus()
            Return False

        Else
            Return True
        End If
    End Function

    Private Function Unknown_Made_Year()
        'Validate for unknown year of production
        Dim strYear As String
        If mtbYear.Text = "" Then
            strYear = "Unknown"
        Else
            strYear = mtbYear.Text
        End If
        Return strYear
    End Function
End Class