<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.UsernameBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.OK = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.UsernameLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.LevelLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.LevelProgress = New MaterialSkin.Controls.MaterialProgressBar()
        Me.RankedScore = New MaterialSkin.Controls.MaterialLabel()
        Me.TotalScore = New MaterialSkin.Controls.MaterialLabel()
        Me.Accuracy = New MaterialSkin.Controls.MaterialLabel()
        Me.PlayCount = New MaterialSkin.Controls.MaterialLabel()
        Me.Rank = New MaterialSkin.Controls.MaterialLabel()
        Me.CountryRank = New MaterialSkin.Controls.MaterialLabel()
        Me.Performance = New MaterialSkin.Controls.MaterialLabel()
        Me.SSLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.SLabel = New MaterialSkin.Controls.MaterialLabel()
        Me.ALabel = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Best = New MaterialSkin.Controls.MaterialListView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Recent = New MaterialSkin.Controls.MaterialListView()
        Me.NoData = New MaterialSkin.Controls.MaterialLabel()
        Me.RefreshIcon = New System.Windows.Forms.PictureBox()
        Me.SettingsIcon = New System.Windows.Forms.PictureBox()
        Me.Flag = New System.Windows.Forms.PictureBox()
        Me.AccountImage = New System.Windows.Forms.PictureBox()
        Me.A = New System.Windows.Forms.PictureBox()
        Me.S = New System.Windows.Forms.PictureBox()
        Me.SS = New System.Windows.Forms.PictureBox()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.RefreshIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingsIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Flag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.S, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameBox
        '
        Me.UsernameBox.Depth = 0
        Me.UsernameBox.Hint = ""
        Me.UsernameBox.Location = New System.Drawing.Point(12, 421)
        Me.UsernameBox.MaxLength = 32767
        Me.UsernameBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameBox.SelectedText = ""
        Me.UsernameBox.SelectionLength = 0
        Me.UsernameBox.SelectionStart = 0
        Me.UsernameBox.Size = New System.Drawing.Size(258, 23)
        Me.UsernameBox.TabIndex = 5
        Me.UsernameBox.TabStop = False
        Me.UsernameBox.UseSystemPasswordChar = False
        '
        'OK
        '
        Me.OK.Depth = 0
        Me.OK.Location = New System.Drawing.Point(281, 421)
        Me.OK.MouseState = MaterialSkin.MouseState.HOVER
        Me.OK.Name = "OK"
        Me.OK.Primary = True
        Me.OK.Size = New System.Drawing.Size(67, 23)
        Me.OK.TabIndex = 7
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(-54, 179)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(459, 1)
        Me.MaterialDivider1.TabIndex = 8
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Depth = 0
        Me.UsernameLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UsernameLabel.Location = New System.Drawing.Point(38, 3)
        Me.UsernameLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(77, 19)
        Me.UsernameLabel.TabIndex = 9
        Me.UsernameLabel.Text = "Username"
        '
        'LevelLabel
        '
        Me.LevelLabel.AutoSize = True
        Me.LevelLabel.Depth = 0
        Me.LevelLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.LevelLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LevelLabel.Location = New System.Drawing.Point(154, 3)
        Me.LevelLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(60, 19)
        Me.LevelLabel.TabIndex = 10
        Me.LevelLabel.Text = "Level: 0"
        '
        'LevelProgress
        '
        Me.LevelProgress.Depth = 0
        Me.LevelProgress.Location = New System.Drawing.Point(158, 25)
        Me.LevelProgress.MouseState = MaterialSkin.MouseState.HOVER
        Me.LevelProgress.Name = "LevelProgress"
        Me.LevelProgress.Size = New System.Drawing.Size(136, 5)
        Me.LevelProgress.Step = 1
        Me.LevelProgress.TabIndex = 11
        '
        'RankedScore
        '
        Me.RankedScore.AutoSize = True
        Me.RankedScore.Depth = 0
        Me.RankedScore.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.RankedScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RankedScore.Location = New System.Drawing.Point(154, 33)
        Me.RankedScore.MouseState = MaterialSkin.MouseState.HOVER
        Me.RankedScore.Name = "RankedScore"
        Me.RankedScore.Size = New System.Drawing.Size(117, 19)
        Me.RankedScore.TabIndex = 12
        Me.RankedScore.Text = "Ranked Score: 0"
        '
        'TotalScore
        '
        Me.TotalScore.AutoSize = True
        Me.TotalScore.Depth = 0
        Me.TotalScore.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.TotalScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TotalScore.Location = New System.Drawing.Point(154, 52)
        Me.TotalScore.MouseState = MaterialSkin.MouseState.HOVER
        Me.TotalScore.Name = "TotalScore"
        Me.TotalScore.Size = New System.Drawing.Size(103, 19)
        Me.TotalScore.TabIndex = 13
        Me.TotalScore.Text = "Total Score: 0"
        '
        'Accuracy
        '
        Me.Accuracy.AutoSize = True
        Me.Accuracy.Depth = 0
        Me.Accuracy.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Accuracy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Accuracy.Location = New System.Drawing.Point(154, 71)
        Me.Accuracy.MouseState = MaterialSkin.MouseState.HOVER
        Me.Accuracy.Name = "Accuracy"
        Me.Accuracy.Size = New System.Drawing.Size(114, 19)
        Me.Accuracy.TabIndex = 14
        Me.Accuracy.Text = "Accuracy: 100%"
        '
        'PlayCount
        '
        Me.PlayCount.AutoSize = True
        Me.PlayCount.Depth = 0
        Me.PlayCount.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.PlayCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PlayCount.Location = New System.Drawing.Point(154, 90)
        Me.PlayCount.MouseState = MaterialSkin.MouseState.HOVER
        Me.PlayCount.Name = "PlayCount"
        Me.PlayCount.Size = New System.Drawing.Size(97, 19)
        Me.PlayCount.TabIndex = 15
        Me.PlayCount.Text = "Play Count: 0"
        '
        'Rank
        '
        Me.Rank.AutoSize = True
        Me.Rank.Depth = 0
        Me.Rank.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Rank.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Rank.Location = New System.Drawing.Point(8, 128)
        Me.Rank.MouseState = MaterialSkin.MouseState.HOVER
        Me.Rank.Name = "Rank"
        Me.Rank.Size = New System.Drawing.Size(26, 19)
        Me.Rank.TabIndex = 16
        Me.Rank.Text = "#0"
        '
        'CountryRank
        '
        Me.CountryRank.AutoSize = True
        Me.CountryRank.Depth = 0
        Me.CountryRank.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.CountryRank.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CountryRank.Location = New System.Drawing.Point(8, 147)
        Me.CountryRank.MouseState = MaterialSkin.MouseState.HOVER
        Me.CountryRank.Name = "CountryRank"
        Me.CountryRank.Size = New System.Drawing.Size(49, 19)
        Me.CountryRank.TabIndex = 17
        Me.CountryRank.Text = "GB #0"
        '
        'Performance
        '
        Me.Performance.AutoSize = True
        Me.Performance.Depth = 0
        Me.Performance.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Performance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Performance.Location = New System.Drawing.Point(154, 109)
        Me.Performance.MouseState = MaterialSkin.MouseState.HOVER
        Me.Performance.Name = "Performance"
        Me.Performance.Size = New System.Drawing.Size(127, 19)
        Me.Performance.TabIndex = 18
        Me.Performance.Text = "Performance: 0pp"
        '
        'SSLabel
        '
        Me.SSLabel.AutoSize = True
        Me.SSLabel.Depth = 0
        Me.SSLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.SSLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SSLabel.Location = New System.Drawing.Point(96, 239)
        Me.SSLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.SSLabel.Name = "SSLabel"
        Me.SSLabel.Size = New System.Drawing.Size(17, 19)
        Me.SSLabel.TabIndex = 23
        Me.SSLabel.Text = "0"
        Me.SSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SLabel
        '
        Me.SLabel.AutoSize = True
        Me.SLabel.Depth = 0
        Me.SLabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.SLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SLabel.Location = New System.Drawing.Point(168, 239)
        Me.SLabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.SLabel.Name = "SLabel"
        Me.SLabel.Size = New System.Drawing.Size(17, 19)
        Me.SLabel.TabIndex = 24
        Me.SLabel.Text = "0"
        Me.SLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ALabel
        '
        Me.ALabel.AutoSize = True
        Me.ALabel.Depth = 0
        Me.ALabel.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.ALabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ALabel.Location = New System.Drawing.Point(237, 239)
        Me.ALabel.MouseState = MaterialSkin.MouseState.HOVER
        Me.ALabel.Name = "ALabel"
        Me.ALabel.Size = New System.Drawing.Size(17, 19)
        Me.ALabel.TabIndex = 25
        Me.ALabel.Text = "0"
        Me.ALabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 64)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(360, 32)
        Me.MaterialTabSelector1.TabIndex = 28
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage3)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(0, 96)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(360, 319)
        Me.MaterialTabControl1.TabIndex = 29
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Flag)
        Me.TabPage1.Controls.Add(Me.UsernameLabel)
        Me.TabPage1.Controls.Add(Me.MaterialDivider1)
        Me.TabPage1.Controls.Add(Me.AccountImage)
        Me.TabPage1.Controls.Add(Me.SSLabel)
        Me.TabPage1.Controls.Add(Me.ALabel)
        Me.TabPage1.Controls.Add(Me.LevelLabel)
        Me.TabPage1.Controls.Add(Me.SLabel)
        Me.TabPage1.Controls.Add(Me.LevelProgress)
        Me.TabPage1.Controls.Add(Me.RankedScore)
        Me.TabPage1.Controls.Add(Me.A)
        Me.TabPage1.Controls.Add(Me.TotalScore)
        Me.TabPage1.Controls.Add(Me.S)
        Me.TabPage1.Controls.Add(Me.Accuracy)
        Me.TabPage1.Controls.Add(Me.SS)
        Me.TabPage1.Controls.Add(Me.PlayCount)
        Me.TabPage1.Controls.Add(Me.Rank)
        Me.TabPage1.Controls.Add(Me.CountryRank)
        Me.TabPage1.Controls.Add(Me.Performance)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(352, 293)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Profile"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Best)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(352, 293)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Best"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Best
        '
        Me.Best.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.Best.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Best.Depth = 0
        Me.Best.Font = New System.Drawing.Font("Roboto", 24.0!)
        Me.Best.FullRowSelect = True
        Me.Best.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.Best.Location = New System.Drawing.Point(6, 6)
        Me.Best.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Best.MouseState = MaterialSkin.MouseState.OUT
        Me.Best.MultiSelect = False
        Me.Best.Name = "Best"
        Me.Best.OwnerDraw = True
        Me.Best.Scrollable = False
        Me.Best.Size = New System.Drawing.Size(340, 263)
        Me.Best.TabIndex = 31
        Me.Best.UseCompatibleStateImageBehavior = False
        Me.Best.View = System.Windows.Forms.View.Details
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Recent)
        Me.TabPage3.Controls.Add(Me.NoData)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(352, 293)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Recent"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Recent
        '
        Me.Recent.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.Recent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Recent.Depth = 0
        Me.Recent.Font = New System.Drawing.Font("Roboto", 24.0!)
        Me.Recent.FullRowSelect = True
        Me.Recent.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.Recent.Location = New System.Drawing.Point(6, 6)
        Me.Recent.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Recent.MouseState = MaterialSkin.MouseState.OUT
        Me.Recent.MultiSelect = False
        Me.Recent.Name = "Recent"
        Me.Recent.OwnerDraw = True
        Me.Recent.Scrollable = False
        Me.Recent.Size = New System.Drawing.Size(340, 263)
        Me.Recent.TabIndex = 32
        Me.Recent.UseCompatibleStateImageBehavior = False
        Me.Recent.View = System.Windows.Forms.View.Details
        '
        'NoData
        '
        Me.NoData.AutoSize = True
        Me.NoData.Depth = 0
        Me.NoData.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.NoData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NoData.Location = New System.Drawing.Point(136, 132)
        Me.NoData.MouseState = MaterialSkin.MouseState.HOVER
        Me.NoData.Name = "NoData"
        Me.NoData.Size = New System.Drawing.Size(81, 19)
        Me.NoData.TabIndex = 33
        Me.NoData.Text = "No Data :-("
        '
        'RefreshIcon
        '
        Me.RefreshIcon.Image = Global.osu.My.Resources.Resources.refresh
        Me.RefreshIcon.Location = New System.Drawing.Point(289, 34)
        Me.RefreshIcon.Name = "RefreshIcon"
        Me.RefreshIcon.Size = New System.Drawing.Size(24, 24)
        Me.RefreshIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.RefreshIcon.TabIndex = 32
        Me.RefreshIcon.TabStop = False
        '
        'SettingsIcon
        '
        Me.SettingsIcon.Image = Global.osu.My.Resources.Resources.settings
        Me.SettingsIcon.Location = New System.Drawing.Point(324, 34)
        Me.SettingsIcon.Name = "SettingsIcon"
        Me.SettingsIcon.Size = New System.Drawing.Size(24, 24)
        Me.SettingsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.SettingsIcon.TabIndex = 31
        Me.SettingsIcon.TabStop = False
        '
        'Flag
        '
        Me.Flag.Location = New System.Drawing.Point(12, 6)
        Me.Flag.Name = "Flag"
        Me.Flag.Size = New System.Drawing.Size(25, 15)
        Me.Flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Flag.TabIndex = 26
        Me.Flag.TabStop = False
        '
        'AccountImage
        '
        Me.AccountImage.ErrorImage = CType(resources.GetObject("AccountImage.ErrorImage"), System.Drawing.Image)
        Me.AccountImage.Image = Global.osu.My.Resources.Resources.avatar
        Me.AccountImage.ImageLocation = ""
        Me.AccountImage.InitialImage = CType(resources.GetObject("AccountImage.InitialImage"), System.Drawing.Image)
        Me.AccountImage.Location = New System.Drawing.Point(12, 25)
        Me.AccountImage.Name = "AccountImage"
        Me.AccountImage.Size = New System.Drawing.Size(100, 100)
        Me.AccountImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AccountImage.TabIndex = 4
        Me.AccountImage.TabStop = False
        '
        'A
        '
        Me.A.Image = Global.osu.My.Resources.Resources.A
        Me.A.Location = New System.Drawing.Point(220, 186)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(50, 50)
        Me.A.TabIndex = 21
        Me.A.TabStop = False
        '
        'S
        '
        Me.S.Image = Global.osu.My.Resources.Resources.S
        Me.S.Location = New System.Drawing.Point(151, 186)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(50, 50)
        Me.S.TabIndex = 20
        Me.S.TabStop = False
        '
        'SS
        '
        Me.SS.Image = Global.osu.My.Resources.Resources.SS
        Me.SS.Location = New System.Drawing.Point(80, 186)
        Me.SS.Name = "SS"
        Me.SS.Size = New System.Drawing.Size(50, 50)
        Me.SS.TabIndex = 19
        Me.SS.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 451)
        Me.Controls.Add(Me.RefreshIcon)
        Me.Controls.Add(Me.SettingsIcon)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.UsernameBox)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Sizable = False
        Me.Text = "osu!info"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.RefreshIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Flag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.S, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AccountImage As PictureBox
    Friend WithEvents UsernameBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents OK As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents UsernameLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents LevelLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents LevelProgress As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents RankedScore As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TotalScore As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Accuracy As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PlayCount As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Rank As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents CountryRank As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Performance As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SS As PictureBox
    Friend WithEvents S As PictureBox
    Friend WithEvents A As PictureBox
    Friend WithEvents SSLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SLabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ALabel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Best As MaterialSkin.Controls.MaterialListView
    Friend WithEvents SettingsIcon As PictureBox
    Friend WithEvents Flag As PictureBox
    Friend WithEvents RefreshIcon As PictureBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Recent As MaterialSkin.Controls.MaterialListView
    Friend WithEvents NoData As MaterialSkin.Controls.MaterialLabel
End Class
