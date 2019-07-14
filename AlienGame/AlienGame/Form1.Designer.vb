<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Alien1 = New System.Windows.Forms.PictureBox()
        Me.Xpos = New System.Windows.Forms.TextBox()
        Me.Ypos = New System.Windows.Forms.TextBox()
        Me.RightAdd = New System.Windows.Forms.TextBox()
        Me.DownAdd = New System.Windows.Forms.TextBox()
        Me.MoveAlien = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Alien2 = New System.Windows.Forms.PictureBox()
        Me.Gun = New System.Windows.Forms.PictureBox()
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.FireTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Alien3 = New System.Windows.Forms.PictureBox()
        Me.Alien4 = New System.Windows.Forms.PictureBox()
        Me.Alien5 = New System.Windows.Forms.PictureBox()
        Me.btStart = New System.Windows.Forms.Button()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbRestart = New System.Windows.Forms.PictureBox()
        Me.lbLevel = New System.Windows.Forms.Label()
        Me.lbScore = New System.Windows.Forms.Label()
        Me.MoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SpecialAlien = New System.Windows.Forms.PictureBox()
        Me.SpecAlienMoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Alien6 = New System.Windows.Forms.PictureBox()
        Me.Alien7 = New System.Windows.Forms.PictureBox()
        Me.Alien8 = New System.Windows.Forms.PictureBox()
        Me.Alien9 = New System.Windows.Forms.PictureBox()
        Me.Alien10 = New System.Windows.Forms.PictureBox()
        Me.SpecAlienRst = New System.Windows.Forms.PictureBox()
        CType(Me.Alien1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbRestart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpecialAlien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpecAlienRst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Alien1
        '
        Me.Alien1.Location = New System.Drawing.Point(45, 90)
        Me.Alien1.Name = "Alien1"
        Me.Alien1.Size = New System.Drawing.Size(81, 87)
        Me.Alien1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien1.TabIndex = 0
        Me.Alien1.TabStop = False
        '
        'Xpos
        '
        Me.Xpos.Enabled = False
        Me.Xpos.Location = New System.Drawing.Point(45, 38)
        Me.Xpos.Name = "Xpos"
        Me.Xpos.Size = New System.Drawing.Size(100, 20)
        Me.Xpos.TabIndex = 1
        Me.Xpos.Text = "100"
        Me.Xpos.Visible = False
        '
        'Ypos
        '
        Me.Ypos.Enabled = False
        Me.Ypos.Location = New System.Drawing.Point(165, 38)
        Me.Ypos.Name = "Ypos"
        Me.Ypos.Size = New System.Drawing.Size(100, 20)
        Me.Ypos.TabIndex = 2
        Me.Ypos.Text = "100"
        Me.Ypos.Visible = False
        '
        'RightAdd
        '
        Me.RightAdd.Enabled = False
        Me.RightAdd.Location = New System.Drawing.Point(271, 38)
        Me.RightAdd.Name = "RightAdd"
        Me.RightAdd.Size = New System.Drawing.Size(100, 20)
        Me.RightAdd.TabIndex = 3
        Me.RightAdd.Text = "20"
        Me.RightAdd.Visible = False
        '
        'DownAdd
        '
        Me.DownAdd.Enabled = False
        Me.DownAdd.Location = New System.Drawing.Point(377, 38)
        Me.DownAdd.Name = "DownAdd"
        Me.DownAdd.Size = New System.Drawing.Size(100, 20)
        Me.DownAdd.TabIndex = 4
        Me.DownAdd.Text = "0"
        Me.DownAdd.Visible = False
        '
        'MoveAlien
        '
        Me.MoveAlien.Enabled = False
        Me.MoveAlien.Location = New System.Drawing.Point(523, 35)
        Me.MoveAlien.Name = "MoveAlien"
        Me.MoveAlien.Size = New System.Drawing.Size(103, 23)
        Me.MoveAlien.TabIndex = 5
        Me.MoveAlien.Text = "MoveTheAlien"
        Me.MoveAlien.UseVisualStyleBackColor = True
        Me.MoveAlien.Visible = False
        '
        'Timer1
        '
        '
        'Alien2
        '
        Me.Alien2.Location = New System.Drawing.Point(147, 90)
        Me.Alien2.Name = "Alien2"
        Me.Alien2.Size = New System.Drawing.Size(81, 87)
        Me.Alien2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien2.TabIndex = 6
        Me.Alien2.TabStop = False
        '
        'Gun
        '
        Me.Gun.BackColor = System.Drawing.Color.Blue
        Me.Gun.Location = New System.Drawing.Point(410, 655)
        Me.Gun.Name = "Gun"
        Me.Gun.Size = New System.Drawing.Size(100, 21)
        Me.Gun.TabIndex = 7
        Me.Gun.TabStop = False
        '
        'Bullet
        '
        Me.Bullet.BackColor = System.Drawing.Color.Yellow
        Me.Bullet.Location = New System.Drawing.Point(459, 628)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(10, 21)
        Me.Bullet.TabIndex = 9
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'FireTimer
        '
        Me.FireTimer.Interval = 1
        '
        'Alien3
        '
        Me.Alien3.Location = New System.Drawing.Point(254, 90)
        Me.Alien3.Name = "Alien3"
        Me.Alien3.Size = New System.Drawing.Size(81, 87)
        Me.Alien3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien3.TabIndex = 10
        Me.Alien3.TabStop = False
        '
        'Alien4
        '
        Me.Alien4.Location = New System.Drawing.Point(356, 90)
        Me.Alien4.Name = "Alien4"
        Me.Alien4.Size = New System.Drawing.Size(81, 87)
        Me.Alien4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien4.TabIndex = 11
        Me.Alien4.TabStop = False
        '
        'Alien5
        '
        Me.Alien5.Location = New System.Drawing.Point(459, 90)
        Me.Alien5.Name = "Alien5"
        Me.Alien5.Size = New System.Drawing.Size(81, 87)
        Me.Alien5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien5.TabIndex = 12
        Me.Alien5.TabStop = False
        '
        'btStart
        '
        Me.btStart.BackColor = System.Drawing.Color.Black
        Me.btStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btStart.ForeColor = System.Drawing.Color.Yellow
        Me.btStart.Location = New System.Drawing.Point(258, 367)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(392, 64)
        Me.btStart.TabIndex = 13
        Me.btStart.Text = "Click Here To Start"
        Me.btStart.UseVisualStyleBackColor = False
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.BackColor = System.Drawing.Color.Black
        Me.lbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.ForeColor = System.Drawing.Color.Yellow
        Me.lbTitle.Location = New System.Drawing.Point(119, 203)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(664, 108)
        Me.lbTitle.TabIndex = 15
        Me.lbTitle.Text = "Alien Invaders"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lbTitle)
        Me.Panel1.Controls.Add(Me.btStart)
        Me.Panel1.Location = New System.Drawing.Point(13, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(939, 690)
        Me.Panel1.TabIndex = 16
        '
        'pbRestart
        '
        Me.pbRestart.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pbRestart.Location = New System.Drawing.Point(459, 629)
        Me.pbRestart.Name = "pbRestart"
        Me.pbRestart.Size = New System.Drawing.Size(10, 20)
        Me.pbRestart.TabIndex = 17
        Me.pbRestart.TabStop = False
        Me.pbRestart.Visible = False
        '
        'lbLevel
        '
        Me.lbLevel.AutoSize = True
        Me.lbLevel.BackColor = System.Drawing.Color.Black
        Me.lbLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLevel.ForeColor = System.Drawing.Color.Yellow
        Me.lbLevel.Location = New System.Drawing.Point(803, 9)
        Me.lbLevel.Name = "lbLevel"
        Me.lbLevel.Size = New System.Drawing.Size(109, 33)
        Me.lbLevel.TabIndex = 19
        Me.lbLevel.Text = "Level 1"
        '
        'lbScore
        '
        Me.lbScore.AutoSize = True
        Me.lbScore.BackColor = System.Drawing.Color.Black
        Me.lbScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbScore.ForeColor = System.Drawing.Color.Yellow
        Me.lbScore.Location = New System.Drawing.Point(803, 57)
        Me.lbScore.Name = "lbScore"
        Me.lbScore.Size = New System.Drawing.Size(123, 33)
        Me.lbScore.TabIndex = 20
        Me.lbScore.Text = "Score: 0"
        '
        'MoveTimer
        '
        Me.MoveTimer.Interval = 1
        '
        'SpecialAlien
        '
        Me.SpecialAlien.Location = New System.Drawing.Point(1006, 102)
        Me.SpecialAlien.Name = "SpecialAlien"
        Me.SpecialAlien.Size = New System.Drawing.Size(81, 87)
        Me.SpecialAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SpecialAlien.TabIndex = 26
        Me.SpecialAlien.TabStop = False
        '
        'SpecAlienMoveTimer
        '
        '
        'Alien6
        '
        Me.Alien6.Location = New System.Drawing.Point(45, 210)
        Me.Alien6.Name = "Alien6"
        Me.Alien6.Size = New System.Drawing.Size(81, 87)
        Me.Alien6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien6.TabIndex = 27
        Me.Alien6.TabStop = False
        '
        'Alien7
        '
        Me.Alien7.Location = New System.Drawing.Point(147, 210)
        Me.Alien7.Name = "Alien7"
        Me.Alien7.Size = New System.Drawing.Size(81, 87)
        Me.Alien7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien7.TabIndex = 28
        Me.Alien7.TabStop = False
        '
        'Alien8
        '
        Me.Alien8.Location = New System.Drawing.Point(254, 210)
        Me.Alien8.Name = "Alien8"
        Me.Alien8.Size = New System.Drawing.Size(81, 87)
        Me.Alien8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien8.TabIndex = 29
        Me.Alien8.TabStop = False
        '
        'Alien9
        '
        Me.Alien9.Location = New System.Drawing.Point(356, 207)
        Me.Alien9.Name = "Alien9"
        Me.Alien9.Size = New System.Drawing.Size(81, 87)
        Me.Alien9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien9.TabIndex = 30
        Me.Alien9.TabStop = False
        '
        'Alien10
        '
        Me.Alien10.Location = New System.Drawing.Point(459, 207)
        Me.Alien10.Name = "Alien10"
        Me.Alien10.Size = New System.Drawing.Size(81, 87)
        Me.Alien10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien10.TabIndex = 31
        Me.Alien10.TabStop = False
        '
        'SpecAlienRst
        '
        Me.SpecAlienRst.Location = New System.Drawing.Point(1006, 102)
        Me.SpecAlienRst.Name = "SpecAlienRst"
        Me.SpecAlienRst.Size = New System.Drawing.Size(81, 87)
        Me.SpecAlienRst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SpecAlienRst.TabIndex = 32
        Me.SpecAlienRst.TabStop = False
        Me.SpecAlienRst.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(954, 688)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.Gun)
        Me.Controls.Add(Me.MoveAlien)
        Me.Controls.Add(Me.DownAdd)
        Me.Controls.Add(Me.RightAdd)
        Me.Controls.Add(Me.Ypos)
        Me.Controls.Add(Me.Xpos)
        Me.Controls.Add(Me.pbRestart)
        Me.Controls.Add(Me.lbLevel)
        Me.Controls.Add(Me.lbScore)
        Me.Controls.Add(Me.Alien3)
        Me.Controls.Add(Me.Alien4)
        Me.Controls.Add(Me.Alien5)
        Me.Controls.Add(Me.Alien2)
        Me.Controls.Add(Me.Alien1)
        Me.Controls.Add(Me.SpecialAlien)
        Me.Controls.Add(Me.Alien6)
        Me.Controls.Add(Me.Alien7)
        Me.Controls.Add(Me.Alien8)
        Me.Controls.Add(Me.Alien9)
        Me.Controls.Add(Me.Alien10)
        Me.Controls.Add(Me.SpecAlienRst)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Alien1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbRestart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpecialAlien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpecAlienRst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Alien1 As System.Windows.Forms.PictureBox
    Friend WithEvents Xpos As System.Windows.Forms.TextBox
    Friend WithEvents Ypos As System.Windows.Forms.TextBox
    Friend WithEvents RightAdd As System.Windows.Forms.TextBox
    Friend WithEvents DownAdd As System.Windows.Forms.TextBox
    Friend WithEvents MoveAlien As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Alien2 As System.Windows.Forms.PictureBox
    Friend WithEvents Gun As System.Windows.Forms.PictureBox
    Friend WithEvents Bullet As System.Windows.Forms.PictureBox
    Friend WithEvents FireTimer As System.Windows.Forms.Timer
    Friend WithEvents Alien3 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien4 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien5 As System.Windows.Forms.PictureBox
    Friend WithEvents btStart As System.Windows.Forms.Button
    Friend WithEvents lbTitle As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pbRestart As System.Windows.Forms.PictureBox
    Friend WithEvents lbLevel As System.Windows.Forms.Label
    Friend WithEvents lbScore As System.Windows.Forms.Label
    Friend WithEvents MoveTimer As System.Windows.Forms.Timer
    Friend WithEvents SpecialAlien As System.Windows.Forms.PictureBox
    Friend WithEvents SpecAlienMoveTimer As System.Windows.Forms.Timer
    Friend WithEvents Alien6 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien7 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien8 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien9 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien10 As System.Windows.Forms.PictureBox
    Friend WithEvents SpecAlienRst As System.Windows.Forms.PictureBox

End Class
