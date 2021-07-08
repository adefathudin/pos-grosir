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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PLU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategoriharga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Promosi = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.formcaribarang = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deskripsi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBoxCariBarang = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxBarang = New System.Windows.Forms.TextBox()
        Me.TextBoxQTY = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxKembali = New System.Windows.Forms.TextBox()
        Me.TextBoxUangTunai = New System.Windows.Forms.TextBox()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.TextBoxDiskon = New System.Windows.Forms.TextBox()
        Me.TextBoxTotalBelanja = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Promosi.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.formcaribarang.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PLU, Me.Column2, Me.kategoriharga, Me.Column3, Me.SubHarga})
        Me.DataGridView1.Location = New System.Drawing.Point(5, 18)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.DataGridView1.Size = New System.Drawing.Size(442, 436)
        Me.DataGridView1.TabIndex = 0
        '
        'PLU
        '
        Me.PLU.HeaderText = "PLU"
        Me.PLU.Name = "PLU"
        Me.PLU.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Deskripsi"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'kategoriharga
        '
        Me.kategoriharga.HeaderText = "Kategori"
        Me.kategoriharga.Name = "kategoriharga"
        Me.kategoriharga.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "QTY"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'SubHarga
        '
        Me.SubHarga.HeaderText = "Harga"
        Me.SubHarga.Name = "SubHarga"
        Me.SubHarga.ReadOnly = True
        '
        'Promosi
        '
        Me.Promosi.Controls.Add(Me.DataGridView2)
        Me.Promosi.Controls.Add(Me.TextBox7)
        Me.Promosi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Promosi.Location = New System.Drawing.Point(3, 12)
        Me.Promosi.Name = "Promosi"
        Me.Promosi.Size = New System.Drawing.Size(165, 461)
        Me.Promosi.TabIndex = 8
        Me.Promosi.TabStop = False
        Me.Promosi.Text = "PROMOSI"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(9, 45)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(149, 410)
        Me.DataGridView2.TabIndex = 1
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox7.Location = New System.Drawing.Point(9, 19)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(150, 20)
        Me.TextBox7.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.formcaribarang)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(174, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(452, 461)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DAFTAR TRANSAKSI"
        '
        'formcaribarang
        '
        Me.formcaribarang.Controls.Add(Me.Button4)
        Me.formcaribarang.Controls.Add(Me.DataGridView3)
        Me.formcaribarang.Controls.Add(Me.TextBoxCariBarang)
        Me.formcaribarang.Location = New System.Drawing.Point(5, 242)
        Me.formcaribarang.Margin = New System.Windows.Forms.Padding(2)
        Me.formcaribarang.Name = "formcaribarang"
        Me.formcaribarang.Padding = New System.Windows.Forms.Padding(2)
        Me.formcaribarang.Size = New System.Drawing.Size(442, 213)
        Me.formcaribarang.TabIndex = 1
        Me.formcaribarang.TabStop = False
        Me.formcaribarang.Text = "CARI BARANG"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button4.Location = New System.Drawing.Point(407, 18)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(30, 20)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Deskripsi})
        Me.DataGridView3.Location = New System.Drawing.Point(4, 41)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(433, 167)
        Me.DataGridView3.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "PLU"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'Deskripsi
        '
        Me.Deskripsi.HeaderText = "Deskripsi"
        Me.Deskripsi.Name = "Deskripsi"
        '
        'TextBoxCariBarang
        '
        Me.TextBoxCariBarang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxCariBarang.Location = New System.Drawing.Point(4, 18)
        Me.TextBoxCariBarang.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCariBarang.Name = "TextBoxCariBarang"
        Me.TextBoxCariBarang.Size = New System.Drawing.Size(399, 20)
        Me.TextBoxCariBarang.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxBarang)
        Me.GroupBox1.Controls.Add(Me.TextBoxQTY)
        Me.GroupBox1.Location = New System.Drawing.Point(174, 478)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(452, 132)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TRANSAKSI PENJUALAN"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button2.Location = New System.Drawing.Point(345, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 57)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "[F2] Cancel Sales"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button1.Location = New System.Drawing.Point(225, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 57)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "[F1] Cari Barang"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "QTY :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Barang :"
        '
        'TextBoxBarang
        '
        Me.TextBoxBarang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxBarang.Location = New System.Drawing.Point(73, 39)
        Me.TextBoxBarang.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxBarang.Name = "TextBoxBarang"
        Me.TextBoxBarang.Size = New System.Drawing.Size(130, 20)
        Me.TextBoxBarang.TabIndex = 1
        '
        'TextBoxQTY
        '
        Me.TextBoxQTY.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxQTY.Location = New System.Drawing.Point(73, 76)
        Me.TextBoxQTY.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxQTY.Name = "TextBoxQTY"
        Me.TextBoxQTY.Size = New System.Drawing.Size(130, 20)
        Me.TextBoxQTY.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(12, 479)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(149, 130)
        Me.Panel1.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 23)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 90)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tekan F1 untuk" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mencari barang" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tekan F2 untuk" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "membatalkan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pembelian"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBoxKembali)
        Me.GroupBox2.Controls.Add(Me.TextBoxUangTunai)
        Me.GroupBox2.Controls.Add(Me.TextBoxTotal)
        Me.GroupBox2.Controls.Add(Me.TextBoxDiskon)
        Me.GroupBox2.Controls.Add(Me.TextBoxTotalBelanja)
        Me.GroupBox2.Location = New System.Drawing.Point(632, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(184, 478)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PEMBAYARAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Kembali :"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(8, 385)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 57)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "SIMPAN DAN CETAK STRUK"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Uang Tunai :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Disc. :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total Belanja :"
        '
        'TextBoxKembali
        '
        Me.TextBoxKembali.Location = New System.Drawing.Point(79, 182)
        Me.TextBoxKembali.Name = "TextBoxKembali"
        Me.TextBoxKembali.ReadOnly = True
        Me.TextBoxKembali.Size = New System.Drawing.Size(101, 20)
        Me.TextBoxKembali.TabIndex = 5
        Me.TextBoxKembali.Text = "0"
        Me.TextBoxKembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxUangTunai
        '
        Me.TextBoxUangTunai.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBoxUangTunai.Location = New System.Drawing.Point(79, 146)
        Me.TextBoxUangTunai.Name = "TextBoxUangTunai"
        Me.TextBoxUangTunai.Size = New System.Drawing.Size(101, 20)
        Me.TextBoxUangTunai.TabIndex = 4
        Me.TextBoxUangTunai.Text = "0"
        Me.TextBoxUangTunai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotal.Location = New System.Drawing.Point(6, 99)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.ReadOnly = True
        Me.TextBoxTotal.Size = New System.Drawing.Size(172, 26)
        Me.TextBoxTotal.TabIndex = 3
        Me.TextBoxTotal.Text = "0"
        Me.TextBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxDiskon
        '
        Me.TextBoxDiskon.Location = New System.Drawing.Point(79, 54)
        Me.TextBoxDiskon.Name = "TextBoxDiskon"
        Me.TextBoxDiskon.ReadOnly = True
        Me.TextBoxDiskon.Size = New System.Drawing.Size(99, 20)
        Me.TextBoxDiskon.TabIndex = 1
        Me.TextBoxDiskon.Text = "0"
        Me.TextBoxDiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxTotalBelanja
        '
        Me.TextBoxTotalBelanja.Location = New System.Drawing.Point(79, 19)
        Me.TextBoxTotalBelanja.Name = "TextBoxTotalBelanja"
        Me.TextBoxTotalBelanja.ReadOnly = True
        Me.TextBoxTotalBelanja.Size = New System.Drawing.Size(99, 20)
        Me.TextBoxTotalBelanja.TabIndex = 0
        Me.TextBoxTotalBelanja.Text = "0"
        Me.TextBoxTotalBelanja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(5, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(169, 20)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(633, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(183, 101)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PELANGGAN"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox2.Location = New System.Drawing.Point(5, 66)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(169, 20)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.Text = "0"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FormKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(819, 620)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Promosi)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormKasir"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormKasir"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Promosi.ResumeLayout(False)
        Me.Promosi.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.formcaribarang.ResumeLayout(False)
        Me.formcaribarang.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Promosi As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxBarang As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PLU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kategoriharga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents formcaribarang As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deskripsi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBoxCariBarang As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
