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
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlBlack = New System.Windows.Forms.Panel()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.btnGPA = New System.Windows.Forms.Button()
        Me.pnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.pnlTitle.Controls.Add(Me.lblWelcome)
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(518, 71)
        Me.pnlTitle.TabIndex = 0
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblWelcome.Location = New System.Drawing.Point(12, 11)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(377, 45)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome <username> !"
        '
        'pnlBlack
        '
        Me.pnlBlack.BackColor = System.Drawing.Color.Black
        Me.pnlBlack.Location = New System.Drawing.Point(0, 68)
        Me.pnlBlack.Name = "pnlBlack"
        Me.pnlBlack.Size = New System.Drawing.Size(518, 21)
        Me.pnlBlack.TabIndex = 1
        '
        'btnAverage
        '
        Me.btnAverage.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAverage.Location = New System.Drawing.Point(78, 118)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(262, 42)
        Me.btnAverage.TabIndex = 1
        Me.btnAverage.Text = "Average Test Grades"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'btnGPA
        '
        Me.btnGPA.Font = New System.Drawing.Font("NSimSun", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnGPA.Location = New System.Drawing.Point(78, 182)
        Me.btnGPA.Name = "btnGPA"
        Me.btnGPA.Size = New System.Drawing.Size(262, 42)
        Me.btnGPA.TabIndex = 2
        Me.btnGPA.Text = "Calculate GPA"
        Me.btnGPA.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(414, 261)
        Me.Controls.Add(Me.btnGPA)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.pnlBlack)
        Me.Controls.Add(Me.pnlTitle)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program 9 - Student Grades"
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents pnlBlack As Panel
    Friend WithEvents btnAverage As Button
    Friend WithEvents btnGPA As Button
End Class
