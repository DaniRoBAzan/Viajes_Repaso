Public Class Viajes

    Public _listaCiudades As List(Of Ciudad)
    Public _listaPaquete As List(Of Paquete)
    Public Function getCityByID(id As String) As Ciudad
        For Each ciudad In _listaCiudades
            If ciudad.ToString() = id Then
                Return ciudad
            End If
        Next
        Return Nothing
    End Function

    Public Function getPaqueteByCliente(cuit_cuil As String) As Paquete
        For Each paquete In _listaPaquete
            If paquete.Cliente.CUIT_CUIL = cuit_cuil Then
                Return paquete
            End If
        Next
        Return Nothing
    End Function
End Class
