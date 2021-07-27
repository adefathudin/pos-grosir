<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POSMAIN
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POSMAIN))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelStation = New System.Windows.Forms.Label()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblversi = New System.Windows.Forms.Label()
        Me.GroupBoxLogin = New System.Windows.Forms.GroupBox()
        Me.TextBoxLoginUsername = New System.Windows.Forms.TextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.TextBoxLoginPassword = New System.Windows.Forms.TextBox()
        Me.lbljam = New System.Windows.Forms.Label()
        Me.GroupBoxMenu = New System.Windows.Forms.GroupBox()
        Me.ButtonCustomer = New System.Windows.Forms.Button()
        Me.btnlaporan = New System.Windows.Forms.Button()
        Me.btnkasir = New System.Windows.Forms.Button()
        Me.btnproduk = New System.Windows.Forms.Button()
        Me.btnpembelian = New System.Windows.Forms.Button()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.PanelIdentitas = New System.Windows.Forms.Panel()
        Me.LabelSubToko = New System.Windows.Forms.Label()
        Me.LabelToko = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxLogin.SuspendLayout()
        Me.GroupBoxMenu.SuspendLayout()
        Me.PanelIdentitas.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.GroupBoxLogin)
        Me.PanelMenu.Controls.Add(Me.lbljam)
        Me.PanelMenu.Controls.Add(Me.GroupBoxMenu)
        Me.PanelMenu.Controls.Add(Me.lbldate)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(178, 729)
        Me.PanelMenu.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.LabelStation)
        Me.Panel1.Controls.Add(Me.LabelUser)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblversi)
        Me.Panel1.Location = New System.Drawing.Point(9, 640)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(163, 77)
        Me.Panel1.TabIndex = 12
        '
        'LabelStation
        '
        Me.LabelStation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelStation.AutoSize = True
        Me.LabelStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelStation.Location = New System.Drawing.Point(63, 30)
        Me.LabelStation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelStation.Name = "LabelStation"
        Me.LabelStation.Size = New System.Drawing.Size(21, 15)
        Me.LabelStation.TabIndex = 11
        Me.LabelStation.Text = "01"
        Me.LabelStation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelUser
        '
        Me.LabelUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelUser.AutoSize = True
        Me.LabelUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelUser.Location = New System.Drawing.Point(6, 8)
        Me.LabelUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(64, 15)
        Me.LabelUser.TabIndex = 10
        Me.LabelUser.Text = "LabelUser"
        Me.LabelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(5, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Station : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblversi
        '
        Me.lblversi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblversi.AutoSize = True
        Me.lblversi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblversi.Location = New System.Drawing.Point(5, 56)
        Me.lblversi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblversi.Name = "lblversi"
        Me.lblversi.Size = New System.Drawing.Size(97, 13)
        Me.lblversi.TabIndex = 9
        Me.lblversi.Text = "POSMain v.1.0.1.1"
        Me.lblversi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBoxLogin
        '
        Me.GroupBoxLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLogin.Controls.Add(Me.TextBoxLoginUsername)
        Me.GroupBoxLogin.Controls.Add(Me.ButtonLogin)
        Me.GroupBoxLogin.Controls.Add(Me.TextBoxLoginPassword)
        Me.GroupBoxLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBoxLogin.Location = New System.Drawing.Point(9, 480)
        Me.GroupBoxLogin.Name = "GroupBoxLogin"
        Me.GroupBoxLogin.Size = New System.Drawing.Size(163, 131)
        Me.GroupBoxLogin.TabIndex = 9
        Me.GroupBoxLogin.TabStop = False
        Me.GroupBoxLogin.Text = "Login"
        '
        'TextBoxLoginUsername
        '
        Me.TextBoxLoginUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLoginUsername.Location = New System.Drawing.Point(9, 30)
        Me.TextBoxLoginUsername.Name = "TextBoxLoginUsername"
        Me.TextBoxLoginUsername.Size = New System.Drawing.Size(147, 26)
        Me.TextBoxLoginUsername.TabIndex = 0
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogin.Location = New System.Drawing.Point(105, 94)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(51, 27)
        Me.ButtonLogin.TabIndex = 2
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'TextBoxLoginPassword
        '
        Me.TextBoxLoginPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLoginPassword.Location = New System.Drawing.Point(9, 62)
        Me.TextBoxLoginPassword.Name = "TextBoxLoginPassword"
        Me.TextBoxLoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxLoginPassword.Size = New System.Drawing.Size(147, 26)
        Me.TextBoxLoginPassword.TabIndex = 1
        '
        'lbljam
        '
        Me.lbljam.AutoSize = True
        Me.lbljam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljam.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbljam.Location = New System.Drawing.Point(5, 36)
        Me.lbljam.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbljam.Name = "lbljam"
        Me.lbljam.Size = New System.Drawing.Size(59, 24)
        Me.lbljam.TabIndex = 6
        Me.lbljam.Text = "lbljam"
        Me.lbljam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBoxMenu
        '
        Me.GroupBoxMenu.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBoxMenu.Controls.Add(Me.ButtonCustomer)
        Me.GroupBoxMenu.Controls.Add(Me.btnlaporan)
        Me.GroupBoxMenu.Controls.Add(Me.btnkasir)
        Me.GroupBoxMenu.Controls.Add(Me.btnproduk)
        Me.GroupBoxMenu.Controls.Add(Me.btnpembelian)
        Me.GroupBoxMenu.Location = New System.Drawing.Point(9, 63)
        Me.GroupBoxMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxMenu.Name = "GroupBoxMenu"
        Me.GroupBoxMenu.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxMenu.Size = New System.Drawing.Size(163, 295)
        Me.GroupBoxMenu.TabIndex = 8
        Me.GroupBoxMenu.TabStop = False
        Me.GroupBoxMenu.Visible = False
        '
        'ButtonCustomer
        '
        Me.ButtonCustomer.BackColor = System.Drawing.Color.LightCyan
        Me.ButtonCustomer.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCustomer.Image = CType(resources.GetObject("ButtonCustomer.Image"), System.Drawing.Image)
        Me.ButtonCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCustomer.Location = New System.Drawing.Point(9, 187)
        Me.ButtonCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCustomer.Name = "ButtonCustomer"
        Me.ButtonCustomer.Size = New System.Drawing.Size(147, 37)
        Me.ButtonCustomer.TabIndex = 13
        Me.ButtonCustomer.Text = "CUSTOMER"
        Me.ButtonCustomer.UseVisualStyleBackColor = False
        '
        'btnlaporan
        '
        Me.btnlaporan.BackColor = System.Drawing.Color.LightCyan
        Me.btnlaporan.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlaporan.Image = CType(resources.GetObject("btnlaporan.Image"), System.Drawing.Image)
        Me.btnlaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlaporan.Location = New System.Drawing.Point(9, 241)
        Me.btnlaporan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnlaporan.Name = "btnlaporan"
        Me.btnlaporan.Size = New System.Drawing.Size(147, 37)
        Me.btnlaporan.TabIndex = 12
        Me.btnlaporan.Text = "LAPORAN"
        Me.btnlaporan.UseVisualStyleBackColor = False
        '
        'btnkasir
        '
        Me.btnkasir.BackColor = System.Drawing.Color.LightCyan
        Me.btnkasir.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkasir.Image = CType(resources.GetObject("btnkasir.Image"), System.Drawing.Image)
        Me.btnkasir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkasir.Location = New System.Drawing.Point(9, 17)
        Me.btnkasir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnkasir.Name = "btnkasir"
        Me.btnkasir.Size = New System.Drawing.Size(147, 37)
        Me.btnkasir.TabIndex = 9
        Me.btnkasir.Text = "KASIR"
        Me.btnkasir.UseVisualStyleBackColor = False
        '
        'btnproduk
        '
        Me.btnproduk.BackColor = System.Drawing.Color.LightCyan
        Me.btnproduk.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproduk.Image = CType(resources.GetObject("btnproduk.Image"), System.Drawing.Image)
        Me.btnproduk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnproduk.Location = New System.Drawing.Point(9, 131)
        Me.btnproduk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnproduk.Name = "btnproduk"
        Me.btnproduk.Size = New System.Drawing.Size(147, 37)
        Me.btnproduk.TabIndex = 11
        Me.btnproduk.Text = "PRODUK"
        Me.btnproduk.UseVisualStyleBackColor = False
        '
        'btnpembelian
        '
        Me.btnpembelian.BackColor = System.Drawing.Color.LightCyan
        Me.btnpembelian.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpembelian.Image = CType(resources.GetObject("btnpembelian.Image"), System.Drawing.Image)
        Me.btnpembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpembelian.Location = New System.Drawing.Point(9, 75)
        Me.btnpembelian.Margin = New System.Windows.Forms.Padding(2)
        Me.btnpembelian.Name = "btnpembelian"
        Me.btnpembelian.Size = New System.Drawing.Size(147, 37)
        Me.btnpembelian.TabIndex = 10
        Me.btnpembelian.Text = "PEMBELIAN"
        Me.btnpembelian.UseVisualStyleBackColor = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldate.Location = New System.Drawing.Point(5, 9)
        Me.lbldate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(65, 24)
        Me.lbldate.TabIndex = 7
        Me.lbldate.Text = "lbldate"
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelIdentitas
        '
        Me.PanelIdentitas.BackColor = System.Drawing.Color.CornflowerBlue
        Me.PanelIdentitas.Controls.Add(Me.LabelSubToko)
        Me.PanelIdentitas.Controls.Add(Me.LabelToko)
        Me.PanelIdentitas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelIdentitas.Location = New System.Drawing.Point(178, 0)
        Me.PanelIdentitas.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelIdentitas.Name = "PanelIdentitas"
        Me.PanelIdentitas.Size = New System.Drawing.Size(830, 70)
        Me.PanelIdentitas.TabIndex = 4
        Me.PanelIdentitas.Visible = False
        '
        'LabelSubToko
        '
        Me.LabelSubToko.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelSubToko.AutoSize = True
        Me.LabelSubToko.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSubToko.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelSubToko.Location = New System.Drawing.Point(5, 36)
        Me.LabelSubToko.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSubToko.Name = "LabelSubToko"
        Me.LabelSubToko.Size = New System.Drawing.Size(112, 20)
        Me.LabelSubToko.TabIndex = 9
        Me.LabelSubToko.Text = "LabelSubToko"
        Me.LabelSubToko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelToko
        '
        Me.LabelToko.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelToko.AutoSize = True
        Me.LabelToko.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelToko.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelToko.Location = New System.Drawing.Point(2, 12)
        Me.LabelToko.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelToko.Name = "LabelToko"
        Me.LabelToko.Size = New System.Drawing.Size(113, 25)
        Me.LabelToko.TabIndex = 9
        Me.LabelToko.Text = "LabelToko"
        Me.LabelToko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'POSMAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.PanelIdentitas)
        Me.Controls.Add(Me.PanelMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "POSMAIN"
        Me.Text = "POSMAIN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBoxLogin.ResumeLayout(False)
        Me.GroupBoxLogin.PerformLayout()
        Me.GroupBoxMenu.ResumeLayout(False)
        Me.PanelIdentitas.ResumeLayout(False)
        Me.PanelIdentitas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents PanelIdentitas As System.Windows.Forms.Panel
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lbljam As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBoxMenu As System.Windows.Forms.GroupBox
    Friend WithEvents btnlaporan As System.Windows.Forms.Button
    Friend WithEvents btnkasir As System.Windows.Forms.Button
    Friend WithEvents btnproduk As System.Windows.Forms.Button
    Friend WithEvents btnpembelian As System.Windows.Forms.Button
    Friend WithEvents lblversi As System.Windows.Forms.Label
    Friend WithEvents LabelSubToko As System.Windows.Forms.Label
    Friend WithEvents LabelToko As System.Windows.Forms.Label
    Friend WithEvents LabelUser As System.Windows.Forms.Label
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
    Friend WithEvents TextBoxLoginPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLoginUsername As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxLogin As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonCustomer As System.Windows.Forms.Button
    Friend WithEvents LabelStation As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
