Imports System.Text
Imports System.IO
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Runtime.CompilerServices

Public Class frmChoosePlayer
    Dim left As Integer
    Dim kit As New kitchanismoto.betsayda
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        pos = chan.GetLocation(Me)
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location = chan.SetLocation(pos, MousePosition)
        End If
    End Sub
    Private Sub frmChoosePlayer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulatePlayer(lvplayer)
        left = pnchoose.Left
        PreventFlick()
    End Sub

    Public Sub PopulatePlayer(ByVal lv As ListView)
        connected()
        With lv
            .Items.Clear()
            sql = " SELECT * FROM tblplayer order by id desc"
            CommandDb()
            dr = cmd.ExecuteReader()
            lv.Items.Clear()
            While (dr.Read())
                With lv.Items.Add(dr("id"))
                    .SubItems.Add(dr("player_name"))
                End With
            End While
        End With
    End Sub

    Public Function DoesExist(ByVal tbl As String, ByVal field As String, ByVal str As String)
        connected()
        sql = "Select COUNT(*) FROM " & tbl & " WHERE " & field & " = '" & str & "'"
        CommandDb()
        Dim rows As Integer = cmd.ExecuteScalar()
        If rows > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbplayer.MouseClick
        tbplayer.Text = ""
        tbplayer.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        tbplayer.ForeColor = Color.FromArgb(0, 192, 192)
        playername = ""
    End Sub




    Private Sub TextBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbplayer.MouseEnter
        If tbplayer.Text <> "Enter New Player" Then
            Exit Sub
        End If

        tbplayer.Text = ""
        tbplayer.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub TextBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbplayer.MouseLeave
        If tbplayer.Text <> "" Then
            Exit Sub
        End If
        tbplayer.Text = "Enter New Player"

        tbplayer.ForeColor = Color.Silver
        tbplayer.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub



    Sub SavePlayerData()
        connected()
        sql = "INSERT INTO tblplayer (player_name, cat_measure, cat_equation, cat_temperature, cat_square, cat_equivalent, cat_time) VALUES ('" & tbplayer.Text.ToLower & "', 0,0,0,0,0,0)"
        CommandDb()
        dr = cmd.ExecuteReader()
    End Sub


    Sub SaveScore(ByVal tbl As String)
        connected()
        sql = "INSERT INTO " & tbl & " (player_name, player_score) VALUES ('" & tbplayer.Text.ToLower & "', 0)"
        CommandDb()
        dr = cmd.ExecuteReader()
    End Sub



    Private Sub lvplayer_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvplayer.MouseClick
        With lvplayer.SelectedItems(0)
            tbplayer.Text = .SubItems(1).Text
        End With
    End Sub

    Dim ctr As Integer = 0
    Private Sub tmrload_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrload.Tick
        ctr += 1
        pload.Value = ctr
        If ctr = 50 Then
            connected()
        End If
        If pload.Value = 100 Then
            Dim loc As Point
            loc.X += (470 + 270)
            loc.Y = 0
            ctr = 0
            tmrload.Stop()

            tmosaic.HideSync(pload, False)
            'kit.xylocation_elastic(pnchoose, loc, 2000)
            SliderEffects()
            thoriz.Show(pnchoose, False)
            trotate.Show(btnplay, False)
            trotate.Show(btnclose, False)
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If tbplayer.Text = "" Or tbplayer.Text = "Enter New Player" Then
            Exit Sub
        End If

        If tbplayer.Text.Length >= 5 And tbplayer.Text.Length <= 10 Then
        Else
            StopEffects()
            MsgBoxAlert("Player name must be 5-10 characters only!", Color.LightCoral, Me)
            Exit Sub
        End If

        If DoesExist("tblplayer", "player_name", tbplayer.Text.ToUpper) = True Then
            StopEffects()
            MsgBoxAlert(tbplayer.Text & " is taken!", Color.LightCoral, Me)
            Exit Sub
        End If
        SavePlayerData()
        SaveScore("tblequationscore")
        SaveScore("tblsquarescore")
        SaveScore("tbltimescore")
        SaveScore("tblmeasurescore")
        playername = tbplayer.Text
        PopulatePlayer(lvplayer)
        thoriz.Show(pnchoose, False)

        'frmCategories.Show()
        ' Me.Hide()

        MsgBoxAlert(tbplayer.Text & " has been added!", Color.MediumSeaGreen, Me)
        tbplayer.Text = ""
    End Sub

    Private Sub BunifuImageButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplay.Click
      
   
      
        'thoriz.Show(pnchoose, False)

        'frmCategories.Show()
        ' Me.Hide()

        ' MsgBoxAlert(tbplayer.Text & " has been added!", Color.MediumSeaGreen, Me)

        'playername = tbplayer.Text
        playername = tbplayer.Text
        If playername = "" Or playername = "Enter New Player" Then
            StopEffects()
            MsgBoxAlert("Enter or Choose a player name!", Color.LightCoral, Me)
            Exit Sub
        End If

        If playername.Length >= 5 And playername.Length <= 10 And playername <> "Enter New Player" Then
        Else
            StopEffects()
            MsgBoxAlert("Player name must be 5-10 characters only!", Color.LightCoral, Me)
            Exit Sub
        End If

        If playername <> "Enter New Player" Then
            If DoesExist("tblplayer", "player_name", playername.ToUpper) = True Then
                GoTo a
            End If
            SavePlayerData()
            SaveScore("tblequationscore")
            SaveScore("tblsquarescore")
            SaveScore("tbltimescore")
            SaveScore("tblmeasurescore")
            SaveScore("tbltemperaturescore")
        End If
a:
        SliderEffects()
        PopulatePlayer(lvplayer)
        trotate.HideSync(btnplay, False)
        thoriz.HideSync(pnchoose, False)
        frmCategories.Show()
        frmBlank.Show()
        Me.Hide()
        MsgWelcome("Welcome " & playername.ToUpper & "!", Color.Teal, Me)
        ' playername = ""
        tbplayer.Text = ""
        btnplay.Visible = True
    End Sub


    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        MsgBoxYesN("Are you sure you want to quit the game?", Color.PaleVioletRed, Me)
        If confirm = "no" Then
            Exit Sub
        End If
        trotate.HideSync(btnclose, False)
        playername = ""
        SliderEffects()
        thoriz.HideSync(pnchoose, False)
        End
    End Sub

    Private Sub pnchoose_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnchoose.Paint

    End Sub

    Private Sub btnplay_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnplay.MouseEnter, btnclose.MouseEnter
        TickEffects()
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
End Class