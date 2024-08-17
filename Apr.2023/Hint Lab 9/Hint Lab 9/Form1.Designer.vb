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
        Me.btnTry = New System.Windows.Forms.Button()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnTry
        '
        Me.btnTry.BackColor = System.Drawing.Color.Cyan
        Me.btnTry.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTry.Location = New System.Drawing.Point(181, 312)
        Me.btnTry.Name = "btnTry"
        Me.btnTry.Size = New System.Drawing.Size(122, 53)
        Me.btnTry.TabIndex = 0
        Me.btnTry.Text = "Try It"
        Me.btnTry.UseVisualStyleBackColor = False
        '
        'txtOut
        '
        Me.txtOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOut.Location = New System.Drawing.Point(69, 47)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(348, 221)
        Me.txtOut.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(489, 405)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.btnTry)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab 9 Hint"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTry As Button
    Friend WithEvents txtOut As TextBox
End Class
