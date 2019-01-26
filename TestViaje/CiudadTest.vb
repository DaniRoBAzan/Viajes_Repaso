Imports Viajes
Module CiudadTest
    Sub Main()
        Try
            Dim ciudad1 As New Ciudad("Posadas")
            Console.WriteLine("-ToString : {0}", ciudad1.ToString())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub
End Module
