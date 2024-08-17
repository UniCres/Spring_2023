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
        Me.mnsMain = New System.Windows.Forms.MenuStrip()
        Me.mnsFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblKwik = New System.Windows.Forms.Label()
        Me.lblMart = New System.Windows.Forms.Label()
        Me.lblE = New System.Windows.Forms.Label()
        Me.lblGas = New System.Windows.Forms.Label()
        Me.nudGas = New System.Windows.Forms.NumericUpDown()
        Me.lblCola = New System.Windows.Forms.Label()
        Me.nudCola = New System.Windows.Forms.NumericUpDown()
        Me.lblSquishie = New System.Windows.Forms.Label()
        Me.lblCereal = New System.Windows.Forms.Label()
        Me.lblBooks = New System.Windows.Forms.Label()
        Me.nudSquishie = New System.Windows.Forms.NumericUpDown()
        Me.nudCereal = New System.Windows.Forms.NumericUpDown()
        Me.nudBooks = New System.Windows.Forms.NumericUpDown()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblGasPrice = New System.Windows.Forms.Label()
        Me.lblColaPrice = New System.Windows.Forms.Label()
        Me.lblSquishiePrice = New System.Windows.Forms.Label()
        Me.lblCerealPrice = New System.Windows.Forms.Label()
        Me.lblBooksPrice = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.mnsMain.SuspendLayout()
        CType(Me.nudGas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCola, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSquishie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCereal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnsMain
        '
        Me.mnsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsFile, Me.mnsHelp})
        Me.mnsMain.Location = New System.Drawing.Point(0, 0)
        Me.mnsMain.Name = "mnsMain"
        Me.mnsMain.Size = New System.Drawing.Size(784, 24)
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
        'lblKwik
        '
        Me.lblKwik.AutoSize = True
        Me.lblKwik.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblKwik.Font = New System.Drawing.Font("Snap ITC", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblKwik.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblKwik.Location = New System.Drawing.Point(55, 49)
        Me.lblKwik.Name = "lblKwik"
        Me.lblKwik.Size = New System.Drawing.Size(243, 82)
        Me.lblKwik.TabIndex = 0
        Me.lblKwik.Text = "KWIK"
        '
        'lblMart
        '
        Me.lblMart.AutoSize = True
        Me.lblMart.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblMart.Font = New System.Drawing.Font("Snap ITC", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMart.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblMart.Location = New System.Drawing.Point(474, 49)
        Me.lblMart.Name = "lblMart"
        Me.lblMart.Size = New System.Drawing.Size(259, 82)
        Me.lblMart.TabIndex = 2
        Me.lblMart.Text = "MART"
        '
        'lblE
        '
        Me.lblE.AutoSize = True
        Me.lblE.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblE.Font = New System.Drawing.Font("Snap ITC", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblE.ForeColor = System.Drawing.Color.Red
        Me.lblE.Location = New System.Drawing.Point(285, 26)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(204, 123)
        Me.lblE.TabIndex = 3
        Me.lblE.Text = "-E-"
        '
        'lblGas
        '
        Me.lblGas.AutoSize = True
        Me.lblGas.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGas.Location = New System.Drawing.Point(65, 176)
        Me.lblGas.Name = "lblGas"
        Me.lblGas.Size = New System.Drawing.Size(48, 30)
        Me.lblGas.TabIndex = 4
        Me.lblGas.Text = "Gas"
        '
        'nudGas
        '
        Me.nudGas.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nudGas.Location = New System.Drawing.Point(181, 176)
        Me.nudGas.Name = "nudGas"
        Me.nudGas.Size = New System.Drawing.Size(150, 35)
        Me.nudGas.TabIndex = 1
        '
        'lblCola
        '
        Me.lblCola.AutoSize = True
        Me.lblCola.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCola.Location = New System.Drawing.Point(368, 176)
        Me.lblCola.Name = "lblCola"
        Me.lblCola.Size = New System.Drawing.Size(108, 30)
        Me.lblCola.TabIndex = 6
        Me.lblCola.Text = "Buzz Cola"
        '
        'nudCola
        '
        Me.nudCola.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nudCola.Location = New System.Drawing.Point(572, 176)
        Me.nudCola.Name = "nudCola"
        Me.nudCola.Size = New System.Drawing.Size(150, 35)
        Me.nudCola.TabIndex = 2
        '
        'lblSquishie
        '
        Me.lblSquishie.AutoSize = True
        Me.lblSquishie.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSquishie.Location = New System.Drawing.Point(65, 278)
        Me.lblSquishie.Name = "lblSquishie"
        Me.lblSquishie.Size = New System.Drawing.Size(96, 30)
        Me.lblSquishie.TabIndex = 8
        Me.lblSquishie.Text = "Squishie"
        '
        'lblCereal
        '
        Me.lblCereal.AutoSize = True
        Me.lblCereal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCereal.Location = New System.Drawing.Point(368, 278)
        Me.lblCereal.Name = "lblCereal"
        Me.lblCereal.Size = New System.Drawing.Size(180, 30)
        Me.lblCereal.TabIndex = 9
        Me.lblCereal.Text = "Krusty-O's Cereal"
        '
        'lblBooks
        '
        Me.lblBooks.AutoSize = True
        Me.lblBooks.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBooks.Location = New System.Drawing.Point(65, 377)
        Me.lblBooks.Name = "lblBooks"
        Me.lblBooks.Size = New System.Drawing.Size(310, 30)
        Me.lblBooks.TabIndex = 10
        Me.lblBooks.Text = "Radioactive Man Comic Books"
        '
        'nudSquishie
        '
        Me.nudSquishie.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nudSquishie.Location = New System.Drawing.Point(181, 276)
        Me.nudSquishie.Name = "nudSquishie"
        Me.nudSquishie.Size = New System.Drawing.Size(150, 35)
        Me.nudSquishie.TabIndex = 3
        '
        'nudCereal
        '
        Me.nudCereal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nudCereal.Location = New System.Drawing.Point(572, 273)
        Me.nudCereal.Name = "nudCereal"
        Me.nudCereal.Size = New System.Drawing.Size(150, 35)
        Me.nudCereal.TabIndex = 4
        '
        'nudBooks
        '
        Me.nudBooks.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nudBooks.Location = New System.Drawing.Point(395, 375)
        Me.nudBooks.Name = "nudBooks"
        Me.nudBooks.Size = New System.Drawing.Size(150, 35)
        Me.nudBooks.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(70, 573)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(184, 52)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCheck.Location = New System.Drawing.Point(297, 573)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(184, 52)
        Me.btnCheck.TabIndex = 7
        Me.btnCheck.Text = "Check Out"
        Me.btnCheck.UseVisualStyleBackColor = True
        Me.btnCheck.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(524, 573)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(184, 52)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear Screen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblGasPrice
        '
        Me.lblGasPrice.AutoSize = True
        Me.lblGasPrice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblGasPrice.Location = New System.Drawing.Point(65, 214)
        Me.lblGasPrice.Name = "lblGasPrice"
        Me.lblGasPrice.Size = New System.Drawing.Size(99, 17)
        Me.lblGasPrice.TabIndex = 17
        Me.lblGasPrice.Text = "$3.19 per gallon"
        '
        'lblColaPrice
        '
        Me.lblColaPrice.AutoSize = True
        Me.lblColaPrice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblColaPrice.Location = New System.Drawing.Point(368, 214)
        Me.lblColaPrice.Name = "lblColaPrice"
        Me.lblColaPrice.Size = New System.Drawing.Size(96, 17)
        Me.lblColaPrice.TabIndex = 18
        Me.lblColaPrice.Text = "$1.19 per bottle"
        '
        'lblSquishiePrice
        '
        Me.lblSquishiePrice.AutoSize = True
        Me.lblSquishiePrice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblSquishiePrice.Location = New System.Drawing.Point(65, 318)
        Me.lblSquishiePrice.Name = "lblSquishiePrice"
        Me.lblSquishiePrice.Size = New System.Drawing.Size(69, 17)
        Me.lblSquishiePrice.TabIndex = 19
        Me.lblSquishiePrice.Text = "$0.99 each"
        '
        'lblCerealPrice
        '
        Me.lblCerealPrice.AutoSize = True
        Me.lblCerealPrice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblCerealPrice.Location = New System.Drawing.Point(368, 318)
        Me.lblCerealPrice.Name = "lblCerealPrice"
        Me.lblCerealPrice.Size = New System.Drawing.Size(85, 17)
        Me.lblCerealPrice.TabIndex = 20
        Me.lblCerealPrice.Text = "$3.49 per box"
        '
        'lblBooksPrice
        '
        Me.lblBooksPrice.AutoSize = True
        Me.lblBooksPrice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblBooksPrice.Location = New System.Drawing.Point(65, 416)
        Me.lblBooksPrice.Name = "lblBooksPrice"
        Me.lblBooksPrice.Size = New System.Drawing.Size(69, 17)
        Me.lblBooksPrice.TabIndex = 21
        Me.lblBooksPrice.Text = "$3.10 each"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPrice.Location = New System.Drawing.Point(140, 479)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(186, 45)
        Me.lblPrice.TabIndex = 22
        Me.lblPrice.Text = "Total Price:"
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Enabled = False
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtPrice.Location = New System.Drawing.Point(352, 485)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(267, 39)
        Me.txtPrice.TabIndex = 23
        Me.txtPrice.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(784, 661)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblBooksPrice)
        Me.Controls.Add(Me.lblCerealPrice)
        Me.Controls.Add(Me.lblSquishiePrice)
        Me.Controls.Add(Me.lblColaPrice)
        Me.Controls.Add(Me.lblGasPrice)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.nudBooks)
        Me.Controls.Add(Me.nudCereal)
        Me.Controls.Add(Me.nudSquishie)
        Me.Controls.Add(Me.lblBooks)
        Me.Controls.Add(Me.lblCereal)
        Me.Controls.Add(Me.lblSquishie)
        Me.Controls.Add(Me.nudCola)
        Me.Controls.Add(Me.lblCola)
        Me.Controls.Add(Me.nudGas)
        Me.Controls.Add(Me.lblGas)
        Me.Controls.Add(Me.lblE)
        Me.Controls.Add(Me.lblKwik)
        Me.Controls.Add(Me.lblMart)
        Me.Controls.Add(Me.mnsMain)
        Me.MainMenuStrip = Me.mnsMain
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kwik-E-Mart"
        Me.mnsMain.ResumeLayout(False)
        Me.mnsMain.PerformLayout()
        CType(Me.nudGas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCola, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSquishie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCereal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblKwik As Label
    Friend WithEvents mnsMain As MenuStrip
    Friend WithEvents lblMart As Label
    Friend WithEvents lblE As Label
    Friend WithEvents mnsFile As ToolStripMenuItem
    Friend WithEvents mnsExit As ToolStripMenuItem
    Friend WithEvents mnsHelp As ToolStripMenuItem
    Friend WithEvents mnsAbout As ToolStripMenuItem
    Friend WithEvents lblGas As Label
    Friend WithEvents nudGas As NumericUpDown
    Friend WithEvents lblCola As Label
    Friend WithEvents nudCola As NumericUpDown
    Friend WithEvents lblSquishie As Label
    Friend WithEvents lblCereal As Label
    Friend WithEvents lblBooks As Label
    Friend WithEvents nudSquishie As NumericUpDown
    Friend WithEvents nudCereal As NumericUpDown
    Friend WithEvents nudBooks As NumericUpDown
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblGasPrice As Label
    Friend WithEvents lblColaPrice As Label
    Friend WithEvents lblSquishiePrice As Label
    Friend WithEvents lblCerealPrice As Label
    Friend WithEvents lblBooksPrice As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
End Class
