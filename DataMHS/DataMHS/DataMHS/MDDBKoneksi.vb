Imports MySql.Data.MySqlClient
Module MDDBKoneksi
    'membuat variabel
    Public DBkoneksi As MySqlConnection
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public CMD As MySqlCommand
    Public DR As MySqlDataReader
    Public Hitung As Integer = 1
    Public Kode_Jurusan As String
    Public Kode_Semester As String
    Public Nomor As Integer

    'membuat variabel SQL dan lokasi database
    Public LokasiDatabase As String
    Public SQLInsert As String
    Public SQLUpdate As String
    Public SQLHapus As String
    Public pesan As String
    Public PesanMk1 As String
    Public PesanSmstr As String

    'membuat prosedure publik

    Public Sub KoneksiDB()
        Try
            'Lokasi Database
            LokasiDatabase = "Server=Localhost;Uid=root;Database=dbakamdemik_2024"
            DBkoneksi = New MySqlConnection(LokasiDatabase)
            If DBkoneksi.State = ConnectionState.Closed Then
                DBkoneksi.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal", vbExclamation, "Koneksi Kedatbase Gagagl")
        End Try
    End Sub

    Function Diskonek()
        DBkoneksi.Close()
        Return DBkoneksi
    End Function
End Module