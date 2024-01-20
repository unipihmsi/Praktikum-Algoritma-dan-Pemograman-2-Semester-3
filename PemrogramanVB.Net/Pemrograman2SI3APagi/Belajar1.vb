Public Class Belajar1

    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        Dim arr(4) As String
        arr(0) = txtNim.Text
        arr(1) = txtNama.Text
        arr(2) = cbHobi.Text
        arr(3) = cbSemester.Text

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(arr(0))
        listitem.SubItems.Add(arr(1))
        listitem.SubItems.Add(arr(2))
        listitem.SubItems.Add(arr(3))
        
    End Sub

    Private Sub Belajar1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim arr(4, 1) As String
        arr(0, 0) = "NIM"
        arr(0, 1) = "NAMA"
        arr(1, 0) = "HOBI"
        arr(1, 1) = "SEMESTER"
        arr(2, 0) = "MEMBACA"
        arr(2, 1) = "MENULIS"
        arr(3, 0) = "MENGGAMBAR"
        arr(3, 1) = "SATU"
        arr(4, 0) = "DUA"
        arr(4, 1) = "TIGA"
        ListView1.GridLines = True
        ListView1.View = View.Details


        For baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(arr(baris, kolom), 100)
            Next kolom
        Next baris

        For baris = 2 To 2
            For kolom = 0 To 1
                cbHobi.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris

        For baris = 3 To 3
            For kolom = 0 To 0
                cbHobi.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris

        For baris = 3 To 3
            For kolom = 1 To 1
                cbSemester.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris

        For baris = 4 To 4
            For kolom = 0 To 1
                cbSemester.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris
    End Sub
End Class