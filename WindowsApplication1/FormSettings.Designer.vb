<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettings
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
        Me.DataGridViewUsers = New System.Windows.Forms.DataGridView()
        Me.PanelDetailCustomer = New System.Windows.Forms.Panel()
        Me.TextBoxNamaUser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxLevel = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxNIK = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ButtonProdukSave = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxAlamat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.Label()
        Me.TextBoxNoTelepon = New System.Windows.Forms.TextBox()
        Me.TextBoxNamaToko = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetailCustomer.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridViewUsers)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 129)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(729, 620)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Users"
        '
        'DataGridViewUsers
        '
        Me.DataGridViewUsers.AllowUserToAddRows = False
        Me.DataGridViewUsers.AllowUserToDeleteRows = False
        Me.DataGridViewUsers.AllowUserToResizeColumns = False
        Me.DataGridViewUsers.AllowUserToResizeRows = False
        Me.DataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewUsers.Location = New System.Drawing.Point(8, 31)
        Me.DataGridViewUsers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewUsers.MultiSelect = False
        Me.DataGridViewUsers.Name = "DataGridViewUsers"
        Me.DataGridViewUsers.ReadOnly = True
        Me.DataGridViewUsers.RowTemplate.Height = 24
        Me.DataGridViewUsers.Size = New System.Drawing.Size(715, 613)
        Me.DataGridViewUsers.TabIndex = 2
        '
        'PanelDetailCustomer
        '
        Me.PanelDetailCustomer.BackColor = System.Drawing.Color.BurlyWood
        Me.PanelDetailCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelDetailCustomer.Controls.Add(Me.TextBoxNamaUser)
        Me.PanelDetailCustomer.Controls.Add(Me.Label4)
        Me.PanelDetailCustomer.Controls.Add(Me.ComboBoxLevel)
        Me.PanelDetailCustomer.Controls.Add(Me.Button2)
        Me.PanelDetailCustomer.Controls.Add(Me.Button1)
        Me.PanelDetailCustomer.Controls.Add(Me.Label9)
        Me.PanelDetailCustomer.Controls.Add(Me.TextBoxNIK)
        Me.PanelDetailCustomer.Controls.Add(Me.Label2)
        Me.PanelDetailCustomer.Controls.Add(Me.Label1)
        Me.PanelDetailCustomer.Controls.Add(Me.TextBoxPassword)
        Me.PanelDetailCustomer.Controls.Add(Me.ButtonProdukSave)
        Me.PanelDetailCustomer.Location = New System.Drawing.Point(8, 31)
        Me.PanelDetailCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDetailCustomer.Name = "PanelDetailCustomer"
        Me.PanelDetailCustomer.Size = New System.Drawing.Size(328, 581)
        Me.PanelDetailCustomer.TabIndex = 4
        '
        'TextBoxNamaUser
        '
        Me.TextBoxNamaUser.Location = New System.Drawing.Point(91, 154)
        Me.TextBoxNamaUser.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNamaUser.Name = "TextBoxNamaUser"
        Me.TextBoxNamaUser.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxNamaUser.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 211)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Level"
        '
        'ComboBoxLevel
        '
        Me.ComboBoxLevel.FormattingEnabled = True
        Me.ComboBoxLevel.Items.AddRange(New Object() {"kasir", "admin"})
        Me.ComboBoxLevel.Location = New System.Drawing.Point(91, 208)
        Me.ComboBoxLevel.Name = "ComboBoxLevel"
        Me.ComboBoxLevel.Size = New System.Drawing.Size(200, 24)
        Me.ComboBoxLevel.TabIndex = 26
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(191, 32)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Linen
        Me.Button1.Location = New System.Drawing.Point(91, 320)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 62)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(54, 101)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "NIK"
        '
        'TextBoxNIK
        '
        Me.TextBoxNIK.Location = New System.Drawing.Point(91, 98)
        Me.TextBoxNIK.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNIK.Name = "TextBoxNIK"
        Me.TextBoxNIK.ReadOnly = True
        Me.TextBoxNIK.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxNIK.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 265)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 157)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nama"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(91, 262)
        Me.TextBoxPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxPassword.TabIndex = 4
        '
        'ButtonProdukSave
        '
        Me.ButtonProdukSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonProdukSave.Location = New System.Drawing.Point(191, 320)
        Me.ButtonProdukSave.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonProdukSave.Name = "ButtonProdukSave"
        Me.ButtonProdukSave.Size = New System.Drawing.Size(100, 62)
        Me.ButtonProdukSave.TabIndex = 2
        Me.ButtonProdukSave.Text = "Save"
        Me.ButtonProdukSave.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PanelDetailCustomer)
        Me.GroupBox3.Location = New System.Drawing.Point(751, 129)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(345, 620)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Form Tambah / Edit Customer"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonSimpan)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBoxAlamat)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Nama)
        Me.GroupBox2.Controls.Add(Me.TextBoxNoTelepon)
        Me.GroupBox2.Controls.Add(Me.TextBoxNamaToko)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1080, 91)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Identitas Toko"
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(972, 49)
        Me.ButtonSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(100, 28)
        Me.ButtonSimpan.TabIndex = 6
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(463, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Alamat"
        '
        'TextBoxAlamat
        '
        Me.TextBoxAlamat.Location = New System.Drawing.Point(463, 52)
        Me.TextBoxAlamat.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxAlamat.Name = "TextBoxAlamat"
        Me.TextBoxAlamat.Size = New System.Drawing.Size(500, 22)
        Me.TextBoxAlamat.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "No. Telpon"
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Location = New System.Drawing.Point(8, 32)
        Me.Nama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(81, 17)
        Me.Nama.TabIndex = 2
        Me.Nama.Text = "Nama Toko"
        '
        'TextBoxNoTelepon
        '
        Me.TextBoxNoTelepon.Location = New System.Drawing.Point(255, 52)
        Me.TextBoxNoTelepon.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNoTelepon.Name = "TextBoxNoTelepon"
        Me.TextBoxNoTelepon.Size = New System.Drawing.Size(199, 22)
        Me.TextBoxNoTelepon.TabIndex = 1
        '
        'TextBoxNamaToko
        '
        Me.TextBoxNamaToko.Location = New System.Drawing.Point(12, 52)
        Me.TextBoxNamaToko.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNamaToko.Name = "TextBoxNamaToko"
        Me.TextBoxNamaToko.Size = New System.Drawing.Size(233, 22)
        Me.TextBoxNamaToko.TabIndex = 0
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1112, 763)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormSettings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridViewUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetailCustomer.ResumeLayout(False)
        Me.PanelDetailCustomer.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewUsers As System.Windows.Forms.DataGridView
    Friend WithEvents PanelDetailCustomer As System.Windows.Forms.Panel
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents ButtonProdukSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNIK As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Nama As System.Windows.Forms.Label
    Friend WithEvents TextBoxNoTelepon As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNamaToko As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNamaUser As System.Windows.Forms.TextBox
End Class
