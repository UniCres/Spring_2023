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
        Me.pnlWelcome = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlSub = New System.Windows.Forms.Panel()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.nudCost = New System.Windows.Forms.NumericUpDown()
        Me.nudDiscount = New System.Windows.Forms.NumericUpDown()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.picKetchup = New System.Windows.Forms.PictureBox()
        Me.pnlWelcome.SuspendLayout()
        CType(Me.nudCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKetchup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlWelcome
        '
        Me.pnlWelcome.BackColor = System.Drawing.Color.Red
        Me.pnlWelcome.Controls.Add(Me.lblWelcome)
        Me.pnlWelcome.Location = New System.Drawing.Point(0, 0)
        Me.pnlWelcome.Name = "pnlWelcome"
        Me.pnlWelcome.Size = New System.Drawing.Size(700, 130)
        Me.pnlWelcome.TabIndex = 0
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Cambria", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(61, 23)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(557, 75)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to Heinz"
        '
        'pnlSub
        '
        Me.pnlSub.BackColor = System.Drawing.Color.DarkGreen
        Me.pnlSub.Location = New System.Drawing.Point(0, 125)
        Me.pnlSub.Name = "pnlSub"
        Me.pnlSub.Size = New System.Drawing.Size(685, 27)
        Me.pnlSub.TabIndex = 1
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCost.Location = New System.Drawing.Point(294, 188)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(111, 21)
        Me.lblCost.TabIndex = 3
        Me.lblCost.Text = "Cost Per Bottle"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDiscount.Location = New System.Drawing.Point(495, 188)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(126, 21)
        Me.lblDiscount.TabIndex = 4
        Me.lblDiscount.Text = "Discount Percent"
        '
        'nudCost
        '
        Me.nudCost.DecimalPlaces = 2
        Me.nudCost.Location = New System.Drawing.Point(294, 254)
        Me.nudCost.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudCost.Name = "nudCost"
        Me.nudCost.Size = New System.Drawing.Size(120, 23)
        Me.nudCost.TabIndex = 5
        '
        'nudDiscount
        '
        Me.nudDiscount.Location = New System.Drawing.Point(495, 254)
        Me.nudDiscount.Name = "nudDiscount"
        Me.nudDiscount.Size = New System.Drawing.Size(120, 23)
        Me.nudDiscount.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(381, 313)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(157, 46)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Find Discount"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPrice.Location = New System.Drawing.Point(320, 381)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(272, 45)
        Me.lblPrice.TabIndex = 8
        Me.lblPrice.Text = "Discounted Price"
        '
        'picKetchup
        '
        Me.picKetchup.Image = CType(resources.GetObject("picKetchup.Image"), System.Drawing.Image)
        Me.picKetchup.Location = New System.Drawing.Point(33, 175)
        Me.picKetchup.Name = "picKetchup"
        Me.picKetchup.Size = New System.Drawing.Size(213, 251)
        Me.picKetchup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKetchup.TabIndex = 9
        Me.picKetchup.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.picKetchup)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.nudDiscount)
        Me.Controls.Add(Me.nudCost)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.pnlSub)
        Me.Controls.Add(Me.pnlWelcome)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Heinz Ketchup"
        Me.pnlWelcome.ResumeLayout(False)
        Me.pnlWelcome.PerformLayout()
        CType(Me.nudCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKetchup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlWelcome As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents pnlSub As Panel
    Friend WithEvents lblCost As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents nudCost As NumericUpDown
    Friend WithEvents nudDiscount As NumericUpDown
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents picKetchup As PictureBox
End Class
