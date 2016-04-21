<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class APIKey
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
        Me.OK = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'APIKeyBox
        '
        Me.APIKeyBox.Depth = 0
        Me.APIKeyBox.Hint = ""
        Me.APIKeyBox.Location = New System.Drawing.Point(12, 71)
        Me.APIKeyBox.MaxLength = 32767
        Me.APIKeyBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.APIKeyBox.Name = "APIKeyBox"
        Me.APIKeyBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.APIKeyBox.SelectedText = ""
        Me.APIKeyBox.SelectionLength = 0
        Me.APIKeyBox.SelectionStart = 0
        Me.APIKeyBox.Size = New System.Drawing.Size(261, 23)
        Me.APIKeyBox.TabIndex = 0
        Me.APIKeyBox.TabStop = False
        Me.APIKeyBox.UseSystemPasswordChar = False
        '
        'OK
        '
        Me.OK.Depth = 0
        Me.OK.Location = New System.Drawing.Point(279, 71)
        Me.OK.MouseState = MaterialSkin.MouseState.HOVER
        Me.OK.Name = "OK"
        Me.OK.Primary = True
        Me.OK.Size = New System.Drawing.Size(49, 23)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'APIKey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 106)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.APIKeyBox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "APIKey"
        Me.ShowIcon = False
        Me.Sizable = False
        Me.Text = "API Key"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents APIKeyBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents OK As MaterialSkin.Controls.MaterialRaisedButton
End Class
