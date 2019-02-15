Imports System.Data.SqlClient
Public Class FrmManageEmployee
    Private Sub FrmManageEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Msemployee._Msemployee' table. You can move, or remove it, as needed.
        Me.MsemployeeTableAdapter.Fill(Me.Msemployee._Msemployee)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Then
            MsgBox("Harap masukan data terlebih dahulu")
        Else
            Call koneksi()
            cmd = New SqlCommand("INSERT INTO Msemployee(Name,Email,Handphone,Position)Values ('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("data berhasil diinput")
            Me.MsemployeeTableAdapter.Fill(Me.Msemployee._Msemployee)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            ComboBox1.Text = Nothing
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Then
            MsgBox("harap isi data terlebih dahulu")
        Else
            Call koneksi()
            cmd = New SqlCommand("UPDATE Msemployee Set Name = '" & TextBox2.Text & "', Email = '" & TextBox2.Text & "',Handphone = '" & TextBox2.Text & "', Position = '" & ComboBox1.Text & "' Where EmployeeID = '" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("data berhasil diupdate")
            Me.MsemployeeTableAdapter.Fill(Me.Msemployee._Msemployee)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            ComboBox1.Text = Nothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (ComboBox1.Text = "") Then
            MsgBox("Harap Pilih data terlebih dahulu")
        Else
            Dim hapus As String
            hapus = MsgBox("yakin delete data ini??", vbQuestion + vbYesNo, "delete")
            If hapus = vbYes Then
                Call koneksi()
                cmd = New SqlCommand("DELETE Msemployee Where EmployeeID = '" & TextBox1.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("data berhasil dihapus")
                Me.MsemployeeTableAdapter.Fill(Me.Msemployee._Msemployee)
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                ComboBox1.Text = Nothing
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        TextBox3.Text = DataGridView1.Item(2, i).Value
        TextBox4.Text = DataGridView1.Item(3, i).Value
        ComboBox1.Text = DataGridView1.Item(4, i).Value
    End Sub

    Private Sub FrmManageEmployee_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If CloseReason.ApplicationExitCall Then
            FrmAdminNav.Show()
        End If
    End Sub
End Class