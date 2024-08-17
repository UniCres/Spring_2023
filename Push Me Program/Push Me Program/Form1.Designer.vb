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
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnTop = New System.Windows.Forms.Button()
        Me.btnBottom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLeft
        '
        Me.btnLeft.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnLeft.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLeft.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnLeft.Location = New System.Drawing.Point(343, 159)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(118, 61)
        Me.btnLeft.TabIndex = 1
        Me.btnLeft.Text = "No, Push Me"
        Me.btnLeft.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Red
        Me.btnQuit.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnQuit.Location = New System.Drawing.Point(343, 356)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(144, 64)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Get Me Outta Here!!"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnRight
        '
        Me.btnRight.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnRight.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRight.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnRight.Location = New System.Drawing.Point(59, 159)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(118, 61)
        Me.btnRight.TabIndex = 5
        Me.btnRight.Text = "No, Push Me"
        Me.btnRight.UseVisualStyleBackColor = False
        '
        'btnTop
        '
        Me.btnTop.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnTop.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTop.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnTop.Location = New System.Drawing.Point(201, 61)
        Me.btnTop.Name = "btnTop"
        Me.btnTop.Size = New System.Drawing.Size(118, 61)
        Me.btnTop.TabIndex = 6
        Me.btnTop.Text = "Push Me Please"
        Me.btnTop.UseVisualStyleBackColor = False
        '
        'btnBottom
        '
        Me.btnBottom.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnBottom.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBottom.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnBottom.Location = New System.Drawing.Point(201, 255)
        Me.btnBottom.Name = "btnBottom"
        Me.btnBottom.Size = New System.Drawing.Size(118, 61)
        Me.btnBottom.TabIndex = 7
        Me.btnBottom.Text = "No, Push Me"
        Me.btnBottom.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(534, 461)
        Me.Controls.Add(Me.btnBottom)
        Me.Controls.Add(Me.btnTop)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnLeft)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Push Me Please"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLeft As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnTop As Button
    Friend WithEvents btnBottom As Button
End Class
