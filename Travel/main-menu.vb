Public Class main_menu
    Private Sub main_menu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Close()
    End Sub

    Private Sub main_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        Pelanggan.Show()
    End Sub

    Private Sub HotelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HotelToolStripMenuItem.Click
        master_hotel.Show()
    End Sub

    Private Sub BusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusToolStripMenuItem.Click
        Transport.Show()
    End Sub
End Class