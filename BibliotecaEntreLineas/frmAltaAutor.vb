Imports Dominio
Imports Entidades

Public Class frmAltaAutor


    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim unDAutor As New clsDAutor
        Dim unEAutor As New ClsEAutor
        'Carga de datos
        unEAutor.Nombre = txtNombre.Text
        unEAutor.Apellido = txtApellido.Text
        unEAutor.Nacionalidad = txtNacionalidad.Text
        unEAutor.Nac = CInt(txtNacimiento.Text)
        'Envio de los datos
        unDAutor.AltaAutor(unEAutor)




    End Sub
End Class