<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWizard4
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
        Me.txtAverageAge = New System.Windows.Forms.TextBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAverageAge
        '
        Me.txtAverageAge.Location = New System.Drawing.Point(342, 100)
        Me.txtAverageAge.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtAverageAge.Name = "txtAverageAge"
        Me.txtAverageAge.Size = New System.Drawing.Size(129, 25)
        Me.txtAverageAge.TabIndex = 18
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(48, 25)
        Me.lblQuestion.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(428, 24)
        Me.lblQuestion.TabIndex = 17
        Me.lblQuestion.Text = "What should be the average passenger age?"
        '
        'btnPrevious
        '
        Me.btnPrevious.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrevious.Location = New System.Drawing.Point(57, 285)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(133, 39)
        Me.btnPrevious.TabIndex = 16
        Me.btnPrevious.Text = "Prev"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(447, 285)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(133, 39)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = "Finish"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(50, 220)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(173, 18)
        Me.lblMessage.TabIndex = 14
        Me.lblMessage.Text = "Please enter valid age"
        Me.lblMessage.Visible = False
        '
        'frmWizard4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 363)
        Me.Controls.Add(Me.txtAverageAge)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblMessage)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmWizard4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Step 4: Average Passanger Age"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAverageAge As TextBox
    Friend WithEvents lblQuestion As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblMessage As Label
End Class
