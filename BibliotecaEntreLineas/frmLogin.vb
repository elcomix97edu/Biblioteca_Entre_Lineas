Imports Dominio
Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim ver As New clsValidar

        'If ver.Valido(TextBox1.Text) Then

        '    If ver.VerificarCI(CInt(TextBox1.Text)) Then

        '        If ver.Valido(TextBox2.Text) Then

        '            Dim unDE As New clsDEmpleado
        '            If unDE.login(TextBox1.Text, TextBox2.Text) Then
        '                Dim frm As New frmPrincipal
        '                frm.Show()
        '                Me.Hide()
        '            End If

        '        Else
        '            MsgBox("Contraseña vacia")
        '        End If

        '    Else
        '        MsgBox("Cédula inválida")
        '    End If

        'Else
        '    MsgBox("Cédula vacia")
        'End If
        If VerificarCampos(Me) Then
            Dim unCont As New clsControladora
            Dim unEmpl = unCont.login(TextBox1.Text, TextBox2.Text)
            If unEmpl Is Nothing Then
                MsgBox("Usuario y/o Contraseña Invalidos", MsgBoxStyle.Critical)
            Else
                Dim frm As New frmPrincipal
                frm.unUsuario = unEmpl
                frm.Show()
                Me.Hide()
            End If
        End If

    End Sub

    'Public Function VerificarCampos() As Boolean
    '    For Each unControl In Me.Controls
    '        If TypeOf unControl Is TextBox Then
    '            unControl.backcolor = Color.White
    '            If unControl.Text = "" Then
    '                unControl.backcolor = Color.Red
    '                MsgBox("Hay campos vacios")
    '                Return False
    '            End If
    '        End If
    '    Next
    '    Return True
    'End Function
End Class