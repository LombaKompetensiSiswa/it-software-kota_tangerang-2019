Imports System.Data.SqlClient
Public Class FrmManageMenu
    Private Sub FrmManageMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Menu.Msmenu' table. You can move, or remove it, as needed.
        Me.MsmenuTableAdapter.Fill(Me.Menu.Msmenu)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Then
            MsgBox("Harap isi data terlebih dahulu")
        Else
            Call koneksi()
            cmd = New SqlCommand("INSERT INTO Msmenu(Name,Price,Photo) Values('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("data berhasil dimasukkan")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            PictureBox1.Image = Nothing
        End If
        Me.MsmenuTableAdapter.Fill(Me.Menu.Msmenu)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim browse As New OpenFileDialog
        If (browse.ShowDialog = DialogResult.OK) Then
            browse.Filter = "Choose Image (*.jpg)|*.jpg"
            PictureBox1.Image = Image.FromFile(browse.FileName)
            TextBox4.Text = browse.FileName().ToArray
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Then
            MsgBox("Harap pilih data terlebih dahulu")
        Else
            Call koneksi()
            cmd = New SqlCommand("UPDATE Msmenu Set Name = '" & TextBox2.Text & "', Price = '" & TextBox3.Text & "',Photo = '" & TextBox4.Text & "' Where MenuID = '" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("data berhasil diganti")
            Me.MsmenuTableAdapter.Fill(Me.Menu.Msmenu)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            PictureBox1 = Nothing
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Then
            MsgBox("Harap pilih data terlebih dahulu")
        Else
            Call koneksi()
            cmd = New SqlCommand("DELETE Msmenu Where MenuID = '" & TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus")
            Me.MsmenuTableAdapter.Fill(Me.Menu.Msmenu)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            PictureBox1 = Nothing
        End If
    End Sub

    Private Sub FrmManageMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If CloseReason.ApplicationExitCall Then
            FrmAdminNav.Show()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index()
        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        TextBox3.Text = DataGridView1.Item(2, i).Value
        TextBox4.Text = DataGridView1.Item(3, i).Value
        PictureBox1.Image = Image.FromFile(TextBox4.Text)
    End Sub
End Class