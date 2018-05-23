Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports Sanford.Multimedia.Midi
Imports Sanford.Multimedia.Midi.UI
Imports Vlc.DotNet.Core
'Imports Midi

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

    Public Class PlaylistManager
        Public urls As String() = {}
        Public tw As TreeView
        Public list As ListBox
        Public WithEvents vlc As Vlc.DotNet.Forms.VlcControl
        Public form As Form
        Public WithEvents inputDev As InputDevice
        Public midichoose As New InputDeviceDialog()

        Delegate Sub EventHandlerDelegate()

        Sub New(ByRef treeview As TreeView, ByRef listbox As ListBox, ByRef label As Object, ByRef axvlc As Vlc.DotNet.Forms.VlcControl, ByRef form As Form)
            list = listbox
            vlc = axvlc
            tw = treeview
            Me.form = form

            AddHandler vlc.VlcMediaPlayer.TimeChanged, AddressOf VLC_MediaPlayerPositionChanged
            AddHandler vlc.VlcMediaPlayer.Paused, AddressOf VLC_MediaPlayerPlayPause
            AddHandler vlc.VlcMediaPlayer.Playing, AddressOf VLC_MediaPlayerPlayPause
        End Sub

#Region "       Functions"
        ''' <summary>
        ''' Clear all playlist
        ''' </summary>
        Public Sub Clear()
            'parent.vlc.playlist.stop()
            'parent.vlc.playlist.items.clear()
            vlc.VlcMediaPlayer.Stop()
            list.Items.Clear()
            urls = {}
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
            For Each child As TreeNode In tw.Nodes
                AddNodes(child, True)
            Next
        End Sub

        ''' <summary>
        ''' Add a music to playlist 
        ''' </summary>
        Public Sub Add(name As String, media As TreeNodeMedia)
            If media.Type = MediaType.media Then
                urls.Add("file:///" + media.Url)
            Else
                urls.Add(media.Url)
            End If
            list.Items.Add(name)
        End Sub

        Public Sub Play(id As Integer)
            vlc.Play(urls(id), list.Items(id))
        End Sub
#End Region

#Region "       VLC events"

        Dim lenght As TimeSpan
        Dim actual As TimeSpan

        Private Sub VLC_MediaPlayerPositionChanged(sender As Object, e As VlcMediaPlayerTimeChangedEventArgs)
            lenght = TimeSpan.FromMilliseconds(vlc.Length)
            actual = TimeSpan.FromMilliseconds(vlc.Time)

            Dim del As New EventHandlerDelegate(AddressOf TimeEventHandler)
            form.Invoke(del)
        End Sub

        Public Shared Event TimeChanged(ByVal sender As Object, ByVal e As TimeChangedEventArgs)

        Public Sub TimeEventHandler()
            RaiseEvent TimeChanged(Me, New TimeChangedEventArgs(lenght, actual))
        End Sub

        Private Sub VLC_MediaPlayerPlayPause()
            Dim del As New EventHandlerDelegate(AddressOf PauseEventHandler)
            form.Invoke(del)
        End Sub

        Public Shared Event PauseChanged(ByVal sender As Object, ByVal e As Boolean)

        Private Sub PauseEventHandler()
            RaiseEvent PauseChanged(Me, vlc.State = Interops.Signatures.MediaStates.Playing)
        End Sub

#End Region

#Region "       Midi"

        Public Sub ConnectMidi()
            If midichoose.ShowDialog() = DialogResult.OK Then
                Try
                    If Not IsNothing(inputDev) Then
                        inputDev.StopRecording()
                        inputDev.Close()
                    End If
                    inputDev = New InputDevice(midichoose.InputDeviceID)
                    inputDev.StartRecording()
                    MsgBox("Device connected", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox("Error on connecting: " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        End Sub

        Private Sub inputDev_ControlChange(sender As Object, e As ChannelMessageEventArgs) Handles inputDev.ChannelMessageReceived
            Debug.WriteLine(e.Message.Data1 & ": " & e.Message.Data2)
            If e.Message.Data2 > 0 Then
                Select Case e.Message.Data1
                    Case 0
                        If vlc.VlcMediaPlayer.State = 3 Then
                            vlc.Pause()
                        Else
                            vlc.Play()
                        End If
                    Case 1
                        vlc.Time = (e.Message.Data2 - 1) / 126 * vlc.Length
                    Case 2
                        list.SelectedIndex = Math.Min(list.SelectedIndex + 1, list.Items.Count)
                    Case 3
                        list.SelectedIndex = Math.Max(list.SelectedIndex - 1, 0)
                End Select
            End If
        End Sub
    End Class

#End Region

    Public Class TimeChangedEventArgs
        Public lenght As TimeSpan
        Public actual As TimeSpan
        Sub New(lgt As TimeSpan, time As TimeSpan)
            lenght = lgt
            actual = time
        End Sub
    End Class

    Public Class TreenodeManager
        Public tw As TreeView

        Sub New(ByRef treeview As TreeView)
            tw = treeview
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
            For Each child As TreeNode In tw.Nodes
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
            For Each n As TreeNode In tw.Nodes
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
                tw.Nodes.Add(n)
            Next
        End Sub
    End Class

End Namespace