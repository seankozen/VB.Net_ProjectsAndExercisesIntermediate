Public Class frmCustomers
    Private cust As New Customers

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RsDbDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.RsDbDataSet.Customers)

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvCustomers.SelectedRows.Count = 0 Then
            lblStatus.Text = "Please select a row to edit."
            Return

        End If
        Dim frm As New frmModifyCustomer
        frm.CustomerId = CShort(dgvCustomers.SelectedRows(0).Cells(0).Value(0))
        If frm.ShowDialog() = DialogResult.OK Then
            CustomersTableAdapter.Fill(RsDbDataSet.Customers)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvCustomers.SelectedRows.Count > 0 Then
            Dim custId = CShort(dgvCustomers.SelectedRows(0).Cells(0).Value(0))
            If cust.Delete(custId) Then
                dgvCustomers.DataSource = cust.Items
                MessageBox.Show("Customer Deleted")
            Else
                MessageBox.Show("Customer NOT Deleted")
            End If
        End If
    End Sub
End Class