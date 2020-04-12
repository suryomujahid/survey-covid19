Public Class HasilSurveyForm
    Private Sub HasilSurveyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        If CInt(SurveyForm2.Label2.Text) < 8 Then
            Label2.ForeColor = Color.Green
            Label2.Text = "Rendah"
            RichTextBox1.Text = "Alhamdulillah, dengan begini artinya Anda telah melakukan banyak antisipasi agar terhindar dari virus"
        ElseIf CInt(SurveyForm2.Label2.Text) < 15 Then
            Label2.ForeColor = Color.YellowGreen
            Label2.Text = "Sedang"
            RichTextBox1.Text = "Kurangi hal-hal yang dapat mengakibatkan penularan covid19 mulai sekarang. Hubungi RS jika mendapat keluhan"
        Else
            Label2.ForeColor = Color.Red
            Label2.Text = "Tinggi"
            RichTextBox1.Text = "Cepat hubungi Rumah Sakit terdekat agar diperiksa dan diberi penanganan untuk virus covid19."
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class