Public Class frmSummary
    Public WithEvents WStation As WeatherStation
    Private normal As Integer
    Private raining As Integer
    Private snowing As Integer
    Private lightning As Integer

    Private Sub myStation_Normal() Handles WStation.Normal
        normal += 1
        lblNormal.Text = normal.ToString()
    End Sub

    Private Sub myStation_Lightningl() Handles WStation.Lightning
        lightning += 1
        lblLightning.Text = lightning.ToString()
    End Sub

    Private Sub myStation_Snowing() Handles WStation.Snowing
        snowing += 1
        lblSnowing.Text = snowing.ToString()
    End Sub


    Private Sub myStation_Raining() Handles WStation.Raining
        raining += 1
        lblRaining.Text = raining.ToString()
    End Sub



End Class