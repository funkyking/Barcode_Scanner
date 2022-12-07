<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class WorkCentre_Topup_Scan_Station_6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorkCentre_Topup_Scan_Station_6))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.logout_pbx = New System.Windows.Forms.PictureBox
        Me.settings_pbx = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.part_Id_lbl = New System.Windows.Forms.Label
        Me.part_station_lbl = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.mdl_lbl = New System.Windows.Forms.Label
        Me.sub_lbl = New System.Windows.Forms.Label
        Me.cont_btn = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.scn_stn = New System.Windows.Forms.TextBox
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.username = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.rescan_pbx = New System.Windows.Forms.PictureBox
        Me.back_pbx = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.logout_pbx)
        Me.Panel1.Controls.Add(Me.settings_pbx)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 53)
        '
        'logout_pbx
        '
        Me.logout_pbx.BackColor = System.Drawing.Color.Transparent
        Me.logout_pbx.Image = CType(resources.GetObject("logout_pbx.Image"), System.Drawing.Image)
        Me.logout_pbx.Location = New System.Drawing.Point(428, 8)
        Me.logout_pbx.Name = "logout_pbx"
        Me.logout_pbx.Size = New System.Drawing.Size(44, 36)
        Me.logout_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'settings_pbx
        '
        Me.settings_pbx.BackColor = System.Drawing.Color.Transparent
        Me.settings_pbx.Image = CType(resources.GetObject("settings_pbx.Image"), System.Drawing.Image)
        Me.settings_pbx.Location = New System.Drawing.Point(6, 8)
        Me.settings_pbx.Name = "settings_pbx"
        Me.settings_pbx.Size = New System.Drawing.Size(32, 32)
        Me.settings_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label1.Location = New System.Drawing.Point(121, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 34)
        Me.Label1.Text = "Barcode Scanner"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gold
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.part_Id_lbl)
        Me.Panel4.Controls.Add(Me.part_station_lbl)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 110)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(478, 57)
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label11.Location = New System.Drawing.Point(279, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 26)
        Me.Label11.Text = "|"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label10.Location = New System.Drawing.Point(93, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 26)
        Me.Label10.Text = "|"
        '
        'part_Id_lbl
        '
        Me.part_Id_lbl.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.part_Id_lbl.Location = New System.Drawing.Point(304, 16)
        Me.part_Id_lbl.Name = "part_Id_lbl"
        Me.part_Id_lbl.Size = New System.Drawing.Size(171, 26)
        Me.part_Id_lbl.Text = "Part ID [0]"
        Me.part_Id_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'part_station_lbl
        '
        Me.part_station_lbl.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.part_station_lbl.Location = New System.Drawing.Point(121, 16)
        Me.part_station_lbl.Name = "part_station_lbl"
        Me.part_station_lbl.Size = New System.Drawing.Size(165, 26)
        Me.part_station_lbl.Text = "Part Station [0]"
        Me.part_station_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label7.Location = New System.Drawing.Point(3, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 26)
        Me.Label7.Text = "Top Up"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.Panel2.Size = New System.Drawing.Size(478, 57)
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label13.Location = New System.Drawing.Point(225, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 26)
        Me.Label13.Text = "|"
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
        'sub_lbl
        '
        Me.sub_lbl.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.sub_lbl.Location = New System.Drawing.Point(39, 15)
        Me.sub_lbl.Name = "sub_lbl"
        Me.sub_lbl.Size = New System.Drawing.Size(144, 26)
        Me.sub_lbl.Text = "Subline [0]"
        Me.sub_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cont_btn
        '
        Me.cont_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.cont_btn.ForeColor = System.Drawing.Color.White
        Me.cont_btn.Location = New System.Drawing.Point(225, 588)
        Me.cont_btn.Name = "cont_btn"
        Me.cont_btn.Size = New System.Drawing.Size(57, 24)
        Me.cont_btn.TabIndex = 28
        Me.cont_btn.Text = "Continue"
        Me.cont_btn.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(14, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 26)
        Me.Label5.Text = "Scan Station"
        '
        'scn_stn
        '
        Me.scn_stn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.scn_stn.Location = New System.Drawing.Point(84, 68)
        Me.scn_stn.Name = "scn_stn"
        Me.scn_stn.Size = New System.Drawing.Size(208, 23)
        Me.scn_stn.TabIndex = 27
        '
        'DataGrid2
        '
        Me.DataGrid2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid2.Location = New System.Drawing.Point(39, 257)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(401, 230)
        Me.DataGrid2.TabIndex = 29
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(383, 170)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(92, 20)
        Me.username.Text = "[username]"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(304, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.Text = "User_ID :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.rescan_pbx)
        Me.Panel3.Controls.Add(Me.back_pbx)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.scn_stn)
        Me.Panel3.Location = New System.Drawing.Point(62, 279)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(350, 178)
        '
        'rescan_pbx
        '
        Me.rescan_pbx.Image = CType(resources.GetObject("rescan_pbx.Image"), System.Drawing.Image)
        Me.rescan_pbx.Location = New System.Drawing.Point(298, 68)
        Me.rescan_pbx.Name = "rescan_pbx"
        Me.rescan_pbx.Size = New System.Drawing.Size(28, 23)
        Me.rescan_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'back_pbx
        '
        Me.back_pbx.Image = CType(resources.GetObject("back_pbx.Image"), System.Drawing.Image)
        Me.back_pbx.Location = New System.Drawing.Point(163, 97)
        Me.back_pbx.Name = "back_pbx"
        Me.back_pbx.Size = New System.Drawing.Size(38, 39)
        Me.back_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(15, 183)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'WorkCentre_Topup_Scan_Station_6
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(478, 615)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cont_btn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGrid2)
        Me.Name = "WorkCentre_Topup_Scan_Station_6"
        Me.Text = "Topup_Scan_Station_6"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents part_Id_lbl As System.Windows.Forms.Label
    Friend WithEvents part_station_lbl As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents mdl_lbl As System.Windows.Forms.Label
    Friend WithEvents sub_lbl As System.Windows.Forms.Label
    Friend WithEvents cont_btn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents scn_stn As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents username As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents logout_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents settings_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents back_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents rescan_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
