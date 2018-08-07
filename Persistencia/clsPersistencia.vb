
﻿Imports MySql.Data
Imports MySql.Data.MySqlClient
    Public Class clsPersistencia
        Private con As MySqlConnection
        Private Function conectar() As MySqlConnection
            If Not con Is Nothing Then con.Close()
            Dim miConexion As String
            miConexion = "server=localhost; uid=root ; password= ; database=  ;"
            Try
                con = New MySqlConnection(miConexion)
                con.Open()
            Catch ex As MySqlException
                MessageBox.Show("Error al conectarse con el servidor " & ex.Message)
            End Try
            Return con
        End Function

        Private Sub desconectar()
            con.Close()
        End Sub
        Public Function ejecutarSQL(ByVal consultaSQL As String) As Boolean
            Dim correctou As Boolean = True
            Dim comando As New MySqlCommand()
            comando.CommandText = consultaSQL
            comando.CommandType = CommandType.Text
            comando.Connection = conectar()
            Try
                comando.ExecuteNonQuery()
            Catch ex As MySqlException
                '  MessageBox.Show("Error al ejecutar las sentencias sql" & ex.Message)
                correctou = False
            End Try
            desconectar()
            Return correctou
        End Function

        Protected Function ejecutarYdevolver(ByVal sql As String) As MySqlDataReader
            Dim comando As New MySqlCommand
            Dim resultados As MySqlDataReader
            comando.CommandText = sql
            comando.CommandType = CommandType.Text
            comando.Connection = conectar()
            Try
                resultados = comando.ExecuteReader()
            Catch ex As MySqlException
                MessageBox.Show("Error al ejecutar las sentencias sql" & ex.Message)
            End Try
            Return resultados
            desconectar()
        End Function


    End Class


End Class
