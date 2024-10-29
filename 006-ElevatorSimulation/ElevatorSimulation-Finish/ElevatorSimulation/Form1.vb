Public Class frmElevator
    Private ReadOnly NumFloors As Integer = 8
    Private ReadOnly FloorHeight As Integer = 28 'pixels
    Private floors(NumFloors) As Integer
    Private waitLabels(NumFloors - 1) As Label
    Private elev As New Elevator
    Private rand As New Random


    Private Sub TimerTick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If elev.Direction = Elevator.DirectionType.Up Then
            If elev.CurrFloor < NumFloors - 1 Then
                LoadPassangers()
                MoveElevator(1) 'go up one floor
            Else
                elev.Direction = Elevator.DirectionType.Down
                elev.NumPass = 0
                FillFloors(0, NumFloors - 2)
            End If
        Else
            If elev.CurrFloor > 0 Then
                LoadPassangers()
                MoveElevator(-1)
            Else
                elev.Direction = Elevator.DirectionType.Up
                elev.NumPass = 0
                FillFloors(1, NumFloors - 1)
            End If
        End If
    End Sub

    Private Sub frmElevator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim X As Integer = 150
        Dim Y As Integer = 215
        pnlElevator.Location = New Point(X - 100, Y - 5)
        elev.Direction = Elevator.DirectionType.Up

        For i As Integer = 0 To NumFloors - 1
            waitLabels(i) = New Label With {
                .Location = New Point(X, Y)
            }
            Controls.Add(waitLabels(i))
            Y -= FloorHeight
        Next
        FillFloors(0, NumFloors - 1)
    End Sub

    Private Sub UpdateFloorLabels()
        'Update the labels that show how many people are waiting on each floor
        For i As Integer = 0 To NumFloors - 1
            waitLabels(i).Text = floors(i).ToString()
        Next
    End Sub

    Private Sub LoadPassangers()
        'moves people from current floor into elevator
        elev.NumPass += floors(elev.CurrFloor)
        floors(elev.CurrFloor) = 0
        lblPassengers.Text = elev.NumPass.ToString()
        UpdateFloorLabels()
    End Sub

    Private Sub FillFloors(first As Integer, last As Integer)
        'Randomly fill the floors array.
        For i As Integer = first To last
            floors(i) = rand.Next(6)
        Next
        UpdateFloorLabels()
    End Sub

    Private Sub MoveElevator(whichWay As Integer)
        'if whichWay = 1, the elevator moves up; if whichWay equals -1, the elevator moves down.
        elev.CurrFloor += whichWay
        Dim Y As Integer = pnlElevator.Location.Y - (FloorHeight * whichWay)
        pnlElevator.Location = New Point(pnlElevator.Location.X, Y)
        lblFloorNumber.Text = (elev.CurrFloor + 1).ToString()
    End Sub
End Class
