Imports Dominio
Imports Entidades
Public Class frmListadoAutor

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim unDAutor As New clsDAutor
        Dim unEAutor As New ClsEAutor
        Dim res As String
        'Carga de datos
        unEAutor.Nombre = txtNombre.Text
        'unEAutor.Apellido = txtApellido.Text
        'unEAutor.Nacionalidad = txtNacionalidad.Text
        'unEAutor.Nac = CInt(txtNacimiento.Text)
        'Envio de los datos
        res = unDAutor.ListadoAutor(unEAutor)
        txt2.Text = res

    End Sub



End Class