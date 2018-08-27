Imports Entidades
Imports Persistencia
Public Class clsDAutor

    Public Function AltaAutor(unautor As ClsEAutor) As Boolean
        Dim unPAutor As New clsPAutor
        Return unPAutor.AltaAutor(unautor)
    End Function

    Public Function ListadoAutor(unautor As ClsEAutor) As String
        Dim unPAutor As New clsPAutor
        Return unPAutor.ListadoAutor(unautor)
    End Function

End Class
