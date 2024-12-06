Public Class Airport
    Public Property Code As String
    Public Property UtcOffset As Integer
    Public Sub New(pCode As String, utc As Integer)
        Code = pCode
        UtcOffset = utc
    End Sub
End Class
