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
        xAdapter = New MySqlDataAdapter("SELECT id, nama_hotel, standart, superior, deluxe, provinsi, kota FROM master_hotel ", xConnection)
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
        xAdapter = New MySqlDataAdapter("SELECT id, nama_hotel, standart, superior, deluxe, provinsi, kota FROM master_hotel WHERE nama_hotel LIKE '%" & TextBox6.Text & "%' ", xConnection)
        xAdapter.Fill(xDataSet, "master_hotel")
        xView = xDataSet.Tables("master_hotel").DefaultView
        DataGridView1.DataSource = xView
       
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        xDataSet.Clear()
        xAdapter = New MySqlDataAdapter("SELECT id, nama_hotel, standart, superior, deluxe, provinsi, kota FROM master_hotel WHERE kota LIKE '%" & TextBox7.Text & "%' ", xConnection)
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

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 0 Or e.ColumnIndex = 1 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 5 Or e.ColumnIndex = 6 Then
            Edit.Visible = True
            If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then
                Dim edit As String = "select nama_hotel, standart, superior, deluxe, provinsi, kota, id FROM master_hotel where id =" & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value & ""
                xCommand = New MySqlCommand(edit, xConnection)

                xReader = xCommand.ExecuteReader()
                If xReader.Read Then
                    TextBox8.Text = xReader.GetValue(0)
                    TextBox10.Text = xReader.GetValue(1)
                    TextBox11.Text = xReader.GetValue(2)
                    TextBox12.Text = xReader.GetValue(3)
                    Dim prov As String
                    prov = xReader.GetValue(4)
                    If prov = "Jawa Timur" Then
                        ComboBox2.SelectedIndex = 0
                    ElseIf prov = "Jawa Barat" Then
                        ComboBox2.SelectedIndex = 1
                    ElseIf prov = "Jawa Tengah" Then
                        ComboBox2.SelectedIndex = 2
                    ElseIf prov = "Daerah Istimewa Yogyakarta" Then
                        ComboBox2.SelectedIndex = 3
                    ElseIf prov = "Banten" Then
                        ComboBox2.SelectedIndex = 4
                    ElseIf prov = "Jakarta" Then
                        ComboBox2.SelectedIndex = 5
                    ElseIf prov = "Bali" Then
                        ComboBox2.SelectedIndex = 6
                    ElseIf prov = "NTT" Then
                        ComboBox2.SelectedIndex = 7
                    ElseIf prov = "NTB" Then
                        ComboBox2.SelectedIndex = 8
                    End If
                    TextBox9.Text = xReader.GetValue(5)
                    Label17.Text = xReader.GetValue(6)
                End If
            End If
            xReader.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            connectDatabase()
            xCommand = New MySqlCommand("update master_hotel set nama_hotel = '" + TextBox8.Text + "', standart = '" + TextBox10.Text + "', superior = '" + TextBox11.Text + "', deluxe = '" + TextBox12.Text + "', kota = '" + TextBox9.Text + "', provinsi = '" + ComboBox2.SelectedItem.ToString + "' where id = " + Label17.Text + " ", xConnection)
            xCommand.ExecuteNonQuery()
            Edit.Visible = False
            isi_dgv()
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan")
        End Try
    End Sub
End Class