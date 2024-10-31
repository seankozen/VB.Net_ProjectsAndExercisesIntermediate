Imports System.Data.SqlTypes

Public Class Cruise
    Public Property NumOfPassengers As Integer
    Public Property Region As String
    Public Property Formal As Boolean
    Public Property AverageAge As Integer
    Public Property Name As String

    Private Shared numPassengersWt As Single
    Private Shared regionWt As Single
    Private Shared formalWt As Single
    Private Shared averageAgeWt As Single

    Public Sub New()

    End Sub

    Public Sub New(numberPassengers As Integer, cruiseRegion As String, formalAttire As Boolean, avgAge As Integer, cruiseName As String)
        NumOfPassengers = numberPassengers
        Region = cruiseRegion
        Formal = formalAttire
        AverageAge = avgAge
        Name = cruiseName

    End Sub

    'Set percentage weights for determining the selection criteria
    Public Shared Sub SetWeights(numPassengers As Single, cruiseRegion As Single, formalInformal As Single, avgAge As Single)
        numPassengersWt = numPassengers
        regionWt = cruiseRegion
        formalWt = formalInformal
        averageAgeWt = avgAge
    End Sub

    Public Function CountMatches(cruiseObj As Cruise) As Single
        Dim matches As Single = 0.0
        If Math.Abs(NumOfPassengers - cruiseObj.NumOfPassengers) <= 500 Then matches += numPassengersWt

        If Region = cruiseObj.Region Then matches += regionWt

        If Formal = cruiseObj.Formal Then matches += formalWt

        If Math.Abs(AverageAge - cruiseObj.AverageAge) <= 5 Then matches += averageAgeWt

        Return matches

    End Function








































End Class
