Imports System.Security.Cryptography.X509Certificates

Public Enum TransactionType
    Deposit
    Withdrawal
End Enum

Public Class TransactionHistory
    Public Property Items As New Dictionary(Of Date, Transaction)
End Class


Public Class Transaction
    Public Property TransDate As DateTime
    Public Property Type As TransactionType
    Public Property Amount As Double

    Public Sub New(TransactionDate As DateTime, transactionType As TransactionType, transAmount As Double)
        TransactionDate = TransactionDate
        Type = transactionType
        Amount = transAmount
    End Sub


    Public Overrides Function ToString() As String
        Dim typeStr As String = "Deposit"

        If Type = TransactionType.Withdrawal Then typeStr = "Withdrawal"
        Return TransDate & ", " & typeStr & ", " & Amount.ToString("c")
    End Function








End Class

