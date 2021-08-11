Public Class Properties
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Username = UserBox.Text
        My.Settings.Password = Passbox.Text
        My.Settings.Save()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        SipaaOS.Desktop.BackgroundImage = My.Resources.img0
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        SipaaOS.Desktop.BackgroundImage = My.Resources.img28
    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click
        SipaaOS.Desktop.BackgroundImage = My.Resources.rainbow_narcissus_poeticus_wallpaper_1600x900
    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click
        SipaaOS.Desktop.BackgroundImage = My.Resources.img01
    End Sub

    Private Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox5.Click
        SipaaOS.Desktop.BackgroundImage = My.Resources.macos_12_monterey_wallpaper_dark
    End Sub

    Private Sub Guna2PictureBox6_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox6.Click
        SipaaOS.Desktop.BackgroundImage = My.Resources.macos_12_monterey_wallpaper_light
    End Sub

    Private Sub Guna2PictureBox7_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox7.Click
        SipaaOS.Desktop.BackgroundImage = My.Resources.windows_8_1_wallpaper_remodeled_wallpaper_1680x1050
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        My.Settings.NonInstalle = True
        My.Settings.Save()
        StartupVisual.Show()
        Me.Close()
    End Sub

    Private Sub MetroTabPage4_Click(sender As Object, e As EventArgs) Handles MetroTabPage4.Click

    End Sub

    Private Sub Properties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Guna2CheckBox1.Checked = True Then
            My.Settings.DebugMode = True
            My.Settings.Save()
        Else
            My.Settings.DebugMode = False
            My.Settings.Save()
        End If
    End Sub
End Class