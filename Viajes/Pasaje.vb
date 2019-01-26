Public Class Pasaje
    Inherits Servicio
    Implements IAbono
    Private _fecha As Date
    Private _impuesto As Single
    Private _valor As Single
    Private _ciudadDestino As Ciudad
    Private _ciudadOrigen As Ciudad
    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public Property Impuesto As Single
        Get
            Return _impuesto
        End Get
        Set(value As Single)
            _impuesto = value
        End Set
    End Property
    Public Property Valor As Single
        Get
            Return _valor
        End Get
        Set(value As Single)
            _valor = value
        End Set
    End Property
    Public Property CiudadDestino As Ciudad
        Get
            Return _ciudadDestino
        End Get
        Set(value As Ciudad)
            _ciudadDestino = value
        End Set
    End Property
    Public Property CiudadOrigen As Ciudad
        Get
            Return _ciudadOrigen
        End Get
        Set(value As Ciudad)
            _ciudadOrigen = value
        End Set
    End Property
    Public Function CalcularCosto() As Single Implements IAbono.CalcularCosto
        Return Valor + (Valor * Impuesto)
    End Function
    Sub New(descripcion As String, fecha As Date, valor As Single, impuesto As Single)
        MyBase.New(descripcion)
        Me.Fecha = fecha
        Me.Valor = valor
        Me.Impuesto = impuesto
    End Sub
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
