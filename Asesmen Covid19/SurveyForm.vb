Public Class SurveyForm
    Private Sub SurveyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If nameTB.Text = "" Or nisTB.Text = "" Then
            MessageBox.Show("Lengkapi terlebih dahulu identitasnya!")
        ElseIf IsNumeric(nisTB.Text) = False Then
            MessageBox.Show("NIS yang dimasukan tidak valid")
        Else
            Me.Hide()
            SurveyForm2.Show()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MenuForm.Show()
    End Sub
End Class