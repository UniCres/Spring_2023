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
        Me.picTortoise = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.nudAge = New System.Windows.Forms.NumericUpDown()
        Me.btnNow = New System.Windows.Forms.Button()
        Me.btnOld = New System.Windows.Forms.Button()
        Me.btnYoung = New System.Windows.Forms.Button()
        Me.txtNow = New System.Windows.Forms.TextBox()
        Me.txtOld = New System.Windows.Forms.TextBox()
        Me.txtYoung = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picTortoise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTortoise
        '
        Me.picTortoise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTortoise.Image = CType(resources.GetObject("picTortoise.Image"), System.Drawing.Image)
        Me.picTortoise.Location = New System.Drawing.Point(37, 126)
        Me.picTortoise.Name = "picTortoise"
        Me.picTortoise.Size = New System.Drawing.Size(197, 158)
        Me.picTortoise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTortoise.TabIndex = 0
        Me.picTortoise.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Chiller", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(120, 38)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(363, 56)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Old Age Is A Comin!!"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Tempus Sans ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAge.Location = New System.Drawing.Point(263, 149)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(151, 24)
        Me.lblAge.TabIndex = 2
        Me.lblAge.Text = "Enter Your Age"
        '
        'nudAge
        '
        Me.nudAge.Location = New System.Drawing.Point(446, 149)
        Me.nudAge.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudAge.Name = "nudAge"
        Me.nudAge.Size = New System.Drawing.Size(100, 23)
        Me.nudAge.TabIndex = 3
        Me.nudAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNow
        '
        Me.btnNow.BackColor = System.Drawing.Color.PaleGreen
        Me.btnNow.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnNow.Location = New System.Drawing.Point(263, 218)
        Me.btnNow.Name = "btnNow"
        Me.btnNow.Size = New System.Drawing.Size(150, 51)
        Me.btnNow.TabIndex = 4
        Me.btnNow.Text = "My Age Now Is:"
        Me.btnNow.UseVisualStyleBackColor = False
        '
        'btnOld
        '
        Me.btnOld.BackColor = System.Drawing.Color.PaleGreen
        Me.btnOld.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOld.Location = New System.Drawing.Point(263, 294)
        Me.btnOld.Name = "btnOld"
        Me.btnOld.Size = New System.Drawing.Size(150, 51)
        Me.btnOld.TabIndex = 5
        Me.btnOld.Text = "My Age in 50 Years:"
        Me.btnOld.UseVisualStyleBackColor = False
        '
        'btnYoung
        '
        Me.btnYoung.BackColor = System.Drawing.Color.PaleGreen
        Me.btnYoung.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnYoung.Location = New System.Drawing.Point(263, 366)
        Me.btnYoung.Name = "btnYoung"
        Me.btnYoung.Size = New System.Drawing.Size(150, 51)
        Me.btnYoung.TabIndex = 6
        Me.btnYoung.Text = "My Age 10 Years Ago"
        Me.btnYoung.UseVisualStyleBackColor = False
        '
        'txtNow
        '
        Me.txtNow.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNow.Location = New System.Drawing.Point(446, 218)
        Me.txtNow.Multiline = True
        Me.txtNow.Name = "txtNow"
        Me.txtNow.ReadOnly = True
        Me.txtNow.Size = New System.Drawing.Size(100, 51)
        Me.txtNow.TabIndex = 7
        Me.txtNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOld
        '
        Me.txtOld.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtOld.Location = New System.Drawing.Point(446, 294)
        Me.txtOld.Multiline = True
        Me.txtOld.Name = "txtOld"
        Me.txtOld.ReadOnly = True
        Me.txtOld.Size = New System.Drawing.Size(100, 51)
        Me.txtOld.TabIndex = 8
        Me.txtOld.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtYoung
        '
        Me.txtYoung.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtYoung.Location = New System.Drawing.Point(446, 366)
        Me.txtYoung.Multiline = True
        Me.txtYoung.Name = "txtYoung"
        Me.txtYoung.ReadOnly = True
        Me.txtYoung.Size = New System.Drawing.Size(100, 51)
        Me.txtYoung.TabIndex = 9
        Me.txtYoung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.PaleGreen
        Me.btnExit.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(84, 366)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 51)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Get Me Outta Here!"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtYoung)
        Me.Controls.Add(Me.txtOld)
        Me.Controls.Add(Me.txtNow)
        Me.Controls.Add(Me.btnYoung)
        Me.Controls.Add(Me.btnOld)
        Me.Controls.Add(Me.btnNow)
        Me.Controls.Add(Me.nudAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picTortoise)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Old Age"
        CType(Me.picTortoise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picTortoise As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents nudAge As NumericUpDown
    Friend WithEvents btnNow As Button
    Friend WithEvents btnOld As Button
    Friend WithEvents btnYoung As Button
    Friend WithEvents txtNow As TextBox
    Friend WithEvents txtOld As TextBox
    Friend WithEvents txtYoung As TextBox
    Friend WithEvents btnExit As Button
End Class
