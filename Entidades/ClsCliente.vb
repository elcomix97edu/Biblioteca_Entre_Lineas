Public Class ClsCliente

    Private mNombre As String
    Private mApellodo As String
    Private mCI As Integer
    Private mTel As String
    Private mDir As String
    Private mNumCli As Integer

    Public Property Nombre As String
        Get
            Return mNombre
        End Get
        Set(value As String)
            mNombre = value
        End Set
    End Property

    Public Property Apellodo As String
        Get
            Return mApellodo
        End Get
        Set(value As String)
            mApellodo = value
        End Set
    End Property

    Public Property CI As Integer
        Get
            Return mCI
        End Get
        Set(value As Integer)
            mCI = value
        End Set
    End Property

    Public Property Tel As String
        Get
            Return mTel
        End Get
        Set(value As String)
            mTel = value
        End Set
    End Property

    Public Property Dir As String
        Get
            Return mDir
        End Get
        Set(value As String)
            mDir = value
        End Set
    End Property

    Public Property NumCli As Integer
        Get
            Return mNumCli
        End Get
        Set(value As Integer)
            mNumCli = value
        End Set
    End Property
End Class
