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
        Me.btnFind = New System.Windows.Forms.Button()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.Tan
        Me.btnFind.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFind.Location = New System.Drawing.Point(111, 306)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(159, 54)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblArea.Location = New System.Drawing.Point(80, 30)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(221, 45)
        Me.lblArea.TabIndex = 1
        Me.lblArea.Text = "Find the Area"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLength.Location = New System.Drawing.Point(121, 97)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(71, 25)
        Me.lblLength.TabIndex = 2
        Me.lblLength.Text = "Length"
        '
        'txtLength
        '
        Me.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLength.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtLength.Location = New System.Drawing.Point(121, 135)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(140, 33)
        Me.txtLength.TabIndex = 3
        '
        'txtWidth
        '
        Me.txtWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWidth.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtWidth.Location = New System.Drawing.Point(121, 232)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(140, 33)
        Me.txtWidth.TabIndex = 5
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblWidth.Location = New System.Drawing.Point(121, 195)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(64, 25)
        Me.lblWidth.TabIndex = 4
        Me.lblWidth.Text = "Width"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(375, 393)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.btnFind)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parameter Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFind As Button
    Friend WithEvents lblArea As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents lblWidth As Label
End Class
