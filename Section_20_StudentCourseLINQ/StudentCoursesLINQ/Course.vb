Public Class Course
    Public Property CourseId As String
    Public Property Credits As Integer
    Public Property Grade As Double



    Public Sub New(id As String, courseCredits As Integer, courseGrade As Double)
        CourseId = id
        Credits = courseCredits
        Grade = courseGrade
    End Sub

    Public Overrides Function ToString() As String
        Return $"{CourseId}, {Credits}, Grade: {Grade}"
    End Function

End Class
