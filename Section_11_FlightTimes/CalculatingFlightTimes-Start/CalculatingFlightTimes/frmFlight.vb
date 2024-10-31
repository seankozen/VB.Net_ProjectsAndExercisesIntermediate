Public Class frmFlight
    Private airports() As String = {"MIA", "JFK", "HNL", "LAX", "DFW"}
    Private utcOffsets() As Integer = {-5, -5, -10, -8, -6}
    Private travelTimes(,) As Double = {{0, 3, 12, 8, 2.5},
                                        {3, 0, 14, 8.5, 3.5},
                                        {12, 14, 0, 4.5, 8.5},
                                        {8, 8.5, 4.5, 0, 3.5},
                                        {2.5, 3.5, 8.5, 3.5, 0}}

    Private ErrorProvider1 = New ErrorProvider

    Private Sub frmFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDepartureDate.Value = Today

        For Each airport As String In airports
            cboDepartureAirport.Items.Add(airport)
            cboArrivalAirport.Items.Add(airport)
        Next

    End Sub


    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If cboDepartureAirport.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cboDepartureAirport, "You must select a departure airport.")
            Return
        Else
            ErrorProvider1.SetError(cboDepartureAirport, "")
        End If

        If cboArrivalAirport.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cboArrivalAirport, "You must select an arrival airport.")
            Return
        Else
            ErrorProvider1.SetError(cboArrivalAirport, "")
        End If




        Dim departIndex As Integer = cboDepartureAirport.SelectedIndex

        Dim departWhen As DateTime = dtpDepartureDate.Value.Date
        Dim departTime As DateTime

        If Date.TryParse(txtDepartureTime.Text, departTime) = Nothing Then
            ErrorProvider1.SetError(txtDepartureTime, "Departure time must be a valid date.")
            Return
        Else
            ErrorProvider1.SetError(txtDepartureTime, "")
        End If

        departWhen = departWhen.AddHours(departTime.Hour)
        departWhen = departWhen.AddMinutes(departTime.Minute)

        departWhen = departWhen.AddHours(-utcOffsets(departIndex))


        Dim arriveIndex As Integer = cboArrivalAirport.SelectedIndex
        Dim duration As Double = travelTimes(departIndex, arriveIndex)
        Dim arriveWhen As Date = departWhen.AddHours(duration)

        arriveWhen = arriveWhen.AddHours(utcOffsets(arriveIndex))

        lblArriveWhen.Text = arriveWhen.ToString("d") & " " _
            & arriveWhen.ToString("\a\t hh:mm tt") _
            & " Travel time is " & duration & " hours."



    End Sub








End Class

