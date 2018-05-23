Imports System.ComponentModel
Imports System.IO
Imports MetroFramework
Imports ShowMediaPlayer.MetroAdditions
Imports ShowMediaPlayer.ShowMedia
Imports Vlc.DotNet.Core

Public Class Main

    Friend WithEvents playmanager As PlaylistManager
    Friend WithEvents nodemanager As TreenodeManager

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StyleManager = msmMain
        SetMetroStyle(Me)

        TreeViewOptions.Renderer = New MetroStripRenderer

        Dim test As New Controls.MetroLabel

        playmanager = New PlaylistManager(MediaTreeView, MediaList, MediaNameLabel, Output.VLC, Me)
        nodemanager = New TreenodeManager(MediaTreeView)
        AddHandler nodemanager.OnChanges, AddressOf changes

        OutputChoice.Items.Add("Windowed")
        For Each sc In Screen.AllScreens
            OutputChoice.Items.Add(sc.DeviceName.Replace("\\.\DISPLAY", "Display n°"))
        Next
        OutputChoice.SelectedIndex = OutputChoice.Items.Count - 1

        Output.Show()
        Output.Visible = False
    End Sub

#Region "VLC managers events"

    Function timetostring(time As TimeSpan) As String
        Return time.Hours.ToString("D2") & ":" & time.Minutes.ToString("D2") & ":" & time.Seconds.ToString("D2")
    End Function

    Friend WithEvents nextbw As New BackgroundWorker()

    Private Sub TimeChanged(sender As Object, e As TimeChangedEventArgs) Handles playmanager.TimeChanged
        SeekTrackBar.Maximum = e.lenght.TotalMilliseconds
        SeekTrackBar.Value = Math.Min(e.actual.TotalMilliseconds, e.lenght.TotalMilliseconds)
        TimeLabel.Text = timetostring(e.actual) & "/" & timetostring(e.lenght)

        If e.actual.TotalSeconds >= e.lenght.TotalSeconds - 1 And Not nextbw.IsBusy Then
            nextbw.RunWorkerAsync()
        End If
    End Sub

    Private Sub nextbw_DoWork(sender As Object, e As DoWorkEventArgs) Handles nextbw.DoWork
        Threading.Thread.Sleep(2000)
    End Sub

    Private Sub nextbw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles nextbw.RunWorkerCompleted
        MediaList.SelectedIndex += 1
    End Sub

    Private Sub PauseChanged(sender As Object, e As Boolean) Handles playmanager.PauseChanged
        If e Then
            PlayButton.Text = "Pause"
        Else
            PlayButton.Text = "Play"
        End If
    End Sub

#End Region

#Region "Drag/Drop Treeview"
    Private Sub MediaTreeView_ItemDrag(sender As Object, e As ItemDragEventArgs) Handles MediaTreeView.ItemDrag
        DoDragDrop(e.Item, DragDropEffects.Move)
    End Sub

    Private Sub MediaTreeView_DragEnter(sender As Object, e As DragEventArgs) Handles MediaTreeView.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub MediaTreeView_DragDrop(sender As Object, e As DragEventArgs) Handles MediaTreeView.DragDrop
        Dim targetPoint As Point = MediaTreeView.PointToClient(New Point(e.X, e.Y))
        Dim targetNode As TreeNode = MediaTreeView.GetNodeAt(targetPoint)

        Dim draggedNode As TreeNode = DirectCast(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)
        If (Not draggedNode.Equals(targetNode)) Then
            draggedNode.Remove()
            If IsNothing(targetNode) Then
                MediaTreeView.Nodes.Add(draggedNode)
            Else
                If targetNode.GetMedia.Type = MediaType.folder Then
                    targetNode.Nodes.Add(draggedNode)
                    targetNode.Expand()
                Else
                    If IsNothing(targetNode.Parent) Then
                        MediaTreeView.Nodes.Insert(targetNode.Index, draggedNode)
                    Else
                        targetNode.Parent.Nodes.Insert(targetNode.Index, draggedNode)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub MediaTreeView_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MediaTreeView.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim node_here As TreeNode = MediaTreeView.GetNodeAt(e.X,
                e.Y)
            MediaTreeView.SelectedNode = node_here

            If Not IsNothing(MediaTreeView) Then
                ContextNode.Show(MediaTreeView, New Point(e.X, e.Y))
            End If
        End If
    End Sub

#End Region

#Region "Buttons"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        If Output.VLC.VlcMediaPlayer.State = 3 Then
            Output.VLC.Pause()
        Else
            Output.VLC.Play()
        End If
    End Sub

    Private Sub AddFolder_Click(sender As Object, e As EventArgs) Handles AddFolderButton.Click
        MediaTreeView.AddMediaNode("New Folder", MediaType.folder)
        changes()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        MediaTreeView.Nodes.Remove(MediaTreeView.SelectedNode)
        changes()
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        MediaTreeView.SelectedNode.BeginEdit()
        changes()
    End Sub

    Private Sub AddMedia_Click(sender As Object, e As EventArgs) Handles AddMediaButton.Click
        If OpenMusic.ShowDialog() = DialogResult.OK Then
            For Each music In OpenMusic.FileNames
                MediaTreeView.AddMediaNode(Path.GetFileNameWithoutExtension(music), MediaType.media, music)
            Next
            changes()
        End If
    End Sub

    Private Sub MetroTrackBar1_Click(sender As Object, e As EventArgs) Handles SeekTrackBar.Click
        Output.VLC.Time = SeekTrackBar.Value
        'manager.playlist.seeking = SeekTrackBar.Value
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles Remove.Click
        nodemanager.Remove()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        playmanager.Clear()
        MediaNameLabel.Text = "No media"
    End Sub

    Private Sub AddPauseButton_Click(sender As Object, e As EventArgs) Handles AddPauseButton.Click
        'MediaTreeView.AddMusicNode("Pause", MusicType.pause, Application.StartupPath & "/silence.mp3"
        MediaTreeView.AddMediaNode("Pause", MediaType.pause, "vlc://pause:9999")
        changes()
    End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        About.ShowDialog()
    End Sub

    Private Sub MediaList_Click(sender As Object, e As EventArgs) Handles MediaList.SelectedIndexChanged
        playmanager.Play(MediaList.SelectedIndex)
    End Sub

    Private Sub AddToPlay_Click(sender As Object, e As EventArgs) Handles AddToPlay.Click
        playmanager.AddNodes()
    End Sub

    Private Sub TreeNode_DoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles MediaTreeView.NodeMouseDoubleClick
        playmanager.Clear()
        playmanager.AddNodes(e.Node)
        MediaNameLabel.Text = e.Node.Text
    End Sub

    Private Sub MidiChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MidiButton.Click
        playmanager.ConnectMidi()
    End Sub
#End Region

#Region "Checkboxes"
    Private Sub ShowOutput_CheckedChanged(sender As Object, e As EventArgs) Handles ShowOutputCheck.CheckedChanged
        Output.Visible = ShowOutputCheck.Checked
    End Sub

    Private Sub MediaTreeView_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles MediaTreeView.AfterCheck
        If e.Node.GetMedia.Type = MediaType.folder Then
            If e.Node.Checked Then
                nodemanager.checkNodes(True, e.Node)
            Else
                nodemanager.checkNodes(False, e.Node)
            End If
        End If
    End Sub
#End Region

#Region "Load/Save"
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        save()
    End Sub

    Sub save()
        Dim result = SaveFile.ShowDialog()
        If result = DialogResult.OK Then
            nodemanager.Save(SaveFile.FileName)
            unchanges()
        End If
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        If changed AndAlso MetroMessageBox.Show(Me, "Do you want to save actual work before?", "Open project", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            save()
        End If
        Dim result = OpenSave.ShowDialog()
        If result = DialogResult.OK Then
            MediaTreeView.Nodes.Clear()
            nodemanager.Load(OpenSave.FileName)
            unchanges()
        End If
    End Sub

    Dim changed As Boolean = False

    Public Sub changes()
        changed = True
        msmMain.Style = MetroColorStyle.Orange
        Me.Refresh()
    End Sub

    Public Sub unchanges()
        msmMain.Style = MetroColorStyle.Blue
        changed = False
        Me.Refresh()
    End Sub

#End Region

End Class
