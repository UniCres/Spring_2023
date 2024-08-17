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
        Me.pnlRed = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.picPizzaHut = New System.Windows.Forms.PictureBox()
        Me.pnlGreen = New System.Windows.Forms.Panel()
        Me.lblPizza = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtPizza = New System.Windows.Forms.TextBox()
        Me.lblWings = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblBread = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtWings = New System.Windows.Forms.TextBox()
        Me.txtBread = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.grpOrder = New System.Windows.Forms.GroupBox()
        Me.grpCheckout = New System.Windows.Forms.GroupBox()
        Me.pnlRed.SuspendLayout()
        CType(Me.picPizzaHut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlRed
        '
        Me.pnlRed.BackColor = System.Drawing.Color.DarkGreen
        Me.pnlRed.Controls.Add(Me.lblWelcome)
        Me.pnlRed.Controls.Add(Me.picPizzaHut)
        Me.pnlRed.Location = New System.Drawing.Point(0, 0)
        Me.pnlRed.Name = "pnlRed"
        Me.pnlRed.Size = New System.Drawing.Size(584, 112)
        Me.pnlRed.TabIndex = 0
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(162, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(337, 86)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome!"
        '
        'picPizzaHut
        '
        Me.picPizzaHut.Image = CType(resources.GetObject("picPizzaHut.Image"), System.Drawing.Image)
        Me.picPizzaHut.Location = New System.Drawing.Point(12, 0)
        Me.picPizzaHut.Name = "picPizzaHut"
        Me.picPizzaHut.Size = New System.Drawing.Size(118, 109)
        Me.picPizzaHut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPizzaHut.TabIndex = 0
        Me.picPizzaHut.TabStop = False
        '
        'pnlGreen
        '
        Me.pnlGreen.BackColor = System.Drawing.Color.Red
        Me.pnlGreen.Location = New System.Drawing.Point(0, 106)
        Me.pnlGreen.Name = "pnlGreen"
        Me.pnlGreen.Size = New System.Drawing.Size(584, 22)
        Me.pnlGreen.TabIndex = 1
        '
        'lblPizza
        '
        Me.lblPizza.AutoSize = True
        Me.lblPizza.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPizza.Location = New System.Drawing.Point(138, 145)
        Me.lblPizza.Name = "lblPizza"
        Me.lblPizza.Size = New System.Drawing.Size(83, 37)
        Me.lblPizza.TabIndex = 2
        Me.lblPizza.Text = "Pizza"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(90, 349)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(153, 42)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtPizza
        '
        Me.txtPizza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPizza.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtPizza.Location = New System.Drawing.Point(120, 185)
        Me.txtPizza.Name = "txtPizza"
        Me.txtPizza.Size = New System.Drawing.Size(123, 35)
        Me.txtPizza.TabIndex = 1
        '
        'lblWings
        '
        Me.lblWings.AutoSize = True
        Me.lblWings.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblWings.Location = New System.Drawing.Point(356, 145)
        Me.lblWings.Name = "lblWings"
        Me.lblWings.Size = New System.Drawing.Size(97, 37)
        Me.lblWings.TabIndex = 8
        Me.lblWings.Text = "Wings"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCost.Location = New System.Drawing.Point(211, 409)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(146, 37)
        Me.lblCost.TabIndex = 9
        Me.lblCost.Text = "Total Cost"
        '
        'lblBread
        '
        Me.lblBread.AutoSize = True
        Me.lblBread.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBread.Location = New System.Drawing.Point(211, 233)
        Me.lblBread.Name = "lblBread"
        Me.lblBread.Size = New System.Drawing.Size(163, 37)
        Me.lblBread.TabIndex = 10
        Me.lblBread.Text = "Breadsticks"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(346, 349)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(153, 42)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtWings
        '
        Me.txtWings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWings.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtWings.Location = New System.Drawing.Point(346, 185)
        Me.txtWings.Name = "txtWings"
        Me.txtWings.Size = New System.Drawing.Size(123, 35)
        Me.txtWings.TabIndex = 2
        '
        'txtBread
        '
        Me.txtBread.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBread.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtBread.Location = New System.Drawing.Point(229, 273)
        Me.txtBread.Name = "txtBread"
        Me.txtBread.Size = New System.Drawing.Size(123, 35)
        Me.txtBread.TabIndex = 3
        '
        'txtCost
        '
        Me.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCost.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtCost.Location = New System.Drawing.Point(229, 449)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(123, 35)
        Me.txtCost.TabIndex = 14
        Me.txtCost.TabStop = False
        '
        'grpOrder
        '
        Me.grpOrder.Location = New System.Drawing.Point(42, 134)
        Me.grpOrder.Name = "grpOrder"
        Me.grpOrder.Size = New System.Drawing.Size(507, 190)
        Me.grpOrder.TabIndex = 15
        Me.grpOrder.TabStop = False
        Me.grpOrder.Text = "Order"
        '
        'grpCheckout
        '
        Me.grpCheckout.Location = New System.Drawing.Point(42, 330)
        Me.grpCheckout.Name = "grpCheckout"
        Me.grpCheckout.Size = New System.Drawing.Size(507, 174)
        Me.grpCheckout.TabIndex = 16
        Me.grpCheckout.TabStop = False
        Me.grpCheckout.Text = "Checkout"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 516)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtBread)
        Me.Controls.Add(Me.txtWings)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblBread)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblWings)
        Me.Controls.Add(Me.txtPizza)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblPizza)
        Me.Controls.Add(Me.pnlGreen)
        Me.Controls.Add(Me.pnlRed)
        Me.Controls.Add(Me.grpOrder)
        Me.Controls.Add(Me.grpCheckout)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pizza Hut"
        Me.pnlRed.ResumeLayout(False)
        Me.pnlRed.PerformLayout()
        CType(Me.picPizzaHut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlRed As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents picPizzaHut As PictureBox
    Friend WithEvents pnlGreen As Panel
    Friend WithEvents lblPizza As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtPizza As TextBox
    Friend WithEvents lblWings As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblBread As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txtWings As TextBox
    Friend WithEvents txtBread As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents grpOrder As GroupBox
    Friend WithEvents grpCheckout As GroupBox
End Class
