Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class SuratTampilanData
    Private Sub btn_kembali(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
        SuratTampilanAwal.Show()
    End Sub

    Sub tampilData()
        DA = New MySqlDataAdapter("select no_surat, nik, nama, tanggal_buat, keperluan from tb_surat", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "surat")
        Dim table As DataTable = DS.Tables("surat")
        For Each baris As DataRow In table.Rows
            baris(3) = Convert.ToDateTime(baris(3)).ToString("dd-MM-yyyy")
        Next
        DataGridView1.DataSource = table
        DataGridView1.Refresh()
    End Sub
    Sub aturGrid()
        DataGridView1.Columns(0).Width = 40
        DataGridView1.Columns(1).Width = 105
        DataGridView1.Columns(2).Width = 210
        DataGridView1.Columns(3).Width = 65
        DataGridView1.Columns(4).Width = 241
        DataGridView1.Columns(0).HeaderText = "No Surat"
        DataGridView1.Columns(1).HeaderText = "NIK"
        DataGridView1.Columns(2).HeaderText = "Nama"
        DataGridView1.Columns(3).HeaderText = "Tanggal dibuat"
        DataGridView1.Columns(4).HeaderText = "Keperluan"
    End Sub
    Private Sub TampilanData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilData()
        aturGrid()
    End Sub

    

    Private Sub txtNik_TextChanged(sender As Object, e As EventArgs) Handles txtSearchNik.TextChanged
        If txtSearchNik.Text <> Nothing Then
            txtSearchNama.Clear()
            txtSearchNo.Clear()
            CMD = New MySqlCommand("SELECT * FROM tb_surat WHERE nik LIKE @nik", CONN)
            CMD.Parameters.AddWithValue("@nik", "%" & txtSearchNik.Text & "%")
            RD = CMD.ExecuteReader()
            If RD.HasRows Then
                DS.Clear()
                While RD.Read()
                    Dim dsNewRow As DataRow = DS.Tables("surat").NewRow()
                    dsNewRow.Item(0) = RD("no_surat")
                    dsNewRow.Item(1) = RD("nik")
                    dsNewRow.Item(2) = RD("nama")
                    dsNewRow.Item(3) = Convert.ToDateTime(RD("tanggal_buat")).ToString("dd-MM-yyyy")
                    dsNewRow.Item(4) = RD("keperluan")
                    DS.Tables("surat").Rows.Add(dsNewRow)
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
            txtSearchNo.Clear()
            CMD = New MySqlCommand("SELECT * FROM tb_surat WHERE nama LIKE @nama", CONN)
            CMD.Parameters.AddWithValue("@nama", "%" & txtSearchNama.Text & "%")
            RD = CMD.ExecuteReader()
            If RD.HasRows Then
                DS.Clear()
                While RD.Read()
                     Dim dsNewRow As DataRow = DS.Tables("surat").NewRow()
                    dsNewRow.Item(0) = RD("no_surat")
                    dsNewRow.Item(1) = RD("nik")
                    dsNewRow.Item(2) = RD("nama")
                    dsNewRow.Item(3) = Convert.ToDateTime(RD("tanggal_buat")).ToString("dd-MM-yyyy")
                    dsNewRow.Item(4) = RD("keperluan")
                    DS.Tables("surat").Rows.Add(dsNewRow)
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

    Private Sub txtSearchNo_TextChanged(sender As Object, e As EventArgs) Handles txtSearchNo.TextChanged
        If txtSearchNo.Text <> Nothing Then
            txtSearchNik.Clear()
            txtSearchNama.Clear()
            CMD = New MySqlCommand("SELECT * FROM tb_surat WHERE no_surat LIKE @no", CONN)
            CMD.Parameters.AddWithValue("@no", "%" & txtSearchNo.Text & "%")
            RD = CMD.ExecuteReader()
            If RD.HasRows Then
                DS.Clear()
                While RD.Read()
                    Dim dsNewRow As DataRow = DS.Tables("surat").NewRow()
                    dsNewRow.Item(0) = RD("no_surat")
                    dsNewRow.Item(1) = RD("nik")
                    dsNewRow.Item(2) = RD("nama")
                    dsNewRow.Item(3) = Convert.ToDateTime(RD("tanggal_buat")).ToString("dd-MM-yyyy")
                    dsNewRow.Item(4) = RD("keperluan")
                    DS.Tables("surat").Rows.Add(dsNewRow)
                End While
            Else
                MessageBox.Show("Data Tidak Ditemukan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                RD.Close()
                txtSearchNo.Clear()
                txtSearchNo.Focus()
            End If
            RD.Close()
        Else
            tampilData()
        End If
    End Sub
    Dim no_surat As String
    Dim nama As String
    Dim nkk As String
    Dim nik As String
    Dim tanggal_buat As String
    Dim tempat As String
    Dim gender As String
    Dim tanggal_lahir As String
    Dim tempat_lahir As String
    Dim keperluan As String

    Private BG As Image = PA.My.Resources.Resources.surat_konoha

    Public Sub New()
        InitializeComponent()
        Dim paperSize As New PaperSize("Custom", 827, 1169) ' 8.5 x 11 inci
        PrintDocument1.DefaultPageSettings.PaperSize = paperSize
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim data As New List(Of String)()
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim no As String = selectedRow.Cells(0).Value.ToString()
            CMD = New MySqlCommand("Select * from tb_surat where no_surat ='" & no & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                For i As Integer = 0 To RD.FieldCount - 1
                    data.Add(RD(i).ToString)
                Next
            End If
            RD.Close()
            no_surat = data(0)
            nik = data(1)
            nama = data(2)
            tanggal_buat = Convert.ToDateTime(data(3)).ToString("dd-MM-yyyy")
            keperluan = data(4)
            nkk = data(5)
            gender = data(6)
            tanggal_lahir = Convert.ToDateTime(data(7)).ToString("dd-MM-yyyy")
            tempat_lahir = data(8)
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Else
            MessageBox.Show("Tidak ada baris yang dipilih.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim graphics As Graphics = e.Graphics
        Dim pageBounds As Rectangle = e.PageBounds

        If BackgroundImage IsNot Nothing Then
            graphics.DrawImage(BG, pageBounds)
        End If

        Dim font As New Font("Arial", 11.6)
        Dim brush As New SolidBrush(Color.Black)
        Dim text As String = "Ini"

        graphics.DrawString(no_surat, font, brush, 373, 188)
        graphics.DrawString(nama, font, brush, 310, 313)
        graphics.DrawString(nkk, font, brush, 310, 341)
        graphics.DrawString(nik, font, brush, 310, 367)
        graphics.DrawString(tempat_lahir, font, brush, 310, 392)
        graphics.DrawString(tanggal_lahir, font, brush, 310, 416)
        graphics.DrawString(gender, font, brush, 310, 437)
        graphics.DrawString(keperluan, font, brush, 50, 505)
        graphics.DrawString(tanggal_buat, font, brush, 578, 588)
        graphics.DrawString(tanggal_buat, font, brush, 533, 1040)
    End Sub
End Class