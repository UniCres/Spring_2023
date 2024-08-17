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
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.txtSide = New System.Windows.Forms.TextBox()
        Me.lblSide = New System.Windows.Forms.Label()
        Me.txtDrink = New System.Windows.Forms.TextBox()
        Me.lblDrink = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOrder.Location = New System.Drawing.Point(58, 28)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(236, 33)
        Me.lblOrder.TabIndex = 0
        Me.lblOrder.Text = "What's Your Order?"
        '
        'txtOrder
        '
        Me.txtOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrder.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtOrder.Location = New System.Drawing.Point(58, 74)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(317, 41)
        Me.txtOrder.TabIndex = 1
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.Color.Bisque
        Me.btnOrder.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnOrder.Location = New System.Drawing.Point(134, 370)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(160, 49)
        Me.btnOrder.TabIndex = 4
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'txtSide
        '
        Me.txtSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSide.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSide.Location = New System.Drawing.Point(58, 184)
        Me.txtSide.Name = "txtSide"
        Me.txtSide.Size = New System.Drawing.Size(317, 41)
        Me.txtSide.TabIndex = 2
        '
        'lblSide
        '
        Me.lblSide.AutoSize = True
        Me.lblSide.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSide.Location = New System.Drawing.Point(58, 138)
        Me.lblSide.Name = "lblSide"
        Me.lblSide.Size = New System.Drawing.Size(150, 33)
        Me.lblSide.TabIndex = 3
        Me.lblSide.Text = "Side Order?"
        '
        'txtDrink
        '
        Me.txtDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDrink.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDrink.Location = New System.Drawing.Point(58, 300)
        Me.txtDrink.Name = "txtDrink"
        Me.txtDrink.Size = New System.Drawing.Size(317, 41)
        Me.txtDrink.TabIndex = 3
        '
        'lblDrink
        '
        Me.lblDrink.AutoSize = True
        Me.lblDrink.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDrink.Location = New System.Drawing.Point(58, 254)
        Me.lblDrink.Name = "lblDrink"
        Me.lblDrink.Size = New System.Drawing.Size(190, 33)
        Me.lblDrink.TabIndex = 5
        Me.lblDrink.Text = "What to Drink?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(434, 450)
        Me.Controls.Add(Me.txtDrink)
        Me.Controls.Add(Me.lblDrink)
        Me.Controls.Add(Me.txtSide)
        Me.Controls.Add(Me.lblSide)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.txtOrder)
        Me.Controls.Add(Me.lblOrder)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Breakfast Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOrder As Label
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents btnOrder As Button
    Friend WithEvents txtSide As TextBox
    Friend WithEvents lblSide As Label
    Friend WithEvents txtDrink As TextBox
    Friend WithEvents lblDrink As Label
End Class
