<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBestFuelEconomy
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
        grpCity = New GroupBox()
        lblCost = New Label()
        lblHMPG = New Label()
        lblCMPG = New Label()
        lblAverage = New Label()
        lblHighway = New Label()
        lblCity = New Label()
        pnlGray = New Panel()
        pnlBlue = New Panel()
        lblTitle = New Label()
        mnsMain = New MenuStrip()
        mnsFile = New ToolStripMenuItem()
        mnsExit = New ToolStripMenuItem()
        mnsHelp = New ToolStripMenuItem()
        mnsAbout = New ToolStripMenuItem()
        lblSelect = New Label()
        cmbVehicle = New ComboBox()
        grpCity.SuspendLayout()
        pnlBlue.SuspendLayout()
        mnsMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpCity
        ' 
        grpCity.Controls.Add(lblCost)
        grpCity.Controls.Add(lblHMPG)
        grpCity.Controls.Add(lblCMPG)
        grpCity.Controls.Add(lblAverage)
        grpCity.Controls.Add(lblHighway)
        grpCity.Controls.Add(lblCity)
        grpCity.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        grpCity.Location = New Point(62, 208)
        grpCity.Name = "grpCity"
        grpCity.Size = New Size(400, 200)
        grpCity.TabIndex = 16
        grpCity.TabStop = False
        grpCity.Text = "City"
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblCost.Location = New Point(36, 149)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(52, 20)
        lblCost.TabIndex = 8
        lblCost.Text = "$00.00"
        ' 
        ' lblHMPG
        ' 
        lblHMPG.AutoSize = True
        lblHMPG.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblHMPG.Location = New Point(183, 69)
        lblHMPG.Name = "lblHMPG"
        lblHMPG.Size = New Size(25, 20)
        lblHMPG.TabIndex = 7
        lblHMPG.Text = "00"
        ' 
        ' lblCMPG
        ' 
        lblCMPG.AutoSize = True
        lblCMPG.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblCMPG.Location = New Point(36, 69)
        lblCMPG.Name = "lblCMPG"
        lblCMPG.Size = New Size(25, 20)
        lblCMPG.TabIndex = 6
        lblCMPG.Text = "00"
        ' 
        ' lblAverage
        ' 
        lblAverage.AutoSize = True
        lblAverage.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblAverage.Location = New Point(24, 114)
        lblAverage.Name = "lblAverage"
        lblAverage.Size = New Size(184, 21)
        lblAverage.TabIndex = 5
        lblAverage.Text = "Average Cost Per Fill Up"
        ' 
        ' lblHighway
        ' 
        lblHighway.AutoSize = True
        lblHighway.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblHighway.Location = New Point(171, 38)
        lblHighway.Name = "lblHighway"
        lblHighway.Size = New Size(122, 21)
        lblHighway.TabIndex = 3
        lblHighway.Text = "MPG (Highway)"
        ' 
        ' lblCity
        ' 
        lblCity.AutoSize = True
        lblCity.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblCity.Location = New Point(24, 38)
        lblCity.Name = "lblCity"
        lblCity.Size = New Size(87, 21)
        lblCity.TabIndex = 0
        lblCity.Text = "MPG (City)"
        ' 
        ' pnlGray
        ' 
        pnlGray.BackColor = Color.Silver
        pnlGray.Location = New Point(0, 90)
        pnlGray.Name = "pnlGray"
        pnlGray.Size = New Size(547, 17)
        pnlGray.TabIndex = 15
        ' 
        ' pnlBlue
        ' 
        pnlBlue.BackColor = Color.MidnightBlue
        pnlBlue.Controls.Add(lblTitle)
        pnlBlue.Location = New Point(0, 24)
        pnlBlue.Name = "pnlBlue"
        pnlBlue.Size = New Size(550, 67)
        pnlBlue.TabIndex = 14
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.Transparent
        lblTitle.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.ForeColor = SystemColors.Window
        lblTitle.Location = New Point(10, 7)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(348, 50)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Best Fuel Economy"
        ' 
        ' mnsMain
        ' 
        mnsMain.BackColor = Color.MistyRose
        mnsMain.Items.AddRange(New ToolStripItem() {mnsFile, mnsHelp})
        mnsMain.Location = New Point(0, 0)
        mnsMain.Name = "mnsMain"
        mnsMain.Size = New Size(534, 24)
        mnsMain.TabIndex = 17
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
        ' lblSelect
        ' 
        lblSelect.AutoSize = True
        lblSelect.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblSelect.Location = New Point(62, 126)
        lblSelect.Name = "lblSelect"
        lblSelect.Size = New Size(146, 25)
        lblSelect.TabIndex = 18
        lblSelect.Text = "Select a Vehicle"
        ' 
        ' cmbVehicle
        ' 
        cmbVehicle.DropDownStyle = ComboBoxStyle.DropDownList
        cmbVehicle.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        cmbVehicle.FormattingEnabled = True
        cmbVehicle.Items.AddRange(New Object() {"Mitsubishi Mirage", "Hyundai Elantra", "Honda Civic", "Hyundai Accent", "Toyota Corolla Hatchback"})
        cmbVehicle.Location = New Point(75, 164)
        cmbVehicle.Name = "cmbVehicle"
        cmbVehicle.Size = New Size(260, 28)
        cmbVehicle.TabIndex = 19
        ' 
        ' frmBestFuelEconomy
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(534, 441)
        Controls.Add(cmbVehicle)
        Controls.Add(lblSelect)
        Controls.Add(grpCity)
        Controls.Add(pnlGray)
        Controls.Add(pnlBlue)
        Controls.Add(mnsMain)
        Name = "frmBestFuelEconomy"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Best Fuel Economy"
        grpCity.ResumeLayout(False)
        grpCity.PerformLayout()
        pnlBlue.ResumeLayout(False)
        pnlBlue.PerformLayout()
        mnsMain.ResumeLayout(False)
        mnsMain.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grpCity As GroupBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblHighway As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents pnlGray As Panel
    Friend WithEvents pnlBlue As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents mnsMain As MenuStrip
    Friend WithEvents mnsFile As ToolStripMenuItem
    Friend WithEvents mnsExit As ToolStripMenuItem
    Friend WithEvents mnsHelp As ToolStripMenuItem
    Friend WithEvents mnsAbout As ToolStripMenuItem
    Friend WithEvents lblSelect As Label
    Friend WithEvents cmbVehicle As ComboBox
    Friend WithEvents lblCost As Label
    Friend WithEvents lblHMPG As Label
    Friend WithEvents lblCMPG As Label
End Class
