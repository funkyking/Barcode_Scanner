Imports System.Data.SqlClient
Imports System.Data

Public Class frm
    Public conn As SqlConnection
    Public conn_temp_str As String = "Data Source=192.168.8.126,1433;Password=saadmin;User ID=sa;Initial Catalog=PCC"
    Public tmp_string As String


    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''If (conn.State = ConnectionState.Closed) Then
        ''    conn.ConnectionString = conn_temp_str
        ''    conn.Open()
        ''End If

        'Using conn As SqlConnection = New SqlConnection(conn_temp_str)
        '    conn.Open()
        '    Dim da As New SqlDataAdapter("Select * From [dbo].[Part]", conn)
        '    Dim dt As New DataTable
        '    da.Fill(dt)
        '    DataGrid1.DataSource = dt
        '    conn.Close()
        'End Using

    End Sub

    Private Sub btn_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load.Click
        Using conn As SqlConnection = New SqlConnection(conn_temp_str)
            conn.Open()
            Dim tmp As String = String.Format("Select * From [dbo].[{0}]", tmp_string)
            Dim da As New SqlDataAdapter(tmp, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGrid1.DataSource = dt
            conn.Close()
        End Using
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        tmp_string = ComboBox1.GetItemText(ComboBox1.SelectedItem)
    End Sub
End Class