Imports System.IO
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports System.Reflection
Public Class Frm_Tutorial
    Private Sub Minimized_Button_Click(sender As Object, e As EventArgs) Handles Minimized_Button.Click
        WindowState = FormWindowState.Minimized
    End Sub 'Boton Minimizar'

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        If MessageBox.Show("Realmente desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        Else
            System.Environment.Exit(1)
        End If
    End Sub 'Boton Salir'

    Private Sub lbl_Texto1_TextChanged(sender As Object, e As EventArgs) Handles lbl_Texto1.TextChanged

        Dim pfc As New PrivateFontCollection
        Dim resource As String = "Trivia_Game.04B_30__.TTF"
        Dim fontstream As Stream
        Dim data As IntPtr
        Dim fontdata As Byte()
        fontstream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource)
        data = Marshal.AllocCoTaskMem(CInt(fontstream.Length))
        fontdata = New Byte(fontstream.Length - 1) {}
        fontstream.Read(fontdata, 0, CInt(fontstream.Length))
        Marshal.Copy(fontdata, 0, data, CInt(fontstream.Length))
        pfc.AddMemoryFont(data, CInt(fontstream.Length))
        fontstream.Close()
        Marshal.FreeCoTaskMem(data)

        lbl_Texto1.Text = "Te damos la bienvenida al juego de trivia mas interesante." & vbCrLf + "hablaremos de muchos temas de cultura general y muchos mas.
        " & vbCrLf & "Pocos han logrado la cima de este reto tan dificil" & vbCrLf & "Esperamos que vengas preparado para este gran desafio." & vbCrLf & vbCrLf & "Pero antes que nada, queremos saber como te llamas?."

        lbl_Trivia.Font = New Font(pfc.Families(0), 48, FontStyle.Regular)
        lbl_Game.Font = New Font(pfc.Families(0), 48, FontStyle.Regular)
        lbl_Texto1.Font = New Font(pfc.Families(0), 14, FontStyle.Regular)
        btn_Start.Font = New Font(pfc.Families(0), 12, FontStyle.Regular)



    End Sub 'Texto Introducctorio'

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        Trivia_Game.nombre = Txt_Nombre.Text.ToUpper
        MsgBox("Su nombre se guardó correctamente")
        Me.Hide()
        Frm_Pregunta1.Show()


    End Sub 'Guardar nombre'


End Class
