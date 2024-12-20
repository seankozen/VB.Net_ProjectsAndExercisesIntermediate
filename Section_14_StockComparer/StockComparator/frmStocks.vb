﻿Public Class frmStocks
    Private stockList As New List(Of Stock)

    Private Sub frmStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stockList.Add(New Stock("MMA", 40, 5))
        stockList.Add(New Stock("ABC", 80, 20))
        stockList.Add(New Stock("XYZ", 77, 4))
        stockList.Add(New Stock("LLT", 43, 5))
        stockList.Add(New Stock("SBA", 42, 7))
        DisplayList()
    End Sub

    Private Sub DisplayList()
        lstBox.Items.Clear()
        For Each st As Stock In stockList
            lstBox.Items.Add(st.ToString())
        Next
    End Sub

    Private Sub btnByTicker_Click(sender As Object, e As EventArgs) Handles btnByTicker.Click
        If chkDescending.Checked = True Then
            stockList.Reverse()
        Else
            stockList.Sort()
        End If

        DisplayList()
    End Sub

    Private Sub btnByPrice_Click(sender As Object, e As EventArgs) Handles btnByPrice.Click
        stockList.Sort(AddressOf CompareByPrice)
        DisplayList()
    End Sub

    Private Function CompareByPrice(x As Stock, y As Stock) As Integer
        If chkDescending.Checked Then
            Return y.Price.CompareTo(x.Price)
        Else
            Return x.Price.CompareTo(y.Price)
        End If
    End Function

    Private Sub btnByPE_Ratio_Click(sender As Object, e As EventArgs) Handles btnByPE_Ratio.Click
        stockList.Sort(AddressOf CompareByPeRatio)
        DisplayList()
    End Sub

    Private Function CompareByPeRatio(x As Stock, y As Stock) As Integer
        If chkDescending.Checked Then
            Return y.PeRatio.CompareTo(x.PeRatio)
        Else
            Return x.PeRatio.CompareTo(y.PeRatio)
        End If
    End Function

End Class

