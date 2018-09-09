Module VerificarCampo
    Public Function VerificarCampos(unForm As Form) As Boolean
        Dim bandera As Boolean = True
        For Each unControl In unForm.Controls
            If TypeOf unControl Is TextBox Then
                unControl.backcolor = Color.White
                If unControl.Text = "" Then
                    unControl.backcolor = Color.Red
                    'MsgBox("Hay campos vacios")
                    bandera = False
                End If
            End If

            If TypeOf unControl Is MaskedTextBox Then
                unControl.backcolor = Color.White
                If unControl.maskfull = False Then
                    unControl.backcolor = Color.Red
                    'MsgBox("Hay campos vacios")
                    bandera = False
                End If
            End If
        Next
        If bandera = False Then
            MsgBox("Hay campos vacios")
        End If

        Return bandera
    End Function

End Module
