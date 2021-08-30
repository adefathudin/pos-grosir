<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        Me.DateTimePickerStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridViewLaporan = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelPeriode = New System.Windows.Forms.Label()
        Me.TextBoxTotalKeuntungan = New System.Windows.Forms.TextBox()
        Me.TextBoxTotalHargaBeli = New System.Windows.Forms.TextBox()
        Me.TextBoxTotalPenjualan = New System.Windows.Forms.TextBox()
        Me.TextBoxItemTerjual = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Lable1 = New System.Windows.Forms.Label()
        Me.TextBoxCustomer = New System.Windows.Forms.TextBox()
        Me.TextBoxNamaCustomer = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridViewLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePickerStartDate
        '
        Me.DateTimePickerStartDate.Location = New System.Drawing.Point(84, 28)
        Me.DateTimePickerStartDate.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        Me.DateTimePickerStartDate.Size = New System.Drawing.Size(223, 20)
        Me.DateTimePickerStartDate.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Start Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "End Date :"
        '
        'DateTimePickerEndDate
        '
        Me.DateTimePickerEndDate.Location = New System.Drawing.Point(84, 63)
        Me.DateTimePickerEndDate.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        Me.DateTimePickerEndDate.Size = New System.Drawing.Size(223, 20)
        Me.DateTimePickerEndDate.TabIndex = 2
        Me.DateTimePickerEndDate.Value = New Date(2021, 8, 27, 15, 40, 47, 0)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(92, 145)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(188, 145)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 34)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Export Excel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridViewLaporan
        '
        Me.DataGridViewLaporan.AllowUserToAddRows = False
        Me.DataGridViewLaporan.AllowUserToDeleteRows = False
        Me.DataGridViewLaporan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewLaporan.Location = New System.Drawing.Point(9, 228)
        Me.DataGridViewLaporan.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewLaporan.Name = "DataGridViewLaporan"
        Me.DataGridViewLaporan.RowTemplate.Height = 24
        Me.DataGridViewLaporan.Size = New System.Drawing.Size(801, 384)
        Me.DataGridViewLaporan.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(801, 214)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.TextBoxNamaCustomer)
        Me.GroupBox3.Controls.Add(Me.TextBoxCustomer)
        Me.GroupBox3.Controls.Add(Me.Lable1)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerStartDate)
        Me.GroupBox3.Controls.Add(Me.DateTimePickerEndDate)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 17)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(352, 193)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelPeriode)
        Me.GroupBox1.Controls.Add(Me.TextBoxTotalKeuntungan)
        Me.GroupBox1.Controls.Add(Me.TextBoxTotalHargaBeli)
        Me.GroupBox1.Controls.Add(Me.TextBoxTotalPenjualan)
        Me.GroupBox1.Controls.Add(Me.TextBoxItemTerjual)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(392, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(404, 193)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Summary"
        '
        'LabelPeriode
        '
        Me.LabelPeriode.AutoSize = True
        Me.LabelPeriode.Location = New System.Drawing.Point(111, 0)
        Me.LabelPeriode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPeriode.Name = "LabelPeriode"
        Me.LabelPeriode.Size = New System.Drawing.Size(18, 13)
        Me.LabelPeriode.TabIndex = 9
        Me.LabelPeriode.Text = "All"
        '
        'TextBoxTotalKeuntungan
        '
        Me.TextBoxTotalKeuntungan.Location = New System.Drawing.Point(167, 128)
        Me.TextBoxTotalKeuntungan.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTotalKeuntungan.Name = "TextBoxTotalKeuntungan"
        Me.TextBoxTotalKeuntungan.ReadOnly = True
        Me.TextBoxTotalKeuntungan.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxTotalKeuntungan.TabIndex = 8
        Me.TextBoxTotalKeuntungan.Text = "0"
        Me.TextBoxTotalKeuntungan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxTotalHargaBeli
        '
        Me.TextBoxTotalHargaBeli.Location = New System.Drawing.Point(167, 60)
        Me.TextBoxTotalHargaBeli.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTotalHargaBeli.Name = "TextBoxTotalHargaBeli"
        Me.TextBoxTotalHargaBeli.ReadOnly = True
        Me.TextBoxTotalHargaBeli.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxTotalHargaBeli.TabIndex = 7
        Me.TextBoxTotalHargaBeli.Text = "0"
        Me.TextBoxTotalHargaBeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxTotalPenjualan
        '
        Me.TextBoxTotalPenjualan.Location = New System.Drawing.Point(167, 95)
        Me.TextBoxTotalPenjualan.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTotalPenjualan.Name = "TextBoxTotalPenjualan"
        Me.TextBoxTotalPenjualan.ReadOnly = True
        Me.TextBoxTotalPenjualan.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxTotalPenjualan.TabIndex = 6
        Me.TextBoxTotalPenjualan.Text = "0"
        Me.TextBoxTotalPenjualan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxItemTerjual
        '
        Me.TextBoxItemTerjual.Location = New System.Drawing.Point(167, 28)
        Me.TextBoxItemTerjual.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxItemTerjual.Name = "TextBoxItemTerjual"
        Me.TextBoxItemTerjual.ReadOnly = True
        Me.TextBoxItemTerjual.Size = New System.Drawing.Size(234, 20)
        Me.TextBoxItemTerjual.TabIndex = 5
        Me.TextBoxItemTerjual.Text = "0"
        Me.TextBoxItemTerjual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 63)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total Harga Beli :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Periode :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total Item Terjual :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 130)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Total Keuntungan :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(74, 98)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total Penjualan :"
        '
        'Lable1
        '
        Me.Lable1.AutoSize = True
        Me.Lable1.Location = New System.Drawing.Point(19, 102)
        Me.Lable1.Name = "Lable1"
        Me.Lable1.Size = New System.Drawing.Size(57, 13)
        Me.Lable1.TabIndex = 6
        Me.Lable1.Text = "Customer :"
        '
        'TextBoxCustomer
        '
        Me.TextBoxCustomer.Location = New System.Drawing.Point(84, 99)
        Me.TextBoxCustomer.Name = "TextBoxCustomer"
        Me.TextBoxCustomer.ReadOnly = True
        Me.TextBoxCustomer.Size = New System.Drawing.Size(92, 20)
        Me.TextBoxCustomer.TabIndex = 7
        '
        'TextBoxNamaCustomer
        '
        Me.TextBoxNamaCustomer.Location = New System.Drawing.Point(188, 98)
        Me.TextBoxNamaCustomer.Name = "TextBoxNamaCustomer"
        Me.TextBoxNamaCustomer.ReadOnly = True
        Me.TextBoxNamaCustomer.Size = New System.Drawing.Size(119, 20)
        Me.TextBoxNamaCustomer.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(313, 96)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "x"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 620)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridViewLaporan)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormLaporan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridViewLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewLaporan As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxTotalKeuntungan As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotalHargaBeli As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotalPenjualan As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxItemTerjual As System.Windows.Forms.TextBox
    Friend WithEvents LabelPeriode As System.Windows.Forms.Label
    Friend WithEvents TextBoxCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Lable1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNamaCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
