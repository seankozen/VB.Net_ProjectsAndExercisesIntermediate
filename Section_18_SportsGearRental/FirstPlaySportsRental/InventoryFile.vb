﻿Imports System.IO

Public Class InventoryFile
    Private infile As StreamReader
    Private outFile As StreamWriter
    Private fileName As String

    Public Sub New(nameOfFile As String)
        fileName = nameOfFile
    End Sub



    Private Function ReadOneItem() As Item
        Dim item As New Item()
        With infile
            item.IDNumber = .ReadLine()
            item.Description = .ReadLine()
            item.DailyRate = CSng(.ReadLine())
            item.WeeklyRate = CSng(.ReadLine())
            item.MonthlyRate = CSng(.ReadLine())
            item.Quantity = CInt(.ReadLine())
        End With
        Return item
    End Function

    Private Sub WriteOneItem(item As Item)
        With outFile
            .WriteLine(item.IDNumber)
            .WriteLine(item.Description)
            .WriteLine(item.DailyRate)
            .WriteLine(item.WeeklyRate)
            .WriteLine(item.MonthlyRate)
            .WriteLine(item.Quantity)
        End With
    End Sub


    Public Sub LoadData(inv As Inventory)
        infile = File.OpenText(fileName)
        Dim item As New Item()

        Do Until infile.Peek = -1
            item = ReadOneItem()
            If Not item Is Nothing Then
                inv.AddItem(item)
            End If
        Loop

        infile.Close()

    End Sub

    Public Sub SaveData(inv As Inventory)
        outFile = File.CreateText(fileName)
        Dim item As Item
        For Each item In inv.Items
            WriteOneItem(item)
        Next

        outFile.Close()
    End Sub




End Class
