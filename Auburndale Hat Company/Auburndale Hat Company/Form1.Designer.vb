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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.grpHat = New System.Windows.Forms.GroupBox()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.txtWhite = New System.Windows.Forms.TextBox()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.lblWhite = New System.Windows.Forms.Label()
        Me.grpTotal = New System.Windows.Forms.GroupBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtSold = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblSold = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.mnsMain = New System.Windows.Forms.MenuStrip()
        Me.mnsFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpInfo.SuspendLayout()
        Me.grpHat.SuspendLayout()
        Me.grpTotal.SuspendLayout()
        Me.mnsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(44, 476)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(164, 44)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate Order"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCheck.Location = New System.Drawing.Point(232, 476)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(164, 44)
        Me.btnCheck.TabIndex = 11
        Me.btnCheck.Text = "Check Out"
        Me.btnCheck.UseVisualStyleBackColor = True
        Me.btnCheck.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(417, 476)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(164, 44)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear Screen"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'grpInfo
        '
        Me.grpInfo.Controls.Add(Me.txtZip)
        Me.grpInfo.Controls.Add(Me.txtState)
        Me.grpInfo.Controls.Add(Me.txtAddress)
        Me.grpInfo.Controls.Add(Me.txtCity)
        Me.grpInfo.Controls.Add(Me.txtName)
        Me.grpInfo.Controls.Add(Me.lblZip)
        Me.grpInfo.Controls.Add(Me.lblState)
        Me.grpInfo.Controls.Add(Me.lblCity)
        Me.grpInfo.Controls.Add(Me.lblAddress)
        Me.grpInfo.Controls.Add(Me.lblName)
        Me.grpInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpInfo.Location = New System.Drawing.Point(53, 117)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(528, 115)
        Me.grpInfo.TabIndex = 3
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Sales Information"
        '
        'txtZip
        '
        Me.txtZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtZip.Location = New System.Drawing.Point(443, 75)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(55, 29)
        Me.txtZip.TabIndex = 5
        Me.txtZip.Text = "29582"
        '
        'txtState
        '
        Me.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtState.Location = New System.Drawing.Point(340, 75)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(56, 29)
        Me.txtState.TabIndex = 4
        Me.txtState.Text = "SC"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Location = New System.Drawing.Point(83, 75)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(199, 29)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.Text = "3750 Sea Mountain Hwy"
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Location = New System.Drawing.Point(340, 30)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(160, 29)
        Me.txtCity.TabIndex = 2
        Me.txtCity.Text = "North Myrtle Beach"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(83, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(199, 29)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = "NMB High School"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblZip.Location = New System.Drawing.Point(403, 78)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(34, 20)
        Me.lblZip.TabIndex = 4
        Me.lblZip.Text = "Zip:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblState.Location = New System.Drawing.Point(288, 78)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(46, 20)
        Me.lblState.TabIndex = 3
        Me.lblState.Text = "State:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCity.Location = New System.Drawing.Point(297, 33)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(37, 20)
        Me.lblCity.TabIndex = 2
        Me.lblCity.Text = "City:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAddress.Location = New System.Drawing.Point(12, 78)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(65, 20)
        Me.lblAddress.TabIndex = 1
        Me.lblAddress.Text = "Address:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(25, 33)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(52, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'grpHat
        '
        Me.grpHat.Controls.Add(Me.txtRed)
        Me.grpHat.Controls.Add(Me.txtGreen)
        Me.grpHat.Controls.Add(Me.txtBlue)
        Me.grpHat.Controls.Add(Me.txtWhite)
        Me.grpHat.Controls.Add(Me.lblGreen)
        Me.grpHat.Controls.Add(Me.lblRed)
        Me.grpHat.Controls.Add(Me.lblBlue)
        Me.grpHat.Controls.Add(Me.lblWhite)
        Me.grpHat.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpHat.Location = New System.Drawing.Point(53, 256)
        Me.grpHat.Name = "grpHat"
        Me.grpHat.Size = New System.Drawing.Size(204, 198)
        Me.grpHat.TabIndex = 4
        Me.grpHat.TabStop = False
        Me.grpHat.Text = "Hats Purchased"
        '
        'txtRed
        '
        Me.txtRed.BackColor = System.Drawing.Color.Red
        Me.txtRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRed.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtRed.ForeColor = System.Drawing.Color.White
        Me.txtRed.Location = New System.Drawing.Point(74, 148)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(100, 27)
        Me.txtRed.TabIndex = 9
        Me.txtRed.Text = "5"
        '
        'txtGreen
        '
        Me.txtGreen.BackColor = System.Drawing.Color.DarkGreen
        Me.txtGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGreen.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtGreen.ForeColor = System.Drawing.Color.White
        Me.txtGreen.Location = New System.Drawing.Point(74, 108)
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(100, 27)
        Me.txtGreen.TabIndex = 8
        Me.txtGreen.Text = "4"
        '
        'txtBlue
        '
        Me.txtBlue.BackColor = System.Drawing.Color.DarkBlue
        Me.txtBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBlue.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBlue.ForeColor = System.Drawing.Color.White
        Me.txtBlue.Location = New System.Drawing.Point(74, 68)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(100, 27)
        Me.txtBlue.TabIndex = 7
        Me.txtBlue.Text = "2"
        '
        'txtWhite
        '
        Me.txtWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWhite.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtWhite.Location = New System.Drawing.Point(74, 28)
        Me.txtWhite.Name = "txtWhite"
        Me.txtWhite.Size = New System.Drawing.Size(100, 27)
        Me.txtWhite.TabIndex = 6
        Me.txtWhite.Text = "1"
        '
        'lblGreen
        '
        Me.lblGreen.AutoSize = True
        Me.lblGreen.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblGreen.Location = New System.Drawing.Point(15, 108)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(48, 20)
        Me.lblGreen.TabIndex = 8
        Me.lblGreen.Text = "Green"
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRed.Location = New System.Drawing.Point(28, 148)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(35, 20)
        Me.lblRed.TabIndex = 7
        Me.lblRed.Text = "Red"
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBlue.Location = New System.Drawing.Point(25, 68)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(38, 20)
        Me.lblBlue.TabIndex = 6
        Me.lblBlue.Text = "Blue"
        '
        'lblWhite
        '
        Me.lblWhite.AutoSize = True
        Me.lblWhite.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblWhite.Location = New System.Drawing.Point(15, 30)
        Me.lblWhite.Name = "lblWhite"
        Me.lblWhite.Size = New System.Drawing.Size(48, 20)
        Me.lblWhite.TabIndex = 5
        Me.lblWhite.Text = "White"
        '
        'grpTotal
        '
        Me.grpTotal.Controls.Add(Me.txtPrice)
        Me.grpTotal.Controls.Add(Me.txtSold)
        Me.grpTotal.Controls.Add(Me.lblPrice)
        Me.grpTotal.Controls.Add(Me.lblSold)
        Me.grpTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpTotal.Location = New System.Drawing.Point(304, 256)
        Me.grpTotal.Name = "grpTotal"
        Me.grpTotal.Size = New System.Drawing.Size(277, 141)
        Me.grpTotal.TabIndex = 5
        Me.grpTotal.TabStop = False
        Me.grpTotal.Text = "Totals"
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(145, 90)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(100, 29)
        Me.txtPrice.TabIndex = 11
        Me.txtPrice.TabStop = False
        '
        'txtSold
        '
        Me.txtSold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSold.Enabled = False
        Me.txtSold.Location = New System.Drawing.Point(145, 41)
        Me.txtSold.Name = "txtSold"
        Me.txtSold.ReadOnly = True
        Me.txtSold.Size = New System.Drawing.Size(100, 29)
        Me.txtSold.TabIndex = 8
        Me.txtSold.TabStop = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPrice.Location = New System.Drawing.Point(47, 93)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(81, 20)
        Me.lblPrice.TabIndex = 10
        Me.lblPrice.Text = "Total Price:"
        '
        'lblSold
        '
        Me.lblSold.AutoSize = True
        Me.lblSold.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSold.Location = New System.Drawing.Point(15, 44)
        Me.lblSold.Name = "lblSold"
        Me.lblSold.Size = New System.Drawing.Size(113, 20)
        Me.lblSold.TabIndex = 9
        Me.lblSold.Text = "Total Hats Sold:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(29, 44)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(584, 47)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "North Myrtle Beach Hat Company"
        '
        'mnsMain
        '
        Me.mnsMain.BackColor = System.Drawing.Color.LightGray
        Me.mnsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsFile, Me.mnsHelp})
        Me.mnsMain.Location = New System.Drawing.Point(0, 0)
        Me.mnsMain.Name = "mnsMain"
        Me.mnsMain.Size = New System.Drawing.Size(634, 24)
        Me.mnsMain.TabIndex = 7
        Me.mnsMain.Text = "MenuStrip1"
        '
        'mnsFile
        '
        Me.mnsFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsQuit})
        Me.mnsFile.Name = "mnsFile"
        Me.mnsFile.Size = New System.Drawing.Size(37, 20)
        Me.mnsFile.Text = "File"
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
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(634, 561)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpTotal)
        Me.Controls.Add(Me.grpHat)
        Me.Controls.Add(Me.grpInfo)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.mnsMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnsMain
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "North Myrtle Beach Hat Company"
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.grpHat.ResumeLayout(False)
        Me.grpHat.PerformLayout()
        Me.grpTotal.ResumeLayout(False)
        Me.grpTotal.PerformLayout()
        Me.mnsMain.ResumeLayout(False)
        Me.mnsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblZip As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblName As Label
    Friend WithEvents grpHat As GroupBox
    Friend WithEvents txtRed As TextBox
    Friend WithEvents txtGreen As TextBox
    Friend WithEvents txtBlue As TextBox
    Friend WithEvents txtWhite As TextBox
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblRed As Label
    Friend WithEvents lblBlue As Label
    Friend WithEvents lblWhite As Label
    Friend WithEvents grpTotal As GroupBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtSold As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblSold As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents mnsMain As MenuStrip
    Friend WithEvents mnsFile As ToolStripMenuItem
    Friend WithEvents mnsQuit As ToolStripMenuItem
    Friend WithEvents mnsHelp As ToolStripMenuItem
    Friend WithEvents mnsAbout As ToolStripMenuItem
End Class
