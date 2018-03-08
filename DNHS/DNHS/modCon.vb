Module modCon

    Dim conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbplayer.mdb;"

    Public Sub connected()
        With con
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = conString
            .Open()
        End With
    End Sub

    Public Sub CommandDb()
        cmd = New OleDb.OleDbCommand(sql, con)
    End Sub
End Module