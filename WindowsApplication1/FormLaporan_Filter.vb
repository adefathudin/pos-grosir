Public Class FormLaporan_Filter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBoxNomorStruk.Text) Then
            TextBoxNomorStruk.Focus()
            Exit Sub
        End If
        Try
            Dim NomorStruk = TextBoxNomorStruk.Text
            Call conecDB()
            comDB = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM mtran WHERE nomor_struk='" + NomorStruk + "'", connDB)
            rdDB = comDB.ExecuteReader
            If rdDB.HasRows Then
                rdDB.Read()
                'TextBoxBarang.Text = rdDB("prdcd")
                'TextBoxQTY.Focus()
            Else
                MessageBox.Show("Stok tidak mencukupi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'TextBoxBarang.SelectAll()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        rdDB.Close()
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged

    End Sub
End Class