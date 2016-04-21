Imports MaterialSkin
Imports osuElements
Imports osuElements.Api.Repositories

Public Class Form1
    Dim uRep = New ApiUserRepository()
    Dim bRep = New ApiBeatmapRepository()
    Dim BMPs(4) As Integer
    Dim GetBestCounter = 0


    Public Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        If My.Settings.DarkTheme = "LIG0HT" Then
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        ElseIf My.Settings.DarkTheme = "DARK" Then
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
        End If
        SkinManager.ColorScheme = New ColorScheme(Primary.Pink600, Primary.Pink700, Primary.Pink300, Accent.LightBlue100, TextShade.WHITE)

        If My.Settings.APIKey = Nothing Then
            Dim Input = InputBox("Enter your API key", "osu!info")
            Try
                osuElements.osuElements.ApiKey = Input
                Dim account = Await uRep.Get("GreenTurtwig")
            Catch ex As Exception
                Me.Hide()
                MessageBox.Show("Invalid/no API key, please restart the program and enter again")
                Application.Exit()
            End Try
            My.Settings.APIKey = Input
        End If
        osuElements.osuElements.ApiKey = My.Settings.APIKey

        Best.Columns.Add("Rank")
        Best.Columns.Add("Name", 220)
        Best.Columns.Add("pp")
    End Sub

    Async Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Dim uRep = New ApiUserRepository()      'Remove these when the .ToString("N0") bug is fixed
        Dim bRep = New ApiBeatmapRepository()
        Best.Items.Clear()
        GetBestCounter = 0

        Dim account = Await uRep.Get(UsernameBox.Text)
        AccountImage.ImageLocation = ("http://s.ppy.sh/a/" & account.UserId)
        UsernameLabel.Text = account.Username
        LevelLabel.Text = ("Level: " & Int(account.Level))
        LevelProgress.Value = ((account.Level - Int(account.Level)) * 100)
        RankedScore.Text = ("Ranked Score: " & account.RankedScore.ToString("N0"))
        TotalScore.Text = ("Total Score: " & account.TotalScore.ToString("N0"))
        Accuracy.Text = ("Accuracy: " & account.Accuracy & "%")
        PlayCount.Text = ("Play Count: " & account.Playcount.ToString("N0"))
        Performance.Text = ("Performance: " & Int(account.PpRaw.ToString("N0")) & "pp")

        Rank.Text = ("#" & account.PpRank)
        CountryRank.Text = (account.Country & " #" & account.PpCountryRank)

        SSLabel.Text = account.SSCount
        SLabel.Text = account.SCount
        ALabel.Text = account.ACount

        GetBest()
    End Sub

    Public Async Sub GetBest()
        While GetBestCounter < 5
            Dim account = Await uRep.Get(UsernameBox.Text)
            Dim top = Await uRep.GetBest(account.UserId)

            Dim one As New ListViewItem(ConvertRank(top.Item(GetBestCounter).Rank.ToString))
            Dim map = Await bRep.Get(top.Item(GetBestCounter).BeatmapId)
            one.SubItems.Add(map.Title)
            one.SubItems.Add(Math.Round(top.Item(GetBestCounter).Pp))
            BMPs(GetBestCounter) = map.BeatmapSetId
            Best.Items.AddRange(New ListViewItem() {one})
            GetBestCounter = GetBestCounter + 1
        End While
    End Sub

    Public Function ConvertRank(ByVal rank As String) As String
        If rank = "X" Then
            rank = "SS"
        ElseIf rank = "XH" Then
            rank = "SS"
        ElseIf rank = "SH" Then
            rank = "S"
        End If
        ConvertRank = rank
    End Function
    Private Sub Best_ItemActivate(sender As Object, e As EventArgs) Handles Best.ItemActivate
        osuURL.InClientDownload(BMPs(Best.FocusedItem.Index))
    End Sub

    Private Sub DarkThemeIcon_Click(sender As Object, e As EventArgs) Handles DarkThemeIcon.Click
        If My.Settings.DarkTheme = "LIGHT" Then
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
            My.Settings.DarkTheme = "DARK"
        ElseIf My.Settings.DarkTheme = "DARK" Then
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
            My.Settings.DarkTheme = "LIGHT"
        End If
    End Sub

    Private Sub Best_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangedEventArgs) Handles Best.ColumnWidthChanged
        Static FireMe As Boolean = True
        If FireMe = True Then
            FireMe = False
            Best.Columns(0).Width = 60
            Best.Columns(1).Width = 220
            Best.Columns(2).Width = 60
            FireMe = True
        End If
    End Sub
    Private Sub Best_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles Best.ColumnWidthChanging
        e.Cancel = True
    End Sub
End Class
