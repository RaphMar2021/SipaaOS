Public Class Logon
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Guna2TextBox1.Text = My.Settings.Password Then
            Desktop.Show()
            Me.Close()
        Else
            MsgBox("MDP incorrect", vbCritical + vbOKOnly, "Interface graphique de connexion a un compte local")
        End If

    End Sub

    Private Sub Logon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = My.Settings.Username
        If My.Settings.Password = "" Then
            Guna2TextBox1.Visible = False
        End If
    End Sub
End Class