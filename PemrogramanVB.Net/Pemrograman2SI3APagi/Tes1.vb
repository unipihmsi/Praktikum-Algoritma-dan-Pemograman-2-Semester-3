Public Class Tes1

    Private Sub Tes1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.Columns.Add("NAMA", 300)
        ListView1.Columns.Add("NAMA PANGGILAN", 200)
        txtNim.Text = txtNim.Text
        txtNama.Focus()
    End Sub

    Private Sub bTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bTambah.Click
        Dim Arr(2) As String
        Arr(0) = txtNim.Text
        Arr(1) = txtNama.Text

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(Arr(0))
        listitem.SubItems.Add(Arr(1))
        listitem.SubItems.Add(Arr(2))
        txtNim.Text = txtNim.Text
        txtNama.Text = ""
        txtNama.Focus()
    End Sub
End Class