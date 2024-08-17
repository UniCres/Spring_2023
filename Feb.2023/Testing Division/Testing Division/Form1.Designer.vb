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
        Me.btnRegular = New System.Windows.Forms.Button()
        Me.btnInteger = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.lblRegular = New System.Windows.Forms.Label()
        Me.lblInteger = New System.Windows.Forms.Label()
        Me.lblMod = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRegular
        '
        Me.btnRegular.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRegular.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRegular.Location = New System.Drawing.Point(66, 92)
        Me.btnRegular.Name = "btnRegular"
        Me.btnRegular.Size = New System.Drawing.Size(195, 52)
        Me.btnRegular.TabIndex = 1
        Me.btnRegular.Text = "Testing /"
        Me.btnRegular.UseVisualStyleBackColor = False
        '
        'btnInteger
        '
        Me.btnInteger.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnInteger.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnInteger.Location = New System.Drawing.Point(66, 200)
        Me.btnInteger.Name = "btnInteger"
        Me.btnInteger.Size = New System.Drawing.Size(195, 52)
        Me.btnInteger.TabIndex = 2
        Me.btnInteger.Text = "Testing \"
        Me.btnInteger.UseVisualStyleBackColor = False
        '
        'btnMod
        '
        Me.btnMod.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMod.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMod.Location = New System.Drawing.Point(66, 308)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(195, 52)
        Me.btnMod.TabIndex = 3
        Me.btnMod.Text = "Testing Mod"
        Me.btnMod.UseVisualStyleBackColor = False
        '
        'lblRegular
        '
        Me.lblRegular.AutoSize = True
        Me.lblRegular.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegular.Location = New System.Drawing.Point(325, 102)
        Me.lblRegular.Name = "lblRegular"
        Me.lblRegular.Size = New System.Drawing.Size(202, 32)
        Me.lblRegular.TabIndex = 3
        Me.lblRegular.Text = "Regular Division"
        '
        'lblInteger
        '
        Me.lblInteger.AutoSize = True
        Me.lblInteger.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInteger.Location = New System.Drawing.Point(325, 210)
        Me.lblInteger.Name = "lblInteger"
        Me.lblInteger.Size = New System.Drawing.Size(197, 32)
        Me.lblInteger.TabIndex = 4
        Me.lblInteger.Text = "Integer Division"
        '
        'lblMod
        '
        Me.lblMod.AutoSize = True
        Me.lblMod.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMod.Location = New System.Drawing.Point(325, 318)
        Me.lblMod.Name = "lblMod"
        Me.lblMod.Size = New System.Drawing.Size(67, 32)
        Me.lblMod.TabIndex = 5
        Me.lblMod.Text = "Mod"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(584, 461)
        Me.Controls.Add(Me.lblMod)
        Me.Controls.Add(Me.lblInteger)
        Me.Controls.Add(Me.lblRegular)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnInteger)
        Me.Controls.Add(Me.btnRegular)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Testing Division"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegular As Button
    Friend WithEvents btnInteger As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents lblRegular As Label
    Friend WithEvents lblInteger As Label
    Friend WithEvents lblMod As Label
End Class
