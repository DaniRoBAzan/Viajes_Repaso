Imports Viajes
Module PasajeTest
    Sub main()
        Try
            Dim pasaje1 As New Pasaje("Descripcion pasaje 1", Today, 100, 0.21)
            Console.WriteLine("-calcular costo: {0}", pasaje1.CalcularCosto())
            Console.WriteLine("-ToString : {0}", pasaje1.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub
End Module
