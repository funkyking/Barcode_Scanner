<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class WorkCentre_Topup_Scan_Part_Match_8
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
        Me.stn_val = New System.Windows.Forms.Label
        Me.Station = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'stn_val
        '
        Me.stn_val.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular)
        Me.stn_val.Location = New System.Drawing.Point(56, 320)
        Me.stn_val.Name = "stn_val"
        Me.stn_val.Size = New System.Drawing.Size(337, 113)
        Me.stn_val.Text = "[]"
        Me.stn_val.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Station
        '
        Me.Station.Font = New System.Drawing.Font("Microsoft Sans Serif", 58.0!, System.Drawing.FontStyle.Regular)
        Me.Station.Location = New System.Drawing.Point(13, 207)
        Me.Station.Name = "Station"
        Me.Station.Size = New System.Drawing.Size(455, 113)
        Me.Station.Text = "Part Match !"
        Me.Station.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'WorkCentre_Topup_Scan_Part_Match_8
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.LawnGreen
        Me.ClientSize = New System.Drawing.Size(478, 615)
        Me.Controls.Add(Me.stn_val)
        Me.Controls.Add(Me.Station)
        Me.Name = "WorkCentre_Topup_Scan_Part_Match_8"
        Me.Text = "WorkCentre_Topup_Scan_Part_Match_8"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents stn_val As System.Windows.Forms.Label
    Friend WithEvents Station As System.Windows.Forms.Label
End Class
