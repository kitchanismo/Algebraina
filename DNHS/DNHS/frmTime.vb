Imports MetroFramework.Animation

Public Class frmTime
    Dim hr As String
    Dim mn As String
    Dim c As Integer
    Dim ctr As Integer = 0
    Dim rnhr As String
    Dim rnmn As String
    Dim questiontime As String
    Dim lbans As New ListBox
    Dim lbctr As New ListBox
    Dim b1 As Point
    Dim b2 As Point
    Dim b3 As Point
    Dim b4 As Point
    Dim bw As Boolean = False
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadQuestion()

        AssignLocation()
        loadAnswers()
        lblbest.Text = GetBestScore("tbltimescore")
        HRMIN("00:00", "00", pnquestion)
        HRMIN(GetProbTime(questiontime), "00", pnquestion)
        'pnquestion.Running = True
        BGMStage(btnspeaker, btnmute)
    End Sub

#Region "Move"

    Private Sub btn1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl1.MouseDown, btn1.MouseDown
        loc = chan.GetLocation(btn1)
    End Sub

    Private Sub btn1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl1.MouseMove, btn1.MouseMove
        DragMove(btn1, loc, e, lbl1.Text)
    End Sub

    Private Sub btn2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl2.MouseDown, btn2.MouseDown
        loc = chan.GetLocation(btn2)
    End Sub

    Private Sub btn2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl2.MouseMove, btn2.MouseMove
        DragMove(btn2, loc, e, lbl2.Text)
    End Sub
    Private Sub btn3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl3.MouseDown, btn3.MouseDown
        loc = chan.GetLocation(btn3)
    End Sub

    Private Sub btn3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl3.MouseMove, btn3.MouseMove
        DragMove(btn3, loc, e, lbl3.Text)
    End Sub
    Private Sub btn4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl4.MouseDown, btn4.MouseDown
        loc = chan.GetLocation(btn4)
    End Sub

    Private Sub btn4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl4.MouseMove, btn4.MouseMove
        DragMove(btn4, loc, e, lbl4.Text)
    End Sub

#End Region

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

#Region "Zoom"

    Private Sub btn1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn1.MouseEnter
        chan.ZoomIn(btn1, 5)
    End Sub
    Private Sub btn2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn2.MouseEnter
        chan.ZoomIn(btn2, 5)
    End Sub
    Private Sub btn3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn3.MouseEnter
        chan.ZoomIn(btn3, 5)
    End Sub
    Private Sub btn4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn4.MouseEnter
        chan.ZoomIn(btn4, 5)
    End Sub
    Private Sub btn1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn1.MouseLeave
        chan.ZoomOut(btn1)
    End Sub
    Private Sub btn2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn2.MouseLeave
        chan.ZoomOut(btn2)
    End Sub
    Private Sub btn3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn3.MouseLeave
        chan.ZoomOut(btn3)
    End Sub
    Private Sub btn4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn4.MouseLeave
        chan.ZoomOut(btn4)
    End Sub
#End Region
    Sub changebtncolor(ByVal mover As Control)
        If chan.IsEnterInsideBox(pnquestion, mover) = True Then
            mover.BackColor = Color.FromArgb(50, 50, 50)
        Else
            mover.BackColor = Color.FromArgb(0, 192, 192)
        End If


    End Sub

    Sub DragMove(ByVal mover As Control, ByVal target As Point, ByVal e As System.Windows.Forms.MouseEventArgs, ByVal lbl As String)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Try
                mover.Location = chan.SetLocation(target, MousePosition)
                mover.BringToFront()
                changebtncolor(mover)
                mover.Cursor = Cursors.Hand
                HRMIN("00:00", "00", pnquestion)
                HRMIN(lbl, "00", pnquestion)
            Catch
            End Try
        Else
            Try
                mover.Cursor = Cursors.Default
                HRMIN(GetProbTime(questiontime), "00", pnquestion)
            Catch
            End Try
        End If
    End Sub
 
    Sub AssignLocation()
        b1 = btn1.Location
        b2 = btn2.Location
        b3 = btn3.Location
        b4 = btn4.Location
    End Sub

    Sub LoadQuestion()
        ' str2 = Label1.Text

        'strText1 = str2

        questiontime = GetTimeProblem()
        'tbquestion.Text = questiontime
        chan.LabelTransition(tbquestion, questiontime, Color.FromArgb(0, 192, 192))
        hr = GetTimeAnsHr(questiontime)
        mn = GetTimeAnsMn(questiontime)
    End Sub


    Sub loadAnswers()
        lbans.Items.Clear()
        lbctr.Items.Clear()
        lbans.Items.Add(hr & ":" & mn)
        lbans.Items.Add(ConcatenatedTime(chan.RanMinMax(1, 9), 1, 9) & ":" & chan.RanMinMax(10, 59))
        lbans.Items.Add(hr & ":" & chan.RanMinMax(10, 39))
        lbans.Items.Add(chan.RanMinMax(10, 12) & ":" & chan.RanMinMax(40, 59))
        chan.DisplayRandomInListbox(lbans.Items.Count, lbctr)
        lbl1.Text = lbans.Items.Item(lbctr.Items.Item(0) - 1)
        lbl2.Text = lbans.Items.Item(lbctr.Items.Item(1) - 1)
        lbl3.Text = lbans.Items.Item(lbctr.Items.Item(2) - 1)
        lbl4.Text = lbans.Items.Item(lbctr.Items.Item(3) - 1)
    End Sub

    Function ConcatenatedTime(ByVal time As String, ByVal min As Integer, ByVal max As Integer) As String
        Dim t As String
        If time.Length >= min And time.Length <= max Then
            t = "0" & time
        End If
        Return t
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadQuestion()
        loadAnswers()
    End Sub
    Sub JumpBack(ByVal e As Control, ByVal p As Point)
        ma.Start(e, p, TransitionType.EaseOutCubic, 20)
    End Sub
    Sub JumpBackMethod(ByVal mover As Control, ByVal destination As Point)
        If chan.IsEnterInsideBox(pnquestion, mover) = False Then
            ma.Start(mover, destination, TransitionType.EaseOutCubic, 20)
            Exit Sub
        End If
        JumpBack(mover, mover.Location)
        If GetAnswerTime(questiontime) = GetGuess() Then
            TimerEnable(False)
            'JumpBack(mover, pnquestion.Location)
            ' MsgBox(")")
            ClickEffects()
            tmosaic.Hide(pnquestion, False)
            MsgBoxAlert("Correct! Get ready for the next problem.", Color.MediumSeaGreen, Me)
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
        If GetAnswerTime(questiontime) = GetGuess() Then
            LoadQuestion()
            loadAnswers()
            HRMIN(GetProbTime(questiontime), "00", pnquestion)
            tmosaic.Show(pnquestion, False)
        End If
        mover.BackColor = Color.FromArgb(0, 192, 192)
       
    End Sub
    Sub TimerEnable(ByVal bool As Boolean)
        If lblbomb3.Text <> 60 And lblbomb2.Text = 60 And lblbomb1.Text = 60 Then
            TimerBomb3.Enabled = bool
        ElseIf lblbomb3.Text = 60 And lblbomb2.Text <> 60 And lblbomb1.Text = 60 Then
            TimerBomb2.Enabled = bool
        ElseIf lblbomb3.Text = 60 And lblbomb2.Text = 60 And lblbomb1.Text <> 60 Then
            TimerBomb1.Enabled = bool
        End If
    End Sub
    Function GetGuess() As String
        Dim str As String = ""
        If chan.IsEnterInsideBox(pnquestion, btn1) = True Then
            str = lbl1.Text
        ElseIf chan.IsEnterInsideBox(pnquestion, btn2) = True Then
            str = lbl2.Text
        ElseIf chan.IsEnterInsideBox(pnquestion, btn3) = True Then
            str = lbl3.Text
        ElseIf chan.IsEnterInsideBox(pnquestion, btn4) = True Then
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
            'timeleft = gettime()
            correct = lblcorrect.Text
            wrong = lblwrong.Text

            MsgBoxGameOver(Me)

        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        isonEquation = False
        TimerEnable(False)
        MsgBoxYesN("Are you sure you want to quit the game?", Color.PaleVioletRed, Me)
        If confirm = "no" Then
            TimerEnable(True)
            Exit Sub
        End If
        trotate.HideSync(btnclose, False)
        frmCategories.Show()
        Me.Close()
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

    Private Sub btnclose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose.MouseEnter, btn1.MouseEnter, btn2.MouseEnter, btn3.MouseEnter, btn4.MouseEnter
        TickEffects()
    End Sub

    Private Sub BunifuImageButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuImageButton1.Click
        TimerEnable(False)
        MsgBoxAlert("*Instruction" & vbNewLine & " Guess the time by dragging the correct answer " & vbNewLine & " in the clock before the bomb runs out!", Color.Teal, Me)
        TimerEnable(True)
    End Sub
End Class