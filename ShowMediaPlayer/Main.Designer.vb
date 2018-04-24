<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    'Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.RightTable = New System.Windows.Forms.TableLayoutPanel()
        Me.TreeViewOptions = New System.Windows.Forms.ToolStrip()
        Me.AddFolderButton = New System.Windows.Forms.ToolStripButton()
        Me.AddMediaButton = New System.Windows.Forms.ToolStripButton()
        Me.AddPauseButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddToPlay = New System.Windows.Forms.ToolStripButton()
        Me.Remove = New System.Windows.Forms.ToolStripButton()
        Me.MediaTreeView = New System.Windows.Forms.TreeView()
        Me.ContextNode = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenMusic = New System.Windows.Forms.OpenFileDialog()
        Me.LeftRightSplit = New System.Windows.Forms.SplitContainer()
        Me.LeftTable = New System.Windows.Forms.TableLayoutPanel()
        Me.PlayButton = New MetroFramework.Controls.MetroButton()
        Me.OptionsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ClearButton = New MetroFramework.Controls.MetroButton()
        Me.ShowOutputCheck = New MetroFramework.Controls.MetroCheckBox()
        Me.OutputChoice = New System.Windows.Forms.ComboBox()
        Me.AboutButton = New MetroFramework.Controls.MetroButton()
        Me.MediaNameLabel = New MetroFramework.Controls.MetroLabel()
        Me.SeekTrackBar = New MetroFramework.Controls.MetroTrackBar()
        Me.MediaList = New System.Windows.Forms.ListBox()
        Me.TimeLabel = New MetroFramework.Controls.MetroLabel()
        Me.msmMain = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.GeneralTable = New System.Windows.Forms.TableLayoutPanel()
        Me.TopPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SaveButton = New MetroFramework.Controls.MetroButton()
        Me.LoadButton = New MetroFramework.Controls.MetroButton()
        Me.OpenSave = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.AutoPlayCheck = New MetroFramework.Controls.MetroCheckBox()
        Me.RightTable.SuspendLayout()
        Me.TreeViewOptions.SuspendLayout()
        Me.ContextNode.SuspendLayout()
        CType(Me.LeftRightSplit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LeftRightSplit.Panel1.SuspendLayout()
        Me.LeftRightSplit.Panel2.SuspendLayout()
        Me.LeftRightSplit.SuspendLayout()
        Me.LeftTable.SuspendLayout()
        Me.OptionsPanel.SuspendLayout()
        CType(Me.msmMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GeneralTable.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RightTable
        '
        Me.RightTable.ColumnCount = 1
        Me.RightTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RightTable.Controls.Add(Me.TreeViewOptions, 0, 0)
        Me.RightTable.Controls.Add(Me.MediaTreeView, 0, 1)
        Me.RightTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RightTable.Location = New System.Drawing.Point(0, 0)
        Me.RightTable.Name = "RightTable"
        Me.RightTable.RowCount = 2
        Me.RightTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.RightTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RightTable.Size = New System.Drawing.Size(369, 456)
        Me.RightTable.TabIndex = 0
        '
        'TreeViewOptions
        '
        Me.TreeViewOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.TreeViewOptions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.TreeViewOptions.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TreeViewOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TreeViewOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddFolderButton, Me.AddMediaButton, Me.AddPauseButton, Me.ToolStripSeparator1, Me.AddToPlay, Me.Remove})
        Me.TreeViewOptions.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewOptions.Name = "TreeViewOptions"
        Me.TreeViewOptions.Size = New System.Drawing.Size(369, 25)
        Me.TreeViewOptions.TabIndex = 3
        Me.TreeViewOptions.Text = "ToolStrip1"
        '
        'AddFolderButton
        '
        Me.AddFolderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddFolderButton.Image = CType(resources.GetObject("AddFolderButton.Image"), System.Drawing.Image)
        Me.AddFolderButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddFolderButton.Name = "AddFolderButton"
        Me.AddFolderButton.Size = New System.Drawing.Size(69, 22)
        Me.AddFolderButton.Text = "Add Folder"
        '
        'AddMediaButton
        '
        Me.AddMediaButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddMediaButton.Image = CType(resources.GetObject("AddMediaButton.Image"), System.Drawing.Image)
        Me.AddMediaButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddMediaButton.Name = "AddMediaButton"
        Me.AddMediaButton.Size = New System.Drawing.Size(69, 22)
        Me.AddMediaButton.Text = "Add Media"
        '
        'AddPauseButton
        '
        Me.AddPauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddPauseButton.Image = CType(resources.GetObject("AddPauseButton.Image"), System.Drawing.Image)
        Me.AddPauseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddPauseButton.Name = "AddPauseButton"
        Me.AddPauseButton.Size = New System.Drawing.Size(67, 22)
        Me.AddPauseButton.Text = "Add pause"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'AddToPlay
        '
        Me.AddToPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddToPlay.Image = CType(resources.GetObject("AddToPlay.Image"), System.Drawing.Image)
        Me.AddToPlay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddToPlay.Name = "AddToPlay"
        Me.AddToPlay.Size = New System.Drawing.Size(87, 22)
        Me.AddToPlay.Text = "Add to playlist"
        '
        'Remove
        '
        Me.Remove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Remove.Image = CType(resources.GetObject("Remove.Image"), System.Drawing.Image)
        Me.Remove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Remove.Name = "Remove"
        Me.Remove.Size = New System.Drawing.Size(54, 22)
        Me.Remove.Text = "Remove"
        '
        'MediaTreeView
        '
        Me.MediaTreeView.AllowDrop = True
        Me.MetroStyleExtender1.SetApplyMetroTheme(Me.MediaTreeView, True)
        Me.MediaTreeView.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.MediaTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MediaTreeView.CheckBoxes = True
        Me.MediaTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MediaTreeView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MediaTreeView.FullRowSelect = True
        Me.MediaTreeView.ItemHeight = 30
        Me.MediaTreeView.LabelEdit = True
        Me.MediaTreeView.LineColor = System.Drawing.Color.White
        Me.MediaTreeView.Location = New System.Drawing.Point(3, 33)
        Me.MediaTreeView.Name = "MediaTreeView"
        Me.MediaTreeView.Size = New System.Drawing.Size(363, 420)
        Me.MediaTreeView.TabIndex = 4
        '
        'ContextNode
        '
        Me.ContextNode.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.RenameToolStripMenuItem})
        Me.ContextNode.Name = "ContextNode"
        Me.ContextNode.Size = New System.Drawing.Size(118, 48)
        Me.ContextNode.Text = "Node"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'OpenMusic
        '
        Me.OpenMusic.Multiselect = True
        '
        'LeftRightSplit
        '
        Me.LeftRightSplit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeftRightSplit.Location = New System.Drawing.Point(3, 43)
        Me.LeftRightSplit.Name = "LeftRightSplit"
        '
        'LeftRightSplit.Panel1
        '
        Me.LeftRightSplit.Panel1.Controls.Add(Me.LeftTable)
        '
        'LeftRightSplit.Panel2
        '
        Me.LeftRightSplit.Panel2.Controls.Add(Me.RightTable)
        Me.LeftRightSplit.Size = New System.Drawing.Size(1123, 456)
        Me.LeftRightSplit.SplitterDistance = 750
        Me.LeftRightSplit.TabIndex = 0
        '
        'LeftTable
        '
        Me.LeftTable.ColumnCount = 3
        Me.LeftTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.LeftTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LeftTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197.0!))
        Me.LeftTable.Controls.Add(Me.PlayButton, 0, 1)
        Me.LeftTable.Controls.Add(Me.OptionsPanel, 0, 3)
        Me.LeftTable.Controls.Add(Me.MediaNameLabel, 0, 0)
        Me.LeftTable.Controls.Add(Me.SeekTrackBar, 1, 1)
        Me.LeftTable.Controls.Add(Me.MediaList, 0, 2)
        Me.LeftTable.Controls.Add(Me.TimeLabel, 2, 1)
        Me.LeftTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeftTable.Location = New System.Drawing.Point(0, 0)
        Me.LeftTable.Name = "LeftTable"
        Me.LeftTable.RowCount = 4
        Me.LeftTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.LeftTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.LeftTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LeftTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.LeftTable.Size = New System.Drawing.Size(750, 456)
        Me.LeftTable.TabIndex = 1
        '
        'PlayButton
        '
        Me.PlayButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlayButton.Location = New System.Drawing.Point(3, 63)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(55, 44)
        Me.PlayButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PlayButton.TabIndex = 0
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseSelectable = True
        '
        'OptionsPanel
        '
        Me.LeftTable.SetColumnSpan(Me.OptionsPanel, 3)
        Me.OptionsPanel.Controls.Add(Me.ClearButton)
        Me.OptionsPanel.Controls.Add(Me.AutoPlayCheck)
        Me.OptionsPanel.Controls.Add(Me.ShowOutputCheck)
        Me.OptionsPanel.Controls.Add(Me.OutputChoice)
        Me.OptionsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OptionsPanel.Location = New System.Drawing.Point(0, 429)
        Me.OptionsPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.OptionsPanel.Name = "OptionsPanel"
        Me.OptionsPanel.Size = New System.Drawing.Size(750, 27)
        Me.OptionsPanel.TabIndex = 5
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(3, 3)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 21)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear playlist"
        Me.ClearButton.UseSelectable = True
        '
        'ShowOutputCheck
        '
        Me.ShowOutputCheck.AutoSize = True
        Me.ShowOutputCheck.Dock = System.Windows.Forms.DockStyle.Left
        Me.ShowOutputCheck.Location = New System.Drawing.Point(161, 3)
        Me.ShowOutputCheck.Name = "ShowOutputCheck"
        Me.ShowOutputCheck.Size = New System.Drawing.Size(91, 21)
        Me.ShowOutputCheck.TabIndex = 1
        Me.ShowOutputCheck.Text = "Show output"
        Me.ShowOutputCheck.UseSelectable = True
        '
        'OutputChoice
        '
        Me.MetroStyleExtender1.SetApplyMetroTheme(Me.OutputChoice, True)
        Me.OutputChoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.OutputChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OutputChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OutputChoice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.OutputChoice.FormattingEnabled = True
        Me.OutputChoice.Location = New System.Drawing.Point(258, 3)
        Me.OutputChoice.Name = "OutputChoice"
        Me.OutputChoice.Size = New System.Drawing.Size(121, 21)
        Me.OutputChoice.TabIndex = 2
        '
        'AboutButton
        '
        Me.AboutButton.Location = New System.Drawing.Point(165, 3)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(75, 23)
        Me.AboutButton.TabIndex = 5
        Me.AboutButton.Text = "About"
        Me.AboutButton.UseSelectable = True
        '
        'MediaNameLabel
        '
        Me.MediaNameLabel.AutoSize = True
        Me.LeftTable.SetColumnSpan(Me.MediaNameLabel, 3)
        Me.MediaNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MediaNameLabel.Location = New System.Drawing.Point(20, 0)
        Me.MediaNameLabel.Margin = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.MediaNameLabel.Name = "MediaNameLabel"
        Me.MediaNameLabel.Size = New System.Drawing.Size(87, 25)
        Me.MediaNameLabel.Style = MetroFramework.MetroColorStyle.Blue
        Me.MediaNameLabel.TabIndex = 6
        Me.MediaNameLabel.Text = "No media"
        Me.MediaNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SeekTrackBar
        '
        Me.SeekTrackBar.BackColor = System.Drawing.Color.Transparent
        Me.SeekTrackBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SeekTrackBar.Location = New System.Drawing.Point(64, 63)
        Me.SeekTrackBar.Name = "SeekTrackBar"
        Me.SeekTrackBar.Size = New System.Drawing.Size(486, 44)
        Me.SeekTrackBar.Style = MetroFramework.MetroColorStyle.Blue
        Me.SeekTrackBar.TabIndex = 7
        Me.SeekTrackBar.Text = "Progress"
        Me.SeekTrackBar.Value = 0
        '
        'MediaList
        '
        Me.MediaList.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.MediaList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LeftTable.SetColumnSpan(Me.MediaList, 3)
        Me.MediaList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MediaList.ForeColor = System.Drawing.Color.White
        Me.MediaList.FormattingEnabled = True
        Me.MediaList.Location = New System.Drawing.Point(3, 113)
        Me.MediaList.Name = "MediaList"
        Me.MediaList.Size = New System.Drawing.Size(744, 313)
        Me.MediaList.TabIndex = 8
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.TimeLabel.ForeColor = System.Drawing.Color.White
        Me.TimeLabel.Location = New System.Drawing.Point(556, 60)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(191, 50)
        Me.TimeLabel.TabIndex = 9
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'msmMain
        '
        Me.msmMain.Owner = Nothing
        Me.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'MetroStyleExtender1
        '
        Me.MetroStyleExtender1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'GeneralTable
        '
        Me.GeneralTable.ColumnCount = 1
        Me.GeneralTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GeneralTable.Controls.Add(Me.LeftRightSplit, 0, 1)
        Me.GeneralTable.Controls.Add(Me.TopPanel, 0, 0)
        Me.GeneralTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GeneralTable.Location = New System.Drawing.Point(20, 60)
        Me.GeneralTable.Name = "GeneralTable"
        Me.GeneralTable.RowCount = 2
        Me.GeneralTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.GeneralTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.GeneralTable.Size = New System.Drawing.Size(1129, 502)
        Me.GeneralTable.TabIndex = 1
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.SaveButton)
        Me.TopPanel.Controls.Add(Me.LoadButton)
        Me.TopPanel.Controls.Add(Me.AboutButton)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopPanel.Location = New System.Drawing.Point(3, 3)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1123, 34)
        Me.TopPanel.TabIndex = 1
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(3, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 0
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseSelectable = True
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(84, 3)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(75, 23)
        Me.LoadButton.TabIndex = 1
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseSelectable = True
        '
        'OpenSave
        '
        Me.OpenSave.Title = "Open show"
        '
        'SaveFile
        '
        Me.SaveFile.Title = "Save playlist"
        '
        'AutoPlayCheck
        '
        Me.AutoPlayCheck.AutoSize = True
        Me.AutoPlayCheck.Checked = True
        Me.AutoPlayCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoPlayCheck.Dock = System.Windows.Forms.DockStyle.Left
        Me.AutoPlayCheck.Enabled = False
        Me.AutoPlayCheck.Location = New System.Drawing.Point(84, 3)
        Me.AutoPlayCheck.Name = "AutoPlayCheck"
        Me.AutoPlayCheck.Size = New System.Drawing.Size(71, 21)
        Me.AutoPlayCheck.TabIndex = 6
        Me.AutoPlayCheck.Text = "Autoplay"
        Me.AutoPlayCheck.UseSelectable = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 582)
        Me.Controls.Add(Me.GeneralTable)
        Me.Name = "Main"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Text = "Show Media Player"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.RightTable.ResumeLayout(False)
        Me.RightTable.PerformLayout()
        Me.TreeViewOptions.ResumeLayout(False)
        Me.TreeViewOptions.PerformLayout()
        Me.ContextNode.ResumeLayout(False)
        Me.LeftRightSplit.Panel1.ResumeLayout(False)
        Me.LeftRightSplit.Panel2.ResumeLayout(False)
        CType(Me.LeftRightSplit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LeftRightSplit.ResumeLayout(False)
        Me.LeftTable.ResumeLayout(False)
        Me.LeftTable.PerformLayout()
        Me.OptionsPanel.ResumeLayout(False)
        Me.OptionsPanel.PerformLayout()
        CType(Me.msmMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GeneralTable.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RightTable As TableLayoutPanel
    Friend WithEvents TreeViewOptions As ToolStrip
    Friend WithEvents AddFolderButton As ToolStripButton
    Friend WithEvents AddMediaButton As ToolStripButton
    Friend WithEvents ContextNode As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenMusic As OpenFileDialog
    Friend WithEvents MediaTreeView As TreeView
    Friend WithEvents LeftRightSplit As SplitContainer
    Friend WithEvents OptionsPanel As FlowLayoutPanel
    Friend WithEvents OutputChoice As ComboBox
    Friend WithEvents MediaNameLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents PlayButton As MetroFramework.Controls.MetroButton
    Friend WithEvents ShowOutputCheck As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents msmMain As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents LeftTable As TableLayoutPanel
    Friend WithEvents SeekTrackBar As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents GeneralTable As TableLayoutPanel
    Friend WithEvents TopPanel As FlowLayoutPanel
    Friend WithEvents SaveButton As MetroFramework.Controls.MetroButton
    Friend WithEvents OpenSave As OpenFileDialog
    Friend WithEvents SaveFile As SaveFileDialog
    Friend WithEvents LoadButton As MetroFramework.Controls.MetroButton
    Friend WithEvents MediaList As ListBox
    Friend WithEvents TimeLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents ClearButton As MetroFramework.Controls.MetroButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AddToPlay As ToolStripButton
    Friend WithEvents AutoNextCheck As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Remove As ToolStripButton
    Friend WithEvents AddPauseButton As ToolStripButton
    Friend WithEvents AboutButton As MetroFramework.Controls.MetroButton
    Friend WithEvents AutoPlayCheck As MetroFramework.Controls.MetroCheckBox
End Class
