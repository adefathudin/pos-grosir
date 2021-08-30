
Imports Excel = Microsoft.Office.Interop.Excel


Public Class FormLaporan

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerStartDate.MaxDate = DateTime.Today
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim StartDate As String = DateTimePickerStartDate.Value.Date.ToString("yyyy-MM-dd")
        Dim EndDate As String = DateTimePickerEndDate.Value.Date.ToString("yyyy-MM-dd")

        LabelPeriode.Text = DateTimePickerStartDate.Value.Date.ToString("dd/MM/yy") + " s-d " + DateTimePickerEndDate.Value.Date.ToString("dd/MM/yy")

        Cursor = Cursors.WaitCursor
        Call conecDB()

        If (String.IsNullOrEmpty(TextBoxCustomer.Text)) Then
            comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT format(sum(qty),0) as total_item, format(sum(total_harga_beli),0) as total_acost, format(sum(total_harga_kategori),0) as total_penjualan, format(sum(total_harga_kategori-total_harga_beli),0) as total_keuntungan FROM mtran WHERE tanggal BETWEEN '" + StartDate + "' AND '" + EndDate + "'", connDB)
        Else
            comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT format(sum(qty),0) as total_item, format(sum(total_harga_beli),0) as total_acost, format(sum(total_harga_kategori),0) as total_penjualan, format(sum(total_harga_kategori-total_harga_beli),0) as total_keuntungan FROM mtran WHERE customer_id='" + TextBoxCustomer.Text + "' and tanggal BETWEEN '" + StartDate + "' AND '" + EndDate + "'", connDB)
        End If

        rdDB = comDB.ExecuteReader
        If rdDB.HasRows Then
            rdDB.Read()

            If IsDBNull(rdDB.Item("total_item")) Then
                MessageBox.Show("Tidak ada data penjualan pada periode " + LabelPeriode.Text, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cursor = Cursors.Default
                Button2.Enabled = False
                rdDB.Close()
                Exit Sub
            End If

            TextBoxItemTerjual.Text = rdDB.Item("total_item")
            TextBoxTotalHargaBeli.Text = rdDB.Item("total_acost").ToString
            TextBoxTotalPenjualan.Text = rdDB.Item("total_penjualan").ToString
            TextBoxTotalKeuntungan.Text = rdDB.Item("total_keuntungan").ToString
        End If
        rdDB.Close()

        Button2.Enabled = True

        dt = New DataTable
        If String.IsNullOrEmpty(TextBoxCustomer.Text) Then
            da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT addtime,nomor_struk,nama_pelanggan,desc2,qty,format(total_harga_beli,0),format(total_harga_kategori,0),format((total_harga_kategori-total_harga_beli),0) as keuntungan FROM mtran LEFT JOIN customers ON mtran.customer_id=customers.nomor_hp JOIN prodmast on mtran.plu=prodmast.prdcd WHERE tanggal BETWEEN '" + StartDate + "' AND '" + EndDate + "' ORDER BY tanggal", connDB)
        Else
            da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT addtime,nomor_struk,nama_pelanggan,desc2,qty,format(total_harga_beli,0),format(total_harga_kategori,0),format((total_harga_kategori-total_harga_beli),0) as keuntungan FROM mtran LEFT JOIN customers ON mtran.customer_id=customers.nomor_hp JOIN prodmast on mtran.plu=prodmast.prdcd WHERE customer_id='" + TextBoxCustomer.Text + "' AND tanggal BETWEEN '" + StartDate + "' AND '" + EndDate + "' ORDER BY tanggal", connDB)
        End If
        Try
            comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
            da.Fill(dt)
            DataGridViewLaporan.DataSource = dt
            DataGridViewLaporan.Columns(0).HeaderText = "Tanggal"
            DataGridViewLaporan.Columns(1).HeaderText = "No. Struk"
            DataGridViewLaporan.Columns(2).HeaderText = "Customer"
            DataGridViewLaporan.Columns(3).HeaderText = "Barang"
            DataGridViewLaporan.Columns(4).HeaderText = "QTY"
            DataGridViewLaporan.Columns(5).HeaderText = "Harga Beli"
            DataGridViewLaporan.Columns(6).HeaderText = "Harga Jual"
            DataGridViewLaporan.Columns(7).HeaderText = "Keuntungan"

            DataGridViewLaporan.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridViewLaporan.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridViewLaporan.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            'Zebra Table
            Me.DataGridViewLaporan.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            Me.DataGridViewLaporan.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cursor = Cursors.WaitCursor
        Button2.Enabled = False
        Button2.Text = "mohon tunggu"
        Try
            Dim ExcelApp As Microsoft.Office.Interop.Excel.Application
            Dim ExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim ExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim a As Integer
            Dim b As Integer

            ExcelApp = New Microsoft.Office.Interop.Excel.Application
            ExcelWorkBook = ExcelApp.Workbooks.Add(misValue)
            ExcelWorkSheet = ExcelWorkBook.Sheets("sheet1")

            ExcelWorkSheet.Cells(1, 1) = POSMAIN.LabelToko.Text
            ExcelWorkSheet.Cells(2, 1) = POSMAIN.LabelSubToko.Text
            If String.IsNullOrEmpty(TextBoxCustomer.Text) Then
                ExcelWorkSheet.Cells(4, 1) = "Laporan Penjualan Periode " + LabelPeriode.Text
            Else
                ExcelWorkSheet.Cells(4, 1) = "Laporan Penjualan Customer " + TextBoxNamaCustomer.Text + "(" + TextBoxCustomer.Text + ")" + " Periode " + LabelPeriode.Text
            End If
            ExcelWorkSheet.Cells(5, 1) = "-------------------------------------------------------"

            For a = 0 To DataGridViewLaporan.RowCount - 1
                For b = 0 To DataGridViewLaporan.ColumnCount - 1
                    For c As Integer = 1 To DataGridViewLaporan.Columns.Count
                        ExcelWorkSheet.Cells(6, c) = DataGridViewLaporan.Columns(c - 1).HeaderText
                        ExcelWorkSheet.Cells(a + 7, b + 1) = DataGridViewLaporan(b, a).Value.ToString()
                    Next
                Next
            Next
            Dim FileNameExcel = "D:\Kasgros\Laporan\Laporan_" + DateTimePickerStartDate.Value.Date.ToString("dd_MM_yy") + "_sd_" + DateTimePickerEndDate.Value.Date.ToString("dd_MM_yy") + ".xlsx"
            ExcelWorkSheet.SaveAs(FileNameExcel)
            ExcelWorkBook.Close()
            ExcelApp.Quit()

            releaseObject(ExcelApp)
            releaseObject(ExcelWorkBook)
            releaseObject(ExcelWorkSheet)

            Button2.Enabled = True
            Button2.Text = "Export Excel"
            Dim ask As DialogResult = MessageBox.Show("Data laporan berhasil disimpan. Apakah anda akan membuka file " + FileNameExcel + "?", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ask = Windows.Forms.DialogResult.Yes Then
                Dim BukaFile As New System.Diagnostics.Process
                BukaFile = Process.Start(FileNameExcel)
            End If
        Catch ex As Exception
            MsgBox("error export laporan : " + ex.ToString)
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub DateTimePickerStartDate_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerStartDate.ValueChanged
        DateTimePickerEndDate.MinDate = DateTimePickerStartDate.Value
    End Sub

    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBoxCustomer.MouseClick
        FormKasir_Customer_Select.LabelSource.Text = "FormLaporan"
        FormKasir_Customer_Select.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBoxCustomer.Clear()
        TextBoxNamaCustomer.Clear()
    End Sub
End Class