<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlBlue = New Panel()
        lblTitle = New Label()
        pnlGray = New Panel()
        lblOption = New Label()
        btnYFC = New Button()
        btnTFE = New Button()
        mnsMain = New MenuStrip()
        mnsFile = New ToolStripMenuItem()
        mnsExit = New ToolStripMenuItem()
        mnsHelp = New ToolStripMenuItem()
        mnsAbout = New ToolStripMenuItem()
        pnlBlue.SuspendLayout()
        mnsMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlBlue
        ' 
        pnlBlue.BackColor = Color.MidnightBlue
        pnlBlue.Controls.Add(lblTitle)
        pnlBlue.Location = New Point(0, 24)
        pnlBlue.Name = "pnlBlue"
        pnlBlue.Size = New Size(534, 67)
        pnlBlue.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(10, 5)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(377, 50)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Gas Milage Program"
        ' 
        ' pnlGray
        ' 
        pnlGray.BackColor = Color.Silver
        pnlGray.Location = New Point(0, 91)
        pnlGray.Name = "pnlGray"
        pnlGray.Size = New Size(534, 17)
        pnlGray.TabIndex = 1
        ' 
        ' lblOption
        ' 
        lblOption.AutoSize = True
        lblOption.Font = New Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lblOption.Location = New Point(126, 125)
        lblOption.Name = "lblOption"
        lblOption.Size = New Size(289, 30)
        lblOption.TabIndex = 2
        lblOption.Text = "Please Choose An Option Below"
        ' 
        ' btnYFC
        ' 
        btnYFC.Font = New Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btnYFC.Location = New Point(163, 173)
        btnYFC.Name = "btnYFC"
        btnYFC.Size = New Size(208, 49)
        btnYFC.TabIndex = 3
        btnYFC.Text = "Yearly Fuel Cost"
        btnYFC.UseVisualStyleBackColor = True
        ' 
        ' btnTFE
        ' 
        btnTFE.Font = New Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btnTFE.Location = New Point(163, 239)
        btnTFE.Name = "btnTFE"
        btnTFE.Size = New Size(208, 49)
        btnTFE.TabIndex = 4
        btnTFE.Text = "Top Fuel Economy"
        btnTFE.UseVisualStyleBackColor = True
        ' 
        ' mnsMain
        ' 
        mnsMain.BackColor = Color.MistyRose
        mnsMain.Items.AddRange(New ToolStripItem() {mnsFile, mnsHelp})
        mnsMain.Location = New Point(0, 0)
        mnsMain.Name = "mnsMain"
        mnsMain.Size = New Size(534, 24)
        mnsMain.TabIndex = 5
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
        mnsAbout.Size = New Size(180, 22)
        mnsAbout.Text = "About"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(534, 314)
        Controls.Add(mnsMain)
        Controls.Add(btnTFE)
        Controls.Add(btnYFC)
        Controls.Add(lblOption)
        Controls.Add(pnlGray)
        Controls.Add(pnlBlue)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gas Milage Program"
        pnlBlue.ResumeLayout(False)
        pnlBlue.PerformLayout()
        mnsMain.ResumeLayout(False)
        mnsMain.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlBlue As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlGray As Panel
    Friend WithEvents lblOption As Label
    Friend WithEvents btnYFC As Button
    Friend WithEvents btnTFE As Button
    Friend WithEvents mnsMain As MenuStrip
    Friend WithEvents mnsFile As ToolStripMenuItem
    Friend WithEvents mnsExit As ToolStripMenuItem
    Friend WithEvents mnsHelp As ToolStripMenuItem
    Friend WithEvents mnsAbout As ToolStripMenuItem
End Class
