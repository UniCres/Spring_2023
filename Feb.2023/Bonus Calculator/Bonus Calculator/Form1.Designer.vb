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
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtBonus = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(91, 326)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(192, 45)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnQuit.Location = New System.Drawing.Point(357, 326)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(192, 45)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Calisto MT", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(108, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(398, 54)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Bonus Calculator"
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSales.Location = New System.Drawing.Point(91, 106)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(130, 25)
        Me.lblSales.TabIndex = 2
        Me.lblSales.Text = "Sales Amount"
        '
        'lblBonus
        '
        Me.lblBonus.AutoSize = True
        Me.lblBonus.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBonus.Location = New System.Drawing.Point(385, 106)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(139, 25)
        Me.lblBonus.TabIndex = 3
        Me.lblBonus.Text = "Bonus Amount"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRate.Location = New System.Drawing.Point(91, 210)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(218, 25)
        Me.lblRate.TabIndex = 5
        Me.lblRate.Text = "Bonus Rate (such as .07)"
        '
        'txtSales
        '
        Me.txtSales.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtSales.Location = New System.Drawing.Point(91, 147)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(164, 33)
        Me.txtSales.TabIndex = 1
        '
        'txtBonus
        '
        Me.txtBonus.Enabled = False
        Me.txtBonus.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtBonus.Location = New System.Drawing.Point(385, 147)
        Me.txtBonus.Name = "txtBonus"
        Me.txtBonus.Size = New System.Drawing.Size(164, 33)
        Me.txtBonus.TabIndex = 7
        Me.txtBonus.TabStop = False
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtRate.Location = New System.Drawing.Point(91, 252)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(164, 33)
        Me.txtRate.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(634, 411)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtBonus)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblBonus)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program 1 - Bonus Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSales As Label
    Friend WithEvents lblBonus As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents txtBonus As TextBox
    Friend WithEvents txtRate As TextBox
End Class
