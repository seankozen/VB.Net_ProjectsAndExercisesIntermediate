Public Class SavingsAccount
    Inherits Account

    Public Sub New(Id As String, Owner As String, CashBalance As Double, accountInterestRate As Double)
        MyBase.New(Id, Owner, CashBalance)
        InterestRate = accountInterestRate
    End Sub

    Public Property InterestRate As Double
    Public Property TransHistory As New TransactionHistory


End Class
