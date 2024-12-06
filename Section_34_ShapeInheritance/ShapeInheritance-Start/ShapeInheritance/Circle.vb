Public Class Circle
    Inherits Shape

    Private center As Point
    Private radius As Double

    Public Sub New(centerOfCircle As Point, radiusOfCircle As Double)
        MyBase.New("Circle")
        center = centerOfCircle
        radius = radiusOfCircle
    End Sub

    Public Overrides Function GetArea() As Double
        Return Math.PI * radius * radius

        Return MyBase.ToString() & ": center = " & center.ToString() & ", radius = " & radius.ToString()

    End Function
End Class
