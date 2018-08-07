Imports _BibliotecaEntreLineas

Public Class ClsELibro

    Private mTitulo As String
    Private mTipo As String
    Private mEditrial As String
    Private mAño As Integer
    Private mAutor As ClsEAutor
    Private mID As Integer
    Private mISBN As Integer

    Public Property Titulo As String
        Get
            Return mTitulo
        End Get
        Set(value As String)
            mTitulo = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return mTipo
        End Get
        Set(value As String)
            mTipo = value
        End Set
    End Property

    Public Property Editrial As String
        Get
            Return mEditrial
        End Get
        Set(value As String)
            mEditrial = value
        End Set
    End Property

    Public Property Año As Integer
        Get
            Return mAño
        End Get
        Set(value As Integer)
            mAño = value
        End Set
    End Property

    Public Property Autor As ClsEAutor
        Get
            Return mAutor
        End Get
        Set(value As ClsEAutor)
            mAutor = value
        End Set
    End Property

    Public Property ID As Integer
        Get
            Return mID
        End Get
        Set(value As Integer)
            [mID] = value
        End Set
    End Property

    Public Property ISBN As Integer
        Get
            Return mISBN
        End Get
        Set(value As Integer)
            mISBN = value
        End Set
    End Property
End Class
