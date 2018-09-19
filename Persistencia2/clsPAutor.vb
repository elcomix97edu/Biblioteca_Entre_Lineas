Imports Entidades
Imports MySql.Data.MySqlClient

Public Class clsPAutor
    Inherits clsPersistencia

    Public Function AltaAutor(unautor As ClsEAutor) As Boolean
        Dim consulta As String
        consulta = "INSERT INTO autores (nombreAutor,apellidoAutor,nacionalidadAutor,fechaNacimiento) VALUES ('" & unautor.Nombre & "','" & unautor.Apellido & "','" & unautor.Nacionalidad & "', " & unautor.Nac & ")"

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

        unAutor.Id = CInt(datos.Item("idAutor").ToString)
        unAutor.Nombre = datos.Item("nombreAutor").ToString
        unAutor.Apellido = datos.Item("apellidoAutor").ToString
        unAutor.Nac = datos.Item("fechaNacimiento").ToString
        unAutor.Nacionalidad = datos.Item("nacionalidadAutor").ToString



        Return unAutor
    End Function

    'Public Function listarAutor(nombre As String) As ClsEAutor
    '    Dim consulta As String
    '    consulta = "SELECT * FROM autores WHERE nombre='" & nombre
    '    Dim unAutor As New ClsEAutor
    '    Dim datos As MySqlDataReader
    '    datos = ejecutarYdevolver(consulta)

    '    While datos.Read

    '        unAutor = crearAutor(datos)
    '    End While

    '    Return unAutor
    'End Function

    Public Function listarAutor2(nombre As String) As List(Of ClsEAutor)
        Dim consulta As String
        consulta = "SELECT * FROM autores WHERE nombreAutor='" & nombre & "';"

        Dim datos As MySqlDataReader
        datos = ejecutarYdevolver(consulta)

        Dim listaautores As New List(Of ClsEAutor)

        While datos.Read
            Dim unHorario As New ClsEAutor
            unHorario = crearAutor(datos)
            listaautores.Add(unHorario)
        End While

        Return listaautores
    End Function

    Public Function eliminarAutor(id As Integer) As Boolean
        Dim consulta As String
        consulta = "DELETE FROM autores WHERE idAutor =" & id & ";"
        Return ejecutarSQL(consulta)
    End Function

    Public Function modificarAutor(unautor As ClsEAutor) As Boolean
        Dim consulta As String
        consulta = "UPDATE autores SET nombreAutor = '" & unautor.Nombre & "' , apellidoAutor = '" & unautor.Apellido & "' , nacionalidadAutor = '" & unautor.Nacionalidad & "', fechaNacimiento = " & unautor.Nac & " WHERE idAutor =" & unautor.Id & "; "
        Return ejecutarSQL(consulta)

    End Function

End Class
