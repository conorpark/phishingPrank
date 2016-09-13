Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_cancel4.BackColor = Color.Transparent
        btn_cancel4.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_cancel4.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_cancel4.FlatAppearance.BorderSize = 0
        btn_cancel4.FlatStyle = FlatStyle.Flat
        btn_next4.BackColor = Color.Transparent
        btn_next4.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_next4.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_next4.FlatAppearance.BorderSize = 0
        btn_next4.FlatStyle = FlatStyle.Flat
        btn_back4.BackColor = Color.Transparent
        btn_back4.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_back4.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_back4.FlatAppearance.BorderSize = 0
        btn_back4.FlatStyle = FlatStyle.Flat
        CheckedListBox2.ClientSize = New Size(TextRenderer.MeasureText(CheckedListBox2.Items.ToString(), CheckedListBox2.Font).Width + 40, CheckedListBox2.GetItemRectangle(0).Height * CheckedListBox2.Items.Count)
    End Sub

    Private Sub btn_back4_Click(sender As Object, e As EventArgs) Handles btn_back4.Click
        Dim thirdform As New Form3
        thirdform.Show()
        Hide()
    End Sub

    Private Sub btn_cancel4_Click(sender As Object, e As EventArgs) Handles btn_cancel4.Click
        Application.Exit()
        Close()
    End Sub

    Private Sub btn_next4_Click(sender As Object, e As EventArgs) Handles btn_next4.Click
        Dim fifthform As New MDIParent1()
        fifthform.Show()
        Hide()
    End Sub
End Class

