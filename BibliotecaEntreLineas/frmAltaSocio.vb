Imports MySql.Data.MySqlClient
Public Class frmAltaSocio

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=Belpois59656;database=visual")

    Private MysqlCommand As New MySqlCommand
    Dim MysqlConnString As String = "server=localhost; user id= root ; password=Belpois59656"
    Public MysqlConexion As MySqlConnection = New MySqlConnection(MysqlConnString)

    Public Sub Probarconexion()
        Try
            MysqlConexion.Open()
            MsgBox("la conexión fue exitosa")
            MysqlConexion.Close()
        Catch ex As Exception
            MsgBox("La conexión no fue exitosa")
        End Try
    End Sub

    Public Sub Coso()

        Dim command As New MySqlCommand("SELECT * FROM `text` WHERE `id` = 1", connection)

        'command.Parameters.Add("@id", MySqlDbType.Int64).Value = TextBox1.Text

        Dim reader As MySqlDataReader

        connection.Open()

        reader = command.ExecuteReader()

        If reader.Read() Then

            TextBox1.Text = reader(0)
            TextBox2.Text = reader(1)
            'DateTimePicker1.Value = reader(3)

        End If

        connection.Close()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Probarconexion()
        Coso()

    End Sub
End Class