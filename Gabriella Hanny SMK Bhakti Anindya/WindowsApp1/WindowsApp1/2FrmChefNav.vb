Public Class FrmChef
    Private Sub FrmChef_Load(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmChPw.Close()
        FrmVord.Close()
        FrmWel.Show()


    End Sub

    Private Sub FrmChef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUser.Text = unama
    End Sub

    Private Sub Bmem_Click(sender As Object, e As EventArgs) Handles Bord.Click
        FrmVord.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BPw.Click
        FrmChPw.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bout.Click
        FrmWel.Show()
        Close()


    End Sub


End Class