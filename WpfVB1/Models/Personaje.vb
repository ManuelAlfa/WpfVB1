

Public Class Origin
        Public Property name As String
        Public Property url As String
    End Class

    Public Class Location
        Public Property name As String
        Public Property url As String
    End Class

Public Class Personaje

    Public Property id As Integer
    Public Property name As String
    Public Property status As String
    Public Property species As String
    Public Property type As String
    Public Property gender As String
    Public Property origin As Origin
    Public Property location As Location
    Public Property image As String
    Public Property episode As String()
    Public Property url As String
    Public Property created As DateTime
End Class



Public Class PersonajeDTO

    Public Property id As Integer
    Public Property name As String
    Public Property status As String
    Public Property species As String
    Public Property type As String
    Public Property gender As String
    Public Property image As String
    Public Property episode As String()
    Public Property url As String
    Public Property created As DateTime
End Class

