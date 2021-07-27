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
        Me.TextBoxPencarianCustomer = New System.Windows.Forms.TextBox()
        Me.TextBoxPencarianProduk = New System.Windows.Forms.TextBox()
        Me.DataGridViewCustomer = New System.Windows.Forms.DataGridView()
        Me.LabelTotalItem = New System.Windows.Forms.Label()
        Me.PanelDetailCustomer = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxIDCustomer = New System.Windows.Forms.TextBox()
        Me.ComboBoxKategoriHarga = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNomorHP = New System.Windows.Forms.TextBox()
        Me.TextBoxNamaLengkap = New System.Windows.Forms.TextBox()
        Me.ButtonProdukSave = New System.Windows.Forms.Button()
        Me.TextBoxAlamat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetailCustomer.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxPencarianCustomer)
        Me.GroupBox1.Controls.Add(Me.TextBoxPencarianProduk)
        Me.GroupBox1.Controls.Add(Me.DataGridViewCustomer)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 80)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(421, 529)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Customer"
        '
        'TextBoxPencarianCustomer
        '
        Me.TextBoxPencarianCustomer.Location = New System.Drawing.Point(275, 0)
        Me.TextBoxPencarianCustomer.Name = "TextBoxPencarianCustomer"
        Me.TextBoxPencarianCustomer.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxPencarianCustomer.TabIndex = 6
        '
        'TextBoxPencarianProduk
        '
        Me.TextBoxPencarianProduk.Location = New System.Drawing.Point(673, 0)
        Me.TextBoxPencarianProduk.Name = "TextBoxPencarianProduk"
        Me.TextBoxPencarianProduk.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxPencarianProduk.TabIndex = 4
        Me.TextBoxPencarianProduk.WordWrap = False
        '
        'DataGridViewCustomer
        '
        Me.DataGridViewCustomer.AllowUserToAddRows = False
        Me.DataGridViewCustomer.AllowUserToDeleteRows = False
        Me.DataGridViewCustomer.AllowUserToResizeColumns = False
        Me.DataGridViewCustomer.AllowUserToResizeRows = False
        Me.DataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomer.Location = New System.Drawing.Point(6, 25)
        Me.DataGridViewCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewCustomer.MultiSelect = False
        Me.DataGridViewCustomer.Name = "DataGridViewCustomer"
        Me.DataGridViewCustomer.ReadOnly = True
        Me.DataGridViewCustomer.RowTemplate.Height = 24
        Me.DataGridViewCustomer.Size = New System.Drawing.Size(411, 498)
        Me.DataGridViewCustomer.TabIndex = 2
        '
        'LabelTotalItem
        '
        Me.LabelTotalItem.AutoSize = True
        Me.LabelTotalItem.Location = New System.Drawing.Point(91, 80)
        Me.LabelTotalItem.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTotalItem.Name = "LabelTotalItem"
        Me.LabelTotalItem.Size = New System.Drawing.Size(77, 13)
        Me.LabelTotalItem.TabIndex = 5
        Me.LabelTotalItem.Text = "LabelTotalItem"
        '
        'PanelDetailCustomer
        '
        Me.PanelDetailCustomer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PanelDetailCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelDetailCustomer.Controls.Add(Me.Button2)
        Me.PanelDetailCustomer.Controls.Add(Me.Button1)
        Me.PanelDetailCustomer.Controls.Add(Me.Label9)
        Me.PanelDetailCustomer.Controls.Add(Me.TextBoxIDCustomer)
        Me.PanelDetailCustomer.Controls.Add(Me.ComboBoxKategoriHarga)
        Me.PanelDetailCustomer.Controls.Add(Me.Label4)
        Me.PanelDetailCustomer.Controls.Add(Me.Label2)
        Me.PanelDetailCustomer.Controls.Add(Me.Label1)
        Me.PanelDetailCustomer.Controls.Add(Me.TextBoxNomorHP)
        Me.PanelDetailCustomer.Controls.Add(Me.TextBoxNamaLengkap)
        Me.PanelDetailCustomer.Controls.Add(Me.ButtonProdukSave)
        Me.PanelDetailCustomer.Controls.Add(Me.TextBoxAlamat)
        Me.PanelDetailCustomer.Controls.Add(Me.Label8)
        Me.PanelDetailCustomer.Location = New System.Drawing.Point(6, 25)
        Me.PanelDetailCustomer.Name = "PanelDetailCustomer"
        Me.PanelDetailCustomer.Size = New System.Drawing.Size(373, 498)
        Me.PanelDetailCustomer.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(260, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Linen
        Me.Button1.Location = New System.Drawing.Point(108, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 50)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(81, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "ID"
        '
        'TextBoxIDCustomer
        '
        Me.TextBoxIDCustomer.Location = New System.Drawing.Point(108, 58)
        Me.TextBoxIDCustomer.Name = "TextBoxIDCustomer"
        Me.TextBoxIDCustomer.ReadOnly = True
        Me.TextBoxIDCustomer.Size = New System.Drawing.Size(227, 20)
        Me.TextBoxIDCustomer.TabIndex = 22
        '
        'ComboBoxKategoriHarga
        '
        Me.ComboBoxKategoriHarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxKategoriHarga.FormattingEnabled = True
        Me.ComboBoxKategoriHarga.Items.AddRange(New Object() {"Aktif", "Tidak Aktif"})
        Me.ComboBoxKategoriHarga.Location = New System.Drawing.Point(108, 336)
        Me.ComboBoxKategoriHarga.Name = "ComboBoxKategoriHarga"
        Me.ComboBoxKategoriHarga.Size = New System.Drawing.Size(227, 21)
        Me.ComboBoxKategoriHarga.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nomor HP"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nama Lengkap"
        '
        'TextBoxNomorHP
        '
        Me.TextBoxNomorHP.Location = New System.Drawing.Point(108, 140)
        Me.TextBoxNomorHP.Name = "TextBoxNomorHP"
        Me.TextBoxNomorHP.Size = New System.Drawing.Size(227, 20)
        Me.TextBoxNomorHP.TabIndex = 4
        '
        'TextBoxNamaLengkap
        '
        Me.TextBoxNamaLengkap.Location = New System.Drawing.Point(108, 98)
        Me.TextBoxNamaLengkap.Name = "TextBoxNamaLengkap"
        Me.TextBoxNamaLengkap.Size = New System.Drawing.Size(227, 20)
        Me.TextBoxNamaLengkap.TabIndex = 3
        '
        'ButtonProdukSave
        '
        Me.ButtonProdukSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonProdukSave.Location = New System.Drawing.Point(243, 391)
        Me.ButtonProdukSave.Name = "ButtonProdukSave"
        Me.ButtonProdukSave.Size = New System.Drawing.Size(92, 50)
        Me.ButtonProdukSave.TabIndex = 2
        Me.ButtonProdukSave.Text = "Save"
        Me.ButtonProdukSave.UseVisualStyleBackColor = False
        '
        'TextBoxAlamat
        '
        Me.TextBoxAlamat.Location = New System.Drawing.Point(108, 177)
        Me.TextBoxAlamat.Multiline = True
        Me.TextBoxAlamat.Name = "TextBoxAlamat"
        Me.TextBoxAlamat.Size = New System.Drawing.Size(227, 138)
        Me.TextBoxAlamat.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 339)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Kategori Harga"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PanelDetailCustomer)
        Me.GroupBox3.Location = New System.Drawing.Point(437, 80)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(385, 529)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Form Tambah / Edit Customer"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 52)
        Me.Panel1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(318, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Form Customer"
        '
        'FormCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 620)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelTotalItem)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormCustomer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetailCustomer.ResumeLayout(False)
        Me.PanelDetailCustomer.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents LabelTotalItem As System.Windows.Forms.Label
    Friend WithEvents TextBoxPencarianProduk As System.Windows.Forms.TextBox
    Friend WithEvents PanelDetailCustomer As System.Windows.Forms.Panel
    Friend WithEvents TextBoxNomorHP As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNamaLengkap As System.Windows.Forms.TextBox
    Friend WithEvents ButtonProdukSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAlamat As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxKategoriHarga As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxIDCustomer As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPencarianCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
