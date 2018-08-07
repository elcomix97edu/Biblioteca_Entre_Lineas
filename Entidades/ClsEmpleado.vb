Public Class ClsEmpleado
    Inherits ClsPersona

    Private mSueldo As Double

    Public Property Sueldo As Double
        Get
            Return mSueldo
        End Get
        Set(value As Double)
            mSueldo = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(nom As String, ap As String, dir As String, tel As String, ci As Integer, su As Double)
        Nombre = nom
        Apellido = ap
        Direccion = dir
        Telefono = tel
        Cedula = ci
        Sueldo = su


    End Sub


End Class
