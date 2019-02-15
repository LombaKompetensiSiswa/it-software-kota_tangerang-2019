Public Class Form1
    Private ShowMenu As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Hide()
        MsgBox("Halo Admin")

    End Sub
End Class
