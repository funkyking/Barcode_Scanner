﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.tableList_cmbx = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.loadTables_btn = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Add_Btn = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.conn_Btn = New System.Windows.Forms.Button
        Me.db_add_tbx = New System.Windows.Forms.TextBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.home_pbx = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.Text = "Database"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.Panel1.Controls.Add(Me.Button3)
=======
>>>>>>> 0d6055eed53b1b3304b77c91fb6f11866c034b19
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tableList_cmbx)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.loadTables_btn)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Add_Btn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.conn_Btn)
        Me.Panel1.Controls.Add(Me.db_add_tbx)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 83)
        Me.Panel1.Name = "Panel1"
<<<<<<< HEAD
        Me.Panel1.Size = New System.Drawing.Size(228, 480)
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkBlue
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(16, 419)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 40)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "M Table"
=======
        Me.Panel1.Size = New System.Drawing.Size(228, 515)
>>>>>>> 0d6055eed53b1b3304b77c91fb6f11866c034b19
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Button1.ForeColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.Button1.Location = New System.Drawing.Point(149, 419)
=======
        Me.Button1.Location = New System.Drawing.Point(74, 373)
>>>>>>> 0d6055eed53b1b3304b77c91fb6f11866c034b19
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 40)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Log File"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(7, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.Text = "Tables"
        '
        'tableList_cmbx
        '
        Me.tableList_cmbx.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular)
        Me.tableList_cmbx.Items.Add("Data Source=192.168.8.126,1433;Password=saadmin;User ID=sa;Initial Catalog=PCC")
        Me.tableList_cmbx.Items.Add("Data Source=DESKTOP-P9BJNAI;Password=saadmin;User ID=sa;Initial Catalog=PCC")
        Me.tableList_cmbx.Location = New System.Drawing.Point(7, 338)
        Me.tableList_cmbx.Name = "tableList_cmbx"
        Me.tableList_cmbx.Size = New System.Drawing.Size(211, 29)
        Me.tableList_cmbx.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Underline)
        Me.Label4.Location = New System.Drawing.Point(7, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.Text = "Data Tables"
        '
        'loadTables_btn
        '
        Me.loadTables_btn.BackColor = System.Drawing.Color.SteelBlue
        Me.loadTables_btn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.loadTables_btn.ForeColor = System.Drawing.Color.White
        Me.loadTables_btn.Location = New System.Drawing.Point(149, 373)
        Me.loadTables_btn.Name = "loadTables_btn"
        Me.loadTables_btn.Size = New System.Drawing.Size(69, 40)
        Me.loadTables_btn.TabIndex = 16
        Me.loadTables_btn.Text = "Load"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(10, 102)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 38)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Remove"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(7, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 20)
        Me.Label3.Text = "Choose a Database"
        '
        'Add_Btn
        '
        Me.Add_Btn.BackColor = System.Drawing.Color.SteelBlue
        Me.Add_Btn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Add_Btn.ForeColor = System.Drawing.Color.White
        Me.Add_Btn.Location = New System.Drawing.Point(149, 225)
        Me.Add_Btn.Name = "Add_Btn"
        Me.Add_Btn.Size = New System.Drawing.Size(69, 40)
        Me.Add_Btn.TabIndex = 6
        Me.Add_Btn.Text = "Add"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(10, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 19)
        Me.Label2.Text = "New Database"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.ComboBox1.Items.Add("Data Source=192.169.42.100,1433;Password=saadmin;User ID=sa;Initial Catalog=PCC")
        Me.ComboBox1.Items.Add("Data Source=192.168.8.126,1433;Password=saadmin;User ID=sa;Initial Catalog=PCC")
        Me.ComboBox1.Items.Add("Data Source=DESKTOP-P9BJNAI;Password=saadmin;User ID=sa;Initial Catalog=PCC")
<<<<<<< HEAD
        Me.ComboBox1.Items.Add("Data Source=DESKTOP-601UU1V\SQLEXPRESS2014;Password=saadmin;User ID=sa;Initial Ca" & _
                "talog=PCC")
=======
>>>>>>> 0d6055eed53b1b3304b77c91fb6f11866c034b19
        Me.ComboBox1.Location = New System.Drawing.Point(7, 70)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(211, 26)
        Me.ComboBox1.TabIndex = 4
        '
        'conn_Btn
        '
        Me.conn_Btn.BackColor = System.Drawing.Color.SteelBlue
        Me.conn_Btn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.conn_Btn.ForeColor = System.Drawing.Color.White
        Me.conn_Btn.Location = New System.Drawing.Point(131, 102)
        Me.conn_Btn.Name = "conn_Btn"
        Me.conn_Btn.Size = New System.Drawing.Size(87, 38)
        Me.conn_Btn.TabIndex = 3
        Me.conn_Btn.Text = "Connect"
        '
        'db_add_tbx
        '
        Me.db_add_tbx.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.db_add_tbx.Location = New System.Drawing.Point(10, 179)
        Me.db_add_tbx.Multiline = True
        Me.db_add_tbx.Name = "db_add_tbx"
        Me.db_add_tbx.Size = New System.Drawing.Size(208, 40)
        Me.db_add_tbx.TabIndex = 1
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGrid1.Location = New System.Drawing.Point(237, 83)
        Me.DataGrid1.Name = "DataGrid1"
<<<<<<< HEAD
        Me.DataGrid1.Size = New System.Drawing.Size(240, 480)
=======
        Me.DataGrid1.Size = New System.Drawing.Size(240, 515)
>>>>>>> 0d6055eed53b1b3304b77c91fb6f11866c034b19
        Me.DataGrid1.TabIndex = 5
        '
        'home_pbx
        '
        Me.home_pbx.BackColor = System.Drawing.Color.White
        Me.home_pbx.Image = CType(resources.GetObject("home_pbx.Image"), System.Drawing.Image)
        Me.home_pbx.Location = New System.Drawing.Point(3, 17)
        Me.home_pbx.Name = "home_pbx"
        Me.home_pbx.Size = New System.Drawing.Size(60, 60)
        Me.home_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.home_pbx)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents db_add_tbx As System.Windows.Forms.TextBox
    Friend WithEvents conn_Btn As System.Windows.Forms.Button
    Friend WithEvents Add_Btn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents home_pbx As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents loadTables_btn As System.Windows.Forms.Button
    Friend WithEvents tableList_cmbx As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
