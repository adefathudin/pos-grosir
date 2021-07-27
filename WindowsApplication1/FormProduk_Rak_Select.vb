Public Class FormProduk_Rak_Select

    Private Sub FormProduk_Rak_Select_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor
        Call conecDB()
        dt = New DataTable
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT id_rak,nama_rak,deskripsi FROM ref_rak", connDB)
        Try
            comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
            da.Fill(dt)
            DataGridViewRakSelect.DataSource = dt
            DataGridViewRakSelect.Columns(0).HeaderText = "ID"
            DataGridViewRakSelect.Columns(1).HeaderText = "Nama Rak"
            DataGridViewRakSelect.Columns(2).HeaderText = "Deskripsi"
            'Zebra Table
            Me.DataGridViewRakSelect.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            Me.DataGridViewRakSelect.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Cursor = Cursors.Default
    End Sub


    Private Sub ButtonSelectRak_Click(sender As Object, e As EventArgs) Handles ButtonSelectRak.Click
        FormProduk.TextBoxRak.Text = TextBoxSelectRak.Text
        Me.Close()
    End Sub

    Private Sub DataGridViewRakSelect_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewRakSelect.CellMouseClick
        TextBoxSelectRak.Text = DataGridViewRakSelect.Rows(e.RowIndex).Cells(1).Value
    End Sub
End Class