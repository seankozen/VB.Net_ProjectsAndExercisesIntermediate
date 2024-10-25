Public Class frmDetailsForm

    Public Property SingleWorkshop As Workshop

    Private Sub frmDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCategory.DataSource = Workshop.CategoryNames

        With SingleWorkshop
            txtTitle.Text = .Title
            txtDays.Text = .NumDays.ToString()
            txtCost.Text = $"${ .Cost.ToString("n")}"
            cboCategory.SelectedIndex = .Category
        End With
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub


    Private Sub btnSaveClose_Click(sender As Object, e As EventArgs) Handles btnSaveClose.Click

        With SingleWorkshop
             .Title = txtTitle.Text
             .NumDays = CInt(txtDays.Text)
            .Cost = CDbl(txtCost.Text)
            .Category = CType(cboCategory.SelectedIndex, Workshop.CategoryType)
        End With

        Close()

    End Sub
End Class