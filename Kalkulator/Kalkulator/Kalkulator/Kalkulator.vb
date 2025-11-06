Public Class FrmKalkulator
    Private Sub Btjumlah_Click(ByVal sender As System.Object, e As EventArgs) Handles Btjumlah.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(Txtangka1.Text)
        angka2 = Val(Txtangka2.Text)
        hasil = angka1 + angka2
        Txthasil.Text = hasil
    End Sub

    Private Sub Btkurang_Click(ByVal sender As System.Object, e As EventArgs) Handles Btkurang.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(Txtangka1.Text)
        angka2 = Val(Txtangka2.Text)
        hasil = angka1 - angka2
        Txthasil.Text = hasil
    End Sub

    Private Sub Btbagi_Click(ByVal sender As System.Object, e As EventArgs) Handles Btbagi.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(Txtangka1.Text)
        angka2 = Val(Txtangka2.Text)
        hasil = angka1 / angka2
        Txthasil.Text = hasil
    End Sub

    Private Sub Btkali_Click(ByVal sender As System.Object, e As EventArgs) Handles Btkali.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(Txtangka1.Text)
        angka2 = Val(Txtangka2.Text)
        hasil = angka1 * angka2
        Txthasil.Text = hasil
    End Sub
End Class
