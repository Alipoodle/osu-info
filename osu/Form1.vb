﻿Imports MaterialSkin
Imports osuElements
Imports osuElements.Api.Repositories

Public Class Form1
    Public RainbowActive = 0
    Dim uRep = New ApiUserRepository()
    Dim bRep = New ApiBeatmapRepository()
    Dim BMPB(4) As Integer
    Dim BMPR(4) As Integer
    Dim GetBestCounter = 0
    Dim GetRecentCounter = 0


    Public Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme()

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
            Dim map = Await bRep.Get(top.Item(GetBestCounter).BeatmapId)
            one.SubItems.Add(map.Title & " [" & map.version & "]")
            one.SubItems.Add(Math.Round(top.Item(GetBestCounter).Pp))
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

    Private Sub Theme()
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)

        If My.Settings.DarkTheme = "LIGHT" Then
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        ElseIf My.Settings.DarkTheme = "DARK" Then
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
        End If

        If My.Settings.Colour = "Red" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Red500, Primary.Red700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(244, 67, 54)
            SettingsIcon.BackColor = Color.FromArgb(244, 67, 54)
            RefreshIcon.BackColor = Color.FromArgb(244, 67, 54)
        ElseIf My.Settings.Colour = "Pink" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Pink500, Primary.Pink700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(233, 30, 99)
            SettingsIcon.BackColor = Color.FromArgb(233, 30, 99)
            RefreshIcon.BackColor = Color.FromArgb(233, 30, 99)
        ElseIf My.Settings.Colour = "Purple" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Purple500, Primary.Purple700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(156, 39, 176)
            SettingsIcon.BackColor = Color.FromArgb(156, 39, 176)
            RefreshIcon.BackColor = Color.FromArgb(156, 39, 176)
        ElseIf My.Settings.Colour = "DeepPurple" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.DeepPurple500, Primary.DeepPurple700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(103, 58, 183)
            SettingsIcon.BackColor = Color.FromArgb(103, 58, 183)
            RefreshIcon.BackColor = Color.FromArgb(103, 58, 183)
        ElseIf My.Settings.Colour = "Indigo" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(63, 81, 181)
            SettingsIcon.BackColor = Color.FromArgb(63, 81, 181)
            RefreshIcon.BackColor = Color.FromArgb(63, 81, 181)
        ElseIf My.Settings.Colour = "Blue" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(33, 150, 243)
            SettingsIcon.BackColor = Color.FromArgb(33, 150, 243)
            RefreshIcon.BackColor = Color.FromArgb(33, 150, 243)
        ElseIf My.Settings.Colour = "LightBlue" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.LightBlue500, Primary.LightBlue700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(3, 169, 244)
            SettingsIcon.BackColor = Color.FromArgb(3, 169, 244)
            RefreshIcon.BackColor = Color.FromArgb(3, 169, 244)
        ElseIf My.Settings.Colour = "Cyan" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Cyan500, Primary.Cyan700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(0, 188, 212)
            SettingsIcon.BackColor = Color.FromArgb(0, 188, 212)
            RefreshIcon.BackColor = Color.FromArgb(0, 188, 212)
        ElseIf My.Settings.Colour = "Teal" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(0, 150, 136)
            SettingsIcon.BackColor = Color.FromArgb(0, 150, 136)
            RefreshIcon.BackColor = Color.FromArgb(0, 150, 136)
        ElseIf My.Settings.Colour = "Green" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Green500, Primary.Green700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(76, 175, 80)
            SettingsIcon.BackColor = Color.FromArgb(76, 175, 80)
            RefreshIcon.BackColor = Color.FromArgb(76, 175, 80)
        ElseIf My.Settings.Colour = "LightGreen" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.LightGreen500, Primary.LightGreen700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(139, 195, 74)
            SettingsIcon.BackColor = Color.FromArgb(139, 195, 74)
            RefreshIcon.BackColor = Color.FromArgb(139, 195, 74)
        ElseIf My.Settings.Colour = "Lime" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Lime500, Primary.Lime700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(205, 220, 57)
            SettingsIcon.BackColor = Color.FromArgb(205, 220, 57)
            RefreshIcon.BackColor = Color.FromArgb(205, 220, 57)
        ElseIf My.Settings.Colour = "Yellow" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Yellow500, Primary.Yellow700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(255, 235, 59)
            SettingsIcon.BackColor = Color.FromArgb(255, 235, 59)
            RefreshIcon.BackColor = Color.FromArgb(255, 235, 59)
        ElseIf My.Settings.Colour = "Amber" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Amber500, Primary.Amber700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(255, 193, 7)
            SettingsIcon.BackColor = Color.FromArgb(255, 193, 7)
            RefreshIcon.BackColor = Color.FromArgb(255, 193, 7)
        ElseIf My.Settings.Colour = "Orange" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Orange500, Primary.Orange700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(255, 152, 0)
            SettingsIcon.BackColor = Color.FromArgb(255, 152, 0)
            RefreshIcon.BackColor = Color.FromArgb(255, 152, 0)
        ElseIf My.Settings.Colour = "DeepOrange" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.DeepOrange500, Primary.DeepOrange700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(255, 87, 34)
            SettingsIcon.BackColor = Color.FromArgb(255, 87, 34)
            RefreshIcon.BackColor = Color.FromArgb(255, 87, 34)
        ElseIf My.Settings.Colour = "Brown" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Brown500, Primary.Brown700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(121, 85, 72)
            SettingsIcon.BackColor = Color.FromArgb(121, 85, 72)
            RefreshIcon.BackColor = Color.FromArgb(121, 85, 72)
        ElseIf My.Settings.Colour = "Gray" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Grey500, Primary.Grey700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(158, 158, 158)
            SettingsIcon.BackColor = Color.FromArgb(158, 158, 158)
            RefreshIcon.BackColor = Color.FromArgb(158, 158, 158)
        ElseIf My.Settings.Colour = "BlueGray" Then
            SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey500, Primary.BlueGrey700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(96, 125, 139)
            SettingsIcon.BackColor = Color.FromArgb(96, 125, 139)
            RefreshIcon.BackColor = Color.FromArgb(96, 125, 139)
        End If
    End Sub

    Async Sub RainbowSub()
        Do
            SkinManager.ColorScheme = New ColorScheme(Primary.Red500, Primary.Red700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(244, 67, 54)
            SettingsIcon.BackColor = Color.FromArgb(244, 67, 54)
            RefreshIcon.BackColor = Color.FromArgb(244, 67, 54)
            Await Task.Delay(50)
            SkinManager.ColorScheme = New ColorScheme(Primary.Pink500, Primary.Pink700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(233, 30, 99)
            SettingsIcon.BackColor = Color.FromArgb(233, 30, 99)
            RefreshIcon.BackColor = Color.FromArgb(233, 30, 99)
            Await Task.Delay(50)
            SkinManager.ColorScheme = New ColorScheme(Primary.Purple500, Primary.Purple700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(156, 39, 176)
            SettingsIcon.BackColor = Color.FromArgb(156, 39, 176)
            RefreshIcon.BackColor = Color.FromArgb(156, 39, 176)
            Await Task.Delay(50)
            SkinManager.ColorScheme = New ColorScheme(Primary.DeepPurple500, Primary.DeepPurple700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(103, 58, 183)
            SettingsIcon.BackColor = Color.FromArgb(103, 58, 183)
            RefreshIcon.BackColor = Color.FromArgb(103, 58, 183)
            Await Task.Delay(50)
            SkinManager.ColorScheme = New ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(63, 81, 181)
            SettingsIcon.BackColor = Color.FromArgb(63, 81, 181)
            RefreshIcon.BackColor = Color.FromArgb(63, 81, 181)
            Await Task.Delay(50)
            SkinManager.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(33, 150, 243)
            SettingsIcon.BackColor = Color.FromArgb(33, 150, 243)
            RefreshIcon.BackColor = Color.FromArgb(33, 150, 243)
            Await Task.Delay(50)
            SkinManager.ColorScheme = New ColorScheme(Primary.LightBlue500, Primary.LightBlue700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(3, 169, 244)
            SettingsIcon.BackColor = Color.FromArgb(3, 169, 244)
            RefreshIcon.BackColor = Color.FromArgb(3, 169, 244)
            Await Task.Delay(50)
            SkinManager.ColorScheme = New ColorScheme(Primary.Cyan500, Primary.Cyan700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(0, 188, 212)
            SettingsIcon.BackColor = Color.FromArgb(0, 188, 212)
            RefreshIcon.BackColor = Color.FromArgb(0, 188, 212)
            Await Task.Delay(50)
            SkinManager.ColorScheme = New ColorScheme(Primary.Teal500, Primary.Teal700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(0, 150, 136)
            SettingsIcon.BackColor = Color.FromArgb(0, 150, 136)
            RefreshIcon.BackColor = Color.FromArgb(0, 150, 136)
            Await Task.Delay(50)
            SkinManager.ColorScheme = New ColorScheme(Primary.Green500, Primary.Green700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(76, 175, 80)
            SettingsIcon.BackColor = Color.FromArgb(76, 175, 80)
            RefreshIcon.BackColor = Color.FromArgb(76, 175, 80)
            Await Task.Delay(50)
            SkinManager.ColorScheme = New ColorScheme(Primary.LightGreen500, Primary.LightGreen700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(139, 195, 74)
            SettingsIcon.BackColor = Color.FromArgb(139, 195, 74)
            RefreshIcon.BackColor = Color.FromArgb(139, 195, 74)
            Await Task.Delay(50)
            SkinManager.ColorScheme = New ColorScheme(Primary.Lime500, Primary.Lime700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(205, 220, 57)
            SettingsIcon.BackColor = Color.FromArgb(205, 220, 57)
            RefreshIcon.BackColor = Color.FromArgb(205, 220, 57)
            Await Task.Delay(50)
            SkinManager.ColorScheme = New ColorScheme(Primary.Yellow500, Primary.Yellow700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(255, 235, 59)
            SettingsIcon.BackColor = Color.FromArgb(255, 235, 59)
            RefreshIcon.BackColor = Color.FromArgb(255, 235, 59)
            Await Task.Delay(50)
            SkinManager.ColorScheme = New ColorScheme(Primary.Amber500, Primary.Amber700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(255, 193, 7)
            SettingsIcon.BackColor = Color.FromArgb(255, 193, 7)
            RefreshIcon.BackColor = Color.FromArgb(255, 193, 7)
            Await Task.Delay(50)
            SkinManager.ColorScheme = New ColorScheme(Primary.Orange500, Primary.Orange700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(255, 152, 0)
            SettingsIcon.BackColor = Color.FromArgb(255, 152, 0)
            RefreshIcon.BackColor = Color.FromArgb(255, 152, 0)
            Await Task.Delay(50)
            SkinManager.ColorScheme = New ColorScheme(Primary.DeepOrange500, Primary.DeepOrange700, Primary.Red200, Accent.LightBlue100, TextShade.WHITE)
            Settings.BackIcon.BackColor = Color.FromArgb(255, 87, 34)
            SettingsIcon.BackColor = Color.FromArgb(255, 87, 34)
            RefreshIcon.BackColor = Color.FromArgb(255, 87, 34)
            Await Task.Delay(50)
        Loop
    End Sub
End Class
