<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAbout
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAbout))
        lblCreated = New Label()
        lblName = New Label()
        mnsAbout = New MenuStrip()
        mnsExit = New ToolStripMenuItem()
        picProfile = New PictureBox()
        btnHide = New Button()
        btnShow = New Button()
        btnExit = New Button()
        mnsAbout.SuspendLayout()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblCreated
        ' 
        lblCreated.AutoSize = True
        lblCreated.Font = New Font("Castellar", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblCreated.Location = New Point(47, 50)
        lblCreated.Name = "lblCreated"
        lblCreated.Size = New Size(199, 29)
        lblCreated.TabIndex = 0
        lblCreated.Text = "Created by:"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Castellar", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblName.Location = New Point(252, 79)
        lblName.Name = "lblName"
        lblName.Size = New Size(192, 29)
        lblName.TabIndex = 1
        lblName.Text = "Shiyu Chen"
        ' 
        ' mnsAbout
        ' 
        mnsAbout.BackColor = Color.MistyRose
        mnsAbout.Items.AddRange(New ToolStripItem() {mnsExit})
        mnsAbout.Location = New Point(0, 0)
        mnsAbout.Name = "mnsAbout"
        mnsAbout.Size = New Size(484, 24)
        mnsAbout.TabIndex = 2
        mnsAbout.Text = "MenuStrip1"
        ' 
        ' mnsExit
        ' 
        mnsExit.Name = "mnsExit"
        mnsExit.Size = New Size(38, 20)
        mnsExit.Text = "Exit"
        ' 
        ' picProfile
        ' 
        picProfile.BorderStyle = BorderStyle.Fixed3D
        picProfile.Image = CType(resources.GetObject("picProfile.Image"), Image)
        picProfile.Location = New Point(47, 132)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(199, 195)
        picProfile.SizeMode = PictureBoxSizeMode.Zoom
        picProfile.TabIndex = 3
        picProfile.TabStop = False
        ' 
        ' btnHide
        ' 
        btnHide.BackColor = Color.YellowGreen
        btnHide.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnHide.Location = New Point(292, 146)
        btnHide.Name = "btnHide"
        btnHide.Size = New Size(133, 49)
        btnHide.TabIndex = 4
        btnHide.Text = "Hide Picture"
        btnHide.UseVisualStyleBackColor = False
        ' 
        ' btnShow
        ' 
        btnShow.BackColor = Color.YellowGreen
        btnShow.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnShow.Location = New Point(292, 263)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(133, 49)
        btnShow.TabIndex = 5
        btnShow.Text = "Show Picture"
        btnShow.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Red
        btnExit.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.ForeColor = Color.AliceBlue
        btnExit.Location = New Point(313, 208)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(88, 39)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' frmAbout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSeaGreen
        ClientSize = New Size(484, 361)
        Controls.Add(btnExit)
        Controls.Add(btnShow)
        Controls.Add(btnHide)
        Controls.Add(picProfile)
        Controls.Add(lblName)
        Controls.Add(lblCreated)
        Controls.Add(mnsAbout)
        MainMenuStrip = mnsAbout
        Name = "frmAbout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "About"
        mnsAbout.ResumeLayout(False)
        mnsAbout.PerformLayout()
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCreated As Label
    Friend WithEvents lblName As Label
    Friend WithEvents mnsAbout As MenuStrip
    Friend WithEvents mnsExit As ToolStripMenuItem
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents btnHide As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents btnExit As Button
End Class
