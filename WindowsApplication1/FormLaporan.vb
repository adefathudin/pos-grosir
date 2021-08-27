
Imports Excel = Microsoft.Office.Interop.Excel


Public Class FormLaporan

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Enabled = True
        Dim StartDate As String = DateTimePickerStartDate.Value.Date.ToString("yyyy-MM-dd")
        Dim EndDate As String = DateTimePickerEndDate.Value.Date.ToString("yyyy-MM-dd")

        LabelPeriode.Text = DateTimePickerStartDate.Value.Date.ToString("dd/MM/yy") + " s-d " + DateTimePickerEndDate.Value.Date.ToString("dd/MM/yy")

        Cursor = Cursors.WaitCursor
        Call conecDB()

        comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT format(sum(qty),0) as total_item, format(sum(total_harga_beli),0) as total_acost, format(sum(total_harga_kategori),0) as total_penjualan, format(sum(total_harga_kategori-total_harga_beli),0) as total_keuntungan FROM mtran WHERE tanggal BETWEEN '" + StartDate + "' AND '" + EndDate + "'", connDB)
        rdDB = comDB.ExecuteReader
        If rdDB.HasRows Then
            rdDB.Read()
            TextBoxItemTerjual.Text = rdDB.Item("total_item")
            TextBoxTotalHargaBeli.Text = rdDB.Item("total_acost").ToString
            TextBoxTotalPenjualan.Text = rdDB.Item("total_penjualan").ToString
            TextBoxTotalKeuntungan.Text = rdDB.Item("total_keuntungan").ToString
        End If
        rdDB.Close()


        dt = New DataTable
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT tanggal,nomor_struk,desc2,qty,format(total_harga_beli,0),format(total_harga_kategori,0),format((total_harga_kategori-total_harga_beli),0) as keuntungan FROM mtran JOIN prodmast on mtran.plu=prodmast.prdcd WHERE tanggal BETWEEN '" + StartDate + "' AND '" + EndDate + "' ORDER BY tanggal", connDB)
        Try
            comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
            da.Fill(dt)
            DataGridViewLaporan.DataSource = dt
            DataGridViewLaporan.Columns(0).HeaderText = "Tanggal"
            DataGridViewLaporan.Columns(1).HeaderText = "No. Struk"
            DataGridViewLaporan.Columns(2).HeaderText = "Barang"
            DataGridViewLaporan.Columns(3).HeaderText = "QTY"
            DataGridViewLaporan.Columns(4).HeaderText = "Harga Beli"
            DataGridViewLaporan.Columns(5).HeaderText = "Harga Jual"
            DataGridViewLaporan.Columns(6).HeaderText = "Keuntungan"

            DataGridViewLaporan.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridViewLaporan.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridViewLaporan.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            'Zebra Table
            Me.DataGridViewLaporan.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            Me.DataGridViewLaporan.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

            For a = 0 To DataGridViewLaporan.RowCount - 2
                For b = 0 To DataGridViewLaporan.ColumnCount - 1
                    For c As Integer = 1 To DataGridViewLaporan.Columns.Count
                        ExcelWorkSheet.Cells(1, c) = DataGridViewLaporan.Columns(c - 1).HeaderText
                        ExcelWorkSheet.Cells(a + 2, b + 1) = DataGridViewLaporan(b, a).Value.ToString()
                    Next
                Next
            Next

            ExcelWorkSheet.SaveAs("D:\Kasgros\tes.xlsx")
            ExcelWorkBook.Close()
            ExcelApp.Quit()

            releaseObject(ExcelApp)
            releaseObject(ExcelWorkBook)
            releaseObject(ExcelWorkSheet)

            MsgBox("Hasil export tersimpan di D:\DB, dengan nama Test.xlsx")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
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

End Class