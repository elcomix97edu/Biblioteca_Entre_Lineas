Imports Dominio
Imports Entidades
Public Class frmListadoAutor


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim unacon As New clsControladora
        'Dim unEAutor As New ClsEAutor
        Dim res As String
        'Carga de datos
        'unEAutor.Nombre = txtNombre.Text
        'unEAutor.Apellido = txtApellido.Text
        'unEAutor.Nacionalidad = txtNacionalidad.Text
        'unEAutor.Nac = CInt(txtNacimiento.Text)
        'Envio de los datos
        'res = unDAutor.ListadoAutor(unEAutor)
        res = txtNombre.Text
        Dim lista = unacon.ListadoAutor(res)
        dgvDatos.Rows.Clear()

        Dim Row As DataGridViewRow
        Dim Cell As DataGridViewCell
        Dim a As Integer = 0

        For Each unAutor In lista
            Row = New DataGridViewRow

            Cell = New DataGridViewTextBoxCell
            Cell.Value = unAutor.Id.ToString
            Row.Cells.Add(Cell)

            Cell = New DataGridViewTextBoxCell
            Cell.Value = unAutor.Nombre.ToString
            Row.Cells.Add(Cell)

            Cell = New DataGridViewTextBoxCell
            Cell.Value = unAutor.Apellido.ToString
            Row.Cells.Add(Cell)

            Cell = New DataGridViewTextBoxCell
            Cell.Value = unAutor.Nac.ToString
            Row.Cells.Add(Cell)

            Cell = New DataGridViewTextBoxCell
            Cell.Value = unAutor.Nacionalidad.ToString
            Row.Cells.Add(Cell)


            Me.dgvDatos.Rows.Add(Row)
            a = a + 1

        Next
        If a = 0 Then
            MsgBox("No se encontró ningun resultado", MsgBoxStyle.Exclamation)

        End If

        'dgvDatos.DataSource = unacon.ListadoAutor(res)


    End Sub


End Class