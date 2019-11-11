Imports MySql.Data.MySqlClient
Public Class Pelanggan
    Private Sub Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = main_menu
        connectDatabase()
        isi_dgv()
    End Sub

    Private Sub isi_dgv()
        xDataSet.Clear()
        xAdapter = New MySqlDataAdapter("SELECT id, nama_member, tanggal_lahir, alamat, phone, organisasi FROM member ", xConnection)
        xAdapter.Fill(xDataSet, "member")
        xView = xDataSet.Tables("member").DefaultView
        DataGridView1.DataSource = xView
        DataGridView1.Columns.Item(0).HeaderText = "No"
        DataGridView1.Columns.Item(1).HeaderText = "Nama"
        DataGridView1.Columns.Item(2).HeaderText = "Tanggal Lahir"
        DataGridView1.Columns.Item(3).HeaderText = "Alamat"
        DataGridView1.Columns.Item(4).HeaderText = "No Hp"
        DataGridView1.Columns.Item(5).HeaderText = "Organisasi"
        DataGridView1.Columns.Item(0).Width = 50
        DataGridView1.Columns.Item(1).Width = 150
        DataGridView1.Columns.Item(2).Width = 150
        DataGridView1.Columns.Item(3).Width = 200
        DataGridView1.Columns.Item(4).Width = 100
        DataGridView1.Columns.Item(5).Width = 100
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        xCommand = New MySqlCommand("insert into member (nama_member, tanggal_lahir, alamat, phone, organisasi) values ('" + TextBox1.Text + "', '" + DateTimePicker1.Value.ToString("yyyy-MM-dd") + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "')", xConnection)
        xCommand.ExecuteNonQuery()
        isi_dgv()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        xDataSet.Clear()
        xAdapter = New MySqlDataAdapter("SELECT id, nama_member, tanggal_lahir, alamat, phone, organisasi FROM member  " & "WHERE nama_member LIKE '%" & TextBox5.Text & "%'", xConnection)
        xAdapter.Fill(xDataSet, "member")
        xView = xDataSet.Tables("member").DefaultView
        DataGridView1.DataSource = xView
        DataGridView1.Columns.Item(0).HeaderText = "No"
        DataGridView1.Columns.Item(1).HeaderText = "Nama"
        DataGridView1.Columns.Item(2).HeaderText = "Tanggal Lahir"
        DataGridView1.Columns.Item(3).HeaderText = "Alamat"
        DataGridView1.Columns.Item(4).HeaderText = "No Hp"
        DataGridView1.Columns.Item(5).HeaderText = "Organisasi"
        DataGridView1.Columns.Item(0).Width = 50
        DataGridView1.Columns.Item(1).Width = 150
        DataGridView1.Columns.Item(2).Width = 150
        DataGridView1.Columns.Item(3).Width = 200
        DataGridView1.Columns.Item(4).Width = 100
        DataGridView1.Columns.Item(5).Width = 100
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connectDatabase()
        Edit_Pelanggan.Show()
        Me.Enabled = False
        If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then

            Dim edit As String = "SELECT id, nama_member, tanggal_lahir, alamat, phone, organisasi  FROM member where id_member ='" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value & "'"
            xCommand = New MySqlCommand(edit, xConnection)
            xReader = xCommand.ExecuteReader()
            'DataGridView1.Visible = True

            If xReader.Read Then
                Edit_Pelanggan.Label6.Text = xReader.GetValue(0)
                Edit_Pelanggan.TextBox1.Text = xReader.GetValue(1)
                Edit_Pelanggan.DateTimePicker1.Value = xReader.GetValue(2)
                Edit_Pelanggan.TextBox2.Text = xReader.GetValue(3)
                Edit_Pelanggan.TextBox3.Text = xReader.GetValue(4)
                Edit_Pelanggan.TextBox4.Text = xReader.GetValue(5)
            End If

        End If
        xReader.Close()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        xDataSet.Clear()
        xAdapter = New MySqlDataAdapter("SELECT id, nama_member, tanggal_lahir, alamat, phone, organisasi FROM member  " & "WHERE organisasi LIKE '%" & TextBox6.Text & "%'", xConnection)
        xAdapter.Fill(xDataSet, "member")
        xView = xDataSet.Tables("member").DefaultView
        DataGridView1.DataSource = xView
        DataGridView1.Columns.Item(0).HeaderText = "No"
        DataGridView1.Columns.Item(1).HeaderText = "Nama"
        DataGridView1.Columns.Item(2).HeaderText = "Tanggal Lahir"
        DataGridView1.Columns.Item(3).HeaderText = "Alamat"
        DataGridView1.Columns.Item(4).HeaderText = "No Hp"
        DataGridView1.Columns.Item(5).HeaderText = "Organisasi"
        DataGridView1.Columns.Item(0).Width = 50
        DataGridView1.Columns.Item(1).Width = 150
        DataGridView1.Columns.Item(2).Width = 150
        DataGridView1.Columns.Item(3).Width = 200
        DataGridView1.Columns.Item(4).Width = 100
        DataGridView1.Columns.Item(5).Width = 100
    End Sub

    Private Sub Pelanggan_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
        isi_dgv()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        connectDatabase()
        Edit_Pelanggan.Show()
        Me.Enabled = False
        If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then

            Dim edit As String = "SELECT id, nama_member, tanggal_lahir, alamat, phone, organisasi  FROM member where id ='" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value & "'"
            xCommand = New MySqlCommand(edit, xConnection)
            xReader = xCommand.ExecuteReader()
            'DataGridView1.Visible = True

            If xReader.Read Then
                Edit_Pelanggan.Label6.Text = xReader.GetValue(0)
                Edit_Pelanggan.TextBox1.Text = xReader.GetValue(1)
                Edit_Pelanggan.DateTimePicker1.Value = xReader.GetValue(2)
                Edit_Pelanggan.TextBox2.Text = xReader.GetValue(3)
                Edit_Pelanggan.TextBox3.Text = xReader.GetValue(4)
                Edit_Pelanggan.TextBox4.Text = xReader.GetValue(5)
            End If

        End If
        xReader.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class