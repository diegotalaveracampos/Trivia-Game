Public Class Frm_Pregunta3
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Exit_Button.Click
        If MessageBox.Show("Realmente desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        Else
            System.Environment.Exit(1)
        End If

    End Sub 'Boton Salir'

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Minimized_Button.Click
        WindowState = FormWindowState.Minimized

    End Sub 'Boton Minimizar'



    'Botones'

    Private Sub Btn_1_Click(sender As Object, e As EventArgs) Handles Btn_1.Click
        If Btn_1.Text = "Océano Pacifico" Then
            count_function.Contar_Correcta()
            MsgBox("Su respuesta es correcta")
            MsgBox("Su puntaje es de: " + Puntaje.ToString)
            Me.Hide()
            Frm_Pregunta4.Show()
        End If
    End Sub

    Private Sub Btn_2_Click(sender As Object, e As EventArgs) Handles Btn_2.Click
        count_function.Contar_Incorrecta()
        MsgBox("Su respuesta es incorrecta")
        MsgBox("Su puntaje es de: " + Puntaje.ToString)
        Me.Hide()
        Frm_Pregunta4.Show()
    End Sub

    Private Sub Btn_3_Click(sender As Object, e As EventArgs) Handles Btn_3.Click
        count_function.Contar_Incorrecta()
        MsgBox("Su respuesta es incorrecta")
        MsgBox("Su puntaje es de: " + Puntaje.ToString)
        Me.Hide()
        Frm_Pregunta4.Show()
    End Sub

    Private Sub Btn_4_Click(sender As Object, e As EventArgs) Handles Btn_4.Click
        count_function.Contar_Incorrecta()
        MsgBox("Su respuesta es incorrecta")
        MsgBox("Su puntaje es de: " + Puntaje.ToString)
        Me.Hide()
        Frm_Pregunta4.Show()
    End Sub
End Class
