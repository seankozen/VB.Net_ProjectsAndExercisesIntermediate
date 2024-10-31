<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlight
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
        Me.txtDepartureTime = New System.Windows.Forms.TextBox()
        Me.lblArriveWhen = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDepartureDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboArrivalAirport = New System.Windows.Forms.ComboBox()
        Me.cboDepartureAirport = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtDepartureTime
        '
        Me.txtDepartureTime.Location = New System.Drawing.Point(28, 233)
        Me.txtDepartureTime.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtDepartureTime.Name = "txtDepartureTime"
        Me.txtDepartureTime.Size = New System.Drawing.Size(132, 25)
        Me.txtDepartureTime.TabIndex = 27
        '
        'lblArriveWhen
        '
        Me.lblArriveWhen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblArriveWhen.Location = New System.Drawing.Point(388, 152)
        Me.lblArriveWhen.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblArriveWhen.Name = "lblArriveWhen"
        Me.lblArriveWhen.Size = New System.Drawing.Size(275, 116)
        Me.lblArriveWhen.TabIndex = 26
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(282, 313)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(145, 39)
        Me.btnContinue.TabIndex = 25
        Me.btnContinue.Text = "Go"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 208)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 18)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Departure Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(388, 115)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 18)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Arrival Date/Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 18)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Departure Date:"
        '
        'dtpDepartureDate
        '
        Me.dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDepartureDate.Location = New System.Drawing.Point(28, 143)
        Me.dtpDepartureDate.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.dtpDepartureDate.Name = "dtpDepartureDate"
        Me.dtpDepartureDate.Size = New System.Drawing.Size(211, 25)
        Me.dtpDepartureDate.TabIndex = 21
        Me.dtpDepartureDate.Value = New Date(2007, 7, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(388, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Arrive at:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Depart from:"
        '
        'cboArrivalAirport
        '
        Me.cboArrivalAirport.FormattingEnabled = True
        Me.cboArrivalAirport.Location = New System.Drawing.Point(392, 54)
        Me.cboArrivalAirport.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.cboArrivalAirport.Name = "cboArrivalAirport"
        Me.cboArrivalAirport.Size = New System.Drawing.Size(211, 26)
        Me.cboArrivalAirport.TabIndex = 18
        '
        'cboDepartureAirport
        '
        Me.cboDepartureAirport.FormattingEnabled = True
        Me.cboDepartureAirport.Location = New System.Drawing.Point(28, 54)
        Me.cboDepartureAirport.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.cboDepartureAirport.Name = "cboDepartureAirport"
        Me.cboDepartureAirport.Size = New System.Drawing.Size(211, 26)
        Me.cboDepartureAirport.TabIndex = 17
        '
        'frmFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 390)
        Me.Controls.Add(Me.txtDepartureTime)
        Me.Controls.Add(Me.lblArriveWhen)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpDepartureDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboArrivalAirport)
        Me.Controls.Add(Me.cboDepartureAirport)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmFlight"
        Me.Text = "Schedule a Flight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDepartureTime As TextBox
    Friend WithEvents lblArriveWhen As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDepartureDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboArrivalAirport As ComboBox
    Friend WithEvents cboDepartureAirport As ComboBox
End Class
