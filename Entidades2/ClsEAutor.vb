Public Class ClsEAutor

    Private mId As Integer
    Private mNombre As String
    Private mApellido As String
    Private mNacionalidad As String
    Private mNac As Integer



    Public Property Id As Integer
        Get
            Return mId
        End Get
        Set(value As Integer)
            [mId] = value
        End Set
    End Property

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

    Public Property Nac As Integer
        Get
            Return mNac
        End Get
        Set(value As Integer)
            mNac = value
        End Set
    End Property


End Class
