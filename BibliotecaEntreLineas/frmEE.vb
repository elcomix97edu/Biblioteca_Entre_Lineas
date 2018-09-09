Public Class frmEE
    Dim maxX As Integer
    Dim maxY As Integer
    Dim posX As Integer
    Dim posY As Integer
    Dim sumarX As Boolean = True
    Dim SumarY As Boolean = False
    Dim rnd As New Random

    Private Sub frmEE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        maxX = Me.Size.Width
        maxX = maxX - Label1.Size.Width

        maxY = Me.Size.Height
        maxY = maxY - Label1.Size.Height

        posX = Label1.Location.X
        posY = Label1.Location.Y

        Timer1.Enabled = True



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If posX = maxX Then
            sumarX = False
        ElseIf posX = 0 Then
            sumarX = True
        End If

        If posY = 0 Then
            SumarY = True
        ElseIf posY = maxY Then
            SumarY = False
        End If

        If sumarX Then
            posX = posX + 1
        Else
            posX = posX - 1

        End If

        If SumarY Then
            posY = posY + 1
        Else
            posY = posY - 1
        End If

        Label1.Location = New Point(posX, posY)
        Label1.ForeColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        Me.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
    End Sub
End Class
