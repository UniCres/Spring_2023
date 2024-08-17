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
        Me.btnDo = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.nudTime = New System.Windows.Forms.NumericUpDown()
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtPhrase = New System.Windows.Forms.TextBox()
        Me.lbxRepeat = New System.Windows.Forms.ListBox()
        Me.picBart = New System.Windows.Forms.PictureBox()
        CType(Me.nudTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDo
        '
        Me.btnDo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDo.Location = New System.Drawing.Point(482, 30)
        Me.btnDo.Name = "btnDo"
        Me.btnDo.Size = New System.Drawing.Size(96, 45)
        Me.btnDo.TabIndex = 0
        Me.btnDo.Text = "Do it"
        Me.btnDo.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(482, 100)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 45)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'nudTime
        '
        Me.nudTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nudTime.Location = New System.Drawing.Point(75, 120)
        Me.nudTime.Maximum = New Decimal(New Integer() {1569325056, 23283064, 0, 0})
        Me.nudTime.Name = "nudTime"
        Me.nudTime.Size = New System.Drawing.Size(102, 29)
        Me.nudTime.TabIndex = 2
        Me.nudTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPhrase
        '
        Me.lblPhrase.AutoSize = True
        Me.lblPhrase.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPhrase.Location = New System.Drawing.Point(66, 30)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(134, 21)
        Me.lblPhrase.TabIndex = 3
        Me.lblPhrase.Text = "Phrase to Repeat"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTime.Location = New System.Drawing.Point(66, 93)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(122, 21)
        Me.lblTime.TabIndex = 4
        Me.lblTime.Text = "Time to Repeat"
        '
        'txtPhrase
        '
        Me.txtPhrase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhrase.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPhrase.Location = New System.Drawing.Point(75, 57)
        Me.txtPhrase.Name = "txtPhrase"
        Me.txtPhrase.Size = New System.Drawing.Size(343, 29)
        Me.txtPhrase.TabIndex = 5
        Me.txtPhrase.Text = "I WILL NOT CHEW GUM IN CLASS."
        '
        'lbxRepeat
        '
        Me.lbxRepeat.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.lbxRepeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbxRepeat.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lbxRepeat.ForeColor = System.Drawing.Color.White
        Me.lbxRepeat.FormattingEnabled = True
        Me.lbxRepeat.ItemHeight = 19
        Me.lbxRepeat.Items.AddRange(New Object() {" I WILL NOT CHEW GUM IN CLASS."})
        Me.lbxRepeat.Location = New System.Drawing.Point(75, 169)
        Me.lbxRepeat.Name = "lbxRepeat"
        Me.lbxRepeat.Size = New System.Drawing.Size(503, 230)
        Me.lbxRepeat.TabIndex = 6
        '
        'picBart
        '
        Me.picBart.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.picBart.Image = CType(resources.GetObject("picBart.Image"), System.Drawing.Image)
        Me.picBart.Location = New System.Drawing.Point(451, 225)
        Me.picBart.Name = "picBart"
        Me.picBart.Size = New System.Drawing.Size(103, 174)
        Me.picBart.TabIndex = 7
        Me.picBart.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 461)
        Me.Controls.Add(Me.picBart)
        Me.Controls.Add(Me.lbxRepeat)
        Me.Controls.Add(Me.txtPhrase)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.nudTime)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDo)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lab 8 - Repeat Words"
        CType(Me.nudTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDo As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents nudTime As NumericUpDown
    Friend WithEvents lblPhrase As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents txtPhrase As TextBox
    Friend WithEvents lbxRepeat As ListBox
    Friend WithEvents picBart As PictureBox
End Class
