﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElevator
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
        Me.lblFloorNumber = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlElevator = New System.Windows.Forms.Panel()
        Me.lblPassengers = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlElevator.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFloorNumber
        '
        Me.lblFloorNumber.AutoSize = True
        Me.lblFloorNumber.Location = New System.Drawing.Point(246, 31)
        Me.lblFloorNumber.Name = "lblFloorNumber"
        Me.lblFloorNumber.Size = New System.Drawing.Size(13, 13)
        Me.lblFloorNumber.TabIndex = 5
        Me.lblFloorNumber.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Floor:"
        '
        'pnlElevator
        '
        Me.pnlElevator.BackColor = System.Drawing.Color.Silver
        Me.pnlElevator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlElevator.Controls.Add(Me.lblPassengers)
        Me.pnlElevator.Location = New System.Drawing.Point(14, 114)
        Me.pnlElevator.Name = "pnlElevator"
        Me.pnlElevator.Size = New System.Drawing.Size(77, 26)
        Me.pnlElevator.TabIndex = 3
        '
        'lblPassengers
        '
        Me.lblPassengers.AutoSize = True
        Me.lblPassengers.Location = New System.Drawing.Point(29, 6)
        Me.lblPassengers.Name = "lblPassengers"
        Me.lblPassengers.Size = New System.Drawing.Size(13, 13)
        Me.lblPassengers.TabIndex = 0
        Me.lblPassengers.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'frmElevator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 313)
        Me.Controls.Add(Me.lblFloorNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlElevator)
        Me.Name = "frmElevator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elevator"
        Me.pnlElevator.ResumeLayout(False)
        Me.pnlElevator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFloorNumber As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlElevator As Panel
    Friend WithEvents lblPassengers As Label
    Friend WithEvents Timer1 As Timer
End Class
