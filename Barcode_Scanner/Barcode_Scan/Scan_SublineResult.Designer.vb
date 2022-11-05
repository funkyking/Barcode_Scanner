<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scan_SublineResult
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sublineStn = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 83)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Part Station"
        '
        'sublineStn
        '
        Me.sublineStn.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sublineStn.Location = New System.Drawing.Point(179, 271)
        Me.sublineStn.Name = "sublineStn"
        Me.sublineStn.Size = New System.Drawing.Size(116, 99)
        Me.sublineStn.TabIndex = 3
        Me.sublineStn.Text = "[0]"
        '
        'Scan_SublineResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(458, 584)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sublineStn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Scan_SublineResult"
        Me.Text = "Scan_SublineResult"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents sublineStn As Label
End Class
