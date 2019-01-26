Imports Viajes
Module ClienteTest
    Sub main()
        Try
            Dim pasajero1 As New Pasajero(12345678, "Nombre Pasajero1")
            Dim Cliente1 As New Cliente(pasajero1, 27 - 12345678 - 7)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module
