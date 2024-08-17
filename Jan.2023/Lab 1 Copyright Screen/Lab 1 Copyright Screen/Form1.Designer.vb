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
        Me.lblCreateBy = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCreateBy
        '
        Me.lblCreateBy.AutoSize = True
        Me.lblCreateBy.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCreateBy.ForeColor = System.Drawing.Color.Gold
        Me.lblCreateBy.Location = New System.Drawing.Point(27, 19)
        Me.lblCreateBy.Name = "lblCreateBy"
        Me.lblCreateBy.Size = New System.Drawing.Size(356, 25)
        Me.lblCreateBy.TabIndex = 0
        Me.lblCreateBy.Text = "Applicaion Create By: Shiyu Chen"
        Me.lblCreateBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCopyright.ForeColor = System.Drawing.Color.Gold
        Me.lblCopyright.Location = New System.Drawing.Point(250, 61)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(133, 19)
        Me.lblCopyright.TabIndex = 1
        Me.lblCopyright.Text = "Copyright 2023"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(409, 101)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblCreateBy)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab 1 - Copyright Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCreateBy As Label
    Friend WithEvents lblCopyright As Label
End Class
