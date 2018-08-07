Imports Entidades

Public Class clsPAutor
    Inherits clsPersistencia

    Public Function AltaAutor(unautor As ClsEAutor) As Boolean
        Dim consulta As String
        consulta = "INSERT INTO autores (nombre,apellido,nacionalidad,nacimiento) VALUES ('" & unautor.Nombre & "','" & unautor.Apellido & "','" & unautor.Nacionalidad & "', " & unautor.Nac & ")"

        Return ejecutarSQL(consulta)
    End Function

End Class
