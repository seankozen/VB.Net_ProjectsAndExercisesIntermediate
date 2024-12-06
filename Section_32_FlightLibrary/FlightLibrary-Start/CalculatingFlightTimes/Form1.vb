Imports FlightSchedulerLib


Public Class frmFlights


    Private Sub frmFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Flight.GetData("..\..\FlightData.txt")

        For Each ap As Airport In Flight.AirportList
            cboDepartureAirport.Items.Add(ap.Code)
            cboArrivalAirport.Items.Add(ap.Code)
        Next
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If cboDepartureAirport.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cboDepartureAirport, "You must select a departure airport")
            Return
        Else
            ErrorProvider1.SetError(cboDepartureAirport, "")
        End If

        If cboArrivalAirport.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cboArrivalAirport, "You must select a arrival airport")
            Return
        Else
            ErrorProvider1.SetError(cboArrivalAirport, "")
        End If

        Dim departIndex As Integer = cboDepartureAirport.SelectedIndex

        ' get the local departure time from the DateTimePicker control
        Dim departWhen As DateTime = dtpDepartureDate.Value.Date
        Dim departTime As DateTime

        If Date.TryParse(txtDepartureTime.Text, departTime) = Nothing Then
            ErrorProvider1.SetError(txtDepartureTime, "Departure time must be valid date")
            Return
        Else
            ErrorProvider1.SetError(txtDepartureTime, "")
        End If

        Dim departureTime As DateTime = CDate(txtDepartureTime.Text)
        Dim ts As New TimeSpan(departTime.Hour, departTime.Minute, 0)
        Dim departsWhen As DateTime = dtpDepartureDate.Value.Date.Add(ts)
        Dim aFlight As New Flight(cboDepartureAirport.SelectedIndex, cboArrivalAirport.SelectedIndex, departsWhen)

        Dim arriveWhen As DateTime = aFlight.GetArrival()
        lblArriveWhen.Text = arriveWhen.ToString("d") & " " & arriveWhen.ToString("a\t hh:mm tt") & " Travel time is " & aFlight.Duration & " hours."

        lblArriveWhen.Visible = True














    End Sub
End Class
