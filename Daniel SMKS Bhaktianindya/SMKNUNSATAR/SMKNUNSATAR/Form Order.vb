Imports System.Data.SqlClient
Public Class Form_Order
    Private Sub Form_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Msmenuorder.Msmenu' table. You can move, or remove it, as needed.
        Me.MsmenuTableAdapter.Fill(Me.Msmenuorder.Msmenu)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Then
            MsgBox("Harap Pilih data terlebih dahulu")
        Else
            Dim i = DataGridView1.CurrentRow.Index()
            DataGridView2.Rows.Add(New String() {TextBox1.Text, TextBox2.Text, TextBox3.Text, (Convert.ToInt32(TextBox2.Text)) * (Convert.ToInt32(TextBox3.Text)), DataGridView1.Item(3, i).Value})
            Call hitung()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            PictureBox1.Image = Nothing
            If DataGridView1.Rows.Count > -1 Then
                Button2.Enabled = True
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim I = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(1, I).Value
        TextBox2.Text = "1"
        TextBox3.Text = DataGridView1.Item(2, I).Value
        PictureBox1.Image = Image.FromFile(DataGridView1.Item(3, I).Value)
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim I = DataGridView2.CurrentRow.Index
        TextBox1.Text = DataGridView2.Item(0, I).Value
        TextBox2.Text = DataGridView2.Item(1, I).Value
        TextBox3.Text = DataGridView2.Item(2, I).Value
        PictureBox1.Image = Image.FromFile(DataGridView2.Item(4, I).Value)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim row = DataGridView2.CurrentRow.Index()
        DataGridView2.Rows.RemoveAt(row)
        If DataGridView2.Rows.Count < 1 Then
            Button2.Enabled = False
        End If
    End Sub

    Sub hitung()
        Dim total As Integer = 0
        For t As Integer = 0 To DataGridView2.Rows.Count - 1
            total = total + DataGridView2.Rows(t).Cells(3).Value
            totalhitung.Text = total
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call koneksi()
        cmd = New SqlCommand("INSERT INTO Headerorder(EmployeeID,Date,Payment,Bank) values('" & employeeid & "','" & Now & "','','') ", conn)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("SELECT max(OrderID) From Headerorder", conn)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim k As Integer
        k = dr.Item(0).ToString
        Dim i = DataGridView2.CurrentRow.Index()
        Call koneksi()
        cmd = New SqlCommand("INSERT INTO Detailorder(OrderID,MenuID,Qty,Price) values ('" & k & "','" & DataGridView1.Item(0, i).Value & "','" & DataGridView2.Item(1, i).Value & "','" & DataGridView2.Item(2, i).Value & "')", conn)
        cmd.ExecuteNonQuery()
        MsgBox("data berhasil diorder")
        DataGridView2 = Nothing
        totalhitung.Text = ""
    End Sub

    Private Sub Form_Order_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If CloseReason.ApplicationExitCall Then
            FrmChefNav.Show()
            Me.Hide()
        End If
    End Sub
End Class