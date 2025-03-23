Imports System.Speech.Synthesis
Public Class Form1
    Dim AI As SpeechSynthesizer = New SpeechSynthesizer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AI.SelectVoiceByHints(VoiceGender.Male)

        AI.SpeakAsync(TextBox1.Text)

    End Sub
End Class
