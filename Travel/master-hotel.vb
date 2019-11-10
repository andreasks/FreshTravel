Imports MySql.Data.MySqlClient
Public Class master_hotel
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            connectDatabase()
            xCommand = New MySqlCommand("insert into daerah (lokasi) values ('" + LCase(TextBox1.Text) + "')", xConnection)
            xCommand.ExecuteNonQuery()
            TextBox1.Text = ""

        Catch ex As Exception
            MsgBox("Maaf Data Telah Tersedia")
            TextBox1.Text = ""
        End Try


    End Sub

    Private Sub master_hotel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = main_menu
        connectDatabase()
        xCommand = New MySqlCommand("select lokasi from daerah  ", xConnection)
        xReader = xCommand.ExecuteReader
        While xReader.Read
            ComboBox1.Items.Add(xReader.GetValue(0))
        End While
        xReader.Close()
        isi_dgv()
    End Sub


    Private Sub isi_dgv()
        xDataSet.Clear()
        xAdapter = New MySqlDataAdapter("SELECT nama_hotel, standart, superior, deluxe, lokasi FROM master_hotel ", xConnection)
        xAdapter.Fill(xDataSet, "master_hotel")
        xView = xDataSet.Tables("master_hotel").DefaultView
        DataGridView1.DataSource = xView
        DataGridView1.Columns.Item(0).HeaderText = "Nama Hotel"
        DataGridView1.Columns.Item(1).HeaderText = "Standart"
        DataGridView1.Columns.Item(2).HeaderText = "Superior"
        DataGridView1.Columns.Item(3).HeaderText = "Deluxe"
        DataGridView1.Columns.Item(4).HeaderText = "Lokasi"

        DataGridView1.Columns.Item(0).Width = 200
        DataGridView1.Columns.Item(1).Width = 150
        DataGridView1.Columns.Item(2).Width = 150
        DataGridView1.Columns.Item(3).Width = 150
        DataGridView1.Columns.Item(4).Width = 100

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            xCommand = New MySqlCommand("insert into master_hotel (lokasi, nama_hotel, standart, superior, deluxe) values ('" + ComboBox1.Text + "', '" + TextBox2.Text + "', " + TextBox3.Text + ", " + TextBox4.Text + ", " + TextBox5.Text + ")", xConnection)
            xCommand.ExecuteNonQuery()
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            isi_dgv()
        Catch ex As Exception
            MsgBox("Ada Data yang Salah / Belum di Isi")
        End Try

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        xDataSet.Clear()
        xAdapter = New MySqlDataAdapter("SELECT nama_hotel, standart, superior, deluxe, lokasi FROM master_hotel WHERE nama_hotel LIKE '%" & TextBox6.Text & "%' ", xConnection)
        xAdapter.Fill(xDataSet, "master_hotel")
        xView = xDataSet.Tables("master_hotel").DefaultView
        DataGridView1.DataSource = xView
        DataGridView1.Columns.Item(0).HeaderText = "Nama Hotel"
        DataGridView1.Columns.Item(1).HeaderText = "Standart"
        DataGridView1.Columns.Item(2).HeaderText = "Superior"
        DataGridView1.Columns.Item(3).HeaderText = "Deluxe"
        DataGridView1.Columns.Item(4).HeaderText = "Lokasi"

        DataGridView1.Columns.Item(0).Width = 200
        DataGridView1.Columns.Item(1).Width = 150
        DataGridView1.Columns.Item(2).Width = 150
        DataGridView1.Columns.Item(3).Width = 150
        DataGridView1.Columns.Item(4).Width = 100
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        xDataSet.Clear()
        xAdapter = New MySqlDataAdapter("SELECT nama_hotel, standart, superior, deluxe, lokasi FROM master_hotel WHERE lokasi LIKE '%" & TextBox7.Text & "%' ", xConnection)
        xAdapter.Fill(xDataSet, "master_hotel")
        xView = xDataSet.Tables("master_hotel").DefaultView
        DataGridView1.DataSource = xView
        DataGridView1.Columns.Item(0).HeaderText = "Nama Hotel"
        DataGridView1.Columns.Item(1).HeaderText = "Standart"
        DataGridView1.Columns.Item(2).HeaderText = "Superior"
        DataGridView1.Columns.Item(3).HeaderText = "Deluxe"
        DataGridView1.Columns.Item(4).HeaderText = "Lokasi"

        DataGridView1.Columns.Item(0).Width = 200
        DataGridView1.Columns.Item(1).Width = 150
        DataGridView1.Columns.Item(2).Width = 150
        DataGridView1.Columns.Item(3).Width = 150
        DataGridView1.Columns.Item(4).Width = 100
    End Sub
End Class