Public Class TampilanAwal

    Private Sub btn_Pendataan_Click(sender As Object, e As EventArgs) Handles btnPendataan.Click
        Me.Hide()
        TampilanTambahData.Show()
    End Sub

    Private Sub btn_Surat_Click(sender As Object, e As EventArgs) Handles btnSurat.Click
        SuratTampilanAwal.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub TampilanAwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
