Public Class frmMain
    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles SalesStaffBindingSource.CurrentChanged

    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub CalcAvgSalary()
        Dim row As SalesStaffDataSet.SalesStaffRow
        Dim totalSalary As Decimal
        For Each row In SalesStaffDataSet.SalesStaff.Rows
            totalSalary += row.Salary
            Dim avg As Decimal = totalSalary / SalesStaffDataSet.SalesStaff.Rows.Count
            lblAverageSalary.Text = FormatCurrency(avg)
        Next
    End Sub



    Private Sub radFullTime_CheckedChanged(sender As Object, e As EventArgs) Handles radFullTime.CheckedChanged
        SalesStaffTableAdapter.Full_Time(SalesStaffDataSet.SalesStaff)
        CalcAvgSalary()
    End Sub

    Private Sub radPartTime_CheckedChanged(sender As Object, e As EventArgs) Handles radPartTime.CheckedChanged
        SalesStaffTableAdapter.Part_Time(SalesStaffDataSet.SalesStaff)
        CalcAvgSalary()
    End Sub
End Class
