Public Class ClsPersona

    Private mCedula As Integer 'hacer metodo verificador
    Private mApellido As String
    Private mNombre As String
    Private mDireccion As String
    Private mTelefono As String

    Public Property Cedula As Integer
        Get
            Return mCedula
        End Get
        Set(value As Integer)
            mCedula = value
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

    Public Property Nombre As String
        Get
            Return mNombre
        End Get
        Set(value As String)
            mNombre = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return mDireccion
        End Get
        Set(value As String)
            mDireccion = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return mTelefono
        End Get
        Set(value As String)
            mTelefono = value
        End Set
    End Property



    Public Sub New()

    End Sub

    Public Sub New(ci As Integer, nom As String, ape As String, tel As String, dir As String)
        Cedula = ci
        Nombre = nom
        Apellido = ape
        Telefono = tel
        Direccion = dir
    End Sub

    Public Function VerificarCI(ci As Integer) As Boolean
        Dim num(6) As Integer
        For i = 0 To 6
            num(i) = Integer.Parse(ci.ToString.ToCharArray()(i))
        Next
        Dim ver As Integer
        ver = num(0) * 8
        ver += num(1) * 1
        ver += num(2) * 2
        ver += num(3) * 3
        ver += num(4) * 4
        ver += num(5) * 7
        ver += num(6) * 6
        ver = ver Mod 10

        If ver = Integer.Parse(ci.ToString.ToCharArray()(7)) Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Sub AltaPersona(unapersona As ClsPersona)

    End Sub

End Class
