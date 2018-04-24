<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits MetroFramework.Forms.MetroForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelVersion As MetroFramework.Controls.MetroLabel
    Friend WithEvents LabelCompanyName As MetroFramework.Controls.MetroLabel
    Friend WithEvents TextBoxDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents OKButton As MetroFramework.Controls.MetroButton
    Friend WithEvents LabelCopyright As MetroFramework.Controls.MetroLabel

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelVersion = New MetroFramework.Controls.MetroLabel()
        Me.LabelCopyright = New MetroFramework.Controls.MetroLabel()
        Me.LabelCompanyName = New MetroFramework.Controls.MetroLabel()
        Me.TextBoxDescription = New MetroFramework.Controls.MetroTextBox()
        Me.OKButton = New MetroFramework.Controls.MetroButton()
        Me.TableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 1
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.Controls.Add(Me.LabelVersion, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelCopyright, 0, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelCompanyName, 0, 2)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxDescription, 0, 3)
        Me.TableLayoutPanel.Controls.Add(Me.OKButton, 0, 4)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(9, 60)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 5
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(612, 244)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'LabelVersion
        '
        Me.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.LabelVersion.Location = New System.Drawing.Point(6, 0)
        Me.LabelVersion.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelVersion.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(603, 17)
        Me.LabelVersion.Style = MetroFramework.MetroColorStyle.Blue
        Me.LabelVersion.TabIndex = 0
        Me.LabelVersion.Text = "Version"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelVersion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LabelVersion.UseCustomForeColor = True
        '
        'LabelCopyright
        '
        Me.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCopyright.Location = New System.Drawing.Point(6, 24)
        Me.LabelCopyright.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelCopyright.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Size = New System.Drawing.Size(603, 17)
        Me.LabelCopyright.TabIndex = 0
        Me.LabelCopyright.Text = "Open Source software"
        Me.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelCopyright.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LabelCompanyName
        '
        Me.LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCompanyName.Location = New System.Drawing.Point(6, 48)
        Me.LabelCompanyName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelCompanyName.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelCompanyName.Name = "LabelCompanyName"
        Me.LabelCompanyName.Size = New System.Drawing.Size(603, 17)
        Me.LabelCompanyName.TabIndex = 0
        Me.LabelCompanyName.Text = "Emerick Herve"
        Me.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelCompanyName.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'TextBoxDescription
        '
        '
        '
        '
        Me.TextBoxDescription.CustomButton.Image = Nothing
        Me.TextBoxDescription.CustomButton.Location = New System.Drawing.Point(489, 2)
        Me.TextBoxDescription.CustomButton.Name = ""
        Me.TextBoxDescription.CustomButton.Size = New System.Drawing.Size(111, 111)
        Me.TextBoxDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.TextBoxDescription.CustomButton.TabIndex = 1
        Me.TextBoxDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.TextBoxDescription.CustomButton.UseSelectable = True
        Me.TextBoxDescription.CustomButton.Visible = False
        Me.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDescription.Lines = New String() {"Used projects:", " - VLC media player ActiveX plugin", " - MetroFramework"}
        Me.TextBoxDescription.Location = New System.Drawing.Point(6, 75)
        Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.TextBoxDescription.MaxLength = 32767
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBoxDescription.ReadOnly = True
        Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxDescription.SelectedText = ""
        Me.TextBoxDescription.SelectionLength = 0
        Me.TextBoxDescription.SelectionStart = 0
        Me.TextBoxDescription.ShortcutsEnabled = True
        Me.TextBoxDescription.Size = New System.Drawing.Size(603, 116)
        Me.TextBoxDescription.TabIndex = 0
        Me.TextBoxDescription.TabStop = False
        Me.TextBoxDescription.Text = "Used projects:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - VLC media player ActiveX plugin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - MetroFramework"
        Me.TextBoxDescription.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TextBoxDescription.UseSelectable = True
        Me.TextBoxDescription.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.TextBoxDescription.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(534, 216)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 25)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "&OK"
        Me.OKButton.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.OKButton.UseSelectable = True
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(630, 313)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Name = "About"
        Me.Padding = New System.Windows.Forms.Padding(9, 60, 9, 9)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About Show Media Player"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

End Class
