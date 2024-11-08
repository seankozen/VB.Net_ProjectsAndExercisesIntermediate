Public Class frmAddMember
    Dim id As Integer

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            KarateMembersBindingSource.EndEdit()
            MembersTableAdapter.Update(CRUDKarateDataSet.Members)
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmAddMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KarateMembersBindingSource.AddNew()
        id = MembersTableAdapter.GetNewMemberID()
        IDTextBox.Text = id.ToString()
    End Sub

    Private Sub frmAddMember_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        KarateMembersBindingSource.CancelEdit()
    End Sub
End Class