Public Class frmGameOver



    Private Sub btnstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstart.Click
        SliderEffects()
        isonEquation = False
        isonSquare = False
        isonMeasure = False
        isonTime = False
        isonTemperature = False
        BunifuTransition1.HideSync(pntrophy, False)
        wrong = 0
        correct = 0
        frmTransparent.Close()
        Me.Close()
        frmCategories.Show()
        frmEquation.Close()
        frmSquared.Close()
        frmTime.Close()
        frmMeasurement.Close()
        frmTemperature.Close()

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

    Private Sub frmGameOver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PreventFlick()
        BGMStop()
        YeyEffects()
        ClapEffects()
        rscore.Value = 0
        TimerScore.Start()

    End Sub

   
    Dim ctr As Integer = -1
    Private Sub TimerScore_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerScore.Tick
        ctr += 1
        lblScore.Text = ctr
        If ctr >= generatescore() Then
            TimerScore.Stop()
            ctr = -1
            rscore.Value = 0
            tscalerotate.Show(pntrophy, False)
            Timer1.Start()
            lblgreet.Visible = True
            lblgreet.Text = Greeting()
            btnstart.Visible = True
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ctr += 1
        rscore.Value = ctr
        If ctr = getrating() Then
            Timer1.Stop()
            ctr = 0
            btnstart.Visible = True
            SaveData(lblScore.Text)
        End If
    End Sub

 
    Function Greeting() As String
        Dim str As String
        If getrating() = 0 Then
            str = "Study Hard!"
        ElseIf getrating() = 1 Then
            str = "   Good!"
        ElseIf getrating() = 2 Then
            str = "   Nice!"
        ElseIf getrating() = 3 Then
            str = "  Excellent!"
        Else
            str = "  Not implemented!"
        End If
        Return str
    End Function
End Class