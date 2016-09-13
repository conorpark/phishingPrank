<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_link12 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_link12
        '
        Me.btn_link12.BackColor = System.Drawing.Color.Transparent
        Me.btn_link12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_link12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_link12.ForeColor = System.Drawing.Color.Transparent
        Me.btn_link12.Location = New System.Drawing.Point(12, 219)
        Me.btn_link12.Name = "btn_link12"
        Me.btn_link12.Size = New System.Drawing.Size(107, 33)
        Me.btn_link12.TabIndex = 2
        Me.btn_link12.UseVisualStyleBackColor = False
        '
        'Form12
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackgroundImage = Global.Nvidia_Graphics_Driver_Installer.My.Resources.Resources.Screenshot_98
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(441, 264)
        Me.Controls.Add(Me.btn_link12)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form12"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_link12 As Button
End Class
