Public Class Ciudad
    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value = "" Or value = Nothing Then
                Throw New Exception("El nombre no puede estar vacio!")
            End If
            If value.Length > 30 Then
                Throw New Exception("El nombre nombre no debe superar los 30 caracteres!")
            End If
            _nombre = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub
End Class
