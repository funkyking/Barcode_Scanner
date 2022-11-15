<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class choose_option_4
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
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.topup_btn = New System.Windows.Forms.Button
        Me.prep_btn = New System.Windows.Forms.Button
        Me.sffx_chg_btn = New System.Windows.Forms.Button
        Me.mdl_chg_btn = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.sub_lbl = New System.Windows.Forms.Label
        Me.mdl_lbl = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.username = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.logout_btn = New System.Windows.Forms.Button
        Me.back_btn = New System.Windows.Forms.Button
        Me.home_btn = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.topup_btn)
        Me.Panel3.Controls.Add(Me.prep_btn)
        Me.Panel3.Controls.Add(Me.sffx_chg_btn)
        Me.Panel3.Controls.Add(Me.mdl_chg_btn)
        Me.Panel3.Controls.Add(Me.DataGrid1)
        Me.Panel3.Location = New System.Drawing.Point(103, 169)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(256, 295)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(3, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 35)
        Me.Label4.Text = "Options"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'topup_btn
        '
        Me.topup_btn.BackColor = System.Drawing.Color.LightSeaGreen
        Me.topup_btn.ForeColor = System.Drawing.Color.White
        Me.topup_btn.Location = New System.Drawing.Point(139, 173)
        Me.topup_btn.Name = "topup_btn"
        Me.topup_btn.Size = New System.Drawing.Size(98, 51)
        Me.topup_btn.TabIndex = 3
        Me.topup_btn.Text = "Top Up"
        '
        'prep_btn
        '
        Me.prep_btn.Location = New System.Drawing.Point(139, 70)
        Me.prep_btn.Name = "prep_btn"
        Me.prep_btn.Size = New System.Drawing.Size(98, 51)
        Me.prep_btn.TabIndex = 2
        Me.prep_btn.Text = "Preparation"
        '
        'sffx_chg_btn
        '
        Me.sffx_chg_btn.Location = New System.Drawing.Point(18, 173)
        Me.sffx_chg_btn.Name = "sffx_chg_btn"
        Me.sffx_chg_btn.Size = New System.Drawing.Size(98, 51)
        Me.sffx_chg_btn.TabIndex = 1
        Me.sffx_chg_btn.Text = "Suffix Change"
        '
        'mdl_chg_btn
        '
        Me.mdl_chg_btn.Location = New System.Drawing.Point(18, 70)
        Me.mdl_chg_btn.Name = "mdl_chg_btn"
        Me.mdl_chg_btn.Size = New System.Drawing.Size(98, 51)
        Me.mdl_chg_btn.TabIndex = 0
        Me.mdl_chg_btn.Text = "Model Change"
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(256, 295)
        Me.DataGrid1.TabIndex = 16
        '
        'sub_lbl
        '
        Me.sub_lbl.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.sub_lbl.Location = New System.Drawing.Point(39, 15)
        Me.sub_lbl.Name = "sub_lbl"
        Me.sub_lbl.Size = New System.Drawing.Size(144, 26)
        Me.sub_lbl.Text = "Subline [0]"
        Me.sub_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'mdl_lbl
        '
        Me.mdl_lbl.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.mdl_lbl.Location = New System.Drawing.Point(279, 15)
        Me.mdl_lbl.Name = "mdl_lbl"
        Me.mdl_lbl.Size = New System.Drawing.Size(147, 26)
        Me.mdl_lbl.Text = "Model ID [0]"
        Me.mdl_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label13.Location = New System.Drawing.Point(225, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 26)
        Me.Label13.Text = "|"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.mdl_lbl)
        Me.Panel2.Controls.Add(Me.sub_lbl)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 57)
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(382, 564)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(92, 20)
        Me.username.Text = "[username]"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(315, 564)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.Text = "User_ID :"
        '
        'logout_btn
        '
        Me.logout_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.logout_btn.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.logout_btn.Location = New System.Drawing.Point(419, 587)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(55, 41)
        Me.logout_btn.TabIndex = 17
        Me.logout_btn.Text = "log out"
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.Firebrick
        Me.back_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.back_btn.Location = New System.Drawing.Point(405, 116)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(72, 41)
        Me.back_btn.TabIndex = 32
        Me.back_btn.Text = "Back"
        '
        'home_btn
        '
        Me.home_btn.BackColor = System.Drawing.Color.DimGray
        Me.home_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.home_btn.Location = New System.Drawing.Point(3, 116)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.Size = New System.Drawing.Size(72, 41)
        Me.home_btn.TabIndex = 33
        Me.home_btn.Text = "Home"
        '
        'choose_option_4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.home_btn)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Menu = Me.mainMenu1
        Me.Name = "choose_option_4"
        Me.Text = "choose_option_4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents topup_btn As System.Windows.Forms.Button
    Friend WithEvents prep_btn As System.Windows.Forms.Button
    Friend WithEvents sffx_chg_btn As System.Windows.Forms.Button
    Friend WithEvents mdl_chg_btn As System.Windows.Forms.Button
    Friend WithEvents sub_lbl As System.Windows.Forms.Label
    Friend WithEvents mdl_lbl As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents username As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents logout_btn As System.Windows.Forms.Button
    Friend WithEvents back_btn As System.Windows.Forms.Button
    Friend WithEvents home_btn As System.Windows.Forms.Button
End Class
