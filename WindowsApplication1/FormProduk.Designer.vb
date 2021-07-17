<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduk
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelTotalItem = New System.Windows.Forms.Label()
        Me.PanelDetailProduk = New System.Windows.Forms.Panel()
        Me.GroupBoxDetailProduk = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBoxKategoriProduk = New System.Windows.Forms.ComboBox()
        Me.TextBoxProdukPLU = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxProdukDesc = New System.Windows.Forms.TextBox()
        Me.TextBoxProdukStok = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxBarcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxProdukRak = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxProdukHargaBeli = New System.Windows.Forms.TextBox()
        Me.TextBoxProdukHargaJual = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxKategoriHargaID = New System.Windows.Forms.TextBox()
        Me.ButtonDeleteKategoriHarga = New System.Windows.Forms.Button()
        Me.TextBoxKategoriHarga_harga = New System.Windows.Forms.TextBox()
        Me.ComboBoxKategoriHarga = New System.Windows.Forms.ComboBox()
        Me.DataGridViewKategoriHarga = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ButtonProdukClose = New System.Windows.Forms.Button()
        Me.ButtonProdukSave = New System.Windows.Forms.Button()
        Me.TextBoxPencarianProduk = New System.Windows.Forms.TextBox()
        Me.DataGridViewBarang = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonProdukKategoriHarga = New System.Windows.Forms.Button()
        Me.ButtonInputBarang = New System.Windows.Forms.Button()
        Me.ButtonDeleteProduk = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.PanelDetailProduk.SuspendLayout()
        Me.GroupBoxDetailProduk.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridViewKategoriHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelTotalItem)
        Me.GroupBox1.Controls.Add(Me.PanelDetailProduk)
        Me.GroupBox1.Controls.Add(Me.TextBoxPencarianProduk)
        Me.GroupBox1.Controls.Add(Me.DataGridViewBarang)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 90)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(822, 526)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DAFTAR PRODUK"
        '
        'LabelTotalItem
        '
        Me.LabelTotalItem.AutoSize = True
        Me.LabelTotalItem.Location = New System.Drawing.Point(115, 0)
        Me.LabelTotalItem.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTotalItem.Name = "LabelTotalItem"
        Me.LabelTotalItem.Size = New System.Drawing.Size(77, 13)
        Me.LabelTotalItem.TabIndex = 5
        Me.LabelTotalItem.Text = "LabelTotalItem"
        '
        'PanelDetailProduk
        '
        Me.PanelDetailProduk.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PanelDetailProduk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelDetailProduk.Controls.Add(Me.GroupBoxDetailProduk)
        Me.PanelDetailProduk.Location = New System.Drawing.Point(1, 197)
        Me.PanelDetailProduk.Name = "PanelDetailProduk"
        Me.PanelDetailProduk.Size = New System.Drawing.Size(815, 321)
        Me.PanelDetailProduk.TabIndex = 4
        Me.PanelDetailProduk.Visible = False
        '
        'GroupBoxDetailProduk
        '
        Me.GroupBoxDetailProduk.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBoxDetailProduk.Controls.Add(Me.ButtonDeleteProduk)
        Me.GroupBoxDetailProduk.Controls.Add(Me.GroupBox4)
        Me.GroupBoxDetailProduk.Controls.Add(Me.GroupBox3)
        Me.GroupBoxDetailProduk.Controls.Add(Me.ButtonProdukClose)
        Me.GroupBoxDetailProduk.Controls.Add(Me.ButtonProdukSave)
        Me.GroupBoxDetailProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDetailProduk.Location = New System.Drawing.Point(3, 15)
        Me.GroupBoxDetailProduk.Name = "GroupBoxDetailProduk"
        Me.GroupBoxDetailProduk.Size = New System.Drawing.Size(805, 378)
        Me.GroupBoxDetailProduk.TabIndex = 0
        Me.GroupBoxDetailProduk.TabStop = False
        Me.GroupBoxDetailProduk.Text = "DETAIL PRODUK"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.ComboBoxKategoriProduk)
        Me.GroupBox4.Controls.Add(Me.TextBoxProdukPLU)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TextBoxProdukDesc)
        Me.GroupBox4.Controls.Add(Me.TextBoxProdukStok)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.TextBoxBarcode)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.ComboBoxProdukRak)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.TextBoxProdukHargaBeli)
        Me.GroupBox4.Controls.Add(Me.TextBoxProdukHargaJual)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 29)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(333, 264)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Scan Barcode"
        '
        'ComboBoxKategoriProduk
        '
        Me.ComboBoxKategoriProduk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxKategoriProduk.FormattingEnabled = True
        Me.ComboBoxKategoriProduk.Location = New System.Drawing.Point(102, 221)
        Me.ComboBoxKategoriProduk.Name = "ComboBoxKategoriProduk"
        Me.ComboBoxKategoriProduk.Size = New System.Drawing.Size(192, 21)
        Me.ComboBoxKategoriProduk.TabIndex = 26
        '
        'TextBoxProdukPLU
        '
        Me.TextBoxProdukPLU.Location = New System.Drawing.Point(205, 25)
        Me.TextBoxProdukPLU.Name = "TextBoxProdukPLU"
        Me.TextBoxProdukPLU.ReadOnly = True
        Me.TextBoxProdukPLU.Size = New System.Drawing.Size(89, 20)
        Me.TextBoxProdukPLU.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Kategori Produk"
        '
        'TextBoxProdukDesc
        '
        Me.TextBoxProdukDesc.Location = New System.Drawing.Point(102, 58)
        Me.TextBoxProdukDesc.Name = "TextBoxProdukDesc"
        Me.TextBoxProdukDesc.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxProdukDesc.TabIndex = 4
        '
        'TextBoxProdukStok
        '
        Me.TextBoxProdukStok.Location = New System.Drawing.Point(102, 160)
        Me.TextBoxProdukStok.Name = "TextBoxProdukStok"
        Me.TextBoxProdukStok.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxProdukStok.TabIndex = 5
        Me.TextBoxProdukStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nama Produk"
        '
        'TextBoxBarcode
        '
        Me.TextBoxBarcode.Location = New System.Drawing.Point(102, 25)
        Me.TextBoxBarcode.Name = "TextBoxBarcode"
        Me.TextBoxBarcode.Size = New System.Drawing.Size(97, 20)
        Me.TextBoxBarcode.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Qty"
        '
        'ComboBoxProdukRak
        '
        Me.ComboBoxProdukRak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProdukRak.FormattingEnabled = True
        Me.ComboBoxProdukRak.Location = New System.Drawing.Point(102, 191)
        Me.ComboBoxProdukRak.Name = "ComboBoxProdukRak"
        Me.ComboBoxProdukRak.Size = New System.Drawing.Size(192, 21)
        Me.ComboBoxProdukRak.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Rak"
        '
        'TextBoxProdukHargaBeli
        '
        Me.TextBoxProdukHargaBeli.Location = New System.Drawing.Point(102, 94)
        Me.TextBoxProdukHargaBeli.Name = "TextBoxProdukHargaBeli"
        Me.TextBoxProdukHargaBeli.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxProdukHargaBeli.TabIndex = 11
        Me.TextBoxProdukHargaBeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxProdukHargaJual
        '
        Me.TextBoxProdukHargaJual.Location = New System.Drawing.Point(102, 127)
        Me.TextBoxProdukHargaJual.Name = "TextBoxProdukHargaJual"
        Me.TextBoxProdukHargaJual.Size = New System.Drawing.Size(192, 20)
        Me.TextBoxProdukHargaJual.TabIndex = 12
        Me.TextBoxProdukHargaJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Harga Jual"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Harga Beli"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TextBoxKategoriHargaID)
        Me.GroupBox3.Controls.Add(Me.ButtonDeleteKategoriHarga)
        Me.GroupBox3.Controls.Add(Me.TextBoxKategoriHarga_harga)
        Me.GroupBox3.Controls.Add(Me.ComboBoxKategoriHarga)
        Me.GroupBox3.Controls.Add(Me.DataGridViewKategoriHarga)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Location = New System.Drawing.Point(360, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(439, 264)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kategori Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(304, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Ketika menambah kategori harga, data tersebut akan otomatis tersimpan."
        '
        'TextBoxKategoriHargaID
        '
        Me.TextBoxKategoriHargaID.Location = New System.Drawing.Point(7, 20)
        Me.TextBoxKategoriHargaID.Name = "TextBoxKategoriHargaID"
        Me.TextBoxKategoriHargaID.ReadOnly = True
        Me.TextBoxKategoriHargaID.Size = New System.Drawing.Size(48, 20)
        Me.TextBoxKategoriHargaID.TabIndex = 5
        '
        'ButtonDeleteKategoriHarga
        '
        Me.ButtonDeleteKategoriHarga.Location = New System.Drawing.Point(394, 18)
        Me.ButtonDeleteKategoriHarga.Name = "ButtonDeleteKategoriHarga"
        Me.ButtonDeleteKategoriHarga.Size = New System.Drawing.Size(39, 23)
        Me.ButtonDeleteKategoriHarga.TabIndex = 4
        Me.ButtonDeleteKategoriHarga.Text = "-"
        Me.ButtonDeleteKategoriHarga.UseVisualStyleBackColor = True
        '
        'TextBoxKategoriHarga_harga
        '
        Me.TextBoxKategoriHarga_harga.Location = New System.Drawing.Point(221, 20)
        Me.TextBoxKategoriHarga_harga.Name = "TextBoxKategoriHarga_harga"
        Me.TextBoxKategoriHarga_harga.Size = New System.Drawing.Size(118, 20)
        Me.TextBoxKategoriHarga_harga.TabIndex = 3
        '
        'ComboBoxKategoriHarga
        '
        Me.ComboBoxKategoriHarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxKategoriHarga.FormattingEnabled = True
        Me.ComboBoxKategoriHarga.Location = New System.Drawing.Point(61, 20)
        Me.ComboBoxKategoriHarga.Name = "ComboBoxKategoriHarga"
        Me.ComboBoxKategoriHarga.Size = New System.Drawing.Size(154, 21)
        Me.ComboBoxKategoriHarga.TabIndex = 2
        '
        'DataGridViewKategoriHarga
        '
        Me.DataGridViewKategoriHarga.AllowUserToAddRows = False
        Me.DataGridViewKategoriHarga.AllowUserToDeleteRows = False
        Me.DataGridViewKategoriHarga.AllowUserToOrderColumns = True
        Me.DataGridViewKategoriHarga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewKategoriHarga.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewKategoriHarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewKategoriHarga.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewKategoriHarga.Location = New System.Drawing.Point(7, 49)
        Me.DataGridViewKategoriHarga.Name = "DataGridViewKategoriHarga"
        Me.DataGridViewKategoriHarga.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewKategoriHarga.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewKategoriHarga.Size = New System.Drawing.Size(426, 193)
        Me.DataGridViewKategoriHarga.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(345, 18)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(43, 23)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "+"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ButtonProdukClose
        '
        Me.ButtonProdukClose.BackColor = System.Drawing.Color.PeachPuff
        Me.ButtonProdukClose.Location = New System.Drawing.Point(730, 0)
        Me.ButtonProdukClose.Name = "ButtonProdukClose"
        Me.ButtonProdukClose.Size = New System.Drawing.Size(69, 23)
        Me.ButtonProdukClose.TabIndex = 0
        Me.ButtonProdukClose.Text = "Close"
        Me.ButtonProdukClose.UseVisualStyleBackColor = False
        '
        'ButtonProdukSave
        '
        Me.ButtonProdukSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonProdukSave.Location = New System.Drawing.Point(571, 0)
        Me.ButtonProdukSave.Name = "ButtonProdukSave"
        Me.ButtonProdukSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonProdukSave.TabIndex = 2
        Me.ButtonProdukSave.Text = "Save"
        Me.ButtonProdukSave.UseVisualStyleBackColor = False
        '
        'TextBoxPencarianProduk
        '
        Me.TextBoxPencarianProduk.Location = New System.Drawing.Point(673, 0)
        Me.TextBoxPencarianProduk.Name = "TextBoxPencarianProduk"
        Me.TextBoxPencarianProduk.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxPencarianProduk.TabIndex = 4
        Me.TextBoxPencarianProduk.WordWrap = False
        '
        'DataGridViewBarang
        '
        Me.DataGridViewBarang.AllowUserToAddRows = False
        Me.DataGridViewBarang.AllowUserToDeleteRows = False
        Me.DataGridViewBarang.AllowUserToResizeColumns = False
        Me.DataGridViewBarang.AllowUserToResizeRows = False
        Me.DataGridViewBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBarang.Location = New System.Drawing.Point(2, 25)
        Me.DataGridViewBarang.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewBarang.MultiSelect = False
        Me.DataGridViewBarang.Name = "DataGridViewBarang"
        Me.DataGridViewBarang.ReadOnly = True
        Me.DataGridViewBarang.RowTemplate.Height = 24
        Me.DataGridViewBarang.Size = New System.Drawing.Size(816, 494)
        Me.DataGridViewBarang.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.ButtonProdukKategoriHarga)
        Me.GroupBox2.Controls.Add(Me.ButtonInputBarang)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(822, 76)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PILIHAN PRODUK"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button2.Location = New System.Drawing.Point(112, 28)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 32)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Kategori Produk"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button3.Location = New System.Drawing.Point(217, 28)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 32)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Rak"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ButtonProdukKategoriHarga
        '
        Me.ButtonProdukKategoriHarga.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonProdukKategoriHarga.Location = New System.Drawing.Point(321, 28)
        Me.ButtonProdukKategoriHarga.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonProdukKategoriHarga.Name = "ButtonProdukKategoriHarga"
        Me.ButtonProdukKategoriHarga.Size = New System.Drawing.Size(100, 32)
        Me.ButtonProdukKategoriHarga.TabIndex = 5
        Me.ButtonProdukKategoriHarga.Text = "Kategori Harga"
        Me.ButtonProdukKategoriHarga.UseVisualStyleBackColor = False
        '
        'ButtonInputBarang
        '
        Me.ButtonInputBarang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonInputBarang.Location = New System.Drawing.Point(8, 28)
        Me.ButtonInputBarang.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonInputBarang.Name = "ButtonInputBarang"
        Me.ButtonInputBarang.Size = New System.Drawing.Size(100, 32)
        Me.ButtonInputBarang.TabIndex = 4
        Me.ButtonInputBarang.Text = "Input Barang"
        Me.ButtonInputBarang.UseVisualStyleBackColor = False
        '
        'ButtonDeleteProduk
        '
        Me.ButtonDeleteProduk.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonDeleteProduk.Location = New System.Drawing.Point(652, 0)
        Me.ButtonDeleteProduk.Name = "ButtonDeleteProduk"
        Me.ButtonDeleteProduk.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDeleteProduk.TabIndex = 28
        Me.ButtonDeleteProduk.Text = "Delete"
        Me.ButtonDeleteProduk.UseVisualStyleBackColor = False
        '
        'FormProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 620)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormProduk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormProduk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelDetailProduk.ResumeLayout(False)
        Me.GroupBoxDetailProduk.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridViewKategoriHarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewBarang As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonProdukKategoriHarga As System.Windows.Forms.Button
    Friend WithEvents ButtonInputBarang As System.Windows.Forms.Button
    Friend WithEvents LabelTotalItem As System.Windows.Forms.Label
    Friend WithEvents TextBoxPencarianProduk As System.Windows.Forms.TextBox
    Friend WithEvents PanelDetailProduk As System.Windows.Forms.Panel
    Friend WithEvents GroupBoxDetailProduk As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxProdukStok As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxProdukDesc As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxProdukPLU As System.Windows.Forms.TextBox
    Friend WithEvents ButtonProdukSave As System.Windows.Forms.Button
    Friend WithEvents ButtonProdukClose As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxProdukHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxProdukHargaBeli As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxProdukRak As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBarcode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxKategoriProduk As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewKategoriHarga As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBoxKategoriHarga_harga As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxKategoriHarga As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonDeleteKategoriHarga As System.Windows.Forms.Button
    Friend WithEvents TextBoxKategoriHargaID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonDeleteProduk As System.Windows.Forms.Button
End Class
