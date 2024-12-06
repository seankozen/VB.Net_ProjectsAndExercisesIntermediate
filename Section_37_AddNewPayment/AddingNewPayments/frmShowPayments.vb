Public Class frmShowPayments
    Private db As New KarateClassesDataContext
    Private Sub frmShowPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvPayments.DataSource = From aPayment In db.Payments
                                 Select aPayment


    End Sub
End Class