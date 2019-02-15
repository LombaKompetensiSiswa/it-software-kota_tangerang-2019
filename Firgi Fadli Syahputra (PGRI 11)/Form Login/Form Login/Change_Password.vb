Public Class Form8
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        MsgBox("password telah disimpan, silahkan login kembali")
        Me.Hide()
    End Sub
End Class