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
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.grpDes = New System.Windows.Forms.GroupBox()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.grpDes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEnter.Location = New System.Drawing.Point(64, 30)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(353, 47)
        Me.lblEnter.TabIndex = 0
        Me.lblEnter.Text = "Enter a Letter Grade"
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSubmit.Location = New System.Drawing.Point(180, 327)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(120, 50)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'grpDes
        '
        Me.grpDes.Controls.Add(Me.txtDes)
        Me.grpDes.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpDes.Location = New System.Drawing.Point(76, 156)
        Me.grpDes.Name = "grpDes"
        Me.grpDes.Size = New System.Drawing.Size(328, 139)
        Me.grpDes.TabIndex = 2
        Me.grpDes.TabStop = False
        Me.grpDes.Text = "Description"
        '
        'txtDes
        '
        Me.txtDes.BackColor = System.Drawing.Color.White
        Me.txtDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDes.Enabled = False
        Me.txtDes.Location = New System.Drawing.Point(21, 34)
        Me.txtDes.Multiline = True
        Me.txtDes.Name = "txtDes"
        Me.txtDes.ReadOnly = True
        Me.txtDes.Size = New System.Drawing.Size(288, 82)
        Me.txtDes.TabIndex = 0
        Me.txtDes.TabStop = False
        '
        'txtGrade
        '
        Me.txtGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrade.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtGrade.Location = New System.Drawing.Point(201, 101)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(80, 29)
        Me.txtGrade.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(484, 411)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.grpDes)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblEnter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab 7 - Grade Descriptions"
        Me.grpDes.ResumeLayout(False)
        Me.grpDes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnter As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents grpDes As GroupBox
    Friend WithEvents txtDes As TextBox
    Friend WithEvents txtGrade As TextBox
End Class
