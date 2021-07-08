<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbljam = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnlaporan = New System.Windows.Forms.Button()
        Me.btnkasir = New System.Windows.Forms.Button()
        Me.btnproduk = New System.Windows.Forms.Button()
        Me.btnpembelian = New System.Windows.Forms.Button()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblstore = New System.Windows.Forms.Label()
        Me.lblversi = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.lbljam)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(202, 729)
        Me.Panel1.TabIndex = 2
        '
        'lbljam
        '
        Me.lbljam.AutoSize = True
        Me.lbljam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljam.Location = New System.Drawing.Point(5, 36)
        Me.lbljam.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbljam.Name = "lbljam"
        Me.lbljam.Size = New System.Drawing.Size(59, 24)
        Me.lbljam.TabIndex = 6
        Me.lbljam.Text = "lbljam"
        Me.lbljam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Controls.Add(Me.btnlaporan)
        Me.GroupBox1.Controls.Add(Me.btnkasir)
        Me.GroupBox1.Controls.Add(Me.btnproduk)
        Me.GroupBox1.Controls.Add(Me.btnpembelian)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 63)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(182, 249)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'btnlaporan
        '
        Me.btnlaporan.BackColor = System.Drawing.Color.Azure
        Me.btnlaporan.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlaporan.Image = CType(resources.GetObject("btnlaporan.Image"), System.Drawing.Image)
        Me.btnlaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlaporan.Location = New System.Drawing.Point(9, 190)
        Me.btnlaporan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnlaporan.Name = "btnlaporan"
        Me.btnlaporan.Size = New System.Drawing.Size(166, 44)
        Me.btnlaporan.TabIndex = 12
        Me.btnlaporan.Text = "LAPORAN"
        Me.btnlaporan.UseVisualStyleBackColor = False
        '
        'btnkasir
        '
        Me.btnkasir.BackColor = System.Drawing.Color.Azure
        Me.btnkasir.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkasir.Image = CType(resources.GetObject("btnkasir.Image"), System.Drawing.Image)
        Me.btnkasir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnkasir.Location = New System.Drawing.Point(9, 17)
        Me.btnkasir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnkasir.Name = "btnkasir"
        Me.btnkasir.Size = New System.Drawing.Size(166, 44)
        Me.btnkasir.TabIndex = 9
        Me.btnkasir.Text = "KASIR"
        Me.btnkasir.UseVisualStyleBackColor = False
        '
        'btnproduk
        '
        Me.btnproduk.BackColor = System.Drawing.Color.Azure
        Me.btnproduk.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproduk.Image = CType(resources.GetObject("btnproduk.Image"), System.Drawing.Image)
        Me.btnproduk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnproduk.Location = New System.Drawing.Point(9, 133)
        Me.btnproduk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnproduk.Name = "btnproduk"
        Me.btnproduk.Size = New System.Drawing.Size(166, 44)
        Me.btnproduk.TabIndex = 11
        Me.btnproduk.Text = "PRODUK"
        Me.btnproduk.UseVisualStyleBackColor = False
        '
        'btnpembelian
        '
        Me.btnpembelian.BackColor = System.Drawing.Color.Azure
        Me.btnpembelian.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpembelian.Image = CType(resources.GetObject("btnpembelian.Image"), System.Drawing.Image)
        Me.btnpembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpembelian.Location = New System.Drawing.Point(9, 75)
        Me.btnpembelian.Margin = New System.Windows.Forms.Padding(2)
        Me.btnpembelian.Name = "btnpembelian"
        Me.btnpembelian.Size = New System.Drawing.Size(166, 44)
        Me.btnpembelian.TabIndex = 10
        Me.btnpembelian.Text = "PEMBELIAN"
        Me.btnpembelian.UseVisualStyleBackColor = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(5, 9)
        Me.lbldate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(65, 24)
        Me.lbldate.TabIndex = 7
        Me.lbldate.Text = "lbldate"
        Me.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.Controls.Add(Me.LabelUser)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblstore)
        Me.Panel2.Controls.Add(Me.lblversi)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(202, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(806, 70)
        Me.Panel2.TabIndex = 4
        '
        'LabelUser
        '
        Me.LabelUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelUser.AutoSize = True
        Me.LabelUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.Location = New System.Drawing.Point(624, 20)
        Me.LabelUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(109, 17)
        Me.LabelUser.TabIndex = 10
        Me.LabelUser.Text = "ADE FATHUDIN"
        Me.LabelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Jl. Raya Cianjur No. 27, Cianjur"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblstore
        '
        Me.lblstore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblstore.AutoSize = True
        Me.lblstore.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstore.Location = New System.Drawing.Point(2, 12)
        Me.lblstore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblstore.Name = "lblstore"
        Me.lblstore.Size = New System.Drawing.Size(185, 24)
        Me.lblstore.TabIndex = 9
        Me.lblstore.Text = "CV. Maju Jaya Grosir"
        Me.lblstore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblversi
        '
        Me.lblversi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblversi.AutoSize = True
        Me.lblversi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblversi.Location = New System.Drawing.Point(698, 45)
        Me.lblversi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblversi.Name = "lblversi"
        Me.lblversi.Size = New System.Drawing.Size(108, 15)
        Me.lblversi.TabIndex = 9
        Me.lblversi.Text = "POSMain v.1.0.1.1"
        Me.lblversi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "POSMAIN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lbljam As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnlaporan As System.Windows.Forms.Button
    Friend WithEvents btnkasir As System.Windows.Forms.Button
    Friend WithEvents btnproduk As System.Windows.Forms.Button
    Friend WithEvents btnpembelian As System.Windows.Forms.Button
    Friend WithEvents lblversi As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblstore As System.Windows.Forms.Label
    Friend WithEvents LabelUser As System.Windows.Forms.Label

End Class
