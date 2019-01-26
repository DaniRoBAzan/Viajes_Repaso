Imports Viajes
Module PaqueteTest
    Sub Main()
        Dim paquete1 As New Paquete()
        Dim pasajero1 As New Pasajero(38271211, "Nombre Pasajero 1")
        Dim pasajero2 As New Pasajero(32719651, "Nombre Pasajero 2")
        Dim hotel1 As New Hotel("Descripcion 1", 1, 2, 100)
        Dim hotel2 As New Hotel("Descripcion 2", 2, 2, 200)
        paquete1.addPasajero(pasajero1)
        paquete1.addPasajero(pasajero2)
        paquete1.addServicio(hotel1)
        paquete1.addServicio(hotel2)
        'Console.WriteLine("-calcular costo: {0}", Paquete.CalcularCosto())
        Console.WriteLine("-ToString: {0}", paquete1.ToString())
        Console.WriteLine("-Listado de pasajeros")
        For Each pasajero In paquete1.getAllPasajeros()
            Console.WriteLine("- {0}", pasajero.ToString())
        Next
        Console.WriteLine("-Listado de servicios")
        For Each servicio In paquete1.getAllServicio()
            Console.WriteLine("- {0}", servicio.ToString())
        Next
        Console.ReadLine()

    End Sub
End Module
