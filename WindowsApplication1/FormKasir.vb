Public Class FormKasir

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formcaribarang.Visible = True
        TextBoxCariBarang.Focus()
    End Sub

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        formcaribarang.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        formcaribarang.Visible = False
        TextBoxBarang.Focus()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                formcaribarang.Visible = True
                TextBoxCariBarang.Focus()
            Case Keys.F5 'save
                '...sintak anda
            Case Keys.F6 'cancel
                '...sintak anda
            Case Keys.F7 'close
                '...sintak anda
        End Select
    End Sub

    Private Sub TextBoxBarang_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBarang.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class