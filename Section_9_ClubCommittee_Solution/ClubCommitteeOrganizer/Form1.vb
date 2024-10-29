Public Class frmCommittee
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cboCommittees.Text.Length = 0 Then
            lblStatus.Text = "Please select a committee"
            Return
        End If

        For Each name As String In lstAllMembers.SelectedItems
            If Not lstCommMembers.Items.Contains(name) Then
                lstCommMembers.Items.Add(name)
            End If
        Next



        lstAllMembers.SelectedItems.Clear()

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim col As New Collection

        If lstCommMembers.Text.Length = 0 Then
            lblStatus.Text = "Please select a member"
            Return
        End If

        For Each name As String In lstCommMembers.SelectedItems
            col.Add(name)

        Next
        For Each name As String In col
            lstCommMembers.Items.Remove(name)
        Next





        Return
    End Sub
End Class
