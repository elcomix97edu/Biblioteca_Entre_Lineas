Imports Entidades
Imports MySql.Data.MySqlClient

Public Class clsPAutor
    Inherits clsPersistencia

    Public Function AltaAutor(unautor As ClsEAutor) As Boolean
        Dim consulta As String
        consulta = "INSERT INTO autores (nombre,apellido,nacionalidad,nacimiento) VALUES ('" & unautor.Nombre & "','" & unautor.Apellido & "','" & unautor.Nacionalidad & "', " & unautor.Nac & ")"

        Return ejecutarSQL(consulta)
    End Function


    Public Function ListadoAutor(unautor As ClsEAutor) As String

        Dim consulta As String
        Dim datos As MySqlDataReader

        consulta = "SELECT * from autores"
        datos = ejecutarYdevolver(consulta)
        While datos.Read

        End While

        Return datos.Item("Nombre").ToString

    End Function

    Public Function crearAutor(ByVal datos As MySqlDataReader) As ClsEAutor
        Dim unAutor As New ClsEAutor

        unAutor.Nombre = datos.Item("nombre").ToString
        unAutor.Apellido = datos.Item("apellido").ToString
        unAutor.Nac = datos.Item("nacimiento").ToString
        unAutor.Nacionalidad = datos.Item("nacionalidad").ToString


        Return unAutor
    End Function

    Public Function listarAutores() As List(Of ClsEAutor)
        Dim consulta As String
        consulta = "SELECT * from autores"

        Dim colAutores As New List(Of ClsEAutor)
        Dim datos As MySqlDataReader
        datos = ejecutarYdevolver(consulta)

        While datos.Read
            Dim unAutor As New ClsEAutor
            unAutor = crearAutor(datos)
            colAutores.Add(unAutor)
        End While

        Return colAutores
    End Function

End Class
