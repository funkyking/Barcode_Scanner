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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorkCentre_Topup_Scan_Part_5))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.mdl_lbl = New System.Windows.Forms.Label
        Me.sub_lbl = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cont_btn = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.userInput = New System.Windows.Forms.TextBox
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.username = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.rescan_pbx = New System.Windows.Forms.PictureBox
        Me.back_pbx = New System.Windows.Forms.PictureBox
        Me.dropdown_pnl = New System.Windows.Forms.Panel
        Me.exit_btn = New System.Windows.Forms.Button
        Me.info_btn = New System.Windows.Forms.Button
        Me.stg_btn = New System.Windows.Forms.Button
        Me.home_btn = New System.Windows.Forms.Button
        Me.dropdown_pbx = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.dropdown_pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 69)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlText
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlText
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(427, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 26.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label1.Location = New System.Drawing.Point(98, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 44)
        Me.Label1.Text = "Barcode Scanner"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular)
        Me.Label13.Location = New System.Drawing.Point(214, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 45)
        Me.Label13.Text = "|"
        '
        'mdl_lbl
        '
        Me.mdl_lbl.BackColor = System.Drawing.Color.MediumAquamarine
        Me.mdl_lbl.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Regular)
        Me.mdl_lbl.Location = New System.Drawing.Point(244, 8)
        Me.mdl_lbl.Name = "mdl_lbl"
        Me.mdl_lbl.Size = New System.Drawing.Size(236, 38)
        Me.mdl_lbl.Text = "Model ID [0]"
        Me.mdl_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'sub_lbl
        '
        Me.sub_lbl.BackColor = System.Drawing.Color.MediumAquamarine
        Me.sub_lbl.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Regular)
        Me.sub_lbl.Location = New System.Drawing.Point(3, 8)
        Me.sub_lbl.Name = "sub_lbl"
        Me.sub_lbl.Size = New System.Drawing.Size(185, 38)
        Me.sub_lbl.Text = "Subline [0]"
        Me.sub_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.mdl_lbl)
        Me.Panel3.Controls.Add(Me.sub_lbl)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 69)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(480, 56)
        '
        'cont_btn
        '
        Me.cont_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.cont_btn.ForeColor = System.Drawing.Color.White
        Me.cont_btn.Location = New System.Drawing.Point(202, 604)
        Me.cont_btn.Name = "cont_btn"
        Me.cont_btn.Size = New System.Drawing.Size(68, 22)
        Me.cont_btn.TabIndex = 25
        Me.cont_btn.Text = "Continue"
        Me.cont_btn.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 34.0!, System.Drawing.FontStyle.Underline)
        Me.Label5.Location = New System.Drawing.Point(17, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(219, 61)
        Me.Label5.Text = "Scan Part"
        '
        'userInput
        '
        Me.userInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.userInput.Font = New System.Drawing.Font("Leelawadee UI Semilight", 36.0!, System.Drawing.FontStyle.Regular)
        Me.userInput.Location = New System.Drawing.Point(13, 182)
        Me.userInput.Name = "userInput"
        Me.userInput.Size = New System.Drawing.Size(409, 70)
        Me.userInput.TabIndex = 23
        '
        'DataGrid2
        '
        Me.DataGrid2.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid2.Location = New System.Drawing.Point(12, 193)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(456, 389)
        Me.DataGrid2.TabIndex = 26
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.username.Location = New System.Drawing.Point(353, 129)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(122, 35)
        Me.username.Text = "[username]"
        Me.username.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label6.Location = New System.Drawing.Point(257, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 35)
        Me.Label6.Text = "User_ID :"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.rescan_pbx)
        Me.Panel4.Controls.Add(Me.back_pbx)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.userInput)
        Me.Panel4.Location = New System.Drawing.Point(25, 208)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(430, 363)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.ForeColor = System.Drawing.Color.Magenta
        Me.Label2.Location = New System.Drawing.Point(134, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.Text = "✓ TopUp Success"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rescan_pbx
        '
        Me.rescan_pbx.BackColor = System.Drawing.SystemColors.Window
        Me.rescan_pbx.Image = CType(resources.GetObject("rescan_pbx.Image"), System.Drawing.Image)
        Me.rescan_pbx.Location = New System.Drawing.Point(365, 199)
        Me.rescan_pbx.Name = "rescan_pbx"
        Me.rescan_pbx.Size = New System.Drawing.Size(53, 33)
        Me.rescan_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'back_pbx
        '
        Me.back_pbx.BackColor = System.Drawing.Color.White
        Me.back_pbx.Image = CType(resources.GetObject("back_pbx.Image"), System.Drawing.Image)
        Me.back_pbx.Location = New System.Drawing.Point(160, 295)
        Me.back_pbx.Name = "back_pbx"
        Me.back_pbx.Size = New System.Drawing.Size(115, 55)
        Me.back_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'dropdown_pnl
        '
        Me.dropdown_pnl.BackColor = System.Drawing.Color.White
        Me.dropdown_pnl.Controls.Add(Me.exit_btn)
        Me.dropdown_pnl.Controls.Add(Me.info_btn)
        Me.dropdown_pnl.Controls.Add(Me.stg_btn)
        Me.dropdown_pnl.Controls.Add(Me.home_btn)
        Me.dropdown_pnl.Controls.Add(Me.dropdown_pbx)
        Me.dropdown_pnl.Location = New System.Drawing.Point(12, 132)
        Me.dropdown_pnl.Name = "dropdown_pnl"
        Me.dropdown_pnl.Size = New System.Drawing.Size(91, 200)
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.exit_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.exit_btn.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.exit_btn.Location = New System.Drawing.Point(0, 163)
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
        Me.info_btn.Location = New System.Drawing.Point(0, 127)
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
        Me.stg_btn.Location = New System.Drawing.Point(0, 91)
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
        Me.home_btn.Location = New System.Drawing.Point(0, 55)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.Size = New System.Drawing.Size(91, 36)
        Me.home_btn.TabIndex = 1
        Me.home_btn.Text = "Home"
        '
        'dropdown_pbx
        '
        Me.dropdown_pbx.BackColor = System.Drawing.Color.White
        Me.dropdown_pbx.Dock = System.Windows.Forms.DockStyle.Top
        Me.dropdown_pbx.Image = CType(resources.GetObject("dropdown_pbx.Image"), System.Drawing.Image)
        Me.dropdown_pbx.Location = New System.Drawing.Point(0, 0)
        Me.dropdown_pbx.Name = "dropdown_pbx"
        Me.dropdown_pbx.Size = New System.Drawing.Size(91, 55)
        '
        'WorkCentre_Topup_Scan_Part_5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.dropdown_pnl)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.cont_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.DataGrid2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WorkCentre_Topup_Scan_Part_5"
        Me.Text = "Part Scan (TopUp)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.dropdown_pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents mdl_lbl As System.Windows.Forms.Label
    Friend WithEvents sub_lbl As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cont_btn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents userInput As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents username As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents back_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents rescan_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents dropdown_pnl As System.Windows.Forms.Panel
    Friend WithEvents exit_btn As System.Windows.Forms.Button
    Friend WithEvents info_btn As System.Windows.Forms.Button
    Friend WithEvents stg_btn As System.Windows.Forms.Button
    Friend WithEvents home_btn As System.Windows.Forms.Button
    Friend WithEvents dropdown_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
