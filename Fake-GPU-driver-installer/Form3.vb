Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_cancel3.BackColor = Color.Transparent
        btn_cancel3.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_cancel3.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_cancel3.FlatAppearance.BorderSize = 0
        btn_cancel3.FlatStyle = FlatStyle.Flat
        btn_next.BackColor = Color.Transparent
        btn_next.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_next.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_next.FlatAppearance.BorderSize = 0
        btn_next.FlatStyle = FlatStyle.Flat
        btn_back.BackColor = Color.Transparent
        btn_back.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_back.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_back.FlatAppearance.BorderSize = 0
        btn_back.FlatStyle = FlatStyle.Flat
        rb_express.Size = New Size(19, 18)
        rb_custom.Size = New Size(19, 18)
        rb_express.Checked = True
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim secondform As New Form2
        secondform.Show()
        Form1.Hide()
        Me.Hide()
    End Sub

    Private Sub btn_cancel3_Click(sender As Object, e As EventArgs) Handles btn_cancel3.Click
        Application.Exit()
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        If rb_express.Checked = True Then
            MDIParent1.Show()
            Hide()
        ElseIf rb_custom.Checked = True Then
            Dim fourthform As New Form4
            fourthform.Show()
            Hide()
        End If
    End Sub

End Class