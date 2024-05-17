<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TampilanAwal
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
        Me.btnPendataan = New System.Windows.Forms.Button()
        Me.btnSurat = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(779, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SISTEM MANAJEMEN PENDUDUK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 22.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(380, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(418, 54)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RT 24-PALARAN"
        '
        'btnPendataan
        '
        Me.btnPendataan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPendataan.Location = New System.Drawing.Point(303, 282)
        Me.btnPendataan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPendataan.Name = "btnPendataan"
        Me.btnPendataan.Size = New System.Drawing.Size(250, 80)
        Me.btnPendataan.TabIndex = 2
        Me.btnPendataan.Text = "Data Penduduk RT"
        Me.btnPendataan.UseVisualStyleBackColor = True
        '
        'btnSurat
        '
        Me.btnSurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSurat.Location = New System.Drawing.Point(634, 282)
        Me.btnSurat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSurat.Name = "btnSurat"
        Me.btnSurat.Size = New System.Drawing.Size(250, 80)
        Me.btnSurat.TabIndex = 3
        Me.btnSurat.Text = "Surat Pengantar"
        Me.btnSurat.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.Red
        Me.btnKeluar.Location = New System.Drawing.Point(461, 427)
        Me.btnKeluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(250, 80)
        Me.btnKeluar.TabIndex = 4
        Me.btnKeluar.Text = "KELUAR SISTEM"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'TampilanAwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA.My.Resources.Resources.Untitled_design
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnSurat)
        Me.Controls.Add(Me.btnPendataan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "TampilanAwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPendataan As System.Windows.Forms.Button
    Friend WithEvents btnSurat As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button

End Class
