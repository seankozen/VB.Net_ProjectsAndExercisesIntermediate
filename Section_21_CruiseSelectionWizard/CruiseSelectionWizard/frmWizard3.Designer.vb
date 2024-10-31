<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWizard3
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
        Me.radInformal = New System.Windows.Forms.RadioButton()
        Me.radFormal = New System.Windows.Forms.RadioButton()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'radInformal
        '
        Me.radInformal.AutoSize = True
        Me.radInformal.Location = New System.Drawing.Point(125, 166)
        Me.radInformal.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.radInformal.Name = "radInformal"
        Me.radInformal.Size = New System.Drawing.Size(92, 22)
        Me.radInformal.TabIndex = 19
        Me.radInformal.Text = "Informal"
        Me.radInformal.UseVisualStyleBackColor = True
        '
        'radFormal
        '
        Me.radFormal.AutoSize = True
        Me.radFormal.Checked = True
        Me.radFormal.Location = New System.Drawing.Point(125, 108)
        Me.radFormal.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.radFormal.Name = "radFormal"
        Me.radFormal.Size = New System.Drawing.Size(84, 22)
        Me.radFormal.TabIndex = 18
        Me.radFormal.TabStop = True
        Me.radFormal.Text = "Formal"
        Me.radFormal.UseVisualStyleBackColor = True
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(42, 30)
        Me.lblQuestion.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(407, 24)
        Me.lblQuestion.TabIndex = 17
        Me.lblQuestion.Text = "What type of dress do you prefer at meals?"
        '
        'btnPrevious
        '
        Me.btnPrevious.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrevious.Location = New System.Drawing.Point(47, 234)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(133, 39)
        Me.btnPrevious.TabIndex = 16
        Me.btnPrevious.Text = "Prev"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(415, 234)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(133, 39)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'frmWizard3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 325)
        Me.Controls.Add(Me.radInformal)
        Me.Controls.Add(Me.radFormal)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmWizard3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Step 3: Select Dress Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radInformal As RadioButton
    Friend WithEvents radFormal As RadioButton
    Friend WithEvents lblQuestion As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
