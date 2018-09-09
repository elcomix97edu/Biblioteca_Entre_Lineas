Imports Dominio
Imports Entidades

Public Class frmAltaAutor


    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim uncont As New clsControladora
        Dim unEAutor As New ClsEAutor
        'Carga de datos
        unEAutor.Nombre = txtNombre.Text
        unEAutor.Apellido = txtApellido.Text
        unEAutor.Nacionalidad = txtNacionalidad.Text
        unEAutor.Nac = CInt(txtNacimiento.Text)
        'Envio de los datos
        If uncont.AltaAutor(unEAutor) Then
            MsgBox("Autor Agregador Correctamente")
        Else
            MsgBox("Ocurrio un error al agregar el autor")
        End If




    End Sub
End Class