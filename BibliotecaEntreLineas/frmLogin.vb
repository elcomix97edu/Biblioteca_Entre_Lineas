Imports Dominio
Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim unDE As New clsDEmpleado
        If unDE.login(TextBox1.Text, TextBox2.Text) Then
            Dim frm As New frmPrincipal
            frm.Show()
            Me.Hide()
        End If
    End Sub
End Class