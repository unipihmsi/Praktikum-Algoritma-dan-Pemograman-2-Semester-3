Public Class Tes2
    Dim membaca, musik, olahraga As String

    Private Sub Tes2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        lblNpm.Text = txtNpm.Text
        lblNama.Text = txtNama.Text
        Label1.Text = membaca
        Label6.Text = musik
        Label9.Text = olahraga

    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Close()
    End Sub

    Private Sub CheckBoxMembaca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxMembaca.CheckedChanged
        membaca = CheckBoxMembaca.Text
    End Sub

    Private Sub CheckBoxMusik_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxMusik.CheckedChanged
        musik = CheckBoxMusik.Text
    End Sub

    Private Sub CheckBoxOlahraga_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxOlahraga.CheckedChanged
        olahraga = CheckBoxOlahraga.Text
    End Sub
End Class