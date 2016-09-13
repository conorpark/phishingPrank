Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_cancel2.BackColor = Color.Transparent
        btn_cancel2.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_cancel2.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_cancel2.FlatAppearance.BorderSize = 0
        btn_cancel2.FlatStyle = FlatStyle.Flat
        btn_agree.BackColor = Color.Transparent
        btn_agree.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_agree.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_agree.FlatAppearance.BorderSize = 0
        btn_agree.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel2.Click
        Application.Exit()
    End Sub

    Private Sub btn_agree_Click(sender As Object, e As EventArgs) Handles btn_agree.Click
        Dim thirdform As New Form3
        thirdform.Show()
        Hide()
        'hide
    End Sub
End Class