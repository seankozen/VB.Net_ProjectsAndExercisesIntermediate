<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrainingWSApp
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
        Me.lstWorkshops = New System.Windows.Forms.ListBox()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstWorkshops
        '
        Me.lstWorkshops.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lstWorkshops.FormattingEnabled = True
        Me.lstWorkshops.ItemHeight = 24
        Me.lstWorkshops.Location = New System.Drawing.Point(17, 25)
        Me.lstWorkshops.Name = "lstWorkshops"
        Me.lstWorkshops.Size = New System.Drawing.Size(916, 484)
        Me.lstWorkshops.TabIndex = 0
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(36, 563)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(153, 60)
        Me.btnDetails.TabIndex = 1
        Me.btnDetails.Text = "Show Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtResult.Location = New System.Drawing.Point(220, 581)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(657, 31)
        Me.txtResult.TabIndex = 2
        '
        'TrainingWSApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 690)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.lstWorkshops)
        Me.Name = "TrainingWSApp"
        Me.Text = "Training Workshop App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstWorkshops As ListBox
    Friend WithEvents btnDetails As Button
    Friend WithEvents txtResult As TextBox
End Class
