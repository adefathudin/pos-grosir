Public Class FormSettings

    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadIdentitas()
        LoadDataUsers()
    End Sub


    Public Sub LoadDataUsers()
        Cursor = Cursors.WaitCursor
        Call conecDB()
        dt = New DataTable
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT nik,nama,level FROM users", connDB)
        Try
            comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da) 'untuk bisa edit datagridview
            da.Fill(dt)
            DataGridViewUsers.DataSource = dt
            DataGridViewUsers.Columns(0).HeaderText = "NIK"
            DataGridViewUsers.Columns(1).HeaderText = "Nama"
            DataGridViewUsers.Columns(2).HeaderText = "Level"
            'Zebra Table
            Me.DataGridViewUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            Me.DataGridViewUsers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        PanelDetailCustomer.Visible = True
    End Sub

    Private Sub ButtonProdukClose_Click(sender As Object, e As EventArgs)
        PanelDetailCustomer.Visible = False
    End Sub

    'MODUL TAMBAH ATAU EDIT CUSTOMER
    Private Sub ButtonProdukSave_Click(sender As Object, e As EventArgs) Handles ButtonProdukSave.Click
        Dim nik = TextBoxNIK.Text
        Dim nama_user = TextBoxNamaUser.Text
        Dim pass = TextBoxPassword.Text
        Dim level = ComboBoxLevel.SelectedItem.ToString
        If String.IsNullOrEmpty(TextBoxNIK.Text) Then
            Dim ask As DialogResult = MessageBox.Show("Simpan data customer?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ask = DialogResult.Yes Then
                Try
                    Call conecDB()
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT nik FROM users WHERE nik='" + nik + "'", connDB)
                    rdDB = comDB.ExecuteReader
                    If rdDB.HasRows Then
                        rdDB.Read()
                        MessageBox.Show("NIK " + nik + " sudah pernah didaftarkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    rdDB.Close()
                Catch ex As Exception

                End Try
                Try
                    Call conecDB()
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO users (nik,nama,level,password) values ('" + nik + "','" + nama_user + "','" + level + "','" + pass + "')", connDB)
                    comDB.ExecuteNonQuery()
                    MessageBox.Show("Data customer berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadDataUsers()
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
                    'comDB = New MySql.Data.MySqlClient.MySqlCommand("UPDATE customers SET nama_pelanggan='" + nama_pelanggan.Replace("'", "''") + "', nomor_hp='" + nomor_hp + "', alamat='" + alamat.Replace("'", "''") + "',kategori_harga='" + kategori_harga + "' WHERE id='" + id + "'", connDB)
                    'comDB.ExecuteNonQuery()
                    MessageBox.Show("Data customer berhasil diedit", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim query = ""
                    'DataCustomer(query)
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
        TextBoxNIK.Clear()
        TextBoxPassword.Clear()
        TextBoxNamaUser.Clear()
    End Sub

    Private Sub DataGridViewUsers_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewUsers.CellMouseClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        Dim id As String = DataGridViewUsers.Rows(e.RowIndex).Cells(0).Value
        Try
            Call conecDB()
            comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM users where nik='" + id + "'", connDB)
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows Then
                rdDB.Read()
                TextBoxNIK.Text = rdDB.Item("nik")
                TextBoxNIK.ReadOnly = True
                TextBoxNamaUser.Text = rdDB.Item("nama")
            End If
            rdDB.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nik = TextBoxNIK.Text
        Dim result As DialogResult = MessageBox.Show("Hapus data user terpilih?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Call conecDB()
                comDB = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM users WHERE nik='" + nik + "'", connDB)
                comDB.ExecuteNonQuery()
                LoadDataUsers()
                ClearTextBox()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Sub LoadIdentitas()
        Try
            Call conecDB()
            comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM toko", connDB)
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows Then
                rdDB.Read()
                TextBoxNamaToko.Text = rdDB.Item("nama_toko")
                TextBoxNoTelepon.Text = rdDB.Item("telepon")
                TextBoxAlamat.Text = rdDB.Item("alamat")

                POSMAIN.LabelToko.Text = rdDB.Item("nama_toko")
                POSMAIN.LabelSubToko.Text = rdDB.Item("alamat") + ". Telp. " + rdDB.Item("telepon")

            End If
            rdDB.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click

        Call conecDB()
        Try
            comDB = New MySql.Data.MySqlClient.MySqlCommand("UPDATE toko SET nama_toko='" + TextBoxNamaToko.Text + "',telepon='" + TextBoxNoTelepon.Text + "', alamat='" + TextBoxAlamat.Text + "' WHERE rkey='TKO'", connDB)
            comDB.ExecuteNonQuery()
            MessageBox.Show("Identitas toko berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        LoadIdentitas()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class