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
        Me.lblAge = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.nudAge = New System.Windows.Forms.NumericUpDown()
        Me.lblClick = New System.Windows.Forms.Label()
        CType(Me.nudAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Rockwell", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAge.Location = New System.Drawing.Point(102, 58)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(384, 59)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "Enter Your Age"
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFind.Location = New System.Drawing.Point(215, 306)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(161, 56)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "Find Out"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'nudAge
        '
        Me.nudAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudAge.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.nudAge.Location = New System.Drawing.Point(215, 154)
        Me.nudAge.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudAge.Name = "nudAge"
        Me.nudAge.Size = New System.Drawing.Size(161, 39)
        Me.nudAge.TabIndex = 2
        '
        'lblClick
        '
        Me.lblClick.AutoSize = True
        Me.lblClick.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblClick.Location = New System.Drawing.Point(32, 233)
        Me.lblClick.Name = "lblClick"
        Me.lblClick.Size = New System.Drawing.Size(526, 47)
        Me.lblClick.TabIndex = 3
        Me.lblClick.Text = "Click to Check if You Can Drive"
        Me.lblClick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.Controls.Add(Me.lblClick)
        Me.Controls.Add(Me.nudAge)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.lblAge)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Driving Example"
        CType(Me.nudAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAge As Label
    Friend WithEvents btnFind As Button
    Friend WithEvents nudAge As NumericUpDown
    Friend WithEvents lblClick As Label
End Class
