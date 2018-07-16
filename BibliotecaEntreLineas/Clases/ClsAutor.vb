Public Class ClsAutor

    Private mNombre As String
    Private mApellido As String
    Private mLibrosEscritos As Integer
    Private mNacionalidad As String


    Public Property Nombre As String
        Get
            Return mNombre
        End Get
        Set(ByVal value As String)
            mNombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return mApellido
        End Get
        Set(value As String)
            mApellido = value
        End Set
    End Property

    Public Property LibrosEscritos As Integer
        Get
            Return mLibrosEscritos
        End Get
        Set(value As Integer)
            mLibrosEscritos = value
        End Set
    End Property

    Public Property Nacionalidad As String
        Get
            Return mNacionalidad
        End Get
        Set(value As String)
            mNacionalidad = value
        End Set
    End Property
End Class
