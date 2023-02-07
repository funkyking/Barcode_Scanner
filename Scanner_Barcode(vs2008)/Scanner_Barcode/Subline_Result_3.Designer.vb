<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Subline_Result_3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me._top = New System.Windows.Forms.Label
        Me._bot = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        '_top
        '
        Me._top.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Regular)
        Me._top.Location = New System.Drawing.Point(12, 126)
        Me._top.Name = "_top"
        Me._top.Size = New System.Drawing.Size(465, 144)
        Me._top.Text = "Station"
        Me._top.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_bot
        '
        Me._bot.Font = New System.Drawing.Font("Microsoft Sans Serif", 42.0!, System.Drawing.FontStyle.Regular)
        Me._bot.Location = New System.Drawing.Point(12, 283)
        Me._bot.Name = "_bot"
        Me._bot.Size = New System.Drawing.Size(465, 309)
        Me._bot.Text = "00"
        Me._bot.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Subline_Result_3
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LawnGreen
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me._bot)
        Me.Controls.Add(Me._top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Subline_Result_3"
        Me.Text = "Subline_Result_3"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _top As System.Windows.Forms.Label
    Friend WithEvents _bot As System.Windows.Forms.Label
End Class
