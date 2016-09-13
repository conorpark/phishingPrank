<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.btn_link8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_link8
        '
        Me.btn_link8.BackColor = System.Drawing.Color.Transparent
        Me.btn_link8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_link8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_link8.ForeColor = System.Drawing.Color.Transparent
        Me.btn_link8.Location = New System.Drawing.Point(12, 220)
        Me.btn_link8.Name = "btn_link8"
        Me.btn_link8.Size = New System.Drawing.Size(107, 33)
        Me.btn_link8.TabIndex = 1
        Me.btn_link8.UseVisualStyleBackColor = False
        '
        'Form8
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Nvidia_Graphics_Driver_Installer.My.Resources.Resources.Screenshot_1002
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(441, 264)
        Me.Controls.Add(Me.btn_link8)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form8"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_link8 As Button
End Class
