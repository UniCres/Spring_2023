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
        Me.picFrame = New System.Windows.Forms.PictureBox()
        Me.btnBatman = New System.Windows.Forms.Button()
        Me.btnRobin = New System.Windows.Forms.Button()
        Me.picQuit = New System.Windows.Forms.PictureBox()
        Me.picDuo = New System.Windows.Forms.PictureBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.picDorthy = New System.Windows.Forms.PictureBox()
        Me.lblSmile = New System.Windows.Forms.Label()
        Me.txtKansas = New System.Windows.Forms.TextBox()
        Me.lblToto = New System.Windows.Forms.Label()
        Me.lblAnymore = New System.Windows.Forms.Label()
        CType(Me.picFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQuit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDuo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDorthy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFrame
        '
        Me.picFrame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picFrame.Location = New System.Drawing.Point(29, 12)
        Me.picFrame.Name = "picFrame"
        Me.picFrame.Size = New System.Drawing.Size(741, 405)
        Me.picFrame.TabIndex = 0
        Me.picFrame.TabStop = False
        '
        'btnBatman
        '
        Me.btnBatman.BackColor = System.Drawing.Color.Red
        Me.btnBatman.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBatman.ForeColor = System.Drawing.Color.White
        Me.btnBatman.Location = New System.Drawing.Point(63, 36)
        Me.btnBatman.Name = "btnBatman"
        Me.btnBatman.Size = New System.Drawing.Size(120, 50)
        Me.btnBatman.TabIndex = 1
        Me.btnBatman.Text = "Batman"
        Me.btnBatman.UseVisualStyleBackColor = False
        '
        'btnRobin
        '
        Me.btnRobin.BackColor = System.Drawing.Color.ForestGreen
        Me.btnRobin.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRobin.ForeColor = System.Drawing.Color.White
        Me.btnRobin.Location = New System.Drawing.Point(63, 113)
        Me.btnRobin.Name = "btnRobin"
        Me.btnRobin.Size = New System.Drawing.Size(120, 50)
        Me.btnRobin.TabIndex = 2
        Me.btnRobin.Text = "Robin"
        Me.btnRobin.UseVisualStyleBackColor = False
        '
        'picQuit
        '
        Me.picQuit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picQuit.Location = New System.Drawing.Point(509, 273)
        Me.picQuit.Name = "picQuit"
        Me.picQuit.Size = New System.Drawing.Size(194, 108)
        Me.picQuit.TabIndex = 3
        Me.picQuit.TabStop = False
        '
        'picDuo
        '
        Me.picDuo.Image = CType(resources.GetObject("picDuo.Image"), System.Drawing.Image)
        Me.picDuo.Location = New System.Drawing.Point(261, 36)
        Me.picDuo.Name = "picDuo"
        Me.picDuo.Size = New System.Drawing.Size(266, 148)
        Me.picDuo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDuo.TabIndex = 4
        Me.picDuo.TabStop = False
        Me.picDuo.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Red
        Me.btnQuit.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnQuit.ForeColor = System.Drawing.Color.Yellow
        Me.btnQuit.Location = New System.Drawing.Point(530, 284)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(157, 83)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "I wanna Quit NOW !!"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'picDorthy
        '
        Me.picDorthy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDorthy.Image = CType(resources.GetObject("picDorthy.Image"), System.Drawing.Image)
        Me.picDorthy.Location = New System.Drawing.Point(96, 260)
        Me.picDorthy.Name = "picDorthy"
        Me.picDorthy.Size = New System.Drawing.Size(164, 122)
        Me.picDorthy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDorthy.TabIndex = 6
        Me.picDorthy.TabStop = False
        Me.picDorthy.Visible = False
        '
        'lblSmile
        '
        Me.lblSmile.AutoSize = True
        Me.lblSmile.Font = New System.Drawing.Font("Wingdings", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSmile.ForeColor = System.Drawing.Color.Red
        Me.lblSmile.Location = New System.Drawing.Point(575, 68)
        Me.lblSmile.Name = "lblSmile"
        Me.lblSmile.Size = New System.Drawing.Size(126, 106)
        Me.lblSmile.TabIndex = 7
        Me.lblSmile.Text = "J"
        '
        'txtKansas
        '
        Me.txtKansas.BackColor = System.Drawing.Color.Red
        Me.txtKansas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKansas.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.txtKansas.ForeColor = System.Drawing.Color.Navy
        Me.txtKansas.Location = New System.Drawing.Point(390, 199)
        Me.txtKansas.Name = "txtKansas"
        Me.txtKansas.Size = New System.Drawing.Size(224, 56)
        Me.txtKansas.TabIndex = 8
        Me.txtKansas.Text = "Kansas"
        Me.txtKansas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblToto
        '
        Me.lblToto.AutoSize = True
        Me.lblToto.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblToto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblToto.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblToto.ForeColor = System.Drawing.Color.Red
        Me.lblToto.Location = New System.Drawing.Point(44, 213)
        Me.lblToto.Name = "lblToto"
        Me.lblToto.Size = New System.Drawing.Size(337, 36)
        Me.lblToto.TabIndex = 9
        Me.lblToto.Text = "Toto, I don't think were in"
        '
        'lblAnymore
        '
        Me.lblAnymore.AutoSize = True
        Me.lblAnymore.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblAnymore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnymore.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblAnymore.ForeColor = System.Drawing.Color.Red
        Me.lblAnymore.Location = New System.Drawing.Point(620, 213)
        Me.lblAnymore.Name = "lblAnymore"
        Me.lblAnymore.Size = New System.Drawing.Size(124, 36)
        Me.lblAnymore.TabIndex = 10
        Me.lblAnymore.Text = "Anymore!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAnymore)
        Me.Controls.Add(Me.lblToto)
        Me.Controls.Add(Me.txtKansas)
        Me.Controls.Add(Me.lblSmile)
        Me.Controls.Add(Me.picDorthy)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.picDuo)
        Me.Controls.Add(Me.picQuit)
        Me.Controls.Add(Me.btnRobin)
        Me.Controls.Add(Me.btnBatman)
        Me.Controls.Add(Me.picFrame)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dynamic Duo vs Dorthy"
        CType(Me.picFrame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQuit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDuo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDorthy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFrame As PictureBox
    Friend WithEvents btnBatman As Button
    Friend WithEvents btnRobin As Button
    Friend WithEvents picQuit As PictureBox
    Friend WithEvents picDuo As PictureBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents picDorthy As PictureBox
    Friend WithEvents lblSmile As Label
    Friend WithEvents txtKansas As TextBox
    Friend WithEvents lblToto As Label
    Friend WithEvents lblAnymore As Label
End Class
