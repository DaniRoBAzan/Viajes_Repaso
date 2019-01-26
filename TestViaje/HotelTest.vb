Imports Viajes

Module HotelTest
    Sub main()
        Try
            Dim hotel1 As New Hotel("Descripcion Hotel 1", 1, 2, 100)
            Console.WriteLine("-ToString Hotel1 : {0}", hotel1.ToString())
            Console.WriteLine("-calcular costo: {0}", hotel1.CalcularCosto())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim hotel2 As New Hotel("Descripcion Hotel 2", 2, 2, 100)
            Console.WriteLine("-ToString Hotel2 : {0}", hotel2.ToString())
            Console.WriteLine("-calcular costo: {0}", hotel2.CalcularCosto())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub
End Module
