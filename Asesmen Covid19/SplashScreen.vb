Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 91 Then
            ProgressBar1.Value += 3
        Else
            Timer1.Stop()
            Me.Hide()
            MenuForm.Show()
        End If
    End Sub
End Class