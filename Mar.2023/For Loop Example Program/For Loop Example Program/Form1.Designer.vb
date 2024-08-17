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
        Me.btnUp1 = New System.Windows.Forms.Button()
        Me.btnDown1 = New System.Windows.Forms.Button()
        Me.btnUp2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUp1
        '
        Me.btnUp1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUp1.Location = New System.Drawing.Point(83, 56)
        Me.btnUp1.Name = "btnUp1"
        Me.btnUp1.Size = New System.Drawing.Size(270, 60)
        Me.btnUp1.TabIndex = 0
        Me.btnUp1.Text = "Loop Up By One"
        Me.btnUp1.UseVisualStyleBackColor = True
        '
        'btnDown1
        '
        Me.btnDown1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDown1.Location = New System.Drawing.Point(83, 151)
        Me.btnDown1.Name = "btnDown1"
        Me.btnDown1.Size = New System.Drawing.Size(270, 60)
        Me.btnDown1.TabIndex = 1
        Me.btnDown1.Text = "Loop Down By One"
        Me.btnDown1.UseVisualStyleBackColor = True
        '
        'btnUp2
        '
        Me.btnUp2.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnUp2.Location = New System.Drawing.Point(83, 248)
        Me.btnUp2.Name = "btnUp2"
        Me.btnUp2.Size = New System.Drawing.Size(270, 60)
        Me.btnUp2.TabIndex = 2
        Me.btnUp2.Text = "Loop Up By Two"
        Me.btnUp2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(441, 371)
        Me.Controls.Add(Me.btnUp2)
        Me.Controls.Add(Me.btnDown1)
        Me.Controls.Add(Me.btnUp1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "For Loop Example"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnUp1 As Button
    Friend WithEvents btnDown1 As Button
    Friend WithEvents btnUp2 As Button
End Class
