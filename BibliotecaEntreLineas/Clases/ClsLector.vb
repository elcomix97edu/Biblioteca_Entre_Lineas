Public Class ClsLector
    Inherits ClsPersona

    Private mMail As String

    Public Sub New()

    End Sub

    Public Sub New(ced As Integer, nom As String, ap As String, dir As String, tel As String, ma As String)
        Cedula = ced
        Nombre = nom
        Apellido = ap
        Direccion = dir
        Telefono = tel
        Mail = ma
    End Sub


    Public Property Mail As String
        Get
            Return mMail
        End Get
        Set(value As String)
            mMail = value
        End Set
    End Property
End Class
