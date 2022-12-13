Imports System.Data.SqlClient
Imports System.Data

Public Class Form1


#Region "Load"

    Dim conn As SqlConnection
    Dim cmd As SqlCommand

    'Remove from memory stack
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            Me.Dispose()
            Me.Close()
            GC.Collect()
        Catch ex As Exception
        End Try
    End Sub

    'Displays database name (connection to)
    Private Sub Form1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        Label9.Text = DatabaseName
    End Sub

    'form load (start)
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dropdown_pnl.Size = New Size(76, 36)
            home_btn.Visible = False
            userID.Focus()
            If (conn_str = "null") Then
                Label9.Text = "Not Connected to Database"
            Else
                Label9.Text = DatabaseName
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Login"

    'login_btn event
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click

        conn = New SqlConnection(conn_str)
        'Declaring the Column and Row to check if variables exist
        Dim query As String = "Select * From dbo.UserMaster where UserName = @UserName and Password = @Password"
        conn.Open()
        cmd = New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@UserName", userID.Text)
        cmd.Parameters.AddWithValue("@Password", userPass.Text)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        If dr.Read = True Then
            'user_found_lbl.Text = "✓"
            Dim _Identify_Model As New Identify_Model_2
            _Identify_Model.user = userID.Text
            _Identify_Model.Show()
            Me.Hide()
        Else
            user_found_lbl.Visible = True
            user_found_lbl.Text = "Invalid Credentials"
        End If
    End Sub

    'qr_login button event
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qr_login.Click
        Dim Scan_Model_Subline As New Identify_Model_2 'Qr Code Login
        Scan_Model_Subline.Show()
        Me.Close()
    End Sub

    'auto inputs into qr code field
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = ChrW(13) Then
            MsgBox(TextBox3.Text, MsgBoxStyle.Information)
            TextBox3.Text = ""
        End If
    End Sub

#End Region

#Region "Misc"

    'Clears the chat inputbox for the user to type
    Private Sub userID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles userID.GotFocus
        user_found_lbl.Visible = False
    End Sub

    'Clears the chat inputbox for the user to type
    Private Sub userPass_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles userPass.GotFocus
        user_found_lbl.Visible = False
    End Sub

#End Region

#Region "Dropdown Menu"

    'dropdown menu
    Private Sub settings_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dropdown_pbx.Click
        Try
            If (dropdown_pnl.Size = New Size(76, 36)) Then
                dropdown_pnl.Size = New Size(76, 181)
            Else
                dropdown_pnl.Size = New Size(76, 36)
            End If
        Catch ex As Exception
        End Try
    End Sub

    'settings button
    Private Sub stg_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stg_btn.Click
        Try
            settings_pbx_Click(sender, New EventArgs())
            Dim obj As New Settings
            obj.Show()
        Catch ex As Exception
        End Try
    End Sub

    'exit button
    Private Sub exit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_btn.Click
        Try
            Me.Close()
            Me.Dispose()
            GC.Collect()
        Catch ex As Exception
        End Try
    End Sub

#End Region


End Class
