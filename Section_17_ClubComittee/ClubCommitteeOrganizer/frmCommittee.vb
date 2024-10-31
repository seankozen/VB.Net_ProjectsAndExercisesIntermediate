Public Class frmCommittee
    Private ReadOnly ComitteeCount As Integer = 9
    Private comittees As New List(Of Comittee)













    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cboCommittees.Text.Length = 0 Then
            lblStatus.Text = "Please select a committee"
            Return
        End If

        For Each name As String In lstAllMembers.SelectedItems
            If Not lstCommMembers.Items.Contains(name) Then
                lstCommMembers.Items.Add(name)
                comittees(cboCommittees.SelectedIndex).Items.Add(name)
            End If
        Next

        lstAllMembers.SelectedItems.Clear()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim col As New Collection
        For Each name As String In lstCommMembers.SelectedItems
            col.Add(name)
        Next

        For Each name As String In col
            lstCommMembers.Items.Remove(name)
            comittees(cboCommittees.SelectedIndex).Items.Remove(name)
        Next
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Close()
    End Sub

    Private Sub frmCommittee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To cboCommittees.Items.Count - 1
            comittees.Add(New Comittee)
        Next
    End Sub

    Private Sub cboCommittees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCommittees.SelectedIndexChanged
        lstCommMembers.Items.Clear()
        For Each person As String In comittees(cboCommittees.SelectedIndex).Items
            lstCommMembers.Items.Add(person)
        Next
    End Sub
End Class
