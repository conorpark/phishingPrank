Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PreVentFlicker()
        btn_link9.BackColor = Color.Transparent
        btn_link9.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_link9.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_link9.FlatAppearance.BorderSize = 0
        btn_link9.FlatStyle = FlatStyle.Flat
    End Sub
    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub

    Private Sub btn_link9_Click(sender As Object, e As EventArgs) Handles btn_link9.Click
        Process.Start("IExplore.exe", "https://blogs.nvidia.com/blog/2016/02/22/htc-vive/")
    End Sub
End Class