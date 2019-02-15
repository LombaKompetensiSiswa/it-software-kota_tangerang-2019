Public Class FrmAdminNav
    Private Sub FrmAdminNav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = nama
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmManageEmployee.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmManageMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FrmManageMember.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmChangePass.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Logut As String
        Logut = MsgBox("apakah anda yakin ingin keluar", vbQuestion + vbYesNo, "logout")
        If Logut = vbYes Then
            FrmLogin.Show()
            Me.Close()
        End If
    End Sub
End Class