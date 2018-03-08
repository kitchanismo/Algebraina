Module modfunction
    Sub MsgWelcome(ByVal str As String, ByVal col As Color, ByVal frm As Form)
        frmWelcome.lblmsg.Text = str
        frmWelcome.BackColor = col
        frmTransparent.Location = frm.Location
        frmTransparent.Size = frm.Size
        ' frmMsgBox.Location = frm.Location
        frmWelcome.Width = frm.Width
        frmTransparent.Show()
        frmWelcome.ShowDialog()
    End Sub
    Sub MsgBoxAlert(ByVal str As String, ByVal col As Color, ByVal frm As Form)
        frmMsgBox.lblmsg.Text = str
        frmMsgBox.BackColor = col
        frmTransparent.Location = frm.Location
        frmTransparent.Size = frm.Size
        ' frmMsgBox.Location = frm.Location
        frmMsgBox.Width = frm.Width
        frmTransparent.Show()
        frmMsgBox.ShowDialog()
    End Sub

    Sub MsgBoxYesN(ByVal str As String, ByVal col As Color, ByVal frm As Form)
        frmYesNo.lblmsg.Text = str
        frmYesNo.BackColor = col
        frmTransparent.Location = frm.Location
        frmTransparent.Size = frm.Size
        ' frmMsgBox.Location = frm.Location
        frmYesNo.Width = frm.Width
        frmTransparent.Show()
        frmYesNo.ShowDialog()
    End Sub

    Sub MsgBoxGameOver(ByVal frm As Form)
        frmTransparent.Location = frm.Location
        frmTransparent.Size = frm.Size
        ' frmMsgBox.Location = frm.Location
        frmGameOver.Width = frm.Width
        frmTransparent.Show()
        frmGameOver.ShowDialog()
    End Sub
    Function GetRating(ByVal cat As String) As Integer
        connected()
        Dim i As Integer
        sql = "SELECT " & cat & " from tblplayer where player_name ='" & playername & "'"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function


    Sub HRMIN(ByVal hrmin As String, ByVal sec As Integer, ByVal c As AnalogClock.Clock)
        Try
            'Some custom start time for the clock.
            Dim cdt As DateTime = CDate("#" & hrmin & ":" & sec & " #")
            'Get the current UTC dateTime. This is needed beacuse the clock internal works with UTC dateTime.
            Dim utcDt As DateTime = DateTime.UtcNow
            'Set clock's UtcOffset property.
            c.UtcOffset = New TimeSpan(0, cdt.Hour - utcDt.Hour, cdt.Minute - utcDt.Minute, cdt.Second - utcDt.Second)
        Catch
        End Try
    End Sub

    Function GetEquation() As String
        connected()
        Dim i As String
        sql = "SELECT prob from tblequation where id =" & GenerateRandom(CountEquation("tblequation")) & ""
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function
    Function GetProbTime(ByVal prob As String) As String
        connected()
        Dim i As String
        sql = "SELECT probtime from tbltime where prob ='" & prob & "'"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function
    Function GetAnswer(ByVal prob As String) As String
        connected()
        Dim i As String
        sql = "SELECT ans from tblequation where prob ='" & prob & "'"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function
    Function GetAnswerTime(ByVal prob As String) As String
        connected()
        Dim i As String
        sql = "SELECT hrmn from tbltime where prob ='" & prob & "'"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function
    Function GetTemperatureAnswer(ByVal prob As String) As String
        connected()
        Dim i As String
        sql = "SELECT cup_temp from tbltemperature where prob ='" & prob & "'"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function
    Function GetSizeAnswer(ByVal prob As String) As String
        connected()
        Dim i As String
        sql = "SELECT animals_size from tblmeasure where prob ='" & prob & "'"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function
    Function CountEquation(ByVal tbl As String) As Integer
        connected()
        Dim i As Integer
        sql = "SELECT count(prob) from " & tbl & ""
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function

    Function CountAnimals() As Integer
        connected()
        Dim i As Integer
        sql = "SELECT count(prob) from tblmeasure"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function
    Function CountCups() As Integer
        connected()
        Dim i As Integer
        sql = "SELECT count(prob) from tbltemperature"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function


    Function GetTimeProblem() As String
        connected()
        Dim i As String
        sql = "SELECT prob from tbltime where id =" & GenerateRandom(CountEquation("tbltime")) & ""
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function

    Function GetTimeAnsHr(ByVal prob As String) As String
        connected()
        Dim i As String
        sql = "SELECT anshr from tbltime where prob ='" & prob & "'"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function

    Function GetTimeAnsMn(ByVal prob As String) As String
        connected()
        Dim i As String
        sql = "SELECT ansmn from tbltime where prob ='" & prob & "'"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function

    Function GenerateRandom(ByVal rn As Integer) As Integer
        If ctr = lb.Items.Count() Then
            chan.DisplayRandomInListbox(rn, lb)
            ctr = 0
            i = 0
            i = lb.Items.Item(ctr)
        Else
            i = lb.Items.Item(ctr)
            ctr += 1
        End If
        Return i
    End Function


    Sub LoadSquared(ByVal lv As ListBox)
        connected()
        Dim i As Integer
        sql = "SELECT squared from tblsquare"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                lv.Items.Add(dr.Item(0).ToString)
            Loop
        End If
    End Sub

    Sub LoadSquaredNot(ByVal lv As ListBox)
        connected()
        Dim i As Integer
        sql = "SELECT squared_not from tblsquare"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                lv.Items.Add(dr.Item(0).ToString)
            Loop
        End If
    End Sub

    Function GetBestScore(ByVal tbl As String) As Integer
        connected()
        Dim i As Integer
        sql = "SELECT player_score from " & tbl & " where player_name = '" & playername & "'"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function

    Sub SaveScore(ByVal str As String, ByVal score As Integer)
        connected()
        sql = "UPDATE " & str & " SET player_score = " & score & " where player_name = '" & playername & "'"
        CommandDb()
        If cmd.ExecuteNonQuery() = 1 Then
        Else
        End If
    End Sub

    Sub SaveRating(ByVal str As String, ByVal rating As Integer)
        connected()
        sql = "UPDATE tblplayer SET " & str & " = " & rating & " where player_name = '" & playername & "'"
        CommandDb()
        If cmd.ExecuteNonQuery() = 1 Then
        Else
        End If
    End Sub

    Function GetScore(ByVal tbl As String) As Integer
        connected()
        Dim i As Integer
        sql = "SELECT player_score from " & tbl & " where player_name ='" & playername & "'"
        CommandDb()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                i = dr.Item(0).ToString
            Loop
        End If
        Return i
    End Function

    Function generatescore() As Integer
        Dim i As Integer
        i = correct * 3
        i -= wrong
        If i <= 0 Then
            i = 0
        End If
        Return i
    End Function

    Function getrating() As Integer
        Dim i As Integer
        If generatescore() <= 0 Then
            i = 0
        ElseIf generatescore() <= 20 And generatescore() >= 1 Then
            i = 1
        ElseIf generatescore() <= 40 And generatescore() >= 21 Then
            i = 2
        ElseIf generatescore() >= 41 Then
            i = 3
        End If
        'MsgBox(i)
        Return i
    End Function

    Sub SaveData(ByVal score As Integer)
        If GetScore("tblequationscore") < score And isonEquation = True Then
            SaveScore("tblequationscore", score)
            SaveRating("cat_equation", GetRating)
        ElseIf GetScore("tblsquarescore") < score And isonSquare = True Then
            SaveScore("tblsquarescore", score)
            SaveRating("cat_square", GetRating)
        ElseIf GetScore("tbltimescore") < score And isonTime = True Then
            SaveScore("tbltimescore", score)
            SaveRating("cat_time", GetRating)
        ElseIf GetScore("tblmeasurescore") < score And isonMeasure = True Then
            SaveScore("tblmeasurescore", score)
            SaveRating("cat_measure", GetRating)
        ElseIf GetScore("tbltemperaturescore") < score And isonTemperature = True Then
            SaveScore("tbltemperaturescore", score)
            SaveRating("cat_temperature", GetRating)
        End If
    End Sub
End Module
