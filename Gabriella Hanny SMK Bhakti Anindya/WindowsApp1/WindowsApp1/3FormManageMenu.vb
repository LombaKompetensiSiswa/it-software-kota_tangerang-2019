Imports System.Data.SqlClient

Public Class FrmMnMenu
    Private Sub FrmMnMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMKRestorantDataSet2.Msmenu' table. You can move, or remove it, as needed.
        Me.MsmenuTableAdapter.Fill(Me.SMKRestorantDataSet2.Msmenu)

    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Dim row = DGV.CurrentRow
        TxID.Text = row.Cells(0).Value.ToString
        TxName.Text = row.Cells(1).Value.ToString
        TxPrice.Text = row.Cells(2).Value.ToString
        TxPho.Text = row.Cells(3).Value.ToString
        Pho.ImageLocation = TxPho.Text


    End Sub


    Private Sub BIns_Click(sender As Object, e As EventArgs) Handles BIns.Click

        Dim i = New SqlCommand("INSERT INTO msmenu (Name, Price, Photo) VALUES ('" & TxName.Text & "','" & TxPrice.Text & "','" & TxPho.Text & "')", cn)
        i.ExecuteNonQuery()
        MsgBox("Inserted.")
        Me.MsmenuTableAdapter.Fill(Me.SMKRestorantDataSet2.Msmenu)

    End Sub

    Private Sub BUpd_Click(sender As Object, e As EventArgs) Handles BUpd.Click

        Dim i = New SqlCommand("UPDATE msmenu SET Name = '" & TxName.Text & "', Price = '" & TxPrice.Text & "', Photo = '" & TxPho.Text & "' WHERE MenuID = '" & TxID.Text & "'", cn)
        i.ExecuteNonQuery()
        MsgBox("Updated.")
        Me.MsmenuTableAdapter.Fill(Me.SMKRestorantDataSet2.Msmenu)

    End Sub

    Private Sub BDel_Click(sender As Object, e As EventArgs) Handles BDel.Click

        Dim i = New SqlCommand("DELETE FROM msmenu WHERE MenuID = '" & TxID.Text & "'", cn)
        i.ExecuteNonQuery()
        MsgBox("Deleted.")
        Me.MsmenuTableAdapter.Fill(Me.SMKRestorantDataSet2.Msmenu)

    End Sub

    Private Sub InsPho_Click(sender As Object, e As EventArgs) Handles InsPho.Click
        Dim ofd As New OpenFileDialog
        ofd.InitialDirectory = "C:\"
        ofd.Filter = "(*png, *jpg)|*.png;*.jpg"

        Dim result As DialogResult = ofd.ShowDialog
        If result = DialogResult.OK And ofd.FileName <> String.Empty Then

            Pho.Image = Image.FromFile(ofd.FileName)
            TxPho.Text = ofd.FileName

            MsgBox("Uploaded!")

        Else
            MsgBox("Gagal.")
        End If
    End Sub

    Private Sub TxPrice_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxPrice.KeyPress

        If Not Not (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            MsgBox("Hanya Masukan Angka (0-9)")
        End If

        If Not Not (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True

        End If
    End Sub

End Class