Public MustInherit Class Servicio
    Private _descripcion As String
    Private Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Descripcion
    End Function

    Sub New(descpripcion As String)
        Me.Descripcion = descpripcion
    End Sub
End Class
