<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frm
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
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.btn_load = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGrid1.Location = New System.Drawing.Point(14, 67)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(443, 516)
        Me.DataGrid1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.Add("ActivityLog")
        Me.ComboBox1.Items.Add("Line")
        Me.ComboBox1.Items.Add("LineDetail")
        Me.ComboBox1.Items.Add("LineGroup")
        Me.ComboBox1.Items.Add("MasterBOM")
        Me.ComboBox1.Items.Add("MasterModel")
        Me.ComboBox1.Items.Add("MasterPartList")
        Me.ComboBox1.Items.Add("MasterStation")
        Me.ComboBox1.Items.Add("Model")
        Me.ComboBox1.Items.Add("Part")
        Me.ComboBox1.Items.Add("Schedule")
        Me.ComboBox1.Items.Add("ScheduleDetail")
        Me.ComboBox1.Items.Add("UserGroup")
        Me.ComboBox1.Items.Add("UserGroupFunction")
        Me.ComboBox1.Items.Add("UserMaster")
        Me.ComboBox1.Location = New System.Drawing.Point(14, 17)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 23)
        Me.ComboBox1.TabIndex = 1
        '
        'btn_load
        '
        Me.btn_load.Location = New System.Drawing.Point(150, 17)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(70, 23)
        Me.btn_load.TabIndex = 2
        Me.btn_load.Text = "Load"
        '
        'frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(655, 455)
        Me.Controls.Add(Me.btn_load)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "frm"
        Me.Text = "frm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btn_load As System.Windows.Forms.Button
End Class
