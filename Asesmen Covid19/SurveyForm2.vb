Public Class SurveyForm2
    Dim sql, hasilResiko As String
    Public totalCeklis As Integer
    Sub run()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call connection()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sql
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        SurveyForm.nameTB.Text = ""
        SurveyForm.nisTB.Text = ""
        SurveyForm.jenisKelaminCB.Text = ""
    End Sub

    Private Sub BackButton1_Click(sender As Object, e As EventArgs) Handles backButton1.Click
        Me.Hide()
        SurveyForm.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        Panel3.Visible = False
        nextButton.Visible = False
        backButton1.Visible = False
        saveButton.Visible = True
        PictureBox4.Visible = True
    End Sub

    Private Sub BackButton2_Click(sender As Object, e As EventArgs) Handles backButton2.Click
        Panel3.Visible = True
        backButton1.Visible = True
        nextButton.Visible = True
        PictureBox4.Visible = False
    End Sub

    Private Sub SurveyForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
    Sub plusTotal()
        totalCeklis += 1
    End Sub
    Sub minusTotal()
        totalCeklis -= 1
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
        If CheckBox20.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.Checked = True Then
            plusTotal()
        Else
            minusTotal()
        End If
    End Sub
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        If totalCeklis < 8 Then
            hasilResiko = "Resiko Rendah"
        ElseIf totalCeklis < 15 Then
            hasilResiko = "Resiko Sedang"
        ElseIf totalCeklis < 22 Then
            hasilResiko = "Resiko Tinggi"
        End If
        Label2.Text = totalCeklis
        sql = "insert into tb_data(nama,nik,jenis_kelamin,total_ceklis,hasil_resiko)values('" & SurveyForm.nameTB.Text & "','" & SurveyForm.nisTB.Text & "','" & SurveyForm.jenisKelaminCB.Text & "','" & totalCeklis & "','" & hasilResiko & "')"
        Call run()
        connection()
        MenuForm.Show()
        HasilSurveyForm.Show()
        Me.Close()
    End Sub
End Class