Imports MaterialSkin
Imports osuElements.Api.Repositories

Public Class Settings
    Dim uRep = New ApiUserRepository()
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackIcon.Hide()
        AboutPanel.Hide()
        CustomColourPanel.Hide()

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)

        APIKeyBox.Text = My.Settings.APIKey

        If My.Settings.DarkTheme = "LIGHT" Then
            DarkCheckbox.CheckState = CheckState.Unchecked
        ElseIf My.Settings.DarkTheme = "DARK" Then
            DarkCheckbox.CheckState = CheckState.Checked
        End If

        DefaultUserBox.Text = My.Settings.DefaultUser
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Async Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If APIKeyBox.Text = Nothing Then
            MessageBox.Show("Enter your API key", "osu!info")
            Return
        End If
        Try
            osuElements.osuElements.ApiKey = APIKeyBox.Text
            Dim test = Await uRep.Get("GreenTurtwig")
        Catch ex As Exception
            MessageBox.Show("Invalid API key")
            Return
        End Try
        osuElements.osuElements.ApiKey = APIKeyBox.Text
        My.Settings.APIKey = APIKeyBox.Text


        If DarkCheckbox.CheckState = CheckState.Checked Then
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            My.Settings.DarkTheme = "DARK"
        ElseIf DarkCheckbox.CheckState = CheckState.Unchecked Then
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            My.Settings.DarkTheme = "LIGHT"
        End If


        If DefaultUserBox.Text = Nothing Then
            My.Settings.DefaultUser = "peppy"
        Else
            Try
                Dim test = Await uRep.Get(DefaultUserBox.Text)
                Dim test2 = (test.UserId)
            Catch ex As Exception
                MessageBox.Show("Invalid username")
                Return
            End Try
            My.Settings.DefaultUser = DefaultUserBox.Text
        End If

        Me.Close()
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        BackIcon.Show()
        SettingsPanel.Hide()
        AboutPanel.Show()
        Me.Text = "       About"
        Me.Refresh()
    End Sub
    Private Sub AboutSelector_Click(sender As Object, e As EventArgs) Handles AboutSelector.Click
        BackIcon.Show()
        SettingsPanel.Hide()
        AboutPanel.Show()
        Me.Text = "       About"
        Me.Refresh()
    End Sub
    Private Sub CustomColour_Click(sender As Object, e As EventArgs) Handles CustomColour.Click
        BackIcon.Show()
        SettingsPanel.Hide()
        CustomColourPanel.Show()
        If Form1.RainbowActive = 1 Then
            Rainbow.Image = My.Resources.rainbow
        End If
        Me.Text = "       Custom Colour"
        Me.Refresh()
    End Sub
    Private Sub CustomColourSelector_Click(sender As Object, e As EventArgs) Handles CustomColourSelector.Click
        BackIcon.Show()
        SettingsPanel.Hide()
        CustomColourPanel.Show()
        If Form1.RainbowActive = 1 Then
            Rainbow.Image = My.Resources.rainbow
        End If
        Me.Text = "       Custom Colour"
        Me.Refresh()
    End Sub

    Private Sub BackIcon_Click(sender As Object, e As EventArgs) Handles BackIcon.Click
        BackIcon.Hide()
        SettingsPanel.Show()
        AboutPanel.Hide()
        CustomColourPanel.Hide()
        Me.Text = "Settings"
        Me.Refresh()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Process.Start("https://github.com/GreenTurtwig/osu-info")
    End Sub

    Private Sub Lauchosu_Click(sender As Object, e As EventArgs) Handles Lauchosu.Click
        Process.Start("osu://")
    End Sub
    Private Sub LaunchosuPanel_Click(sender As Object, e As EventArgs) Handles LaunchosuSelector.Click
        Process.Start("osu://")
    End Sub

    Private Sub Red_Click(sender As Object, e As EventArgs) Handles Red.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.Red500, Primary.Red700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(244, 67, 54)
        Form1.SettingsIcon.BackColor = Color.FromArgb(244, 67, 54)
        Form1.RefreshIcon.BackColor = Color.FromArgb(244, 67, 54)
        My.Settings.Colour = "Red"
    End Sub
    Private Sub Pink_Click(sender As Object, e As EventArgs) Handles Pink.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.Pink500, Primary.Pink700, Primary.Pink200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(233, 30, 99)
        Form1.SettingsIcon.BackColor = Color.FromArgb(233, 30, 99)
        Form1.RefreshIcon.BackColor = Color.FromArgb(233, 30, 99)
        My.Settings.Colour = "Pink"
    End Sub
    Private Sub Purple_Click(sender As Object, e As EventArgs) Handles Purple.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.Purple500, Primary.Purple700, Primary.Purple200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(156, 39, 176)
        Form1.SettingsIcon.BackColor = Color.FromArgb(156, 39, 176)
        Form1.RefreshIcon.BackColor = Color.FromArgb(156, 39, 176)
        My.Settings.Colour = "Purple"
    End Sub
    Private Sub DeepPurple_Click(sender As Object, e As EventArgs) Handles DeepPurple.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.DeepPurple500, Primary.DeepPurple700, Primary.DeepPurple200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(103, 58, 183)
        Form1.SettingsIcon.BackColor = Color.FromArgb(103, 58, 183)
        Form1.RefreshIcon.BackColor = Color.FromArgb(103, 58, 183)
        My.Settings.Colour = "DeepPurple"
    End Sub
    Private Sub Indigo_Click(sender As Object, e As EventArgs) Handles Indigo.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(63, 81, 181)
        Form1.SettingsIcon.BackColor = Color.FromArgb(63, 81, 181)
        Form1.RefreshIcon.BackColor = Color.FromArgb(63, 81, 181)
        My.Settings.Colour = "Indigo"
    End Sub
    Private Sub Blue_Click(sender As Object, e As EventArgs) Handles Blue.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(33, 150, 243)
        Form1.SettingsIcon.BackColor = Color.FromArgb(33, 150, 243)
        Form1.RefreshIcon.BackColor = Color.FromArgb(33, 150, 243)
        My.Settings.Colour = "Blue"
    End Sub
    Private Sub LightBlue_Click(sender As Object, e As EventArgs) Handles LightBlue.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.LightBlue500, Primary.LightBlue700, Primary.LightBlue200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(3, 169, 244)
        Form1.SettingsIcon.BackColor = Color.FromArgb(3, 169, 244)
        Form1.RefreshIcon.BackColor = Color.FromArgb(3, 169, 244)
        My.Settings.Colour = "LightBlue"
    End Sub
    Private Sub Cyan_Click(sender As Object, e As EventArgs) Handles Cyan.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.Cyan500, Primary.Cyan700, Primary.Cyan200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(0, 188, 212)
        Form1.SettingsIcon.BackColor = Color.FromArgb(0, 188, 212)
        Form1.RefreshIcon.BackColor = Color.FromArgb(0, 188, 212)
        My.Settings.Colour = "Cyan"
    End Sub
    Private Sub Teal_Click(sender As Object, e As EventArgs) Handles Teal.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Teal200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(0, 150, 136)
        Form1.SettingsIcon.BackColor = Color.FromArgb(0, 150, 136)
        Form1.RefreshIcon.BackColor = Color.FromArgb(0, 150, 136)
        My.Settings.Colour = "Teal"
    End Sub
    Private Sub Green_Click(sender As Object, e As EventArgs) Handles Green.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.Green500, Primary.Green700, Primary.Green200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(76, 175, 80)
        Form1.SettingsIcon.BackColor = Color.FromArgb(76, 175, 80)
        Form1.RefreshIcon.BackColor = Color.FromArgb(76, 175, 80)
        My.Settings.Colour = "Green"
    End Sub
    Private Sub LightGreen_Click(sender As Object, e As EventArgs) Handles LightGreen.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.LightGreen500, Primary.LightGreen700, Primary.LightGreen200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(139, 195, 74)
        Form1.SettingsIcon.BackColor = Color.FromArgb(139, 195, 74)
        Form1.RefreshIcon.BackColor = Color.FromArgb(139, 195, 74)
        My.Settings.Colour = "LightGreen"
    End Sub
    Private Sub Lime_Click(sender As Object, e As EventArgs) Handles Lime.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.Lime500, Primary.Lime700, Primary.Lime200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(205, 220, 57)
        Form1.SettingsIcon.BackColor = Color.FromArgb(205, 220, 57)
        Form1.RefreshIcon.BackColor = Color.FromArgb(205, 220, 57)
        My.Settings.Colour = "Lime"
    End Sub
    Private Sub Yellow_Click(sender As Object, e As EventArgs) Handles Yellow.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.Yellow500, Primary.Yellow700, Primary.Lime200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(255, 235, 59)
        Form1.SettingsIcon.BackColor = Color.FromArgb(255, 235, 59)
        Form1.RefreshIcon.BackColor = Color.FromArgb(255, 235, 59)
        My.Settings.Colour = "Yellow"
    End Sub
    Private Sub Amber_Click(sender As Object, e As EventArgs) Handles Amber.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.Amber500, Primary.Amber700, Primary.Amber200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(255, 193, 7)
        Form1.SettingsIcon.BackColor = Color.FromArgb(255, 193, 7)
        Form1.RefreshIcon.BackColor = Color.FromArgb(255, 193, 7)
        My.Settings.Colour = "Amber"
    End Sub
    Private Sub Orange_Click(sender As Object, e As EventArgs) Handles Orange.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.Orange500, Primary.Orange700, Primary.Orange200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(255, 152, 0)
        Form1.SettingsIcon.BackColor = Color.FromArgb(255, 152, 0)
        Form1.RefreshIcon.BackColor = Color.FromArgb(255, 152, 0)
        My.Settings.Colour = "Orange"
    End Sub
    Private Sub DeepOrange_Click(sender As Object, e As EventArgs) Handles DeepOrange.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.DeepOrange500, Primary.DeepOrange700, Primary.DeepOrange200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(255, 87, 34)
        Form1.SettingsIcon.BackColor = Color.FromArgb(255, 87, 34)
        Form1.RefreshIcon.BackColor = Color.FromArgb(255, 87, 34)
        My.Settings.Colour = "DeepOrange"
    End Sub
    Private Sub Brown_Click(sender As Object, e As EventArgs) Handles Brown.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.Brown500, Primary.Brown700, Primary.Brown200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(121, 85, 72)
        Form1.SettingsIcon.BackColor = Color.FromArgb(121, 85, 72)
        Form1.RefreshIcon.BackColor = Color.FromArgb(121, 85, 72)
        My.Settings.Colour = "Brown"
    End Sub
    Private Sub Gray_Click(sender As Object, e As EventArgs) Handles Gray.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.Grey500, Primary.Grey700, Primary.Grey200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(158, 158, 158)
        Form1.SettingsIcon.BackColor = Color.FromArgb(158, 158, 158)
        Form1.RefreshIcon.BackColor = Color.FromArgb(158, 158, 158)
        My.Settings.Colour = "Gray"
    End Sub
    Private Sub BlueGray_Click(sender As Object, e As EventArgs) Handles BlueGray.Click
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey500, Primary.BlueGrey700, Primary.BlueGrey200, Accent.LightBlue100, TextShade.WHITE)
        BackIcon.BackColor = Color.FromArgb(96, 125, 139)
        Form1.SettingsIcon.BackColor = Color.FromArgb(96, 125, 139)
        Form1.RefreshIcon.BackColor = Color.FromArgb(96, 125, 139)
        My.Settings.Colour = "BlueGray"
    End Sub

    Private Sub Rainbow_Click(sender As Object, e As EventArgs) Handles Rainbow.Click
        If Form1.UsernameBox.Text = "GreenTurtwig" Or Form1.UsernameBox.Text = "Alipoodle" Then
            If Form1.RainbowActive = 0 Then
                Rainbow.Image = My.Resources.rainbow
                Form1.RainbowSub()
                Form1.RainbowActive = 1
            End If
        End If
    End Sub
End Class