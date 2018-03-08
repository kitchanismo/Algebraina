Public Class frmCategories
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
    Private Sub frmCategories_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblplayer.Text = playername
        CallRatings()
        LoadCat()
        PreventFlick()
        BGMMenu(btnspeaker, btnmute)
    End Sub
    Sub CallRatings()
        rmeasure.Value = GetRating("cat_measure")
        requation.Value = GetRating("cat_equation")
        rdegree.Value = GetRating("cat_temperature")
        rsquare.Value = GetRating("cat_square")
        requivalent.Value = GetRating("cat_equivalent")
        rfraction.Value = GetRating("cat_time")
    End Sub

    Sub LoadCat()
        tscale.Show(pnmeasure, False)
        tscale.Show(pnequation, False)
        tscale.Show(pndegree, False)
        tscale.Show(pnsquare, False)
        'tscale.Show(pnequivalent, False)
        tscale.Show(pnfraction, False)
    End Sub



    Private Sub btnmeasure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmeasure.Click
        SliderEffects()
        isonMeasure = True
        tscale.HideSync(pnmeasure, False)
        playername = lblplayer.Text
        frmMeasurement.Show()
        MsgBoxAlert("*Instruction" & vbNewLine & " Convert the following size by dragging" & vbNewLine & " the correct answer in the animal before the bomb runs out!", Color.Teal, Me)
        frmMeasurement.BunifuTransition1.ShowSync(frmMeasurement.pntitle, False)
        frmMeasurement.tVertSlide.ShowSync(frmMeasurement.pnbomb3, False)
        frmMeasurement.tVertSlide.ShowSync(frmMeasurement.pnbomb2, False)
        frmMeasurement.tVertSlide.ShowSync(frmMeasurement.pnbomb1, False)
        ' frmMeasurement.tparticles.ShowSync(frmMeasurement.PicAnimals, False)
        frmMeasurement.TimerBomb3.Start()
        frmMeasurement.timerresize.Start()
        'BGMStage(btnspeaker, btnmute)
        Me.Close()
    End Sub

    Private Sub BunifuImageButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhigh.Click
        SliderEffects()
        'frmChoosePlayer.Close()
        lblplayer.Text = playername
        frmHighScore.Show()
        Me.Close()

    End Sub

    Private Sub btnequation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnequation.Click
        SliderEffects()
        isonEquation = True
        tscale.HideSync(pnequation, False)
        playername = lblplayer.Text

        frmEquation.Show()

        MsgBoxAlert("*Instruction" & vbNewLine & " Solve the following equation by dragging" & vbNewLine & " the correct answer in the equal sign before" & vbNewLine & " the bomb runs out!", Color.Teal, Me)
        frmEquation.BunifuTransition1.ShowSync(frmEquation.pntitle, False)
        frmEquation.tVertSlide.ShowSync(frmEquation.pnbomb3, False)
        frmEquation.tVertSlide.ShowSync(frmEquation.pnbomb2, False)
        frmEquation.tVertSlide.ShowSync(frmEquation.pnbomb1, False)
        frmEquation.TimerBomb3.Start()
        Me.Close()

    End Sub

    Private Sub BunifuCustomLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvlchange.Click
        SliderEffects()
        playername = ""
        frmChoosePlayer.Show()
        frmChoosePlayer.thoriz.Show(frmChoosePlayer.pnchoose, False)
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

    Private Sub btntime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsquare.Click
        SliderEffects()
        isonSquare = True
        tscale.HideSync(pnsquare, False)
        playername = lblplayer.Text

        frmSquared.Show()

        ' BGMStop()
        MsgBoxAlert("*Instruction" & vbNewLine & " Find the squared number by dragging outside the box " & vbNewLine & " the correct answer before the bomb runs out!", Color.Teal, Me)
        frmSquared.BunifuTransition1.ShowSync(frmSquared.pntitle, False)
        frmSquared.tmosaic.ShowSync(frmSquared.pncontainer, False)
        frmSquared.tVertSlide.ShowSync(frmSquared.pnbomb3, False)
        frmSquared.tVertSlide.ShowSync(frmSquared.pnbomb2, False)
        frmSquared.tVertSlide.ShowSync(frmSquared.pnbomb1, False)
        frmSquared.TimerBomb3.Start()
        Me.Close()
    End Sub

    Private Sub btndegree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndegree.Click
        SliderEffects()
        isonTemperature = True
        tscale.HideSync(pndegree, False)
        playername = lblplayer.Text

        frmTemperature.Show()

        ' BGMStop()
        MsgBoxAlert("*Instruction" & vbNewLine & " Convert the following Temperature by dragging" & vbNewLine & " the correct answer in the cup before the bomb runs out!", Color.Teal, Me)
        frmTemperature.BunifuTransition1.ShowSync(frmTemperature.pntitle, False)
        frmTemperature.tVertSlide.ShowSync(frmTemperature.pnbomb3, False)
        frmTemperature.tVertSlide.ShowSync(frmTemperature.pnbomb2, False)
        frmTemperature.tVertSlide.ShowSync(frmTemperature.pnbomb1, False)
        frmTemperature.TimerBomb3.Start()
        frmTemperature.timerresize.Start()
        Me.Close()
    End Sub

    Private Sub btnequivalent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnequivalent.Click
        StopEffects()
        MsgBoxAlert("This section is under construction!", Color.PaleVioletRed, Me)
    End Sub

    Private Sub btnfraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntime.Click
        SliderEffects()
        isonTime = True
        tscale.HideSync(pnfraction, False)
        playername = lblplayer.Text
        frmTime.Show()

        ' BGMStop()
        MsgBoxAlert("*Instruction" & vbNewLine & " Guess the time by dragging the correct answer " & vbNewLine & " in the clock before the bomb runs out!", Color.Teal, Me)
        frmTime.BunifuTransition1.ShowSync(frmTime.pntitle, False)
        frmTime.tVertSlide.ShowSync(frmTime.pnbomb3, False)
        frmTime.tVertSlide.ShowSync(frmTime.pnbomb2, False)
        frmTime.tVertSlide.ShowSync(frmTime.pnbomb1, False)
        frmTime.TimerBomb3.Start()
        Me.Close()
    End Sub


    Private Sub btnequation_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnequation.MouseEnter, btnmeasure.MouseEnter, btndegree.MouseEnter, btnsquare.MouseEnter, btnequivalent.MouseEnter, btntime.MouseEnter, btnspeaker.MouseEnter, btnmute.MouseEnter, btnhigh.MouseEnter
        TickEffects()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click

        MsgBoxYesN("Are you sure you want to exit the game?", Color.PaleVioletRed, Me)
        If confirm = "no" Then
            Exit Sub
        End If
        trotate.HideSync(btnclose, False)
        playername = ""
        End
    End Sub
End Class
