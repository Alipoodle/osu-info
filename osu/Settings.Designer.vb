<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.APIKeyBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Save = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Cancel = New MaterialSkin.Controls.MaterialFlatButton()
        Me.About = New MaterialSkin.Controls.MaterialLabel()
        Me.APIKey = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.DarkCheckbox = New MaterialSkin.Controls.MaterialCheckBox()
        Me.DarkTheme = New MaterialSkin.Controls.MaterialLabel()
        Me.DefaultUser = New MaterialSkin.Controls.MaterialLabel()
        Me.DefaultUserBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SettingsPanel = New System.Windows.Forms.Panel()
        Me.AboutSelector = New System.Windows.Forms.Panel()
        Me.AboutPanel = New System.Windows.Forms.Panel()
        Me.MaterialDivider3 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.IconThing = New System.Windows.Forms.PictureBox()
        Me.BackIcon = New System.Windows.Forms.PictureBox()
        Me.SettingsPanel.SuspendLayout()
        Me.AboutSelector.SuspendLayout()
        Me.AboutPanel.SuspendLayout()
        CType(Me.IconThing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'APIKeyBox
        '
        Me.APIKeyBox.Depth = 0
        Me.APIKeyBox.Hint = ""
        Me.APIKeyBox.Location = New System.Drawing.Point(109, 3)
        Me.APIKeyBox.MaxLength = 32767
        Me.APIKeyBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.APIKeyBox.Name = "APIKeyBox"
        Me.APIKeyBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.APIKeyBox.SelectedText = ""
        Me.APIKeyBox.SelectionLength = 0
        Me.APIKeyBox.SelectionStart = 0
        Me.APIKeyBox.Size = New System.Drawing.Size(159, 23)
        Me.APIKeyBox.TabIndex = 0
        Me.APIKeyBox.TabStop = False
        Me.APIKeyBox.UseSystemPasswordChar = False
        '
        'Save
        '
        Me.Save.AutoSize = True
        Me.Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Save.Depth = 0
        Me.Save.Location = New System.Drawing.Point(221, 252)
        Me.Save.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Save.MouseState = MaterialSkin.MouseState.HOVER
        Me.Save.Name = "Save"
        Me.Save.Primary = False
        Me.Save.Size = New System.Drawing.Size(46, 36)
        Me.Save.TabIndex = 1
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.AutoSize = True
        Me.Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Cancel.Depth = 0
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(149, 252)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Cancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Primary = False
        Me.Cancel.Size = New System.Drawing.Size(64, 36)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.About.AutoSize = True
        Me.About.Depth = 0
        Me.About.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.About.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.About.Location = New System.Drawing.Point(3, 5)
        Me.About.MouseState = MaterialSkin.MouseState.HOVER
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(49, 19)
        Me.About.TabIndex = 3
        Me.About.Text = "About"
        '
        'APIKey
        '
        Me.APIKey.AutoSize = True
        Me.APIKey.Depth = 0
        Me.APIKey.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.APIKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.APIKey.Location = New System.Drawing.Point(3, 7)
        Me.APIKey.MouseState = MaterialSkin.MouseState.HOVER
        Me.APIKey.Name = "APIKey"
        Me.APIKey.Size = New System.Drawing.Size(60, 19)
        Me.APIKey.TabIndex = 4
        Me.APIKey.Text = "API Key"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(-9, 101)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(382, 1)
        Me.MaterialDivider1.TabIndex = 5
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'DarkCheckbox
        '
        Me.DarkCheckbox.AutoSize = True
        Me.DarkCheckbox.Depth = 0
        Me.DarkCheckbox.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.DarkCheckbox.Location = New System.Drawing.Point(238, 32)
        Me.DarkCheckbox.Margin = New System.Windows.Forms.Padding(0)
        Me.DarkCheckbox.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.DarkCheckbox.MouseState = MaterialSkin.MouseState.HOVER
        Me.DarkCheckbox.Name = "DarkCheckbox"
        Me.DarkCheckbox.Ripple = True
        Me.DarkCheckbox.Size = New System.Drawing.Size(30, 30)
        Me.DarkCheckbox.TabIndex = 6
        Me.DarkCheckbox.Text = " "
        Me.DarkCheckbox.UseVisualStyleBackColor = True
        '
        'DarkTheme
        '
        Me.DarkTheme.AutoSize = True
        Me.DarkTheme.Depth = 0
        Me.DarkTheme.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.DarkTheme.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DarkTheme.Location = New System.Drawing.Point(3, 36)
        Me.DarkTheme.MouseState = MaterialSkin.MouseState.HOVER
        Me.DarkTheme.Name = "DarkTheme"
        Me.DarkTheme.Size = New System.Drawing.Size(90, 19)
        Me.DarkTheme.TabIndex = 7
        Me.DarkTheme.Text = "Dark Theme"
        '
        'DefaultUser
        '
        Me.DefaultUser.AutoSize = True
        Me.DefaultUser.Depth = 0
        Me.DefaultUser.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.DefaultUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DefaultUser.Location = New System.Drawing.Point(3, 66)
        Me.DefaultUser.MouseState = MaterialSkin.MouseState.HOVER
        Me.DefaultUser.Name = "DefaultUser"
        Me.DefaultUser.Size = New System.Drawing.Size(92, 19)
        Me.DefaultUser.TabIndex = 8
        Me.DefaultUser.Text = "Default User"
        '
        'DefaultUserBox
        '
        Me.DefaultUserBox.Depth = 0
        Me.DefaultUserBox.Hint = ""
        Me.DefaultUserBox.Location = New System.Drawing.Point(109, 62)
        Me.DefaultUserBox.MaxLength = 32767
        Me.DefaultUserBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.DefaultUserBox.Name = "DefaultUserBox"
        Me.DefaultUserBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DefaultUserBox.SelectedText = ""
        Me.DefaultUserBox.SelectionLength = 0
        Me.DefaultUserBox.SelectionStart = 0
        Me.DefaultUserBox.Size = New System.Drawing.Size(159, 23)
        Me.DefaultUserBox.TabIndex = 9
        Me.DefaultUserBox.TabStop = False
        Me.DefaultUserBox.UseSystemPasswordChar = False
        '
        'SettingsPanel
        '
        Me.SettingsPanel.Controls.Add(Me.AboutSelector)
        Me.SettingsPanel.Controls.Add(Me.APIKey)
        Me.SettingsPanel.Controls.Add(Me.APIKeyBox)
        Me.SettingsPanel.Controls.Add(Me.Cancel)
        Me.SettingsPanel.Controls.Add(Me.Save)
        Me.SettingsPanel.Controls.Add(Me.MaterialDivider1)
        Me.SettingsPanel.Controls.Add(Me.DefaultUser)
        Me.SettingsPanel.Controls.Add(Me.DefaultUserBox)
        Me.SettingsPanel.Controls.Add(Me.DarkTheme)
        Me.SettingsPanel.Controls.Add(Me.DarkCheckbox)
        Me.SettingsPanel.Location = New System.Drawing.Point(5, 71)
        Me.SettingsPanel.Name = "SettingsPanel"
        Me.SettingsPanel.Size = New System.Drawing.Size(271, 294)
        Me.SettingsPanel.TabIndex = 34
        '
        'AboutSelector
        '
        Me.AboutSelector.Controls.Add(Me.About)
        Me.AboutSelector.Location = New System.Drawing.Point(0, 109)
        Me.AboutSelector.Name = "AboutSelector"
        Me.AboutSelector.Size = New System.Drawing.Size(271, 30)
        Me.AboutSelector.TabIndex = 10
        '
        'AboutPanel
        '
        Me.AboutPanel.Controls.Add(Me.MaterialDivider3)
        Me.AboutPanel.Controls.Add(Me.MaterialDivider2)
        Me.AboutPanel.Controls.Add(Me.MaterialLabel6)
        Me.AboutPanel.Controls.Add(Me.MaterialLabel3)
        Me.AboutPanel.Controls.Add(Me.MaterialLabel4)
        Me.AboutPanel.Controls.Add(Me.MaterialLabel5)
        Me.AboutPanel.Controls.Add(Me.MaterialFlatButton1)
        Me.AboutPanel.Controls.Add(Me.MaterialLabel2)
        Me.AboutPanel.Controls.Add(Me.MaterialLabel1)
        Me.AboutPanel.Controls.Add(Me.IconThing)
        Me.AboutPanel.Location = New System.Drawing.Point(5, 71)
        Me.AboutPanel.Name = "AboutPanel"
        Me.AboutPanel.Size = New System.Drawing.Size(271, 215)
        Me.AboutPanel.TabIndex = 35
        '
        'MaterialDivider3
        '
        Me.MaterialDivider3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider3.Depth = 0
        Me.MaterialDivider3.Location = New System.Drawing.Point(-14, 156)
        Me.MaterialDivider3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider3.Name = "MaterialDivider3"
        Me.MaterialDivider3.Size = New System.Drawing.Size(299, 1)
        Me.MaterialDivider3.TabIndex = 9
        Me.MaterialDivider3.Text = "MaterialDivider3"
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(-16, 88)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(299, 1)
        Me.MaterialDivider2.TabIndex = 8
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(82, 59)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(194, 19)
        Me.MaterialLabel6.TabIndex = 7
        Me.MaterialLabel6.Text = "GreenTurtwig and Alipoodle"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(2, 96)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(269, 19)
        Me.MaterialLabel3.TabIndex = 4
        Me.MaterialLabel3.Text = "Windows program to get available osu!"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(2, 113)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(257, 19)
        Me.MaterialLabel4.TabIndex = 5
        Me.MaterialLabel4.Text = "information using some elements of "
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(2, 130)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(118, 19)
        Me.MaterialLabel5.TabIndex = 6
        Me.MaterialLabel5.Text = "Material Design."
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(103, 166)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(61, 36)
        Me.MaterialFlatButton1.TabIndex = 3
        Me.MaterialFlatButton1.Text = "GitHub"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(82, 22)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(48, 19)
        Me.MaterialLabel2.TabIndex = 2
        Me.MaterialLabel2.Text = "v1.2.0"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(82, 3)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(64, 19)
        Me.MaterialLabel1.TabIndex = 1
        Me.MaterialLabel1.Text = "osu!info"
        '
        'IconThing
        '
        Me.IconThing.Image = Global.osu.My.Resources.Resources.Icon
        Me.IconThing.Location = New System.Drawing.Point(3, 3)
        Me.IconThing.Name = "IconThing"
        Me.IconThing.Size = New System.Drawing.Size(75, 75)
        Me.IconThing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconThing.TabIndex = 0
        Me.IconThing.TabStop = False
        '
        'BackIcon
        '
        Me.BackIcon.Image = Global.osu.My.Resources.Resources.back
        Me.BackIcon.Location = New System.Drawing.Point(12, 31)
        Me.BackIcon.Name = "BackIcon"
        Me.BackIcon.Size = New System.Drawing.Size(24, 24)
        Me.BackIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BackIcon.TabIndex = 33
        Me.BackIcon.TabStop = False
        '
        'Settings
        '
        Me.AcceptButton = Me.Save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(281, 368)
        Me.Controls.Add(Me.SettingsPanel)
        Me.Controls.Add(Me.AboutPanel)
        Me.Controls.Add(Me.BackIcon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.Text = "Settings"
        Me.TopMost = True
        Me.SettingsPanel.ResumeLayout(False)
        Me.SettingsPanel.PerformLayout()
        Me.AboutSelector.ResumeLayout(False)
        Me.AboutSelector.PerformLayout()
        Me.AboutPanel.ResumeLayout(False)
        Me.AboutPanel.PerformLayout()
        CType(Me.IconThing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents APIKeyBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Save As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Cancel As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents About As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents APIKey As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents DarkCheckbox As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents DarkTheme As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DefaultUser As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DefaultUserBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents BackIcon As PictureBox
    Friend WithEvents SettingsPanel As Panel
    Friend WithEvents AboutPanel As Panel
    Friend WithEvents IconThing As PictureBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialDivider3 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents AboutSelector As Panel
End Class
