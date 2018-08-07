Imports Entidades
Imports Persistencia
Public Class clsDAutor

    Public Function AltaAutor(unautor As ClsEAutor) As Boolean
        Dim unPAutor As New clsPAutor
        Return unPAutor.AltaAutor(unautor)
    End Function

End Class
