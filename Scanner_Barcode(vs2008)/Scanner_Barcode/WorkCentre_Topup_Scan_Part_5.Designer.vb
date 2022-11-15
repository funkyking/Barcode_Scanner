<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class WorkCentre_Topup_Scan_Part_5
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
        Me.Label13 = New System.Windows.Forms.Label
        Me.mdl_lbl = New System.Windows.Forms.Label
        Me.sub_lbl = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.cont_btn = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.part_ID = New System.Windows.Forms.TextBox
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.username = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.back_btn = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList
        Me.home_btn = New System.Windows.Forms.Button
        Me.logout_btn = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 110)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(480, 57)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(147, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 26)
        Me.Label4.Text = "Top Up Section"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cont_btn
        '
        Me.cont_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.cont_btn.ForeColor = System.Drawing.Color.White
        Me.cont_btn.Location = New System.Drawing.Point(147, 337)
        Me.cont_btn.Name = "cont_btn"
        Me.cont_btn.Size = New System.Drawing.Size(166, 38)
        Me.cont_btn.TabIndex = 25
        Me.cont_btn.Text = "Continue"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(52, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 26)
        Me.Label5.Text = "Scan Part"
        '
        'part_ID
        '
        Me.part_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.part_ID.Location = New System.Drawing.Point(130, 295)
        Me.part_ID.Name = "part_ID"
        Me.part_ID.Size = New System.Drawing.Size(208, 21)
        Me.part_ID.TabIndex = 23
        '
        'DataGrid2
        '
        Me.DataGrid2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid2.Location = New System.Drawing.Point(39, 232)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(387, 153)
        Me.DataGrid2.TabIndex = 26
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(390, 572)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(77, 20)
        Me.username.Text = "[username]"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(316, 572)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.Text = "User_ID :"
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.Firebrick
        Me.back_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.back_btn.Location = New System.Drawing.Point(405, 173)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(72, 41)
        Me.back_btn.TabIndex = 30
        Me.back_btn.Text = "Back"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        '
        'home_btn
        '
        Me.home_btn.BackColor = System.Drawing.Color.DimGray
        Me.home_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.home_btn.Location = New System.Drawing.Point(3, 173)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.Size = New System.Drawing.Size(72, 41)
        Me.home_btn.TabIndex = 31
        Me.home_btn.Text = "Home"
        '
        'logout_btn
        '
        Me.logout_btn.BackColor = System.Drawing.SystemColors.Desktop
        Me.logout_btn.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.logout_btn.Location = New System.Drawing.Point(422, 595)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(55, 41)
        Me.logout_btn.TabIndex = 37
        Me.logout_btn.Text = "log out"
        '
        'WorkCentre_Topup_Scan_Part_5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.home_btn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cont_btn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.part_ID)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Menu = Me.mainMenu1
        Me.Name = "WorkCentre_Topup_Scan_Part_5"
        Me.Text = "Topup_Scan_5"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents mdl_lbl As System.Windows.Forms.Label
    Friend WithEvents sub_lbl As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cont_btn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents part_ID As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents username As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents back_btn As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents home_btn As System.Windows.Forms.Button
    Friend WithEvents logout_btn As System.Windows.Forms.Button
End Class
