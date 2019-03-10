Public Class Paquete
    Implements Abono
    Private _fechaFinal As Date
    Private _fechaInicial As Date
    Private _cliente As Cliente
    Private _pasajeros As List(Of Pasajero)
    Private _servicios As List(Of Servicio)
    Public Function CalcularCosto() As Single Implements Abono.CalcularCosto
        ''SUMATORIA DE LOS COSTOS DE LOS SERVICIOS  
        Dim total As Single
        For Each servicio In _servicios.OfType(Of Hotel)
            total += servicio.CalcularCosto
        Next
        For Each servicio In _servicios.OfType(Of Pasaje)
            total += servicio.CalcularCosto
        Next

        Return total
    End Function
    Public ReadOnly Property FechaFinal As Date
        Get
            Return _fechaFinal
        End Get
    End Property
    Public ReadOnly Property FechaInicial As Date
        Get
            Return _fechaInicial
        End Get
    End Property
    Public ReadOnly Property NumeroDias As Integer
        Get
            Return DateDiff(DateInterval.Day, FechaInicial, FechaFinal)
        End Get
    End Property
    Public ReadOnly Property NumeroMiembros As Integer
        Get
            Return _pasajeros.Count()
        End Get
    End Property
    Public Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Set(value As Cliente)
            _cliente = value
        End Set
    End Property
    ''====> CARDINALIDAD CON PASAJERO 
    Public Sub AddPasajero(variable As Pasajero)
        _pasajeros.Add(variable)
    End Sub
    Public Sub RemovePasajero(variable As Pasajero)
        _pasajeros.Remove(variable)
    End Sub
    Public Function GetAllPasajeros() As List(Of Pasajero)
        Return _pasajeros
    End Function
    ''=====> CARDINALIDAD 1-M CON SERVICIOS CLASE RESPONSABLE
    Public Sub AddServicio(variable As Servicio)
        _servicios.Add(variable)
    End Sub
    Public Sub RemoveServicio(variable As Servicio)
        _servicios.Remove(variable)
    End Sub
    Public Function GetAllServicios() As List(Of Servicio)
        Return _servicios
    End Function
    Public Overrides Function ToString() As String
        Dim cadena As String = ""
        ''concatenacion de los toString() de los  servicios
        For Each servicio In _servicios
            cadena += servicio.ToString() & " - "
        Next
        Return cadena
    End Function
    Sub New()
        _pasajeros = New List(Of Pasajero)
        _servicios = New List(Of Servicio)
    End Sub
End Class
