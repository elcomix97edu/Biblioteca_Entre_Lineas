Public Class frmPrincipal
    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Dim unfrmAltaSocio As New frmAltaSocio
        unfrmAltaSocio.MdiParent = Me
        unfrmAltaSocio.Show()

    End Sub
End Class