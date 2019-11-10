Imports MySql.Data.MySqlClient
Public Class master_hotel
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Sub master_hotel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = main_menu
        connectDatabase()
        isi_dgv()
    End Sub


    Private Sub isi_dgv()
        xDataSet.Clear()
        xAdapter = New MySqlDataAdapter("SELECT nama_hotel, standart, superior, deluxe, provinsi, kota FROM master_hotel ", xConnection)
        xAdapter.Fill(xDataSet, "master_hotel")
        xView = xDataSet.Tables("master_hotel").DefaultView
        DataGridView1.DataSource = xView
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            'xConnection.Open()
            xCommand = New MySqlCommand("insert into master_hotel (provinsi, kota, nama_hotel, standart, superior, deluxe) values ('" + ComboBox1.SelectedItem.ToString + "','" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "')", xConnection)
            xCommand.ExecuteNonQuery()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            MsgBox("Data Berhasil Diinput")
            isi_dgv()
        Catch ex As Exception
            MsgBox("Ada Data yang Salah / Belum di Isi")
        End Try

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        xDataSet.Clear()
        xAdapter = New MySqlDataAdapter("SELECT nama_hotel, standart, superior, deluxe, provinsi, kota FROM master_hotel WHERE nama_hotel LIKE '%" & TextBox6.Text & "%' ", xConnection)
        xAdapter.Fill(xDataSet, "master_hotel")
        xView = xDataSet.Tables("master_hotel").DefaultView
        DataGridView1.DataSource = xView
       
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        xDataSet.Clear()
        xAdapter = New MySqlDataAdapter("SELECT nama_hotel, standart, superior, deluxe, provinsi, kota FROM master_hotel WHERE kota LIKE '%" & TextBox7.Text & "%' ", xConnection)
        xAdapter.Fill(xDataSet, "master_hotel")
        xView = xDataSet.Tables("master_hotel").DefaultView
        DataGridView1.DataSource = xView
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Or e.ColumnIndex = 1 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7 Or e.ColumnIndex = 8 Or e.ColumnIndex = 9 Then
            Edit.Visible = True
            If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then

                
            End If
            xReader.Close()
        End If
    End Sub
End Class