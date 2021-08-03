Public Class FormKasir_Customer_Select

    Private Sub FormKasir_Customer_Select_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor
        Call conecDB()
        dt = New DataTable
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT a.id,nama_pelanggan,nomor_hp,alamat,b.nama_kategori FROM customers a left join ref_kategoriharga b on a.kategori_harga=b.id", connDB)
        Try
            comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
            da.Fill(dt)
            DataGridViewCustomerSelect.DataSource = dt
            DataGridViewCustomerSelect.Columns(0).HeaderText = "ID"
            DataGridViewCustomerSelect.Columns(1).HeaderText = "Nama Pelanggan"
            DataGridViewCustomerSelect.Columns(2).HeaderText = "Nomor HP"
            DataGridViewCustomerSelect.Columns(3).HeaderText = "Alamat"
            DataGridViewCustomerSelect.Columns(4).HeaderText = "Kategori Harga"
            'Zebra Table
            Me.DataGridViewCustomerSelect.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            Me.DataGridViewCustomerSelect.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Cursor = Cursors.Default
    End Sub


    Private Sub ButtonSelectKategori_Click(sender As Object, e As EventArgs) Handles ButtonSelectCustomer.Click
        Dim IDCustomer As String = TextBoxSelectIDCustomer.Text
        FormKasir.LoadDataCustomer(IDCustomer)
        Me.Close()
    End Sub

    Private Sub DataGridViewKategoriSelect_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewCustomerSelect.CellMouseClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        TextBoxSelectNamaCustomer.Text = DataGridViewCustomerSelect.Rows(e.RowIndex).Cells(1).Value
        TextBoxSelectIDCustomer.Text = DataGridViewCustomerSelect.Rows(e.RowIndex).Cells(2).Value
    End Sub
End Class