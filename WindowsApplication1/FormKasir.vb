Public Class FormKasir

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formcaribarang.Visible = True
        TextBoxCariBarang.Focus()
    End Sub

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        DataTranTemp()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        formcaribarang.Visible = False
        TextBoxBarang.Focus()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                formcaribarang.Visible = True
                TextBoxCariBarang.Focus()
            Case Keys.F5 'save
                '...sintak anda
            Case Keys.F6 'cancel
                '...sintak anda
            Case Keys.F7 'close
                '...sintak anda
        End Select
    End Sub


    Private Sub TextBoxBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxBarang.KeyDown
        If String.IsNullOrEmpty(TextBoxBarang.Text) Then
            TextBoxQTY.Focus()
            Exit Sub
        End If
        Select Case e.KeyCode
            Case Keys.Enter
                Try
                    Dim plu = TextBoxBarang.Text
                    Call conecDB()
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT prdcd,desc2 FROM prodmast where stok > 0 and prdcd='" + plu + "' or barcd='" + plu + "'", connDB)
                    rdDB = comDB.ExecuteReader
                    If rdDB.HasRows Then
                        TextBoxQTY.Focus()
                    Else
                        MessageBox.Show("Stok tidak mencukupi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        TextBoxBarang.SelectAll()
                    End If
                    rdDB.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
        End Select
    End Sub

    Private Sub TextBoxQTY_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxQTY.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If String.IsNullOrEmpty(TextBoxQTY.Text) Then
                    TextBoxIDCustomer.Enabled = True
                    TextBoxBarang.Enabled = False
                    TextBoxQTY.Enabled = False
                    TextBoxIDCustomer.Focus()
                    Exit Sub
                End If
                Try
                    Dim plu_tmp = TextBoxBarang.Text
                    Call conecDB()
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM prodmast where stok > 0 and prdcd='" + plu_tmp + "' or barcd='" + plu_tmp + "'", connDB)
                    rdDB = comDB.ExecuteReader
                    If rdDB.HasRows Then
                        rdDB.Read()
                        Dim plu As String = rdDB.Item("prdcd")
                        Dim desc As String = rdDB.Item("desc2")
                        Dim price As String = rdDB.Item("price")
                        Dim qty = TextBoxQTY.Text
                        Dim harga As String = qty * price
                        Dim station = POSMAIN.LabelStation.Text
                        rdDB.Close()

                        'CEK DATA TRAN EKSIST
                        comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT id,plu FROM tran_temp where plu='" + plu + "' and station='" + station + "'", connDB)
                        rdDB = comDB.ExecuteReader
                        If rdDB.HasRows Then
                            rdDB.Close()
                            comDB = New MySql.Data.MySqlClient.MySqlCommand("UPDATE tran_temp set harga_satuan='" + price + "',qty='" + qty + "',harga='" + harga + "' where plu='" + plu + "' and station='" + station + "'", connDB)
                            comDB.ExecuteNonQuery()
                            rdDB.Close()
                        Else
                            rdDB.Close()
                            comDB = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO tran_temp (plu,deskripsi,harga_satuan,qty,harga,station) values ('" + plu + "','" + desc.Replace("'", "''") + "','" + price + "','" + qty + "','" + harga + "','" + station + "')", connDB)
                            comDB.ExecuteNonQuery()
                            rdDB.Close()
                        End If
                        TextBoxBarang.Focus()
                        ClearTextBox()
                        DataTranTemp()
                    Else
                        MessageBox.Show("Stok tidak mencukupi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        TextBoxBarang.SelectAll()
                    End If
                    rdDB.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
        End Select
    End Sub

    Public Sub DataTranTemp()
        Cursor = Cursors.WaitCursor
        Call conecDB()
        dt = New DataTable
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT plu,deskripsi,kategoriharga_id,harga_satuan,qty,harga FROM tran_temp WHERE station='" + POSMAIN.LabelStation.Text + "'", connDB)
        Try
            comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
            da.Fill(dt)
            DataGridViewTranTemp.DataSource = dt
            DataGridViewTranTemp.Columns(0).HeaderText = "PLU"
            DataGridViewTranTemp.Columns(1).HeaderText = "Deskripsi"
            DataGridViewTranTemp.Columns(2).HeaderText = "Harga Kategori"
            DataGridViewTranTemp.Columns(3).HeaderText = "Harga"
            DataGridViewTranTemp.Columns(4).HeaderText = "QTY"
            DataGridViewTranTemp.Columns(5).HeaderText = "Total"
            'Zebra Table
            Me.DataGridViewTranTemp.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            Me.DataGridViewTranTemp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        TotalBelanja()
        Cursor = Cursors.Default
    End Sub

    Public Sub ClearTextBox()
        TextBoxBarang.Clear()
        TextBoxQTY.Clear()
    End Sub

    Private Sub DataGridViewTranTemp_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewTranTemp.CellMouseClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        TextBoxBarang.Text = DataGridViewTranTemp.Rows(e.RowIndex).Cells(0).Value
        TextBoxQTY.Text = DataGridViewTranTemp.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub ButtonCancelSales_Click(sender As Object, e As EventArgs) Handles ButtonCancelSales.Click
        Dim result As DialogResult = MessageBox.Show("Hapus item transaksi ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Call conecDB()
                comDB = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM tran_temp where plu='" + TextBoxBarang.Text + "' and station='" + POSMAIN.LabelStation.Text + "'", connDB)
                comDB.ExecuteNonQuery()
                TextBoxBarang.Focus()
                ClearTextBox()
                DataTranTemp()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub ButtonScanKembali_Click(sender As Object, e As EventArgs) Handles ButtonScanKembali.Click
        TextBoxIDCustomer.ReadOnly = True
        TextBoxUangTunai.ReadOnly = True
        TextBoxBarang.Enabled = True
        TextBoxQTY.Enabled = True
        TextBoxBarang.Focus()
    End Sub

    Private Sub ButtonLanjutPembayaran_Click(sender As Object, e As EventArgs) Handles ButtonLanjutPembayaran.Click
        TextBoxIDCustomer.Enabled = True
        TextBoxBarang.Enabled = False
        TextBoxQTY.Enabled = False
        TextBoxIDCustomer.Focus()
    End Sub

    Private Sub TextBoxCariBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxCariBarang.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim query = TextBoxCariBarang.Text
                Cursor = Cursors.WaitCursor
                Call conecDB()
                dt = New DataTable
                da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT prdcd,desc2,stok,price FROM prodmast WHERE prdcd like '%" + query + "%' or barcd like '%" + query + "%' or desc2 like '%" + query + "%'", connDB)
                Try
                    comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
                    da.Fill(dt)
                    DataGridViewCariBarang.DataSource = dt
                    DataGridViewCariBarang.Columns(0).HeaderText = "PLU"
                    DataGridViewCariBarang.Columns(1).HeaderText = "Deskripsi"
                    DataGridViewCariBarang.Columns(2).HeaderText = "Stok"
                    DataGridViewCariBarang.Columns(3).HeaderText = "Harga"
                    'Zebra Table
                    Me.DataGridViewCariBarang.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                    Me.DataGridViewCariBarang.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                Cursor = Cursors.Default
        End Select
    End Sub

    Private Sub DataGridViewCariBarang_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewCariBarang.CellMouseClick
        TextBoxBarang.Text = DataGridViewCariBarang.Rows(e.RowIndex).Cells(0).Value
        TextBoxQTY.Focus()

    End Sub

    Private Sub TextBoxIDPelanggan_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBoxIDCustomer.MouseClick
        FormKasir_Customer_Select.ShowDialog()
    End Sub

    Sub TotalBelanja()
        Try
            Call conecDB()
            comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT sum(harga) as total,sum(harga_diskon) as diskon FROM tran_temp WHERE station='" + POSMAIN.LabelStation.Text + "'", connDB)
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows Then
                rdDB.Read()
                TextBoxTotalBelanja.Text = rdDB.Item("total")
                TextBoxDiskon.Text = rdDB.Item("diskon")
                'TextBoxTotal.Text = (Convert.ToDouble(TextBoxTotalBelanja.Text) - Convert.ToDouble(TextBoxDiskon.Text)).ToString("NO")
            End If
            rdDB.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class