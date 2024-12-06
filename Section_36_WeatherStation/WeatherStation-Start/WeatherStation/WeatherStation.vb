Public Class WeatherStation
    Public Delegate Sub WeatherEvent()
    Public Event Normal As WeatherEvent
    Public Event Raining As WeatherEvent
    Public Event Snowing As WeatherEvent
    Public Event Lightning As WeatherEvent

    Private randGenerator As New Random

    Private Function ReadWeatherSensor() As Integer
        Return randGenerator.Next(4)
    End Function

    Public Sub MonitorWeather()
        Dim sensorValue As Integer = ReadWeatherSensor()

        Select Case sensorValue
            Case 0
                RaiseEvent Normal()
            Case 1
                RaiseEvent Raining()
            Case 2
                RaiseEvent Snowing()
            Case 4
                RaiseEvent Lightning()
        End Select
    End Sub
















End Class
