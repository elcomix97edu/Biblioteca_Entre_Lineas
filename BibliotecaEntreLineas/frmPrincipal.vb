Public Class frmPrincipal
    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Dim unfrmAltaSocio As New frmAltaSocio
        unfrmAltaSocio.MdiParent = Me
        unfrmAltaSocio.Show()

    End Sub

    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem1.Click
        Dim unfrmAltaSocio As New frmAltaAutor
        unfrmAltaSocio.MdiParent = Me
        unfrmAltaSocio.Show()
    End Sub

    Private Sub ListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem.Click
        Dim unfrmListadoSocio As New frmListadoAutor
        unfrmListadoSocio.MdiParent = Me
        unfrmListadoSocio.Show()
    End Sub
End Class