Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PreVentFlicker()
        btn_link10.BackColor = Color.Transparent
        btn_link10.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_link10.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_link10.FlatAppearance.BorderSize = 0
        btn_link10.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub

    Private Sub btn_link10_Click(sender As Object, e As EventArgs) Handles btn_link10.Click
        Process.Start("IExplore.exe", "https://shield.nvidia.com/games/android/borderlandstps")
    End Sub
End Class