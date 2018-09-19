Imports Dominio
Imports Entidades

Public Class frmAltaAutor
    Dim modificar As Boolean = False
    Dim Autor As New ClsEAutor

    Public Property UnAutor As ClsEAutor
        Get
            Return Autor
        End Get
        Set(value As ClsEAutor)
            Autor = value
        End Set
    End Property

    Public Property Modifico As Boolean
        Get
            Return modificar
        End Get
        Set(value As Boolean)
            modificar = value
        End Set
    End Property

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

    Private Sub frmAltaAutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Modifico Then
            btnIngresar.Visible = False
            btnModificar.Visible = True
            btnModificar.Location = btnIngresar.Location
            txtNombre.Text = Autor.Nombre
            txtApellido.Text = Autor.Apellido
            txtNacimiento.Text = Autor.Nac
            txtNacionalidad.Text = Autor.Nacionalidad
            Me.Name = "Modificar Autor"
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim uncont As New clsControladora
        Dim unEAutor As New ClsEAutor
        'Carga de datos
        unEAutor.Nombre = txtNombre.Text
        unEAutor.Apellido = txtApellido.Text
        unEAutor.Nacionalidad = txtNacionalidad.Text
        unEAutor.Nac = CInt(txtNacimiento.Text)
        unEAutor.Id = UnAutor.Id
        'Envio de los datos
        If uncont.ModificarAutor(unEAutor) Then
            MsgBox("Autor Modificado Correctamente")
        Else
            MsgBox("Ocurrio un error al modificar el autor")
        End If
    End Sub
End Class