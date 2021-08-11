Public Class OOBE
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Guna2TextBox1.Text = "" Then
            My.Settings.Username = "Administrateur"
        Else
            My.Settings.Username = Guna2TextBox1.Text
        End If
        My.Settings.Password = Guna2TextBox2.Text
        Guna2CircleProgressBar1.Visible = True
        Label3.Visible = True
        My.Settings.NotConfigured = False
        My.Settings.Save()
        Guna2CircleProgressBar1.Increment(3)
        If Guna2CircleProgressBar1.Value = 100 Then
            If Guna2CheckBox1.Checked = True Then
                DesktopX.Show()
                Me.Close()

            Else

                Desktop.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub OOBE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class