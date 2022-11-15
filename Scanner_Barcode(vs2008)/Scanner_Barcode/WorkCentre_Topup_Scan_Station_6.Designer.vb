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
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.Panel1 = New System.Windows.Forms.Panel
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
        Me.back_btn = New System.Windows.Forms.Button
        Me.home_btn = New System.Windows.Forms.Button
        Me.logout_btn = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
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
        Me.Panel4.Size = New System.Drawing.Size(480, 57)
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
        Me.Panel2.Size = New System.Drawing.Size(480, 57)
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
        Me.cont_btn.Location = New System.Drawing.Point(151, 387)
        Me.cont_btn.Name = "cont_btn"
        Me.cont_btn.Size = New System.Drawing.Size(162, 38)
        Me.cont_btn.TabIndex = 28
        Me.cont_btn.Text = "Continue"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(50, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 26)
        Me.Label5.Text = "Scan Station"
        '
        'scn_stn
        '
        Me.scn_stn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.scn_stn.Location = New System.Drawing.Point(130, 351)
        Me.scn_stn.Name = "scn_stn"
        Me.scn_stn.Size = New System.Drawing.Size(208, 21)
        Me.scn_stn.TabIndex = 27
        '
        'DataGrid2
        '
        Me.DataGrid2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid2.Location = New System.Drawing.Point(39, 288)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(387, 153)
        Me.DataGrid2.TabIndex = 29
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(383, 565)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(92, 20)
        Me.username.Text = "[username]"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(316, 565)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.Text = "User_ID :"
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.Firebrick
        Me.back_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.back_btn.Location = New System.Drawing.Point(405, 173)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(72, 41)
        Me.back_btn.TabIndex = 33
        Me.back_btn.Text = "Back"
        '
        'home_btn
        '
        Me.home_btn.BackColor = System.Drawing.Color.DimGray
        Me.home_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.home_btn.Location = New System.Drawing.Point(3, 173)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.Size = New System.Drawing.Size(72, 41)
        Me.home_btn.TabIndex = 34
        Me.home_btn.Text = "Home"
        '
        'logout_btn
        '
        Me.logout_btn.BackColor = System.Drawing.SystemColors.Desktop
        Me.logout_btn.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.logout_btn.Location = New System.Drawing.Point(418, 590)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(55, 41)
        Me.logout_btn.TabIndex = 38
        Me.logout_btn.Text = "log out"
        '
        'WorkCentre_Topup_Scan_Station_6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.home_btn)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cont_btn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.scn_stn)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Menu = Me.mainMenu1
        Me.Name = "WorkCentre_Topup_Scan_Station_6"
        Me.Text = "Topup_Scan_Station_6"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
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
    Friend WithEvents back_btn As System.Windows.Forms.Button
    Friend WithEvents home_btn As System.Windows.Forms.Button
    Friend WithEvents logout_btn As System.Windows.Forms.Button
End Class
