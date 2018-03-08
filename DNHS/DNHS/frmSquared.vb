Imports MetroFramework.Animation

Public Class frmSquared

    Dim b1 As Point
    Dim b2 As Point
    Dim b3 As Point
    Dim b4 As Point
    Dim b5 As Point
    Dim b6 As Point
    Dim b7 As Point
    Dim b8 As Point
    Dim b9 As Point

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

    Dim rn As Integer
    Private Sub frmSquared_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSquared(ListBox1)
        LoadSquaredNot(ListBox2)
        GenerateRandomList()
        rn = chan.RanMinMax(1, CountRows())
        LoadList()
        AssignData()
        AssignLocation()
        lblbest.Text = GetBestScore("tblsquarescore")
        PreventFlick()
        BGMStage(btnspeaker, btnmute)
    End Sub

    Sub reloaddata()
        GenerateRandomList()
        rn = chan.RanMinMax(1, CountRows())
        LoadList()
        AssignData()
    End Sub
    Dim list_square As New ListBox
    Sub GenerateRandomList()
        list_square.Items.Clear()
        chan.DisplayRandomInListbox(9, list_square)
    End Sub

    Sub AssignLocation()
        b1 = btn1.Location
        b2 = btn2.Location
        b3 = btn3.Location
        b4 = btn4.Location
        b5 = btn5.Location
        b6 = btn6.Location
        b7 = btn7.Location
        b8 = btn8.Location
        b9 = btn9.Location
    End Sub
    Sub AssignData()
        btn1.Text = ListBox4.Items.Item(list_square.Items.Item(0) - 1)
        btn2.Text = ListBox4.Items.Item(list_square.Items.Item(1) - 1)
        btn3.Text = ListBox4.Items.Item(list_square.Items.Item(2) - 1)
        btn4.Text = ListBox4.Items.Item(list_square.Items.Item(3) - 1)
        btn5.Text = ListBox4.Items.Item(list_square.Items.Item(4) - 1)
        btn6.Text = ListBox4.Items.Item(list_square.Items.Item(5) - 1)
        btn7.Text = ListBox4.Items.Item(list_square.Items.Item(6) - 1)
        btn8.Text = ListBox4.Items.Item(list_square.Items.Item(7) - 1)
        btn9.Text = ListBox4.Items.Item(list_square.Items.Item(8) - 1)
    End Sub

    Sub LoadList()
        ListBox4.Items.Clear()
        ListBox4.Items.Add(getrandomdata("squared"))
        rn = chan.RanMinMax(1, CountRows())
        ListBox4.Items.Add(getrandomdata("squared_not"))
        rn = chan.RanMinMax(1, CountRows())
        ListBox4.Items.Add(getrandomdata("squared_not"))
        rn = chan.RanMinMax(1, CountRows())
        ListBox4.Items.Add(getrandomdata("squared_not"))
        rn = chan.RanMinMax(1, CountRows())
        ListBox4.Items.Add(getrandomdata("squared_not"))
        rn = chan.RanMinMax(1, CountRows())
        ListBox4.Items.Add(getrandomdata("squared_not"))
        rn = chan.RanMinMax(1, CountRows())
        ListBox4.Items.Add(getrandomdata("squared_not"))
        rn = chan.RanMinMax(1, CountRows())
        ListBox4.Items.Add(getrandomdata("squared_not"))
        rn = chan.RanMinMax(1, CountRows())
        ListBox4.Items.Add(getrandomdata("squared"))

    End Sub


    Function getrandomdata(ByVal str As String) As String
        connected()
        Dim i As String
        sql = "SELECT " & str & " from tblsquare where id =" & rn & " "
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function




    Function CountRows() As Integer
        connected()
        Dim i As Integer
        sql = "SELECT count(squared) from tblsquare"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function

  


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        reloaddata()
    End Sub

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
            timeleft = gettime()
            correct = lblcorrect.Text
            wrong = lblwrong.Text
            MsgBoxGameOver(Me)

        End If
    End Sub


    Dim bw As Boolean = False
    Sub CheckData(ByVal lbl As Button)
        If ListBox1.Items.Contains(lbl.Text) = True Then
            TimerEnable(False)
            pncontainer.Enabled = False
            ClickEffects()
            MsgBoxAlert("Correct!", Color.MediumSeaGreen, Me)
            TimerEnable(True)
            ' GetData()
            lblcorrect.Text += 1
            reloaddata()
            pncontainer.Enabled = True
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
    End Sub

 



    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        StopEffects()
        TimerEnable(False)
        MsgBoxYesN("Are you sure you want to quit the game?", Color.PaleVioletRed, Me)
        If confirm = "no" Then
            TimerEnable(True)
            Exit Sub
        End If
        trotate.HideSync(btnclose, False)
        isonSquare = False
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

#Region "Jumpback"

    Private Sub btn1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn1.MouseUp
        JumpBackMethod(btn1, b1)
    End Sub
    Private Sub btn2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn2.MouseUp
        JumpBackMethod(btn2, b2)
    End Sub
    Private Sub btn3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn3.MouseUp
        JumpBackMethod(btn3, b3)
    End Sub
    Private Sub btn4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn4.MouseUp
        JumpBackMethod(btn4, b4)
    End Sub
    Private Sub btn5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn5.MouseUp
        JumpBackMethod(btn5, b5)
    End Sub
    Private Sub btn6_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn6.MouseUp
        JumpBackMethod(btn6, b6)
    End Sub
    Private Sub btn7_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn7.MouseUp
        JumpBackMethod(btn7, b7)
    End Sub
    Private Sub btn8_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn8.MouseUp
        JumpBackMethod(btn8, b8)
    End Sub
    Private Sub btn9_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn9.MouseUp
        JumpBackMethod(btn9, b9)
    End Sub
#End Region

#Region "Move"

    Private Sub btn1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn1.MouseDown
        loc = chan.GetLocation(btn1)
    End Sub

    Private Sub btn1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn1.MouseMove
        DragMove(btn1, loc, e)
    End Sub

    Private Sub btn2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn2.MouseDown
        loc = chan.GetLocation(btn2)
    End Sub

    Private Sub btn2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn2.MouseMove
        DragMove(btn2, loc, e)
    End Sub
    Private Sub btn3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn3.MouseDown
        loc = chan.GetLocation(btn3)
    End Sub

    Private Sub btn3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn3.MouseMove
        DragMove(btn3, loc, e)
    End Sub
    Private Sub btn4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn4.MouseDown
        loc = chan.GetLocation(btn4)
    End Sub

    Private Sub btn4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn4.MouseMove
        DragMove(btn4, loc, e)
    End Sub

    Private Sub btn5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn5.MouseDown
        loc = chan.GetLocation(btn5)
    End Sub

    Private Sub btn5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn5.MouseMove
        DragMove(btn5, loc, e)
    End Sub

    Private Sub btn6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn6.MouseDown
        loc = chan.GetLocation(btn6)
    End Sub

    Private Sub btn6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn6.MouseMove
        DragMove(btn6, loc, e)
    End Sub
    Private Sub btn7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn7.MouseDown
        loc = chan.GetLocation(btn7)
    End Sub

    Private Sub btn7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn7.MouseMove
        DragMove(btn7, loc, e)
    End Sub
    Private Sub btn8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn8.MouseDown
        loc = chan.GetLocation(btn8)
    End Sub

    Private Sub btn8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn8.MouseMove
        DragMove(btn8, loc, e)
    End Sub
    Private Sub btn9_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn9.MouseDown
        loc = chan.GetLocation(btn9)
    End Sub

    Private Sub btn9_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn9.MouseMove
        DragMove(btn9, loc, e)
    End Sub

#End Region
    Function GetGuess() As String
        Dim str As String = ""
        If chan.IsEnterBox(pncontainer, btn1) = False Then
            str = btn1.Text
        ElseIf chan.IsEnterBox(pncontainer, btn2) = False Then
            str = btn2.Text
        ElseIf chan.IsEnterBox(pncontainer, btn3) = False Then
            str = btn3.Text
        ElseIf chan.IsEnterBox(pncontainer, btn4) = False Then
            str = btn4.Text
        ElseIf chan.IsEnterBox(pncontainer, btn5) = False Then
            str = btn5.Text
        ElseIf chan.IsEnterBox(pncontainer, btn6) = False Then
            str = btn6.Text
        ElseIf chan.IsEnterBox(pncontainer, btn7) = False Then
            str = btn7.Text
        ElseIf chan.IsEnterBox(pncontainer, btn8) = False Then
            str = btn8.Text
        ElseIf chan.IsEnterBox(pncontainer, btn9) = False Then
            str = btn9.Text
        End If
        Return str
    End Function
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
        If chan.IsEnterBox(pncontainer, mover) = False Then
            mover.BackColor = Color.PaleVioletRed
        Else
            mover.BackColor = Color.FromArgb(0, 188, 188)

        End If
    End Sub

    Sub JumpBackMethod(ByVal mover As Control, ByVal destination As Point)
        If chan.IsEnterBox(pncontainer, mover) = True Then
            ma.Start(mover, destination, TransitionType.EaseOutCubic, 20)
            Exit Sub
        End If
        JumpBack(mover, mover.Location)
        If ListBox1.Items.Contains(GetGuess()) = True Then
            TimerEnable(False)
            pncontainer.Enabled = False
            ClickEffects()
            MsgBoxAlert("Correct!", Color.MediumSeaGreen, Me)
            TimerEnable(True)
            ' GetData()
            lblcorrect.Text += 1

            pncontainer.Enabled = True
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
        If ListBox1.Items.Contains(GetGuess()) = True Then
            reloaddata()
        End If
        mover.BackColor = Color.FromArgb(0, 188, 188)
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

    Private Sub BunifuImageButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuImageButton1.Click
        TimerEnable(False)

        MsgBoxAlert("*Instruction" & vbNewLine & " Find the squares number by dragging outside the box " & vbNewLine & " the correct answer before the bomb runs out!", Color.Teal, Me)

        TimerEnable(True)
    End Sub
End Class