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
        Me.btnShow = New System.Windows.Forms.Button()
        Me.grpServices = New System.Windows.Forms.GroupBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.txtCut = New System.Windows.Forms.TextBox()
        Me.lblCut = New System.Windows.Forms.Label()
        Me.grpIncome = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.mnsMain = New System.Windows.Forms.MenuStrip()
        Me.mnsFIle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpServices.SuspendLayout()
        Me.grpIncome.SuspendLayout()
        Me.mnsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnShow.Location = New System.Drawing.Point(176, 386)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(154, 69)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "Show Me The Money!!"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'grpServices
        '
        Me.grpServices.Controls.Add(Me.txtHours)
        Me.grpServices.Controls.Add(Me.lblHours)
        Me.grpServices.Controls.Add(Me.txtCut)
        Me.grpServices.Controls.Add(Me.lblCut)
        Me.grpServices.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpServices.Location = New System.Drawing.Point(51, 105)
        Me.grpServices.Name = "grpServices"
        Me.grpServices.Size = New System.Drawing.Size(406, 138)
        Me.grpServices.TabIndex = 1
        Me.grpServices.TabStop = False
        Me.grpServices.Text = "Services"
        '
        'txtHours
        '
        Me.txtHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHours.Location = New System.Drawing.Point(233, 80)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(119, 29)
        Me.txtHours.TabIndex = 2
        Me.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHours.Location = New System.Drawing.Point(227, 41)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(132, 25)
        Me.lblHours.TabIndex = 2
        Me.lblHours.Text = "Hours Worked"
        '
        'txtCut
        '
        Me.txtCut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCut.Location = New System.Drawing.Point(46, 80)
        Me.txtCut.Name = "txtCut"
        Me.txtCut.Size = New System.Drawing.Size(119, 29)
        Me.txtCut.TabIndex = 1
        Me.txtCut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCut
        '
        Me.lblCut.AutoSize = True
        Me.lblCut.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCut.Location = New System.Drawing.Point(55, 41)
        Me.lblCut.Name = "lblCut"
        Me.lblCut.Size = New System.Drawing.Size(98, 25)
        Me.lblCut.TabIndex = 0
        Me.lblCut.Text = "Lawns Cut"
        '
        'grpIncome
        '
        Me.grpIncome.Controls.Add(Me.lblTotal)
        Me.grpIncome.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpIncome.Location = New System.Drawing.Point(81, 263)
        Me.grpIncome.Name = "grpIncome"
        Me.grpIncome.Size = New System.Drawing.Size(333, 96)
        Me.grpIncome.TabIndex = 2
        Me.grpIncome.TabStop = False
        Me.grpIncome.Text = "Daily Income"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.Location = New System.Drawing.Point(50, 41)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(225, 25)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "How Much I Made Today!"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(26, 52)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(466, 40)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Lawn Care Example Program"
        '
        'mnsMain
        '
        Me.mnsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsFIle, Me.mnsHelp})
        Me.mnsMain.Location = New System.Drawing.Point(0, 0)
        Me.mnsMain.Name = "mnsMain"
        Me.mnsMain.Size = New System.Drawing.Size(504, 24)
        Me.mnsMain.TabIndex = 4
        Me.mnsMain.Text = "MenuStrip1"
        '
        'mnsFIle
        '
        Me.mnsFIle.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsQuit})
        Me.mnsFIle.Name = "mnsFIle"
        Me.mnsFIle.Size = New System.Drawing.Size(37, 20)
        Me.mnsFIle.Text = "File"
        '
        'mnsQuit
        '
        Me.mnsQuit.Name = "mnsQuit"
        Me.mnsQuit.Size = New System.Drawing.Size(97, 22)
        Me.mnsQuit.Text = "Quit"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(504, 481)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpIncome)
        Me.Controls.Add(Me.grpServices)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.mnsMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnsMain
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lawn Care Example"
        Me.grpServices.ResumeLayout(False)
        Me.grpServices.PerformLayout()
        Me.grpIncome.ResumeLayout(False)
        Me.grpIncome.PerformLayout()
        Me.mnsMain.ResumeLayout(False)
        Me.mnsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShow As Button
    Friend WithEvents grpServices As GroupBox
    Friend WithEvents txtCut As TextBox
    Friend WithEvents lblCut As Label
    Friend WithEvents grpIncome As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents mnsMain As MenuStrip
    Friend WithEvents mnsFIle As ToolStripMenuItem
    Friend WithEvents mnsQuit As ToolStripMenuItem
    Friend WithEvents mnsHelp As ToolStripMenuItem
    Friend WithEvents mnsAbout As ToolStripMenuItem
    Friend WithEvents txtHours As TextBox
    Friend WithEvents lblHours As Label
End Class
