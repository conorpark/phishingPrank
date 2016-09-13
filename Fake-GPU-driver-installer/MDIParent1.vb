Imports System.Windows.Forms

Public Class MDIParent1
    Dim m_ChildFormNumber As Integer 'mandatory vb.net
    Dim timervalue5 As Integer

    Private Const GWL_EXSTYLE As Integer = (-20)
    Private Const WS_EX_CLIENTEDGE As Integer = &H200

    Private Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal handle As IntPtr, ByVal nIndex As Integer) As Integer
    Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal handle As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) 'mandatory vb.net
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                Dim exstyle As Integer = GetWindowLong(ctl.Handle, GWL_EXSTYLE)
                exstyle = exstyle And Not WS_EX_CLIENTEDGE
                SetWindowLong(ctl.Handle, GWL_EXSTYLE, exstyle)
                Exit For
            End If
        Next
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.FormBorderStyle = FormBorderStyle.None
        ProgressBar5.Style = ProgressBarStyle.Blocks
        ProgressBar5.Maximum = 360
        Form12.MdiParent = Me
        Form12.Show()
        Timer5.Interval = 50
        Timer5.Start()

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If ProgressBar5.Value = 0 Then
            Threading.Thread.Sleep(5000)
        End If
        ProgressBar5.Value += 1
        If ProgressBar5.Value = 60 Then
            Form7.MdiParent = Me
            Form7.Show()
            Form7.Location = Form12.Location
            Form12.Hide()
        End If
        If ProgressBar5.Value = 120 Then
            Form8.MdiParent = Me
            Form8.Show()
            Form8.Location = Form7.Location
            Form7.Hide()
        End If
        If ProgressBar5.Value = 180 Then
            Form9.MdiParent = Me
            Form9.Show()
            Form9.Location = Form8.Location
            Form8.Hide()
        End If
        If ProgressBar5.Value = 240 Then
            Form10.MdiParent = Me
            Form10.Show()
            Form10.Location = Form9.Location
            Form9.Hide()
        End If
        If ProgressBar5.Value = 300 Then
            Form11.MdiParent = Me
            Form11.Show()
            Form11.Location = Form10.Location
            Form10.Hide()
        End If
        If ProgressBar5.Value = 360 Then
            Timer5.Stop()
            Form6.Show()
            Form11.Hide()
            Me.Hide()
        End If
    End Sub
End Class




