﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.dropdown_pbx = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.dropdown_pnl = New System.Windows.Forms.Panel
        Me.exit_btn = New System.Windows.Forms.Button
        Me.info_btn = New System.Windows.Forms.Button
        Me.stg_btn = New System.Windows.Forms.Button
        Me.home_btn = New System.Windows.Forms.Button
        Me.login_btn = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.pass_txtbx = New System.Windows.Forms.TextBox
        Me.user_txtbx = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.qr_txtbx = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.forgot_password_link = New System.Windows.Forms.LinkLabel
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.user_found_lbl = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.pass_found_lbl = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.dropdown_pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Controls.Add(Me.Label1)
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
        Me.Label1.Location = New System.Drawing.Point(87, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 47)
        Me.Label1.Text = "Barcode Scanner"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 47)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(13, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 43)
        Me.Label2.Text = "Login"
        '
        'dropdown_pnl
        '
        Me.dropdown_pnl.BackColor = System.Drawing.Color.White
        Me.dropdown_pnl.Controls.Add(Me.exit_btn)
        Me.dropdown_pnl.Controls.Add(Me.info_btn)
        Me.dropdown_pnl.Controls.Add(Me.stg_btn)
        Me.dropdown_pnl.Controls.Add(Me.home_btn)
        Me.dropdown_pnl.Controls.Add(Me.dropdown_pbx)
        Me.dropdown_pnl.Location = New System.Drawing.Point(13, 127)
        Me.dropdown_pnl.Name = "dropdown_pnl"
        Me.dropdown_pnl.Size = New System.Drawing.Size(91, 200)
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.Transparent
        Me.exit_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.exit_btn.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
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
        Me.info_btn.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
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
        Me.stg_btn.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
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
        Me.home_btn.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.home_btn.Location = New System.Drawing.Point(0, 55)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.Size = New System.Drawing.Size(91, 36)
        Me.home_btn.TabIndex = 1
        Me.home_btn.Text = "Home"
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.SystemColors.Desktop
        Me.login_btn.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.login_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.login_btn.Location = New System.Drawing.Point(355, 318)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(71, 41)
        Me.login_btn.TabIndex = 6
        Me.login_btn.Text = "Login"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular)
        Me.Label6.Location = New System.Drawing.Point(190, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 52)
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(190, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 48)
        Me.Label5.Text = ":"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(52, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 48)
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(52, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 60)
        Me.Label3.Text = "User Id"
        '
        'pass_txtbx
        '
        Me.pass_txtbx.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.pass_txtbx.Location = New System.Drawing.Point(217, 264)
        Me.pass_txtbx.Multiline = True
        Me.pass_txtbx.Name = "pass_txtbx"
        Me.pass_txtbx.Size = New System.Drawing.Size(169, 48)
        Me.pass_txtbx.TabIndex = 1
        '
        'user_txtbx
        '
        Me.user_txtbx.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.user_txtbx.Location = New System.Drawing.Point(217, 200)
        Me.user_txtbx.Multiline = True
        Me.user_txtbx.Name = "user_txtbx"
        Me.user_txtbx.Size = New System.Drawing.Size(169, 52)
        Me.user_txtbx.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.Label7.Location = New System.Drawing.Point(237, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 30)
        Me.Label7.Text = "Or"
        '
        'qr_txtbx
        '
        Me.qr_txtbx.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.qr_txtbx.Location = New System.Drawing.Point(120, 462)
        Me.qr_txtbx.Multiline = True
        Me.qr_txtbx.Name = "qr_txtbx"
        Me.qr_txtbx.Size = New System.Drawing.Size(255, 45)
        Me.qr_txtbx.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label8.Location = New System.Drawing.Point(145, 502)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(214, 45)
        Me.Label8.Text = "Scan Qr Code"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(52, 413)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 54)
        Me.Label10.Text = "QR Login"
        '
        'forgot_password_link
        '
        Me.forgot_password_link.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Underline)
        Me.forgot_password_link.Location = New System.Drawing.Point(134, 561)
        Me.forgot_password_link.Name = "forgot_password_link"
        Me.forgot_password_link.Size = New System.Drawing.Size(199, 35)
        Me.forgot_password_link.TabIndex = 13
        Me.forgot_password_link.Text = "Forgot Password"
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid1.Location = New System.Drawing.Point(38, 192)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(397, 175)
        Me.DataGrid1.TabIndex = 19
        '
        'DataGrid2
        '
        Me.DataGrid2.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid2.Location = New System.Drawing.Point(38, 403)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(397, 153)
        Me.DataGrid2.TabIndex = 20
        '
        'user_found_lbl
        '
        Me.user_found_lbl.BackColor = System.Drawing.Color.WhiteSmoke
        Me.user_found_lbl.Location = New System.Drawing.Point(392, 218)
        Me.user_found_lbl.Name = "user_found_lbl"
        Me.user_found_lbl.Size = New System.Drawing.Size(22, 28)
        Me.user_found_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label9.Location = New System.Drawing.Point(113, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(262, 22)
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pass_found_lbl
        '
        Me.pass_found_lbl.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pass_found_lbl.Location = New System.Drawing.Point(392, 278)
        Me.pass_found_lbl.Name = "pass_found_lbl"
        Me.pass_found_lbl.Size = New System.Drawing.Size(22, 31)
        Me.pass_found_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.pass_found_lbl)
        Me.Controls.Add(Me.dropdown_pnl)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.user_found_lbl)
        Me.Controls.Add(Me.qr_txtbx)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.forgot_password_link)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pass_txtbx)
        Me.Controls.Add(Me.user_txtbx)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.DataGrid2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.dropdown_pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pass_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents user_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents login_btn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents forgot_password_link As System.Windows.Forms.LinkLabel
    Friend WithEvents qr_txtbx As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents dropdown_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents user_found_lbl As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dropdown_pnl As System.Windows.Forms.Panel
    Friend WithEvents home_btn As System.Windows.Forms.Button
    Friend WithEvents info_btn As System.Windows.Forms.Button
    Friend WithEvents stg_btn As System.Windows.Forms.Button
    Friend WithEvents exit_btn As System.Windows.Forms.Button
    Friend WithEvents pass_found_lbl As System.Windows.Forms.Label

End Class
