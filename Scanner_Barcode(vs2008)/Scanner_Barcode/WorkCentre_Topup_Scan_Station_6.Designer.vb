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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.logout_pbx = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.mdl_lbl = New System.Windows.Forms.Label
        Me.cont_btn = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.userInput = New System.Windows.Forms.TextBox
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.username = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.rescan_pbx = New System.Windows.Forms.PictureBox
        Me.back_pbx = New System.Windows.Forms.PictureBox
        Me.dropdown_pnl = New System.Windows.Forms.Panel
        Me.exit_btn = New System.Windows.Forms.Button
        Me.info_btn = New System.Windows.Forms.Button
        Me.stg_btn = New System.Windows.Forms.Button
        Me.home_btn = New System.Windows.Forms.Button
        Me.dropdown_pbx = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.dropdown_pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.logout_pbx)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 58)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'logout_pbx
        '
        Me.logout_pbx.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.logout_pbx.Image = CType(resources.GetObject("logout_pbx.Image"), System.Drawing.Image)
        Me.logout_pbx.Location = New System.Drawing.Point(428, 8)
        Me.logout_pbx.Name = "logout_pbx"
        Me.logout_pbx.Size = New System.Drawing.Size(44, 36)
        Me.logout_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 26.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label1.Location = New System.Drawing.Point(132, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 47)
        Me.Label1.Text = "Barcode Scanner"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.mdl_lbl)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(478, 57)
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Regular)
        Me.Label7.Location = New System.Drawing.Point(0, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(219, 37)
        Me.Label7.Text = "TopUp Station"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(225, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 44)
        Me.Label4.Text = "|"
        '
        'mdl_lbl
        '
        Me.mdl_lbl.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Regular)
        Me.mdl_lbl.Location = New System.Drawing.Point(255, 10)
        Me.mdl_lbl.Name = "mdl_lbl"
        Me.mdl_lbl.Size = New System.Drawing.Size(220, 37)
        Me.mdl_lbl.Text = "Model ID [0]"
        Me.mdl_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 28.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(22, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(293, 76)
        Me.Label5.Text = "Scan Station"
        '
        'userInput
        '
        Me.userInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.userInput.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Regular)
        Me.userInput.Location = New System.Drawing.Point(22, 121)
        Me.userInput.Multiline = True
        Me.userInput.Name = "userInput"
        Me.userInput.Size = New System.Drawing.Size(320, 71)
        Me.userInput.TabIndex = 27
        '
        'DataGrid2
        '
        Me.DataGrid2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid2.Location = New System.Drawing.Point(24, 188)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(427, 320)
        Me.DataGrid2.TabIndex = 29
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.username.Location = New System.Drawing.Point(350, 116)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(126, 46)
        Me.username.Text = "[username]"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(255, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 46)
        Me.Label3.Text = "User_ID :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.userInput)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.rescan_pbx)
        Me.Panel3.Controls.Add(Me.back_pbx)
        Me.Panel3.Location = New System.Drawing.Point(42, 194)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(396, 290)
        '
        'rescan_pbx
        '
        Me.rescan_pbx.Image = CType(resources.GetObject("rescan_pbx.Image"), System.Drawing.Image)
        Me.rescan_pbx.Location = New System.Drawing.Point(348, 142)
        Me.rescan_pbx.Name = "rescan_pbx"
        Me.rescan_pbx.Size = New System.Drawing.Size(36, 30)
        Me.rescan_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'back_pbx
        '
        Me.back_pbx.Image = CType(resources.GetObject("back_pbx.Image"), System.Drawing.Image)
        Me.back_pbx.Location = New System.Drawing.Point(134, 209)
        Me.back_pbx.Name = "back_pbx"
        Me.back_pbx.Size = New System.Drawing.Size(115, 52)
        Me.back_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'dropdown_pnl
        '
        Me.dropdown_pnl.BackColor = System.Drawing.Color.Transparent
        Me.dropdown_pnl.Controls.Add(Me.exit_btn)
        Me.dropdown_pnl.Controls.Add(Me.info_btn)
        Me.dropdown_pnl.Controls.Add(Me.stg_btn)
        Me.dropdown_pnl.Controls.Add(Me.home_btn)
        Me.dropdown_pnl.Controls.Add(Me.dropdown_pbx)
        Me.dropdown_pnl.Location = New System.Drawing.Point(13, 128)
        Me.dropdown_pnl.Name = "dropdown_pnl"
        Me.dropdown_pnl.Size = New System.Drawing.Size(91, 181)
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.exit_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.exit_btn.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.exit_btn.Location = New System.Drawing.Point(0, 144)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(91, 36)
        Me.exit_btn.TabIndex = 6
        Me.exit_btn.Text = "Exit"
        '
        'info_btn
        '
        Me.info_btn.BackColor = System.Drawing.Color.Transparent
        Me.info_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.info_btn.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.info_btn.Location = New System.Drawing.Point(0, 108)
        Me.info_btn.Name = "info_btn"
        Me.info_btn.Size = New System.Drawing.Size(91, 36)
        Me.info_btn.TabIndex = 4
        Me.info_btn.Text = "Info"
        '
        'stg_btn
        '
        Me.stg_btn.BackColor = System.Drawing.Color.Transparent
        Me.stg_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.stg_btn.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.stg_btn.Location = New System.Drawing.Point(0, 72)
        Me.stg_btn.Name = "stg_btn"
        Me.stg_btn.Size = New System.Drawing.Size(91, 36)
        Me.stg_btn.TabIndex = 3
        Me.stg_btn.Text = "Settings"
        '
        'home_btn
        '
        Me.home_btn.BackColor = System.Drawing.Color.Transparent
        Me.home_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.home_btn.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.home_btn.Location = New System.Drawing.Point(0, 36)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.Size = New System.Drawing.Size(91, 36)
        Me.home_btn.TabIndex = 1
        Me.home_btn.Text = "Home"
        '
        'dropdown_pbx
        '
        Me.dropdown_pbx.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dropdown_pbx.Dock = System.Windows.Forms.DockStyle.Top
        Me.dropdown_pbx.Image = CType(resources.GetObject("dropdown_pbx.Image"), System.Drawing.Image)
        Me.dropdown_pbx.Location = New System.Drawing.Point(0, 0)
        Me.dropdown_pbx.Name = "dropdown_pbx"
        Me.dropdown_pbx.Size = New System.Drawing.Size(91, 36)
        '
        'WorkCentre_Topup_Scan_Station_6
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(478, 615)
        Me.Controls.Add(Me.dropdown_pnl)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cont_btn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGrid2)
        Me.Name = "WorkCentre_Topup_Scan_Station_6"
        Me.Text = "Station Scan (TopUp)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.dropdown_pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cont_btn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents userInput As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents username As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents logout_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents back_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents rescan_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents dropdown_pnl As System.Windows.Forms.Panel
    Friend WithEvents exit_btn As System.Windows.Forms.Button
    Friend WithEvents info_btn As System.Windows.Forms.Button
    Friend WithEvents stg_btn As System.Windows.Forms.Button
    Friend WithEvents home_btn As System.Windows.Forms.Button
    Friend WithEvents dropdown_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mdl_lbl As System.Windows.Forms.Label
End Class
