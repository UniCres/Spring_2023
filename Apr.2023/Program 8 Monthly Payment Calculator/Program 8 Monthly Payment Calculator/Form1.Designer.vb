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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPrin = New System.Windows.Forms.Label()
        Me.txtP = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblMP = New System.Windows.Forms.Label()
        Me.txtMP = New System.Windows.Forms.TextBox()
        Me.mnsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnsMain
        '
        Me.mnsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsFile, Me.mnsHelp})
        Me.mnsMain.Location = New System.Drawing.Point(0, 0)
        Me.mnsMain.Name = "mnsMain"
        Me.mnsMain.Size = New System.Drawing.Size(508, 24)
        Me.mnsMain.TabIndex = 0
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
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.Navy
        Me.lblTitle.Location = New System.Drawing.Point(50, 48)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(409, 40)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Monthly Payment Calculator"
        '
        'lblPrin
        '
        Me.lblPrin.AutoSize = True
        Me.lblPrin.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPrin.ForeColor = System.Drawing.Color.Navy
        Me.lblPrin.Location = New System.Drawing.Point(50, 107)
        Me.lblPrin.Name = "lblPrin"
        Me.lblPrin.Size = New System.Drawing.Size(94, 30)
        Me.lblPrin.TabIndex = 2
        Me.lblPrin.Text = "Principal"
        '
        'txtP
        '
        Me.txtP.BackColor = System.Drawing.Color.Honeydew
        Me.txtP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtP.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtP.Location = New System.Drawing.Point(50, 140)
        Me.txtP.Name = "txtP"
        Me.txtP.Size = New System.Drawing.Size(138, 29)
        Me.txtP.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Honeydew
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(169, 429)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(171, 56)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblMP
        '
        Me.lblMP.AutoSize = True
        Me.lblMP.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMP.ForeColor = System.Drawing.Color.Navy
        Me.lblMP.Location = New System.Drawing.Point(50, 185)
        Me.lblMP.Name = "lblMP"
        Me.lblMP.Size = New System.Drawing.Size(191, 30)
        Me.lblMP.TabIndex = 5
        Me.lblMP.Text = "Monthly Payments"
        '
        'txtMP
        '
        Me.txtMP.BackColor = System.Drawing.Color.Honeydew
        Me.txtMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMP.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtMP.Location = New System.Drawing.Point(50, 218)
        Me.txtMP.Multiline = True
        Me.txtMP.Name = "txtMP"
        Me.txtMP.Size = New System.Drawing.Size(409, 193)
        Me.txtMP.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(508, 499)
        Me.Controls.Add(Me.txtMP)
        Me.Controls.Add(Me.lblMP)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtP)
        Me.Controls.Add(Me.lblPrin)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnsMain)
        Me.MainMenuStrip = Me.mnsMain
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program 8 - Monthly Payment Calculator"
        Me.mnsMain.ResumeLayout(False)
        Me.mnsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnsMain As MenuStrip
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPrin As Label
    Friend WithEvents mnsFile As ToolStripMenuItem
    Friend WithEvents mnsExit As ToolStripMenuItem
    Friend WithEvents mnsHelp As ToolStripMenuItem
    Friend WithEvents mnsAbout As ToolStripMenuItem
    Friend WithEvents txtP As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblMP As Label
    Friend WithEvents txtMP As TextBox
End Class
