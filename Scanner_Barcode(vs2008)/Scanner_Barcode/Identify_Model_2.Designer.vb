<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Identify_Model_2
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
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.scan_btn = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.model_ID = New System.Windows.Forms.TextBox
        Me.Cont_btn = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.copyID_lbl = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.rescan_btn = New System.Windows.Forms.Button
        Me.mdl_sub_ID = New System.Windows.Forms.TextBox
        Me.model_img = New System.Windows.Forms.PictureBox
        Me.username = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.logout_btn = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 53)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label1.Location = New System.Drawing.Point(121, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 34)
        Me.Label1.Text = "Barcode Scanner"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 57)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 26)
        Me.Label2.Text = "Scan Line && Model"
        '
        'scan_btn
        '
        Me.scan_btn.BackColor = System.Drawing.Color.LimeGreen
        Me.scan_btn.ForeColor = System.Drawing.Color.White
        Me.scan_btn.Location = New System.Drawing.Point(366, 35)
        Me.scan_btn.Name = "scan_btn"
        Me.scan_btn.Size = New System.Drawing.Size(71, 47)
        Me.scan_btn.TabIndex = 6
        Me.scan_btn.Text = "Scan"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(12, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 23)
        Me.Label3.Text = "Scan Line && Model"
        '
        'model_ID
        '
        Me.model_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.model_ID.Location = New System.Drawing.Point(130, 47)
        Me.model_ID.Name = "model_ID"
        Me.model_ID.Size = New System.Drawing.Size(222, 21)
        Me.model_ID.TabIndex = 0
        '
        'Cont_btn
        '
        Me.Cont_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.Cont_btn.ForeColor = System.Drawing.Color.White
        Me.Cont_btn.Location = New System.Drawing.Point(152, 261)
        Me.Cont_btn.Name = "Cont_btn"
        Me.Cont_btn.Size = New System.Drawing.Size(171, 36)
        Me.Cont_btn.TabIndex = 10
        Me.Cont_btn.Text = "Continue"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.model_ID)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.scan_btn)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(5, 131)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(472, 437)
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label8.Location = New System.Drawing.Point(153, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 20)
        Me.Label8.Text = "Scan the Barcode on Model"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.copyID_lbl)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Cont_btn)
        Me.Panel4.Controls.Add(Me.rescan_btn)
        Me.Panel4.Controls.Add(Me.mdl_sub_ID)
        Me.Panel4.Controls.Add(Me.model_img)
        Me.Panel4.Location = New System.Drawing.Point(3, 117)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(466, 317)
        '
        'copyID_lbl
        '
        Me.copyID_lbl.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.copyID_lbl.ForeColor = System.Drawing.Color.Black
        Me.copyID_lbl.Location = New System.Drawing.Point(357, 234)
        Me.copyID_lbl.Name = "copyID_lbl"
        Me.copyID_lbl.Size = New System.Drawing.Size(55, 21)
        Me.copyID_lbl.TabIndex = 16
        Me.copyID_lbl.Text = "Copy ID"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(170, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 22)
        Me.Label4.Text = "Subline && Model ID"
        '
        'rescan_btn
        '
        Me.rescan_btn.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.rescan_btn.ForeColor = System.Drawing.Color.Black
        Me.rescan_btn.Location = New System.Drawing.Point(381, 91)
        Me.rescan_btn.Name = "rescan_btn"
        Me.rescan_btn.Size = New System.Drawing.Size(71, 47)
        Me.rescan_btn.TabIndex = 10
        Me.rescan_btn.Text = "Rescan"
        '
        'mdl_sub_ID
        '
        Me.mdl_sub_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.mdl_sub_ID.Location = New System.Drawing.Point(127, 234)
        Me.mdl_sub_ID.Name = "mdl_sub_ID"
        Me.mdl_sub_ID.Size = New System.Drawing.Size(224, 21)
        Me.mdl_sub_ID.TabIndex = 14
        '
        'model_img
        '
        Me.model_img.BackColor = System.Drawing.Color.White
        Me.model_img.Location = New System.Drawing.Point(127, 24)
        Me.model_img.Name = "model_img"
        Me.model_img.Size = New System.Drawing.Size(224, 173)
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(396, 571)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(81, 20)
        Me.username.Text = "[username]"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(322, 571)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.Text = "User_ID :"
        '
        'logout_btn
        '
        Me.logout_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.logout_btn.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.logout_btn.Location = New System.Drawing.Point(420, 594)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(55, 41)
        Me.logout_btn.TabIndex = 16
        Me.logout_btn.Text = "log out"
        '
        'Identify_Model_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Menu = Me.mainMenu1
        Me.Name = "Identify_Model_2"
        Me.Text = "Identify_Model_2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents scan_btn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents model_ID As System.Windows.Forms.TextBox
    Friend WithEvents Cont_btn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents model_img As System.Windows.Forms.PictureBox
    Friend WithEvents rescan_btn As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents logout_btn As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents mdl_sub_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents copyID_lbl As System.Windows.Forms.Button
End Class
