Public Class ClsEEjemplar

    Private mID As Integer
    Private mNombre As String

    Public Property ID As Integer
        Get
            Return mID
        End Get
        Set(value As Integer)
            [mID] = value
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
End Class
