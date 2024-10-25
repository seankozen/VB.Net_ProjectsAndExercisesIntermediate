Public Class Workshop
    Enum CategoryType
        AppDev
        Database
        Networking
        SysAdmin
    End Enum


    Public Shared CategoryNames() As String = {
        "Application Development",
        "Databases",
        "Networking",
        "System Administration"}

    Public Property Title As String
    Public Property NumDays As Integer
    Public Property Cost As Double
    Public Property Category As CategoryType

    Public Overrides Function ToString() As String
        Return $"{Title}, Days = {NumDays}, Category = {Category}, Cost = {Cost.ToString("c")}"
    End Function












End Class
