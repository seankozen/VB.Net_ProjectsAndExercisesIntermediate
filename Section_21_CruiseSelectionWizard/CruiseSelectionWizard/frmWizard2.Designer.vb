<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWizard2
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
        Me.lstRegion = New System.Windows.Forms.ListBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstRegion
        '
        Me.lstRegion.FormattingEnabled = True
        Me.lstRegion.ItemHeight = 18
        Me.lstRegion.Location = New System.Drawing.Point(157, 84)
        Me.lstRegion.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.lstRegion.Name = "lstRegion"
        Me.lstRegion.Size = New System.Drawing.Size(531, 148)
        Me.lstRegion.TabIndex = 18
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(80, 37)
        Me.lblQuestion.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(405, 24)
        Me.lblQuestion.TabIndex = 17
        Me.lblQuestion.Text = "Which geographical region do you prefer?"
        '
        'btnPrevious
        '
        Me.btnPrevious.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrevious.Location = New System.Drawing.Point(87, 325)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(133, 39)
        Me.btnPrevious.TabIndex = 16
        Me.btnPrevious.Text = "Prev"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(680, 325)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(133, 39)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(303, 251)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(172, 18)
        Me.lblMessage.TabIndex = 14
        Me.lblMessage.Text = "Please select a region"
        Me.lblMessage.Visible = False
        '
        'frmWizard2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 422)
        Me.Controls.Add(Me.lstRegion)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblMessage)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmWizard2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Step 2: Select Region"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstRegion As ListBox
    Friend WithEvents lblQuestion As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblMessage As Label
End Class
