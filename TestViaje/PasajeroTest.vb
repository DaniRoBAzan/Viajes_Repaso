Imports Viajes
Module PasajeroTest
    Sub main()
        Try
            Dim pasajero1 As New Pasajero(210921432, "Nombre Pasajero 1")
            Console.WriteLine("-ToString pasajero1: {0}", pasajero1.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim pasajero2 As New Pasajero(-21221432, "")
            Console.WriteLine("-ToString pasajero2: {0}", pasajero2.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim pasajero3 As New Pasajero(21221432, "")
            Console.WriteLine("-ToString pasajero2: {0}", pasajero3.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module
