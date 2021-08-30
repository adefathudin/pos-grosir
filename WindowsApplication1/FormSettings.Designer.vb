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
        Me.ButtonUserSave = New System.Windows.Forms.Button()
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
        Me.GroupBox1.Location = New System.Drawing.Point(11, 105)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(547, 504)
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
        Me.DataGridViewUsers.Location = New System.Drawing.Point(6, 25)
        Me.DataGridViewUsers.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridViewUsers.MultiSelect = False
        Me.DataGridViewUsers.Name = "DataGridViewUsers"
        Me.DataGridViewUsers.ReadOnly = True
        Me.DataGridViewUsers.RowTemplate.Height = 24
        Me.DataGridViewUsers.Size = New System.Drawing.Size(536, 498)
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
        Me.PanelDetailCustomer.Controls.Add(Me.ButtonUserSave)
        Me.PanelDetailCustomer.Location = New System.Drawing.Point(6, 25)
        Me.PanelDetailCustomer.Name = "PanelDetailCustomer"
        Me.PanelDetailCustomer.Size = New System.Drawing.Size(247, 473)
        Me.PanelDetailCustomer.TabIndex = 4
        '
        'TextBoxNamaUser
        '
        Me.TextBoxNamaUser.Location = New System.Drawing.Point(68, 125)
        Me.TextBoxNamaUser.Name = "TextBoxNamaUser"
        Me.TextBoxNamaUser.Size = New System.Drawing.Size(151, 20)
        Me.TextBoxNamaUser.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Level"
        '
        'ComboBoxLevel
        '
        Me.ComboBoxLevel.FormattingEnabled = True
        Me.ComboBoxLevel.Items.AddRange(New Object() {"kasir", "admin"})
        Me.ComboBoxLevel.Location = New System.Drawing.Point(68, 169)
        Me.ComboBoxLevel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxLevel.Name = "ComboBoxLevel"
        Me.ComboBoxLevel.Size = New System.Drawing.Size(151, 21)
        Me.ComboBoxLevel.TabIndex = 26
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(143, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Linen
        Me.Button1.Location = New System.Drawing.Point(68, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 50)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "NIK"
        '
        'TextBoxNIK
        '
        Me.TextBoxNIK.Location = New System.Drawing.Point(68, 80)
        Me.TextBoxNIK.Name = "TextBoxNIK"
        Me.TextBoxNIK.ReadOnly = True
        Me.TextBoxNIK.Size = New System.Drawing.Size(151, 20)
        Me.TextBoxNIK.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nama"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(68, 213)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(151, 20)
        Me.TextBoxPassword.TabIndex = 4
        '
        'ButtonUserSave
        '
        Me.ButtonUserSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonUserSave.Location = New System.Drawing.Point(143, 260)
        Me.ButtonUserSave.Name = "ButtonUserSave"
        Me.ButtonUserSave.Size = New System.Drawing.Size(75, 50)
        Me.ButtonUserSave.TabIndex = 2
        Me.ButtonUserSave.Text = "Save"
        Me.ButtonUserSave.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PanelDetailCustomer)
        Me.GroupBox3.Location = New System.Drawing.Point(563, 105)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(259, 504)
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(810, 74)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Identitas Toko"
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(729, 40)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSimpan.TabIndex = 6
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(347, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Alamat"
        '
        'TextBoxAlamat
        '
        Me.TextBoxAlamat.Location = New System.Drawing.Point(347, 42)
        Me.TextBoxAlamat.Name = "TextBoxAlamat"
        Me.TextBoxAlamat.Size = New System.Drawing.Size(376, 20)
        Me.TextBoxAlamat.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "No. Telpon"
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Location = New System.Drawing.Point(6, 26)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(63, 13)
        Me.Nama.TabIndex = 2
        Me.Nama.Text = "Nama Toko"
        '
        'TextBoxNoTelepon
        '
        Me.TextBoxNoTelepon.Location = New System.Drawing.Point(191, 42)
        Me.TextBoxNoTelepon.Name = "TextBoxNoTelepon"
        Me.TextBoxNoTelepon.Size = New System.Drawing.Size(150, 20)
        Me.TextBoxNoTelepon.TabIndex = 1
        '
        'TextBoxNamaToko
        '
        Me.TextBoxNamaToko.Location = New System.Drawing.Point(9, 42)
        Me.TextBoxNamaToko.Name = "TextBoxNamaToko"
        Me.TextBoxNamaToko.Size = New System.Drawing.Size(176, 20)
        Me.TextBoxNamaToko.TabIndex = 0
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 620)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents ButtonUserSave As System.Windows.Forms.Button
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
