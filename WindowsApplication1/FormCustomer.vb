Public Class FormCustomer

    Private Sub FormCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query = ""
        load_data_produk(query)
        PanelDetailProduk.Visible = False
    End Sub

    Private Sub DataGridViewBarang_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewBarang.CellMouseDoubleClick
        Dim plu = DataGridViewBarang.Rows(e.RowIndex).Cells(0).Value
        PanelDetailProduk.Visible = True
        Try
            Call conecDB()
            comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT prdcd,desc2,stok,rak,acost,price,price_kat,brg_aktif FROM prodmast where prdcd='" + plu + "'", connDB)
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows Then
                rdDB.Read()
                TextBoxProdukPLU.Text = rdDB.Item("prdcd")
                TextBoxProdukPLU.ReadOnly = True
                TextBoxProdukDesc.Text = rdDB.Item("desc2")
                TextBoxProdukStok.Text = rdDB.Item("stok")
                ComboBoxProdukRak.Text = rdDB.Item("rak")
                TextBoxProdukHargaBeli.Text = rdDB.Item("acost")
                TextBoxProdukHargaJual.Text = rdDB.Item("price")
            End If
            rdDB.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TextBoxPencarianProduk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPencarianProduk.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim query = TextBoxPencarianProduk.Text()
            load_data_produk(query)
            TextBoxPencarianProduk.SelectAll()
        End If
    End Sub

    Public Sub load_data_produk(query)
        Cursor = Cursors.WaitCursor
        Call conecDB()
        dt = New DataTable
        If String.IsNullOrEmpty(query) Then
            da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT prdcd,desc2,stok,rak FROM prodmast order by singkatan limit 10", connDB)
        Else
            da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT prdcd,desc2,stok,rak FROM prodmast where barcd like '%" + query + "%' or prdcd like '%" + query + "%' or singkatan like '%" + query + "%' or desc2 like '%" + query + "%' or rak like '%" + query + "%' or price_kat like '%" + query + "%'", connDB)
        End If
        Try
            comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da) 'untuk bisa edit datagridview
            da.Fill(dt)
            DataGridViewBarang.DataSource = dt
            DataGridViewBarang.Columns(0).HeaderText = "PLU"
            DataGridViewBarang.Columns(1).HeaderText = "Deskripsi"
            DataGridViewBarang.Columns(2).HeaderText = "Stok"
            DataGridViewBarang.Columns(3).HeaderText = "Rak"
            'Zebra Table
            Me.DataGridViewBarang.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            Me.DataGridViewBarang.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            LabelTotalItem.Text = dt.Rows.Count.ToString() + " item"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonInputBarang.Click
        PanelDetailProduk.Visible = True
        TextBoxProdukPLU.ReadOnly = False
    End Sub

    Private Sub ButtonProdukClose_Click(sender As Object, e As EventArgs) Handles ButtonProdukClose.Click
        PanelDetailProduk.Visible = False
    End Sub

    'MODUL TAMBAH ATAU EDIT BARANG

    Private Sub ButtonProdukSave_Click(sender As Object, e As EventArgs) Handles ButtonProdukSave.Click
        Dim result As DialogResult = MessageBox.Show("Simpan perubahan?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            
            Dim plu = TextBoxProdukPLU.Text
            Dim desc2 = TextBoxProdukDesc.Text
            Dim stok = TextBoxProdukStok.Text
            Dim rak = ComboBoxProdukRak.SelectedIndex.ToString
            Dim acost = TextBoxProdukHargaBeli.Text
            Dim price = TextBoxProdukHargaJual.Text
            Dim price_kat = ""
            Dim brg_aktif = ""
            Try
                Call conecDB()
                comDB = New MySql.Data.MySqlClient.MySqlCommand("UPDATE prodmast SET desc2='" + desc2 + "', stok='" + stok + "', rak='" + rak + "',acost='" + acost + "',price='" + price + "',price_kat='" + price_kat + "',brg_aktif='" + brg_aktif + "' where prdcd='" + plu + "'", connDB)
                comDB.ExecuteNonQuery()
                MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim query = ""
                load_data_produk(query)
                PanelDetailProduk.Visible = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub ButtonProdukKategoriHarga_Click(sender As Object, e As EventArgs) Handles ButtonProdukKategoriHarga.Click
        FormProduk_KategoriHarga.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormProduk_Rak.ShowDialog()
    End Sub
End Class