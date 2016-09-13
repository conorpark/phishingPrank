<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btn_cancel2 = New System.Windows.Forms.Button()
        Me.btn_agree = New System.Windows.Forms.Button()
        Me.rtb_terms = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_cancel2
        '
        Me.btn_cancel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel2.Location = New System.Drawing.Point(365, 282)
        Me.btn_cancel2.Name = "btn_cancel2"
        Me.btn_cancel2.Size = New System.Drawing.Size(67, 24)
        Me.btn_cancel2.TabIndex = 0
        Me.btn_cancel2.UseVisualStyleBackColor = True
        '
        'btn_agree
        '
        Me.btn_agree.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_agree.Location = New System.Drawing.Point(219, 282)
        Me.btn_agree.Name = "btn_agree"
        Me.btn_agree.Size = New System.Drawing.Size(137, 22)
        Me.btn_agree.TabIndex = 1
        Me.btn_agree.UseVisualStyleBackColor = True
        '
        'rtb_terms
        '
        Me.rtb_terms.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.rtb_terms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_terms.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.rtb_terms.Location = New System.Drawing.Point(135, 104)
        Me.rtb_terms.Name = "rtb_terms"
        Me.rtb_terms.Size = New System.Drawing.Size(294, 137)
        Me.rtb_terms.TabIndex = 2
        Me.rtb_terms.Text = resources.GetString("rtb_terms.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("AzoSansW01-Medium", 7.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Version 367.55"
        '
        'Form2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Nvidia_Graphics_Driver_Installer.My.Resources.Resources.Screenshot_80
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(441, 310)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtb_terms)
        Me.Controls.Add(Me.btn_agree)
        Me.Controls.Add(Me.btn_cancel2)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancel2 As Button
    Friend WithEvents btn_agree As Button
    Friend WithEvents rtb_terms As RichTextBox
    Friend WithEvents Label1 As Label
End Class
