Public Class Cliente
    Private _cuil_cuil As String
    Private _persona As Pasajero
    Public Property Persona As Pasajero
        Get
            Return _persona
        End Get
        Set(value As Pasajero)
            _persona = value
        End Set
    End Property
    Public Property CUIT_CUIL As String
        Get
            Return _cuil_cuil
        End Get
        Set(value As String)
            _cuil_cuil = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Persona.Nombre
    End Function
    Sub New(persona As Pasajero, cuil_cuil As String)
        Me.Persona = persona
        Me.CUIT_CUIL = cuil_cuil
    End Sub
End Class
