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
        Me.chbToday = New System.Windows.Forms.CheckBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'chbToday
        '
        Me.chbToday.AutoSize = True
        Me.chbToday.Checked = True
        Me.chbToday.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbToday.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chbToday.Location = New System.Drawing.Point(179, 97)
        Me.chbToday.Name = "chbToday"
        Me.chbToday.Size = New System.Drawing.Size(160, 36)
        Me.chbToday.TabIndex = 0
        Me.chbToday.Text = "From Today"
        Me.chbToday.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(23, 37)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(478, 30)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Calculate Number of Days Until Summer Break!"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDate.Location = New System.Drawing.Point(138, 167)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(246, 30)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "or Choose Another Date"
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.Tan
        Me.btnFind.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFind.Location = New System.Drawing.Point(179, 300)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(160, 57)
        Me.btnFind.TabIndex = 3
        Me.btnFind.Text = "Find Out"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'dtpDate
        '
        Me.dtpDate.Enabled = False
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtpDate.Location = New System.Drawing.Point(125, 232)
        Me.dtpDate.MaxDate = New Date(2023, 6, 3, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(271, 29)
        Me.dtpDate.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(524, 391)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.chbToday)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Days Left to Summer Break"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chbToday As CheckBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnFind As Button
    Friend WithEvents dtpDate As DateTimePicker
End Class
