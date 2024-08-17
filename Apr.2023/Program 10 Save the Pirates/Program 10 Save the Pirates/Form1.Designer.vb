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
        Me.pnlBlack = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picPirate = New System.Windows.Forms.PictureBox()
        Me.pnlRed = New System.Windows.Forms.Panel()
        Me.pnlYellow = New System.Windows.Forms.Panel()
        Me.picBaseballField = New System.Windows.Forms.PictureBox()
        Me.picPirates = New System.Windows.Forms.PictureBox()
        Me.lblClick = New System.Windows.Forms.Label()
        Me.lblLO = New System.Windows.Forms.Label()
        Me.lblRO = New System.Windows.Forms.Label()
        Me.lblCen = New System.Windows.Forms.Label()
        Me.lblSS = New System.Windows.Forms.Label()
        Me.lblSB = New System.Windows.Forms.Label()
        Me.lblTB = New System.Windows.Forms.Label()
        Me.lblFB = New System.Windows.Forms.Label()
        Me.lblPit = New System.Windows.Forms.Label()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.pnlBlack.SuspendLayout()
        CType(Me.picPirate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBaseballField, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPirates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBlack
        '
        Me.pnlBlack.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pnlBlack.Controls.Add(Me.lblTitle)
        Me.pnlBlack.Controls.Add(Me.picPirate)
        Me.pnlBlack.Location = New System.Drawing.Point(0, 0)
        Me.pnlBlack.Name = "pnlBlack"
        Me.pnlBlack.Size = New System.Drawing.Size(735, 99)
        Me.pnlBlack.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Comic Sans MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.Moccasin
        Me.lblTitle.Location = New System.Drawing.Point(153, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(500, 49)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Save the Pirates! Vote Now!"
        '
        'picPirate
        '
        Me.picPirate.Image = CType(resources.GetObject("picPirate.Image"), System.Drawing.Image)
        Me.picPirate.Location = New System.Drawing.Point(-6, 0)
        Me.picPirate.Name = "picPirate"
        Me.picPirate.Size = New System.Drawing.Size(155, 99)
        Me.picPirate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPirate.TabIndex = 0
        Me.picPirate.TabStop = False
        '
        'pnlRed
        '
        Me.pnlRed.BackColor = System.Drawing.Color.Firebrick
        Me.pnlRed.Location = New System.Drawing.Point(0, 99)
        Me.pnlRed.Name = "pnlRed"
        Me.pnlRed.Size = New System.Drawing.Size(732, 14)
        Me.pnlRed.TabIndex = 1
        '
        'pnlYellow
        '
        Me.pnlYellow.BackColor = System.Drawing.Color.Chartreuse
        Me.pnlYellow.Location = New System.Drawing.Point(0, 113)
        Me.pnlYellow.Name = "pnlYellow"
        Me.pnlYellow.Size = New System.Drawing.Size(735, 15)
        Me.pnlYellow.TabIndex = 2
        '
        'picBaseballField
        '
        Me.picBaseballField.Image = CType(resources.GetObject("picBaseballField.Image"), System.Drawing.Image)
        Me.picBaseballField.Location = New System.Drawing.Point(283, 217)
        Me.picBaseballField.Name = "picBaseballField"
        Me.picBaseballField.Size = New System.Drawing.Size(363, 240)
        Me.picBaseballField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBaseballField.TabIndex = 3
        Me.picBaseballField.TabStop = False
        '
        'picPirates
        '
        Me.picPirates.Image = CType(resources.GetObject("picPirates.Image"), System.Drawing.Image)
        Me.picPirates.Location = New System.Drawing.Point(1, 173)
        Me.picPirates.Name = "picPirates"
        Me.picPirates.Size = New System.Drawing.Size(218, 357)
        Me.picPirates.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPirates.TabIndex = 4
        Me.picPirates.TabStop = False
        '
        'lblClick
        '
        Me.lblClick.AutoSize = True
        Me.lblClick.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblClick.ForeColor = System.Drawing.Color.Chocolate
        Me.lblClick.Location = New System.Drawing.Point(65, 136)
        Me.lblClick.Name = "lblClick"
        Me.lblClick.Size = New System.Drawing.Size(605, 27)
        Me.lblClick.TabIndex = 2
        Me.lblClick.Text = "Click on a Current Player to Add Your Free Agent Replacement!"
        '
        'lblLO
        '
        Me.lblLO.AutoSize = True
        Me.lblLO.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLO.ForeColor = System.Drawing.Color.Black
        Me.lblLO.Location = New System.Drawing.Point(267, 188)
        Me.lblLO.Name = "lblLO"
        Me.lblLO.Size = New System.Drawing.Size(123, 21)
        Me.lblLO.TabIndex = 5
        Me.lblLO.Text = "Left Outfielder"
        '
        'lblRO
        '
        Me.lblRO.AutoSize = True
        Me.lblRO.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRO.ForeColor = System.Drawing.Color.Black
        Me.lblRO.Location = New System.Drawing.Point(561, 188)
        Me.lblRO.Name = "lblRO"
        Me.lblRO.Size = New System.Drawing.Size(130, 21)
        Me.lblRO.TabIndex = 6
        Me.lblRO.Text = "Right Outfielder"
        '
        'lblCen
        '
        Me.lblCen.AutoSize = True
        Me.lblCen.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCen.ForeColor = System.Drawing.Color.Black
        Me.lblCen.Location = New System.Drawing.Point(441, 196)
        Me.lblCen.Name = "lblCen"
        Me.lblCen.Size = New System.Drawing.Size(57, 21)
        Me.lblCen.TabIndex = 7
        Me.lblCen.Text = "Center"
        '
        'lblSS
        '
        Me.lblSS.AutoSize = True
        Me.lblSS.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSS.ForeColor = System.Drawing.Color.Black
        Me.lblSS.Location = New System.Drawing.Point(277, 257)
        Me.lblSS.Name = "lblSS"
        Me.lblSS.Size = New System.Drawing.Size(91, 21)
        Me.lblSS.TabIndex = 8
        Me.lblSS.Text = "Short Stop"
        '
        'lblSB
        '
        Me.lblSB.AutoSize = True
        Me.lblSB.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSB.ForeColor = System.Drawing.Color.Black
        Me.lblSB.Location = New System.Drawing.Point(579, 257)
        Me.lblSB.Name = "lblSB"
        Me.lblSB.Size = New System.Drawing.Size(128, 21)
        Me.lblSB.TabIndex = 9
        Me.lblSB.Text = "Second Baseman"
        '
        'lblTB
        '
        Me.lblTB.AutoSize = True
        Me.lblTB.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTB.ForeColor = System.Drawing.Color.Black
        Me.lblTB.Location = New System.Drawing.Point(266, 357)
        Me.lblTB.Name = "lblTB"
        Me.lblTB.Size = New System.Drawing.Size(116, 21)
        Me.lblTB.TabIndex = 10
        Me.lblTB.Text = "Third Baseman"
        '
        'lblFB
        '
        Me.lblFB.AutoSize = True
        Me.lblFB.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFB.ForeColor = System.Drawing.Color.Black
        Me.lblFB.Location = New System.Drawing.Point(594, 338)
        Me.lblFB.Name = "lblFB"
        Me.lblFB.Size = New System.Drawing.Size(111, 21)
        Me.lblFB.TabIndex = 11
        Me.lblFB.Text = "First Baseman"
        '
        'lblPit
        '
        Me.lblPit.AutoSize = True
        Me.lblPit.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPit.ForeColor = System.Drawing.Color.Black
        Me.lblPit.Location = New System.Drawing.Point(441, 333)
        Me.lblPit.Name = "lblPit"
        Me.lblPit.Size = New System.Drawing.Size(61, 21)
        Me.lblPit.TabIndex = 12
        Me.lblPit.Text = "Pitcher"
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCat.ForeColor = System.Drawing.Color.Black
        Me.lblCat.Location = New System.Drawing.Point(441, 452)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(66, 21)
        Me.lblCat.TabIndex = 13
        Me.lblCat.Text = "Catcher"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSubmit.Location = New System.Drawing.Point(552, 463)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(166, 48)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "Submit Lineup"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(732, 523)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblCat)
        Me.Controls.Add(Me.lblPit)
        Me.Controls.Add(Me.lblFB)
        Me.Controls.Add(Me.lblTB)
        Me.Controls.Add(Me.lblSB)
        Me.Controls.Add(Me.lblSS)
        Me.Controls.Add(Me.lblCen)
        Me.Controls.Add(Me.lblRO)
        Me.Controls.Add(Me.lblLO)
        Me.Controls.Add(Me.lblClick)
        Me.Controls.Add(Me.picPirates)
        Me.Controls.Add(Me.picBaseballField)
        Me.Controls.Add(Me.pnlYellow)
        Me.Controls.Add(Me.pnlRed)
        Me.Controls.Add(Me.pnlBlack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dream Pirate Lineup"
        Me.pnlBlack.ResumeLayout(False)
        Me.pnlBlack.PerformLayout()
        CType(Me.picPirate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBaseballField, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPirates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlBlack As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents picPirate As PictureBox
    Friend WithEvents pnlRed As Panel
    Friend WithEvents pnlYellow As Panel
    Friend WithEvents picBaseballField As PictureBox
    Friend WithEvents picPirates As PictureBox
    Friend WithEvents lblClick As Label
    Friend WithEvents lblLO As Label
    Friend WithEvents lblRO As Label
    Friend WithEvents lblCen As Label
    Friend WithEvents lblSS As Label
    Friend WithEvents lblSB As Label
    Friend WithEvents lblTB As Label
    Friend WithEvents lblFB As Label
    Friend WithEvents lblPit As Label
    Friend WithEvents lblCat As Label
    Friend WithEvents btnSubmit As Button
End Class
