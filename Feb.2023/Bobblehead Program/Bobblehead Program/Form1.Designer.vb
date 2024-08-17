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
        Me.mnsMain = New System.Windows.Forms.MenuStrip()
        Me.mnsFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlBlue = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.nudPer = New System.Windows.Forms.NumericUpDown()
        Me.nudBox = New System.Windows.Forms.NumericUpDown()
        Me.lblPer = New System.Windows.Forms.Label()
        Me.lblBox = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblShip = New System.Windows.Forms.Label()
        Me.picBobblehead = New System.Windows.Forms.PictureBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.mnsMain.SuspendLayout()
        Me.pnlBlue.SuspendLayout()
        CType(Me.nudPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBobblehead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnsMain
        '
        Me.mnsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsFile, Me.mnsHelp})
        Me.mnsMain.Location = New System.Drawing.Point(0, 0)
        Me.mnsMain.Name = "mnsMain"
        Me.mnsMain.Size = New System.Drawing.Size(534, 24)
        Me.mnsMain.TabIndex = 0
        Me.mnsMain.Text = "MenuStrip1"
        '
        'mnsFile
        '
        Me.mnsFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsExit})
        Me.mnsFile.Name = "mnsFile"
        Me.mnsFile.Size = New System.Drawing.Size(37, 20)
        Me.mnsFile.Text = "File"
        '
        'mnsExit
        '
        Me.mnsExit.Name = "mnsExit"
        Me.mnsExit.Size = New System.Drawing.Size(93, 22)
        Me.mnsExit.Text = "Exit"
        '
        'mnsHelp
        '
        Me.mnsHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsAbout})
        Me.mnsHelp.Name = "mnsHelp"
        Me.mnsHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnsHelp.Text = "Help"
        '
        'mnsAbout
        '
        Me.mnsAbout.Name = "mnsAbout"
        Me.mnsAbout.Size = New System.Drawing.Size(180, 22)
        Me.mnsAbout.Text = "About"
        '
        'pnlBlue
        '
        Me.pnlBlue.BackColor = System.Drawing.Color.DarkBlue
        Me.pnlBlue.Controls.Add(Me.lblTitle)
        Me.pnlBlue.Location = New System.Drawing.Point(0, 27)
        Me.pnlBlue.Name = "pnlBlue"
        Me.pnlBlue.Size = New System.Drawing.Size(539, 82)
        Me.pnlBlue.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.Aqua
        Me.lblTitle.Location = New System.Drawing.Point(61, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(390, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Bobblehead Order Calculator"
        '
        'nudPer
        '
        Me.nudPer.Location = New System.Drawing.Point(40, 144)
        Me.nudPer.Name = "nudPer"
        Me.nudPer.Size = New System.Drawing.Size(75, 23)
        Me.nudPer.TabIndex = 2
        '
        'nudBox
        '
        Me.nudBox.Location = New System.Drawing.Point(40, 216)
        Me.nudBox.Name = "nudBox"
        Me.nudBox.Size = New System.Drawing.Size(75, 23)
        Me.nudBox.TabIndex = 3
        '
        'lblPer
        '
        Me.lblPer.AutoSize = True
        Me.lblPer.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPer.Location = New System.Drawing.Point(151, 137)
        Me.lblPer.Name = "lblPer"
        Me.lblPer.Size = New System.Drawing.Size(254, 32)
        Me.lblPer.TabIndex = 4
        Me.lblPer.Text = "Bobbleheads Per Box"
        '
        'lblBox
        '
        Me.lblBox.AutoSize = True
        Me.lblBox.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBox.Location = New System.Drawing.Point(151, 209)
        Me.lblBox.Name = "lblBox"
        Me.lblBox.Size = New System.Drawing.Size(182, 32)
        Me.lblBox.TabIndex = 5
        Me.lblBox.Text = "Boxes Ordered"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(172, 274)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(108, 36)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblShip
        '
        Me.lblShip.AutoSize = True
        Me.lblShip.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblShip.Location = New System.Drawing.Point(22, 340)
        Me.lblShip.Name = "lblShip"
        Me.lblShip.Size = New System.Drawing.Size(276, 30)
        Me.lblShip.TabIndex = 7
        Me.lblShip.Text = "Total Bobbleheads to Ship:"
        '
        'picBobblehead
        '
        Me.picBobblehead.Image = CType(resources.GetObject("picBobblehead.Image"), System.Drawing.Image)
        Me.picBobblehead.Location = New System.Drawing.Point(388, 183)
        Me.picBobblehead.Name = "picBobblehead"
        Me.picBobblehead.Size = New System.Drawing.Size(121, 207)
        Me.picBobblehead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBobblehead.TabIndex = 8
        Me.picBobblehead.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.Location = New System.Drawing.Point(298, 340)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 30)
        Me.lblTotal.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 411)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.picBobblehead)
        Me.Controls.Add(Me.lblShip)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblBox)
        Me.Controls.Add(Me.lblPer)
        Me.Controls.Add(Me.nudBox)
        Me.Controls.Add(Me.nudPer)
        Me.Controls.Add(Me.pnlBlue)
        Me.Controls.Add(Me.mnsMain)
        Me.MainMenuStrip = Me.mnsMain
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bobblehead Shipping Program"
        Me.mnsMain.ResumeLayout(False)
        Me.mnsMain.PerformLayout()
        Me.pnlBlue.ResumeLayout(False)
        Me.pnlBlue.PerformLayout()
        CType(Me.nudPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBobblehead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnsMain As MenuStrip
    Friend WithEvents mnsFile As ToolStripMenuItem
    Friend WithEvents mnsExit As ToolStripMenuItem
    Friend WithEvents mnsHelp As ToolStripMenuItem
    Friend WithEvents mnsAbout As ToolStripMenuItem
    Friend WithEvents pnlBlue As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents nudPer As NumericUpDown
    Friend WithEvents nudBox As NumericUpDown
    Friend WithEvents lblPer As Label
    Friend WithEvents lblBox As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblShip As Label
    Friend WithEvents picBobblehead As PictureBox
    Friend WithEvents lblTotal As Label
End Class
