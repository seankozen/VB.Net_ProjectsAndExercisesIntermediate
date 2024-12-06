Public Class frmMain
    Private db As New KarateClassesDataContext


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PaymentBindingSource.DataSource = From aPayment In db.Payments
                                          Select aPayment
        PaymentBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            PaymentBindingSource.EndEdit()
            db.SubmitChanges()
            MessageBox.Show("Payment added")
            PaymentBindingSource.AddNew()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        frmShowPayments.ShowDialog()
    End Sub
End Class
