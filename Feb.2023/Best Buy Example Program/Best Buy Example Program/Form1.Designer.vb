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
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.mnsFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDVD = New System.Windows.Forms.Label()
        Me.picBestBuy = New System.Windows.Forms.PictureBox()
        Me.lblWant = New System.Windows.Forms.Label()
        Me.nudQty = New System.Windows.Forms.NumericUpDown()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.mnsMenu.SuspendLayout()
        CType(Me.picBestBuy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnsMenu
        '
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsFile, Me.mnsHelp})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(484, 24)
        Me.mnsMenu.TabIndex = 0
        Me.mnsMenu.Text = "MenuStrip1"
        '
        'mnsFile
        '
        Me.mnsFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.mnsFile.Name = "mnsFile"
        Me.mnsFile.Size = New System.Drawing.Size(37, 20)
        Me.mnsFile.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.AccessibleName = ""
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.AboutToolStripMenuItem.Text = "Exit"
        '
        'mnsHelp
        '
        Me.mnsHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.mnsHelp.Name = "mnsHelp"
        Me.mnsHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnsHelp.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.AccessibleName = ""
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'lblDVD
        '
        Me.lblDVD.AutoSize = True
        Me.lblDVD.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDVD.ForeColor = System.Drawing.Color.Gold
        Me.lblDVD.Location = New System.Drawing.Point(44, 198)
        Me.lblDVD.Name = "lblDVD"
        Me.lblDVD.Size = New System.Drawing.Size(408, 32)
        Me.lblDVD.TabIndex = 3
        Me.lblDVD.Text = "DVD PLAYERS ON SALE FOR $125.95"
        '
        'picBestBuy
        '
        Me.picBestBuy.Image = CType(resources.GetObject("picBestBuy.Image"), System.Drawing.Image)
        Me.picBestBuy.Location = New System.Drawing.Point(143, 44)
        Me.picBestBuy.Name = "picBestBuy"
        Me.picBestBuy.Size = New System.Drawing.Size(202, 141)
        Me.picBestBuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBestBuy.TabIndex = 4
        Me.picBestBuy.TabStop = False
        '
        'lblWant
        '
        Me.lblWant.AutoSize = True
        Me.lblWant.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblWant.ForeColor = System.Drawing.Color.Gold
        Me.lblWant.Location = New System.Drawing.Point(112, 244)
        Me.lblWant.Name = "lblWant"
        Me.lblWant.Size = New System.Drawing.Size(260, 30)
        Me.lblWant.TabIndex = 5
        Me.lblWant.Text = "How many do you want???"
        '
        'nudQty
        '
        Me.nudQty.Location = New System.Drawing.Point(201, 293)
        Me.nudQty.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudQty.Name = "nudQty"
        Me.nudQty.Size = New System.Drawing.Size(81, 23)
        Me.nudQty.TabIndex = 6
        '
        'btnPrice
        '
        Me.btnPrice.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPrice.Location = New System.Drawing.Point(143, 340)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(205, 42)
        Me.btnPrice.TabIndex = 7
        Me.btnPrice.Text = "SHOW ME THE PRICE"
        Me.btnPrice.UseVisualStyleBackColor = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPrice.ForeColor = System.Drawing.Color.Gold
        Me.lblPrice.Location = New System.Drawing.Point(201, 399)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(59, 30)
        Me.lblPrice.TabIndex = 8
        Me.lblPrice.Text = "Price"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnPrice)
        Me.Controls.Add(Me.nudQty)
        Me.Controls.Add(Me.lblWant)
        Me.Controls.Add(Me.picBestBuy)
        Me.Controls.Add(Me.lblDVD)
        Me.Controls.Add(Me.mnsMenu)
        Me.MainMenuStrip = Me.mnsMenu
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Best Buy Sale"
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        CType(Me.picBestBuy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents mnsFile As ToolStripMenuItem
    Friend WithEvents mnsHelp As ToolStripMenuItem
    Friend WithEvents lblDVD As Label
    Friend WithEvents picBestBuy As PictureBox
    Friend WithEvents lblWant As Label
    Friend WithEvents nudQty As NumericUpDown
    Friend WithEvents btnPrice As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
End Class
