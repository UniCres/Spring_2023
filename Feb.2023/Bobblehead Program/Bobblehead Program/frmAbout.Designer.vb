<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.mnsMain = New System.Windows.Forms.MenuStrip()
        Me.mnsExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCreated = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.mnsMain.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnsMain
        '
        Me.mnsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsExit})
        Me.mnsMain.Location = New System.Drawing.Point(0, 0)
        Me.mnsMain.Name = "mnsMain"
        Me.mnsMain.Size = New System.Drawing.Size(484, 24)
        Me.mnsMain.TabIndex = 0
        Me.mnsMain.Text = "MenuStrip1"
        '
        'mnsExit
        '
        Me.mnsExit.Name = "mnsExit"
        Me.mnsExit.Size = New System.Drawing.Size(38, 20)
        Me.mnsExit.Text = "Exit"
        '
        'lblCreated
        '
        Me.lblCreated.AutoSize = True
        Me.lblCreated.Font = New System.Drawing.Font("Castellar", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCreated.Location = New System.Drawing.Point(32, 49)
        Me.lblCreated.Name = "lblCreated"
        Me.lblCreated.Size = New System.Drawing.Size(199, 29)
        Me.lblCreated.TabIndex = 1
        Me.lblCreated.Text = "Created by:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Castellar", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(261, 77)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(192, 29)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Shiyu Chen"
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.YellowGreen
        Me.btnHide.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHide.Location = New System.Drawing.Point(289, 154)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(133, 49)
        Me.btnHide.TabIndex = 5
        Me.btnHide.Text = "Hide Picture"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.YellowGreen
        Me.btnShow.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnShow.Location = New System.Drawing.Point(289, 242)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(133, 49)
        Me.btnShow.TabIndex = 6
        Me.btnShow.Text = "Show Picture"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'picProfile
        '
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picProfile.Image = CType(resources.GetObject("picProfile.Image"), System.Drawing.Image)
        Me.picProfile.Location = New System.Drawing.Point(32, 123)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(199, 195)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 7
        Me.picProfile.TabStop = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCreated)
        Me.Controls.Add(Me.mnsMain)
        Me.MainMenuStrip = Me.mnsMain
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.mnsMain.ResumeLayout(False)
        Me.mnsMain.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnsMain As MenuStrip
    Friend WithEvents mnsExit As ToolStripMenuItem
    Friend WithEvents lblCreated As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnHide As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents picProfile As PictureBox
End Class
