<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuelCostSummary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        grpHighway = New GroupBox()
        txtHCost = New TextBox()
        lblHMile = New Label()
        lblHCost = New Label()
        txtHMile = New TextBox()
        txtHGallon = New TextBox()
        lblHGallon = New Label()
        pnlGray = New Panel()
        pnlBlue = New Panel()
        lblTitle = New Label()
        mnsMain = New MenuStrip()
        mnsFile = New ToolStripMenuItem()
        mnsExit = New ToolStripMenuItem()
        mnsHelp = New ToolStripMenuItem()
        mnsAbout = New ToolStripMenuItem()
        lblCMile = New Label()
        txtCMile = New TextBox()
        grpCity = New GroupBox()
        txtCCost = New TextBox()
        lblCCost = New Label()
        txtCGallon = New TextBox()
        lblCGallon = New Label()
        lblTotal = New Label()
        lblTotalCost = New Label()
        lblVehicle = New Label()
        lblCar = New Label()
        grpHighway.SuspendLayout()
        pnlBlue.SuspendLayout()
        mnsMain.SuspendLayout()
        grpCity.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpHighway
        ' 
        grpHighway.Controls.Add(txtHCost)
        grpHighway.Controls.Add(lblHMile)
        grpHighway.Controls.Add(lblHCost)
        grpHighway.Controls.Add(txtHMile)
        grpHighway.Controls.Add(txtHGallon)
        grpHighway.Controls.Add(lblHGallon)
        grpHighway.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        grpHighway.Location = New Point(276, 169)
        grpHighway.Name = "grpHighway"
        grpHighway.Size = New Size(220, 264)
        grpHighway.TabIndex = 11
        grpHighway.TabStop = False
        grpHighway.Text = "Highway"
        ' 
        ' txtHCost
        ' 
        txtHCost.BorderStyle = BorderStyle.FixedSingle
        txtHCost.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtHCost.Location = New Point(60, 198)
        txtHCost.Name = "txtHCost"
        txtHCost.ReadOnly = True
        txtHCost.Size = New Size(100, 27)
        txtHCost.TabIndex = 12
        txtHCost.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblHMile
        ' 
        lblHMile.AutoSize = True
        lblHMile.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblHMile.Location = New Point(57, 34)
        lblHMile.Name = "lblHMile"
        lblHMile.Size = New Size(111, 21)
        lblHMile.TabIndex = 7
        lblHMile.Text = "Miles Per Year"
        ' 
        ' lblHCost
        ' 
        lblHCost.AutoSize = True
        lblHCost.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblHCost.Location = New Point(57, 174)
        lblHCost.Name = "lblHCost"
        lblHCost.Size = New Size(43, 21)
        lblHCost.TabIndex = 11
        lblHCost.Text = "Cost"
        ' 
        ' txtHMile
        ' 
        txtHMile.BorderStyle = BorderStyle.FixedSingle
        txtHMile.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtHMile.Location = New Point(60, 58)
        txtHMile.Name = "txtHMile"
        txtHMile.ReadOnly = True
        txtHMile.Size = New Size(100, 27)
        txtHMile.TabIndex = 8
        txtHMile.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtHGallon
        ' 
        txtHGallon.BorderStyle = BorderStyle.FixedSingle
        txtHGallon.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtHGallon.Location = New Point(60, 129)
        txtHGallon.Name = "txtHGallon"
        txtHGallon.ReadOnly = True
        txtHGallon.Size = New Size(100, 27)
        txtHGallon.TabIndex = 10
        txtHGallon.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblHGallon
        ' 
        lblHGallon.AutoSize = True
        lblHGallon.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblHGallon.Location = New Point(57, 105)
        lblHGallon.Name = "lblHGallon"
        lblHGallon.Size = New Size(63, 21)
        lblHGallon.TabIndex = 9
        lblHGallon.Text = "Gallons"
        ' 
        ' pnlGray
        ' 
        pnlGray.BackColor = Color.Silver
        pnlGray.Location = New Point(0, 91)
        pnlGray.Name = "pnlGray"
        pnlGray.Size = New Size(547, 17)
        pnlGray.TabIndex = 9
        ' 
        ' pnlBlue
        ' 
        pnlBlue.BackColor = Color.MidnightBlue
        pnlBlue.Controls.Add(lblTitle)
        pnlBlue.Location = New Point(0, 24)
        pnlBlue.Name = "pnlBlue"
        pnlBlue.Size = New Size(550, 67)
        pnlBlue.TabIndex = 8
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.ForeColor = SystemColors.Window
        lblTitle.Location = New Point(10, 7)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(472, 50)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Yearly Fuel Cost Summary"
        ' 
        ' mnsMain
        ' 
        mnsMain.BackColor = Color.MistyRose
        mnsMain.Items.AddRange(New ToolStripItem() {mnsFile, mnsHelp})
        mnsMain.Location = New Point(0, 0)
        mnsMain.Name = "mnsMain"
        mnsMain.Size = New Size(534, 24)
        mnsMain.TabIndex = 13
        mnsMain.Text = "MenuStrip1"
        ' 
        ' mnsFile
        ' 
        mnsFile.DropDownItems.AddRange(New ToolStripItem() {mnsExit})
        mnsFile.Name = "mnsFile"
        mnsFile.Size = New Size(37, 20)
        mnsFile.Text = "File"
        ' 
        ' mnsExit
        ' 
        mnsExit.Name = "mnsExit"
        mnsExit.Size = New Size(93, 22)
        mnsExit.Text = "Exit"
        ' 
        ' mnsHelp
        ' 
        mnsHelp.DropDownItems.AddRange(New ToolStripItem() {mnsAbout})
        mnsHelp.Name = "mnsHelp"
        mnsHelp.Size = New Size(44, 20)
        mnsHelp.Text = "Help"
        ' 
        ' mnsAbout
        ' 
        mnsAbout.Name = "mnsAbout"
        mnsAbout.Size = New Size(107, 22)
        mnsAbout.Text = "About"
        ' 
        ' lblCMile
        ' 
        lblCMile.AutoSize = True
        lblCMile.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblCMile.Location = New Point(56, 34)
        lblCMile.Name = "lblCMile"
        lblCMile.Size = New Size(111, 21)
        lblCMile.TabIndex = 0
        lblCMile.Text = "Miles Per Year"
        ' 
        ' txtCMile
        ' 
        txtCMile.BorderStyle = BorderStyle.FixedSingle
        txtCMile.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtCMile.Location = New Point(59, 58)
        txtCMile.Name = "txtCMile"
        txtCMile.ReadOnly = True
        txtCMile.Size = New Size(100, 27)
        txtCMile.TabIndex = 2
        txtCMile.TextAlign = HorizontalAlignment.Center
        ' 
        ' grpCity
        ' 
        grpCity.Controls.Add(txtCCost)
        grpCity.Controls.Add(lblCCost)
        grpCity.Controls.Add(txtCGallon)
        grpCity.Controls.Add(lblCGallon)
        grpCity.Controls.Add(txtCMile)
        grpCity.Controls.Add(lblCMile)
        grpCity.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        grpCity.Location = New Point(37, 169)
        grpCity.Name = "grpCity"
        grpCity.Size = New Size(220, 264)
        grpCity.TabIndex = 10
        grpCity.TabStop = False
        grpCity.Text = "City"
        ' 
        ' txtCCost
        ' 
        txtCCost.BorderStyle = BorderStyle.FixedSingle
        txtCCost.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtCCost.Location = New Point(59, 198)
        txtCCost.Name = "txtCCost"
        txtCCost.ReadOnly = True
        txtCCost.Size = New Size(100, 27)
        txtCCost.TabIndex = 6
        txtCCost.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblCCost
        ' 
        lblCCost.AutoSize = True
        lblCCost.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblCCost.Location = New Point(56, 174)
        lblCCost.Name = "lblCCost"
        lblCCost.Size = New Size(43, 21)
        lblCCost.TabIndex = 5
        lblCCost.Text = "Cost"
        ' 
        ' txtCGallon
        ' 
        txtCGallon.BorderStyle = BorderStyle.FixedSingle
        txtCGallon.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtCGallon.Location = New Point(59, 129)
        txtCGallon.Name = "txtCGallon"
        txtCGallon.ReadOnly = True
        txtCGallon.Size = New Size(100, 27)
        txtCGallon.TabIndex = 4
        txtCGallon.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblCGallon
        ' 
        lblCGallon.AutoSize = True
        lblCGallon.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblCGallon.Location = New Point(56, 105)
        lblCGallon.Name = "lblCGallon"
        lblCGallon.Size = New Size(63, 21)
        lblCGallon.TabIndex = 3
        lblCGallon.Text = "Gallons"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotal.Location = New Point(154, 456)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(116, 30)
        lblTotal.TabIndex = 7
        lblTotal.Text = "Total Cost:"
        ' 
        ' lblTotalCost
        ' 
        lblTotalCost.AutoSize = True
        lblTotalCost.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalCost.ForeColor = Color.Red
        lblTotalCost.Location = New Point(276, 456)
        lblTotalCost.Name = "lblTotalCost"
        lblTotalCost.Size = New Size(91, 30)
        lblTotalCost.TabIndex = 14
        lblTotalCost.Text = "$000.00"
        ' 
        ' lblVehicle
        ' 
        lblVehicle.AutoSize = True
        lblVehicle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblVehicle.Location = New Point(37, 128)
        lblVehicle.Name = "lblVehicle"
        lblVehicle.Size = New Size(79, 25)
        lblVehicle.TabIndex = 19
        lblVehicle.Text = "Vehicle:"
        ' 
        ' lblCar
        ' 
        lblCar.AutoSize = True
        lblCar.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblCar.Location = New Point(122, 128)
        lblCar.Name = "lblCar"
        lblCar.Size = New Size(41, 25)
        lblCar.TabIndex = 20
        lblCar.Text = "Car"
        ' 
        ' frmFuelCostSummary
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(534, 511)
        Controls.Add(lblCar)
        Controls.Add(lblVehicle)
        Controls.Add(lblTotalCost)
        Controls.Add(lblTotal)
        Controls.Add(grpHighway)
        Controls.Add(grpCity)
        Controls.Add(pnlGray)
        Controls.Add(pnlBlue)
        Controls.Add(mnsMain)
        Name = "frmFuelCostSummary"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Yearly Fuel Cost Summary"
        grpHighway.ResumeLayout(False)
        grpHighway.PerformLayout()
        pnlBlue.ResumeLayout(False)
        pnlBlue.PerformLayout()
        mnsMain.ResumeLayout(False)
        mnsMain.PerformLayout()
        grpCity.ResumeLayout(False)
        grpCity.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grpHighway As GroupBox
    Friend WithEvents pnlGray As Panel
    Friend WithEvents pnlBlue As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents mnsMain As MenuStrip
    Friend WithEvents mnsFile As ToolStripMenuItem
    Friend WithEvents mnsExit As ToolStripMenuItem
    Friend WithEvents mnsHelp As ToolStripMenuItem
    Friend WithEvents mnsAbout As ToolStripMenuItem
    Friend WithEvents lblCMile As Label
    Friend WithEvents txtCMile As TextBox
    Friend WithEvents grpCity As GroupBox
    Friend WithEvents txtCCost As TextBox
    Friend WithEvents lblCCost As Label
    Friend WithEvents txtCGallon As TextBox
    Friend WithEvents lblCGallon As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents txtHCost As TextBox
    Friend WithEvents lblHMile As Label
    Friend WithEvents lblHCost As Label
    Friend WithEvents txtHMile As TextBox
    Friend WithEvents txtHGallon As TextBox
    Friend WithEvents lblHGallon As Label
    Friend WithEvents lblVehicle As Label
    Friend WithEvents lblCar As Label
End Class
