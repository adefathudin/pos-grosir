Imports System.IO
Imports System.Drawing.Printing

Public Class FormKasir

    Public plu, desc, harga_beli, harga_satuan_normal, id_kategoriharga, nama_toko, alamat, no_telepon, nomor_struk As String
    Public station As String = POSMAIN.LabelStation.Text

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formcaribarang.Visible = True
        TextBoxCariBarang.Focus()
    End Sub

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        DataCustTemp()
        DataTranTemp()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        formcaribarang.Visible = False
        TextBoxBarang.Focus()
    End Sub

    Private Sub TextBoxBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxBarang.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If String.IsNullOrEmpty(TextBoxBarang.Text) Then
                    TextBoxQTY.Focus()
                    Exit Sub
                End If
                Try
                    Dim plu = TextBoxBarang.Text
                    Call conecDB()
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT prdcd FROM prodmast where prdcd='" + TextBoxBarang.Text + "' or barcd='" + TextBoxBarang.Text + "'", connDB)
                    rdDB = comDB.ExecuteReader
                    If rdDB.HasRows Then
                        rdDB.Read()
                        TextBoxBarang.Text = rdDB("prdcd")
                        TextBoxQTY.Focus()
                    Else
                        MessageBox.Show("Stok tidak mencukupi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        TextBoxBarang.SelectAll()
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                rdDB.Close()
        End Select
    End Sub

    Public Sub TextBoxQTY_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxQTY.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If String.IsNullOrEmpty(TextBoxQTY.Text) Then
                    TextBoxNamaCustomer.Enabled = True
                    TextBoxBarang.Enabled = False
                    TextBoxQTY.Enabled = False
                    TextBoxNamaCustomer.Focus()
                    Exit Sub
                End If

                If (TextBoxQTY.Text <= 0) Then
                    MessageBox.Show("Jumlah barang tidak valid", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TextBoxQTY.SelectAll()
                    TextBoxQTY.Focus()
                    rdDB.Close()
                    Exit Sub
                End If

                Dim plu_tmp = TextBoxBarang.Text
                Dim qty As String = TextBoxQTY.Text
                Try
                    Call conecDB()
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM prodmast where stok >= '" + TextBoxQTY.Text + "'  and prdcd='" + plu_tmp + "'", connDB)
                    rdDB = comDB.ExecuteReader
                    If rdDB.HasRows Then
                        rdDB.Read()
                        plu = rdDB.Item("prdcd")
                        desc = rdDB.Item("desc2")
                        harga_satuan_normal = rdDB.Item("price")
                        harga_beli = rdDB.Item("acost")
                        rdDB.Close()
                    Else
                        MessageBox.Show("Stok tidak mencukupi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        TextBoxQTY.SelectAll()
                        TextBoxQTY.Focus()
                        rdDB.Close()
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox("Ambil data prodmast: " + ex.ToString)
                End Try
                rdDB.Close()

                Dim tran_temp As Boolean
                Dim tran_kat As Boolean
                Dim total_harga_normal As String = harga_satuan_normal * qty
                Dim total_harga_beli As String = harga_beli * qty

                Try
                    'CEK DATA TRAN EKSIST
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT id,plu FROM tran_temp where plu='" + plu + "' and station='" + station + "'", connDB)
                    rdDB = comDB.ExecuteReader
                    If rdDB.HasRows Then
                        tran_temp = True
                    Else
                        tran_temp = False
                    End If
                Catch ex As Exception
                    MsgBox("Ambil data prodmast: " + ex.ToString)
                End Try
                rdDB.Close()

                If tran_temp = True Then
                    If String.IsNullOrEmpty(TextBoxIDCustomer.Text) Then
                        comDB = New MySql.Data.MySqlClient.MySqlCommand("UPDATE tran_temp set harga_beli_satuan='" + harga_beli + "',total_harga_beli='" + total_harga_beli + "',harga_satuan_normal='" + harga_satuan_normal + "',harga_kategori='" + harga_satuan_normal + "',total_harga_kategori='" + total_harga_normal + "',qty='" + qty + "',total_harga_normal='" + total_harga_normal + "' where plu='" + plu + "' and station='" + station + "'", connDB)
                        comDB.ExecuteNonQuery()
                    Else
                        Try
                            comDB = New MySql.Data.MySqlClient.MySqlCommand("select harga from rel_kategoriharga a inner join customers b on a.kategoriharga_id=b.kategori_harga inner join prodmast c on a.plu=c.prdcd where b.nomor_hp='" + TextBoxIDCustomer.Text + "' and a.plu=" + plu + " and c.stok >= '" + TextBoxQTY.Text + "'", connDB)
                            rdDB = comDB.ExecuteReader
                            If rdDB.HasRows Then
                                rdDB.Read()
                                Dim harga_kategori As String = rdDB.Item("harga")
                                Dim total_harga_kategori As String = qty * harga_kategori
                                comDB = New MySql.Data.MySqlClient.MySqlCommand("UPDATE tran_temp set harga_kategori='" + harga_kategori + "',qty='" + qty + "',total_harga_kategori='" + total_harga_kategori + "' where plu='" + plu + "' and station='" + station + "'", connDB)
                                comDB.ExecuteNonQuery()
                                MsgBox(harga_kategori)
                            Else
                                tran_kat = True
                            End If
                        Catch ex As Exception
                            MsgBox("update menggunakan kategori harga: " + ex.ToString)
                        End Try
                        rdDB.Close()
                    End If
                ElseIf tran_temp = False Then
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO tran_temp (plu,deskripsi,harga_beli_satuan,total_harga_beli,harga_satuan_normal,harga_kategori,qty,total_harga_normal,total_harga_kategori,station) values ('" + plu + "','" + desc.Replace("'", "''") + "','" + harga_beli + "','" + total_harga_beli + "','" + harga_satuan_normal + "','" + harga_satuan_normal + "','" + qty + "','" + total_harga_normal + "','" + total_harga_normal + "','" + station + "')", connDB)
                    comDB.ExecuteNonQuery()
                Else
                End If

                If tran_kat = True Then
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("UPDATE tran_temp set tran_temp set harga_beli_satuan='" + harga_beli + "',total_harga_beli='" + total_harga_beli + "',harga_satuan_normal='" + harga_satuan_normal + "',harga_kategori='" + harga_satuan_normal + "',total_harga_kategori='" + total_harga_normal + "',qty='" + qty + "',total_harga_normal='" + total_harga_normal + "' where plu='" + plu + "' and station='" + station + "'", connDB)
                    comDB.ExecuteNonQuery()
                End If

                TextBoxBarang.Focus()
                ClearTextBoxTran()
                DataTranTemp()
        End Select
    End Sub

    Public Sub DataTranTemp()
        Cursor = Cursors.WaitCursor
        Call conecDB()
        dt = New DataTable
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT plu,deskripsi,harga_satuan_normal,harga_kategori,qty,total_harga_kategori,total_harga_normal,harga_beli_satuan,total_harga_beli FROM tran_temp WHERE station='" + POSMAIN.LabelStation.Text + "'", connDB)
        Try
            comBuilderDB = New MySql.Data.MySqlClient.MySqlCommandBuilder(da)
            da.Fill(dt)
            DataGridViewTranTemp.DataSource = dt
            DataGridViewTranTemp.Columns(0).HeaderText = "PLU"
            DataGridViewTranTemp.Columns(1).HeaderText = "Deskripsi"
            DataGridViewTranTemp.Columns(2).HeaderText = "Harga"
            DataGridViewTranTemp.Columns(3).HeaderText = "Harga Kategori"
            DataGridViewTranTemp.Columns(4).HeaderText = "QTY"
            DataGridViewTranTemp.Columns(5).HeaderText = "Total"

            Me.DataGridViewTranTemp.Columns(6).Visible = False
            Me.DataGridViewTranTemp.Columns(7).Visible = False
            Me.DataGridViewTranTemp.Columns(8).Visible = False


            DataGridViewTranTemp.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridViewTranTemp.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridViewTranTemp.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            'Zebra Table
            Me.DataGridViewTranTemp.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            Me.DataGridViewTranTemp.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        TotalBelanja()
        Cursor = Cursors.Default
    End Sub

    Public Sub DataCustTemp()
        Try
            Call conecDB()
            'comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT nomor_hp,nama_pelanggan,b.nama_kategori as nama_kategori FROM cust_temp a left join ref_kategoriharga b on a.kategori_harga=b.id WHERE a.station='" + station + "'", connDB)
            comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM cust_temp WHERE station='" + station + "'", connDB)
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows Then
                rdDB.Read()
                TextBoxIDCustomer.Text = rdDB.Item("nomor_hp")
                TextBoxNamaCustomer.Text = rdDB.Item("nama_pelanggan")
                TextBoxKategoriHarga.Text = rdDB.Item("kategori_harga")
                'TextBoxTotal.Text = (Convert.ToDouble(TextBoxTotalBelanja.Text) - Convert.ToDouble(TextBoxDiskon.Text)).ToString("NO")
            Else
                ClearTextBoxTran()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        rdDB.Close()
    End Sub

    Sub ClearTextBoxTran()
        TextBoxBarang.Clear()
        TextBoxQTY.Clear()
    End Sub

    Public Sub ClearTextBox()
        TextBoxIDCustomer.Clear()
        TextBoxNamaCustomer.Clear()
        TextBoxKategoriHarga.Clear()
        TextBoxNamaCustomer.Text = "cari..."
    End Sub

    Private Sub DataGridViewTranTemp_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewTranTemp.CellMouseClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        TextBoxBarang.Text = DataGridViewTranTemp.Rows(e.RowIndex).Cells(0).Value
        TextBoxQTY.Text = DataGridViewTranTemp.Rows(e.RowIndex).Cells(4).Value
        TextBoxQTY.SelectAll()
        TextBoxQTY.Focus()
    End Sub

    Private Sub ButtonCancelSales_Click(sender As Object, e As EventArgs) Handles ButtonCancelSales.Click
        Dim result As DialogResult = MessageBox.Show("Hapus item transaksi ini?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Call conecDB()
                comDB = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM tran_temp where plu='" + TextBoxBarang.Text + "' and station='" + POSMAIN.LabelStation.Text + "'", connDB)
                comDB.ExecuteNonQuery()
                TextBoxBarang.Focus()
                ClearTextBoxTran()
                DataTranTemp()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub ButtonScanKembali_Click(sender As Object, e As EventArgs) Handles ButtonScanKembali.Click
        TextBoxNamaCustomer.ReadOnly = True
        TextBoxUangTunai.ReadOnly = True
        TextBoxBarang.Enabled = True
        TextBoxQTY.Enabled = True
        TextBoxBarang.Focus()
    End Sub

    Private Sub ButtonLanjutPembayaran_Click(sender As Object, e As EventArgs) Handles ButtonLanjutPembayaran.Click
        TextBoxNamaCustomer.Enabled = True
        TextBoxBarang.Enabled = False
        TextBoxQTY.Enabled = False
        TextBoxUangTunai.Enabled = True
        TextBoxUangTunai.Text = ""
        TextBoxNamaCustomer.Focus()
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

    Private Sub TextBoxIDPelanggan_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBoxNamaCustomer.MouseClick
        FormKasir_Customer_Select.ShowDialog()
    End Sub

    Sub TotalBelanja()
        Try
            Call conecDB()
            comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT sum(total_harga_normal) as total,sum((total_harga_normal-total_harga_kategori)) as diskon FROM tran_temp WHERE station='" + station + "'", connDB)
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows Then
                rdDB.Read()

                If String.IsNullOrEmpty(rdDB.Item("total").ToString) Then
                    TextBoxTotalBelanja.Text = "0"
                    TextBoxDiskon.Text = "0"
                Else
                    Dim TotalBelanja As Integer = rdDB.Item("total")
                    Dim TotalDiskon As Integer = rdDB.Item("diskon")
                    TextBoxTotalBelanja.Text = TotalBelanja.ToString("N0")
                    TextBoxDiskon.Text = TotalDiskon.ToString("N0")
                End If

                Dim total As Integer
                If String.Equals(TextBoxTotalBelanja.Text, TextBoxDiskon.Text) Then
                    TextBoxDiskon.Text = "0"
                    total = TextBoxTotalBelanja.Text
                Else
                    total = TextBoxTotalBelanja.Text - TextBoxDiskon.Text
                End If
                TextBoxTotal.Text = total.ToString("N0")
                'TextBoxTotal.Text = (Convert.ToDouble(TextBoxTotalBelanja.Text) - Convert.ToDouble(TextBoxDiskon.Text)).ToString("NO")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        rdDB.Close()
    End Sub

    Sub LoadDataCustomer(IDCustomer)
        Try
            Call conecDB()
            comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT nomor_hp,nama_pelanggan,b.nama_kategori as nama_kategori,a.kategori_harga as kategoriharga_id FROM customers a left join ref_kategoriharga b on a.kategori_harga=b.id where nomor_hp='" + IDCustomer + "'", connDB)
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows Then
                rdDB.Read()
                TextBoxIDCustomer.Text = rdDB.Item("nomor_hp")
                TextBoxNamaCustomer.Text = rdDB.Item("nama_pelanggan")
                TextBoxKategoriHarga.Text = rdDB.Item("nama_kategori")
                id_kategoriharga = rdDB.Item("kategoriharga_id")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ButtonCheckCustomer.Enabled = True
        ButtonHapusCustomer.Enabled = True
        rdDB.Close()
    End Sub

    Private Sub ButtonCheckCustomer_Click(sender As Object, e As EventArgs) Handles ButtonCheckCustomer.Click
        Call conecDB()

        comDB = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM cust_temp WHERE station='" + station + "'", connDB)
        comDB.ExecuteNonQuery()

        comDB = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO cust_temp (station,updtime) values ('" + station + "', now())", connDB)
        comDB.ExecuteNonQuery()

        comDB = New MySql.Data.MySqlClient.MySqlCommand("UPDATE cust_temp set nama_pelanggan='" + TextBoxNamaCustomer.Text + "',nomor_hp='" + TextBoxIDCustomer.Text + "',kategoriharga_id=" + id_kategoriharga + ",kategori_harga='" + TextBoxKategoriHarga.Text + "',updtime=now() WHERE station='" + station + "'", connDB)
        comDB.ExecuteNonQuery()

        For Each row As DataGridViewRow In DataGridViewTranTemp.Rows
            If Not row.IsNewRow Then
                Try
                    plu = row.Cells(0).Value.ToString
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("UPDATE tran_temp SET harga_kategori=(SELECT CASE WHEN NOT EXISTS (select a.harga as harga from rel_kategoriharga a inner join cust_temp b on a.kategoriharga_id=b.kategoriharga_id WHERE plu='" + plu + "' AND b.station='" + station + "') THEN  (select price from prodmast where prdcd='" + plu + "') ELSE (select a.harga as harga from rel_kategoriharga a inner join cust_temp b on a.kategoriharga_id=b.kategoriharga_id WHERE plu='" + plu + "' AND b.station='" + station + "') END), total_harga_kategori=(harga_kategori*qty) where plu='" + plu + "' AND station='" + station + "'", connDB)
                    comDB.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("Update harga kategori " + ex.ToString)
                End Try
                rdDB.Close()
            End If
        Next
        ButtonCheckCustomer.Enabled = False
        TextBoxUangTunai.Enabled = True
        TextBoxUangTunai.Text = ""
        TextBoxUangTunai.Focus()
        DataTranTemp()
    End Sub

    Private Sub ButtonHapusCustomer_Click(sender As Object, e As EventArgs) Handles ButtonHapusCustomer.Click
        Try
            Call conecDB()
            comDB = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM cust_temp WHERE station='" + station + "'", connDB)
            comDB.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Hapus Cust Temp " + ex.ToString)
        End Try

        For Each row As DataGridViewRow In DataGridViewTranTemp.Rows
            If Not row.IsNewRow Then
                Try
                    plu = row.Cells(0).Value.ToString
                    Call conecDB()
                    comDB = New MySql.Data.MySqlClient.MySqlCommand("UPDATE tran_temp SET harga_kategori=harga_satuan_normal, total_harga_kategori=total_harga_normal WHERE plu='" + plu + "' AND station='" + station + "'", connDB)
                    comDB.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("Update harga kategori " + ex.ToString)
                End Try
                rdDB.Close()
            End If
        Next
        ButtonHapusCustomer.Enabled = False

        ClearTextBox()
        DataTranTemp()
        DataCustTemp()
    End Sub

    Private Sub TextBoxUangTunai_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxUangTunai.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim result As DialogResult = MessageBox.Show("Simpan dan cetak transaksi?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    If String.IsNullOrEmpty(TextBoxUangTunai.Text) Then
                        TextBoxUangTunai.Focus()
                        Exit Sub
                    End If
                    TextBoxKembali.Text = TextBoxUangTunai.Text - TextBoxTotal.Text
                    ButtonSimpanDanCetak.Enabled = True
                    Dim Kembali As Integer = TextBoxKembali.Text()
                    FormKasir_Kembalian.LabelKembalian.Text = Kembali.ToString("N0")
                    GenerateNomorStruk()
                    FormKasir_Kembalian.ShowDialog()
                End If
        End Select
    End Sub

    Public Sub SimpanTranDanCetak()

        Try
            Call conecDB()

            For Each row As DataGridViewRow In DataGridViewTranTemp.Rows
                If Not row.IsNewRow Then
                    Try
                        plu = row.Cells(0).Value.ToString
                        Dim qty = row.Cells(4).Value.ToString
                        Dim harga_kategori = row.Cells(3).Value.ToString
                        Dim harga_satuan_normal = row.Cells(2).Value.ToString
                        Dim total_harga_kategori = row.Cells(5).Value.ToString
                        Dim total_harga_normal = row.Cells(6).Value.ToString
                        Dim harga_beli_satuan = row.Cells(7).Value.ToString
                        Dim total_harga_beli = row.Cells(8).Value.ToString

                        'SIMPAN DATA TRANSAKSI
                        comDB = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO mtran (plu,tanggal,station,qty,harga_kategori,total_harga_kategori,harga_satuan_normal,total_harga_normal,harga_beli_satuan,total_harga_beli,customer_id,nomor_struk) values ('" + plu + "',curdate(),'" + station + "','" + qty + "','" + harga_kategori + "','" + total_harga_kategori + "','" + harga_satuan_normal + "','" + total_harga_normal + "','" + harga_beli_satuan + "','" + total_harga_beli + "','" + TextBoxIDCustomer.Text + "','" + nomor_struk + "')", connDB)
                        comDB.ExecuteNonQuery()

                        'UPDATE STOK
                        comDB = New MySql.Data.MySqlClient.MySqlCommand("UPDATE prodmast SET stok=stok-" + qty + " WHERE prdcd='" + plu + "'", connDB)
                        comDB.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Update harga kategori " + ex.ToString)
                    End Try
                    rdDB.Close()
                End If
            Next

            comDB = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM tran_temp WHERE station='" + station + "'", connDB)
            comDB.ExecuteNonQuery()
            DataTranTemp()
        Catch ex As Exception
            MsgBox("gagal delete tran_temp " + ex.ToString)
        End Try

        comDB = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM cust_temp WHERE station='" + station + "'", connDB)
        comDB.ExecuteNonQuery()

        TextBoxBarang.Enabled = True
        TextBoxQTY.Enabled = True
        TextBoxBarang.Focus()
        ClearTextBox()
        ClearTextBoxTran()
        TotalBelanja()
        TextBoxKembali.Clear()
        TextBoxUangTunai.Clear()


    End Sub

    Private Sub TextBoxNamaCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxNamaCustomer.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                TextBoxUangTunai.Enabled = True
                TextBoxUangTunai.Text = ""
                TextBoxUangTunai.Focus()
        End Select
    End Sub

    Sub CetakPrint()

        Try
            comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM toko", connDB)
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows Then
                rdDB.Read()
                nama_toko = rdDB.Item("nama_toko")
                alamat = rdDB.Item("alamat")
                no_telepon = "Telp. " + rdDB.Item("telepon")
                rdDB.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dim StoreName As String = nama_toko
        Dim StoreAddress As String = alamat
        Dim StorePhone As String = no_telepon
        'Dim Img As Image = Image.FromFile("d:\logo.jpg") '--> for fixed location
        'Dim Img As Image = Image.FromFile(Application.StartupPath() & "\logo.jpg")
        Dim Img As Image
        Dim TransNo As String = "No: " + nomor_struk
        Dim TransDate As String = "Tgl: " + Format(Now, "dd-MM-yyyy HH:mm:ss")

        'for item sales | untuk item penjualan
        Dim dtItem As DataTable
        Dim arrWidth() As Integer
        Dim arrFormat() As StringFormat

        'declaring printing format class
        Dim c As New PrintingFormat

        'for subtotal & qty total
        Dim dblSubtotal As Double = 0
        Dim dblQty As Double = 0
        Dim dblPayment As Double = 50000

        Printer.NewPrint()

        'Printer.Print(Img, 200, 100)

        'Setting Font
        Printer.SetFont("Bahnschrift Light Condensed", 8, FontStyle.Regular)
        Printer.Print(StoreName) 'Store Name | Nama Toko

        'Setting Font
        Printer.SetFont("Bahnschrift Light Condensed", 7, FontStyle.Regular)
        Printer.Print(StoreAddress & ";", {280}, 0) 'Store Address | Alamat Toko

        'Setting Font
        Printer.SetFont("Bahnschrift Light Condensed", 7, FontStyle.Regular)
        Printer.Print(StorePhone & ";", {280}, 0) 'No Telepon

        'spacing
        Printer.Print("---------------------------------------------------")

        Printer.SetFont("Bahnschrift Light Condensed", 7, FontStyle.Regular) 'Setting Font
        Printer.Print(TransNo + " - " + TransDate) ' Transaction No | Nomor transaksi

        Printer.SetFont("Bahnschrift Light Condensed", 7, FontStyle.Regular) 'Setting Font
        arrWidth = {75, 15, 40, 50} 'array for column width | array untuk lebar kolom
        arrFormat = {c.MidLeft, c.MidRight, c.MidRight, c.MidRight} 'array alignment 

        'column header split by ; | nama kolom dipisah dengan ;
        'Printer.Print("item;qty;price;subtotal", arrWidth, arrFormat)
        'Printer.SetFont("Bahnschrift Light Condensed", 7, FontStyle.Regular) 'Setting Font
        Printer.Print("---------------------------------------------------") 'line

        dblSubtotal = 0
        dblQty = 0
        'looping item sales | loop item penjualan

        For Each row As DataGridViewRow In DataGridViewTranTemp.Rows
            Dim price As Double = row.Cells(2).Value.ToString
            Dim harga_kategori As String = (row.Cells(2).Value.ToString - row.Cells(3).Value.ToString) * row.Cells(4).Value.ToString

            If String.Equals(row.Cells(2).Value.ToString, row.Cells(3).Value.ToString) Then
                harga_kategori = ""
            Else
                harga_kategori = vbCr & vbLf & "(" + harga_kategori + ")"
            End If
            Dim sub_total As Double = (row.Cells(4).Value.ToString * row.Cells(3).Value.ToString)
            Printer.Print(row.Cells(1).Value.ToString & ";" & _
                          row.Cells(4).Value.ToString & ";" & _
                          price.ToString("N0") & harga_kategori & ";" & _
                         (sub_total.ToString("N0")), arrWidth, arrFormat)
            dblQty = dblQty + CSng(row.Cells(4).Value.ToString)
            dblSubtotal = dblSubtotal + (row.Cells(4).Value.ToString * row.Cells(3).Value.ToString)
        Next

        Printer.Print("---------------------------------------------------")
        arrWidth = {80, 100} 'array for column width | array untuk lebar kolom
        arrFormat = {c.MidLeft, c.MidRight} 'array alignment 

        Dim total As Double = TextBoxTotal.Text
        Dim tunai As Double = TextBoxUangTunai.Text
        Dim kembali As Double = TextBoxKembali.Text
        Dim diskon As Double = TextBoxDiskon.Text
        Printer.Print("Total;" & total.ToString("N0"), arrWidth, arrFormat)
        Printer.Print("Tunai;" & tunai.ToString("N0"), arrWidth, arrFormat)
        Printer.Print("Kembali;" & kembali.ToString("N0"), arrWidth, arrFormat)
        If String.IsNullOrEmpty(TextBoxDiskon.Text) Then
        Else
            Printer.Print("Diskon;" & "(" & diskon.ToString("N0") & ")", arrWidth, arrFormat)
        End If
        Printer.Print("---------------------------------------------------")
        Printer.SetFont("Bahnschrift Light Condensed", 7, FontStyle.Regular) 'Setting Font
        Printer.Print("SELAMAT BELANJA KEMBALI") ' Selamat belanja kembali

        'Release the job for actual printing
        Printer.DoPrint()

    End Sub

    Sub GenerateNomorStruk()
        Dim dateAndTime As Date
        dateAndTime = Now

        nomor_struk = station + "-" + Format(dateAndTime, "yyMMddHHmmss").ToString

    End Sub

End Class