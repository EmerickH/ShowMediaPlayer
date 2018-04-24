Imports System.Runtime.CompilerServices
Imports AxAXVLC

Namespace ShowMedia

    Public Module ControlsExtensions

        <Extension>
        Public Function GetMedia(source As TreeNode) As TreeNodeMedia
            Return source.Tag
        End Function

        <Extension>
        Public Sub SetMedia(source As TreeNode, value As TreeNodeMedia)
            source.Tag = value
        End Sub

        <Extension>
        Public Sub AddMediaNode(source As TreeView, name As String, type As MediaType, Optional url As String = "")
            source.Nodes.Add(name).SetMedia(New TreeNodeMedia(url, type))
        End Sub

        <Extension()>
        Public Sub Add(Of T)(ByRef arr As T(), item As T)
            Array.Resize(arr, arr.Length + 1)
            arr(arr.Length - 1) = item
        End Sub

        <Serializable()>
        Class TreeNodeMedia
            Sub New(url As String, type As String)
                Me.Url = url
                Me.Type = type
            End Sub
            Public Url As String
            Public Type As MediaType
        End Class

        Enum MediaType
            media
            folder
            pause
        End Enum

    End Module

    Public Class MediaManager
        Public urls As String() = {}
        Public tw As TreeView
        Public list As ListBox
        Public medianame As Object
        Public WithEvents vlc As AxVLCPlugin2

        Public playlist As PlaylistManager
        Public node As TreenodeManager

        Sub New(ByRef treeview As TreeView, ByRef listbox As ListBox, ByRef label As Object, ByRef axvlc As AxAXVLC.AxVLCPlugin2)
            tw = treeview
            list = listbox
            medianame = label
            vlc = axvlc

            playlist = New PlaylistManager(Me)
            node = New TreenodeManager(Me)
        End Sub

    End Class

    Public Class PlaylistManager
        Private parent As MediaManager

        Sub New(ByRef manager As MediaManager)
            parent = manager

            AddHandler parent.vlc.MediaPlayerTimeChanged, AddressOf VLC_MediaPlayerPositionChanged
            AddHandler parent.vlc.MediaPlayerPaused, AddressOf VLC_MediaPlayerPaused
            AddHandler parent.vlc.MediaPlayerPlaying, AddressOf VLC_MediaPlayerPlaying
            AddHandler parent.vlc.MediaPlayerMediaChanged, AddressOf VLC_MediaPlayerMediaChanged
            AddHandler parent.vlc.MediaPlayerEndReached, AddressOf VLC_MediaPlayerEndReached
        End Sub

#Region "       Functions"
        ''' <summary>
        ''' Clear all playlist
        ''' </summary>
        Public Sub Clear()
            parent.vlc.playlist.stop()
            parent.vlc.playlist.items.clear()
            parent.list.Items.Clear()
            parent.urls = {}
            parent.medianame.Text = "No media"
        End Sub

        ''' <summary>
        ''' Add music node(s) to playlist 
        ''' </summary>
        Public Sub AddNodes(node As TreeNode, Optional checked As Boolean = False)
            If Not node.GetMedia.Type = MediaType.folder Then
                If (Not checked) OrElse node.Checked Then
                    Add(node.Text, node.GetMedia)
                End If
            Else
                For Each child As TreeNode In node.Nodes
                    AddNodes(child, checked)
                Next
            End If
        End Sub

        Public Sub AddNodes()
            For Each child As TreeNode In parent.tw.Nodes
                AddNodes(child, True)
            Next
        End Sub

        ''' <summary>
        ''' Add a music to playlist 
        ''' </summary>
        Public Sub Add(name As String, media As TreeNodeMedia)
            If media.Type = MediaType.media Then
                parent.vlc.playlist.add("file:///" + media.Url, name)
            Else
                parent.vlc.playlist.add(media.Url, name)
            End If
            parent.list.Items.Add(name)
            parent.urls.Add(media.Url)
        End Sub
#End Region

#Region "       VLC events"
        Public Seeking As Integer = 0

        Private Sub VLC_MediaPlayerPositionChanged(sender As Object, e As DVLCEvents_MediaPlayerTimeChangedEvent)
            If seeking > 0 Then
                If e.time = seeking Then
                    seeking = False
                End If
            Else
                Dim lenght As TimeSpan = TimeSpan.FromMilliseconds(sender.input.length)
                Dim actual As TimeSpan = TimeSpan.FromMilliseconds(e.time)
                Main.SeekTrackBar.Maximum = lenght.TotalMilliseconds
                Main.SeekTrackBar.Value = Math.Min(actual.TotalMilliseconds, lenght.TotalMilliseconds)
                Main.TimeLabel.Text = timetostring(actual) & "/" & timetostring(lenght)
            End If
        End Sub

        Function timetostring(time As TimeSpan) As String
            Return time.Hours.ToString("D2") & ":" & time.Minutes.ToString("D2") & ":" & time.Seconds.ToString("D2")
        End Function

        Private Sub VLC_MediaPlayerPaused(sender As Object, e As EventArgs)
            Main.PlayButton.Text = "Play"
        End Sub

        Private Sub VLC_MediaPlayerPlaying(sender As Object, e As EventArgs)
            Main.PlayButton.Text = "Pause"
        End Sub

        Private Sub VLC_MediaPlayerMediaChanged(sender As Object, e As EventArgs)
            Main.MediaNameLabel.Text = Main.MediaList.Items(sender.playlist.currentItem)
            Main.MediaList.SelectedIndex = sender.playlist.currentItem
        End Sub

        Private Sub VLC_MediaPlayerEndReached(sender As Object, e As EventArgs)
            If Not Main.AutoPlayCheck.Checked Then
                sender.playlist.pause()
            End If
        End Sub
#End Region

    End Class

    Public Class TreenodeManager
        Private parent As MediaManager

        Sub New(ByRef manager As MediaManager)
            parent = manager
        End Sub

        Private toremove As New List(Of TreeNode)
        ''' <summary>
        ''' Remove nodes from Treeview
        ''' </summary>
        Public Sub Remove(node As TreeNode, Optional checked As Boolean = False)
            If (Not checked) OrElse node.Checked Then
                toremove.Add(node)
            ElseIf node.GetMedia.Type = MediaType.folder And node.GetNodeCount(True) > 0 Then
                For Each child As TreeNode In node.Nodes
                    Remove(child, checked)
                Next
            End If
        End Sub

        Public Sub Remove()
            For Each child As TreeNode In parent.tw.Nodes
                Remove(child, True)
            Next
            For Each del In toremove
                del.Remove()
            Next
            RaiseEvent OnChanges()
        End Sub

        ''' <summary>
        ''' Triggered when a node is changed on Treeview
        ''' </summary>
        Public Event OnChanges()

        ''' <summary>
        ''' Check or uncheck a node and his children
        ''' </summary>
        Public Sub checkNodes(check As Boolean, node As TreeNode)
            For Each nd As TreeNode In node.Nodes
                nd.Checked = check
            Next
        End Sub

        ''' <summary>
        ''' Save TreeView to file
        ''' </summary>
        Sub Save(ByVal filePath As String)
            Dim tmp As New List(Of TreeNode)
            For Each n As TreeNode In parent.tw.Nodes
                Dim tninfo As New TreeNode
                tninfo = n
                tmp.Add(tninfo)
            Next
            Using fs As IO.FileStream = IO.File.Open(filePath, IO.FileMode.Create)
                Dim bf As New Runtime.Serialization.Formatters.Binary.BinaryFormatter
                bf.Serialize(fs, tmp)
            End Using
        End Sub

        ''' <summary>
        ''' Load TreeView from file
        ''' </summary>
        Sub Load(ByVal filePath As String)
            Dim tmp As New List(Of TreeNode)
            Using fs As IO.FileStream = IO.File.Open(filePath, IO.FileMode.Open)
                Dim bf As New Runtime.Serialization.Formatters.Binary.BinaryFormatter
                tmp = CType(bf.Deserialize(fs), List(Of TreeNode))
            End Using
            For Each n As TreeNode In tmp
                parent.tw.Nodes.Add(n)
            Next
        End Sub
    End Class

End Namespace