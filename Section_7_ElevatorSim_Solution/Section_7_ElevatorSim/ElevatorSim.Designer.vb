<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ElevatorSim
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
        Me.pnlElevator = New System.Windows.Forms.Panel()
        Me.lblPassengers = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblFloorNumber = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlElevator.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlElevator
        '
        Me.pnlElevator.BackColor = System.Drawing.SystemColors.HotTrack
        Me.pnlElevator.Controls.Add(Me.lblPassengers)
        Me.pnlElevator.Location = New System.Drawing.Point(167, 62)
        Me.pnlElevator.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlElevator.Name = "pnlElevator"
        Me.pnlElevator.Size = New System.Drawing.Size(133, 34)
        Me.pnlElevator.TabIndex = 0
        '
        'lblPassengers
        '
        Me.lblPassengers.AutoSize = True
        Me.lblPassengers.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblPassengers.Location = New System.Drawing.Point(50, 11)
        Me.lblPassengers.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblPassengers.Name = "lblPassengers"
        Me.lblPassengers.Size = New System.Drawing.Size(30, 30)
        Me.lblPassengers.TabIndex = 0
        Me.lblPassengers.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'lblFloorNumber
        '
        Me.lblFloorNumber.AutoSize = True
        Me.lblFloorNumber.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblFloorNumber.Location = New System.Drawing.Point(563, 57)
        Me.lblFloorNumber.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFloorNumber.Name = "lblFloorNumber"
        Me.lblFloorNumber.Size = New System.Drawing.Size(0, 33)
        Me.lblFloorNumber.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(471, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Floor:"
        '
        'ElevatorSim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 888)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFloorNumber)
        Me.Controls.Add(Me.pnlElevator)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "ElevatorSim"
        Me.Text = "Elevator Simulation"
        Me.pnlElevator.ResumeLayout(False)
        Me.pnlElevator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPassengers As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblFloorNumber As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlElevator As Panel
End Class
