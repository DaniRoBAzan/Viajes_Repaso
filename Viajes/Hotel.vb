Public Class Hotel
    Inherits Servicio
    Implements IAbono
    Private _ciudad As Ciudad
    Private _numeroHabitaciones As Integer
    Private _numeroNoches As Integer
    Private _valorDiaria As Single
    Public Property NumeroHabitaciones As Integer
        Get
            Return _numeroHabitaciones
        End Get
        Set(value As Integer)
            If value < 0 Then
                Throw New Exception("El campo no debe ser menor a 0!!")
            End If
            _numeroHabitaciones = value
        End Set
    End Property
    Public Property NumeroNoches As Integer
        Get
            Return _numeroNoches
        End Get
        Set(value As Integer)
            If value < 0 Then
                Throw New Exception("El campo no debe ser menor a 0!!")
            End If
            _numeroNoches = value
        End Set
    End Property
    Public Property ValorDiaria As Single
        Get
            Return _valorDiaria
        End Get
        Set(value As Single)
            If value < 0 Then
                Throw New Exception("El campo no debe ser menor a 0!!")
            End If
            _valorDiaria = value
        End Set
    End Property
    Public Property Ciudad As Ciudad
        Get
            Return _ciudad
        End Get
        Set(value As Ciudad)
            _ciudad = value
        End Set
    End Property

    Public Function CalcularCosto() As Single Implements IAbono.CalcularCosto
        Return ValorDiaria * NumeroHabitaciones * NumeroNoches
    End Function
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
    Sub New(descripcion As String, habitaciones As Integer, noches As Integer, valorDiaria As Single)
        MyBase.New(descripcion)
        Me.NumeroHabitaciones = habitaciones
        Me.NumeroNoches = noches
        Me.ValorDiaria = valorDiaria
    End Sub

End Class
