Public Class FormCustomer

    Private Sub FormCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query = ""
        DataCustomer(query)
        AmbilKategoriHarga()
        ClearTextBox()
        TextBoxPencarianCustomer.Focus()
    End Sub

    Private Sub TextBoxPencarianCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPencarianCustomer.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim query = TextBoxPencarianCustomer.Text()
            DataCustomer(query)
            TextBoxPencarianCustomer.SelectAll()
        End If
    End Sub

    Public Sub DataCustomer(query)
        Cursor = Cursors.WaitCursor
        Call conecDB()
        dt = New DataTable
        If String.IsNullOrEmpty(query) Then
            da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT id,nama_pelanggan,nomor_hp,kategori_harga FROM customers ORDER BY nama_pelanggan", connDB)
        Else
            da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT id,nama_pelanggan,nomor_hp,kategori_harga FROM customers where nama_pelanggan like '%" + query + "%' or id like '%" + query + "%' or nomor_hp like '%" + query + "%' or alamat like '%" + query + "%' or kategori_harga like '%" + query + "%'", connDB)
        End If
        Try
            comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da) 'untuk bisa edit datagridview
            da.Fill(dt)
            DataGridViewCustomer.DataSource = dt
            DataGridViewCustomer.Columns(0).HeaderText = "ID"
            DataGridViewCustomer.Columns(1).HeaderText = "Nama Pelanggan"
            DataGridViewCustomer.Columns(2).HeaderText = "Nomor HP"
            DataGridViewCustomer.Columns(3).HeaderText = "Kategori Harga"
            'Zebra Table
            Me.DataGridViewCustomer.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            Me.DataGridViewCustomer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            LabelTotalItem.Text = dt.Rows.Count.ToString() + " item"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        PanelDetailCustomer.Visible = True
        TextBoxNamaLengkap.ReadOnly = False
    End Sub

    Private Sub ButtonProdukClose_Click(sender As Object, e As EventArgs)
        PanelDetailCustomer.Visible = False
    End Sub

    'MODUL TAMBAH ATAU EDIT CUSTOMER
    Private Sub ButtonProdukSave_Click(sender As Object, e As EventArgs) Handles ButtonProdukSave.Click
        Dim id = TextBoxIDCustomer.Text
        Dim nama_pelanggan = TextBoxNamaLengkap.Text
        Dim nomor_hp = TextBoxNomorHP.Text
        Dim alamat = TextBoxAlamat.Text
        Dim kategori_harga = ComboBoxKategoriHarga.SelectedValue.ToString
        If String.IsNullOrEmpty(TextBoxIDCustomer.Text) Then
            Dim ask As DialogResult = MessageBox.Show("Simpan data customer?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ask = DialogResult.Yes Then
                Try
                    Call conecDB()
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT nomor_hp FROM customers WHERE nomor_hp='" + nomor_hp + "'", connDB)
                    rdDB = comDB.ExecuteReader
                    If rdDB.HasRows Then
                        rdDB.Read()
                        MessageBox.Show("Nomor hp " + nomor_hp + " sudah pernah didaftarkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    rdDB.Close()
                Catch ex As Exception

                End Try
                Try
                    Call conecDB()
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO customers (nama_pelanggan,nomor_hp,alamat,kategori_harga) values ('" + nama_pelanggan + "','" + nomor_hp + "','" + alamat + "','" + kategori_harga + "')", connDB)
                    comDB.ExecuteNonQuery()
                    MessageBox.Show("Data customer berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim query = ""
                    DataCustomer(query)
                    ClearTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        Else
            Dim result As DialogResult = MessageBox.Show("Edit data customer?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Try
                    Call conecDB()
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("UPDATE customers SET nama_pelanggan='" + nama_pelanggan.Replace("'", "''") + "', nomor_hp='" + nomor_hp + "', alamat='" + alamat.Replace("'", "''") + "',kategori_harga='" + kategori_harga + "' WHERE id='" + id + "'", connDB)
                    comDB.ExecuteNonQuery()
                    MessageBox.Show("Data customer berhasil diedit", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim query = ""
                    DataCustomer(query)
                    ClearTextBox()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If
    End Sub

    Private Sub ButtonProdukKategoriHarga_Click(sender As Object, e As EventArgs)
        FormProduk_KategoriHarga.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        FormProduk_Rak.ShowDialog()
    End Sub

    Sub ClearTextBox()
        TextBoxIDCustomer.Clear()
        TextBoxNamaLengkap.Clear()
        TextBoxNomorHP.Clear()
        TextBoxAlamat.Clear()
    End Sub

    Private Sub DataGridViewCustomer_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewCustomer.CellMouseClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        Dim id As String = DataGridViewCustomer.Rows(e.RowIndex).Cells(0).Value
        Try
            Call conecDB()
            comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM customers where id='" + id + "'", connDB)
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows Then
                rdDB.Read()
                TextBoxIDCustomer.Text = rdDB.Item("id")
                TextBoxIDCustomer.ReadOnly = True
                TextBoxNamaLengkap.Text = rdDB.Item("nama_pelanggan")
                TextBoxNomorHP.Text = rdDB.Item("nomor_hp")
                TextBoxAlamat.Text = rdDB.Item("alamat")
            End If
            rdDB.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearTextBox()
        TextBoxNamaLengkap.Focus()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id = TextBoxIDCustomer.Text
        Dim result As DialogResult = MessageBox.Show("Hapus data customer terpilih?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Call conecDB()
                comDB = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM customers WHERE id='" + id + "'", connDB)
                comDB.ExecuteNonQuery()
                Dim query = ""
                DataCustomer(query)
                ClearTextBox()
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
            ComboBoxKategoriHarga.ValueMember = "nama_kategori"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class