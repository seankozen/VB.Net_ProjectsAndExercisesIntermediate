Public Class frmAccounts

    Public accounts As New Dictionary(Of String, Account)


    Private Sub frmAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accounts.Add("1050", New Account("1050", "Jones", 800.5D))
        accounts.Add("1001", New Account("1001", "Adams", 750.18D))
        accounts.Add("1020", New Account("1020", "Gonzalez", 1800.21D))
        accounts.Add("1032", New Account("1032", "Chong", 1200.5D))
        accounts.Add("1010", New Account("1010", "Almasi", 5000D))
        FillList()
    End Sub


    Private Sub FillList()
        lstBox.Items.Clear()
        Dim acctEntry As KeyValuePair(Of String, Account)
        For Each acctEntry In accounts
            lstBox.Items.Add(acctEntry.Value.ToString())
        Next
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim act As New Account(txtId.Text, txtName.Text, CDec(txtBalance.Text))
            accounts.Add(act.ID, act)
            FillList()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
        Try
            Dim act As New Account(txtId.Text, txtName.Text, CDec(txtBalance.Text))
            If accounts.ContainsKey(act.ID) Then
                accounts.Item(act.ID) = act
                FillList()
            Else
                MessageBox.Show("This account does not exist.  Please click the add button.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!")
        End Try


    End Sub


















End Class
