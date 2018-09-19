Imports System.ComponentModel
Imports Entidades

Public Class frmPrincipal
    Private usuario As New ClsEEmpleado

    Public Property unUsuario As ClsEEmpleado
        Get
            Return usuario
        End Get
        Set(value As ClsEEmpleado)
            usuario = value
        End Set
    End Property

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

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBienvenida.Text = "Bienvenido " & unUsuario.Nombre & " " & unUsuario.Apellido & " "
    End Sub

    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()

    End Sub

    Private Sub lblBienvenida_Click(sender As Object, e As EventArgs) Handles lblBienvenida.Click
        Dim frm As New frmEE
        frm.Show()
    End Sub

    Private Sub BajaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem1.Click
        Dim unfrmBajaAutor As New frmBajaAutor
        unfrmBajaAutor.MdiParent = Me
        unfrmBajaAutor.Show()
    End Sub

    Private Sub frmPrincipal_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate
        Dim activeChild As Form = Me.ActiveMdiChild
        If (Not activeChild Is Nothing) Then
            lblBienvenida.SendToBack()
        Else
            lblBienvenida.BringToFront()
        End If

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Dim unfrmModAutor As New frmModificarAutor
        unfrmModAutor.MdiParent = Me
        unfrmModAutor.Show()

    End Sub
End Class