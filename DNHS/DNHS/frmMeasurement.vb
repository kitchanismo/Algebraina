Imports MetroFramework.Animation

Public Class frmMeasurement
    Dim ctr As Integer = 0
    Dim imgname As String
    Dim starthpath As String = Application.StartupPath & "\animals\"
    Dim lbanimals As New ListBox
    Dim lbrandom As New ListBox
    Dim ptsize As Point
    Dim ptlocation As Point
    Dim ptlimit As Point
    Dim sizeans As String
    Dim sizewidth As Integer
    Dim lbans As New ListBox
    Dim lbctr As New ListBox
    Dim L1 As String
    Dim L2 As String
    Dim L3 As String
    Dim L4 As String
    Dim b1 As Point
    Dim b2 As Point
    Dim b3 As Point
    Dim b4 As Point
    Dim measure As String
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

    Private Sub frmMeasurement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        chan.DisplayRandomInListbox(countrows, lbrandom)
        AssignSizeLocation()
        ShowAnimals()
        LoadAnimals(lbanimals)
        LoadData()
        LoadAnswers()
        BGMStage(btnspeaker, btnmute)
        AssignLocation()
        lblbest.Text = GetBestScore("tblmeasurescore")
    End Sub
    Sub AssignSizeLocation()
        ptsize = PicAnimals.Size
        ptlocation = PicAnimals.Location
        ptlimit = PicAnimals.Size
    End Sub
    Sub ShowAnimals()
        imgname = GetImage(GetRandomNumber())
        PicAnimals.ImageLocation = starthpath & imgname
    End Sub
    Sub ReloadData()
        'ShowAnimals()
        LoadData()
        LoadAnswers()
        ' PreventFlick()


        timerresize.Start()
    End Sub
    Sub LoadData()
        measure = GetAnimalData("prob")
        chan.LabelTransition(tbquestion, measure, Color.FromArgb(0, 192, 192))
        ' tbquestion.Text = GetAnimalData("prob")
        lblunit.Text = GetAnimalData("animals_unit")
        sizeans = GetAnimalData("animals_size")
        sizewidth = GetAnimalData("animals_width")
        '   timerresize.Start()
        ' pnwidth.Width = sizewidth + 56
        ReSizePic(sizewidth)

    End Sub
    Sub AssignLocation()
        b1 = btn1.Location
        b2 = btn2.Location
        b3 = btn3.Location
        b4 = btn4.Location
    End Sub
    Sub LoadAnswers()
        Dim value As Double = sizeans
        lbans.Items.Clear()
        lbctr.Items.Clear()
        lbans.Items.Add(value + chan.RanMinMax(1, 6)) '0
        lbans.Items.Add(value + 7) '1
        lbans.Items.Add(value)     '2
        lbans.Items.Add(value - 1) '3
        chan.DisplayRandomInListbox(lbans.Items.Count, lbctr)
        L1 = lbans.Items.Item(lbctr.Items.Item(0) - 1)
        L2 = lbans.Items.Item(lbctr.Items.Item(1) - 1)
        L3 = lbans.Items.Item(lbctr.Items.Item(2) - 1)
        L4 = lbans.Items.Item(lbctr.Items.Item(3) - 1)
        lbl1.Text = L1 & GetAnimalData("animals_unit")
        lbl2.Text = L2 & GetAnimalData("animals_unit")
        lbl3.Text = L3 & GetAnimalData("animals_unit")
        lbl4.Text = L4 & GetAnimalData("animals_unit")
    End Sub


    Function GetImage(ByVal i As Integer) As String
        connected()
        Dim str As String = ""
        sql = "SELECT animals from tblmeasure where id=" & i & ""
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                str = (dr.Item(0).ToString)
            Loop
        End If
        Return str
    End Function

    Function GetRandomNumber() As Integer
        Dim i As Integer = 0
        If ctr = CountAnimals() Then
            lbrandom.Items.Clear()
            chan.DisplayRandomInListbox(countrows, lbrandom)
            ctr = 0
        End If
        i = lbrandom.Items.Item(ctr)
        ctr += 1
        Return i
    End Function

    Sub LoadAnimals(ByVal lv As ListBox)
        lv.Items.Clear()
        connected()
        Dim i As Integer
        sql = "SELECT animals from tblmeasure"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                lv.Items.Add(dr.Item(0).ToString)
            Loop
        End If
    End Sub

    Function countrows() As Integer
        connected()
        Dim i As Integer
        sql = "SELECT count(animals) from tblmeasure"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = (dr.Item(0).ToString)
            Loop
        End If
        Return i
    End Function

    Dim c As Integer = 20

    Sub ReSizeImage(ByVal i As Integer)
        If ptsize.X >= pnruler.Width And i > 0 Then
            Exit Sub
        End If

        ptlocation.X -= i
        ptsize.X += i * 2
        If ptsize.Y >= ptlimit.Y And ptsize.X >= ptlimit.X Then
            Exit Sub
        End If
        ptlocation.Y -= i * 2
        ptsize.Y += i * 2
    End Sub

    Sub ReSizePic(ByVal s As Integer)
        'chan.ReSize(pnwidth, "Width", s + 56)
        PicAnimals.Width = s
        'pnwidth.Width = size + 56
        'chan.ReSize(PicAnimals, "Width", size)
        If PicAnimals.Width >= ptlimit.X Then
            PicAnimals.Location = ptlocation
            PicAnimals.Height = ptsize.Y
            Exit Sub
        End If
        PicAnimals.Top = ptlocation.Y + (200 / 2) - 10
        PicAnimals.Height = 200

    End Sub

    Function GetAnimalData(ByVal fld As String) As String
        connected()
        Dim i As String
        sql = "SELECT " & fld & " from tblmeasure where animals ='" & imgname & "'"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function
    Sub DragMove(ByVal mover As Control, ByVal target As Point, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mover.Location = chan.SetLocation(target, MousePosition)
            mover.BringToFront()
            changebtncolor(mover)
            'ReSizePic(GetAnimalData("animals_width"))
            mover.Cursor = Cursors.Hand
        Else
            mover.Cursor = Cursors.Default
            'ReSizePic(ptsize.X)
        End If
    End Sub

    Sub changebtncolor(ByVal mover As Control)
        If chan.IsEnterBox(PicAnimals, mover) = True Then
            mover.BackColor = Color.FromArgb(50, 50, 50)
        Else
            mover.BackColor = Color.FromArgb(0, 192, 192)
        End If
    End Sub

    Function GetGuess() As String
        Dim str As String = ""
        If chan.IsEnterBox(PicAnimals, btn1) = True Then
            str = L1
        ElseIf chan.IsEnterBox(PicAnimals, btn2) = True Then
            str = L2
        ElseIf chan.IsEnterBox(PicAnimals, btn3) = True Then
            str = L3
        ElseIf chan.IsEnterBox(PicAnimals, btn4) = True Then
            str = L4
        End If
        Return str
    End Function

    Dim bw As Boolean = False

    Sub JumpBackMethod(ByVal mover As Control, ByVal destination As Point)
        If chan.IsEnterBox(PicAnimals, mover) = False Then
            ma.Start(mover, destination, TransitionType.EaseOutCubic, 20)
            Exit Sub
        End If
        JumpBack(mover, mover.Location)
        If GetSizeAnswer(measure) = GetGuess() Then
            TimerEnable(False)
            'JumpBack(mover, pnquestion.Location)
            ' MsgBox(")")
            ClickEffects()
            ShowAnimals()
            tparticles.Hide(PicAnimals, False)
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
        If GetSizeAnswer(measure) = GetGuess() Then
            ReloadData()
            tparticles.Show(PicAnimals, False)
        End If
        mover.BackColor = Color.FromArgb(0, 192, 192)
    End Sub

    Sub JumpBack(ByVal e As Control, ByVal p As Point)
        ma.Start(e, p, TransitionType.EaseOutCubic, 20)

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
            ' timeleft = gettime()
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
        isonMeasure = False
    End Sub

    Private Sub BunifuImageButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuImageButton1.Click
        TimerEnable(False)
        MsgBoxAlert("*Instruction" & vbNewLine & " Convert the following size by dragging" & vbNewLine & " the correct answer in the animal before the bomb runs out!", Color.Teal, Me)
        TimerEnable(True)
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

    Private Sub timerresize_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerresize.Tick
        If pnwidth.Width < sizewidth + 56 Then ' 56 is for unit lenght 
            pnwidth.Width += 2
            If pnwidth.Width >= sizewidth + 56 Then ' 56 is for unit lenght
                timerresize.Stop()

                'LoadAnswers()
            End If
        Else
            pnwidth.Width += -2
            If pnwidth.Width <= sizewidth + 56 Then ' 56 is for unit lenght 
                timerresize.Stop()

                'LoadAnswers()
            End If
        End If
    End Sub
End Class