Imports MySql.Data.MySqlClient
Public Class Edit_Pelanggan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        xCommand = New MySqlCommand("update member set nama_member = '" + TextBox1.Text + "', tanggal_lahir = '" + DateTimePicker1.Value.ToString("yyyy-MM-dd") + "', alamat = '" + TextBox2.Text + "', phone ='" + TextBox3.Text + "', organisasi = '" + TextBox4.Text + "' where id = " + Label6.Text + " ", xConnection)
        xCommand.ExecuteNonQuery()
        Pelanggan.Enabled = True
        Me.Close()

    End Sub

    Private Sub Edit_Pelanggan_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Pelanggan.Enabled = True
    End Sub

    Private Sub Edit_Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectDatabase()
    End Sub
End Class