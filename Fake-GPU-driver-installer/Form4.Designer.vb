<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_back4 = New System.Windows.Forms.Button()
        Me.btn_next4 = New System.Windows.Forms.Button()
        Me.btn_cancel4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.CheckedListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Items.AddRange(New Object() {"Graphics Driver                            367.55             364.75", "3D Vision Controller Driver      352.65             352.65", "3D Vision Driver                           365.77             364.75", "HD Audio Driver                           1.3.34.4          1.3.34.4", "Miracast Virtual Audio               365.38             364.75", "PhysX System Software           9.15.0428      9.15.0022"})
        Me.CheckedListBox2.Location = New System.Drawing.Point(134, 119)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(295, 79)
        Me.CheckedListBox2.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(136, 202)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Nvidia_Graphics_Driver_Installer.My.Resources.Resources.Screenshot_96
        Me.PictureBox1.Location = New System.Drawing.Point(134, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(296, 17)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btn_back4
        '
        Me.btn_back4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back4.Location = New System.Drawing.Point(221, 282)
        Me.btn_back4.Name = "btn_back4"
        Me.btn_back4.Size = New System.Drawing.Size(65, 19)
        Me.btn_back4.TabIndex = 5
        Me.btn_back4.UseVisualStyleBackColor = True
        '
        'btn_next4
        '
        Me.btn_next4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_next4.Location = New System.Drawing.Point(289, 281)
        Me.btn_next4.Name = "btn_next4"
        Me.btn_next4.Size = New System.Drawing.Size(66, 21)
        Me.btn_next4.TabIndex = 6
        Me.btn_next4.UseVisualStyleBackColor = True
        '
        'btn_cancel4
        '
        Me.btn_cancel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel4.Location = New System.Drawing.Point(365, 282)
        Me.btn_cancel4.Name = "btn_cancel4"
        Me.btn_cancel4.Size = New System.Drawing.Size(67, 20)
        Me.btn_cancel4.TabIndex = 7
        Me.btn_cancel4.UseVisualStyleBackColor = True
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
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Version 367.55"
        '
        'Form4
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Nvidia_Graphics_Driver_Installer.My.Resources.Resources.Screenshot_86
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(441, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_cancel4)
        Me.Controls.Add(Me.btn_next4)
        Me.Controls.Add(Me.btn_back4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CheckedListBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_back4 As Button
    Friend WithEvents btn_next4 As Button
    Friend WithEvents btn_cancel4 As Button
    Friend WithEvents Label1 As Label
End Class
