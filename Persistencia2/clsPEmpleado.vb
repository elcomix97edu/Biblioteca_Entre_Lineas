Imports MySql.Data.MySqlClient
Imports Entidades

Public Class clsPEmpleado
    Inherits clsPersistencia
    Public Function login(usuario As String, pass As String) As ClsEEmpleado
        Dim consultaSQL As String
        consultaSQL = "SELECT * FROM empleados INNER JOIN personas ON empleados.cedulaEmpleado = personas.cedula WHERE cedulaEmpleado='" & usuario & "' AND pass='" & pass & "';"
        Dim datos = ejecutarYdevolver(consultaSQL)
        If datos.HasRows Then
            datos.Read()
            Dim unEmpleado = crearEmpleado(datos)
            Return unEmpleado
        Else
            Return Nothing
        End If

    End Function

    Private Function crearEmpleado(datoFilas As MySqlDataReader) As ClsEEmpleado
        Dim unEmp As New ClsEEmpleado
        unEmp.Nombre = datoFilas.Item("nombre").ToString
        unEmp.Apellido = datoFilas.Item("apellido").ToString
        unEmp.Cedula = datoFilas.Item("cedula").ToString
        unEmp.Direccion = datoFilas.Item("direccion").ToString
        unEmp.Telefono = datoFilas.Item("telefono").ToString
        unEmp.Sueldo = datoFilas.Item("sueldo").ToString
        unEmp.TipoEmpleado = datoFilas.Item("tipoUsuario").ToString
        unEmp.Pass = datoFilas.Item("pass").ToString

        Return unEmp
    End Function
End Class
