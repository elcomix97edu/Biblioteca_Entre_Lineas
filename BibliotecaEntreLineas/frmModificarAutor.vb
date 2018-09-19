Imports Dominio
Imports Entidades
Public Class frmModificarAutor


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim unacon As New clsControladora
        Dim res As String
        dgvDatos.Rows.Clear()

        res = txtNombre.Text
        Dim lista = unacon.ListadoAutor(res)

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

    Private Sub dgvDatos_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDatos.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then 'Verifica que los click no sean el los bordes

            Dim idAutor = CInt(dgvDatos.Rows(e.RowIndex).Cells(0).Value.ToString)
            Dim nombre = dgvDatos.Rows(e.RowIndex).Cells(1).Value.ToString
            Dim apellido = dgvDatos.Rows(e.RowIndex).Cells(2).Value.ToString
            Dim nacimiento = dgvDatos.Rows(e.RowIndex).Cells(3).Value.ToString
            Dim nacionalidad = dgvDatos.Rows(e.RowIndex).Cells(4).Value.ToString

            txtNombre.Text = idAutor

            Select Case MsgBox("Desea Modifiar el autor " & nombre & " " & apellido & "", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Modifiar Autor")
                Case MsgBoxResult.Yes
                    'Dim unaC As New clsControladora
                    'If unaC.BajaAutor(idAutor) Then
                    '    MsgBox("Autor Eliminado Correctamente")
                    'Else
                    '    MsgBox("Ocurrio un error al Mo el autor")
                    'End If
                    'Case MsgBoxResult.No
                    '    MessageBox.Show("NO button")

                    Dim autor As New ClsEAutor
                    autor.Id = idAutor
                    autor.Nombre = nombre
                    autor.Apellido = apellido
                    autor.Nac = nacimiento
                    autor.Nacionalidad = nacionalidad

                    Dim unfrmAltaAutor As New frmAltaAutor
                    unfrmAltaAutor.UnAutor = autor
                    unfrmAltaAutor.Modifico = True
                    'unfrmAltaAutor.MdiParent = frmPrincipal
                    unfrmAltaAutor.Show()

            End Select
        End If
    End Sub

End Class