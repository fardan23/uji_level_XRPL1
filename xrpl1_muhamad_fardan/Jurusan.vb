Imports System.Data.Odbc
Public Class Jurusan

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
        da = New OdbcDataAdapter("Select * From jurusan", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "jurusan")
        Me.DGV.DataSource = (ds.Tables("jurusan"))
        Aturkolom()
    End Sub

    Sub Kosongkan()
        tij.Clear()
        tnj.Text = "~PILIH JURUSAN~"
    End Sub

    Sub Aktifkan()
        tij.Enabled = True
        tnj.Enabled = True

        bsn.Enabled = True
        bhs.Enabled = True
        buh.Enabled = True
        bbl.Enabled = True
    End Sub

    Sub Nonaktifkan()
        tij.Enabled = False
        tnj.Enabled = False

        bsn.Enabled = False
        bhs.Enabled = False
        buh.Enabled = False
        bbl.Enabled = False
    End Sub

    Sub Aturkolom()
        DGV.Columns(0).Width = 96
        DGV.Columns(1).Width = 186
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        Kosongkan()
        Nonaktifkan()
        TampilDGV()
    End Sub

    Private Sub bth_Click(sender As Object, e As EventArgs) Handles bth.Click
        Aktifkan()
    End Sub

    Private Sub bbl_Click(sender As Object, e As EventArgs) Handles bbl.Click
        Kosongkan()
    End Sub

    Private Sub btp_Click(sender As Object, e As EventArgs) Handles btp.Click
        Close()
    End Sub

    Private Sub bsn_Click(sender As Object, e As EventArgs) Handles bsn.Click
        koneksi()
        sql1 = "Insert Into jurusan () Values (" +
            "'" & tij.Text & "'," +
            "'" & tnj.Text & "')"
        cmd = New OdbcCommand(sql1, Conn)
        cmd.ExecuteNonQuery()
        Conn.Close()
        DGV.Refresh()

        TampilDGV()
        Kosongkan()
        Nonaktifkan()
    End Sub

    Private Sub bhs_Click(sender As Object, e As EventArgs) Handles bhs.Click
        koneksi()
        sql1 = "delete from jurusan where id_jurusan='" & tij.Text & "';"
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
        tij.Text = DGV.Item(0, i).Value
        tnj.Text = DGV.Item(1, i).Value

        Aktifkan()
        tij.Enabled = False
    End Sub

    Private Sub buh_Click(sender As Object, e As EventArgs) Handles buh.Click
        koneksi()
        sql1 = "Update jurusan set nama_jurusan = '" & tnj.Text & "' where id_jurusan = '" & tij.Text & "'"
        cmd = New OdbcCommand(sql1, Conn)
        cmd.ExecuteNonQuery()
        DGV.Refresh()

        TampilDGV()
        Nonaktifkan()
        Kosongkan()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        If CBFILTER.SelectedIndex = 0 Then
            da = New OdbcDataAdapter("Select * From jurusan where id_jurusan like '" & txtcari.Text & "%'", Conn)
            ds = New DataSet
            da.Fill(ds)
            DGV.DataSource = ds.Tables(0)
        Else
            da = New OdbcDataAdapter("Select * From jurusan where nama_jurusan like '" & txtcari.Text & "%'", Conn)
            ds = New DataSet
            da.Fill(ds)
            DGV.DataSource = ds.Tables(0)
        End If
    End Sub

    Private Sub tnj_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tnj.SelectedIndexChanged
        tnj.Enabled = False
    End Sub
End Class