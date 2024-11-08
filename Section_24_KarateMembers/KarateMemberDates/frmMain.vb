Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'KarateEmptyDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.KarateEmptyDataSet1.Members, Today())

    End Sub

    Private Sub dtpJoinDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpJoinDate.ValueChanged
        Me.MembersTableAdapter.Fill(Me.KarateEmptyDataSet1.Members, dtpJoinDate.Value)
    End Sub
End Class
