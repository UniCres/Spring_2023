<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuelCost
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
        pnlGray = New Panel()
        pnlBlue = New Panel()
        lblTitle = New Label()
        grpInfo = New GroupBox()
        nudHMPG = New NumericUpDown()
        nudCMPG = New NumericUpDown()
        lblHMPG = New Label()
        lblCMPG = New Label()
        mtbYear = New MaskedTextBox()
        txtCar = New TextBox()
        lblYear = New Label()
        lblMake = New Label()
        grpTravel = New GroupBox()
        txtPrice = New TextBox()
        lblPrice = New Label()
        nudHMile = New NumericUpDown()
        nudCMile = New NumericUpDown()
        lblCity = New Label()
        lblHighway = New Label()
        btnCalculate = New Button()
        mnsMain = New MenuStrip()
        mnsFile = New ToolStripMenuItem()
        mnsExit = New ToolStripMenuItem()
        mnsHelp = New ToolStripMenuItem()
        mnsAbout = New ToolStripMenuItem()
        pnlBlue.SuspendLayout()
        grpInfo.SuspendLayout()
        CType(nudHMPG, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudCMPG, ComponentModel.ISupportInitialize).BeginInit()
        grpTravel.SuspendLayout()
        CType(nudHMile, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudCMile, ComponentModel.ISupportInitialize).BeginInit()
        mnsMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlGray
        ' 
        pnlGray.BackColor = Color.Silver
        pnlGray.Location = New Point(0, 90)
        pnlGray.Name = "pnlGray"
        pnlGray.Size = New Size(534, 17)
        pnlGray.TabIndex = 3
        ' 
        ' pnlBlue
        ' 
        pnlBlue.BackColor = Color.MidnightBlue
        pnlBlue.Controls.Add(lblTitle)
        pnlBlue.Location = New Point(0, 24)
        pnlBlue.Name = "pnlBlue"
        pnlBlue.Size = New Size(534, 67)
        pnlBlue.TabIndex = 2
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.ForeColor = SystemColors.Window
        lblTitle.Location = New Point(10, 7)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(295, 50)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Yearly Fuel Cost"
        ' 
        ' grpInfo
        ' 
        grpInfo.Controls.Add(nudHMPG)
        grpInfo.Controls.Add(nudCMPG)
        grpInfo.Controls.Add(lblHMPG)
        grpInfo.Controls.Add(lblCMPG)
        grpInfo.Controls.Add(mtbYear)
        grpInfo.Controls.Add(txtCar)
        grpInfo.Controls.Add(lblYear)
        grpInfo.Controls.Add(lblMake)
        grpInfo.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        grpInfo.Location = New Point(90, 126)
        grpInfo.Name = "grpInfo"
        grpInfo.Size = New Size(352, 230)
        grpInfo.TabIndex = 4
        grpInfo.TabStop = False
        grpInfo.Text = "Vehicle Information"
        ' 
        ' nudHMPG
        ' 
        nudHMPG.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudHMPG.Location = New Point(213, 180)
        nudHMPG.Maximum = New [Decimal](New Integer() {1000000, 0, 0, 0})
        nudHMPG.Name = "nudHMPG"
        nudHMPG.Size = New Size(75, 27)
        nudHMPG.TabIndex = 4
        nudHMPG.TextAlign = HorizontalAlignment.Center
        nudHMPG.Value = New [Decimal](New Integer() {30, 0, 0, 0})
        ' 
        ' nudCMPG
        ' 
        nudCMPG.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudCMPG.Location = New Point(52, 180)
        nudCMPG.Maximum = New [Decimal](New Integer() {1000000, 0, 0, 0})
        nudCMPG.Name = "nudCMPG"
        nudCMPG.Size = New Size(75, 27)
        nudCMPG.TabIndex = 3
        nudCMPG.TextAlign = HorizontalAlignment.Center
        nudCMPG.Value = New [Decimal](New Integer() {23, 0, 0, 0})
        ' 
        ' lblHMPG
        ' 
        lblHMPG.AutoSize = True
        lblHMPG.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblHMPG.Location = New Point(193, 156)
        lblHMPG.Name = "lblHMPG"
        lblHMPG.Size = New Size(122, 21)
        lblHMPG.TabIndex = 5
        lblHMPG.Text = "MPG (Highway)"
        ' 
        ' lblCMPG
        ' 
        lblCMPG.AutoSize = True
        lblCMPG.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblCMPG.Location = New Point(47, 156)
        lblCMPG.Name = "lblCMPG"
        lblCMPG.Size = New Size(87, 21)
        lblCMPG.TabIndex = 4
        lblCMPG.Text = "MPG (City)"
        ' 
        ' mtbYear
        ' 
        mtbYear.BorderStyle = BorderStyle.FixedSingle
        mtbYear.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        mtbYear.Location = New Point(22, 117)
        mtbYear.Mask = "0000"
        mtbYear.Name = "mtbYear"
        mtbYear.Size = New Size(76, 27)
        mtbYear.TabIndex = 2
        mtbYear.Text = "2021"
        mtbYear.ValidatingType = GetType(Integer)
        ' 
        ' txtCar
        ' 
        txtCar.BorderStyle = BorderStyle.FixedSingle
        txtCar.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtCar.Location = New Point(21, 56)
        txtCar.Name = "txtCar"
        txtCar.Size = New Size(194, 27)
        txtCar.TabIndex = 1
        txtCar.Text = "Kia Sportage"
        ' 
        ' lblYear
        ' 
        lblYear.AutoSize = True
        lblYear.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblYear.Location = New Point(21, 93)
        lblYear.Name = "lblYear"
        lblYear.Size = New Size(41, 21)
        lblYear.TabIndex = 1
        lblYear.Text = "Year"
        ' 
        ' lblMake
        ' 
        lblMake.AutoSize = True
        lblMake.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblMake.Location = New Point(21, 32)
        lblMake.Name = "lblMake"
        lblMake.Size = New Size(50, 21)
        lblMake.TabIndex = 0
        lblMake.Text = "Make"
        ' 
        ' grpTravel
        ' 
        grpTravel.Controls.Add(txtPrice)
        grpTravel.Controls.Add(lblPrice)
        grpTravel.Controls.Add(nudHMile)
        grpTravel.Controls.Add(nudCMile)
        grpTravel.Controls.Add(lblCity)
        grpTravel.Controls.Add(lblHighway)
        grpTravel.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        grpTravel.Location = New Point(90, 362)
        grpTravel.Name = "grpTravel"
        grpTravel.Size = New Size(352, 181)
        grpTravel.TabIndex = 5
        grpTravel.TabStop = False
        grpTravel.Text = "Average Weekly Travel"
        ' 
        ' txtPrice
        ' 
        txtPrice.BorderStyle = BorderStyle.FixedSingle
        txtPrice.Location = New Point(127, 130)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(100, 29)
        txtPrice.TabIndex = 7
        txtPrice.Text = "2.97"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrice.Location = New Point(66, 106)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(222, 21)
        lblPrice.TabIndex = 12
        lblPrice.Text = "Current Gas Price (Per Gallon)"
        ' 
        ' nudHMile
        ' 
        nudHMile.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudHMile.Location = New Point(216, 58)
        nudHMile.Maximum = New [Decimal](New Integer() {1000000, 0, 0, 0})
        nudHMile.Name = "nudHMile"
        nudHMile.Size = New Size(75, 27)
        nudHMile.TabIndex = 6
        nudHMile.TextAlign = HorizontalAlignment.Center
        nudHMile.Value = New [Decimal](New Integer() {100, 0, 0, 0})
        ' 
        ' nudCMile
        ' 
        nudCMile.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        nudCMile.Location = New Point(55, 58)
        nudCMile.Maximum = New [Decimal](New Integer() {1000000, 0, 0, 0})
        nudCMile.Name = "nudCMile"
        nudCMile.Size = New Size(75, 27)
        nudCMile.TabIndex = 5
        nudCMile.TextAlign = HorizontalAlignment.Center
        nudCMile.Value = New [Decimal](New Integer() {25, 0, 0, 0})
        ' 
        ' lblCity
        ' 
        lblCity.AutoSize = True
        lblCity.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblCity.Location = New Point(51, 34)
        lblCity.Name = "lblCity"
        lblCity.Size = New Size(81, 21)
        lblCity.TabIndex = 8
        lblCity.Text = "City Miles"
        ' 
        ' lblHighway
        ' 
        lblHighway.AutoSize = True
        lblHighway.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblHighway.Location = New Point(196, 34)
        lblHighway.Name = "lblHighway"
        lblHighway.Size = New Size(116, 21)
        lblHighway.TabIndex = 9
        lblHighway.Text = "Highway Miles"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btnCalculate.Location = New Point(187, 565)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(160, 46)
        btnCalculate.TabIndex = 8
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' mnsMain
        ' 
        mnsMain.BackColor = Color.MistyRose
        mnsMain.Items.AddRange(New ToolStripItem() {mnsFile, mnsHelp})
        mnsMain.Location = New Point(0, 0)
        mnsMain.Name = "mnsMain"
        mnsMain.Size = New Size(534, 24)
        mnsMain.TabIndex = 7
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
        mnsExit.Size = New Size(180, 22)
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
        ' frmFuelCost
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(534, 631)
        Controls.Add(btnCalculate)
        Controls.Add(grpTravel)
        Controls.Add(grpInfo)
        Controls.Add(pnlGray)
        Controls.Add(pnlBlue)
        Controls.Add(mnsMain)
        Name = "frmFuelCost"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Yearly Fuel Cost"
        pnlBlue.ResumeLayout(False)
        pnlBlue.PerformLayout()
        grpInfo.ResumeLayout(False)
        grpInfo.PerformLayout()
        CType(nudHMPG, ComponentModel.ISupportInitialize).EndInit()
        CType(nudCMPG, ComponentModel.ISupportInitialize).EndInit()
        grpTravel.ResumeLayout(False)
        grpTravel.PerformLayout()
        CType(nudHMile, ComponentModel.ISupportInitialize).EndInit()
        CType(nudCMile, ComponentModel.ISupportInitialize).EndInit()
        mnsMain.ResumeLayout(False)
        mnsMain.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlGray As Panel
    Friend WithEvents pnlBlue As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents nudHMPG As NumericUpDown
    Friend WithEvents nudCMPG As NumericUpDown
    Friend WithEvents lblHMPG As Label
    Friend WithEvents lblCMPG As Label
    Friend WithEvents mtbYear As MaskedTextBox
    Friend WithEvents txtCar As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents lblMake As Label
    Friend WithEvents grpTravel As GroupBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents nudHMile As NumericUpDown
    Friend WithEvents nudCMile As NumericUpDown
    Friend WithEvents lblCity As Label
    Friend WithEvents lblHighway As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents mnsMain As MenuStrip
    Friend WithEvents mnsFile As ToolStripMenuItem
    Friend WithEvents mnsExit As ToolStripMenuItem
    Friend WithEvents mnsHelp As ToolStripMenuItem
    Friend WithEvents mnsAbout As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPrice As TextBox
End Class
