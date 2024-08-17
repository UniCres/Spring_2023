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
        Me.grpOuter = New System.Windows.Forms.GroupBox()
        Me.nudOStart = New System.Windows.Forms.NumericUpDown()
        Me.lblOutStart = New System.Windows.Forms.Label()
        Me.lblOutStop = New System.Windows.Forms.Label()
        Me.nudOStop = New System.Windows.Forms.NumericUpDown()
        Me.grpInner = New System.Windows.Forms.GroupBox()
        Me.lblInStop = New System.Windows.Forms.Label()
        Me.lblInStart = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.nudIStart = New System.Windows.Forms.NumericUpDown()
        Me.nudIStop = New System.Windows.Forms.NumericUpDown()
        Me.grpOuter.SuspendLayout()
        CType(Me.nudOStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudOStop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInner.SuspendLayout()
        CType(Me.nudIStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIStop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpOuter
        '
        Me.grpOuter.Controls.Add(Me.nudOStop)
        Me.grpOuter.Controls.Add(Me.lblOutStop)
        Me.grpOuter.Controls.Add(Me.lblOutStart)
        Me.grpOuter.Controls.Add(Me.nudOStart)
        Me.grpOuter.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpOuter.Location = New System.Drawing.Point(70, 30)
        Me.grpOuter.Name = "grpOuter"
        Me.grpOuter.Size = New System.Drawing.Size(364, 146)
        Me.grpOuter.TabIndex = 0
        Me.grpOuter.TabStop = False
        Me.grpOuter.Text = "Outer Loop"
        '
        'nudOStart
        '
        Me.nudOStart.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.nudOStart.Location = New System.Drawing.Point(46, 81)
        Me.nudOStart.Name = "nudOStart"
        Me.nudOStart.Size = New System.Drawing.Size(98, 33)
        Me.nudOStart.TabIndex = 0
        '
        'lblOutStart
        '
        Me.lblOutStart.AutoSize = True
        Me.lblOutStart.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOutStart.Location = New System.Drawing.Point(33, 42)
        Me.lblOutStart.Name = "lblOutStart"
        Me.lblOutStart.Size = New System.Drawing.Size(129, 25)
        Me.lblOutStart.TabIndex = 1
        Me.lblOutStart.Text = "Start Number"
        '
        'lblOutStop
        '
        Me.lblOutStop.AutoSize = True
        Me.lblOutStop.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOutStop.Location = New System.Drawing.Point(207, 42)
        Me.lblOutStop.Name = "lblOutStop"
        Me.lblOutStop.Size = New System.Drawing.Size(126, 25)
        Me.lblOutStop.TabIndex = 2
        Me.lblOutStop.Text = "Stop Number"
        '
        'nudOStop
        '
        Me.nudOStop.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.nudOStop.Location = New System.Drawing.Point(222, 81)
        Me.nudOStop.Name = "nudOStop"
        Me.nudOStop.Size = New System.Drawing.Size(98, 33)
        Me.nudOStop.TabIndex = 3
        '
        'grpInner
        '
        Me.grpInner.Controls.Add(Me.nudIStop)
        Me.grpInner.Controls.Add(Me.nudIStart)
        Me.grpInner.Controls.Add(Me.lblInStop)
        Me.grpInner.Controls.Add(Me.lblInStart)
        Me.grpInner.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpInner.Location = New System.Drawing.Point(70, 205)
        Me.grpInner.Name = "grpInner"
        Me.grpInner.Size = New System.Drawing.Size(364, 146)
        Me.grpInner.TabIndex = 4
        Me.grpInner.TabStop = False
        Me.grpInner.Text = "Inner Loop"
        '
        'lblInStop
        '
        Me.lblInStop.AutoSize = True
        Me.lblInStop.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInStop.Location = New System.Drawing.Point(207, 42)
        Me.lblInStop.Name = "lblInStop"
        Me.lblInStop.Size = New System.Drawing.Size(126, 25)
        Me.lblInStop.TabIndex = 2
        Me.lblInStop.Text = "Stop Number"
        '
        'lblInStart
        '
        Me.lblInStart.AutoSize = True
        Me.lblInStart.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInStart.Location = New System.Drawing.Point(33, 42)
        Me.lblInStart.Name = "lblInStart"
        Me.lblInStart.Size = New System.Drawing.Size(129, 25)
        Me.lblInStart.TabIndex = 1
        Me.lblInStart.Text = "Start Number"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnStart.Location = New System.Drawing.Point(192, 382)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(122, 40)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'nudIStart
        '
        Me.nudIStart.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.nudIStart.Location = New System.Drawing.Point(46, 82)
        Me.nudIStart.Name = "nudIStart"
        Me.nudIStart.Size = New System.Drawing.Size(98, 33)
        Me.nudIStart.TabIndex = 3
        '
        'nudIStop
        '
        Me.nudIStop.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.nudIStop.Location = New System.Drawing.Point(222, 82)
        Me.nudIStop.Name = "nudIStop"
        Me.nudIStop.Size = New System.Drawing.Size(98, 33)
        Me.nudIStop.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.ClientSize = New System.Drawing.Size(500, 450)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.grpInner)
        Me.Controls.Add(Me.grpOuter)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nested Loop Example"
        Me.grpOuter.ResumeLayout(False)
        Me.grpOuter.PerformLayout()
        CType(Me.nudOStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudOStop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInner.ResumeLayout(False)
        Me.grpInner.PerformLayout()
        CType(Me.nudIStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIStop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpOuter As GroupBox
    Friend WithEvents nudOStop As NumericUpDown
    Friend WithEvents lblOutStop As Label
    Friend WithEvents lblOutStart As Label
    Friend WithEvents nudOStart As NumericUpDown
    Friend WithEvents grpInner As GroupBox
    Friend WithEvents nudIStop As NumericUpDown
    Friend WithEvents nudIStart As NumericUpDown
    Friend WithEvents lblInStop As Label
    Friend WithEvents lblInStart As Label
    Friend WithEvents btnStart As Button
End Class
