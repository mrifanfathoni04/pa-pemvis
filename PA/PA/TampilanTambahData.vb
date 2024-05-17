Imports MySql.Data.MySqlClient

Public Class TampilanTambahData
    Sub Kosong()
        txtNama.Clear()
        txtNik.Clear()
        txtTempat.Clear()
        txtNkk.Clear()
        cbGender.Text = ""
        txtNik.Focus()
    End Sub

    Private Sub TampilanTambahData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        TampilanAwal.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnData.Click
        Me.Close()
        TampilanData.Show()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
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
            CMD = New MySqlCommand("Select * from tb_penduduk where nik ='" & txtNik.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menambah data penduduk?" & vbCrLf & vbCrLf &
                                                "No KK               : " & txtNkk.Text & vbCrLf &
                                                "NIK                   : " & txtNik.Text & vbCrLf &
                                                "Nama               : " & txtNama.Text & vbCrLf &
                                                "Jenis Kelamin  : " & cbGender.Text & vbCrLf &
                                                "Tanggal Lahir  : " & dtpTanggal.Value.ToString("dd-MM-yyyy") & vbCrLf &
                                                "Tempat Lahir   : " & txtTempat.Text, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If konfirmasi = DialogResult.Yes Then
                    CMD = New MySqlCommand("insert into tb_penduduk( nkk, nik, nama, gender, tanggal, tempat) values('" & txtNkk.Text & "','" & txtNik.Text & "', '" & txtNama.Text & "','" & cbGender.Text & "', '" & dtpTanggal.Value & "', '" & txtTempat.Text & "')", CONN)
                    CMD.ExecuteNonQuery()
                    Kosong()
                    MessageBox.Show("Data Penduduk berhasil ditambahkan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Penambahan data penduduk dibatalkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                RD.Close()
                MessageBox.Show("NIK sudah digunakan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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