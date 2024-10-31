<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccounts
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
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(207, 210)
        Me.btnReplace.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(155, 36)
        Me.btnReplace.TabIndex = 19
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 151)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Balance:"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(205, 143)
        Me.txtBalance.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(124, 25)
        Me.txtBalance.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(470, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Accounts:"
        '
        'lstBox
        '
        Me.lstBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.ItemHeight = 18
        Me.lstBox.Location = New System.Drawing.Point(475, 54)
        Me.lstBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(432, 166)
        Me.lstBox.TabIndex = 15
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(42, 210)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(125, 36)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Account Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(205, 86)
        Me.txtName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(226, 25)
        Me.txtName.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Account ID:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(205, 26)
        Me.txtId.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(124, 25)
        Me.txtId.TabIndex = 10
        '
        'frmAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 285)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstBox)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtId)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmAccounts"
        Me.Text = "Accounts Dictionary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReplace As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lstBox As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
End Class
