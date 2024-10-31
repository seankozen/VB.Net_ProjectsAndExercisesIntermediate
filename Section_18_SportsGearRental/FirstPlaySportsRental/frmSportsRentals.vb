Public Class frmSportsRentals
    Private inv As New Inventory
    Private invFile As New InventoryFile("..\..\inventory.txt")

    Private Sub frmSportsRentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            invFile.LoadData(inv)
            FillCombo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Cannot load data file.")
        End Try
    End Sub


    Private Sub FillCombo()
        cboIdNumber.Items.Clear()
        For Each anItem As Item In inv.Items
            cboIdNumber.Items.Add(anItem.IDNumber)
        Next
    End Sub

    Private Sub cboIdNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIdNumber.SelectedIndexChanged
        Dim anItem As Item = inv.GetItem(cboIdNumber.Text)
        If anItem Is Nothing Then
            MessageBox.Show("The item ID was not found.")
            ClearFields()
        Else
            txtDescription.Text = anItem.Description
            txtDaily.Text = anItem.DailyRate.ToString()
            txtWeekly.Text = anItem.WeeklyRate.ToString()
            txtMonthly.Text = anItem.MonthlyRate.ToString()
            txtQuantity.Text = anItem.Quantity.ToString()
        End If
    End Sub

    Private Sub ClearFields()
        txtDescription.Clear()
        txtDaily.Clear()
        txtWeekly.Clear()
        txtMonthly.Clear()
        txtQuantity.Clear()
        cboIdNumber.Text = String.Empty
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim anItem As New Item
            With anItem
                .IDNumber = cboIdNumber.Text
                .Description = txtDescription.Text
                .DailyRate = CSng(txtDaily.Text)
                .WeeklyRate = CSng(txtWeekly.Text)
                .MonthlyRate = CSng(txtMonthly.Text)
                .Quantity = CInt(txtQuantity.Text)
            End With
            inv.AddItem(anItem)
            FillCombo()
            MessageBox.Show("The item was added to the inventory.")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If MessageBox.Show("Are you sure you want to remove the current item from the inventory?", "Delete Item?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            inv.RemoveItem(cboIdNumber.Text)
            ClearFields()
            FillCombo()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        invFile.SaveData(inv)
        Close()
    End Sub
End Class
