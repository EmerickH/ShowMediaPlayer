<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Output
    Inherits System.Windows.Forms.Form

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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Output))
        Me.VLC = New Vlc.DotNet.Forms.VlcControl()
        CType(Me.VLC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VLC
        '
        Me.VLC.BackColor = System.Drawing.Color.Black
        Me.VLC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VLC.Location = New System.Drawing.Point(0, 0)
        Me.VLC.Name = "VLC"
        Me.VLC.Size = New System.Drawing.Size(284, 261)
        Me.VLC.Spu = -1
        Me.VLC.TabIndex = 0
        Me.VLC.Text = "VLC"
        Me.VLC.VlcLibDirectory = CType(resources.GetObject("VLC.VlcLibDirectory"), System.IO.DirectoryInfo)
        Me.VLC.VlcMediaplayerOptions = Nothing
        '
        'Output
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.VLC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Output"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Output"
        Me.TopMost = True
        CType(Me.VLC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VLC As Vlc.DotNet.Forms.VlcControl
End Class
