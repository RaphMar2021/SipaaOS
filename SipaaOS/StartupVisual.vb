Public Class StartupVisual
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Logon.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        LogonX.Show()
        Me.Close()
    End Sub

    Private Sub StartupVisual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        If My.Settings.NonInstalle = True Then
            loadingfiles.Show()
            Me.Close()
        End If
        If My.Settings.DebugMode = True Then
            Label2.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2CircleProgressBar1.Increment(3)
        If Guna2CircleProgressBar1.Value = 100 Then
            LogonX.Show()
            Me.Close()
        End If
    End Sub
End Class