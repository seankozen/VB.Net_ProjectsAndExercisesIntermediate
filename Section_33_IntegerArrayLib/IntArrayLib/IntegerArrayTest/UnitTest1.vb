Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports IntArrayLib

<TestClass()> Public Class UnitTest1

    <TestMethod()>
    Public Sub GetSmallest()
        Dim target As IntArray = New IntArray()
        target.Data = {-33, 16, 12, 22, 0, 40}
        Dim expected As Integer = -33
        Dim actual As Integer = target.GetSmallest
        Assert.AreEqual(expected, actual)
    End Sub

    <TestMethod()>
    Public Sub GetSmallest2()
        Dim target As IntArray = New IntArray()
        target.Data = {16, 40, 12, 22, 0, -33}
        Dim expected As Integer = -33
        Dim actual As Integer = target.GetSmallest
        Assert.AreEqual(expected, actual)
    End Sub

    <TestMethod()>
    Public Sub GetSmallest3()
        Dim target As IntArray = New IntArray()
        target.Data = {12, -33, 45, 12, 22, 0, 40}
        Dim expected As Integer = -33
        Dim actual As Integer = target.GetSmallest
        Assert.AreEqual(expected, actual)
    End Sub

    <TestMethod()>
    Public Sub GetSmallest4()
        Dim target As IntArray = New IntArray()
        target.Data = {0, 0, 0, 1, 1, 1, 0, 0, 0}
        Dim expected As Integer = 0
        Dim actual As Integer = target.GetSmallest
        Assert.AreEqual(expected, actual)
    End Sub

    <TestMethod()>
    Public Sub GetSmallest5()
        Dim target As IntArray = New IntArray()
        target.Data = {}
        Dim expected As Integer = Integer.MaxValue
        Dim actual As Integer = target.GetSmallest
        Assert.AreEqual(expected, actual, "Testing Empty Array")
    End Sub


    <TestMethod()>
    Public Sub GetLargest()
        Dim target As IntArray = New IntArray()
        target.Data = {-33, 16, 12, 22, 0, 40}
        Dim expected As Integer = 40
        Dim actual As Integer = target.GetLargest
        Assert.AreEqual(expected, actual)
    End Sub

    <TestMethod()>
    Public Sub GetLargest2()
        Dim target As IntArray = New IntArray()
        target.Data = {16, 40, 12, 22, 0, -33}
        Dim expected As Integer = 40
        Dim actual As Integer = target.GetLargest
        Assert.AreEqual(expected, actual)
    End Sub

    <TestMethod()>
    Public Sub GetLargest3()
        Dim target As IntArray = New IntArray()
        target.Data = {12, -33, 45, 12, 22, 0, 40}
        Dim expected As Integer = 45
        Dim actual As Integer = target.GetLargest
        Assert.AreEqual(expected, actual)
    End Sub

    <TestMethod()>
    Public Sub GetLargest4()
        Dim target As IntArray = New IntArray()
        target.Data = {0, 0, 0, 1, 1, 1, 0, 0, 0}
        Dim expected As Integer = 1
        Dim actual As Integer = target.GetLargest
        Assert.AreEqual(expected, actual)
    End Sub

    <TestMethod()>
    Public Sub GetLargest5()
        Dim target As IntArray = New IntArray()
        target.Data = {}
        Dim expected As Integer = Integer.MinValue
        Dim actual As Integer = target.GetLargest
        Assert.AreEqual(expected, actual, "Testing Empty Array")
    End Sub

    <TestMethod()>
    Public Sub GetMedian()
        Dim target As IntArray = New IntArray()
        target.Data = {10, 20, 30}
        Dim expected As Integer = 20
        Dim actual As Integer = target.GetMedian
        Assert.AreEqual(expected, actual, 0.01)
    End Sub

    <TestMethod()>
    Public Sub GetMedian2()
        Dim target As IntArray = New IntArray()
        target.Data = {10, 20, 30, 40}
        Dim expected As Integer = 25
        Dim actual As Integer = target.GetMedian
        Assert.AreEqual(expected, actual, 0.01)
    End Sub

    <TestMethod()>
    Public Sub GetMedian3()
        Dim target As IntArray = New IntArray()
        target.Data = {20, 10, 30}
        Dim expected As Integer = 20
        Dim actual As Integer = target.GetMedian
        Assert.AreEqual(expected, actual, 0.01)
    End Sub

    <TestMethod()>
    Public Sub GetMedian4()
        Dim target As IntArray = New IntArray()
        target.Data = {10, 20, 40, 30}
        Dim expected As Integer = 25
        Dim actual As Integer = target.GetMedian
        Assert.AreEqual(expected, actual, 0.01)
    End Sub

    <TestMethod()>
    Public Sub GetMedian5()
        Dim target As IntArray = New IntArray()
        target.Data = {10, -20, 40, -31}
        Dim expected As Integer = -5
        Dim actual As Integer = target.GetMedian
        Assert.AreEqual(expected, actual, 0.01)
    End Sub

End Class