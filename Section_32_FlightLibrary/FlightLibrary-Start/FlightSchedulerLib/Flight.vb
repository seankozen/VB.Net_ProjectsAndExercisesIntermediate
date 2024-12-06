Imports System.IO
Imports System.IO.File


Public Class Flight
    Public Property Departure As Airport
    Public Property Arrival As Airport
    Public Property DepartsWhen As DateTime
    Private Property newPropertyValue As String
    Public Shared Duration As String

    Public Shared LastError As String
    Public Shared AirportList As New ArrayList
    Private Shared FlightDurations(,) As Double


    Public Sub New(departureIndex As Integer, arrivalIndex As Integer, deptWhen As DateTime)
        Departure = CType(AirportList(departureIndex), Airport)
        Arrival = CType(AirportList(arrivalIndex), Airport)
        DepartsWhen = deptWhen
        Duration = FlightDurations(departureIndex, arrivalIndex)

    End Sub

    Public Function GetArrival() As DateTime
        Dim temp As DateTime = DepartsWhen.AddHours(-Departure.UtcOffset)
        temp = temp.AddHours(Duration)
        Return temp.AddHours(Arrival.UtcOffset)
    End Function

    Public Shared Function GetData(filePath As String) As Boolean
        Dim infile As StreamReader = Nothing
        LastError = String.Empty
        Try
            infile = OpenText(filePath)
            While Not infile.EndOfStream
                Dim airportCodes() As String = infile.ReadLine().Split(" "c)
                Dim utcOffsets() As String = infile.ReadLine().Split(" "c)
                For i As Integer = 0 To airportCodes.Length - 1
                    AirportList.Add(New Airport(airportCodes(i), CInt(utcOffsets(i))))
                Next
                ReDim FlightDurations(airportCodes.Length - 1, airportCodes.Length - 1)
                For i As Integer = 0 To airportCodes.Length - 1
                    Dim temp As String() = infile.ReadLine().Split(" "c)
                    For j As Integer = 0 To airportCodes.Length - 1
                        FlightDurations(i, j) = CDbl(temp(j))
                    Next
                Next
                Return True

            End While
            LastError = "Something is wrong with the input file."
            Return False
        Catch ex As Exception
            LastError = ex.Message
            Return vbFalse
        Finally
            If infile IsNot Nothing Then infile.Close()
        End Try
        Return False
    End Function











End Class
