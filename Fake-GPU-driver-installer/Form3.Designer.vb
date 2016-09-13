<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.rb_express = New System.Windows.Forms.RadioButton()
        Me.rb_custom = New System.Windows.Forms.RadioButton()
        Me.btn_cancel3 = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rb_express
        '
        Me.rb_express.AutoSize = True
        Me.rb_express.BackColor = System.Drawing.Color.Transparent
        Me.rb_express.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.rb_express.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_express.Location = New System.Drawing.Point(134, 89)
        Me.rb_express.Name = "rb_express"
        Me.rb_express.Size = New System.Drawing.Size(17, 16)
        Me.rb_express.TabIndex = 0
        Me.rb_express.TabStop = True
        Me.rb_express.UseVisualStyleBackColor = False
        '
        'rb_custom
        '
        Me.rb_custom.AutoSize = True
        Me.rb_custom.BackColor = System.Drawing.Color.Transparent
        Me.rb_custom.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.rb_custom.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_custom.Location = New System.Drawing.Point(134, 150)
        Me.rb_custom.Name = "rb_custom"
        Me.rb_custom.Size = New System.Drawing.Size(17, 16)
        Me.rb_custom.TabIndex = 1
        Me.rb_custom.TabStop = True
        Me.rb_custom.UseVisualStyleBackColor = False
        '
        'btn_cancel3
        '
        Me.btn_cancel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel3.Location = New System.Drawing.Point(366, 282)
        Me.btn_cancel3.Name = "btn_cancel3"
        Me.btn_cancel3.Size = New System.Drawing.Size(68, 21)
        Me.btn_cancel3.TabIndex = 2
        Me.btn_cancel3.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_next.Location = New System.Drawing.Point(289, 282)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(67, 22)
        Me.btn_next.TabIndex = 3
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.Location = New System.Drawing.Point(221, 280)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(66, 24)
        Me.btn_back.TabIndex = 4
        Me.btn_back.UseVisualStyleBackColor = True
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
        'Form3
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Nvidia_Graphics_Driver_Installer.My.Resources.Resources.Screenshot_81
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(441, 310)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_cancel3)
        Me.Controls.Add(Me.rb_custom)
        Me.Controls.Add(Me.rb_express)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rb_express As RadioButton
    Friend WithEvents rb_custom As RadioButton
    Friend WithEvents btn_cancel3 As Button
    Friend WithEvents btn_next As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents Label1 As Label
End Class
