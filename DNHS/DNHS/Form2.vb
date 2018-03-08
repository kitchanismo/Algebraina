Public Class Form2

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'j += 4
        If Panel1.Width < TextBox1.Text Then
            Panel1.Width += 3
            If Panel1.Width >= TextBox1.Text Then
                Timer1.Stop()
            End If
        Else
            Panel1.Width += -3
            If Panel1.Width <= TextBox1.Text Then
                Timer1.Stop()
            End If
        End If

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub
End Class