﻿Imports System.IO

Public Class Investment
    Enum InvestmentType
        Stock
        MutualFunds
        Commodity
        MoneyMarket
    End Enum

    Class PriceType
        Public Property Ticker As String
        Public Property Price As Double
    End Class


    Public Property Type As InvestmentType
    Public Property PurchaseDate As Date
    Public Property PricePerShare As Double
    Public Property NumOfShares As Integer
    Public Property Ticker As String
    Private Shared prices As New Collection

    Public ReadOnly Property PurchaseAmount As Double
        Get
            Return PricePerShare * NumOfShares
        End Get
    End Property

    Public Shared Function LoadPrices(filename As String) As Boolean
        Dim infile As StreamReader = Nothing
        Try
            infile = File.OpenText(filename)
            While Not infile.EndOfStream
                Dim pType As New PriceType
                Dim line As String = infile.ReadLine()
                Dim fields() As String = line.Split(","c)
                pType.Ticker = fields(0)
                pType.Price = CDbl(fields(1))
                prices.Add(pType, pType.Ticker)
            End While
            Return True
        Catch ex As Exception
            Return False
        Finally
            If infile IsNot Nothing Then infile.Close()
        End Try
        Return False
    End Function

    Public Shared Function GetCurrentPrice(ticker As String) As Double
        If prices.Contains(ticker) Then
            Return CType(prices.Item(ticker), PriceType).Price
        Else
            Return -1.0

        End If
    End Function








End Class
