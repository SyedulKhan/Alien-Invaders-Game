Public Class Form1
#Region "Variables"
    Dim MoveLeft As Boolean
    Dim MoveRight As Boolean

    Dim Level As Integer = 1
    Dim Score As Integer = 0

#End Region

#Region "Keys"
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            MoveLeft = True
        End If
        If e.KeyCode = Keys.Right Then
            MoveRight = True
        End If
        If e.KeyCode = Keys.Q And Bullet.Visible = False Then
            Bullet.Top = Gun.Top - 30
            Bullet.Left = Gun.Left + 45
            pbRestart.Top = Gun.Top - 30
            pbRestart.Left = Gun.Left + 45
            Bullet.Visible = True
            FireTimer.Enabled = True
        End If

    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Left Then
            MoveLeft = False
        End If
        If e.KeyCode = Keys.Right Then
            MoveRight = False
        End If
    End Sub

#End Region

#Region "Timers"

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MoveAlien_Click(sender, e)
    End Sub
    Private Sub FireTimer_Tick(sender As Object, e As EventArgs) Handles FireTimer.Tick
        If Bullet.Visible = True Then
            Bullet.Location = New Point(Bullet.Location.X, Bullet.Location.Y - 60)
            If Bullet.Bounds.IntersectsWith(Alien1.Bounds) And Alien1.Visible = True Then
                Alien1.Visible = False
                Bullet.Visible = False
                Score += 10
                lbScore.Text = "Score: " & Score
            ElseIf Bullet.Bounds.IntersectsWith(Alien1.Bounds) And Alien1.Visible = False Then
                Score += 0
            End If
            If Bullet.Bounds.IntersectsWith(Alien2.Bounds) And Alien2.Visible = True Then
                Alien2.Visible = False
                Bullet.Visible = False
                Score += 10
                lbScore.Text = "Score: " & Score
            ElseIf Bullet.Bounds.IntersectsWith(Alien2.Bounds) And Alien2.Visible = False Then
                Score += 0
            End If
            If Bullet.Bounds.IntersectsWith(Alien3.Bounds) And Alien3.Visible = True Then
                Alien3.Visible = False
                Bullet.Visible = False
                Score += 10
                lbScore.Text = "Score: " & Score
            ElseIf Bullet.Bounds.IntersectsWith(Alien3.Bounds) And Alien3.Visible = False Then
                Score += 0
            End If
            If Bullet.Bounds.IntersectsWith(Alien4.Bounds) And Alien4.Visible = True Then
                Alien4.Visible = False
                Bullet.Visible = False
                Score += 10
                lbScore.Text = "Score: " & Score
            ElseIf Bullet.Bounds.IntersectsWith(Alien4.Bounds) And Alien4.Visible = False Then
                Score += 0
            End If
            If Bullet.Bounds.IntersectsWith(Alien5.Bounds) And Alien5.Visible = True Then
                Alien5.Visible = False
                Bullet.Visible = False
                Score += 10
                lbScore.Text = "Score: " & Score
            ElseIf Bullet.Bounds.IntersectsWith(Alien5.Bounds) And Alien5.Visible = False Then
                Score += 0
            End If
            If Bullet.Bounds.IntersectsWith(Alien6.Bounds) And Alien6.Visible = True Then
                Alien6.Visible = False
                Bullet.Visible = False
                Score += 10
                lbScore.Text = "Score: " & Score
            ElseIf Bullet.Bounds.IntersectsWith(Alien6.Bounds) And Alien6.Visible = False Then
                Score += 0
            End If
            If Bullet.Bounds.IntersectsWith(Alien7.Bounds) And Alien7.Visible = True Then
                Alien7.Visible = False
                Bullet.Visible = False
                Score += 10
                lbScore.Text = "Score: " & Score
            ElseIf Bullet.Bounds.IntersectsWith(Alien7.Bounds) And Alien7.Visible = False Then
                Score += 0
            End If
            If Bullet.Bounds.IntersectsWith(Alien8.Bounds) And Alien8.Visible = True Then
                Alien8.Visible = False
                Bullet.Visible = False
                Score += 10
                lbScore.Text = "Score: " & Score
            ElseIf Bullet.Bounds.IntersectsWith(Alien8.Bounds) And Alien8.Visible = False Then
                Score += 0
            End If
            If Bullet.Bounds.IntersectsWith(Alien9.Bounds) And Alien9.Visible = True Then
                Alien9.Visible = False
                Bullet.Visible = False
                Score += 10
                lbScore.Text = "Score: " & Score
            ElseIf Bullet.Bounds.IntersectsWith(Alien9.Bounds) And Alien9.Visible = False Then
                Score += 0
            End If
            If Bullet.Bounds.IntersectsWith(Alien10.Bounds) And Alien10.Visible = True Then
                Alien10.Visible = False
                Bullet.Visible = False
                Score += 10
                lbScore.Text = "Score: " & Score
            ElseIf Bullet.Bounds.IntersectsWith(Alien10.Bounds) And Alien10.Visible = False Then
                Score += 0
            End If
            If Bullet.Bounds.IntersectsWith(SpecialAlien.Bounds) And SpecialAlien.Visible = True Then
                SpecialAlien.Visible = False
                Bullet.Visible = False
                Score += 50
                lbScore.Text = "Score: " & Score
            ElseIf Bullet.Bounds.IntersectsWith(SpecialAlien.Bounds) And SpecialAlien.Visible = False Then
                Score += 0
            End If
            If Bullet.Location.Y < 0 Then
                FireTimer.Enabled = False
                Bullet.Visible = False
                Bullet.Location = pbRestart.Location
            End If
            If Alien1.Visible = False And Alien2.Visible = False And Alien3.Visible = False And Alien4.Visible = False And Alien5.Visible = False And Alien6.Visible = False And Alien7.Visible = False And Alien8.Visible = False And Alien9.Visible = False And Alien10.Visible = False Then
                Level = Level + 1
                lbLevel.Text = "Level " & Level
                Timer1.Enabled = False
                FireTimer.Enabled = False
                LevelRestart()
            End If

        End If

    End Sub

    Private Sub MoveTimer_Tick(sender As Object, e As EventArgs) Handles MoveTimer.Tick
        If MoveLeft = True Then
            Gun.Left -= 20
            If Gun.Left <= 0 Then
                Gun.Left += 20
            End If
        End If

        If MoveRight = True Then
            Gun.Left += 20
            If Gun.Left >= 850 Then
                Gun.Left -= 20
            End If
        End If
    End Sub

    Private Sub SpecAlienMoveTimer_Tick(sender As Object, e As EventArgs) Handles SpecAlienMoveTimer.Tick
        SpecialAlien.Image = Image.FromFile("Special Alien.png")
        SpecialAlien.Left -= 50
    End Sub
#End Region

#Region "Buttons"

    Private Sub btStart_Click(sender As Object, e As EventArgs) Handles btStart.Click
        lbTitle.Hide()
        btStart.Hide()
        Panel1.Visible = False
        Timer1.Enabled = True
        MoveTimer.Enabled = True
    End Sub

    Private Sub MoveAlien_Click(sender As Object, e As EventArgs) Handles MoveAlien.Click
        
        Alien1.Image = Image.FromFile("AlienUp.png")
        Alien1.Location = New Point(Xpos.Text, Ypos.Text)
        Alien2.Image = Image.FromFile("AlienUp.png")
        Alien2.Location = New Point(Xpos.Text + 100, Ypos.Text)
        Alien3.Image = Image.FromFile("AlienUp.png")
        Alien3.Location = New Point(Xpos.Text + 200, Ypos.Text)
        Alien4.Image = Image.FromFile("AlienUp.png")
        Alien4.Location = New Point(Xpos.Text + 300, Ypos.Text)
        Alien5.Image = Image.FromFile("AlienUp.png")
        Alien5.Location = New Point(Xpos.Text + 400, Ypos.Text)
        Alien6.Image = Image.FromFile("AlienUp.png")
        Alien6.Location = New Point(Xpos.Text, Ypos.Text + 100)
        Alien7.Image = Image.FromFile("AlienUp.png")
        Alien7.Location = New Point(Xpos.Text + 100, Ypos.Text + 100)
        Alien8.Image = Image.FromFile("AlienUp.png")
        Alien8.Location = New Point(Xpos.Text + 200, Ypos.Text + 100)
        Alien9.Image = Image.FromFile("AlienUp.png")
        Alien9.Location = New Point(Xpos.Text + 300, Ypos.Text + 100)
        Alien10.Image = Image.FromFile("AlienUp.png")
        Alien10.Location = New Point(Xpos.Text + 400, Ypos.Text + 100)
        
        Xpos.Text = Xpos.Text + Int(RightAdd.Text)
        Ypos.Text = Ypos.Text + Int(DownAdd.Text)

        If Xpos.Text Mod 40 = 0 Then
            Alien1.Image = Image.FromFile("AlienUp.png")
            Alien2.Image = Image.FromFile("AlienUp.png")
            Alien3.Image = Image.FromFile("AlienUp.png")
            Alien4.Image = Image.FromFile("AlienUp.png")
            Alien5.Image = Image.FromFile("AlienUp.png")
            Alien6.Image = Image.FromFile("AlienUp.png")
            Alien7.Image = Image.FromFile("AlienUp.png")
            Alien8.Image = Image.FromFile("AlienUp.png")
            Alien9.Image = Image.FromFile("AlienUp.png")
            Alien10.Image = Image.FromFile("AlienUp.png")
        Else
            Alien1.Image = Image.FromFile("AlienDown.png")
            Alien2.Image = Image.FromFile("AlienDown.png")
            Alien3.Image = Image.FromFile("AlienDown.png")
            Alien4.Image = Image.FromFile("AlienDown.png")
            Alien5.Image = Image.FromFile("AlienDown.png")
            Alien6.Image = Image.FromFile("AlienDown.png")
            Alien7.Image = Image.FromFile("AlienDown.png")
            Alien8.Image = Image.FromFile("AlienDown.png")
            Alien9.Image = Image.FromFile("AlienDown.png")
            Alien10.Image = Image.FromFile("AlienDown.png")
        End If

        If Alien1.Left <= 20 And Alien1.Visible = True Then
            RightAdd.Text = 20
            Ypos.Text += 10
        ElseIf Alien2.Left <= 20 And Alien2.Visible = True Then
            RightAdd.Text = 20
            Ypos.Text += 10
        ElseIf Alien3.Left <= 20 And Alien3.Visible = True Then
            RightAdd.Text = 20
            Ypos.Text += 10
        ElseIf Alien4.Left <= 20 And Alien4.Visible = True Then
            RightAdd.Text = 20
            Ypos.Text += 10
        ElseIf Alien5.Left <= 20 And Alien5.Visible = True Then
            RightAdd.Text = 20
            Ypos.Text += 10
        ElseIf Alien6.Left <= 20 And Alien6.Visible = True Then
            RightAdd.Text = 20
            Ypos.Text += 10
        ElseIf Alien7.Left <= 20 And Alien7.Visible = True Then
            RightAdd.Text = 20
            Ypos.Text += 10
        ElseIf Alien8.Left <= 20 And Alien8.Visible = True Then
            RightAdd.Text = 20
            Ypos.Text += 10
        ElseIf Alien9.Left <= 20 And Alien9.Visible = True Then
            RightAdd.Text = 20
            Ypos.Text += 10
        ElseIf Alien10.Left <= 20 And Alien10.Visible = True Then
            RightAdd.Text = 20
            Ypos.Text += 10
        End If

        If Alien1.Left >= 850 And Alien1.Visible = True Then
            RightAdd.Text = -20
            Ypos.Text += 10
        ElseIf Alien2.Left >= 850 And Alien2.Visible = True Then
            RightAdd.Text = -20
            Ypos.Text += 10
        ElseIf Alien3.Left >= 850 And Alien3.Visible = True Then
            RightAdd.Text = -20
            Ypos.Text += 10
        ElseIf Alien4.Left >= 850 And Alien4.Visible = True Then
            RightAdd.Text = -20
            Ypos.Text += 10
        ElseIf Alien5.Left >= 850 And Alien5.Visible = True Then
            RightAdd.Text = -20
            Ypos.Text += 10
        ElseIf Alien6.Left >= 850 And Alien6.Visible = True Then
            RightAdd.Text = -20
            Ypos.Text += 10
        ElseIf Alien7.Left >= 850 And Alien7.Visible = True Then
            RightAdd.Text = -20
            Ypos.Text += 10
        ElseIf Alien8.Left >= 850 And Alien8.Visible = True Then
            RightAdd.Text = -20
            Ypos.Text += 10
        ElseIf Alien9.Left >= 850 And Alien9.Visible = True Then
            RightAdd.Text = -20
            Ypos.Text += 10
        ElseIf Alien10.Left >= 850 And Alien10.Visible = True Then
            RightAdd.Text = -20
            Ypos.Text += 10
        End If
        If Alien1.Top + 90 >= Gun.Top And Alien1.Visible = True Then
            Timer1.Enabled = False
            FireTimer.Enabled = False
            MoveTimer.Enabled = False
            MsgBox("Game Over")
        ElseIf Alien2.Top + 90 >= Gun.Top And Alien2.Visible = True Then
            Timer1.Enabled = False
            FireTimer.Enabled = False
            MoveTimer.Enabled = False
            MsgBox("Game Over")
        ElseIf Alien3.Top + 90 >= Gun.Top And Alien3.Visible = True Then
            Timer1.Enabled = False
            FireTimer.Enabled = False
            MoveTimer.Enabled = False
            MsgBox("Game Over")
        ElseIf Alien4.Top + 90 >= Gun.Top And Alien4.Visible = True Then
            Timer1.Enabled = False
            FireTimer.Enabled = False
            MoveTimer.Enabled = False
            MsgBox("Game Over")
        ElseIf Alien5.Top + 90 >= Gun.Top And Alien5.Visible = True Then
            Timer1.Enabled = False
            FireTimer.Enabled = False
            MoveTimer.Enabled = False
            MsgBox("Game Over")
        ElseIf Alien6.Top + 90 >= Gun.Top And Alien6.Visible = True Then
            Timer1.Enabled = False
            FireTimer.Enabled = False
            MoveTimer.Enabled = False
            MsgBox("Game Over")
        ElseIf Alien7.Top + 90 >= Gun.Top And Alien7.Visible = True Then
            Timer1.Enabled = False
            FireTimer.Enabled = False
            MoveTimer.Enabled = False
            MsgBox("Game Over")
        ElseIf Alien8.Top + 90 >= Gun.Top And Alien8.Visible = True Then
            Timer1.Enabled = False
            FireTimer.Enabled = False
            MoveTimer.Enabled = False
            MsgBox("Game Over")
        ElseIf Alien9.Top + 90 >= Gun.Top And Alien9.Visible = True Then
            Timer1.Enabled = False
            FireTimer.Enabled = False
            MoveTimer.Enabled = False
            MsgBox("Game Over")
        ElseIf Alien10.Top + 90 >= Gun.Top And Alien10.Visible = True Then
            Timer1.Enabled = False
            FireTimer.Enabled = False
            MoveTimer.Enabled = False
            MsgBox("Game Over")
        End If
       

        If Alien1.Top >= 200 And Alien1.Top <= 300 Then
            SpecAlienMoveTimer.Enabled = True
        Else
            SpecAlienMoveTimer.Enabled = False
        End If
    End Sub

    

#End Region

#Region "Subs"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
    End Sub

    Private Sub LevelRestart()
        Xpos.Text = 0
        Ypos.Text = 100
        RightAdd.Text = 20
        SpecialAlien.Location = SpecAlienRst.Location
        SpecialAlien.Visible = True
        Timer1.Interval -= 10

        Timer1.Enabled = True
        Alien1.Visible = True
        Alien2.Visible = True
        Alien3.Visible = True
        Alien4.Visible = True
        Alien5.Visible = True
        Alien6.Visible = True
        Alien7.Visible = True
        Alien8.Visible = True
        Alien9.Visible = True
        Alien10.Visible = True
        Exit Sub

    End Sub
#End Region




End Class
