Public Class frmDeletePayment
    Private db As New KarateClassesDataContext
    Private Sub frmDeletePayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub RefreshGrid()
        PaymentBindingSource.DataSource = From aPayment In db.Payments
                                          Select aPayment

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvPayments.SelectedRows.Count = 0 Then Return

        Dim paymentId As Integer = (dgvPayments.SelectedRows(0).Cells(0).Value)
        Dim query = From aPayment In db.Payments
                    Select aPayment
                    Where aPayment.ID = paymentId

        Try
            db.Payments.DeleteOnSubmit(query.First())
            db.SubmitChanges()
            RefreshGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
End Class
