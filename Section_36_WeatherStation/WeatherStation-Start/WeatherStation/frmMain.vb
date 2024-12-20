﻿Imports System.Windows.Forms.VisualStyles

Public Class frmMain

    Private WithEvents myStation As New WeatherStation

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        myStation.MonitorWeather()
    End Sub

    Private Sub myStation_Normal() Handles myStation.Normal
        lblEventDetected.Text = "The weather is normal."
    End Sub

    Private Sub myStation_Raining() Handles myStation.Raining
        lblEventDetected.Text = "The weather is rainy."
    End Sub
    Private Sub myStation_Snowing() Handles myStation.Snowing
        lblEventDetected.Text = "The weather is snowy."
    End Sub
    Private Sub myStation_Lightning() Handles myStation.Lightning
        lblEventDetected.Text = "The weather is stormy."
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        frmSummary.WStation = myStation
        frmSummary.Show()

    End Sub
End Class
