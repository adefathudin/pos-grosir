<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKasir_Customer_Select
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
        Me.DataGridViewCustomerSelect = New System.Windows.Forms.DataGridView()
        Me.TextBoxSelectNamaCustomer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSelectCustomer = New System.Windows.Forms.Button()
        Me.TextBoxSelectIDCustomer = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewCustomerSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewCustomerSelect
        '
        Me.DataGridViewCustomerSelect.AllowUserToAddRows = False
        Me.DataGridViewCustomerSelect.AllowUserToDeleteRows = False
        Me.DataGridViewCustomerSelect.AllowUserToResizeColumns = False
        Me.DataGridViewCustomerSelect.AllowUserToResizeRows = False
        Me.DataGridViewCustomerSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewCustomerSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomerSelect.Location = New System.Drawing.Point(12, 39)
        Me.DataGridViewCustomerSelect.Name = "DataGridViewCustomerSelect"
        Me.DataGridViewCustomerSelect.ReadOnly = True
        Me.DataGridViewCustomerSelect.ShowEditingIcon = False
        Me.DataGridViewCustomerSelect.Size = New System.Drawing.Size(479, 256)
        Me.DataGridViewCustomerSelect.TabIndex = 0
        '
        'TextBoxSelectNamaCustomer
        '
        Me.TextBoxSelectNamaCustomer.Location = New System.Drawing.Point(268, 10)
        Me.TextBoxSelectNamaCustomer.Name = "TextBoxSelectNamaCustomer"
        Me.TextBoxSelectNamaCustomer.ReadOnly = True
        Me.TextBoxSelectNamaCustomer.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxSelectNamaCustomer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nama Customer"
        '
        'ButtonSelectCustomer
        '
        Me.ButtonSelectCustomer.Location = New System.Drawing.Point(416, 8)
        Me.ButtonSelectCustomer.Name = "ButtonSelectCustomer"
        Me.ButtonSelectCustomer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSelectCustomer.TabIndex = 3
        Me.ButtonSelectCustomer.Text = "Select"
        Me.ButtonSelectCustomer.UseVisualStyleBackColor = True
        '
        'TextBoxSelectIDCustomer
        '
        Me.TextBoxSelectIDCustomer.Location = New System.Drawing.Point(100, 10)
        Me.TextBoxSelectIDCustomer.Name = "TextBoxSelectIDCustomer"
        Me.TextBoxSelectIDCustomer.ReadOnly = True
        Me.TextBoxSelectIDCustomer.Size = New System.Drawing.Size(162, 20)
        Me.TextBoxSelectIDCustomer.TabIndex = 4
        '
        'FormKasir_Customer_Select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 307)
        Me.Controls.Add(Me.TextBoxSelectIDCustomer)
        Me.Controls.Add(Me.ButtonSelectCustomer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxSelectNamaCustomer)
        Me.Controls.Add(Me.DataGridViewCustomerSelect)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormKasir_Customer_Select"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Customer"
        CType(Me.DataGridViewCustomerSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewCustomerSelect As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxSelectNamaCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonSelectCustomer As System.Windows.Forms.Button
    Friend WithEvents TextBoxSelectIDCustomer As System.Windows.Forms.TextBox
End Class
