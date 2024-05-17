Imports MySql.Data.MySqlClient

Public Class SuratTampilanBuat

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        SuratTampilanAwal.Show()
    End Sub
    Dim tanggalLahir As DateTime
    Sub data()
        Dim data As New List(Of String)()
        CMD = New MySqlCommand("Select nkk, nik, nama, gender, tanggal, tempat from tb_penduduk where no ='" & idxBuat & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            For i As Integer = 0 To RD.FieldCount - 1
                data.Add(RD(i).ToString())
            Next
        End If
        RD.Close()
        lblNkk.Text = data(0)
        lblNik.Text = data(1)
        lblNama.Text = data(2)
        lblGender.Text = data(3)
        lblTanggal.Text = Convert.ToDateTime(data(4)).ToString("dd-MM-yyyy")
        tanggalLahir = Convert.ToDateTime(data(4))
        lblTempat.Text = data(5)
        lblNo.Text = getLastNoSurat() + 1
    End Sub

    Private Sub TampilanBuatSurat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        data()
    End Sub

    Private Sub btnBuat_Click(sender As Object, e As EventArgs) Handles btnBuat.Click
        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin membuat surat pengantar?" & vbCrLf & vbCrLf &
                                                "No Surat           : " & lblNo.Text & vbCrLf &
                                                "No KK               : " & lblNkk.Text & vbCrLf &
                                                "NIK                   : " & lblNik.Text & vbCrLf &
                                                "Nama               : " & lblNama.Text & vbCrLf &
                                                "Jenis Kelamin  : " & lblGender.Text & vbCrLf &
                                                "Tanggal Lahir  : " & lblTanggal.Text & vbCrLf &
                                                "Tempat Lahir   : " & lblTempat.Text & vbCrLf &
                                                "Keperluan        : " & txtKeperluan.Text, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If konfirmasi = DialogResult.Yes Then
            Dim CMD As New MySqlCommand("INSERT INTO tb_surat VALUES (@no_surat, @nik, @nama, @tanggal, @keperluan,@nkk,@gender,@tanggallahir,@tempat)", CONN)
            CMD.Parameters.AddWithValue("@no_surat", lblNo.Text)
            CMD.Parameters.AddWithValue("@nik", lblNik.Text)
            CMD.Parameters.AddWithValue("@nama", lblNama.Text)
            CMD.Parameters.AddWithValue("@tanggal", DateTime.Now)
            CMD.Parameters.AddWithValue("@keperluan", txtKeperluan.Text)
            CMD.Parameters.AddWithValue("@nkk", lblNkk.Text)
            CMD.Parameters.AddWithValue("@gender", lblGender.Text)
            CMD.Parameters.AddWithValue("@tempat", lblTempat.Text)
            CMD.Parameters.AddWithValue("@tanggallahir", tanggalLahir)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Surat Pengantar berhasil dibuat!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SuratTampilanAwal.Show()
            Me.Close()
        Else
            MessageBox.Show("Pembuatan Surat Pengantar dibatalkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class