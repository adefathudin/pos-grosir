Public Class FormProduk_Kategori_Select

    Private Sub FormProduk_Kategori_Select_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor
        Call conecDB()
        dt = New DataTable
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT id,nama_kategori,deskripsi FROM ref_kategoriproduk", connDB)
        Try
            comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
            da.Fill(dt)
            DataGridViewKategoriSelect.DataSource = dt
            DataGridViewKategoriSelect.Columns(0).HeaderText = "ID"
            DataGridViewKategoriSelect.Columns(1).HeaderText = "Nama Kategori"
            DataGridViewKategoriSelect.Columns(2).HeaderText = "Deskripsi"
            'Zebra Table
            Me.DataGridViewKategoriSelect.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            Me.DataGridViewKategoriSelect.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Cursor = Cursors.Default
    End Sub


    Private Sub ButtonSelectKategori_Click(sender As Object, e As EventArgs) Handles ButtonSelectKategori.Click
        FormProduk.TextBoxKategoriProduk.Text = TextBoxSelectKategori.Text
        Me.Close()
    End Sub

    Private Sub DataGridViewKategoriSelect_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewKategoriSelect.CellMouseClick
        TextBoxSelectKategori.Text = DataGridViewKategoriSelect.Rows(e.RowIndex).Cells(1).Value
    End Sub
End Class