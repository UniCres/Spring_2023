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
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtTable = New System.Windows.Forms.TextBox()
        Me.pnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Navy
        Me.pnlTitle.Controls.Add(Me.lblTable)
        Me.pnlTitle.Location = New System.Drawing.Point(33, 25)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(621, 104)
        Me.pnlTitle.TabIndex = 0
        '
        'lblTable
        '
        Me.lblTable.AutoSize = True
        Me.lblTable.Font = New System.Drawing.Font("Sylfaen", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTable.ForeColor = System.Drawing.Color.Snow
        Me.lblTable.Location = New System.Drawing.Point(66, 24)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(493, 48)
        Me.lblTable.TabIndex = 0
        Me.lblTable.Text = "10 X 10 Multiplication Table"
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.Navy
        Me.btnCreate.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCreate.ForeColor = System.Drawing.Color.Snow
        Me.btnCreate.Location = New System.Drawing.Point(246, 425)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(191, 60)
        Me.btnCreate.TabIndex = 1
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'txtTable
        '
        Me.txtTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTable.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTable.Location = New System.Drawing.Point(33, 156)
        Me.txtTable.Multiline = True
        Me.txtTable.Name = "txtTable"
        Me.txtTable.ReadOnly = True
        Me.txtTable.Size = New System.Drawing.Size(621, 252)
        Me.txtTable.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(688, 511)
        Me.Controls.Add(Me.txtTable)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.pnlTitle)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiplication Table"
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblTable As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents txtTable As TextBox
End Class
