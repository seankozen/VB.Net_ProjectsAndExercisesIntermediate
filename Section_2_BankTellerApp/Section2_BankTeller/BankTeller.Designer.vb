<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankTeller
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
        Me.txtAccNum = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.txtHolderName = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnSaveBalance = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAccountName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAccNum
        '
        Me.txtAccNum.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAccNum.Location = New System.Drawing.Point(164, 35)
        Me.txtAccNum.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAccNum.Name = "txtAccNum"
        Me.txtAccNum.Size = New System.Drawing.Size(140, 23)
        Me.txtAccNum.TabIndex = 0
        '
        'txtBalance
        '
        Me.txtBalance.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtBalance.Location = New System.Drawing.Point(533, 128)
        Me.txtBalance.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(164, 23)
        Me.txtBalance.TabIndex = 1
        '
        'txtHolderName
        '
        Me.txtHolderName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtHolderName.Location = New System.Drawing.Point(24, 115)
        Me.txtHolderName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHolderName.Name = "txtHolderName"
        Me.txtHolderName.Size = New System.Drawing.Size(239, 23)
        Me.txtHolderName.TabIndex = 2
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(284, 67)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(167, 23)
        Me.txtAmount.TabIndex = 3
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnFind.Location = New System.Drawing.Point(326, 25)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(68, 34)
        Me.btnFind.TabIndex = 4
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnDeposit
        '
        Me.btnDeposit.Enabled = False
        Me.btnDeposit.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDeposit.Location = New System.Drawing.Point(33, 28)
        Me.btnDeposit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(117, 33)
        Me.btnDeposit.TabIndex = 5
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Enabled = False
        Me.btnWithdraw.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnWithdraw.Location = New System.Drawing.Point(33, 109)
        Me.btnWithdraw.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(117, 33)
        Me.btnWithdraw.TabIndex = 6
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(533, 194)
        Me.btnTotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(124, 31)
        Me.btnTotal.TabIndex = 7
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnSaveBalance
        '
        Me.btnSaveBalance.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSaveBalance.Location = New System.Drawing.Point(533, 245)
        Me.btnSaveBalance.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSaveBalance.Name = "btnSaveBalance"
        Me.btnSaveBalance.Size = New System.Drawing.Size(124, 61)
        Me.btnSaveBalance.TabIndex = 8
        Me.btnSaveBalance.Text = "Save Balance"
        Me.btnSaveBalance.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnClose.Location = New System.Drawing.Point(533, 333)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(124, 31)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnDeposit)
        Me.GroupBox1.Controls.Add(Me.btnWithdraw)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 194)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(474, 170)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select an action:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Account number:"
        '
        'lblAccountName
        '
        Me.lblAccountName.AutoSize = True
        Me.lblAccountName.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblAccountName.Location = New System.Drawing.Point(22, 89)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(153, 16)
        Me.lblAccountName.TabIndex = 12
        Me.lblAccountName.Text = "Account holder name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(186, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(553, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Balance:"
        '
        'BankTeller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 425)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblAccountName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSaveBalance)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtHolderName)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtAccNum)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "BankTeller"
        Me.Text = "Bank Teller Application"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAccNum As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents txtHolderName As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnSaveBalance As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAccountName As Label
    Friend WithEvents Label4 As Label
End Class
