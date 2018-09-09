Imports Persistencia
Imports Entidades
Public Class clsControladora

    'LOGIN
    Public Function login(usuario As String, contrasenia As String) As ClsEEmpleado
        Dim unDE As New clsDEmpleado
        Return unDE.login(usuario, contrasenia)
    End Function

    'Autor
    Public Function AltaAutor(unautor As ClsEAutor) As Boolean
        Dim unDAutor As New clsDAutor
        Return unDAutor.AltaAutor(unautor)
    End Function

    Public Function ListadoAutor(nombre As String) As List(Of ClsEAutor)
        Dim unDAutor As New clsDAutor
        Return unDAutor.ListadoAutor(nombre)
    End Function

    Public Function BajaAutor(id As Integer) As Boolean
        Dim unDAutor As New clsDAutor
        Return unDAutor.BajaAutor(id)
    End Function
End Class
