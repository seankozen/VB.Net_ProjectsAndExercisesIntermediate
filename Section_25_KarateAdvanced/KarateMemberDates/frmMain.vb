Public Class frmMain

    Private Sub UpdateGrid()
        dgrMembers.DataSource = KarateMembersBindingSource
        If radBefore.Checked Then
            MembersTableAdapter.FillDatesBefore(AdvancedKarateDataSet.Members, dtpJoinDate.Value)
        Else
            MembersTableAdapter.FillByDatesAfter(AdvancedKarateDataSet.Members, dtpJoinDate.Value)
        End If

    End Sub


    Private Sub radBefore_CheckedChanged(sender As Object, e As EventArgs) Handles radBefore.CheckedChanged
        UpdateGrid()
    End Sub

    Private Sub radAfter_CheckedChanged(sender As Object, e As EventArgs) Handles radAfter.CheckedChanged
        UpdateGrid()
    End Sub
End Class
