<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jurusan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btp = New System.Windows.Forms.Button()
        Me.bbl = New System.Windows.Forms.Button()
        Me.buh = New System.Windows.Forms.Button()
        Me.bhs = New System.Windows.Forms.Button()
        Me.bsn = New System.Windows.Forms.Button()
        Me.bth = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tij = New System.Windows.Forms.TextBox()
        Me.tnj = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBFILTER = New System.Windows.Forms.ComboBox()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btp)
        Me.Panel1.Controls.Add(Me.bbl)
        Me.Panel1.Controls.Add(Me.buh)
        Me.Panel1.Controls.Add(Me.bhs)
        Me.Panel1.Controls.Add(Me.bsn)
        Me.Panel1.Controls.Add(Me.bth)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-23, -9)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(191, 399)
        Me.Panel1.TabIndex = 0
        '
        'btp
        '
        Me.btp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btp.FlatAppearance.BorderSize = 0
        Me.btp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btp.Location = New System.Drawing.Point(55, 341)
        Me.btp.Margin = New System.Windows.Forms.Padding(4)
        Me.btp.Name = "btp"
        Me.btp.Size = New System.Drawing.Size(100, 28)
        Me.btp.TabIndex = 5
        Me.btp.Text = "TUTUP"
        Me.btp.UseVisualStyleBackColor = False
        '
        'bbl
        '
        Me.bbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bbl.FlatAppearance.BorderSize = 0
        Me.bbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bbl.Location = New System.Drawing.Point(55, 305)
        Me.bbl.Margin = New System.Windows.Forms.Padding(4)
        Me.bbl.Name = "bbl"
        Me.bbl.Size = New System.Drawing.Size(100, 28)
        Me.bbl.TabIndex = 5
        Me.bbl.Text = "BATAL"
        Me.bbl.UseVisualStyleBackColor = False
        '
        'buh
        '
        Me.buh.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.buh.FlatAppearance.BorderSize = 0
        Me.buh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buh.Location = New System.Drawing.Point(55, 270)
        Me.buh.Margin = New System.Windows.Forms.Padding(4)
        Me.buh.Name = "buh"
        Me.buh.Size = New System.Drawing.Size(100, 28)
        Me.buh.TabIndex = 5
        Me.buh.Text = "UBAH"
        Me.buh.UseVisualStyleBackColor = False
        '
        'bhs
        '
        Me.bhs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bhs.FlatAppearance.BorderSize = 0
        Me.bhs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bhs.Location = New System.Drawing.Point(55, 234)
        Me.bhs.Margin = New System.Windows.Forms.Padding(4)
        Me.bhs.Name = "bhs"
        Me.bhs.Size = New System.Drawing.Size(100, 28)
        Me.bhs.TabIndex = 3
        Me.bhs.Text = "HAPUS"
        Me.bhs.UseVisualStyleBackColor = False
        '
        'bsn
        '
        Me.bsn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bsn.FlatAppearance.BorderSize = 0
        Me.bsn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bsn.Location = New System.Drawing.Point(55, 198)
        Me.bsn.Margin = New System.Windows.Forms.Padding(4)
        Me.bsn.Name = "bsn"
        Me.bsn.Size = New System.Drawing.Size(100, 28)
        Me.bsn.TabIndex = 2
        Me.bsn.Text = "SIMPAN"
        Me.bsn.UseVisualStyleBackColor = False
        '
        'bth
        '
        Me.bth.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bth.FlatAppearance.BorderSize = 0
        Me.bth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bth.Location = New System.Drawing.Point(55, 162)
        Me.bth.Margin = New System.Windows.Forms.Padding(4)
        Me.bth.Name = "bth"
        Me.bth.Size = New System.Drawing.Size(100, 28)
        Me.bth.TabIndex = 1
        Me.bth.Text = "TAMBAH"
        Me.bth.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID JURUSAN"
        '
        'tij
        '
        Me.tij.Location = New System.Drawing.Point(333, 15)
        Me.tij.Margin = New System.Windows.Forms.Padding(4)
        Me.tij.Name = "tij"
        Me.tij.Size = New System.Drawing.Size(132, 22)
        Me.tij.TabIndex = 2
        '
        'tnj
        '
        Me.tnj.FormattingEnabled = True
        Me.tnj.Items.AddRange(New Object() {"Multimedia", "Teknik Komputer dan Jaringan", "Rekayasa Perangkat Lunak", "IPA", "IPS"})
        Me.tnj.Location = New System.Drawing.Point(333, 62)
        Me.tnj.Margin = New System.Windows.Forms.Padding(4)
        Me.tnj.Name = "tnj"
        Me.tnj.Size = New System.Drawing.Size(197, 24)
        Me.tnj.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Myanmar Text", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(183, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NAMA JURUSAN"
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(188, 105)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(417, 198)
        Me.DGV.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Myanmar Text", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(235, 324)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CARI"
        '
        'CBFILTER
        '
        Me.CBFILTER.FormattingEnabled = True
        Me.CBFILTER.Items.AddRange(New Object() {"Multimedia", "Teknik Komputer dan Jaringan", "Rekayasa Perangkat Lunak"})
        Me.CBFILTER.Location = New System.Drawing.Point(288, 321)
        Me.CBFILTER.Margin = New System.Windows.Forms.Padding(4)
        Me.CBFILTER.Name = "CBFILTER"
        Me.CBFILTER.Size = New System.Drawing.Size(144, 24)
        Me.CBFILTER.TabIndex = 6
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(441, 321)
        Me.txtcari.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(132, 22)
        Me.txtcari.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.xrpl1_muhamad_fardan.My.Resources.Resources.lap_data_master
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(39, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 121)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Jurusan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(633, 374)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBFILTER)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tnj)
        Me.Controls.Add(Me.tij)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Jurusan"
        Me.Text = "Data Jurusan"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tij As System.Windows.Forms.TextBox
    Friend WithEvents btp As System.Windows.Forms.Button
    Friend WithEvents bbl As System.Windows.Forms.Button
    Friend WithEvents buh As System.Windows.Forms.Button
    Friend WithEvents bhs As System.Windows.Forms.Button
    Friend WithEvents bsn As System.Windows.Forms.Button
    Friend WithEvents bth As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tnj As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBFILTER As System.Windows.Forms.ComboBox
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
End Class
