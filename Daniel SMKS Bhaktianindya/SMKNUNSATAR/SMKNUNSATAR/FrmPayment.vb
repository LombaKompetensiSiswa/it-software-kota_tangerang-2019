Imports System.Data.SqlClient
Public Class FrmPayment
    Sub Tampildata()
        Call Koneksi()
        da = New SqlDataAdapter("Select Msmenu.Name as Menu, Detailorder.Qty From Detailorder inner join Msmenu on Msmenu.MenuID = Detailorder.MenuID Where OrderID = '" & ComboBox1.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds, "Msmenu")
        DataGridView1.DataSource() = ds.Tables("Msmenu")
    End Sub

    Private Sub FrmPayment_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If CloseReason.ApplicationExitCall Then
            FrmCashierNav.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox2.Text = "") Or (TextBox2.Text = "") Or (ComboBox3.Text = "") Then
            MsgBox("Harap pilih data terlebih dahulu")
        Else
            Call koneksi()
            cmd = New SqlCommand("Update Headerorder set Payment = '" & ComboBox2.Text & "', Bank = '" & ComboBox3.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil disave")
        End If
    End Sub

    Private Sub FrmPayment_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Koneksi()
        cmd = New SqlCommand("Select * From Headerorder", conn)
        dr = cmd.ExecuteReader
        While dr.Read()
            Dim orderid = dr.Item(0)
            ComboBox1.Items.Add(orderid)
        End While
        Call Tampildata()
    End Sub
End Class