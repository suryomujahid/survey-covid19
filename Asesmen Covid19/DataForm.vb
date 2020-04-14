Public Class DataForm
    Dim sql As String
    Sub initdata()
        connection()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_data", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_data")
        DataGridView1.DataSource = DS.Tables("tb_data")
        DataGridView1.Enabled = True
        Label9.Text = (From Rows In DataGridView1.Rows.Cast(Of DataGridViewRow)() Where Not Rows.IsNewRow AndAlso Rows.Cells("hasil_resiko").Value.ToString = "Resiko Rendah").Count
        Label10.Text = (From Rows In DataGridView1.Rows.Cast(Of DataGridViewRow)() Where Not Rows.IsNewRow AndAlso Rows.Cells("hasil_resiko").Value.ToString = "Resiko Sedang").Count
        Label11.Text = (From Rows In DataGridView1.Rows.Cast(Of DataGridViewRow)() Where Not Rows.IsNewRow AndAlso Rows.Cells("hasil_resiko").Value.ToString = "Resiko Tinggi").Count
        Dim a, b, c As Integer
        a = Label9.Text
        b = Label10.Text
        c = Label11.Text
        If a > b And a > c Then
            Label16.Text = "Resiko Rendah"
        ElseIf b > a And b > c Then
            Label16.Text = "Resiko Sedang"
        ElseIf c > a And c > b Then
            Label16.Text = "Resiko Tinggi"
        Else
            Label16.Text = "-"
        End If

    End Sub
    Sub run()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call connection()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sql
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        sql = "delete from tb_data where nik='" & TextBox2.Text & "'"
        Call run()
        MessageBox.Show("Data telah dipetrus")
        Call initdata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub DataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initdata()
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        MenuForm.Show()
    End Sub
    Dim nowNIK As String
    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        ComboBox1.Text = DataGridView1.Item(2, i).Value
        nowNIK = DataGridView1.Item(1, i).Value
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        sql = "UPDATE tb_data set nama='" & TextBox1.Text & "',nik='" & TextBox2.Text & "', jenis_kelamin='" & ComboBox1.Text & "' where nik='" & nowNIK & "'"
        Call run()
        MessageBox.Show("Data berhasil diubah")
        Call initdata()
    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange
        connection()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_data where nama like '%" & BunifuTextbox1.text & "%'", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_data")
        DataGridView1.DataSource = DS.Tables("tb_data")
    End Sub
End Class