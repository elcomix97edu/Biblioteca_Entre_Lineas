Public Class ClsAutor

    Private mNombre As String
    Private mApellido As String
    Private mNacionalidad As String
    Private mFechaNac As Date



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


    Public Property Nacionalidad As String
        Get
            Return mNacionalidad
        End Get
        Set(value As String)
            mNacionalidad = value
        End Set
    End Property

    Public Property FechaNac As Date
        Get
            Return mFechaNac
        End Get
        Set(value As Date)
            mFechaNac = value
        End Set
    End Property
End Class
