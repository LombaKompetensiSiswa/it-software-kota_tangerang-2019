Imports System.Data.SqlClient
Public Class FrmManageMember
    Private Sub FrmManageMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MsMember._Msmember' table. You can move, or remove it, as needed.
        Me.MsmemberTableAdapter.Fill(Me.MsMember._Msmember)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox2.Text = "") Or (TextBox3.Text = "") Then
            MsgBox("Harap Isi data terlebih dahulu")
        Else
            Call koneksi()
            cmd = New SqlCommand("INSERT Msmember(Name,Email,Handphone, JoinDate) Values ('" & TextBox2.Text & "','" & TextBox3.Text & "','', '" & Now & "' )", conn)
            cmd.ExecuteNonQuery()
            MsgBox("data berhasil dimasukkan")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            Me.MsmemberTableAdapter.Fill(Me.MsMember._Msmember)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        If (TextBox2.Text = "") Or (TextBox3.Text = "") Then
            MsgBox("pilih data terlebih dahulu")
        Else
            cmd = New SqlCommand("UPDATE Msmember Set Name ='" & TextBox2.Text & "' , Email='" & TextBox3.Text & "' Where MemberId = '" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("data berhasil diupdate")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            Me.MsmemberTableAdapter.Fill(Me.MsMember._Msmember)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox2.Text = "") Or (TextBox3.Text = "") Then
            MsgBox("pilih data terlebih dahulu")
        Else
            Dim hapus As String
            hapus = MsgBox("anda yakin hapus data ini?", vbQuestion + vbYesNo, "hapus")
            If hapus = vbYes Then
                cmd = New SqlCommand("DELETE Msmember WHere MemberID = '" & TextBox1.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("data berhasil dihapus")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                Me.MsmemberTableAdapter.Fill(Me.MsMember._Msmember)
            End If
        End If
    End Sub

    Private Sub FrmManageMember_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If CloseReason.ApplicationExitCall Then
            FrmAdminNav.Show()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        TextBox3.Text = DataGridView1.Item(2, i).Value
    End Sub
End Class