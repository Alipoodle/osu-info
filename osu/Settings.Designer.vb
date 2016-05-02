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
        Me.SuspendLayout()
        '
        'APIKeyBox
        '
        Me.APIKeyBox.Depth = 0
        Me.APIKeyBox.Hint = ""
        Me.APIKeyBox.Location = New System.Drawing.Point(110, 73)
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
        Me.Save.Location = New System.Drawing.Point(222, 317)
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
        Me.Cancel.Location = New System.Drawing.Point(150, 317)
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
        Me.About.Location = New System.Drawing.Point(12, 291)
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
        Me.APIKey.Location = New System.Drawing.Point(12, 73)
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
        Me.MaterialDivider1.Location = New System.Drawing.Point(-3, 281)
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
        Me.DarkCheckbox.Location = New System.Drawing.Point(242, 104)
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
        Me.DarkTheme.Location = New System.Drawing.Point(12, 108)
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
        Me.DefaultUser.Location = New System.Drawing.Point(12, 144)
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
        Me.DefaultUserBox.Location = New System.Drawing.Point(110, 144)
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
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 368)
        Me.Controls.Add(Me.DefaultUserBox)
        Me.Controls.Add(Me.DefaultUser)
        Me.Controls.Add(Me.DarkTheme)
        Me.Controls.Add(Me.DarkCheckbox)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.APIKey)
        Me.Controls.Add(Me.About)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.APIKeyBox)
        Me.Name = "Settings"
        Me.Text = "Settings"
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
End Class
