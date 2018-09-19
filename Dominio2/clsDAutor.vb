Imports Entidades
Imports Persistencia
Public Class clsDAutor

    Public Function AltaAutor(unautor As ClsEAutor) As Boolean
        Dim unPAutor As New clsPAutor
        Return unPAutor.AltaAutor(unautor)
    End Function

    Public Function ListadoAutor(nombre As String) As List(Of ClsEAutor)
        Dim unPAutor As New clsPAutor
        Return unPAutor.listarAutor2(nombre)
    End Function

    Public Function BajaAutor(id As Integer) As Boolean
        Dim unPAutor As New clsPAutor
        Return unPAutor.eliminarAutor(id)
    End Function

    Public Function ModificarAutor(unautor As ClsEAutor) As Boolean
        Dim unPAutor As New clsPAutor
        Return unPAutor.modificarAutor(unautor)
    End Function

End Class
