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
        Me.lblHello = New System.Windows.Forms.Label()
        Me.lblClick = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.picMHHS = New System.Windows.Forms.PictureBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnAppear = New System.Windows.Forms.Button()
        CType(Me.picMHHS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Font = New System.Drawing.Font("Cooper Black", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblHello.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblHello.Location = New System.Drawing.Point(349, 40)
        Me.lblHello.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(202, 74)
        Me.lblHello.TabIndex = 0
        Me.lblHello.Text = "Hello"
        Me.lblHello.Visible = False
        '
        'lblClick
        '
        Me.lblClick.AutoSize = True
        Me.lblClick.BackColor = System.Drawing.Color.MediumBlue
        Me.lblClick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClick.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblClick.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblClick.Location = New System.Drawing.Point(284, 145)
        Me.lblClick.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClick.Name = "lblClick"
        Me.lblClick.Size = New System.Drawing.Size(337, 23)
        Me.lblClick.TabIndex = 1
        Me.lblClick.Text = "Click the picture to get a message"
        Me.lblClick.Visible = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMessage.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblMessage.Location = New System.Drawing.Point(59, 224)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(560, 24)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.Text = "The Mustang is Mountain House High Schol's Mascot"
        Me.lblMessage.Visible = False
        '
        'picMHHS
        '
        Me.picMHHS.BackColor = System.Drawing.Color.White
        Me.picMHHS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picMHHS.Image = CType(resources.GetObject("picMHHS.Image"), System.Drawing.Image)
        Me.picMHHS.Location = New System.Drawing.Point(59, 26)
        Me.picMHHS.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.picMHHS.Name = "picMHHS"
        Me.picMHHS.Size = New System.Drawing.Size(181, 169)
        Me.picMHHS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMHHS.TabIndex = 3
        Me.picMHHS.TabStop = False
        Me.picMHHS.Visible = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.MediumBlue
        Me.btnRemove.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRemove.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnRemove.Location = New System.Drawing.Point(80, 362)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(135, 58)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove the Messages"
        Me.btnRemove.UseVisualStyleBackColor = False
        Me.btnRemove.Visible = False
        '
        'btnMessage
        '
        Me.btnMessage.BackColor = System.Drawing.Color.MediumBlue
        Me.btnMessage.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMessage.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMessage.Location = New System.Drawing.Point(284, 278)
        Me.btnMessage.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(135, 58)
        Me.btnMessage.TabIndex = 5
        Me.btnMessage.Text = "A Message from Me"
        Me.btnMessage.UseVisualStyleBackColor = False
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.MediumBlue
        Me.btnDone.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDone.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDone.Location = New System.Drawing.Point(284, 362)
        Me.btnDone.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(135, 58)
        Me.btnDone.TabIndex = 6
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = False
        Me.btnDone.Visible = False
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.MediumBlue
        Me.btnHide.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHide.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnHide.Location = New System.Drawing.Point(484, 278)
        Me.btnHide.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(135, 58)
        Me.btnHide.TabIndex = 7
        Me.btnHide.Text = "Hide Pictures"
        Me.btnHide.UseVisualStyleBackColor = False
        Me.btnHide.Visible = False
        '
        'btnAppear
        '
        Me.btnAppear.BackColor = System.Drawing.Color.MediumBlue
        Me.btnAppear.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAppear.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAppear.Location = New System.Drawing.Point(484, 362)
        Me.btnAppear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAppear.Name = "btnAppear"
        Me.btnAppear.Size = New System.Drawing.Size(135, 58)
        Me.btnAppear.TabIndex = 8
        Me.btnAppear.Text = "Make Picture Appear"
        Me.btnAppear.UseVisualStyleBackColor = False
        Me.btnAppear.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.btnAppear)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnMessage)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.picMHHS)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblClick)
        Me.Controls.Add(Me.lblHello)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My First Program"
        CType(Me.picMHHS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHello As Label
    Friend WithEvents lblClick As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents picMHHS As PictureBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnMessage As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents btnHide As Button
    Friend WithEvents btnAppear As Button
End Class
