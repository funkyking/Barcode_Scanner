Imports System.Data.SqlClient
Imports System.Data

Public Class Settings

    Shared table_list As String
    Shared conn As SqlConnection

    'Add Sql Connection
    Private Sub Add_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_Btn.Click
        Try
            Dim temp As String

            If (db_add_tbx.Text IsNot Nothing) Then
                temp = db_add_tbx.Text
                ComboBox1.Items.Add(temp)
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Remove Sql Connection
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If (ComboBox1.SelectedIndex) Then
                ComboBox1.Items.Remove(ComboBox1.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Connect to selected sql connection
    Private Sub conn_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles conn_Btn.Click
        Try
            If (ComboBox1.Items.Count > 0 And ComboBox1.SelectedText IsNot Nothing) Then
                'Give the the connection string throughout the application
                'conn_str = ComboBox1.SelectedText
                conn_str = ComboBox1.SelectedItem.ToString
            End If

            Using conn = New SqlConnection(conn_str)
                conn.Open()

                If (conn.State = ConnectionState.Open) Then
                    Dim query As String = "Select name FROM sys.tables"
                    Dim da As New SqlDataAdapter(query, conn)
                    Using ds = New DataSet()
                        da.Fill(ds)
                        With tableList_cmbx
                            .DataSource = ds.Tables(0)
                            .DisplayMember = "name"
                            .ValueMember = "name"
                        End With
                    End Using
                Else
                    MsgBox("Database Not found / Inactive")
                End If
            End Using
            DatabaseName = String.Format("Connected to = [{0}]", conn_str)
            Form1.Label9.Text = DatabaseName
        Catch ex As Exception
        End Try
    End Sub

    'load tables
    Private Sub loadTables_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadTables_btn.Click
        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                Dim query As String = String.Format("Select * From [dbo].[{0}]", tableList_cmbx.GetItemText(tableList_cmbx.SelectedItem))
                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable
                da.Fill(dt)
                DataGrid1.DataSource = dt
                conn.Close()
            End Using
        Catch ex As Exception
        End Try
    End Sub

    'home
    Private Sub home_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home_pbx.Click
        Me.Close()
    End Sub
End Class