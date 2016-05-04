Imports MaterialSkin
Imports osuElements.Api.Repositories

Public Class Settings
    Dim uRep = New ApiUserRepository()
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackIcon.Hide()
        AboutPanel.Hide()

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        If My.Settings.DarkTheme = "LIGHT" Then
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        ElseIf My.Settings.DarkTheme = "DARK" Then
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
        End If
        SkinManager.ColorScheme = New ColorScheme(Primary.Pink600, Primary.Pink700, Primary.Pink300, Accent.LightBlue100, TextShade.WHITE)

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

    Private Sub BackIcon_Click(sender As Object, e As EventArgs) Handles BackIcon.Click
        BackIcon.Hide()
        SettingsPanel.Show()
        AboutPanel.Hide()
        Me.Text = "Settings"
        Me.Refresh()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Process.Start("https://github.com/GreenTurtwig/osu-info")
    End Sub
End Class