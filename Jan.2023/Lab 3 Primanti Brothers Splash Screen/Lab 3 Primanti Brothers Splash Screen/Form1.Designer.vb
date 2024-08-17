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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblThanks = New System.Windows.Forms.Label()
        Me.picBig = New System.Windows.Forms.PictureBox()
        Me.picSmall = New System.Windows.Forms.PictureBox()
        Me.tmrFive = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picBig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSmall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblThanks
        '
        Me.lblThanks.AutoSize = True
        Me.lblThanks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThanks.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblThanks.Location = New System.Drawing.Point(199, 255)
        Me.lblThanks.Name = "lblThanks"
        Me.lblThanks.Size = New System.Drawing.Size(426, 36)
        Me.lblThanks.TabIndex = 0
        Me.lblThanks.Text = "Thank You For Your Business!"
        '
        'picBig
        '
        Me.picBig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBig.Image = CType(resources.GetObject("picBig.Image"), System.Drawing.Image)
        Me.picBig.Location = New System.Drawing.Point(35, 23)
        Me.picBig.Name = "picBig"
        Me.picBig.Size = New System.Drawing.Size(500, 220)
        Me.picBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBig.TabIndex = 1
        Me.picBig.TabStop = False
        '
        'picSmall
        '
        Me.picSmall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picSmall.Image = CType(resources.GetObject("picSmall.Image"), System.Drawing.Image)
        Me.picSmall.Location = New System.Drawing.Point(537, 308)
        Me.picSmall.Name = "picSmall"
        Me.picSmall.Size = New System.Drawing.Size(140, 70)
        Me.picSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSmall.TabIndex = 2
        Me.picSmall.TabStop = False
        '
        'tmrFive
        '
        Me.tmrFive.Enabled = True
        Me.tmrFive.Interval = 5000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.picSmall)
        Me.Controls.Add(Me.picBig)
        Me.Controls.Add(Me.lblThanks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab 3 – Primanti Brothers Splash Screen"
        CType(Me.picBig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSmall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblThanks As Label
    Friend WithEvents picBig As PictureBox
    Friend WithEvents picSmall As PictureBox
    Friend WithEvents tmrFive As Timer
End Class
