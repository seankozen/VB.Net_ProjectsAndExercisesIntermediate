Public Class TakeOffApp

    Private ReadOnly Names() As String = {"B-747", "A-737", "C-150", "D-240"}
    Private ReadOnly TakeOffVelocity() As Double = {299.2, 264, 270, 240}
    Private ReadOnly Acceleration() As Double = {4.9867, 44.2, 37.1, 51.9}
    Private planes() As Aircraft

    Private Sub TakeOffApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim planes(Names.Length - 1)

        For i As Integer = 0 To planes.Length - 1
            planes(i) = New Aircraft With {
                .Name = Names(i),
                .TakeOffVelocity = TakeOffVelocity(i),
                .Acceleration = Acceleration(i)
            }
        Next
        lstAircraft.DataSource = planes
    End Sub

    Private Sub lstAircraft_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAircraft.SelectedIndexChanged
        Dim aircraft As Aircraft = CType(lstAircraft.SelectedItem, Aircraft)
        lblOutput.Text = $"The {aircraft.Name} aircraft has a required takeoff velocity of {aircraft.TakeOffVelocity:n}" & $"ft/sec and acceleration of {aircraft.Acceleration:n}." & $"Therefor, it requires {aircraft.TakeOffTime:n} second to take off with distance " & $"{aircraft.TakeOffDistance:n} feet."

    End Sub

End Class
