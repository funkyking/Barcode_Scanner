Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Settings

    Shared table_list As String
    Shared conn As SqlConnection
    Public ConnectionId As String = ""
    Public showOnlyConnPnl As Boolean

#Region "Load"

    'Loads Up Important Data (eg. Database)
    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'If the Flag is True (Then Dont Show the Rest only Connection Settings)
            If showOnlyConnPnl = True Then
                Admin_Pnl.Visible = False
                DataGrid1.Visible = False
                userID_lbl.Visible = False
            Else
                userID_lbl.Text = "User : " + EmployeeName + UserID
                logTable = createLogBook()
            End If

            'If conn_str is already established, Then this will display all the tables Automatically
            Connection_Flag = LoadUpTheComboBoxTables()
            ConnStatusFlagLblDis()

            'Gui Area
            ''Remove Part Flag
            rmPartFlag_Sub()

        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Button"

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
    Public Sub conn_Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles conn_Btn.Click
        Try
            If (ComboBox1.SelectedItem IsNot Nothing) Then
                If (ComboBox1.Items.Count > 0 And ComboBox1.SelectedText IsNot Nothing) Then
                    'Give the the connection string throughout the application
                    'conn_str = ComboBox1.SelectedText
                    conn_str = ComboBox1.SelectedItem.ToString
                    'conn_str = ComboBox1.Items(0)
                End If
            End If

            Connection_Flag = LoadUpTheComboBoxTables()
            ConnStatusFlagLblDis()
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

    'Display The finished Scanned Topup Sessions
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            logTable = updateLogBook(logTable)
            DataGrid1.DataSource = logTable
        Catch ex As Exception
        End Try
    End Sub

    'Check,Part,Stn,Mdl,Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            checkTheDb = chckQry()
            DataGrid1.DataSource = checkTheDb
        Catch ex As Exception
        End Try
    End Sub

    'This Enables user(Admin Only) for the Option to remove part or not
    Private Sub rmPartFlag_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rmPartFlag_btn.Click
        If (rmPartFlag_btn.Text = "Inactive") Then
            removePart_Flag = True
        Else
            removePart_Flag = False
        End If
        rmPartFlag_Sub()
    End Sub

#End Region

#Region "Ui"

    'Simple sub that changes the colour of the Remove Part button
    Private Sub rmPartFlag_Sub()
        If (removePart_Flag = True) Then
            rmPartFlag_btn.Text = "Active"
            rmPartFlag_btn.BackColor = Color.Green()
        Else
            rmPartFlag_btn.Text = "Inactive"
            rmPartFlag_btn.BackColor = Color.Gray()
        End If
    End Sub

    'Just a Simple Flag Indicator if A Connection is Established or Not
    'If False the label will display "Not Active"
    Private Sub ConnStatusFlagLblDis()
        Try
            If (Connection_Flag = True) Then
                dbStatus_lbl.Text = "Active"
                dbStatus_lbl.BackColor = Color.Green()
            Else
                dbStatus_lbl.Text = "Not Active"
                dbStatus_lbl.BackColor = Color.Crimson()
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Functions"

    'Automatically Detects if User is Already Connected to A Database
    'If The are Connected, Then it will Display all the Tables Accordingly.
    Private Function LoadUpTheComboBoxTables() As Boolean
        Dim Result As Boolean = False
        Try
            If (conn_str IsNot Nothing) Then
                Using conn = New SqlConnection(conn_str)
                    conn.Open()
                    If (conn.State = ConnectionState.Open) Then
                        Dim query As String = "Select name FROM sys.tables"
                        Dim da As New SqlDataAdapter(query, conn)
                        Using ds = New DataSet()
                            da.Fill(ds)
                            If (ds.Tables.Count > 0) Then
                                With tableList_cmbx
                                    .DataSource = ds.Tables(0)
                                    .DisplayMember = "name"
                                    .ValueMember = "name"
                                End With
                            Else
                                MsgBox("Connection Succeed. But The Database is Empty")
                            End If

                            'Display Connection Information on Login
                            DatabaseName = conn_str
                            Dim temp As String = DatabaseName
                            Dim es As Integer = temp.IndexOf("=") + 1
                            Dim eq As Integer = temp.IndexOf(";")
                            ConnectionId = temp.Substring(es, eq - es)
                            Form1.Label9.Text = "Connected = " + ConnectionId
                            Result = True
                        End Using
                    Else
                        MsgBox("Database Not found / Inactive")
                        Result = False
                    End If
                End Using
            End If
        Catch ex As Exception
            Result = False
        End Try
        Return Result
    End Function

#End Region


End Class