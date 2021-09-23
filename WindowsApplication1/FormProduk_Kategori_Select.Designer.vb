<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduk_Kategori_Select
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
        Me.DataGridViewKategoriSelect = New System.Windows.Forms.DataGridView()
        Me.TextBoxSelectKategori = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSelectKategori = New System.Windows.Forms.Button()
        CType(Me.DataGridViewKategoriSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewKategoriSelect
        '
        Me.DataGridViewKategoriSelect.AllowUserToAddRows = False
        Me.DataGridViewKategoriSelect.AllowUserToDeleteRows = False
        Me.DataGridViewKategoriSelect.AllowUserToResizeColumns = False
        Me.DataGridViewKategoriSelect.AllowUserToResizeRows = False
        Me.DataGridViewKategoriSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewKategoriSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewKategoriSelect.Location = New System.Drawing.Point(12, 39)
        Me.DataGridViewKategoriSelect.Name = "DataGridViewKategoriSelect"
        Me.DataGridViewKategoriSelect.ReadOnly = True
        Me.DataGridViewKategoriSelect.ShowEditingIcon = False
        Me.DataGridViewKategoriSelect.Size = New System.Drawing.Size(353, 256)
        Me.DataGridViewKategoriSelect.TabIndex = 0
        '
        'TextBoxSelectKategori
        '
        Me.TextBoxSelectKategori.Location = New System.Drawing.Point(80, 10)
        Me.TextBoxSelectKategori.Name = "TextBoxSelectKategori"
        Me.TextBoxSelectKategori.ReadOnly = True
        Me.TextBoxSelectKategori.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxSelectKategori.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nama Rak"
        '
        'ButtonSelectKategori
        '
        Me.ButtonSelectKategori.Location = New System.Drawing.Point(290, 8)
        Me.ButtonSelectKategori.Name = "ButtonSelectKategori"
        Me.ButtonSelectKategori.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSelectKategori.TabIndex = 3
        Me.ButtonSelectKategori.Text = "Select"
        Me.ButtonSelectKategori.UseVisualStyleBackColor = True
        '
        'FormProduk_Kategori_Select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 307)
        Me.Controls.Add(Me.ButtonSelectKategori)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxSelectKategori)
        Me.Controls.Add(Me.DataGridViewKategoriSelect)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormProduk_Kategori_Select"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Rak"
        CType(Me.DataGridViewKategoriSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewKategoriSelect As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxSelectKategori As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonSelectKategori As System.Windows.Forms.Button
End Class
