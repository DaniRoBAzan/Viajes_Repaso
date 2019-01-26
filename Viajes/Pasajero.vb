Public Class Pasajero
    Private _dni As Integer
    Private _nombre As String
    Public Property DNI As Integer
        Get
            Return _dni
        End Get
        Set(value As Integer)
            If value < 0 Then
                Throw New Exception("El DNI no puede ser menor a cero!!")
            End If
            _dni = value
        End Set
    End Property
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
    Sub New(dni As Integer, nombre As String)
        Me.DNI = dni
        Me.Nombre = nombre
    End Sub
End Class