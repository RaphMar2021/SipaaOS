Public Class LogonX
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Guna2TextBox1.Text = My.Settings.Password Then
            Desktop.Show()
            Me.Close()

        Else

            MsgBox("Mot de passe invalide (PasswordTextBox x My.Settings.Password)", vbCritical + vbOKOnly, "Service de connexion a des utilisateurs")
        End If
    End Sub

    Private Sub LogonX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("C:\SipaaOS\startup.wav")
        Label2.Text = My.Settings.Username
        If My.Settings.Password = "" Then
            Guna2TextBox1.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Guna2TextBox1.Text = My.Settings.Password Then
            DesktopX.Show()
            Me.Close()

        Else

            MsgBox("Mot de passe invalide (PasswordTextBox x My.Settings.Password)", vbCritical + vbOKOnly, "Service de connexion a des utilisateurs")
        End If
    End Sub
End Class