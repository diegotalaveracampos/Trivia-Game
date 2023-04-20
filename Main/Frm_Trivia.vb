Imports System.IO
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports System.Reflection

Public Class Frm_trivia
    Private Sub Frm_trivia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim musicbackground As New Media.SoundPlayer(My.Resources.bg_sound)
        My.Computer.Audio.Play(My.Resources.bg_sound, AudioPlayMode.BackgroundLoop)


    End Sub 'Musica de fondo'

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exit_Button.Click
        If MessageBox.Show("Realmente desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        Else
            System.Environment.Exit(1)
        End If

    End Sub 'Boton Salir'

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Minimized_Button.Click
        WindowState = FormWindowState.Minimized

    End Sub 'Boton Minimizar'

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Play_Button.Click

        Me.Hide()
        Frm_Tutorial.Show()


    End Sub 'Boton Play'

    Private Sub lbl_Trivia_Click(sender As Object, e As EventArgs) Handles lbl_Trivia.Click

    End Sub

    Private Sub lbl_Trivia_TextChanged(sender As Object, e As EventArgs) Handles lbl_Trivia.TextChanged
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

        lbl_Trivia.Font = New Font(pfc.Families(0), 48, FontStyle.Regular)
        lbl_Game.Font = New Font(pfc.Families(0), 48, FontStyle.Regular)
    End Sub
End Class
