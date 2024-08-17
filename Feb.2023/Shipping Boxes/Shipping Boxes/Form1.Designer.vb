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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.mnsMain = New System.Windows.Forms.MenuStrip()
        Me.mnsFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.nudItems = New System.Windows.Forms.NumericUpDown()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picUPS = New System.Windows.Forms.PictureBox()
        Me.txtLarge = New System.Windows.Forms.TextBox()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblLarge = New System.Windows.Forms.Label()
        Me.lblMedium = New System.Windows.Forms.Label()
        Me.lblSmall = New System.Windows.Forms.Label()
        Me.lblIndividual = New System.Windows.Forms.Label()
        Me.lblThanks = New System.Windows.Forms.Label()
        Me.txtMedium = New System.Windows.Forms.TextBox()
        Me.txtSmall = New System.Windows.Forms.TextBox()
        Me.txtIndividual = New System.Windows.Forms.TextBox()
        Me.mnsMain.SuspendLayout()
        CType(Me.nudItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUPS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(183, 168)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(115, 36)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'mnsMain
        '
        Me.mnsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsFile, Me.mnsHelp})
        Me.mnsMain.Location = New System.Drawing.Point(0, 0)
        Me.mnsMain.Name = "mnsMain"
        Me.mnsMain.Size = New System.Drawing.Size(484, 24)
        Me.mnsMain.TabIndex = 1
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
        Me.mnsAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnsAbout.Text = "About"
        '
        'nudItems
        '
        Me.nudItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudItems.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.nudItems.Location = New System.Drawing.Point(236, 106)
        Me.nudItems.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.nudItems.Name = "nudItems"
        Me.nudItems.Size = New System.Drawing.Size(106, 29)
        Me.nudItems.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Rockwell", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(102, 47)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(221, 36)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "We Ship Boxes"
        '
        'picUPS
        '
        Me.picUPS.Image = CType(resources.GetObject("picUPS.Image"), System.Drawing.Image)
        Me.picUPS.Location = New System.Drawing.Point(363, 47)
        Me.picUPS.Name = "picUPS"
        Me.picUPS.Size = New System.Drawing.Size(109, 124)
        Me.picUPS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUPS.TabIndex = 4
        Me.picUPS.TabStop = False
        '
        'txtLarge
        '
        Me.txtLarge.Enabled = False
        Me.txtLarge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLarge.Location = New System.Drawing.Point(301, 280)
        Me.txtLarge.Name = "txtLarge"
        Me.txtLarge.ReadOnly = True
        Me.txtLarge.Size = New System.Drawing.Size(96, 29)
        Me.txtLarge.TabIndex = 5
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblItems.Location = New System.Drawing.Point(39, 108)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(181, 21)
        Me.lblItems.TabIndex = 6
        Me.lblItems.Text = "Number of Items to Ship"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.Location = New System.Drawing.Point(74, 226)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(332, 25)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total Number of Boxes You Will Need"
        '
        'lblLarge
        '
        Me.lblLarge.AutoSize = True
        Me.lblLarge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLarge.Location = New System.Drawing.Point(78, 280)
        Me.lblLarge.Name = "lblLarge"
        Me.lblLarge.Size = New System.Drawing.Size(164, 21)
        Me.lblLarge.TabIndex = 8
        Me.lblLarge.Text = "Large Box <50 items>"
        '
        'lblMedium
        '
        Me.lblMedium.AutoSize = True
        Me.lblMedium.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMedium.Location = New System.Drawing.Point(78, 327)
        Me.lblMedium.Name = "lblMedium"
        Me.lblMedium.Size = New System.Drawing.Size(183, 21)
        Me.lblMedium.TabIndex = 9
        Me.lblMedium.Text = "Medium Box <30 items>"
        '
        'lblSmall
        '
        Me.lblSmall.AutoSize = True
        Me.lblSmall.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSmall.Location = New System.Drawing.Point(78, 372)
        Me.lblSmall.Name = "lblSmall"
        Me.lblSmall.Size = New System.Drawing.Size(164, 21)
        Me.lblSmall.TabIndex = 10
        Me.lblSmall.Text = "Small Box <10 items>"
        '
        'lblIndividual
        '
        Me.lblIndividual.AutoSize = True
        Me.lblIndividual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblIndividual.Location = New System.Drawing.Point(78, 418)
        Me.lblIndividual.Name = "lblIndividual"
        Me.lblIndividual.Size = New System.Drawing.Size(184, 21)
        Me.lblIndividual.TabIndex = 11
        Me.lblIndividual.Text = "Individual Box <1 items>"
        '
        'lblThanks
        '
        Me.lblThanks.AutoSize = True
        Me.lblThanks.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblThanks.Location = New System.Drawing.Point(30, 460)
        Me.lblThanks.Name = "lblThanks"
        Me.lblThanks.Size = New System.Drawing.Size(421, 33)
        Me.lblThanks.TabIndex = 12
        Me.lblThanks.Text = "Thanks For Shipping With Us!!"
        Me.lblThanks.Visible = False
        '
        'txtMedium
        '
        Me.txtMedium.Enabled = False
        Me.txtMedium.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtMedium.Location = New System.Drawing.Point(301, 327)
        Me.txtMedium.Name = "txtMedium"
        Me.txtMedium.ReadOnly = True
        Me.txtMedium.Size = New System.Drawing.Size(96, 29)
        Me.txtMedium.TabIndex = 13
        '
        'txtSmall
        '
        Me.txtSmall.Enabled = False
        Me.txtSmall.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSmall.Location = New System.Drawing.Point(301, 372)
        Me.txtSmall.Name = "txtSmall"
        Me.txtSmall.ReadOnly = True
        Me.txtSmall.Size = New System.Drawing.Size(96, 29)
        Me.txtSmall.TabIndex = 14
        '
        'txtIndividual
        '
        Me.txtIndividual.Enabled = False
        Me.txtIndividual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtIndividual.Location = New System.Drawing.Point(301, 418)
        Me.txtIndividual.Name = "txtIndividual"
        Me.txtIndividual.ReadOnly = True
        Me.txtIndividual.Size = New System.Drawing.Size(96, 29)
        Me.txtIndividual.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(484, 511)
        Me.Controls.Add(Me.txtIndividual)
        Me.Controls.Add(Me.txtSmall)
        Me.Controls.Add(Me.txtMedium)
        Me.Controls.Add(Me.lblThanks)
        Me.Controls.Add(Me.lblIndividual)
        Me.Controls.Add(Me.lblSmall)
        Me.Controls.Add(Me.lblMedium)
        Me.Controls.Add(Me.lblLarge)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.txtLarge)
        Me.Controls.Add(Me.picUPS)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.nudItems)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.mnsMain)
        Me.MainMenuStrip = Me.mnsMain
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shipping Boxes"
        Me.mnsMain.ResumeLayout(False)
        Me.mnsMain.PerformLayout()
        CType(Me.nudItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUPS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents mnsMain As MenuStrip
    Friend WithEvents nudItems As NumericUpDown
    Friend WithEvents lblTitle As Label
    Friend WithEvents picUPS As PictureBox
    Friend WithEvents txtLarge As TextBox
    Friend WithEvents lblItems As Label
    Friend WithEvents mnsFile As ToolStripMenuItem
    Friend WithEvents mnsExit As ToolStripMenuItem
    Friend WithEvents mnsHelp As ToolStripMenuItem
    Friend WithEvents mnsAbout As ToolStripMenuItem
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblLarge As Label
    Friend WithEvents lblMedium As Label
    Friend WithEvents lblSmall As Label
    Friend WithEvents lblIndividual As Label
    Friend WithEvents lblThanks As Label
    Friend WithEvents txtMedium As TextBox
    Friend WithEvents txtSmall As TextBox
    Friend WithEvents txtIndividual As TextBox
End Class
