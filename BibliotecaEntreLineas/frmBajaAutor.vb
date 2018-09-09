Imports Dominio
Imports Entidades
Public Class frmBajaAutor
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim unacon As New clsControladora
        Dim res As String

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
        Next

    End Sub

    Private Sub dgvDatos_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDatos.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then 'Verifica que los click no sean el los bordes

            Dim idAutor = CInt(dgvDatos.Rows(e.RowIndex).Cells(0).Value.ToString)
            Dim nombre = dgvDatos.Rows(e.RowIndex).Cells(1).Value.ToString
            Dim apellido = dgvDatos.Rows(e.RowIndex).Cells(2).Value.ToString

            txtNombre.Text = idAutor

            Select Case MsgBox("Desea quitar el autor " & nombre & " " & apellido & " del sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Baja Autor")
                Case MsgBoxResult.Yes
                    Dim unaC As New clsControladora
                    If unaC.BajaAutor(idAutor) Then
                        MsgBox("Autor Eliminado Correctamente")
                    Else
                        MsgBox("Ocurrio un error al eliminar el autor")
                    End If
                    'Case MsgBoxResult.No
                    '    MessageBox.Show("NO button")
            End Select
        End If
    End Sub
End Class