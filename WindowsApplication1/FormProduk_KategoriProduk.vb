Public Class FormProduk_KategoriProduk

    Private Sub FormProduk_KategoriProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearTextBox()
        LoadKategori()
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        ClearTextBox()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim result As DialogResult = MessageBox.Show("Hapus kategori " & TextBoxNama.Text & "?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Call conecDB()
                comDB = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM ref_kategoriproduk WHERE id='" + TextBoxID.Text + "'", connDB)
                comDB.ExecuteNonQuery()
                LoadKategori()
                ClearTextBox()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If String.IsNullOrEmpty(TextBoxNama.Text) Then
            MessageBox.Show("Harap lengkapi form", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If String.IsNullOrEmpty(TextBoxID.Text) Then
                Try
                    Call conecDB()
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT nama_kategori FROM ref_kategoriproduk WHERE nama_kategori='" + TextBoxNama.Text + "'", connDB)
                    rdDB = comDB.ExecuteReader
                    rdDB.Close()
                    If rdDB.HasRows Then
                        MessageBox.Show("Kategori " + TextBoxNama.Text + " sudah ada", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Dim result As DialogResult = MessageBox.Show("Simpan kategori " & TextBoxNama.Text & "?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If result = DialogResult.Yes Then
                            Try
                                comDB = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO ref_kategoriproduk (nama_kategori,deskripsi) values ('" + TextBoxNama.Text + "','" + TextBoxDesc.Text + "')", connDB)
                                comDB.ExecuteNonQuery()
                                LoadKategori()
                                FormProduk.AmbilKategoriHarga()
                                ClearTextBox()
                                rdDB.Close()
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        End If
                    End If
                    rdDB.Close()
                Catch ex As Exception
                    MsgBox("PESAN : " + ex.ToString)
                End Try
            Else
                Try
                    Dim result As DialogResult = MessageBox.Show("Rubah kategori " & TextBoxNama.Text & "?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        Call conecDB()
                        comDB = New MySql.Data.MySqlClient.MySqlCommand("UPDATE ref_kategoriproduk set nama_kategori='" + TextBoxNama.Text + "',deskripsi='" + TextBoxDesc.Text + "' where id='" + TextBoxID.Text + "'", connDB)
                        comDB.ExecuteNonQuery()
                        LoadKategori()
                        ClearTextBox()
                        rdDB.Close()
                    End If
                Catch ex As Exception
                    MsgBox("Form Update : " + ex.ToString)
                End Try
            End If
        End If
    End Sub

    Public Sub ClearTextBox()
        TextBoxID.Text = ""
        TextBoxNama.Text = ""
        TextBoxDesc.Text = ""
        TextBoxNama.Focus()
    End Sub

    Public Sub LoadKategori()
        Cursor = Cursors.WaitCursor
        Call conecDB()
        dt = New DataTable
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT id,nama_kategori,deskripsi FROM ref_kategoriproduk", connDB)
        Try
            comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
            da.Fill(dt)
            DataGridViewKategoriProduk.DataSource = dt
            DataGridViewKategoriProduk.Columns(0).HeaderText = "ID"
            DataGridViewKategoriProduk.Columns(1).HeaderText = "Nama Kategori"
            DataGridViewKategoriProduk.Columns(2).HeaderText = "Deskripsi"
            'Zebra Table
            Me.DataGridViewKategoriProduk.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            Me.DataGridViewKategoriProduk.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            LabelTotalItem.Text = dt.Rows.Count.ToString() + " item"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub DataGridViewKategoriHarga_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewKategoriProduk.CellMouseClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        TextBoxID.Text = DataGridViewKategoriProduk.Rows(e.RowIndex).Cells(0).Value
        TextBoxNama.Text = DataGridViewKategoriProduk.Rows(e.RowIndex).Cells(1).Value
        TextBoxDesc.Text = DataGridViewKategoriProduk.Rows(e.RowIndex).Cells(2).Value
    End Sub
End Class