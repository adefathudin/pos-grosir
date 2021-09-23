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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelTotalItem = New System.Windows.Forms.Label()
        Me.PanelDetailProduk = New System.Windows.Forms.Panel()
        Me.GroupBoxDetailProduk = New System.Windows.Forms.GroupBox()
        Me.ButtonDeleteProduk = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBoxKategoriProduk = New System.Windows.Forms.TextBox()
        Me.TextBoxRak = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxProdukPLU = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxProdukDesc = New System.Windows.Forms.TextBox()
        Me.TextBoxProdukStok = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxBarcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.ButtonSaveKategoriHarga = New System.Windows.Forms.Button()
        Me.ButtonProdukClose = New System.Windows.Forms.Button()
        Me.ButtonProdukSave = New System.Windows.Forms.Button()
        Me.TextBoxPencarianProduk = New System.Windows.Forms.TextBox()
        Me.DataGridViewBarang = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonProdukKategoriHarga = New System.Windows.Forms.Button()
        Me.ButtonInputBarang = New System.Windows.Forms.Button()
        Me.ButtonExportExcelProduk = New System.Windows.Forms.Button()
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
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LabelTotalItem)
        Me.GroupBox1.Controls.Add(Me.PanelDetailProduk)
        Me.GroupBox1.Controls.Add(Me.TextBoxPencarianProduk)
        Me.GroupBox1.Controls.Add(Me.DataGridViewBarang)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1096, 647)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DAFTAR PRODUK"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(800, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Cari barang :"
        '
        'LabelTotalItem
        '
        Me.LabelTotalItem.AutoSize = True
        Me.LabelTotalItem.Location = New System.Drawing.Point(153, 0)
        Me.LabelTotalItem.Name = "LabelTotalItem"
        Me.LabelTotalItem.Size = New System.Drawing.Size(101, 17)
        Me.LabelTotalItem.TabIndex = 5
        Me.LabelTotalItem.Text = "LabelTotalItem"
        '
        'PanelDetailProduk
        '
        Me.PanelDetailProduk.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PanelDetailProduk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelDetailProduk.Controls.Add(Me.GroupBoxDetailProduk)
        Me.PanelDetailProduk.Location = New System.Drawing.Point(1, 242)
        Me.PanelDetailProduk.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDetailProduk.Name = "PanelDetailProduk"
        Me.PanelDetailProduk.Size = New System.Drawing.Size(1085, 394)
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
        Me.GroupBoxDetailProduk.Location = New System.Drawing.Point(4, 18)
        Me.GroupBoxDetailProduk.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxDetailProduk.Name = "GroupBoxDetailProduk"
        Me.GroupBoxDetailProduk.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxDetailProduk.Size = New System.Drawing.Size(1073, 465)
        Me.GroupBoxDetailProduk.TabIndex = 0
        Me.GroupBoxDetailProduk.TabStop = False
        Me.GroupBoxDetailProduk.Text = "DETAIL PRODUK"
        '
        'ButtonDeleteProduk
        '
        Me.ButtonDeleteProduk.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonDeleteProduk.Location = New System.Drawing.Point(869, 0)
        Me.ButtonDeleteProduk.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDeleteProduk.Name = "ButtonDeleteProduk"
        Me.ButtonDeleteProduk.Size = New System.Drawing.Size(100, 28)
        Me.ButtonDeleteProduk.TabIndex = 28
        Me.ButtonDeleteProduk.Text = "Delete"
        Me.ButtonDeleteProduk.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBoxKategoriProduk)
        Me.GroupBox4.Controls.Add(Me.TextBoxRak)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.TextBoxProdukPLU)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TextBoxProdukDesc)
        Me.GroupBox4.Controls.Add(Me.TextBoxProdukStok)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.TextBoxBarcode)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.TextBoxProdukHargaBeli)
        Me.GroupBox4.Controls.Add(Me.TextBoxProdukHargaJual)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 36)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(444, 325)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        '
        'TextBoxKategoriProduk
        '
        Me.TextBoxKategoriProduk.Location = New System.Drawing.Point(136, 272)
        Me.TextBoxKategoriProduk.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxKategoriProduk.Name = "TextBoxKategoriProduk"
        Me.TextBoxKategoriProduk.ReadOnly = True
        Me.TextBoxKategoriProduk.Size = New System.Drawing.Size(255, 23)
        Me.TextBoxKategoriProduk.TabIndex = 28
        '
        'TextBoxRak
        '
        Me.TextBoxRak.Location = New System.Drawing.Point(136, 235)
        Me.TextBoxRak.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxRak.Name = "TextBoxRak"
        Me.TextBoxRak.ReadOnly = True
        Me.TextBoxRak.Size = New System.Drawing.Size(255, 23)
        Me.TextBoxRak.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 34)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Scan Barcode"
        '
        'TextBoxProdukPLU
        '
        Me.TextBoxProdukPLU.Location = New System.Drawing.Point(273, 31)
        Me.TextBoxProdukPLU.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxProdukPLU.Name = "TextBoxProdukPLU"
        Me.TextBoxProdukPLU.ReadOnly = True
        Me.TextBoxProdukPLU.Size = New System.Drawing.Size(117, 23)
        Me.TextBoxProdukPLU.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 276)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Kategori Produk"
        '
        'TextBoxProdukDesc
        '
        Me.TextBoxProdukDesc.Location = New System.Drawing.Point(136, 71)
        Me.TextBoxProdukDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxProdukDesc.Name = "TextBoxProdukDesc"
        Me.TextBoxProdukDesc.Size = New System.Drawing.Size(255, 23)
        Me.TextBoxProdukDesc.TabIndex = 4
        '
        'TextBoxProdukStok
        '
        Me.TextBoxProdukStok.Location = New System.Drawing.Point(136, 197)
        Me.TextBoxProdukStok.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxProdukStok.Name = "TextBoxProdukStok"
        Me.TextBoxProdukStok.Size = New System.Drawing.Size(255, 23)
        Me.TextBoxProdukStok.TabIndex = 5
        Me.TextBoxProdukStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nama Produk"
        '
        'TextBoxBarcode
        '
        Me.TextBoxBarcode.Location = New System.Drawing.Point(136, 31)
        Me.TextBoxBarcode.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxBarcode.Name = "TextBoxBarcode"
        Me.TextBoxBarcode.Size = New System.Drawing.Size(128, 23)
        Me.TextBoxBarcode.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 201)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Qty"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 239)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Rak"
        '
        'TextBoxProdukHargaBeli
        '
        Me.TextBoxProdukHargaBeli.Location = New System.Drawing.Point(136, 116)
        Me.TextBoxProdukHargaBeli.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxProdukHargaBeli.Name = "TextBoxProdukHargaBeli"
        Me.TextBoxProdukHargaBeli.Size = New System.Drawing.Size(255, 23)
        Me.TextBoxProdukHargaBeli.TabIndex = 11
        Me.TextBoxProdukHargaBeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxProdukHargaJual
        '
        Me.TextBoxProdukHargaJual.Location = New System.Drawing.Point(136, 156)
        Me.TextBoxProdukHargaJual.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxProdukHargaJual.Name = "TextBoxProdukHargaJual"
        Me.TextBoxProdukHargaJual.Size = New System.Drawing.Size(255, 23)
        Me.TextBoxProdukHargaJual.TabIndex = 12
        Me.TextBoxProdukHargaJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 160)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Harga Jual"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 119)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
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
        Me.GroupBox3.Controls.Add(Me.ButtonSaveKategoriHarga)
        Me.GroupBox3.Location = New System.Drawing.Point(480, 36)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(585, 325)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kategori Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 302)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(408, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Ketika menambah kategori harga, data tersebut akan otomatis tersimpan."
        '
        'TextBoxKategoriHargaID
        '
        Me.TextBoxKategoriHargaID.Location = New System.Drawing.Point(9, 25)
        Me.TextBoxKategoriHargaID.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxKategoriHargaID.Name = "TextBoxKategoriHargaID"
        Me.TextBoxKategoriHargaID.ReadOnly = True
        Me.TextBoxKategoriHargaID.Size = New System.Drawing.Size(63, 23)
        Me.TextBoxKategoriHargaID.TabIndex = 5
        '
        'ButtonDeleteKategoriHarga
        '
        Me.ButtonDeleteKategoriHarga.Location = New System.Drawing.Point(525, 22)
        Me.ButtonDeleteKategoriHarga.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDeleteKategoriHarga.Name = "ButtonDeleteKategoriHarga"
        Me.ButtonDeleteKategoriHarga.Size = New System.Drawing.Size(52, 28)
        Me.ButtonDeleteKategoriHarga.TabIndex = 4
        Me.ButtonDeleteKategoriHarga.Text = "-"
        Me.ButtonDeleteKategoriHarga.UseVisualStyleBackColor = True
        '
        'TextBoxKategoriHarga_harga
        '
        Me.TextBoxKategoriHarga_harga.Location = New System.Drawing.Point(295, 25)
        Me.TextBoxKategoriHarga_harga.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxKategoriHarga_harga.Name = "TextBoxKategoriHarga_harga"
        Me.TextBoxKategoriHarga_harga.Size = New System.Drawing.Size(156, 23)
        Me.TextBoxKategoriHarga_harga.TabIndex = 3
        '
        'ComboBoxKategoriHarga
        '
        Me.ComboBoxKategoriHarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxKategoriHarga.FormattingEnabled = True
        Me.ComboBoxKategoriHarga.Location = New System.Drawing.Point(81, 25)
        Me.ComboBoxKategoriHarga.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxKategoriHarga.Name = "ComboBoxKategoriHarga"
        Me.ComboBoxKategoriHarga.Size = New System.Drawing.Size(204, 25)
        Me.ComboBoxKategoriHarga.TabIndex = 2
        '
        'DataGridViewKategoriHarga
        '
        Me.DataGridViewKategoriHarga.AllowUserToAddRows = False
        Me.DataGridViewKategoriHarga.AllowUserToDeleteRows = False
        Me.DataGridViewKategoriHarga.AllowUserToOrderColumns = True
        Me.DataGridViewKategoriHarga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewKategoriHarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKategoriHarga.Location = New System.Drawing.Point(9, 60)
        Me.DataGridViewKategoriHarga.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewKategoriHarga.Name = "DataGridViewKategoriHarga"
        Me.DataGridViewKategoriHarga.ReadOnly = True
        Me.DataGridViewKategoriHarga.Size = New System.Drawing.Size(568, 238)
        Me.DataGridViewKategoriHarga.TabIndex = 1
        '
        'ButtonSaveKategoriHarga
        '
        Me.ButtonSaveKategoriHarga.Location = New System.Drawing.Point(460, 22)
        Me.ButtonSaveKategoriHarga.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSaveKategoriHarga.Name = "ButtonSaveKategoriHarga"
        Me.ButtonSaveKategoriHarga.Size = New System.Drawing.Size(57, 28)
        Me.ButtonSaveKategoriHarga.TabIndex = 0
        Me.ButtonSaveKategoriHarga.Text = "+"
        Me.ButtonSaveKategoriHarga.UseVisualStyleBackColor = True
        '
        'ButtonProdukClose
        '
        Me.ButtonProdukClose.BackColor = System.Drawing.Color.PeachPuff
        Me.ButtonProdukClose.Location = New System.Drawing.Point(973, 0)
        Me.ButtonProdukClose.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonProdukClose.Name = "ButtonProdukClose"
        Me.ButtonProdukClose.Size = New System.Drawing.Size(92, 28)
        Me.ButtonProdukClose.TabIndex = 0
        Me.ButtonProdukClose.Text = "Close"
        Me.ButtonProdukClose.UseVisualStyleBackColor = False
        '
        'ButtonProdukSave
        '
        Me.ButtonProdukSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonProdukSave.Location = New System.Drawing.Point(761, 0)
        Me.ButtonProdukSave.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonProdukSave.Name = "ButtonProdukSave"
        Me.ButtonProdukSave.Size = New System.Drawing.Size(100, 28)
        Me.ButtonProdukSave.TabIndex = 2
        Me.ButtonProdukSave.Text = "Save"
        Me.ButtonProdukSave.UseVisualStyleBackColor = False
        '
        'TextBoxPencarianProduk
        '
        Me.TextBoxPencarianProduk.Location = New System.Drawing.Point(897, 0)
        Me.TextBoxPencarianProduk.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPencarianProduk.Name = "TextBoxPencarianProduk"
        Me.TextBoxPencarianProduk.Size = New System.Drawing.Size(191, 22)
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
        Me.DataGridViewBarang.Location = New System.Drawing.Point(3, 31)
        Me.DataGridViewBarang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewBarang.MultiSelect = False
        Me.DataGridViewBarang.Name = "DataGridViewBarang"
        Me.DataGridViewBarang.ReadOnly = True
        Me.DataGridViewBarang.RowTemplate.Height = 24
        Me.DataGridViewBarang.Size = New System.Drawing.Size(1088, 608)
        Me.DataGridViewBarang.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonExportExcelProduk)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.ButtonProdukKategoriHarga)
        Me.GroupBox2.Controls.Add(Me.ButtonInputBarang)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1096, 94)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PILIHAN PRODUK"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button2.Location = New System.Drawing.Point(149, 34)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 39)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Kategori Produk"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button3.Location = New System.Drawing.Point(289, 34)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 39)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Rak"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ButtonProdukKategoriHarga
        '
        Me.ButtonProdukKategoriHarga.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonProdukKategoriHarga.Location = New System.Drawing.Point(428, 34)
        Me.ButtonProdukKategoriHarga.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonProdukKategoriHarga.Name = "ButtonProdukKategoriHarga"
        Me.ButtonProdukKategoriHarga.Size = New System.Drawing.Size(133, 39)
        Me.ButtonProdukKategoriHarga.TabIndex = 5
        Me.ButtonProdukKategoriHarga.Text = "Kategori Harga"
        Me.ButtonProdukKategoriHarga.UseVisualStyleBackColor = False
        '
        'ButtonInputBarang
        '
        Me.ButtonInputBarang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonInputBarang.Location = New System.Drawing.Point(11, 34)
        Me.ButtonInputBarang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonInputBarang.Name = "ButtonInputBarang"
        Me.ButtonInputBarang.Size = New System.Drawing.Size(133, 39)
        Me.ButtonInputBarang.TabIndex = 4
        Me.ButtonInputBarang.Text = "Input Barang"
        Me.ButtonInputBarang.UseVisualStyleBackColor = False
        '
        'ButtonExportExcelProduk
        '
        Me.ButtonExportExcelProduk.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonExportExcelProduk.Location = New System.Drawing.Point(953, 34)
        Me.ButtonExportExcelProduk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonExportExcelProduk.Name = "ButtonExportExcelProduk"
        Me.ButtonExportExcelProduk.Size = New System.Drawing.Size(133, 39)
        Me.ButtonExportExcelProduk.TabIndex = 8
        Me.ButtonExportExcelProduk.Text = "Export Excel"
        Me.ButtonExportExcelProduk.UseVisualStyleBackColor = False
        '
        'FormProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 763)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBarcode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewKategoriHarga As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonSaveKategoriHarga As System.Windows.Forms.Button
    Friend WithEvents TextBoxKategoriHarga_harga As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxKategoriHarga As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonDeleteKategoriHarga As System.Windows.Forms.Button
    Friend WithEvents TextBoxKategoriHargaID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonDeleteProduk As System.Windows.Forms.Button
    Friend WithEvents TextBoxKategoriProduk As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRak As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ButtonExportExcelProduk As System.Windows.Forms.Button
End Class
