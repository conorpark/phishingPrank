Imports System.Net
Public Class Form8

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PreVentFlicker()
        btn_link8.BackColor = Color.Transparent
        btn_link8.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_link8.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_link8.FlatAppearance.BorderSize = 0
        btn_link8.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub

    Private Sub btn_link8_Click(sender As Object, e As EventArgs) Handles btn_link8.Click
        Process.Start("IExplore.exe", "http://www.geforce.com/GetRiseOfTheTombRaider")
    End Sub
End Class