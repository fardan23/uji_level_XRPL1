Imports System.Data.Odbc
Public Class Siswa

    Public Conn As OdbcConnection
    Public dr As OdbcDataReader
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public sql1 As String
    Public sql2 As String

    Sub koneksi()
        sql1 = "Driver={MySQL ODBC 5.1 Driver};server=localhost;uid=root;database=db_uji_level_muhamad_fardan;port=3306"
        Conn = New OdbcConnection(sql1)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

    Sub TampilDGV()
        koneksi()
        da = New OdbcDataAdapter("Select * From siswa", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "siswa")
        Me.DGV.DataSource = (ds.Tables("siswa"))
        Aturkolom()
    End Sub

    Sub Kosongkan()
        tnk.Clear()
        tna.Clear()
        tjk.Text = "~PILIH~"
        ttr.Clear()
        tij.Text = "~PILIH~"
        tnj.Clear()
        tur.Clear()
    End Sub

    Sub Aktifkan()
        tnk.Enabled = True
        tna.Enabled = True
        tjk.Enabled = True
        ttr.Enabled = True
        tij.Enabled = True
        tnj.Enabled = True
        tur.Enabled = True

        bsn.Enabled = True
        bhs.Enabled = True
        buh.Enabled = True
        bbl.Enabled = True
    End Sub

    Sub Nonaktifkan()
        tnk.Enabled = False
        tna.Enabled = False
        tjk.Enabled = False
        ttr.Enabled = False
        tij.Enabled = False
        tnj.Enabled = False
        tur.Enabled = False

        bsn.Enabled = False
        bhs.Enabled = False
        buh.Enabled = False
        bbl.Enabled = False
    End Sub

    Sub Aturkolom()
        DGV.Columns(0).Width = 76
        DGV.Columns(1).Width = 121
        DGV.Columns(2).Width = 90
        DGV.Columns(3).Width = 112
        DGV.Columns(4).Width = 87
        DGV.Columns(5).Width = 172
        DGV.Columns(6).Width = 48
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Kosongkan()
        Nonaktifkan()
        TampilDGV()

        cmd = New OdbcCommand("select * from jurusan", Conn)
        dr = cmd.ExecuteReader()
        Do While dr.Read
            tij.Items.Add(dr.GetString(0))
        Loop
    End Sub

    Private Sub bth_Click(sender As Object, e As EventArgs) Handles bth.Click
        Aktifkan()
    End Sub

    Private Sub bsn_Click(sender As Object, e As EventArgs) Handles bsn.Click
        koneksi()
        sql1 = "Insert Into siswa () Values (" +
            "'" & tnk.Text & "'," +
            "'" & tna.Text & "'," +
            "'" & tjk.Text & "'," +
            "'" & ttr.Text & "'," +
            "'" & tij.Text & "'," +
            "'" & tnj.Text & "'," +
            "'" & tur.Text & "')"
        cmd = New OdbcCommand(sql1, Conn)
        cmd.ExecuteNonQuery()
        Conn.Close()
        DGV.Refresh()

        TampilDGV()
        Nonaktifkan()
        Kosongkan()
    End Sub

    Private Sub bhs_Click(sender As Object, e As EventArgs) Handles bhs.Click
        koneksi()
        sql1 = "delete from siswa where nik='" & tnk.Text & "';"
        cmd = New OdbcCommand(sql1, Conn)
        cmd.ExecuteNonQuery()
        DGV.Refresh()

        TampilDGV()
        Kosongkan()
        Nonaktifkan()
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Dim i As Integer
        i = DGV.CurrentRow.Index
        tnk.Text = DGV.Item(0, i).Value
        tna.Text = DGV.Item(1, i).Value
        tjk.Text = DGV.Item(2, i).Value
        ttr.Text = DGV.Item(3, i).Value
        tij.Text = DGV.Item(4, i).Value
        tnj.Text = DGV.Item(5, i).Value
        tur.Text = DGV.Item(6, i).Value

        Aktifkan()
        tnk.Enabled = False
    End Sub

    Private Sub bbl_Click(sender As Object, e As EventArgs) Handles bbl.Click
        Kosongkan()
    End Sub

    Private Sub btp_Click(sender As Object, e As EventArgs) Handles btp.Click
        Close()
    End Sub

    Private Sub buh_Click(sender As Object, e As EventArgs) Handles buh.Click
        koneksi()
        sql1 = "Update siswa set nama = '" & tna.Text & "', jenis_kelamin = '" & tjk.Text & "', tanggal_lahir = '" & ttr.Text & "', id_jurusan = '" & tij.Text & "', nama_jurusan = '" & tnj.Text & "', umur = '" & tur.Text & "' where nik = '" & tnk.Text & "'"
        cmd = New OdbcCommand(sql1, Conn)
        cmd.ExecuteNonQuery()
        DGV.Refresh()

        TampilDGV()
        Nonaktifkan()
        Kosongkan()
    End Sub

    Private Sub tij_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tij.SelectedIndexChanged
        koneksi()
        cmd = New OdbcCommand("select * from jurusan where id_jurusan = '" & tij.Text & "'", Conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If dr.HasRows Then
            tnj.Text = dr.GetString(1)
        End If

        tnj.Enabled = False
    End Sub

    Private Sub tjk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tjk.SelectedIndexChanged
        tjk.Enabled = False
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class
