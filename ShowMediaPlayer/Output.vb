﻿Imports System.IO
Imports Vlc.DotNet.Core
Public Class Output

#Region "Output visibility"
    Private Sub Output_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Visible Then
            If Main.OutputChoice.SelectedIndex = 0 Then
                FormBorderStyle = FormBorderStyle.Sizable
                Bounds = Main.Bounds
            Else
                FormBorderStyle = FormBorderStyle.None
                Bounds = Screen.AllScreens(Main.OutputChoice.SelectedIndex - 1).Bounds
            End If
        End If
    End Sub

    Private Sub Output_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main.ShowOutputCheck.Checked = False
        e.Cancel = True
    End Sub

    Private Sub VLC_VlcLibDirectoryNeeded(sender As Object, e As Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs) Handles VLC.VlcLibDirectoryNeeded
        Me.VLC.VlcLibDirectory = New DirectoryInfo(Path.Combine(Application.StartupPath, "libvlc\win-x64"))
    End Sub

#End Region

End Class