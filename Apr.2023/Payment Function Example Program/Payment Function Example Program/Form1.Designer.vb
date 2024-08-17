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
        Me.mtbPhone = New System.Windows.Forms.MaskedTextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.nudTerm = New System.Windows.Forms.NumericUpDown()
        Me.txtLoan = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.lblInterest = New System.Windows.Forms.Label()
        Me.lblTerm = New System.Windows.Forms.Label()
        Me.lblLoan = New System.Windows.Forms.Label()
        Me.nudInterest = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudInterest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mtbPhone
        '
        Me.mtbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mtbPhone.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbPhone.Location = New System.Drawing.Point(368, 85)
        Me.mtbPhone.Mask = "(999) 000-0000"
        Me.mtbPhone.Name = "mtbPhone"
        Me.mtbPhone.Size = New System.Drawing.Size(154, 35)
        Me.mtbPhone.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Bright", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.SeaShell
        Me.lblTitle.Location = New System.Drawing.Point(91, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(458, 31)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Calculate Your Monthly Payment"
        '
        'nudTerm
        '
        Me.nudTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudTerm.DecimalPlaces = 2
        Me.nudTerm.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nudTerm.Location = New System.Drawing.Point(363, 214)
        Me.nudTerm.Name = "nudTerm"
        Me.nudTerm.Size = New System.Drawing.Size(159, 35)
        Me.nudTerm.TabIndex = 2
        '
        'txtLoan
        '
        Me.txtLoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoan.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtLoan.Location = New System.Drawing.Point(333, 287)
        Me.txtLoan.Name = "txtLoan"
        Me.txtLoan.Size = New System.Drawing.Size(189, 35)
        Me.txtLoan.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(190, 362)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(262, 54)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate Payment"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEnter.ForeColor = System.Drawing.Color.SeaShell
        Me.lblEnter.Location = New System.Drawing.Point(104, 92)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(220, 23)
        Me.lblEnter.TabIndex = 5
        Me.lblEnter.Text = "Enter Phone Number"
        '
        'lblInterest
        '
        Me.lblInterest.AutoSize = True
        Me.lblInterest.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInterest.ForeColor = System.Drawing.Color.SeaShell
        Me.lblInterest.Location = New System.Drawing.Point(104, 153)
        Me.lblInterest.Name = "lblInterest"
        Me.lblInterest.Size = New System.Drawing.Size(174, 23)
        Me.lblInterest.TabIndex = 6
        Me.lblInterest.Text = "Interest Rate (%)"
        '
        'lblTerm
        '
        Me.lblTerm.AutoSize = True
        Me.lblTerm.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTerm.ForeColor = System.Drawing.Color.SeaShell
        Me.lblTerm.Location = New System.Drawing.Point(311, 153)
        Me.lblTerm.Name = "lblTerm"
        Me.lblTerm.Size = New System.Drawing.Size(211, 23)
        Me.lblTerm.TabIndex = 7
        Me.lblTerm.Text = "Term of Loan (Year)"
        '
        'lblLoan
        '
        Me.lblLoan.AutoSize = True
        Me.lblLoan.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLoan.ForeColor = System.Drawing.Color.SeaShell
        Me.lblLoan.Location = New System.Drawing.Point(104, 294)
        Me.lblLoan.Name = "lblLoan"
        Me.lblLoan.Size = New System.Drawing.Size(176, 23)
        Me.lblLoan.TabIndex = 8
        Me.lblLoan.Text = "Amount of Loan"
        '
        'nudInterest
        '
        Me.nudInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudInterest.DecimalPlaces = 2
        Me.nudInterest.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nudInterest.Location = New System.Drawing.Point(104, 214)
        Me.nudInterest.Name = "nudInterest"
        Me.nudInterest.Size = New System.Drawing.Size(159, 35)
        Me.nudInterest.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(655, 450)
        Me.Controls.Add(Me.nudInterest)
        Me.Controls.Add(Me.lblLoan)
        Me.Controls.Add(Me.lblTerm)
        Me.Controls.Add(Me.lblInterest)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtLoan)
        Me.Controls.Add(Me.nudTerm)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mtbPhone)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Function Example Program"
        CType(Me.nudTerm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudInterest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtbPhone As MaskedTextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents nudTerm As NumericUpDown
    Friend WithEvents txtLoan As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblEnter As Label
    Friend WithEvents lblInterest As Label
    Friend WithEvents lblTerm As Label
    Friend WithEvents lblLoan As Label
    Friend WithEvents nudInterest As NumericUpDown
End Class
