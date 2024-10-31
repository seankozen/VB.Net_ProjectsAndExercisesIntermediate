Public Class frmCourse
    Public Property CurrStudent As Student
    Private Sub frmCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStudent.Text = CurrStudent.StudentId & ", " & CurrStudent.LastName
        FillCourseList()
    End Sub

    Private Sub FillCourseList()
        lstCourses.Items.Clear()
        For Each pair As KeyValuePair(Of String, Course) In CurrStudent.Courses
            lstCourses.Items.Add(pair.Value.ToString())
        Next

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim credits As Integer
        Dim grade As Double

        errProvider.SetError(txtCourseNumber, "")
        errProvider.SetError(txtGrade, "")
        errProvider.SetError(txtCredits, "")

        If CurrStudent.Courses.ContainsKey(txtCourseNumber.Text) Then
            errProvider.SetError(txtCourseNumber, "Cannot add a duplicate course.")
            Return
        End If

        If txtCourseNumber.Text.Length = 0 Then
            errProvider.SetError(txtCourseNumber, "Enter a valid course number.")
            Return
        End If

        If Not (Double.TryParse(txtGrade.Text, grade) AndAlso (grade >= 0 And grade <= 4.0)) Then
            errProvider.SetError(txtGrade, "Enter a valid grade.")
            Return
        End If

        If Not (Integer.TryParse(txtCredits.Text, credits) AndAlso (credits >= 0 And credits <= 6)) Then
            errProvider.SetError(txtCredits, "Enter a valid number of credits, between 0 and 6.")
            Return
        End If

        CurrStudent.Courses.Add(txtCourseNumber.Text, New Course(txtCourseNumber.Text, credits, grade))
            FillCourseList()























    End Sub
End Class