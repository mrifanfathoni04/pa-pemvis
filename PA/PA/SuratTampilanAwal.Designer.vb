<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuratTampilanAwal
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
        Me.txtSearchNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearchNik = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuat = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnHistory = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearchNama
        '
        Me.txtSearchNama.Location = New System.Drawing.Point(211, 155)
        Me.txtSearchNama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearchNama.Name = "txtSearchNama"
        Me.txtSearchNama.Size = New System.Drawing.Size(299, 22)
        Me.txtSearchNama.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(255, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 29)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Cari Data NAMA"
        '
        'txtSearchNik
        '
        Me.txtSearchNik.Location = New System.Drawing.Point(682, 155)
        Me.txtSearchNik.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearchNik.Name = "txtSearchNik"
        Me.txtSearchNik.Size = New System.Drawing.Size(299, 22)
        Me.txtSearchNik.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(738, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 29)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Cari Data NIK"
        '
        'btnBuat
        '
        Me.btnBuat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuat.ForeColor = System.Drawing.Color.Black
        Me.btnBuat.Location = New System.Drawing.Point(469, 450)
        Me.btnBuat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuat.Name = "btnBuat"
        Me.btnBuat.Size = New System.Drawing.Size(264, 60)
        Me.btnBuat.TabIndex = 27
        Me.btnBuat.Text = "Buat Surat Pengantar"
        Me.btnBuat.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans Ultra Bold Condensed", 22.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(441, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(345, 51)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "SURAT PENGANTAR"
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(49, 30)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(86, 30)
        Me.btnKembali.TabIndex = 25
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(134, 201)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(938, 238)
        Me.DataGridView1.TabIndex = 24
        '
        'btnHistory
        '
        Me.btnHistory.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.DarkKhaki
        Me.btnHistory.Location = New System.Drawing.Point(390, 523)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(424, 103)
        Me.btnHistory.TabIndex = 33
        Me.btnHistory.Text = "HISTORY SURAT PENGANTAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DAN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CETAK SURAT PENGANTAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'SuratTampilanAwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA.My.Resources.Resources.Untitled_design
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.txtSearchNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSearchNik)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SuratTampilanAwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TampilanDataSurat"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearchNama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSearchNik As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuat As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnHistory As System.Windows.Forms.Button
End Class
