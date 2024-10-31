<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSportsRentals
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMonthly = New System.Windows.Forms.TextBox()
        Me.txtWeekly = New System.Windows.Forms.TextBox()
        Me.txtDaily = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.cboIdNumber = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(258, 232)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(159, 24)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(258, 198)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(159, 24)
        Me.btnRemove.TabIndex = 19
        Me.btnRemove.Text = "Remove Current Item"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(258, 164)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(159, 24)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Add Current Item"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 12)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Quantity"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(103, 270)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(43, 19)
        Me.txtQuantity.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMonthly)
        Me.GroupBox1.Controls.Add(Me.txtWeekly)
        Me.GroupBox1.Controls.Add(Me.txtDaily)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 141)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rates"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Monthly"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Weekly"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Daily"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMonthly
        '
        Me.txtMonthly.Location = New System.Drawing.Point(104, 105)
        Me.txtMonthly.Name = "txtMonthly"
        Me.txtMonthly.Size = New System.Drawing.Size(64, 19)
        Me.txtMonthly.TabIndex = 2
        '
        'txtWeekly
        '
        Me.txtWeekly.Location = New System.Drawing.Point(104, 69)
        Me.txtWeekly.Name = "txtWeekly"
        Me.txtWeekly.Size = New System.Drawing.Size(64, 19)
        Me.txtWeekly.TabIndex = 1
        '
        'txtDaily
        '
        Me.txtDaily.Location = New System.Drawing.Point(104, 32)
        Me.txtDaily.Name = "txtDaily"
        Me.txtDaily.Size = New System.Drawing.Size(64, 19)
        Me.txtDaily.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 12)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(25, 66)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(392, 19)
        Me.txtDescription.TabIndex = 13
        '
        'cboIdNumber
        '
        Me.cboIdNumber.FormattingEnabled = True
        Me.cboIdNumber.Location = New System.Drawing.Point(25, 38)
        Me.cboIdNumber.Name = "cboIdNumber"
        Me.cboIdNumber.Size = New System.Drawing.Size(121, 20)
        Me.cboIdNumber.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID Number"
        '
        'frmSportsRentals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 314)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.cboIdNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSportsRentals"
        Me.Text = "FirstPlay Sports Rentals"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMonthly As TextBox
    Friend WithEvents txtWeekly As TextBox
    Friend WithEvents txtDaily As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents cboIdNumber As ComboBox
    Friend WithEvents Label1 As Label
End Class
