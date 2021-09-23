<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduk_Rak_Select
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
        Me.DataGridViewRakSelect = New System.Windows.Forms.DataGridView()
        Me.TextBoxSelectRak = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSelectRak = New System.Windows.Forms.Button()
        CType(Me.DataGridViewRakSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewRakSelect
        '
        Me.DataGridViewRakSelect.AllowUserToAddRows = False
        Me.DataGridViewRakSelect.AllowUserToDeleteRows = False
        Me.DataGridViewRakSelect.AllowUserToResizeColumns = False
        Me.DataGridViewRakSelect.AllowUserToResizeRows = False
        Me.DataGridViewRakSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewRakSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRakSelect.Location = New System.Drawing.Point(12, 39)
        Me.DataGridViewRakSelect.Name = "DataGridViewRakSelect"
        Me.DataGridViewRakSelect.ReadOnly = True
        Me.DataGridViewRakSelect.ShowEditingIcon = False
        Me.DataGridViewRakSelect.Size = New System.Drawing.Size(353, 256)
        Me.DataGridViewRakSelect.TabIndex = 0
        '
        'TextBoxSelectRak
        '
        Me.TextBoxSelectRak.Location = New System.Drawing.Point(80, 10)
        Me.TextBoxSelectRak.Name = "TextBoxSelectRak"
        Me.TextBoxSelectRak.ReadOnly = True
        Me.TextBoxSelectRak.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxSelectRak.TabIndex = 1
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
        'ButtonSelectRak
        '
        Me.ButtonSelectRak.Location = New System.Drawing.Point(290, 8)
        Me.ButtonSelectRak.Name = "ButtonSelectRak"
        Me.ButtonSelectRak.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSelectRak.TabIndex = 3
        Me.ButtonSelectRak.Text = "Select"
        Me.ButtonSelectRak.UseVisualStyleBackColor = True
        '
        'FormProduk_Rak_Select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 307)
        Me.Controls.Add(Me.ButtonSelectRak)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxSelectRak)
        Me.Controls.Add(Me.DataGridViewRakSelect)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormProduk_Rak_Select"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Rak"
        CType(Me.DataGridViewRakSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewRakSelect As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxSelectRak As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonSelectRak As System.Windows.Forms.Button
End Class
