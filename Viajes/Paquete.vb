Public Class Paquete
    Implements IAbono
    Private _fechaFinal As Date
    Private _fechaInicial As Date
    'Private _numeroDias As Integer
    Private _numeroMiembros As Integer
    Private _cliente As Cliente
    Private _listaPasajeros As List(Of Pasajero)
    Private _listaServicios As List(Of Servicio)
    Private ReadOnly Property FechaFinal As Date
        Get
            Return _fechaFinal
        End Get
    End Property
    Private ReadOnly Property FechaInicial As Date
        Get
            Return _fechaInicial
        End Get
    End Property
    Private ReadOnly Property NumeroDias As Integer
        Get
            Return calcularNumeroDias()
        End Get
    End Property
    Private ReadOnly Property NumeroMiembros As Integer
        Get
            Return CalcularNumeroMiembros()
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
    Public Sub addPasajero(var As Pasajero)
        _listaPasajeros.Add(var)
    End Sub
    'Public Sub removePasajero(var As Pasajero)
    '    _listaPasajeros.Remove(var)
    'End Sub
    Public Function getAllPasajeros() As List(Of Pasajero)
        Return _listaPasajeros
    End Function
    Public Sub addServicio(var As Servicio)
        _listaServicios.Add(var)
    End Sub
    'Public Sub removeServicio(var As Servicio)
    '    _listaServicios.Remove(var)
    'End Sub
    Public Function getAllServicio() As List(Of Servicio)
        Return _listaServicios
    End Function
    Public Function calcularNumeroDias() As Integer
        Return FechaFinal.Day - FechaInicial.Day
    End Function
    Public Function CalcularNumeroMiembros() As Integer
        _numeroMiembros = _listaPasajeros.Count()
        Return _numeroMiembros
    End Function
    Public Function CalcularCosto() As Single Implements IAbono.CalcularCosto
        Dim total As Single
        '==> Falta sacar los importes de cada servicio y sumarlos.!!
        'For Each servicio In _listaServicios
        '    total += servicio.calcularCosto()
        'Next
        Return total
    End Function
    Public Overrides Function ToString() As String
        Dim var As String = ""
        For Each elemento In _listaServicios
            var += " - "
            var += elemento.ToString()
        Next

        Return var
    End Function

    Sub New()
        _listaPasajeros = New List(Of Pasajero)
        _listaServicios = New List(Of Servicio)
    End Sub
End Class
