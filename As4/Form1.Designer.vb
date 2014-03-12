<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCalc = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblMath = New System.Windows.Forms.Label
        Me.lblRead = New System.Windows.Forms.Label
        Me.lblSciHis = New System.Windows.Forms.Label
        Me.txtMath = New System.Windows.Forms.TextBox
        Me.txtRead = New System.Windows.Forms.TextBox
        Me.txtSciHis = New System.Windows.Forms.TextBox
        Me.lblAvg = New System.Windows.Forms.Label
        Me.lblAvgScore = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(197, 14)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 42)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(197, 70)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 42)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 123)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 42)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMath
        '
        Me.lblMath.AutoSize = True
        Me.lblMath.Location = New System.Drawing.Point(44, 29)
        Me.lblMath.Name = "lblMath"
        Me.lblMath.Size = New System.Drawing.Size(34, 13)
        Me.lblMath.TabIndex = 0
        Me.lblMath.Text = "&Math:"
        '
        'lblRead
        '
        Me.lblRead.AutoSize = True
        Me.lblRead.Location = New System.Drawing.Point(17, 62)
        Me.lblRead.Name = "lblRead"
        Me.lblRead.Size = New System.Drawing.Size(88, 13)
        Me.lblRead.TabIndex = 2
        Me.lblRead.Text = "&Reading/Writing:"
        '
        'lblSciHis
        '
        Me.lblSciHis.AutoSize = True
        Me.lblSciHis.Location = New System.Drawing.Point(18, 95)
        Me.lblSciHis.Name = "lblSciHis"
        Me.lblSciHis.Size = New System.Drawing.Size(86, 13)
        Me.lblSciHis.TabIndex = 4
        Me.lblSciHis.Text = "&Science/History:"
        '
        'txtMath
        '
        Me.txtMath.Location = New System.Drawing.Point(107, 22)
        Me.txtMath.Name = "txtMath"
        Me.txtMath.Size = New System.Drawing.Size(70, 20)
        Me.txtMath.TabIndex = 1
        '
        'txtRead
        '
        Me.txtRead.Location = New System.Drawing.Point(107, 55)
        Me.txtRead.Name = "txtRead"
        Me.txtRead.Size = New System.Drawing.Size(70, 20)
        Me.txtRead.TabIndex = 3
        '
        'txtSciHis
        '
        Me.txtSciHis.Location = New System.Drawing.Point(107, 88)
        Me.txtSciHis.Name = "txtSciHis"
        Me.txtSciHis.Size = New System.Drawing.Size(70, 20)
        Me.txtSciHis.TabIndex = 5
        '
        'lblAvg
        '
        Me.lblAvg.AutoSize = True
        Me.lblAvg.Location = New System.Drawing.Point(36, 143)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(50, 13)
        Me.lblAvg.TabIndex = 9
        Me.lblAvg.Text = "Average:"
        '
        'lblAvgScore
        '
        Me.lblAvgScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvgScore.Location = New System.Drawing.Point(107, 138)
        Me.lblAvgScore.Name = "lblAvgScore"
        Me.lblAvgScore.Size = New System.Drawing.Size(70, 23)
        Me.lblAvgScore.TabIndex = 10
        Me.lblAvgScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(287, 177)
        Me.Controls.Add(Me.lblAvgScore)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.txtSciHis)
        Me.Controls.Add(Me.txtRead)
        Me.Controls.Add(Me.txtMath)
        Me.Controls.Add(Me.lblSciHis)
        Me.Controls.Add(Me.lblRead)
        Me.Controls.Add(Me.lblMath)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Act Average Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblMath As System.Windows.Forms.Label
    Friend WithEvents lblRead As System.Windows.Forms.Label
    Friend WithEvents lblSciHis As System.Windows.Forms.Label
    Friend WithEvents txtMath As System.Windows.Forms.TextBox
    Friend WithEvents txtRead As System.Windows.Forms.TextBox
    Friend WithEvents txtSciHis As System.Windows.Forms.TextBox
    Friend WithEvents lblAvg As System.Windows.Forms.Label
    Friend WithEvents lblAvgScore As System.Windows.Forms.Label

End Class
