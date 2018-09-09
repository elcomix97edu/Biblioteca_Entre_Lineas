Public Class ClsEEmpleado
    Inherits ClsEPersona

    Private mSueldo As Double
    Private mTipoEmpleado As String
    Private mPass As String


    Public Property Sueldo As Double
        Get
            Return mSueldo
        End Get
        Set(value As Double)
            mSueldo = value
        End Set
    End Property

    Public Property TipoEmpleado As String
        Get
            Return mTipoEmpleado
        End Get
        Set(value As String)
            mTipoEmpleado = value
        End Set
    End Property

    Public Property Pass As String
        Get
            Return mPass
        End Get
        Set(value As String)
            mPass = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(nom As String, ap As String, dir As String, tel As String, ci As Integer, su As Double, te As Double)
        Nombre = nom
        Apellido = ap
        Direccion = dir
        Telefono = tel
        Cedula = ci
        Sueldo = su
        TipoEmpleado = te


    End Sub


End Class
