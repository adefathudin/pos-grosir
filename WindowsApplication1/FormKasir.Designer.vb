<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridViewTranTemp = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.formcaribarang = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridViewCariBarang = New System.Windows.Forms.DataGridView()
        Me.TextBoxCariBarang = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBarang = New System.Windows.Forms.TextBox()
        Me.TextBoxQTY = New System.Windows.Forms.TextBox()
        Me.ButtonCancelSales = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonSimpanDanCetak = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxKembali = New System.Windows.Forms.TextBox()
        Me.TextBoxUangTunai = New System.Windows.Forms.TextBox()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.TextBoxDiskon = New System.Windows.Forms.TextBox()
        Me.TextBoxTotalBelanja = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ButtonHapusCustomer = New System.Windows.Forms.Button()
        Me.ButtonCheckCustomer = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxKategoriHarga = New System.Windows.Forms.TextBox()
        Me.TextBoxNamaCustomer = New System.Windows.Forms.TextBox()
        Me.TextBoxIDCustomer = New System.Windows.Forms.TextBox()
        Me.ButtonScanKembali = New System.Windows.Forms.Button()
        Me.ButtonLanjutPembayaran = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridViewTranTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.formcaribarang.SuspendLayout()
        CType(Me.DataGridViewCariBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewTranTemp
        '
        Me.DataGridViewTranTemp.AllowUserToAddRows = False
        Me.DataGridViewTranTemp.AllowUserToDeleteRows = False
        Me.DataGridViewTranTemp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewTranTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTranTemp.Location = New System.Drawing.Point(5, 18)
        Me.DataGridViewTranTemp.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewTranTemp.Name = "DataGridViewTranTemp"
        Me.DataGridViewTranTemp.ReadOnly = True
        Me.DataGridViewTranTemp.RowTemplate.Height = 24
        Me.DataGridViewTranTemp.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DataGridViewTranTemp.Size = New System.Drawing.Size(613, 581)
        Me.DataGridViewTranTemp.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.formcaribarang)
        Me.GroupBox3.Controls.Add(Me.DataGridViewTranTemp)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(623, 604)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DAFTAR TRANSAKSI"
        '
        'formcaribarang
        '
        Me.formcaribarang.Controls.Add(Me.Button4)
        Me.formcaribarang.Controls.Add(Me.DataGridViewCariBarang)
        Me.formcaribarang.Controls.Add(Me.TextBoxCariBarang)
        Me.formcaribarang.Location = New System.Drawing.Point(0, 307)
        Me.formcaribarang.Margin = New System.Windows.Forms.Padding(2)
        Me.formcaribarang.Name = "formcaribarang"
        Me.formcaribarang.Padding = New System.Windows.Forms.Padding(2)
        Me.formcaribarang.Size = New System.Drawing.Size(623, 297)
        Me.formcaribarang.TabIndex = 1
        Me.formcaribarang.TabStop = False
        Me.formcaribarang.Text = "CARI BARANG"
        Me.formcaribarang.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button4.Location = New System.Drawing.Point(588, 18)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(30, 20)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DataGridViewCariBarang
        '
        Me.DataGridViewCariBarang.AllowUserToAddRows = False
        Me.DataGridViewCariBarang.AllowUserToDeleteRows = False
        Me.DataGridViewCariBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCariBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCariBarang.Location = New System.Drawing.Point(4, 41)
        Me.DataGridViewCariBarang.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewCariBarang.Name = "DataGridViewCariBarang"
        Me.DataGridViewCariBarang.ReadOnly = True
        Me.DataGridViewCariBarang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridViewCariBarang.RowTemplate.Height = 24
        Me.DataGridViewCariBarang.Size = New System.Drawing.Size(614, 245)
        Me.DataGridViewCariBarang.TabIndex = 3
        '
        'TextBoxCariBarang
        '
        Me.TextBoxCariBarang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxCariBarang.Location = New System.Drawing.Point(4, 18)
        Me.TextBoxCariBarang.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCariBarang.Name = "TextBoxCariBarang"
        Me.TextBoxCariBarang.Size = New System.Drawing.Size(580, 20)
        Me.TextBoxCariBarang.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxBarang)
        Me.GroupBox1.Controls.Add(Me.TextBoxQTY)
        Me.GroupBox1.Location = New System.Drawing.Point(632, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(197, 83)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TRANSAKSI PENJUALAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "QTY :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Barang :"
        '
        'TextBoxBarang
        '
        Me.TextBoxBarang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxBarang.Location = New System.Drawing.Point(57, 20)
        Me.TextBoxBarang.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxBarang.Name = "TextBoxBarang"
        Me.TextBoxBarang.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxBarang.TabIndex = 1
        '
        'TextBoxQTY
        '
        Me.TextBoxQTY.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxQTY.Location = New System.Drawing.Point(57, 48)
        Me.TextBoxQTY.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxQTY.Name = "TextBoxQTY"
        Me.TextBoxQTY.Size = New System.Drawing.Size(133, 20)
        Me.TextBoxQTY.TabIndex = 2
        '
        'ButtonCancelSales
        '
        Me.ButtonCancelSales.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonCancelSales.Location = New System.Drawing.Point(105, 19)
        Me.ButtonCancelSales.Name = "ButtonCancelSales"
        Me.ButtonCancelSales.Size = New System.Drawing.Size(86, 46)
        Me.ButtonCancelSales.TabIndex = 10
        Me.ButtonCancelSales.Text = "[F2] Cancel Sales"
        Me.ButtonCancelSales.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.Location = New System.Drawing.Point(5, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 46)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "[F1] Cari Barang"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ButtonSimpanDanCetak)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBoxKembali)
        Me.GroupBox2.Controls.Add(Me.TextBoxUangTunai)
        Me.GroupBox2.Controls.Add(Me.TextBoxTotal)
        Me.GroupBox2.Controls.Add(Me.TextBoxDiskon)
        Me.GroupBox2.Controls.Add(Me.TextBoxTotalBelanja)
        Me.GroupBox2.Location = New System.Drawing.Point(631, 376)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(197, 240)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PEMBAYARAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Kembali :"
        '
        'ButtonSimpanDanCetak
        '
        Me.ButtonSimpanDanCetak.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonSimpanDanCetak.Enabled = False
        Me.ButtonSimpanDanCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSimpanDanCetak.Location = New System.Drawing.Point(8, 182)
        Me.ButtonSimpanDanCetak.Name = "ButtonSimpanDanCetak"
        Me.ButtonSimpanDanCetak.Size = New System.Drawing.Size(184, 47)
        Me.ButtonSimpanDanCetak.TabIndex = 11
        Me.ButtonSimpanDanCetak.Text = "SIMPAN DAN CETAK STRUK"
        Me.ButtonSimpanDanCetak.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Uang Tunai :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Disc. Hrg Ktgr :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hrg. Normal :"
        '
        'TextBoxKembali
        '
        Me.TextBoxKembali.Location = New System.Drawing.Point(80, 154)
        Me.TextBoxKembali.Name = "TextBoxKembali"
        Me.TextBoxKembali.ReadOnly = True
        Me.TextBoxKembali.Size = New System.Drawing.Size(112, 20)
        Me.TextBoxKembali.TabIndex = 5
        Me.TextBoxKembali.Text = "0"
        Me.TextBoxKembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxUangTunai
        '
        Me.TextBoxUangTunai.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxUangTunai.Enabled = False
        Me.TextBoxUangTunai.Location = New System.Drawing.Point(81, 128)
        Me.TextBoxUangTunai.Name = "TextBoxUangTunai"
        Me.TextBoxUangTunai.Size = New System.Drawing.Size(111, 20)
        Me.TextBoxUangTunai.TabIndex = 4
        Me.TextBoxUangTunai.Text = "0"
        Me.TextBoxUangTunai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotal.Location = New System.Drawing.Point(8, 87)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.ReadOnly = True
        Me.TextBoxTotal.Size = New System.Drawing.Size(184, 26)
        Me.TextBoxTotal.TabIndex = 3
        Me.TextBoxTotal.Text = "0"
        Me.TextBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxDiskon
        '
        Me.TextBoxDiskon.Location = New System.Drawing.Point(88, 52)
        Me.TextBoxDiskon.Name = "TextBoxDiskon"
        Me.TextBoxDiskon.ReadOnly = True
        Me.TextBoxDiskon.Size = New System.Drawing.Size(102, 20)
        Me.TextBoxDiskon.TabIndex = 1
        Me.TextBoxDiskon.Text = "0"
        Me.TextBoxDiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxTotalBelanja
        '
        Me.TextBoxTotalBelanja.Location = New System.Drawing.Point(88, 26)
        Me.TextBoxTotalBelanja.Name = "TextBoxTotalBelanja"
        Me.TextBoxTotalBelanja.ReadOnly = True
        Me.TextBoxTotalBelanja.Size = New System.Drawing.Size(102, 20)
        Me.TextBoxTotalBelanja.TabIndex = 0
        Me.TextBoxTotalBelanja.Text = "0"
        Me.TextBoxTotalBelanja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ButtonHapusCustomer)
        Me.GroupBox4.Controls.Add(Me.ButtonCheckCustomer)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TextBoxKategoriHarga)
        Me.GroupBox4.Controls.Add(Me.TextBoxNamaCustomer)
        Me.GroupBox4.Controls.Add(Me.TextBoxIDCustomer)
        Me.GroupBox4.Location = New System.Drawing.Point(632, 235)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(197, 135)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PELANGGAN"
        '
        'ButtonHapusCustomer
        '
        Me.ButtonHapusCustomer.Enabled = False
        Me.ButtonHapusCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHapusCustomer.Location = New System.Drawing.Point(79, 102)
        Me.ButtonHapusCustomer.Name = "ButtonHapusCustomer"
        Me.ButtonHapusCustomer.Size = New System.Drawing.Size(50, 27)
        Me.ButtonHapusCustomer.TabIndex = 19
        Me.ButtonHapusCustomer.Text = "x"
        Me.ButtonHapusCustomer.UseVisualStyleBackColor = True
        '
        'ButtonCheckCustomer
        '
        Me.ButtonCheckCustomer.Enabled = False
        Me.ButtonCheckCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCheckCustomer.Location = New System.Drawing.Point(141, 102)
        Me.ButtonCheckCustomer.Name = "ButtonCheckCustomer"
        Me.ButtonCheckCustomer.Size = New System.Drawing.Size(50, 27)
        Me.ButtonCheckCustomer.TabIndex = 18
        Me.ButtonCheckCustomer.Text = "✓"
        Me.ButtonCheckCustomer.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Nama :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "No. HP :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Ktgr. Harga :"
        '
        'TextBoxKategoriHarga
        '
        Me.TextBoxKategoriHarga.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxKategoriHarga.Location = New System.Drawing.Point(79, 76)
        Me.TextBoxKategoriHarga.Name = "TextBoxKategoriHarga"
        Me.TextBoxKategoriHarga.ReadOnly = True
        Me.TextBoxKategoriHarga.Size = New System.Drawing.Size(112, 20)
        Me.TextBoxKategoriHarga.TabIndex = 15
        '
        'TextBoxNamaCustomer
        '
        Me.TextBoxNamaCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxNamaCustomer.Location = New System.Drawing.Point(79, 50)
        Me.TextBoxNamaCustomer.Name = "TextBoxNamaCustomer"
        Me.TextBoxNamaCustomer.ReadOnly = True
        Me.TextBoxNamaCustomer.Size = New System.Drawing.Size(112, 20)
        Me.TextBoxNamaCustomer.TabIndex = 14
        Me.TextBoxNamaCustomer.Text = "cari..."
        '
        'TextBoxIDCustomer
        '
        Me.TextBoxIDCustomer.Location = New System.Drawing.Point(79, 24)
        Me.TextBoxIDCustomer.Name = "TextBoxIDCustomer"
        Me.TextBoxIDCustomer.ReadOnly = True
        Me.TextBoxIDCustomer.Size = New System.Drawing.Size(112, 20)
        Me.TextBoxIDCustomer.TabIndex = 13
        '
        'ButtonScanKembali
        '
        Me.ButtonScanKembali.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonScanKembali.Location = New System.Drawing.Point(5, 71)
        Me.ButtonScanKembali.Name = "ButtonScanKembali"
        Me.ButtonScanKembali.Size = New System.Drawing.Size(86, 46)
        Me.ButtonScanKembali.TabIndex = 11
        Me.ButtonScanKembali.Text = "[F3] Scan Kembali"
        Me.ButtonScanKembali.UseVisualStyleBackColor = False
        '
        'ButtonLanjutPembayaran
        '
        Me.ButtonLanjutPembayaran.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonLanjutPembayaran.Location = New System.Drawing.Point(104, 71)
        Me.ButtonLanjutPembayaran.Name = "ButtonLanjutPembayaran"
        Me.ButtonLanjutPembayaran.Size = New System.Drawing.Size(86, 46)
        Me.ButtonLanjutPembayaran.TabIndex = 12
        Me.ButtonLanjutPembayaran.Text = "[F4] Lanjut Pembayaran"
        Me.ButtonLanjutPembayaran.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ButtonCancelSales)
        Me.GroupBox5.Controls.Add(Me.ButtonLanjutPembayaran)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.ButtonScanKembali)
        Me.GroupBox5.Location = New System.Drawing.Point(633, 101)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(196, 128)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "OPTION"
        '
        'FormKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(834, 620)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormKasir"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormKasir"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridViewTranTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.formcaribarang.ResumeLayout(False)
        Me.formcaribarang.PerformLayout()
        CType(Me.DataGridViewCariBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTranTemp As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxBarang As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancelSales As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKembali As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUangTunai As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDiskon As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotalBelanja As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSimpanDanCetak As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents formcaribarang As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewCariBarang As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxCariBarang As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxNamaCustomer As System.Windows.Forms.TextBox
    Friend WithEvents ButtonScanKembali As System.Windows.Forms.Button
    Friend WithEvents ButtonLanjutPembayaran As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKategoriHarga As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxIDCustomer As System.Windows.Forms.TextBox
    Friend WithEvents ButtonHapusCustomer As System.Windows.Forms.Button
    Friend WithEvents ButtonCheckCustomer As System.Windows.Forms.Button
End Class
