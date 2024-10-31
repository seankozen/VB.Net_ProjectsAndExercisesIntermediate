<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourse
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
        Me.components = New System.ComponentModel.Container()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCourseNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtCredits = New System.Windows.Forms.TextBox()
        Me.lstCourses = New System.Windows.Forms.ListBox()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(27, 300)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(125, 35)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(773, 51)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Existing Courses:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCourseNumber)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtGrade)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtCredits)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(715, 202)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Course Info"
        '
        'txtCourseNumber
        '
        Me.txtCourseNumber.Location = New System.Drawing.Point(242, 46)
        Me.txtCourseNumber.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtCourseNumber.Name = "txtCourseNumber"
        Me.txtCourseNumber.Size = New System.Drawing.Size(156, 25)
        Me.txtCourseNumber.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(437, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Credits"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Grade"
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(242, 91)
        Me.txtGrade.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(86, 25)
        Me.txtGrade.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(488, 97)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 39)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtCredits
        '
        Me.txtCredits.Location = New System.Drawing.Point(537, 43)
        Me.txtCredits.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.Size = New System.Drawing.Size(71, 25)
        Me.txtCredits.TabIndex = 1
        '
        'lstCourses
        '
        Me.lstCourses.FormattingEnabled = True
        Me.lstCourses.ItemHeight = 18
        Me.lstCourses.Location = New System.Drawing.Point(773, 78)
        Me.lstCourses.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lstCourses.Name = "lstCourses"
        Me.lstCourses.Size = New System.Drawing.Size(346, 202)
        Me.lstCourses.TabIndex = 15
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudent.Location = New System.Drawing.Point(193, 28)
        Me.lblStudent.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(125, 25)
        Me.lblStudent.TabIndex = 14
        Me.lblStudent.Text = "(lblStudent)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 26)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Student name:"
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'frmCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 378)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstCourses)
        Me.Controls.Add(Me.lblStudent)
        Me.Controls.Add(Me.Label4)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmCourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Course Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCourseNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtCredits As TextBox
    Friend WithEvents lstCourses As ListBox
    Friend WithEvents lblStudent As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents errProvider As ErrorProvider
End Class
