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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.pnlBorder = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picFoundation = New System.Windows.Forms.PictureBox()
        Me.lblThank = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlTitle.SuspendLayout()
        CType(Me.picFoundation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Gold
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.pnlTitle.ForeColor = System.Drawing.Color.Black
        Me.pnlTitle.Location = New System.Drawing.Point(-5, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(600, 80)
        Me.pnlTitle.TabIndex = 0
        Me.pnlTitle.Tag = ""
        '
        'pnlBorder
        '
        Me.pnlBorder.BackColor = System.Drawing.Color.Black
        Me.pnlBorder.Location = New System.Drawing.Point(-2, 80)
        Me.pnlBorder.Name = "pnlBorder"
        Me.pnlBorder.Size = New System.Drawing.Size(600, 20)
        Me.pnlBorder.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(47, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(278, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Mario Lemieux Foundation"
        '
        'picFoundation
        '
        Me.picFoundation.Image = CType(resources.GetObject("picFoundation.Image"), System.Drawing.Image)
        Me.picFoundation.Location = New System.Drawing.Point(54, 126)
        Me.picFoundation.Name = "picFoundation"
        Me.picFoundation.Size = New System.Drawing.Size(150, 150)
        Me.picFoundation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFoundation.TabIndex = 2
        Me.picFoundation.TabStop = False
        '
        'lblThank
        '
        Me.lblThank.AutoSize = True
        Me.lblThank.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblThank.ForeColor = System.Drawing.Color.Black
        Me.lblThank.Location = New System.Drawing.Point(256, 126)
        Me.lblThank.Name = "lblThank"
        Me.lblThank.Size = New System.Drawing.Size(270, 24)
        Me.lblThank.TabIndex = 3
        Me.lblThank.Text = "Thanks For Your Support!"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Silver
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(339, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 33)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 311)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblThank)
        Me.Controls.Add(Me.picFoundation)
        Me.Controls.Add(Me.pnlBorder)
        Me.Controls.Add(Me.pnlTitle)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab 2 – Mario Lemieux Foundation"
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        CType(Me.picFoundation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlBorder As Panel
    Friend WithEvents picFoundation As PictureBox
    Friend WithEvents lblThank As Label
    Friend WithEvents btnExit As Button
End Class
