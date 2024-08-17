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
        Me.lblFind = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Font = New System.Drawing.Font("Lucida Bright", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEnter.Location = New System.Drawing.Point(89, 102)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(356, 22)
        Me.lblEnter.TabIndex = 0
        Me.lblEnter.Text = "Enter Band Name in Textbox Please!"
        '
        'lblFind
        '
        Me.lblFind.AutoSize = True
        Me.lblFind.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFind.Location = New System.Drawing.Point(26, 40)
        Me.lblFind.Name = "lblFind"
        Me.lblFind.Size = New System.Drawing.Size(484, 23)
        Me.lblFind.TabIndex = 1
        Me.lblFind.Text = "Find Out What Genre Your Favorite Band Is!"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtName.Location = New System.Drawing.Point(132, 168)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(262, 33)
        Me.txtName.TabIndex = 2
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("Britannic Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFind.Location = New System.Drawing.Point(175, 242)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(180, 49)
        Me.btnFind.TabIndex = 3
        Me.btnFind.Text = "Find Genre"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(534, 331)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblFind)
        Me.Controls.Add(Me.lblEnter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bands Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnter As Label
    Friend WithEvents lblFind As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnFind As Button
End Class
