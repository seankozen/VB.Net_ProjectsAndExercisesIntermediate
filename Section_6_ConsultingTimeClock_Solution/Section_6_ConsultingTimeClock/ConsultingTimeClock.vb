Public Class ConsultingTimeClock

    Dim clock As New TimeClock

    Dim billData As New BillingData



    Private Sub ConsultingTimeClock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboClients.DataSource = billData.ClientColl


    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        clock.ClientName = cboClients.Text
        Me.Text = cboClients.Text
        clock.StartClock()
        txtStartTime.Text = clock.StartTime.ToShortTimeString
        txtBillableHrsMins.Visible = False
        btnStart.Enabled = False
        btnStop.Enabled = True
        btnExit.Enabled = False
        cboClients.Enabled = False
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        btnStart.Enabled = True
        btnStop.Enabled = False
        btnExit.Enabled = True
        txtBillableHrsMins.Visible = True
        cboClients.Enabled = True
        clock.StopClock()
        txtStopTime.Text = clock.StopTime.ToShortTimeString
        txtBillableHrsMins.Text = clock.Elapsed.Hours & ":" & clock.Elapsed.Minutes & ":" & clock.Elapsed.Seconds

        With clock
            billData.WriteBilling(
                Now.ToShortDateString & ", " & .ClientName & ", " & .StartTime.ToShortTimeString & ", " & .StopTime.ToShortTimeString & ", " & .TotalElapsed.Hours & ": " & .TotalElapsed.Minutes & ": " & .TotalElapsed.Seconds)
        End With
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        billData.CloseBilling()
        Close()
    End Sub
End Class
