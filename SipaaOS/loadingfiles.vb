Public Class loadingfiles
    Private Sub loadingfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2CircleProgressBar1.Increment(3)
        If Guna2CircleProgressBar1.Value = 100 Then
            install.Show()
            Me.Close()
        End If
    End Sub
End Class