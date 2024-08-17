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
        Me.pnlChocolate = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.grpNumbers = New System.Windows.Forms.GroupBox()
        Me.lblLowPrint = New System.Windows.Forms.Label()
        Me.lblHighPrint = New System.Windows.Forms.Label()
        Me.lblLow = New System.Windows.Forms.Label()
        Me.lblHigh = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.txtTwo = New System.Windows.Forms.TextBox()
        Me.txtOne = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlChocolate.SuspendLayout()
        Me.grpNumbers.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlChocolate
        '
        Me.pnlChocolate.BackColor = System.Drawing.Color.Chocolate
        Me.pnlChocolate.Controls.Add(Me.lblWelcome)
        Me.pnlChocolate.Location = New System.Drawing.Point(0, 0)
        Me.pnlChocolate.Name = "pnlChocolate"
        Me.pnlChocolate.Size = New System.Drawing.Size(536, 134)
        Me.pnlChocolate.TabIndex = 0
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblWelcome.Location = New System.Drawing.Point(27, 30)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(474, 65)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to Hi_Low"
        '
        'grpNumbers
        '
        Me.grpNumbers.Controls.Add(Me.lblLowPrint)
        Me.grpNumbers.Controls.Add(Me.lblHighPrint)
        Me.grpNumbers.Controls.Add(Me.lblLow)
        Me.grpNumbers.Controls.Add(Me.lblHigh)
        Me.grpNumbers.Controls.Add(Me.lblTwo)
        Me.grpNumbers.Controls.Add(Me.lblOne)
        Me.grpNumbers.Controls.Add(Me.txtTwo)
        Me.grpNumbers.Controls.Add(Me.txtOne)
        Me.grpNumbers.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpNumbers.Location = New System.Drawing.Point(49, 145)
        Me.grpNumbers.Name = "grpNumbers"
        Me.grpNumbers.Size = New System.Drawing.Size(436, 257)
        Me.grpNumbers.TabIndex = 1
        Me.grpNumbers.TabStop = False
        Me.grpNumbers.Text = "Enter 2 Numbers"
        '
        'lblLowPrint
        '
        Me.lblLowPrint.AutoSize = True
        Me.lblLowPrint.Font = New System.Drawing.Font("Felix Titling", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLowPrint.Location = New System.Drawing.Point(273, 206)
        Me.lblLowPrint.Name = "lblLowPrint"
        Me.lblLowPrint.Size = New System.Drawing.Size(99, 32)
        Me.lblLowPrint.TabIndex = 9
        Me.lblLowPrint.Text = "Print"
        '
        'lblHighPrint
        '
        Me.lblHighPrint.AutoSize = True
        Me.lblHighPrint.Font = New System.Drawing.Font("Felix Titling", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHighPrint.Location = New System.Drawing.Point(56, 206)
        Me.lblHighPrint.Name = "lblHighPrint"
        Me.lblHighPrint.Size = New System.Drawing.Size(99, 32)
        Me.lblHighPrint.TabIndex = 8
        Me.lblHighPrint.Text = "Print"
        '
        'lblLow
        '
        Me.lblLow.AutoSize = True
        Me.lblLow.Location = New System.Drawing.Point(257, 160)
        Me.lblLow.Name = "lblLow"
        Me.lblLow.Size = New System.Drawing.Size(141, 30)
        Me.lblLow.TabIndex = 7
        Me.lblLow.Text = "Low Number"
        '
        'lblHigh
        '
        Me.lblHigh.AutoSize = True
        Me.lblHigh.Location = New System.Drawing.Point(33, 160)
        Me.lblHigh.Name = "lblHigh"
        Me.lblHigh.Size = New System.Drawing.Size(148, 30)
        Me.lblHigh.TabIndex = 6
        Me.lblHigh.Text = "High Number"
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTwo.Location = New System.Drawing.Point(56, 108)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(110, 30)
        Me.lblTwo.TabIndex = 5
        Me.lblTwo.Text = "Number 2"
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOne.Location = New System.Drawing.Point(56, 49)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(106, 30)
        Me.lblOne.TabIndex = 4
        Me.lblOne.Text = "Number 1"
        '
        'txtTwo
        '
        Me.txtTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTwo.Location = New System.Drawing.Point(226, 108)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(146, 35)
        Me.txtTwo.TabIndex = 2
        '
        'txtOne
        '
        Me.txtOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOne.Location = New System.Drawing.Point(226, 49)
        Me.txtOne.Name = "txtOne"
        Me.txtOne.Size = New System.Drawing.Size(146, 35)
        Me.txtOne.TabIndex = 1
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.Tan
        Me.btnFind.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFind.Location = New System.Drawing.Point(49, 422)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(118, 52)
        Me.btnFind.TabIndex = 3
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Tan
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(207, 422)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(118, 52)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Tan
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(367, 422)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 52)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 495)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.grpNumbers)
        Me.Controls.Add(Me.pnlChocolate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab 6 - Hi low"
        Me.pnlChocolate.ResumeLayout(False)
        Me.pnlChocolate.PerformLayout()
        Me.grpNumbers.ResumeLayout(False)
        Me.grpNumbers.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlChocolate As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents grpNumbers As GroupBox
    Friend WithEvents lblLowPrint As Label
    Friend WithEvents lblHighPrint As Label
    Friend WithEvents lblLow As Label
    Friend WithEvents lblHigh As Label
    Friend WithEvents lblTwo As Label
    Friend WithEvents lblOne As Label
    Friend WithEvents txtTwo As TextBox
    Friend WithEvents txtOne As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
