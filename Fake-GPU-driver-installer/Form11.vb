Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PreVentFlicker()
        btn_link11.BackColor = Color.Transparent
        btn_link11.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_link11.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_link11.FlatAppearance.BorderSize = 0
        btn_link11.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub

    Private Sub btn_link11_Click(sender As Object, e As EventArgs) Handles btn_link11.Click
        Process.Start("IExplore.exe", "https://shield.nvidia.com/")
    End Sub
End Class