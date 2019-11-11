Imports MySql.Data.MySqlClient
Public Class Transport

    Private Sub Transport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = main_menu
        connectDatabase()
        isi_dgv()
    End Sub
    Private Sub isi_dgv()
        xDataSet.Clear()
        xAdapter = New MySqlDataAdapter("SELECT id, jenis, harga, ket FROM transport ", xConnection)
        xAdapter.Fill(xDataSet, "transport")
        xView = xDataSet.Tables("transport").DefaultView
        DataGridView1.DataSource = xView
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'xConnection.Open()
            xCommand = New MySqlCommand("insert into transport (jenis, harga, ket) values ('" + ComboBox1.SelectedItem.ToString + "','" + TextBox1.Text + "', '" + TextBox2.Text + "')", xConnection)
            xCommand.ExecuteNonQuery()
            TextBox1.Text = ""
            TextBox2.Text = ""
            MsgBox("Data Berhasil Diinput")
            isi_dgv()
        Catch ex As Exception
            MsgBox("Ada Data yang Salah / Belum di Isi")
        End Try

    End Sub
End Class