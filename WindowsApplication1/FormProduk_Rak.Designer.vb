<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduk_Rak
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.LabelTotalItem = New System.Windows.Forms.Label()
        Me.DataGridViewRak = New System.Windows.Forms.DataGridView()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewRak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonDelete)
        Me.GroupBox2.Controls.Add(Me.ButtonTambah)
        Me.GroupBox2.Controls.Add(Me.LabelTotalItem)
        Me.GroupBox2.Controls.Add(Me.DataGridViewRak)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(809, 537)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.SystemColors.Menu
        Me.ButtonDelete.Location = New System.Drawing.Point(728, 0)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 6
        Me.ButtonDelete.Text = "DELETE"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'ButtonTambah
        '
        Me.ButtonTambah.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonTambah.Location = New System.Drawing.Point(647, 0)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 5
        Me.ButtonTambah.Text = "TAMBAH"
        Me.ButtonTambah.UseVisualStyleBackColor = False
        '
        'LabelTotalItem
        '
        Me.LabelTotalItem.AutoSize = True
        Me.LabelTotalItem.Location = New System.Drawing.Point(6, 0)
        Me.LabelTotalItem.Name = "LabelTotalItem"
        Me.LabelTotalItem.Size = New System.Drawing.Size(77, 13)
        Me.LabelTotalItem.TabIndex = 1
        Me.LabelTotalItem.Text = "LabelTotalItem"
        '
        'DataGridViewRak
        '
        Me.DataGridViewRak.AllowUserToAddRows = False
        Me.DataGridViewRak.AllowUserToDeleteRows = False
        Me.DataGridViewRak.AllowUserToOrderColumns = True
        Me.DataGridViewRak.AllowUserToResizeRows = False
        Me.DataGridViewRak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewRak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRak.Location = New System.Drawing.Point(7, 29)
        Me.DataGridViewRak.MultiSelect = False
        Me.DataGridViewRak.Name = "DataGridViewRak"
        Me.DataGridViewRak.Size = New System.Drawing.Size(796, 502)
        Me.DataGridViewRak.TabIndex = 0
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ButtonSave.Location = New System.Drawing.Point(728, 17)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 4
        Me.ButtonSave.Text = "SAVE"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(177, 19)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(215, 20)
        Me.TextBoxNama.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Rak :"
        '
        'TextBoxDesc
        '
        Me.TextBoxDesc.Location = New System.Drawing.Point(475, 19)
        Me.TextBoxDesc.Multiline = True
        Me.TextBoxDesc.Name = "TextBoxDesc"
        Me.TextBoxDesc.Size = New System.Drawing.Size(236, 20)
        Me.TextBoxDesc.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(413, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Deskripsi :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxDesc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxNama)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(809, 51)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(30, 19)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.ReadOnly = True
        Me.TextBoxID.Size = New System.Drawing.Size(49, 20)
        Me.TextBoxID.TabIndex = 6
        Me.TextBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ID :"
        '
        'FormProduk_Rak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 620)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormProduk_Rak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RAK"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridViewRak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewRak As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents LabelTotalItem As System.Windows.Forms.Label
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
