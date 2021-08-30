Public Class FormProduk_Rak

    Private Sub FormProduk_Rak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearTextBox()
        LoadRak()
    End Sub


    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        ClearTextBox()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim result As DialogResult = MessageBox.Show("Hapus kategori " & TextBoxNama.Text & "?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Call conecDB()
                comDB = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM ref_rak WHERE id_rak='" + TextBoxID.Text + "'", connDB)
                comDB.ExecuteNonQuery()
                LoadRak()
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
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT nama_rak FROM ref_rak WHERE nama_rak='" + TextBoxNama.Text + "'", connDB)
                    rdDB = comDB.ExecuteReader
                    If rdDB.HasRows Then
                        MessageBox.Show("Rak " + TextBoxNama.Text + " sudah ada", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Try
                            rdDB.Close()
                            Dim result As DialogResult = MessageBox.Show("Simpan rak " & TextBoxNama.Text & "?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If result = DialogResult.Yes Then
                                comDB = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO ref_rak (nama_rak,deskripsi) values ('" + TextBoxNama.Text + "','" + TextBoxDesc.Text + "')", connDB)
                                comDB.ExecuteNonQuery()
                                LoadRak()
                                ClearTextBox()
                                rdDB.Close()
                            End If
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End If
                    rdDB.Close()
                Catch ex As Exception
                    MsgBox("PESAN : " + ex.ToString)
                End Try
            Else
                Try
                    Dim result As DialogResult = MessageBox.Show("Rubah nama rak " & TextBoxNama.Text & "?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        Call conecDB()
                        comDB = New MySql.Data.MySqlClient.MySqlCommand("UPDATE ref_rak set nama_rak='" + TextBoxNama.Text + "',deskripsi='" + TextBoxDesc.Text + "' where id_rak='" + TextBoxID.Text + "'", connDB)
                        comDB.ExecuteNonQuery()
                        LoadRak()
                        ClearTextBox()
                    End If
                Catch ex As Exception
                    MsgBox("Form Update : " + ex.ToString)
                End Try
            End If
        End If
    End Sub

    Public Sub ClearTextBox()
        TextBoxID.Clear()
        TextBoxNama.Text = ""
        TextBoxDesc.Text = ""
        TextBoxNama.Focus()
    End Sub

    Public Sub LoadRak()
        Cursor = Cursors.WaitCursor
        Call conecDB()
        dt = New DataTable
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT id_rak,nama_rak,deskripsi FROM ref_rak", connDB)
        Try
            comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
            da.Fill(dt)
            DataGridViewRak.DataSource = dt
            DataGridViewRak.Columns(0).HeaderText = "ID"
            DataGridViewRak.Columns(1).HeaderText = "Nama Rak"
            DataGridViewRak.Columns(2).HeaderText = "Deskripsi"
            'Zebra Table
            Me.DataGridViewRak.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            Me.DataGridViewRak.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            LabelTotalItem.Text = dt.Rows.Count.ToString() + " rak"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub DataGridViewRak_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewRak.CellMouseClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        TextBoxID.Text = DataGridViewRak.Rows(e.RowIndex).Cells(0).Value
        TextBoxNama.Text = DataGridViewRak.Rows(e.RowIndex).Cells(1).Value
        TextBoxDesc.Text = DataGridViewRak.Rows(e.RowIndex).Cells(2).Value
    End Sub
End Class