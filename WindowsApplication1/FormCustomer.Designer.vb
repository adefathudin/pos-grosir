<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomer
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
        Me.LabelTotalItem = New System.Windows.Forms.Label()
        Me.PanelDetailProduk = New System.Windows.Forms.Panel()
        Me.GroupBoxDetailProduk = New System.Windows.Forms.GroupBox()
        Me.ComboBoxProdukRak = New System.Windows.Forms.ComboBox()
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.ButtonProdukClose = New System.Windows.Forms.Button()
        Me.ButtonProdukSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxProdukHargaJual = New System.Windows.Forms.TextBox()
        Me.TextBoxProdukHargaBeli = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxProdukStok = New System.Windows.Forms.TextBox()
        Me.TextBoxProdukDesc = New System.Windows.Forms.TextBox()
        Me.TextBoxProdukPLU = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxPencarianProduk = New System.Windows.Forms.TextBox()
        Me.DataGridViewBarang = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonProdukKategoriHarga = New System.Windows.Forms.Button()
        Me.ButtonInputBarang = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.PanelDetailProduk.SuspendLayout()
        Me.GroupBoxDetailProduk.SuspendLayout()
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
        Me.PanelDetailProduk.Controls.Add(Me.ComboBox1)
        Me.PanelDetailProduk.Controls.Add(Me.Label6)
        Me.PanelDetailProduk.Location = New System.Drawing.Point(1, 118)
        Me.PanelDetailProduk.Name = "PanelDetailProduk"
        Me.PanelDetailProduk.Size = New System.Drawing.Size(815, 400)
        Me.PanelDetailProduk.TabIndex = 4
        Me.PanelDetailProduk.Visible = False
        '
        'GroupBoxDetailProduk
        '
        Me.GroupBoxDetailProduk.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBoxDetailProduk.Controls.Add(Me.ComboBoxProdukRak)
        Me.GroupBoxDetailProduk.Controls.Add(Me.ComboBoxStatus)
        Me.GroupBoxDetailProduk.Controls.Add(Me.ButtonProdukClose)
        Me.GroupBoxDetailProduk.Controls.Add(Me.ButtonProdukSave)
        Me.GroupBoxDetailProduk.Controls.Add(Me.Label5)
        Me.GroupBoxDetailProduk.Controls.Add(Me.Label7)
        Me.GroupBoxDetailProduk.Controls.Add(Me.Label8)
        Me.GroupBoxDetailProduk.Controls.Add(Me.TextBoxProdukHargaJual)
        Me.GroupBoxDetailProduk.Controls.Add(Me.TextBoxProdukHargaBeli)
        Me.GroupBoxDetailProduk.Controls.Add(Me.Label4)
        Me.GroupBoxDetailProduk.Controls.Add(Me.Label3)
        Me.GroupBoxDetailProduk.Controls.Add(Me.Label2)
        Me.GroupBoxDetailProduk.Controls.Add(Me.Label1)
        Me.GroupBoxDetailProduk.Controls.Add(Me.TextBoxProdukStok)
        Me.GroupBoxDetailProduk.Controls.Add(Me.TextBoxProdukDesc)
        Me.GroupBoxDetailProduk.Controls.Add(Me.TextBoxProdukPLU)
        Me.GroupBoxDetailProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDetailProduk.Location = New System.Drawing.Point(3, 15)
        Me.GroupBoxDetailProduk.Name = "GroupBoxDetailProduk"
        Me.GroupBoxDetailProduk.Size = New System.Drawing.Size(805, 164)
        Me.GroupBoxDetailProduk.TabIndex = 0
        Me.GroupBoxDetailProduk.TabStop = False
        Me.GroupBoxDetailProduk.Text = "DETAIL PRODUK"
        '
        'ComboBoxProdukRak
        '
        Me.ComboBoxProdukRak.FormattingEnabled = True
        Me.ComboBoxProdukRak.Items.AddRange(New Object() {"Aktif", "Tidak Aktif"})
        Me.ComboBoxProdukRak.Location = New System.Drawing.Point(90, 87)
        Me.ComboBoxProdukRak.Name = "ComboBoxProdukRak"
        Me.ComboBoxProdukRak.Size = New System.Drawing.Size(260, 21)
        Me.ComboBoxProdukRak.TabIndex = 21
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.DisplayMember = "Aktif"
        Me.ComboBoxStatus.FormattingEnabled = True
        Me.ComboBoxStatus.Items.AddRange(New Object() {"Y", "N"})
        Me.ComboBoxStatus.Location = New System.Drawing.Point(694, 84)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(105, 21)
        Me.ComboBoxStatus.TabIndex = 20
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
        Me.ButtonProdukSave.Location = New System.Drawing.Point(649, 0)
        Me.ButtonProdukSave.Name = "ButtonProdukSave"
        Me.ButtonProdukSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonProdukSave.TabIndex = 2
        Me.ButtonProdukSave.Text = "Save"
        Me.ButtonProdukSave.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(651, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(425, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Harga Jual"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(425, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Harga Beli"
        '
        'TextBoxProdukHargaJual
        '
        Me.TextBoxProdukHargaJual.Location = New System.Drawing.Point(539, 58)
        Me.TextBoxProdukHargaJual.Name = "TextBoxProdukHargaJual"
        Me.TextBoxProdukHargaJual.Size = New System.Drawing.Size(260, 20)
        Me.TextBoxProdukHargaJual.TabIndex = 12
        '
        'TextBoxProdukHargaBeli
        '
        Me.TextBoxProdukHargaBeli.Location = New System.Drawing.Point(539, 32)
        Me.TextBoxProdukHargaBeli.Name = "TextBoxProdukHargaBeli"
        Me.TextBoxProdukHargaBeli.Size = New System.Drawing.Size(260, 20)
        Me.TextBoxProdukHargaBeli.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Rak"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Stok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Deskripsi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "PLU"
        '
        'TextBoxProdukStok
        '
        Me.TextBoxProdukStok.Location = New System.Drawing.Point(539, 84)
        Me.TextBoxProdukStok.Name = "TextBoxProdukStok"
        Me.TextBoxProdukStok.Size = New System.Drawing.Size(105, 20)
        Me.TextBoxProdukStok.TabIndex = 5
        '
        'TextBoxProdukDesc
        '
        Me.TextBoxProdukDesc.Location = New System.Drawing.Point(90, 58)
        Me.TextBoxProdukDesc.Name = "TextBoxProdukDesc"
        Me.TextBoxProdukDesc.Size = New System.Drawing.Size(260, 20)
        Me.TextBoxProdukDesc.TabIndex = 4
        '
        'TextBoxProdukPLU
        '
        Me.TextBoxProdukPLU.Location = New System.Drawing.Point(90, 32)
        Me.TextBoxProdukPLU.Name = "TextBoxProdukPLU"
        Me.TextBoxProdukPLU.Size = New System.Drawing.Size(260, 20)
        Me.TextBoxProdukPLU.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(338, 258)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(199, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Kategori Harga Jual"
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button3.Location = New System.Drawing.Point(256, 28)
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
        Me.ButtonProdukKategoriHarga.Location = New System.Drawing.Point(130, 28)
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
        'FormCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 620)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormCustomer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelDetailProduk.ResumeLayout(False)
        Me.PanelDetailProduk.PerformLayout()
        Me.GroupBoxDetailProduk.ResumeLayout(False)
        Me.GroupBoxDetailProduk.PerformLayout()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxProdukHargaJual As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxProdukHargaBeli As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxStatus As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxProdukRak As System.Windows.Forms.ComboBox
End Class
