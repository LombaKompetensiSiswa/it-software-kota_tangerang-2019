Public Class FrmAdmin

    Private Sub FrmChef_Load(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmChPw.Close()
        FrmMnEmp.Close()
        FrmMnMem.Close()
        FrmMnMenu.Close()
        FrmWel.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblUser.Text = unama

    End Sub

    Private Sub Bmem_Click(sender As Object, e As EventArgs) Handles Bemp.Click
        FrmMnEmp.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BChPW.Click
        FrmChPw.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BOut.Click
        Close()
        FrmWel.Show()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Bmem.Click
        FrmMnMem.Show()

    End Sub

    Private Sub Bemp_Click(sender As Object, e As EventArgs) Handles Bmen.Click
        FrmMnMenu.Show()

    End Sub


End Class