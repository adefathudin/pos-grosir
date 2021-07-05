Public Class Form1
    Private Sub PRODUKToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormProduk.MdiParent = Me
        FormProduk.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim waktu As New Date
        lbljam.Text = Format(Now, "HH:mm:ss")
        lbldate.Text = Format(Now, "ddd, dd MMM yyyy")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnkasir_Click_1(sender As Object, e As EventArgs) Handles btnkasir.Click
        FormKasir.MdiParent = Me
        FormProduk.Close()
        FormLaporan.Close()
        FormKasir.Show()
    End Sub

    Private Sub btnproduk_Click(sender As Object, e As EventArgs) Handles btnproduk.Click
        FormProduk.MdiParent = Me
        FormKasir.Close()
        FormLaporan.Close()
        FormProduk.Show()
    End Sub

    Private Sub btnlaporan_Click(sender As Object, e As EventArgs) Handles btnlaporan.Click
        FormLaporan.MdiParent = Me
        FormKasir.Close()
        FormProduk.Close()
        FormLaporan.Show()
    End Sub
End Class
