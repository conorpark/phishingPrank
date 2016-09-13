Public Class Form12
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PreVentFlicker()
        btn_link12.BackColor = Color.Transparent
        btn_link12.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_link12.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_link12.FlatAppearance.BorderSize = 0
        btn_link12.FlatStyle = FlatStyle.Flat
    End Sub
    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub

    Private Sub btn_link12_Click(sender As Object, e As EventArgs) Handles btn_link12.Click
        Process.Start("IExplore.exe", "https://shield.nvidia.com/")
    End Sub
End Class