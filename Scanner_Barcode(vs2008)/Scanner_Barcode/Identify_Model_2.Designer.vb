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
        Me.settings_pbx = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.logout_pbx = New System.Windows.Forms.PictureBox
        Me.username = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.model_ID = New System.Windows.Forms.TextBox
        Me.Cont_btn = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.back_pbx = New System.Windows.Forms.PictureBox
        Me.rescan_pbx = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.settings_pbx)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.logout_pbx)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 53)
        '
        'settings_pbx
        '
        Me.settings_pbx.Image = CType(resources.GetObject("settings_pbx.Image"), System.Drawing.Image)
        Me.settings_pbx.Location = New System.Drawing.Point(3, 11)
        Me.settings_pbx.Name = "settings_pbx"
        Me.settings_pbx.Size = New System.Drawing.Size(41, 36)
        Me.settings_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label1.Location = New System.Drawing.Point(121, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 34)
        Me.Label1.Text = "Barcode Scanner"
        '
        'logout_pbx
        '
        Me.logout_pbx.Image = CType(resources.GetObject("logout_pbx.Image"), System.Drawing.Image)
        Me.logout_pbx.Location = New System.Drawing.Point(431, 11)
        Me.logout_pbx.Name = "logout_pbx"
        Me.logout_pbx.Size = New System.Drawing.Size(44, 36)
        Me.logout_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'username
        '
        Me.username.ForeColor = System.Drawing.Color.Black
        Me.username.Location = New System.Drawing.Point(386, 113)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(89, 20)
        Me.username.Text = "[username]"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(478, 57)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 26)
        Me.Label2.Text = "Scan Line && Model"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 23)
        Me.Label3.Text = "Scan Line && Model"
        '
        'model_ID
        '
        Me.model_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.model_ID.Location = New System.Drawing.Point(94, 88)
        Me.model_ID.Name = "model_ID"
        Me.model_ID.Size = New System.Drawing.Size(210, 23)
        Me.model_ID.TabIndex = 0
        '
        'Cont_btn
        '
        Me.Cont_btn.BackColor = System.Drawing.Color.SteelBlue
        Me.Cont_btn.ForeColor = System.Drawing.Color.White
        Me.Cont_btn.Location = New System.Drawing.Point(198, 577)
        Me.Cont_btn.Name = "Cont_btn"
        Me.Cont_btn.Size = New System.Drawing.Size(65, 16)
        Me.Cont_btn.TabIndex = 10
        Me.Cont_btn.Text = "Continue"
        Me.Cont_btn.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.back_pbx)
        Me.Panel3.Controls.Add(Me.rescan_pbx)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.model_ID)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(44, 230)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(386, 209)
        '
        'back_pbx
        '
        Me.back_pbx.Image = CType(resources.GetObject("back_pbx.Image"), System.Drawing.Image)
        Me.back_pbx.Location = New System.Drawing.Point(181, 149)
        Me.back_pbx.Name = "back_pbx"
        Me.back_pbx.Size = New System.Drawing.Size(38, 39)
        Me.back_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'rescan_pbx
        '
        Me.rescan_pbx.Image = CType(resources.GetObject("rescan_pbx.Image"), System.Drawing.Image)
        Me.rescan_pbx.Location = New System.Drawing.Point(310, 88)
        Me.rescan_pbx.Name = "rescan_pbx"
        Me.rescan_pbx.Size = New System.Drawing.Size(28, 23)
        Me.rescan_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label8.Location = New System.Drawing.Point(112, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 20)
        Me.Label8.Text = "Scan the Barcode on Model"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(323, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.Text = "User_ID :"
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.Location = New System.Drawing.Point(31, 214)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(409, 239)
        Me.DataGrid1.TabIndex = 11
        '
        'Identify_Model_2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(478, 615)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cont_btn)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "Identify_Model_2"
        Me.Text = "Identify_Model_2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
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
    Friend WithEvents settings_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents rescan_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents back_pbx As System.Windows.Forms.PictureBox


End Class
