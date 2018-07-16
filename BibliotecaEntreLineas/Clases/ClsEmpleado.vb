Public Class ClsEmpleado

    Private mNombre As String
    Private mApellido As String
    Private mDir As String
    Private mTel As String
    Private mSueldo As Integer
    Private mCi As Integer
    Private mFechaIngreso As Date

    Public Property Nombre As String
        Get
            Return mNombre
        End Get
        Set(value As String)
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

    Public Property Dir As String
        Get
            Return mDir
        End Get
        Set(value As String)
            mDir = value
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

    Public Property Sueldo As Integer
        Get
            Return mSueldo
        End Get
        Set(value As Integer)
            mSueldo = value
        End Set
    End Property

    Public Property Ci As Integer
        Get
            Return mCi
        End Get
        Set(value As Integer)
            mCi = value
        End Set
    End Property

    Public Property FechaIngreso As Date
        Get
            Return mFechaIngreso
        End Get
        Set(value As Date)
            mFechaIngreso = value
        End Set
    End Property
End Class
