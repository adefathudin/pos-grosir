Public Class FormProduk

    Private Sub FormProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query = ""
        load_data_produk(query)
        PanelDetailProduk.Visible = False
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

    Private Sub ButtonInputBarang_Click(sender As Object, e As EventArgs) Handles ButtonInputBarang.Click
        ButtonInputBarang.Enabled = False
        PanelDetailProduk.Visible = True
        TextBoxBarcode.Focus()
        ClearTextBoxProduk()
        Cursor = Cursors.WaitCursor
        Dim plu = TextBoxProdukPLU.Text
        Call conecDB()

        'AMBIL PLU TERAKHIR
        Try
            comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT prdcd FROM prodmast order by prdcd desc limit 1", connDB)
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows Then
                rdDB.Read()

                'GENERATE PLU BARU
                TextBoxProdukPLU.Text = rdDB.Item("prdcd") + 1

            End If
            rdDB.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        AmbilRak()
        AmbilKategoriHarga()
        AmbilKategoriProduk()

        Cursor = Cursors.Default
    End Sub

    Private Sub ButtonProdukClose_Click(sender As Object, e As EventArgs) Handles ButtonProdukClose.Click
        PanelDetailProduk.Visible = False
    End Sub

    'MODUL TAMBAH ATAU EDIT BARANG

    Private Sub ButtonProdukSave_Click(sender As Object, e As EventArgs) Handles ButtonProdukSave.Click
        Dim plu = TextBoxProdukPLU.Text
        Dim desc2 = TextBoxProdukDesc.Text
        Dim stok = TextBoxProdukStok.Text
        Dim rak = ComboBoxProdukRak.SelectedIndex.ToString
        Dim acost = TextBoxProdukHargaBeli.Text
        Dim price = TextBoxProdukHargaJual.Text
        Dim price_kat = ""
        Dim brg_aktif = ""
        If ButtonInputBarang.Enabled = False Then
            Dim ask As DialogResult = MessageBox.Show("Simpan data produk?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ask = DialogResult.Yes Then
                Try
                    Call conecDB()
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO (barcd,plu,SET desc2='" + desc2 + "', stok='" + stok + "', rak='" + rak + "',acost='" + acost + "',price='" + price + "',price_kat='" + price_kat + "',brg_aktif='" + brg_aktif + "' where prdcd='" + plu + "'", connDB)
                    comDB.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim query = ""
                    load_data_produk(query)
                    ClearTextBoxProduk()
                    PanelDetailProduk.Visible = False
                    ButtonInputBarang.Enabled = True
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        Else
            Dim result As DialogResult = MessageBox.Show("Simpan perubahan?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    Call conecDB()
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("UPDATE prodmast SET desc2='" + desc2 + "', stok='" + stok + "', rak='" + rak + "',acost='" + acost + "',price='" + price + "',price_kat='" + price_kat + "',brg_aktif='" + brg_aktif + "' where prdcd='" + plu + "'", connDB)
                    comDB.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil dirubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim query = ""
                    load_data_produk(query)
                    ClearTextBoxProduk()
                    PanelDetailProduk.Visible = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If
    End Sub

    Private Sub ButtonProdukKategoriHarga_Click(sender As Object, e As EventArgs) Handles ButtonProdukKategoriHarga.Click
        FormProduk_KategoriHarga.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormProduk_Rak.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormProduk_KategoriProduk.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim plu = TextBoxProdukPLU.Text
        Try
            comDB = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO rel_kategoriharga (kategoriharga_id,plu,harga) values ('" + ComboBoxKategoriHarga.SelectedValue.ToString + "'," + plu + ",'" + TextBoxKategoriHarga_harga.Text + "')", connDB)
            comDB.ExecuteNonQuery()
            AmbilKategoriHargaUsed(plu)
            ClearTextBoxKategoriHarga()
            rdDB.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub AmbilKategoriHargaUsed(plu)
        'AMBIL DATA KATEGORI HARGA

        Call conecDB()
        dt = New DataTable
        If String.IsNullOrEmpty(plu) Then
        Else
            da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT b.id,a.deskripsi,b.harga FROM ref_kategoriharga a join rel_kategoriharga b on a.id=b.kategoriharga_id where b.plu='" + plu + "' ", connDB)
            Try
                comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
                da.Fill(dt)
                DataGridViewKategoriHarga.DataSource = dt
                DataGridViewKategoriHarga.Columns(0).HeaderText = "ID"
                DataGridViewKategoriHarga.Columns(1).HeaderText = "Kategori"
                DataGridViewKategoriHarga.Columns(2).HeaderText = "Harga"
                'Zebra Table
                Me.DataGridViewKategoriHarga.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                Me.DataGridViewKategoriHarga.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Sub AmbilKategoriHarga()
        'AMBIL DATA KATEGORI HARGA

        Call conecDB()
        dt = New DataTable
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM ref_kategoriharga", connDB)

        Try
            comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
            da.Fill(dt)
            ComboBoxKategoriHarga.DataSource = dt
            ComboBoxKategoriHarga.DisplayMember = "nama_kategori"
            ComboBoxKategoriHarga.ValueMember = "id"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub AmbilKategoriProduk()
        'AMBIL DATA KATEGORI HARGA

        Call conecDB()
        dt = New DataTable
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM ref_kategoriproduk", connDB)

        Try
            comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
            da.Fill(dt)
            ComboBoxKategoriProduk.DataSource = dt
            ComboBoxKategoriProduk.DisplayMember = "nama_kategori"
            ComboBoxKategoriProduk.ValueMember = "id"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub AmbilRak()

        'AMBIL DATA RAK
        dt = New DataTable
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM ref_rak", connDB)

        Try
            comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
            da.Fill(dt)
            ComboBoxProdukRak.DataSource = dt
            ComboBoxProdukRak.DisplayMember = "nama_rak"
            ComboBoxProdukRak.ValueMember = "id_rak"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DataGridViewBarang_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewBarang.CellMouseClick
        Dim plu = DataGridViewBarang.Rows(e.RowIndex).Cells(0).Value
        PanelDetailProduk.Visible = True
        Try
            Call conecDB()
            comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT barcd,prdcd,desc2,stok,rak,acost,price,price_kat,brg_aktif FROM prodmast where prdcd='" + plu + "'", connDB)
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows Then
                rdDB.Read()
                TextBoxBarcode.Text = rdDB.Item("barcd")
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
        AmbilKategoriProduk()
        AmbilKategoriHarga()
        AmbilRak()
        AmbilKategoriHargaUsed(plu)
    End Sub

    Private Sub ButtonDeleteKategoriHarga_Click(sender As Object, e As EventArgs) Handles ButtonDeleteKategoriHarga.Click
        Dim plu = TextBoxProdukPLU.Text
        Dim result As DialogResult = MessageBox.Show("Hapus kategori terpilih?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Call conecDB()
                comDB = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM rel_kategoriharga WHERE id='" + TextBoxKategoriHargaID.Text + "'", connDB)
                comDB.ExecuteNonQuery()
                AmbilKategoriHargaUsed(plu)
                ClearTextBoxKategoriHarga()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub DataGridViewKategoriHarga_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewKategoriHarga.CellMouseClick
        Dim id_kategoriharga = DataGridViewKategoriHarga.Rows(e.RowIndex).Cells(0).Value
        TextBoxKategoriHargaID.Text = id_kategoriharga
    End Sub

    Sub ClearTextBoxKategoriHarga()
        TextBoxKategoriHargaID.Clear()
        TextBoxKategoriHarga_harga.Clear()
    End Sub

    Sub ClearTextBoxProduk()
        TextBoxBarcode.Clear()
        TextBoxProdukPLU.Clear()
        TextBoxProdukDesc.Clear()
        TextBoxProdukHargaBeli.Clear()
        TextBoxProdukHargaJual.Clear()
        TextBoxProdukStok.Clear()
        TextBoxKategoriHargaID.Clear()
        TextBoxKategoriHarga_harga.Clear()
    End Sub

    Private Sub TextBoxBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxBarcode.KeyDown
        Select e.KeyCode
            Case Keys.Enter
                TextBoxProdukDesc.Focus()
        End Select
    End Sub

    Private Sub TextBoxProdukDesc_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxProdukDesc.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                TextBoxProdukHargaBeli.Focus()
        End Select
    End Sub

    Private Sub TextBoxProdukHargaBeli_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxProdukHargaBeli.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                TextBoxProdukHargaJual.Focus()
        End Select
    End Sub

    Private Sub TextBoxProdukHargaJual_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxProdukHargaJual.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                TextBoxProdukStok.Focus()
        End Select
    End Sub
End Class