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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Identify_Model_2))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.logout_pbx = New System.Windows.Forms.PictureBox
        Me.username = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.model_ID = New System.Windows.Forms.TextBox
        Me.Cont_btn = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.rescan_pbx = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.dropdown_pnl = New System.Windows.Forms.Panel
        Me.exit_btn = New System.Windows.Forms.Button
        Me.info_btn = New System.Windows.Forms.Button
        Me.stg_btn = New System.Windows.Forms.Button
        Me.dropdown_pbx = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.dropdown_pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.logout_pbx)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 69)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 26.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label1.Location = New System.Drawing.Point(97, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 49)
        Me.Label1.Text = "Barcode Scanner"
        '
        'logout_pbx
        '
        Me.logout_pbx.BackColor = System.Drawing.SystemColors.ControlText
        Me.logout_pbx.Image = CType(resources.GetObject("logout_pbx.Image"), System.Drawing.Image)
        Me.logout_pbx.Location = New System.Drawing.Point(427, 12)
        Me.logout_pbx.Name = "logout_pbx"
        Me.logout_pbx.Size = New System.Drawing.Size(50, 50)
        Me.logout_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.username.ForeColor = System.Drawing.Color.Black
        Me.username.Location = New System.Drawing.Point(346, 134)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(122, 34)
        Me.username.Text = "[username]"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 56)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 32)
        Me.Label2.Text = "Scan Line && Model"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 34.0!, System.Drawing.FontStyle.Underline)
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(401, 68)
        Me.Label3.Text = "Scan Line && Model"
        '
        'model_ID
        '
        Me.model_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.model_ID.Font = New System.Drawing.Font("Tahoma", 26.0!, System.Drawing.FontStyle.Regular)
        Me.model_ID.Location = New System.Drawing.Point(7, 111)
        Me.model_ID.Multiline = True
        Me.model_ID.Name = "model_ID"
        Me.model_ID.Size = New System.Drawing.Size(409, 144)
        Me.model_ID.TabIndex = 0
        '
        'Cont_btn
        '
        Me.Cont_btn.BackColor = System.Drawing.Color.SteelBlue
        Me.Cont_btn.ForeColor = System.Drawing.Color.White
        Me.Cont_btn.Location = New System.Drawing.Point(197, 610)
        Me.Cont_btn.Name = "Cont_btn"
        Me.Cont_btn.Size = New System.Drawing.Size(65, 16)
        Me.Cont_btn.TabIndex = 10
        Me.Cont_btn.Text = "Continue"
        Me.Cont_btn.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.rescan_pbx)
        Me.Panel3.Controls.Add(Me.model_ID)
        Me.Panel3.Location = New System.Drawing.Point(25, 219)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(429, 322)
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular)
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label8.Location = New System.Drawing.Point(8, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(396, 32)
        Me.Label8.Text = "Scan the Barcode on Model"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rescan_pbx
        '
        Me.rescan_pbx.BackColor = System.Drawing.SystemColors.Window
        Me.rescan_pbx.Image = CType(resources.GetObject("rescan_pbx.Image"), System.Drawing.Image)
        Me.rescan_pbx.Location = New System.Drawing.Point(351, 174)
        Me.rescan_pbx.Name = "rescan_pbx"
        Me.rescan_pbx.Size = New System.Drawing.Size(53, 33)
        Me.rescan_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(246, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 34)
        Me.Label5.Text = "User_ID :"
        '
        'DataGrid1
        '
        Me.DataGrid1.BackColor = System.Drawing.Color.White
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid1.Location = New System.Drawing.Point(12, 203)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGrid1.Size = New System.Drawing.Size(453, 385)
        Me.DataGrid1.TabIndex = 11
        '
        'dropdown_pnl
        '
        Me.dropdown_pnl.BackColor = System.Drawing.Color.White
        Me.dropdown_pnl.Controls.Add(Me.exit_btn)
        Me.dropdown_pnl.Controls.Add(Me.info_btn)
        Me.dropdown_pnl.Controls.Add(Me.stg_btn)
        Me.dropdown_pnl.Controls.Add(Me.dropdown_pbx)
        Me.dropdown_pnl.Location = New System.Drawing.Point(12, 134)
        Me.dropdown_pnl.Name = "dropdown_pnl"
        Me.dropdown_pnl.Size = New System.Drawing.Size(91, 164)
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.exit_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.exit_btn.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.exit_btn.Location = New System.Drawing.Point(0, 127)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(91, 36)
        Me.exit_btn.TabIndex = 6
        Me.exit_btn.Text = "Exit"
        '
        'info_btn
        '
        Me.info_btn.BackColor = System.Drawing.Color.Transparent
        Me.info_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.info_btn.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.info_btn.Location = New System.Drawing.Point(0, 91)
        Me.info_btn.Name = "info_btn"
        Me.info_btn.Size = New System.Drawing.Size(91, 36)
        Me.info_btn.TabIndex = 4
        Me.info_btn.Text = "Info"
        '
        'stg_btn
        '
        Me.stg_btn.BackColor = System.Drawing.Color.Transparent
        Me.stg_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.stg_btn.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.stg_btn.Location = New System.Drawing.Point(0, 55)
        Me.stg_btn.Name = "stg_btn"
        Me.stg_btn.Size = New System.Drawing.Size(91, 36)
        Me.stg_btn.TabIndex = 3
        Me.stg_btn.Text = "Settings"
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
        'Identify_Model_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.dropdown_pnl)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cont_btn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Identify_Model_2"
        Me.Text = "Scan Line & Model"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.dropdown_pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents model_ID As System.Windows.Forms.TextBox
    Friend WithEvents Cont_btn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents logout_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents rescan_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents dropdown_pnl As System.Windows.Forms.Panel
    Friend WithEvents exit_btn As System.Windows.Forms.Button
    Friend WithEvents info_btn As System.Windows.Forms.Button
    Friend WithEvents stg_btn As System.Windows.Forms.Button
    Friend WithEvents dropdown_pbx As System.Windows.Forms.PictureBox


End Class
