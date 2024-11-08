<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddMember
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Date_JoinedLabel As System.Windows.Forms.Label
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Date_JoinedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.KarateMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CRUDKarateDataSet = New KarateMemberDates.CRUDKarateDataSet()
        Me.MembersTableAdapter = New KarateMemberDates.CRUDKarateDataSetTableAdapters.MembersTableAdapter()
        IDLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Date_JoinedLabel = New System.Windows.Forms.Label()
        CType(Me.KarateMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRUDKarateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(47, 17)
        IDLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(28, 18)
        IDLabel.TabIndex = 24
        IDLabel.Text = "ID:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(47, 57)
        Last_NameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(93, 18)
        Last_NameLabel.TabIndex = 16
        Last_NameLabel.Text = "Last Name:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(47, 93)
        First_NameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(94, 18)
        First_NameLabel.TabIndex = 19
        First_NameLabel.Text = "First Name:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(47, 129)
        PhoneLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(59, 18)
        PhoneLabel.TabIndex = 21
        PhoneLabel.Text = "Phone:"
        '
        'Date_JoinedLabel
        '
        Date_JoinedLabel.AutoSize = True
        Date_JoinedLabel.Location = New System.Drawing.Point(47, 166)
        Date_JoinedLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Date_JoinedLabel.Name = "Date_JoinedLabel"
        Date_JoinedLabel.Size = New System.Drawing.Size(103, 18)
        Date_JoinedLabel.TabIndex = 22
        Date_JoinedLabel.Text = "Date Joined:"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KarateMembersBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(168, 53)
        Me.Last_NameTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(331, 25)
        Me.Last_NameTextBox.TabIndex = 14
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KarateMembersBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(168, 89)
        Me.First_NameTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(331, 25)
        Me.First_NameTextBox.TabIndex = 15
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KarateMembersBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(168, 125)
        Me.PhoneTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(331, 25)
        Me.PhoneTextBox.TabIndex = 17
        '
        'Date_JoinedDateTimePicker
        '
        Me.Date_JoinedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KarateMembersBindingSource, "Date_Joined", True))
        Me.Date_JoinedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_JoinedDateTimePicker.Location = New System.Drawing.Point(168, 161)
        Me.Date_JoinedDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Date_JoinedDateTimePicker.Name = "Date_JoinedDateTimePicker"
        Me.Date_JoinedDateTimePicker.Size = New System.Drawing.Size(172, 25)
        Me.Date_JoinedDateTimePicker.TabIndex = 18
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(218, 213)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(125, 32)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KarateMembersBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(168, 17)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(97, 25)
        Me.IDTextBox.TabIndex = 13
        '
        'KarateMembersBindingSource
        '
        Me.KarateMembersBindingSource.DataMember = "Members"
        Me.KarateMembersBindingSource.DataSource = Me.CRUDKarateDataSet
        '
        'CRUDKarateDataSet
        '
        Me.CRUDKarateDataSet.DataSetName = "CRUDKarateDataSet"
        Me.CRUDKarateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'frmAddMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 278)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Date_JoinedLabel)
        Me.Controls.Add(Me.Date_JoinedDateTimePicker)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.IDTextBox)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmAddMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Member"
        CType(Me.KarateMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRUDKarateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Date_JoinedDateTimePicker As DateTimePicker
    Friend WithEvents btnUpdate As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents KarateMembersBindingSource As BindingSource
    Friend WithEvents CRUDKarateDataSet As CRUDKarateDataSet
    Friend WithEvents MembersTableAdapter As CRUDKarateDataSetTableAdapters.MembersTableAdapter
End Class
