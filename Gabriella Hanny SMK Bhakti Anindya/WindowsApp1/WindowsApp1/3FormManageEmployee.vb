Imports System.Data.SqlClient

Public Class FrmMnEmp
    Private Sub FrmMnEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxPos.BackColor = Color.White

        'TODO: This line of code loads data into the 'SMKRestorantDataSet.MsEmployee' table. You can move, or remove it, as needed.
        Me.MsEmployeeTableAdapter.Fill(Me.SMKRestorantDataSet.MsEmployee)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick

        Dim row = DGV.CurrentRow
        TxID.Text = row.Cells(0).Value.ToString
        TxName.Text = row.Cells(1).Value.ToString
        TxEmail.Text = row.Cells(2).Value.ToString
        TxHp.Text = row.Cells(4).Value.ToString
        TxPos.Text = row.Cells(5).Value.ToString

    End Sub

    Private Sub BIns_Click(sender As Object, e As EventArgs) Handles BIns.Click

        Dim i = New SqlCommand("INSERT INTO msemployee (Name, Email, Password, Handphone, Position) VALUES ('" & TxName.Text & "','" & TxEmail.Text & "','','" & TxHp.Text & "','" & TxPos.Text & "')", cn)
        i.ExecuteNonQuery()
        MsgBox("Inserted.")
        Me.MsEmployeeTableAdapter.Fill(Me.SMKRestorantDataSet.MsEmployee)


    End Sub

    Private Sub BUpd_Click(sender As Object, e As EventArgs) Handles BUpd.Click

        Dim i = New SqlCommand("UPDATE msemployee SET Name = '" & TxName.Text & "', Email = '" & TxEmail.Text & "', Handphone = '" & TxHp.Text & "', Position = '" & TxPos.Text & "' WHERE EmployeeID = '" & TxID.Text & "'", cn)
        i.ExecuteNonQuery()
        MsgBox("Updated.")
        Me.MsEmployeeTableAdapter.Fill(Me.SMKRestorantDataSet.MsEmployee)

    End Sub

    Private Sub BDel_Click(sender As Object, e As EventArgs) Handles BDel.Click

        Dim i = New SqlCommand("DELETE FROM msemployee WHERE EmployeeID = '" & TxID.Text & "'", cn)
        i.ExecuteNonQuery()
        MsgBox("Deleted.")
        Me.MsEmployeeTableAdapter.Fill(Me.SMKRestorantDataSet.MsEmployee)

    End Sub

    Private Sub TxHp_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxHp.KeyPress

        If Not Not (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            MsgBox("Hanya Masukan Angka (0-9)")
        End If

        If Not Not (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True

        End If
    End Sub

End Class