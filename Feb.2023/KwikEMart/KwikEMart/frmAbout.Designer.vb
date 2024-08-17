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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblCreated = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.mnsAbout = New System.Windows.Forms.MenuStrip()
        Me.mnsExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.mnsAbout.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCreated
        '
        Me.lblCreated.AutoSize = True
        Me.lblCreated.Font = New System.Drawing.Font("Castellar", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCreated.Location = New System.Drawing.Point(47, 50)
        Me.lblCreated.Name = "lblCreated"
        Me.lblCreated.Size = New System.Drawing.Size(199, 29)
        Me.lblCreated.TabIndex = 0
        Me.lblCreated.Text = "Created by:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Castellar", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(252, 79)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(192, 29)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Shiyu Chen"
        '
        'mnsAbout
        '
        Me.mnsAbout.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsExit})
        Me.mnsAbout.Location = New System.Drawing.Point(0, 0)
        Me.mnsAbout.Name = "mnsAbout"
        Me.mnsAbout.Size = New System.Drawing.Size(484, 24)
        Me.mnsAbout.TabIndex = 2
        Me.mnsAbout.Text = "MenuStrip1"
        '
        'mnsExit
        '
        Me.mnsExit.Name = "mnsExit"
        Me.mnsExit.Size = New System.Drawing.Size(38, 20)
        Me.mnsExit.Text = "Exit"
        '
        'picProfile
        '
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picProfile.Image = CType(resources.GetObject("picProfile.Image"), System.Drawing.Image)
        Me.picProfile.Location = New System.Drawing.Point(47, 132)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(199, 195)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 3
        Me.picProfile.TabStop = False
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.YellowGreen
        Me.btnHide.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHide.Location = New System.Drawing.Point(292, 146)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(133, 49)
        Me.btnHide.TabIndex = 4
        Me.btnHide.Text = "Hide Picture"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.YellowGreen
        Me.btnShow.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnShow.Location = New System.Drawing.Point(292, 263)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(133, 49)
        Me.btnShow.TabIndex = 5
        Me.btnShow.Text = "Show Picture"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnExit.Location = New System.Drawing.Point(313, 208)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 39)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCreated)
        Me.Controls.Add(Me.mnsAbout)
        Me.MainMenuStrip = Me.mnsAbout
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.mnsAbout.ResumeLayout(False)
        Me.mnsAbout.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
