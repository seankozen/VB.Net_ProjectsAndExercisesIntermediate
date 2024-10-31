Public Class Student
    Public Property StudentId As String
    Public Property LastName As String
    Private testAvg As Double

    Public Property Courses As Dictionary(Of String, Course)

    Public Property TestAverage As Double
        Get
            Return testAvg
        End Get
        Set(value As Double)
            If value >= 0.0 And value <= 100 Then
                testAvg = value
            Else
                MessageBox.Show("Invalid test average", "Error")
            End If
        End Set
    End Property

    Public Sub New(id As String, lstName As String, avg As Double)
        StudentId = id
        LastName = lstName
        TestAverage = avg
        Courses = New Dictionary(Of String, Course)
    End Sub

    Public Overrides Function ToString() As String
        Return $"{StudentId}, {LastName}, Test Average = {TestAverage.ToString("n2")}"
    End Function

End Class
