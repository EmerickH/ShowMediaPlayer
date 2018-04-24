Namespace MetroAdditions
    Friend Class MetroStripRenderer
        Inherits ToolStripRenderer

        Private gcolor As Color = Color.FromArgb(45, 45, 45)
        Private gpen As New Pen(gcolor, 3)

        Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
            MyBase.OnRenderToolStripBorder(e)

            e.Graphics.DrawLine(gpen, 0, e.AffectedBounds.Height - 2, e.AffectedBounds.Width, e.AffectedBounds.Height - 2)
        End Sub

        Protected Overrides Sub OnRenderButtonBackground(e As ToolStripItemRenderEventArgs)
            MyBase.OnRenderButtonBackground(e)

            If (e.Item.Selected = True) Then
                e.Graphics.Clear(gcolor)
            End If
        End Sub

        Protected Overrides Sub OnRenderSeparator(e As ToolStripSeparatorRenderEventArgs)
            MyBase.OnRenderSeparator(e)

            e.Graphics.DrawLine(gpen, 2, 0, 2, e.Item.Height)
        End Sub
    End Class

    Module MetroStyle
        Public Sub SetMetroStyle(ByVal parent As Control)
            If parent.GetType.Namespace = "MetroFramework.Controls" Then
                Try
                    DirectCast(parent, Object).StyleManager = Main.msmMain
                Catch
                End Try
            End If
            For Each child In parent.Controls
                SetMetroStyle(child)
            Next
        End Sub
    End Module
End Namespace
