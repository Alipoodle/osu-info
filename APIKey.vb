Imports MaterialSkin
Imports osuElements

Public Class APIKey
    Private Sub APIKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        If My.Settings.DarkTheme = "LIGHT" Then
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        ElseIf My.Settings.DarkTheme = "DARK" Then
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
        End If
        SkinManager.ColorScheme = New ColorScheme(Primary.Pink600, Primary.Pink700, Primary.Pink300, Accent.LightBlue100, TextShade.WHITE)
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        My.Settings.APIKey = APIKeyBox.Text
        osuElements.osuElements.ApiKey = My.Settings.APIKey

    End Sub
End Class