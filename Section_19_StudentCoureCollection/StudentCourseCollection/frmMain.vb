Public Class frmMain

    Private AllStudents As New Collection
    Private currStudent As Student

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtIdNumber.Text.Length = 0 Then
            MessageBox.Show("ID number cannot be blank!", "Error")
            Return
        End If
        If txtLastName.Text.Length = 0 Then
            MessageBox.Show("Last name cannot be blank!", "Error")
            Return
        End If

        Try
            currStudent = New Student(txtIdNumber.Text, txtLastName.Text, CDbl(txtAverage.Text))
            AllStudents.Add(currStudent, currStudent.StudentId)
            btnCourseInfo.Enabled = True
        Catch ex As InvalidCastException
            MessageBox.Show("Test average must be a number", "Error")
        Catch ex As ArgumentException
            MessageBox.Show("Can't add a duplicate student ID to the collection", "Error")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub btnCourseInfo_Click(sender As Object, e As EventArgs) Handles btnCourseInfo.Click
        frmCourse.CurrStudent = currStudent
        frmCourse.ShowDialog()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        lstStudents.Items.Clear()
        For Each student As Student In AllStudents
            lstStudents.Items.Add(student.ToString())
        Next
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        lstStudents.Items.Clear()

        If AllStudents.Contains(txtFindId.Text) Then
            currStudent = CType(AllStudents.Item(txtFindId.Text), Student)
            lstStudents.Items.Add(currStudent.ToString())
            btnCourseInfo.Enabled = True

            txtIdNumber.Text = currStudent.StudentId
            txtLastName.Text = currStudent.LastName
            txtAverage.Text = currStudent.TestAverage.ToString("n2")
        Else
            lstStudents.Items.Add("Student ID was NOT found")
        End If
    End Sub
End Class
