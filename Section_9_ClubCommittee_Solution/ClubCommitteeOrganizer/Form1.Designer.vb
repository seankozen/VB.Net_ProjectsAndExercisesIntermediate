﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommittee
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstCommMembers = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCommittees = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstAllMembers = New System.Windows.Forms.ListBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 424)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 23, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(793, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 15)
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(357, 226)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(97, 37)
        Me.btnRemove.TabIndex = 23
        Me.btnRemove.Text = "<--"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(357, 161)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(97, 37)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "-->"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(492, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 26)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Current Members"
        '
        'lstCommMembers
        '
        Me.lstCommMembers.FormattingEnabled = True
        Me.lstCommMembers.ItemHeight = 18
        Me.lstCommMembers.Location = New System.Drawing.Point(497, 100)
        Me.lstCommMembers.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lstCommMembers.Name = "lstCommMembers"
        Me.lstCommMembers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstCommMembers.Size = New System.Drawing.Size(231, 220)
        Me.lstCommMembers.Sorted = True
        Me.lstCommMembers.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 30)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "General Member List"
        '
        'cboCommittees
        '
        Me.cboCommittees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCommittees.FormattingEnabled = True
        Me.cboCommittees.Items.AddRange(New Object() {"Activities", "Community Services", "Executive", "Membership", "Programming Team", "Scholarship", "Sports", "Travel", "Volunteer Tutoring", "", ""})
        Me.cboCommittees.Location = New System.Drawing.Point(317, 15)
        Me.cboCommittees.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cboCommittees.Name = "cboCommittees"
        Me.cboCommittees.Size = New System.Drawing.Size(341, 26)
        Me.cboCommittees.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Select a Committee"
        '
        'lstAllMembers
        '
        Me.lstAllMembers.FormattingEnabled = True
        Me.lstAllMembers.ItemHeight = 18
        Me.lstAllMembers.Items.AddRange(New Object() {"Adams, Ben", "Baker, Sam", "Chong, Anne", "Davis, Sandra", "Easterlin, John", "Fernandez, Jose", "Fox, Barbara", "Gomez, Ignacio", "Halperin, James", "Iams, Jeffrey", "Johnson, Beth", "Kenwood, Brian", "Saint Pierre, Justin"})
        Me.lstAllMembers.Location = New System.Drawing.Point(45, 100)
        Me.lstAllMembers.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lstAllMembers.Name = "lstAllMembers"
        Me.lstAllMembers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstAllMembers.Size = New System.Drawing.Size(259, 166)
        Me.lstAllMembers.TabIndex = 16
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(328, 350)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(125, 37)
        Me.btnQuit.TabIndex = 15
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmCommittee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 446)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstCommMembers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboCommittees)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstAllMembers)
        Me.Controls.Add(Me.btnQuit)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmCommittee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Club Committee Organizer"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lstCommMembers As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboCommittees As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstAllMembers As ListBox
    Friend WithEvents btnQuit As Button
End Class
