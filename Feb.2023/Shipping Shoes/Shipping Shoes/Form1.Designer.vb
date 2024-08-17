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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblShoes = New System.Windows.Forms.Label()
        Me.lblCrates = New System.Windows.Forms.Label()
        Me.lblBoxes = New System.Windows.Forms.Label()
        Me.txtShoes = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Mongolian Baiti", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.Location = New System.Drawing.Point(40, 273)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(171, 59)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.Font = New System.Drawing.Font("Mongolian Baiti", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(257, 273)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(170, 59)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.Font = New System.Drawing.Font("Mongolian Baiti", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(474, 273)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(170, 59)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblShoes
        '
        Me.lblShoes.AutoSize = True
        Me.lblShoes.Font = New System.Drawing.Font("Mongolian Baiti", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblShoes.Location = New System.Drawing.Point(40, 80)
        Me.lblShoes.Name = "lblShoes"
        Me.lblShoes.Size = New System.Drawing.Size(328, 29)
        Me.lblShoes.TabIndex = 3
        Me.lblShoes.Text = "# of needed pairs of shoes"
        '
        'lblCrates
        '
        Me.lblCrates.AutoSize = True
        Me.lblCrates.Font = New System.Drawing.Font("Mongolian Baiti", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCrates.Location = New System.Drawing.Point(145, 187)
        Me.lblCrates.Name = "lblCrates"
        Me.lblCrates.Size = New System.Drawing.Size(89, 29)
        Me.lblCrates.TabIndex = 4
        Me.lblCrates.Text = "Crates"
        '
        'lblBoxes
        '
        Me.lblBoxes.AutoSize = True
        Me.lblBoxes.Font = New System.Drawing.Font("Mongolian Baiti", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBoxes.Location = New System.Drawing.Point(474, 187)
        Me.lblBoxes.Name = "lblBoxes"
        Me.lblBoxes.Size = New System.Drawing.Size(87, 29)
        Me.lblBoxes.TabIndex = 5
        Me.lblBoxes.Text = "Boxes"
        '
        'txtShoes
        '
        Me.txtShoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShoes.Font = New System.Drawing.Font("Mongolian Baiti", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtShoes.Location = New System.Drawing.Point(410, 78)
        Me.txtShoes.Name = "txtShoes"
        Me.txtShoes.Size = New System.Drawing.Size(234, 39)
        Me.txtShoes.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(684, 391)
        Me.Controls.Add(Me.txtShoes)
        Me.Controls.Add(Me.lblBoxes)
        Me.Controls.Add(Me.lblCrates)
        Me.Controls.Add(Me.lblShoes)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shipping Shoes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblShoes As Label
    Friend WithEvents lblCrates As Label
    Friend WithEvents lblBoxes As Label
    Friend WithEvents txtShoes As TextBox
End Class
