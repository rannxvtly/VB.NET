Imports MySql.Data.MySqlClient
Public Class FrmData_Mahasiswa
    Sub AktifDataGridMahasiswa()
        'memberikan nama header pada datagrid
        With DataGridMahasiswa
            .EnableHeadersVisualStyles = False
            Try
                'mengatur properties pada data grid header
                .Font = New Font(DataGridMahasiswa.Font, FontStyle.Bold)
                DataGridMahasiswa.DefaultCellStyle.Font = New Font("Arial", 9)
                DataGridMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                DataGridMahasiswa.ColumnHeadersHeight = 35

                '1memberikan nama header NIK
                DataGridMahasiswa.Columns(0).Width = 150
                DataGridMahasiswa.Columns(0).HeaderText = "NIM"
                DataGridMahasiswa.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                '1memberikan nama header NIK
                DataGridMahasiswa.Columns(1).Width = 220
                DataGridMahasiswa.Columns(1).HeaderText = "NAMA"
                DataGridMahasiswa.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                '1memberikan nama header NIK
                DataGridMahasiswa.Columns(2).Width = 150
                DataGridMahasiswa.Columns(2).HeaderText = "JENIS KELAMIN"
                DataGridMahasiswa.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                '1memberikan nama header NIK
                DataGridMahasiswa.Columns(3).Width = 150
                DataGridMahasiswa.Columns(3).HeaderText = "TEMPAT LAHIR"
                DataGridMahasiswa.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                '1memberikan nama header NIK
                DataGridMahasiswa.Columns(4).Width = 150
                DataGridMahasiswa.Columns(4).HeaderText = "TANGGAL LAHIR"
                DataGridMahasiswa.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                '1memberikan nama header NIK
                DataGridMahasiswa.Columns(5).Width = 150
                DataGridMahasiswa.Columns(5).HeaderText = "ALAMAT"
                DataGridMahasiswa.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

                '1memberikan nama header NIK
                DataGridMahasiswa.Columns(6).Width = 150
                DataGridMahasiswa.Columns(6).HeaderText = "STATUS MAHASISWA"
                DataGridMahasiswa.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Catch ex As Exception

            End Try
        End With
    End Sub

    Sub TampilkanDataMahasiswa()
        Call KoneksiDB()
        DA = New MySqlDataAdapter("SELECT
	tbl_mahasiswa.NIK_Mhs, 
	tbl_mahasiswa.Nm_Mhs, 
	tbl_mahasiswa.JK_Mhs, 
	tbl_mahasiswa.tmptlahir_Mhs, 
	tbl_mahasiswa.TglLahir_Mhs, 
	tbl_mahasiswa.Alamat_Mhs, 
	tbl_mahasiswa.Status_Mhs
FROM
	tbl_mahasiswa
  ORDER BY NIK_Mhs ASC", DBkoneksi)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)
        DataGridMahasiswa.DataSource = DS.Tables(0)
        DataGridMahasiswa.ReadOnly = True
        Call AktifDataGridMahasiswa()
    End Sub

    Private Sub FrmData_Mahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB()
        Call TampilkanDataMahasiswa()
    End Sub
End Class
