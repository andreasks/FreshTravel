Imports MySql.Data.MySqlClient
Module Module1
    Public xConnection As New MySqlConnection
    Public xCommand As New MySqlCommand
    Public xAdapter As New MySqlDataAdapter
    Public xDataSet As New DataSet
    Public xView As DataView
    Public xReader As MySqlDataReader
    Public no_member As String
    Public nama_member As String
    Public alamat_member As String
    Public no_hp_member As String

    Public op As String

    Public checkedGejala As List(Of String) = New List(Of String)

    Public Sub connectDatabase()
        Try
            If xConnection.State = ConnectionState.Open Then
                xConnection.Close()
            End If
            xConnection.ConnectionString = "server=localhost; user id=root; password=; database=travel; Convert Zero Datetime=True; Persist Security Info=True"
            xConnection.Open()
        Catch ex As Exception
            MsgBox("Koneksi Gagal!" + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Koneksi")
        End Try
    End Sub
End Module
