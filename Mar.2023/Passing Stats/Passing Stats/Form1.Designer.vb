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
        Me.btnFind = New System.Windows.Forms.Button()
        Me.picQuarter = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblYard = New System.Windows.Forms.Label()
        Me.nudYard = New System.Windows.Forms.NumericUpDown()
        CType(Me.picQuarter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudYard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnFind.Location = New System.Drawing.Point(181, 458)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(175, 52)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "Find Out!"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'picQuarter
        '
        Me.picQuarter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picQuarter.Image = CType(resources.GetObject("picQuarter.Image"), System.Drawing.Image)
        Me.picQuarter.Location = New System.Drawing.Point(109, 90)
        Me.picQuarter.Name = "picQuarter"
        Me.picQuarter.Size = New System.Drawing.Size(345, 229)
        Me.picQuarter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picQuarter.TabIndex = 1
        Me.picQuarter.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Snap ITC", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(123, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(322, 48)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Passing Stats"
        '
        'lblYard
        '
        Me.lblYard.AutoSize = True
        Me.lblYard.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblYard.Location = New System.Drawing.Point(33, 345)
        Me.lblYard.Name = "lblYard"
        Me.lblYard.Size = New System.Drawing.Size(482, 25)
        Me.lblYard.TabIndex = 3
        Me.lblYard.Text = "Enter Total Yards Passing by Your Favorite Quarterback!"
        '
        'nudYard
        '
        Me.nudYard.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nudYard.Location = New System.Drawing.Point(158, 397)
        Me.nudYard.Maximum = New Decimal(New Integer() {-1593835520, 466537709, 54210, 0})
        Me.nudYard.Name = "nudYard"
        Me.nudYard.Size = New System.Drawing.Size(225, 33)
        Me.nudYard.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(554, 531)
        Me.Controls.Add(Me.nudYard)
        Me.Controls.Add(Me.lblYard)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picQuarter)
        Me.Controls.Add(Me.btnFind)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Passing Stats"
        CType(Me.picQuarter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudYard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFind As Button
    Friend WithEvents picQuarter As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblYard As Label
    Friend WithEvents nudYard As NumericUpDown
End Class
