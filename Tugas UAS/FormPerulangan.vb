Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTuliskanText.Text = ""
        txtJmlPerulangan.Text = ""


    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click

        If txtTuliskanText.Text = "" Then
            MessageBox.Show("Input tidak boleh kosong!", "Pesan Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Dim teks As String
        Dim jumlah As Integer
        teks = txtTuliskanText.Text
        jumlah = txtJmlPerulangan.Text



        For i = 1 To jumlah
            ListBox1.Items.Add(teks)
        Next i

    End Sub


End Class
