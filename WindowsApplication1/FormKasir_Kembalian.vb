Public Class FormKasir_Kembalian

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        FormKasir.CetakPrint()
        FormKasir.SimpanTranDanCetak()
        Me.Close()
    End Sub

End Class