Public Class frmYesNo



    Private Sub btnstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstart.Click
        confirm = "yes"
        Me.Close()
        frmTransparent.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        confirm = "no"
        Me.Close()
        frmTransparent.Close()
    End Sub
End Class