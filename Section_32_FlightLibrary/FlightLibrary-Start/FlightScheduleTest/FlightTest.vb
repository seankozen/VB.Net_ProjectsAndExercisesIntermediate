Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports FlightSchedulerLib

<TestClass()> Public Class FlightTest
    Private testContextInstance As TestContext
    Public Property TestContext As TestContext
        Get
            Return testContextInstance
        End Get
        Set(value As TestContext)
            testContextInstance = value

        End Set
    End Property

    <ClassInitialize()>
    Public Shared Sub ClassInit(testContext As TestContext)
        Flight.GetData("..\..\FlightData.txt")
    End Sub


    <TestMethod()>
    Public Sub GetArrivalTest1()
        Dim depart As Integer = 0 'MIA
        Dim arrive As Integer = 3 'LAX
        Dim departWhen As DateTime = #10/1/2019 8:30:00 AM#
        Dim target As Flight = New Flight(depart, arrive, departWhen)
        Dim expected As DateTime = #10/1/2019 1:30:00 PM#
        Dim actual As DateTime = target.GetArrival
        Assert.AreEqual(expected, actual)

    End Sub

    <TestMethod()>
    Public Sub GetArrivalTest2()
        Dim depart As Integer = 0 'MIA
        Dim arrive As Integer = 2 'HNL
        Dim departWhen As DateTime = #10/1/2019 8:30:00 AM#
        Dim target As Flight = New Flight(depart, arrive, departWhen)
        Dim expected As DateTime = #10/1/2019 3:30:00 PM#
        Dim actual As DateTime = target.GetArrival
        Assert.AreEqual(expected, actual)

    End Sub

    <TestMethod()>
    Public Sub GetArrivalTest3()
        Dim depart As Integer = 1 'JFK
        Dim arrive As Integer = 2 'HNL
        Dim departWhen As DateTime = #10/1/2019 8:30:00 AM#
        Dim target As Flight = New Flight(depart, arrive, departWhen)
        Dim expected As DateTime = #10/1/2019 5:30:00 PM#
        Dim actual As DateTime = target.GetArrival
        Assert.AreEqual(expected, actual)

    End Sub

    <TestMethod()>
    Public Sub GetArrivalTest4()
        Dim depart As Integer = 1 'JFK
        Dim arrive As Integer = 0 'MIA
        Dim departWhen As DateTime = #10/1/2019 11:30:00 PM#
        Dim target As Flight = New Flight(depart, arrive, departWhen)
        Dim expected As DateTime = #10/2/2019 2:30:00 AM#
        Dim actual As DateTime = target.GetArrival
        Assert.AreEqual(expected, actual)

    End Sub


    <TestMethod()>
    Public Sub GetArrivalTest5()
        Dim depart As Integer = 3 'LAX
        Dim arrive As Integer = 4 'DFW
        Dim departWhen As DateTime = #10/1/2019 11:30:00 AM#
        Dim target As Flight = New Flight(depart, arrive, departWhen)
        Dim expected As DateTime = #10/1/2019 5:00:00 PM#
        Dim actual As DateTime = target.GetArrival
        Assert.AreEqual(expected, actual)

    End Sub






End Class