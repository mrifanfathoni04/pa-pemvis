<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TampilanTambahData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNkk = New System.Windows.Forms.TextBox()
        Me.txtNik = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtTempat = New System.Windows.Forms.TextBox()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnData = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 22.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(385, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(465, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TAMBAH DATA PENDUDUK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(571, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NO. KK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(596, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NIK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(506, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NAMA LENGKAP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(511, 435)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TEMPAT LAHIR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(500, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TANGGAL LAHIR"
        '
        'txtNkk
        '
        Me.txtNkk.Location = New System.Drawing.Point(416, 147)
        Me.txtNkk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNkk.Name = "txtNkk"
        Me.txtNkk.Size = New System.Drawing.Size(390, 22)
        Me.txtNkk.TabIndex = 7
        '
        'txtNik
        '
        Me.txtNik.Location = New System.Drawing.Point(416, 210)
        Me.txtNik.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNik.Name = "txtNik"
        Me.txtNik.Size = New System.Drawing.Size(390, 22)
        Me.txtNik.TabIndex = 8
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(416, 274)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNama.MaxLength = 255
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(390, 22)
        Me.txtNama.TabIndex = 9
        '
        'txtTempat
        '
        Me.txtTempat.Location = New System.Drawing.Point(416, 470)
        Me.txtTempat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTempat.MaxLength = 255
        Me.txtTempat.Name = "txtTempat"
        Me.txtTempat.Size = New System.Drawing.Size(390, 22)
        Me.txtTempat.TabIndex = 11
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Location = New System.Drawing.Point(416, 403)
        Me.dtpTanggal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpTanggal.MaxDate = New Date(2024, 5, 16, 0, 0, 0, 0)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(390, 22)
        Me.dtpTanggal.TabIndex = 12
        Me.dtpTanggal.Value = New Date(2024, 5, 16, 0, 0, 0, 0)
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnSimpan.Location = New System.Drawing.Point(549, 500)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(149, 60)
        Me.btnSimpan.TabIndex = 13
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(37, 25)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(86, 30)
        Me.btnKembali.TabIndex = 14
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnData
        '
        Me.btnData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnData.Location = New System.Drawing.Point(485, 568)
        Me.btnData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnData.Name = "btnData"
        Me.btnData.Size = New System.Drawing.Size(267, 69)
        Me.btnData.TabIndex = 15
        Me.btnData.Text = "Cek Data Penduduk"
        Me.btnData.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(515, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(202, 29)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "JENIS KELAMIN"
        '
        'cbGender
        '
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Perempuan", "Laki-laki"})
        Me.cbGender.Location = New System.Drawing.Point(416, 336)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(390, 24)
        Me.cbGender.TabIndex = 17
        '
        'TampilanTambahData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA.My.Resources.Resources.Untitled_design
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnData)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.txtTempat)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNik)
        Me.Controls.Add(Me.txtNkk)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "TampilanTambahData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNkk As System.Windows.Forms.TextBox
    Friend WithEvents txtNik As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtTempat As System.Windows.Forms.TextBox
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents btnData As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbGender As System.Windows.Forms.ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
