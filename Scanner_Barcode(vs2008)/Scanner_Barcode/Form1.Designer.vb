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
        Me.settings_pbx = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.login_btn = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.userPass = New System.Windows.Forms.TextBox
        Me.userID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.qr_login = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.forgot_password_link = New System.Windows.Forms.LinkLabel
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.user_found_lbl = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel1.Controls.Add(Me.settings_pbx)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 53)
        '
        'settings_pbx
        '
        Me.settings_pbx.Image = CType(resources.GetObject("settings_pbx.Image"), System.Drawing.Image)
        Me.settings_pbx.Location = New System.Drawing.Point(3, 9)
        Me.settings_pbx.Name = "settings_pbx"
        Me.settings_pbx.Size = New System.Drawing.Size(41, 36)
        Me.settings_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label1.Location = New System.Drawing.Point(123, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 34)
        Me.Label1.Text = "Barcode Scanner"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(478, 48)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(3, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 26)
        Me.Label2.Text = "Login"
        '
        'login_btn
        '
        Me.login_btn.Location = New System.Drawing.Point(335, 255)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(71, 38)
        Me.login_btn.TabIndex = 6
        Me.login_btn.Text = "Login"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label6.Location = New System.Drawing.Point(156, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 26)
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(156, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 26)
        Me.Label5.Text = ":"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(50, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 26)
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(50, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 26)
        Me.Label3.Text = "User Id"
        '
        'userPass
        '
        Me.userPass.Location = New System.Drawing.Point(177, 226)
        Me.userPass.Name = "userPass"
        Me.userPass.Size = New System.Drawing.Size(208, 23)
        Me.userPass.TabIndex = 1
        '
        'userID
        '
        Me.userID.Location = New System.Drawing.Point(177, 197)
        Me.userID.Name = "userID"
        Me.userID.Size = New System.Drawing.Size(208, 23)
        Me.userID.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(219, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 20)
        Me.Label7.Text = "Or"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(134, 406)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(208, 23)
        Me.TextBox3.TabIndex = 11
        '
        'qr_login
        '
        Me.qr_login.Location = New System.Drawing.Point(335, 435)
        Me.qr_login.Name = "qr_login"
        Me.qr_login.Size = New System.Drawing.Size(71, 38)
        Me.qr_login.TabIndex = 11
        Me.qr_login.Text = "Validate"
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label8.Location = New System.Drawing.Point(195, 432)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 20)
        Me.Label8.Text = "Scan Qr Code"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Regular)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(50, 364)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 26)
        Me.Label10.Text = "UserID (QR) "
        '
        'forgot_password_link
        '
        Me.forgot_password_link.Location = New System.Drawing.Point(21, 527)
        Me.forgot_password_link.Name = "forgot_password_link"
        Me.forgot_password_link.Size = New System.Drawing.Size(114, 20)
        Me.forgot_password_link.TabIndex = 13
        Me.forgot_password_link.Text = "Forgot Password"
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid1.Location = New System.Drawing.Point(37, 174)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(397, 131)
        Me.DataGrid1.TabIndex = 19
        '
        'DataGrid2
        '
        Me.DataGrid2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid2.Location = New System.Drawing.Point(37, 339)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(397, 153)
        Me.DataGrid2.TabIndex = 20
        '
        'user_found_lbl
        '
        Me.user_found_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.user_found_lbl.Location = New System.Drawing.Point(195, 255)
        Me.user_found_lbl.Name = "user_found_lbl"
        Me.user_found_lbl.Size = New System.Drawing.Size(120, 20)
        Me.user_found_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label9.Location = New System.Drawing.Point(37, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(397, 36)
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(478, 615)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.user_found_lbl)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.qr_login)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.forgot_password_link)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.userPass)
        Me.Controls.Add(Me.userID)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents userPass As System.Windows.Forms.TextBox
    Friend WithEvents userID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents login_btn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents qr_login As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents forgot_password_link As System.Windows.Forms.LinkLabel
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents settings_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents user_found_lbl As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
