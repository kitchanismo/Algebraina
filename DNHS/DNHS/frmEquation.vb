Imports MetroFramework.Animation

Public Class frmEquation
    Dim b1 As Point
    Dim b2 As Point
    Dim b3 As Point
    Dim b4 As Point
    Dim lbans As New ListBox
    Dim lbctr As New ListBox
    Dim i As Integer = 0

#Region "Jumpback"

    Private Sub btn1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn1.MouseUp, lbl1.MouseUp
        JumpBackMethod(btn1, b1)
    End Sub
    Private Sub btn2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn2.MouseUp, lbl2.MouseUp
        JumpBackMethod(btn2, b2)
    End Sub
    Private Sub btn3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn3.MouseUp, lbl3.MouseUp
        JumpBackMethod(btn3, b3)
    End Sub
    Private Sub btn4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn4.MouseUp, lbl4.MouseUp
        JumpBackMethod(btn4, b4)
    End Sub
#End Region

#Region "Move"

    Private Sub btn1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn1.MouseDown, lbl1.MouseDown
        loc = chan.GetLocation(btn1)
    End Sub

    Private Sub btn1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn1.MouseMove, lbl1.MouseMove
        DragMove(btn1, loc, e)
    End Sub

    Private Sub btn2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn2.MouseDown, lbl2.MouseDown
        loc = chan.GetLocation(btn2)
    End Sub

    Private Sub btn2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn2.MouseMove, lbl2.MouseMove
        DragMove(btn2, loc, e)
    End Sub
    Private Sub btn3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn3.MouseDown, lbl3.MouseDown
        loc = chan.GetLocation(btn3)
    End Sub

    Private Sub btn3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn3.MouseMove, lbl3.MouseMove
        DragMove(btn3, loc, e)
    End Sub
    Private Sub btn4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn4.MouseDown, lbl4.MouseDown
        loc = chan.GetLocation(btn4)
    End Sub

    Private Sub btn4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn4.MouseMove, lbl4.MouseMove
        DragMove(btn4, loc, e)
    End Sub

#End Region

#Region "zoom"

    Private Sub lbl1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl1.MouseEnter, btn1.MouseEnter
        chan.ZoomIn(btn1, 5)
    End Sub

    Private Sub btn1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn1.MouseLeave, lbl1.MouseLeave
        chan.ZoomOut(btn1)
    End Sub
    Private Sub lbl2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl2.MouseEnter, btn2.MouseEnter
        chan.ZoomIn(btn2, 5)
    End Sub

    Private Sub btn2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn2.MouseLeave, lbl2.MouseLeave
        chan.ZoomOut(btn2)
    End Sub

    Private Sub lbl3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl3.MouseEnter, btn3.MouseEnter
        chan.ZoomIn(btn3, 5)
    End Sub

    Private Sub btn3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn3.MouseLeave, lbl3.MouseLeave
        chan.ZoomOut(btn3)
    End Sub
    Private Sub lbl4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl4.MouseEnter, btn4.MouseEnter
        chan.ZoomIn(btn4, 5)
    End Sub

    Private Sub btn4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn4.MouseLeave, lbl4.MouseLeave
        chan.ZoomOut(btn4)
    End Sub

#End Region

    Protected Overloads Overrides ReadOnly Property Createparams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle
            Return cp
        End Get
    End Property

    Private Sub PreventFlick()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub

    Private Sub frmEquation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chan.DisplayRandomInListbox(CountEquation("tblequation"), lb)
        GetData()
        AssignLocation()
        PreventFlick()
        BGMStage(btnspeaker, btnmute)
    End Sub

    Dim equation As String
    Sub GetData()
        equation = GetEquation()
        chan.LabelTransition(tbquestion, equation, Color.FromArgb(0, 192, 192))
        loadAnswers()
        lblbest.Text = GetBestScore("tblequationscore")
    End Sub
    Dim i As Integer
    Sub AssignLocation()
        b1 = btn1.Location
        b2 = btn2.Location
        b3 = btn3.Location
        b4 = btn4.Location
    End Sub

    Sub DragMove(ByVal mover As Control, ByVal target As Point, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mover.Location = chan.SetLocation(target, MousePosition)
            mover.BringToFront()
            changebtncolor(mover)
            mover.Cursor = Cursors.Hand
        Else
            mover.Cursor = Cursors.Default
        End If
    End Sub

    Sub changebtncolor(ByVal mover As Control)
        If chan.IsEnterBox(pnquestion, mover) = True Then
            mover.BackColor = Color.FromArgb(50, 50, 50)
        Else
            mover.BackColor = Color.FromArgb(0, 192, 192)
        End If
    End Sub

    Dim bw As Boolean = False
    Sub JumpBackMethod(ByVal mover As Control, ByVal destination As Point)

        If chan.IsEnterBox(pnquestion, mover) = False Then
            ma.Start(mover, destination, TransitionType.EaseOutCubic, 20)
            Exit Sub
        End If

        JumpBack(mover, mover.Location)

        If GetAnswer(equation) = GetGuess() Then
            TimerEnable(False)
            'JumpBack(mover, pnquestion.Location)
            ClickEffects()
            MsgBoxAlert("Correct! Get ready for the next equation.", Color.MediumSeaGreen, Me)
            TimerEnable(True)
            lblcorrect.Text += 1
        Else
            TimerEnable(False)
            BuzzEffects()
            If bw = False Then
                MsgBoxAlert("Wrong!" & vbNewLine & "*Time will be deducted by 10 seconds for every" & vbNewLine & "  wrong answer.", Color.PaleVioletRed, Me)
                bw = True
            Else
                MsgBoxAlert("Wrong!", Color.PaleVioletRed, Me)
            End If
            TimerEnable(True)
            ctrbomb -= 9
            lblwrong.Text += 1
        End If

        JumpBack(mover, destination)

        If GetAnswer(equation) = GetGuess() Then
            GetData()
        End If

        mover.BackColor = Color.FromArgb(0, 192, 192)
    End Sub

    Function gettime() As Integer
        Dim i As Integer
        i = Val(lblbomb3.Text) + Val(lblbomb2.Text) + Val(lblbomb1.Text)
        Return i
    End Function

    Sub TimerEnable(ByVal bool As Boolean)
        If lblbomb3.Text <> 60 And lblbomb2.Text = 60 And lblbomb1.Text = 60 Then
            TimerBomb3.Enabled = bool
        ElseIf lblbomb3.Text = 60 And lblbomb2.Text <> 60 And lblbomb1.Text = 60 Then
            TimerBomb2.Enabled = bool
        ElseIf lblbomb3.Text = 60 And lblbomb2.Text = 60 And lblbomb1.Text <> 60 Then
            TimerBomb1.Enabled = bool
        End If
    End Sub

    Sub JumpBack(ByVal e As Control, ByVal p As Point)
        ma.Start(e, p, TransitionType.EaseOutCubic, 20)

    End Sub

    Sub loadAnswers()
        Dim value As Double = GetAnswer(equation)
        lbans.Items.Clear()
        lbctr.Items.Clear()
        lbans.Items.Add(value + chan.RanMinMax(1, 4)) '0
        lbans.Items.Add(value + 5) '1
        lbans.Items.Add(value)     '2
        lbans.Items.Add(value - 3) '3
        chan.DisplayRandomInListbox(lbans.Items.Count, lbctr)
        lbl1.Text = lbans.Items.Item(lbctr.Items.Item(0) - 1)
        lbl2.Text = lbans.Items.Item(lbctr.Items.Item(1) - 1)
        lbl3.Text = lbans.Items.Item(lbctr.Items.Item(2) - 1)
        lbl4.Text = lbans.Items.Item(lbctr.Items.Item(3) - 1)
    End Sub

    Function GetGuess() As String
        Dim str As String = ""
        If chan.IsEnterBox(pnquestion, btn1) = True Then
            str = lbl1.Text
        ElseIf chan.IsEnterBox(pnquestion, btn2) = True Then
            str = lbl2.Text
        ElseIf chan.IsEnterBox(pnquestion, btn3) = True Then
            str = lbl3.Text
        ElseIf chan.IsEnterBox(pnquestion, btn4) = True Then
            str = lbl4.Text
        End If
        Return str
    End Function

    Dim ctrbomb As Integer = 60
    Private Sub TimerBomb3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBomb3.Tick
        ctrbomb -= 1
        lblbomb3.Text = ctrbomb

        If ctrbomb < 10 Then
            lblbomb3.Left = 10
        End If

        If lblbomb3.Text <= 0 Then
            ExplosionEffects()
            TimerBomb3.Stop()
            ctrbomb = 60
            lblbomb3.Text = 60
            tmosaic.HideSync(pnbomb3, False)
        
            TimerBomb2.Start()

        End If
    End Sub

    Private Sub TimerBomb2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBomb2.Tick
        ctrbomb -= 1

        If ctrbomb < 10 Then
            lblbomb2.Left = 10
        End If

        lblbomb2.Text = ctrbomb


        If lblbomb2.Text <= 0 Then
            ExplosionEffects()
            TimerBomb2.Stop()
            ctrbomb = 60
            lblbomb2.Text = 60
            tmosaic.HideSync(pnbomb2, False)

            TimerBomb1.Start()
        End If
    End Sub

    Private Sub TimerBomb1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerBomb1.Tick
        ctrbomb -= 1

        If ctrbomb < 10 Then
            lblbomb1.Left = 10
        End If

        lblbomb1.Text = ctrbomb

        If lblbomb1.Text <= 0 Then
            ExplosionEffects()
            TimerBomb1.Stop()
            ctrbomb = 60
            lblbomb1.Text = 60
            tmosaic.HideSync(pnbomb1, False)
            'TimerBomb1.Start()
            timeleft = gettime()
            correct = lblcorrect.Text
            wrong = lblwrong.Text

            MsgBoxGameOver(Me)

        End If
    End Sub



    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click

        TimerEnable(False)
        MsgBoxYesN("Are you sure you want to quit the game?", Color.PaleVioletRed, Me)
        If confirm = "no" Then
            TimerEnable(True)
            Exit Sub
        End If
        trotate.HideSync(btnclose, False)
        frmCategories.Show()
        Me.Close()
        isonEquation = False
    End Sub

   
    Private Sub btnclose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose.MouseEnter, btn1.MouseEnter, btn2.MouseEnter, btn3.MouseEnter, btn4.MouseEnter
        TickEffects()
    End Sub

 

    Private Sub btnmute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmute.Click
        btnspeaker.BringToFront()
        btnmute.SendToBack()
        togSE = True
        togMusic = True
        BGMStage(btnspeaker, btnmute)
    End Sub

    Private Sub btnspeaker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnspeaker.Click
        btnspeaker.SendToBack()
        btnmute.BringToFront()
        togSE = False
        togMusic = False
        BGMStage(btnspeaker, btnmute)
    End Sub

   
    Private Sub BunifuImageButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuImageButton1.Click
        TimerEnable(False)
        MsgBoxAlert("*Instruction" & vbNewLine & " Solve the following equation by dragging" & vbNewLine & " the correct answer in the equal sign before" & vbNewLine & " the bomb runs out!", Color.Teal, Me)
        TimerEnable(True)
    End Sub
End Class