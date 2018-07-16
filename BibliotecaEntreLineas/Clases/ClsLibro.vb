Public Class ClsLibro

    Private mNombre As String
    Private mEditrial As String
    Private mAutor As String
    Private mISBN As Integer
    Private mFechaPub As Date

    Public Property MNombre1 As String
        Get
            Return mNombre
        End Get
        Set(value As String)
            mNombre = value
        End Set
    End Property

    Public Property MEditrial1 As String
        Get
            Return mEditrial
        End Get
        Set(value As String)
            mEditrial = value
        End Set
    End Property

    Public Property MAutor1 As String
        Get
            Return mAutor
        End Get
        Set(value As String)
            mAutor = value
        End Set
    End Property

    Public Property MISBN1 As Integer
        Get
            Return mISBN
        End Get
        Set(value As Integer)
            mISBN = value
        End Set
    End Property

    Public Property MFechaPub1 As Date
        Get
            Return mFechaPub
        End Get
        Set(value As Date)
            mFechaPub = value
        End Set
    End Property
End Class
