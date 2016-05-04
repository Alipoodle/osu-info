Imports MaterialSkin
Imports osuElements
Imports osuElements.Api.Repositories

Public Class Form1
    Dim uRep = New ApiUserRepository()
    Dim bRep = New ApiBeatmapRepository()
    Dim BMPB(4) As Integer
    Dim BMPR(4) As Integer
    Dim GetBestCounter = 0
    Dim GetRecentCounter = 0


    Public Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        If My.Settings.DarkTheme = "LIGHT" Then
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
        Recent.Columns.Add("Rank")
        Recent.Columns.Add("Name", 280)

        UsernameBox.Text = My.Settings.DefaultUser
        GetData()
    End Sub

    Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        GetData()
    End Sub

    Public Async Sub GetData()
        Dim uRep = New ApiUserRepository()      'Remove these when the .ToString("N0") bug is fixed
        Dim bRep = New ApiBeatmapRepository()
        Best.Items.Clear()
        Recent.Items.Clear()
        GetBestCounter = 0
        GetRecentCounter = 0
        UsernameBox.Enabled = False
        OK.Enabled = False
        RefreshIcon.Enabled = False

        Try
            Dim test = Await uRep.Get(UsernameBox.Text)
            Dim test2 = (test.UserId)
        Catch ex As Exception
            MessageBox.Show("Invalid username, try again")
            UsernameBox.Enabled = True
            Return
        End Try
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
        Flag.ImageLocation = ("https://new.ppy.sh/images/flags/" & account.Country & ".png")

        SSLabel.Text = account.SSCount
        SLabel.Text = account.SCount
        ALabel.Text = account.ACount
        CentreScores()

        GetBest()
        GetRecent()
    End Sub

    Sub CentreScores()
        SSLabel.Location = New Point((SS.Left + (SS.Width / 2)) - (SSLabel.Width / 2), 239)
        SLabel.Location = New Point((S.Left + (S.Width / 2)) - (SLabel.Width / 2), 239)
        ALabel.Location = New Point((A.Left + (A.Width / 2)) - (ALabel.Width / 2), 239)
    End Sub

    Public Async Sub GetBest()
        Dim account = Await uRep.Get(UsernameBox.Text)
        Dim top = Await uRep.GetBest(account.UserId)
        While GetBestCounter < 5
            Try
                Dim test As New ListViewItem(top.Item(GetBestCounter).Rank.ToString)
            Catch ex As Exception
                UsernameBox.Enabled = True
                OK.Enabled = True
                RefreshIcon.Enabled = True
                Return
            End Try
            Dim one As New ListViewItem(ConvertRank(top.Item(GetBestCounter).Rank.ToString))
            Dim map = Await bRep.Get(Top.Item(GetBestCounter).BeatmapId)
            one.SubItems.Add(map.Title & " [" & map.version & "]")
            one.SubItems.Add(Math.Round(Top.Item(GetBestCounter).Pp))
            BMPB(GetBestCounter) = map.BeatmapSetId
            Best.Items.AddRange(New ListViewItem() {one})
            GetBestCounter = GetBestCounter + 1
        End While
        UsernameBox.Enabled = True
        OK.Enabled = True
        RefreshIcon.Enabled = True
    End Sub

    Public Async Sub GetRecent()
        Recent.Show()
        Dim account = Await uRep.Get(UsernameBox.Text)
        Dim top = Await uRep.GetRecent(account.UserId)
        While GetRecentCounter < 5
            Try
                Dim test As New ListViewItem(top.Item(GetRecentCounter).Rank.ToString)
            Catch ex As Exception
                Recent.Hide()
                Return
            End Try
            Dim one As New ListViewItem(ConvertRank(top.Item(GetRecentCounter).Rank.ToString))
            Dim map = Await bRep.Get(top.Item(GetRecentCounter).BeatmapId)
            one.SubItems.Add(map.Title & " [" & map.version & "]")
            BMPR(GetRecentCounter) = map.BeatmapSetId
            Recent.Items.AddRange(New ListViewItem() {one})
            GetRecentCounter = GetRecentCounter + 1
        End While
    End Sub

    Public Function ConvertRank(ByVal rank As String) As String
        If rank = "X" Then
            rank = "SS"
        ElseIf rank = "XH" Then
            rank = "SS"
        ElseIf rank = "SH" Then
            rank = "S"
        ElseIf rank = "F" Then
            rank = "Fail"
        End If
        ConvertRank = rank
    End Function

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
    Private Sub Recent_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangedEventArgs) Handles Recent.ColumnWidthChanged
        Static FireMe As Boolean = True
        If FireMe = True Then
            FireMe = False
            Recent.Columns(0).Width = 60
            Recent.Columns(1).Width = 280
            FireMe = True
        End If
    End Sub
    Private Sub Recent_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles Recent.ColumnWidthChanging
        e.Cancel = True
    End Sub

    Private Sub UsernameBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UsernameBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            GetData()
        End If
    End Sub

    Private Sub SettingsIcon_Click(sender As Object, e As EventArgs) Handles SettingsIcon.Click
        Settings.Show()
    End Sub
    Private Sub RefreshIcon_Click(sender As Object, e As EventArgs) Handles RefreshIcon.Click
        UsernameBox.Text = UsernameLabel.Text
        GetData()
    End Sub

    Private Sub Best_ItemActivate(sender As Object, e As EventArgs) Handles Best.ItemActivate
        osuURL.InClientDownload(BMPB(Best.FocusedItem.Index))
    End Sub
    Private Sub Recent_ItemActivate(sender As Object, e As EventArgs) Handles Recent.ItemActivate
        osuURL.InClientDownload(BMPR(Recent.FocusedItem.Index))
    End Sub
End Class
