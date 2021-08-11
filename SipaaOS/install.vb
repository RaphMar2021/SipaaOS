Public Class install
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Guna2CircleProgressBar1.Visible = True
        Label6.Visible = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2CircleProgressBar1.Increment(3)
        If Guna2CircleProgressBar1.Value = 95 Then
            Label6.Text = "Redémarrage..."
        End If
        If Guna2CircleProgressBar1.Value = 100 Then
            My.Settings.NonInstalle = False
            My.Settings.NotConfigured = True
            My.Settings.Save()
            OOBE.Show()
            Me.Close()
        End If
    End Sub
End Class