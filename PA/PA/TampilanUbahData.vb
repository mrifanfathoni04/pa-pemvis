Imports MySql.Data.MySqlClient

Public Class TampilanUbahData
    Sub dataLama()
        Dim data As New List(Of String)()
        CMD = New MySqlCommand("Select nkk, nik, nama, gender, tanggal, tempat from tb_penduduk where no ='" & idxUbah & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            For i As Integer = 0 To RD.FieldCount - 1
                data.Add(RD(i).ToString)
            Next
        End If
        RD.Close()
        lblNkk.Text = data(0)
        lblNik.Text = data(1)
        lblNama.Text = data(2)
        lblGender.Text = data(3)
        lblTanggal.Text = Convert.ToDateTime(data(4)).ToString("dd-MM-yyyy")
        lblTempat.Text = data(5)
        txtNkk.Text = data(0)
        txtNik.Text = data(1)
        txtNama.Text = data(2)
        If data(3) = "Perempuan" Then
            cbGender.SelectedIndex = 0
        Else
            cbGender.SelectedIndex = 1
        End If
        dtpTanggal.Value = data(4)
        txtTempat.Text = data(5)



    End Sub

    Private Sub TampilanUbahData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        dataLama()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        TampilanData.Show()
    End Sub
    Sub Kosong()
        txtNama.Clear()
        txtNik.Clear()
        txtTempat.Clear()
        txtNkk.Clear()
        cbGender.Text = ""
        txtNik.Focus()
    End Sub
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If String.IsNullOrWhiteSpace(txtNkk.Text) Then
            MessageBox.Show("Harap masukkan NKK.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNkk.Focus()
        ElseIf txtNkk.Text.Length <> 16 Then
            MessageBox.Show("NKK harus terdiri dari 16 karakter.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNkk.Focus()
        ElseIf String.IsNullOrWhiteSpace(txtNik.Text) Then
            MessageBox.Show("Harap masukkan NIK.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNik.Focus()
        ElseIf txtNik.Text.Length <> 16 Then
            MessageBox.Show("NIK harus terdiri dari 16 karakter.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNik.Focus()
        ElseIf String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Harap masukkan nama.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
        ElseIf (cbGender.Text <> "Perempuan" AndAlso cbGender.Text <> "Laki-laki") Then
            MessageBox.Show("Harap pilih jenis kelamin yang valid.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf String.IsNullOrWhiteSpace(txtTempat.Text) Then
            MessageBox.Show("Harap masukkan tempat lahir.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
        Else
            Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin mengubah data penduduk?" & vbCrLf & vbCrLf &
                                                 "Data Lama" & vbCrLf & vbCrLf &
                                                 "No KK              : " & lblNkk.Text & vbCrLf &
                                                 "NIK                  : " & lblNik.Text & vbCrLf &
                                                 "Nama              : " & lblNama.Text & vbCrLf &
                                                 "Jenis Kelamin : " & lblGender.Text & vbCrLf &
                                                 "Tanggal Lahir : " & lblTanggal.Text & vbCrLf &
                                                 "Tempat Lahir  : " & lblTempat.Text & vbCrLf & vbCrLf &
                                                 "Data Baru" & vbCrLf & vbCrLf &
                                                 "No KK              : " & txtNkk.Text & vbCrLf &
                                                 "NIK                  : " & txtNik.Text & vbCrLf &
                                                 "Nama              : " & txtNama.Text & vbCrLf &
                                                 "Jenis Kelamin : " & cbGender.Text & vbCrLf &
                                                 "Tanggal Lahir : " & dtpTanggal.Value.ToString("dd-MM-yyyy") & vbCrLf &
                                                 "Tempat Lahir  : " & txtTempat.Text, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If konfirmasi = DialogResult.Yes Then
                CMD = New MySqlCommand("UPDATE tb_penduduk SET nkk=@nkk, nik=@nik, nama=@nama, gender=@gender, tanggal=@tanggal, tempat=@tempat WHERE no=@no", CONN)
                CMD.Parameters.AddWithValue("@nkk", txtNkk.Text)
                CMD.Parameters.AddWithValue("@nik", txtNik.Text)
                CMD.Parameters.AddWithValue("@nama", txtNama.Text)
                CMD.Parameters.AddWithValue("@gender", cbGender.Text)
                CMD.Parameters.AddWithValue("@tanggal", dtpTanggal.Value)
                CMD.Parameters.AddWithValue("@tempat", txtTempat.Text)
                CMD.Parameters.AddWithValue("@no", idxUbah)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data penduduk berhasil dirubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                TampilanData.Show()
            Else
                MessageBox.Show("Perubahan data penduduk dibatalkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub txtNkk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNkk.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub
    Private Sub txtNik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNik.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)


        If (e.KeyChar Like "[a-z, A-Z]" OrElse keyascii = Keys.Back OrElse keyascii = Keys.Space OrElse keyascii = Keys.Return OrElse keyascii = Keys.Delete) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub
    Private Sub txtTempat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTempat.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)


        If (e.KeyChar Like "[a-z, A-Z]" OrElse keyascii = Keys.Back OrElse keyascii = Keys.Space OrElse keyascii = Keys.Return OrElse keyascii = Keys.Delete) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub
End Class