Public Class frmHighScore

    Private Sub frmHighScore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadBest()
        LoadAward()
        PreventFlick()
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
    Sub LoadAward()

        tscale.Show(pnmeasure, False)

        tscale.Show(pnequation, False)

        tscale.Show(pntemperature, False)

        tscale.Show(pnsquare, False)

        'tscale.Show(pnequivalent, False)

        tscale.Show(pnfraction, False)
    End Sub

    Sub LoadBest()
        lblSequation.Text = GetBestScore("tblequationscore")
        lblSsquare.Text = GetBestScore("tblsquarescore")
        lblSfraction.Text = GetBestScore("tbltimescore")
        lblSmeasure.Text = GetBestScore("tblmeasurescore")
        lblStemperature.Text = GetBestScore("tbltemperaturescore")

        lblNequation.Text = GetBestMan("tblequationscore", GetBestScore("tblequationscore")).ToUpper
        lblNsquare.Text = GetBestMan("tblsquarescore", GetBestScore("tblsquarescore")).ToUpper
        lblNfraction.Text = GetBestMan("tbltimescore", GetBestScore("tbltimescore")).ToUpper
        lblNmeasure.Text = GetBestMan("tblmeasurescore", GetBestScore("tblmeasurescore")).ToUpper
        lblNTemperature.Text = GetBestMan("tbltemperaturescore", GetBestScore("tbltemperaturescore")).ToUpper
    End Sub
    Function GetBestScore(ByVal tbl As String) As Integer
        connected()
        Dim i As Integer
        sql = "SELECT max(player_score) from " & tbl & ""
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0)
            Loop
        End If
        Return i
    End Function

    Function GetBestMan(ByVal tbl As String, ByVal fld As Integer) As String
        connected()
        Dim i As String
        sql = "SELECT player_name from " & tbl & " where player_score = " & fld & ""
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        trotate.HideSync(btnclose, False)
        frmCategories.Show()
        Me.Close()
    End Sub

    Private Sub btnclose_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose.MouseEnter
        TickEffects()
    End Sub
End Class