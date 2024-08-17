<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGPA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.pnlBlack = New System.Windows.Forms.Panel()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblF = New System.Windows.Forms.Label()
        Me.mtbA = New System.Windows.Forms.MaskedTextBox()
        Me.mtbB = New System.Windows.Forms.MaskedTextBox()
        Me.mtbC = New System.Windows.Forms.MaskedTextBox()
        Me.mtbD = New System.Windows.Forms.MaskedTextBox()
        Me.mtbF = New System.Windows.Forms.MaskedTextBox()
        Me.pnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.pnlTitle.Controls.Add(Me.lblEnter)
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(518, 71)
        Me.pnlTitle.TabIndex = 1
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEnter.Location = New System.Drawing.Point(14, 11)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(386, 45)
        Me.lblEnter.TabIndex = 0
        Me.lblEnter.Text = "Enter Grade Information"
        '
        'pnlBlack
        '
        Me.pnlBlack.BackColor = System.Drawing.Color.Black
        Me.pnlBlack.Location = New System.Drawing.Point(0, 68)
        Me.pnlBlack.Name = "pnlBlack"
        Me.pnlBlack.Size = New System.Drawing.Size(518, 28)
        Me.pnlBlack.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(111, 361)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(190, 42)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblA.Location = New System.Drawing.Point(84, 123)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(153, 21)
        Me.lblA.TabIndex = 5
        Me.lblA.Text = "Number of A's"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblB.Location = New System.Drawing.Point(84, 169)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(153, 21)
        Me.lblB.TabIndex = 7
        Me.lblB.Text = "Number of B's"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblC.Location = New System.Drawing.Point(84, 215)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(153, 21)
        Me.lblC.TabIndex = 9
        Me.lblC.Text = "Number of C's"
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblD.Location = New System.Drawing.Point(84, 262)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(153, 21)
        Me.lblD.TabIndex = 11
        Me.lblD.Text = "Number of D's"
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblF.Location = New System.Drawing.Point(84, 309)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(153, 21)
        Me.lblF.TabIndex = 13
        Me.lblF.Text = "Number of F's"
        '
        'mtbA
        '
        Me.mtbA.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbA.Location = New System.Drawing.Point(265, 123)
        Me.mtbA.Mask = "0"
        Me.mtbA.Name = "mtbA"
        Me.mtbA.Size = New System.Drawing.Size(67, 31)
        Me.mtbA.TabIndex = 1
        Me.mtbA.Text = "0"
        Me.mtbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtbA.ValidatingType = GetType(Integer)
        '
        'mtbB
        '
        Me.mtbB.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbB.Location = New System.Drawing.Point(265, 169)
        Me.mtbB.Mask = "0"
        Me.mtbB.Name = "mtbB"
        Me.mtbB.Size = New System.Drawing.Size(67, 31)
        Me.mtbB.TabIndex = 2
        Me.mtbB.Text = "0"
        Me.mtbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtbB.ValidatingType = GetType(Integer)
        '
        'mtbC
        '
        Me.mtbC.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbC.Location = New System.Drawing.Point(265, 215)
        Me.mtbC.Mask = "0"
        Me.mtbC.Name = "mtbC"
        Me.mtbC.Size = New System.Drawing.Size(67, 31)
        Me.mtbC.TabIndex = 3
        Me.mtbC.Text = "0"
        Me.mtbC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtbC.ValidatingType = GetType(Integer)
        '
        'mtbD
        '
        Me.mtbD.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbD.Location = New System.Drawing.Point(265, 262)
        Me.mtbD.Mask = "0"
        Me.mtbD.Name = "mtbD"
        Me.mtbD.Size = New System.Drawing.Size(67, 31)
        Me.mtbD.TabIndex = 4
        Me.mtbD.Text = "0"
        Me.mtbD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtbD.ValidatingType = GetType(Integer)
        '
        'mtbF
        '
        Me.mtbF.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mtbF.Location = New System.Drawing.Point(265, 309)
        Me.mtbF.Mask = "0"
        Me.mtbF.Name = "mtbF"
        Me.mtbF.Size = New System.Drawing.Size(67, 31)
        Me.mtbF.TabIndex = 5
        Me.mtbF.Text = "0"
        Me.mtbF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtbF.ValidatingType = GetType(Integer)
        '
        'frmGPA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(414, 428)
        Me.Controls.Add(Me.mtbF)
        Me.Controls.Add(Me.mtbD)
        Me.Controls.Add(Me.mtbC)
        Me.Controls.Add(Me.mtbB)
        Me.Controls.Add(Me.mtbA)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.pnlBlack)
        Me.Controls.Add(Me.pnlTitle)
        Me.Name = "frmGPA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculate GPA"
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblEnter As Label
    Friend WithEvents pnlBlack As Panel
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblA As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblC As Label
    Friend WithEvents lblD As Label
    Friend WithEvents lblF As Label
    Friend WithEvents mtbA As MaskedTextBox
    Friend WithEvents mtbB As MaskedTextBox
    Friend WithEvents mtbC As MaskedTextBox
    Friend WithEvents mtbD As MaskedTextBox
    Friend WithEvents mtbF As MaskedTextBox
End Class
