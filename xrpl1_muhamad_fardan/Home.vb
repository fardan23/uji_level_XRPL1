Public Class Home

    Private Sub JurusanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JurusanToolStripMenuItem.Click
        Jurusan.Show()
    End Sub

    Private Sub SiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SiswaToolStripMenuItem.Click
        Siswa.Show()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Format(Now, "dd-MMM-yyyy")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.Enabled = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Jurusan.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Siswa.Show()
    End Sub
End Class