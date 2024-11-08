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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblAverageSalary = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radPartTime = New System.Windows.Forms.RadioButton()
        Me.radFullTime = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesStaffDataSet = New SalesStaffSalaries.SalesStaffDataSet()
        Me.SalesStaffTableAdapter = New SalesStaffSalaries.SalesStaffDataSetTableAdapters.SalesStaffTableAdapter()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesStaffDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SalesStaffBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 127)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(540, 320)
        Me.DataGridView1.TabIndex = 11
        '
        'lblAverageSalary
        '
        Me.lblAverageSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageSalary.Location = New System.Drawing.Point(277, 60)
        Me.lblAverageSalary.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblAverageSalary.Name = "lblAverageSalary"
        Me.lblAverageSalary.Size = New System.Drawing.Size(167, 32)
        Me.lblAverageSalary.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Average salary:"
        '
        'radPartTime
        '
        Me.radPartTime.AutoSize = True
        Me.radPartTime.Location = New System.Drawing.Point(445, 7)
        Me.radPartTime.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radPartTime.Name = "radPartTime"
        Me.radPartTime.Size = New System.Drawing.Size(102, 22)
        Me.radPartTime.TabIndex = 8
        Me.radPartTime.Text = "Part time"
        Me.radPartTime.UseVisualStyleBackColor = True
        '
        'radFullTime
        '
        Me.radFullTime.AutoSize = True
        Me.radFullTime.Checked = True
        Me.radFullTime.Location = New System.Drawing.Point(307, 7)
        Me.radFullTime.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.radFullTime.Name = "radFullTime"
        Me.radFullTime.Size = New System.Drawing.Size(97, 22)
        Me.radFullTime.TabIndex = 7
        Me.radFullTime.TabStop = True
        Me.radFullTime.Text = "Full time"
        Me.radFullTime.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select employment status:"
        '
        'SalesStaffBindingSource
        '
        Me.SalesStaffBindingSource.DataMember = "SalesStaff"
        Me.SalesStaffBindingSource.DataSource = Me.SalesStaffDataSet
        '
        'SalesStaffDataSet
        '
        Me.SalesStaffDataSet.DataSetName = "SalesStaffDataSet"
        Me.SalesStaffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesStaffTableAdapter
        '
        Me.SalesStaffTableAdapter.ClearBeforeFill = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn.Width = 150
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn.Width = 150
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        Me.SalaryDataGridViewTextBoxColumn.ReadOnly = True
        Me.SalaryDataGridViewTextBoxColumn.Width = 150
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 474)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblAverageSalary)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.radPartTime)
        Me.Controls.Add(Me.radFullTime)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Staff Salaries"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesStaffDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblAverageSalary As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents radPartTime As RadioButton
    Friend WithEvents radFullTime As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents SalesStaffBindingSource As BindingSource
    Friend WithEvents SalesStaffDataSet As SalesStaffDataSet
    Friend WithEvents SalesStaffTableAdapter As SalesStaffDataSetTableAdapters.SalesStaffTableAdapter
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
