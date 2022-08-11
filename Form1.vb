Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static time As Integer
        Select Case time
            Case 1
                Timer1.Interval = 2000
                redlight.ForeColor = Color.Red
                yellowlight.ForeColor = Color.Goldenrod
                greenlight.ForeColor = Color.LightGreen
            Case 2
                Timer1.Interval = 3000
                redlight.ForeColor = Color.IndianRed
                yellowlight.ForeColor = Color.Gold
                greenlight.ForeColor = Color.LightGreen
            Case 3
                Timer1.Interval = 4000
                redlight.ForeColor = Color.IndianRed
                yellowlight.ForeColor = Color.Goldenrod
                greenlight.ForeColor = Color.LimeGreen
                time = 0
        End Select
        time = time + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub
End Class
