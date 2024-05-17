Imports MySql.Data.MySqlClient

Public Class TampilanData
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        TampilanTambahData.Show()
    End Sub

    Sub tampilData()
        DA = New MySqlDataAdapter("select nkk, nik, nama, gender, tanggal, tempat from tb_penduduk", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "penduduk")
        Dim table As DataTable = DS.Tables("penduduk")
        For Each baris As DataRow In table.Rows
            baris(4) = Convert.ToDateTime(baris(4)).ToString("dd-MM-yyyy")
        Next
        DataGridView1.DataSource = table
        DataGridView1.Refresh()
    End Sub
    Sub aturGrid()
        DataGridView1.Columns(0).Width = 105
        DataGridView1.Columns(1).Width = 105
        DataGridView1.Columns(2).Width = 210
        DataGridView1.Columns(3).Width = 50
        DataGridView1.Columns(4).Width = 65
        DataGridView1.Columns(5).Width = 126
        DataGridView1.Columns(0).HeaderText = "No KK"
        DataGridView1.Columns(1).HeaderText = "NIK"
        DataGridView1.Columns(2).HeaderText = "Nama"
        DataGridView1.Columns(3).HeaderText = "Jenis Kelamin"
        DataGridView1.Columns(4).HeaderText = "Tanggal Lahir"
        DataGridView1.Columns(5).HeaderText = "Tempat Lahir"
    End Sub
    Private Sub TampilanData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilData()
        aturGrid()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim nkk As String = selectedRow.Cells(0).Value.ToString()
            Dim nik As String = selectedRow.Cells(1).Value.ToString()
            Dim nama As String = selectedRow.Cells(2).Value.ToString()
            Dim gender As String = selectedRow.Cells(3).Value.ToString()
            Dim tanggal As String = selectedRow.Cells(4).Value.ToString()
            Dim tempat As String = selectedRow.Cells(5).Value.ToString()
            Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data penduduk?" & vbCrLf & vbCrLf &
                                                            "No KK               : " & nkk & vbCrLf &
                                                            "NIK                   : " & nik & vbCrLf &
                                                            "Nama               : " & nama & vbCrLf &
                                                            "Jenis Kelamin   : " & gender & vbCrLf &
                                                            "Tanggal Lahir   : " & tanggal & vbCrLf &
                                                            "Tempat Lahir    : " & tempat,
                                                            "Konfirmasi",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning)
            If konfirmasi = DialogResult.Yes Then
                CMD = New MySqlCommand("DELETE FROM `tb_penduduk` WHERE nik ='" & nik & "'", CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data penduduk berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tampilData()
            Else
                MessageBox.Show("hapus data penduduk dibatalkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Tidak ada baris yang dipilih.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim nik As String = selectedRow.Cells(1).Value.ToString()
            CMD = New MySqlCommand("Select no from tb_penduduk where nik ='" & nik & "'", CONN)
            Module1.idxUbah = Convert.ToInt16(CMD.ExecuteScalar)
            Me.Close()
            TampilanUbahData.Show()
        Else
            MessageBox.Show("Tidak ada baris yang dipilih.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtNik_TextChanged(sender As Object, e As EventArgs) Handles txtSearchNik.TextChanged
        If txtSearchNik.Text <> Nothing Then
            txtSearchNama.Clear()
            CMD = New MySqlCommand("SELECT * FROM tb_penduduk WHERE nik LIKE @nik", CONN)
            CMD.Parameters.AddWithValue("@nik", "%" & txtSearchNik.Text & "%")
            RD = CMD.ExecuteReader()
            If RD.HasRows Then
                DS.Clear()
                While RD.Read()
                    Dim dsNewRow As DataRow = DS.Tables("penduduk").NewRow()
                    dsNewRow.Item(0) = RD("nkk")
                    dsNewRow.Item(1) = RD("nik")
                    dsNewRow.Item(2) = RD("nama")
                    dsNewRow.Item(3) = RD("gender")
                    dsNewRow.Item(4) = Convert.ToDateTime(RD("tanggal")).ToString("dd-MM-yyyy")
                    dsNewRow.Item(5) = RD("tempat")
                    DS.Tables("penduduk").Rows.Add(dsNewRow)
                End While
            Else
                MessageBox.Show("Data Tidak Ditemukan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                RD.Close()
                txtSearchNik.Clear()
                txtSearchNik.Focus()
            End If
            RD.Close()
        Else
            tampilData()
        End If
    End Sub


    Private Sub txtSearchNama_TextChanged(sender As Object, e As EventArgs) Handles txtSearchNama.TextChanged
        If txtSearchNama.Text <> Nothing Then
            txtSearchNik.Clear()
            CMD = New MySqlCommand("SELECT * FROM tb_penduduk WHERE nama LIKE @nama", CONN)
            CMD.Parameters.AddWithValue("@nama", "%" & txtSearchNama.Text & "%")
            RD = CMD.ExecuteReader()
            If RD.HasRows Then
                DS.Clear()
                While RD.Read()
                    Dim dsNewRow As DataRow = DS.Tables("penduduk").NewRow()
                    dsNewRow.Item(0) = RD("nkk")
                    dsNewRow.Item(1) = RD("nik")
                    dsNewRow.Item(2) = RD("nama")
                    dsNewRow.Item(3) = RD("gender")
                    dsNewRow.Item(4) = Convert.ToDateTime(RD("tanggal")).ToString("dd-MM-yyyy")
                    dsNewRow.Item(5) = RD("tempat")
                    DS.Tables("penduduk").Rows.Add(dsNewRow)
                End While
            Else
                MessageBox.Show("Data Tidak Ditemukan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                RD.Close()
                txtSearchNama.Clear()
                txtSearchNama.Focus()
            End If
            RD.Close()
        Else
            tampilData()
        End If
    End Sub
End Class