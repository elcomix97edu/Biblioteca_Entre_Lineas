Public Class Form1

    Dim a As New ClsPersona

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        a.Cedula = Integer.Parse(txt.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If a.VerificarCI(a.Cedula) = True Then
            MsgBox("La cédula es válida")
        Else
            MsgBox("La cédula es inválida")
        End If
    End Sub
End Class
