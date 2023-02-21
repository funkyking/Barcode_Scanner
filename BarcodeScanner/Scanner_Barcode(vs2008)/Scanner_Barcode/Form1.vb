Imports System.Data.SqlClient
Imports System.Data

Public Class Form1



#Region "Load"

    Dim conn As SqlConnection
    Dim cmd As SqlCommand

    'form load (start)
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Choose First connection string in settings.combobox1.items
            setSqlConn()

            'GUI effects
            dropdown_pnl.Size = New Size(91, 55)
            home_btn.Visible = False
            'qr_txtbx.Focus()
            'Check if Connected to database
            If (conn_str = "null") Then
                Label9.Text = "Not Connected to Database"
            Else
                Dim temp As String = conn_str
                Dim es As Integer = temp.IndexOf("=") + 1
                Dim eq As Integer = temp.IndexOf(";")
                Dim _temp = temp.Substring(es, eq - es)
                Label9.Text = "Connected = " + _temp
                'Label9.Text = "Connected = " + Settings.ConnectionId
                'Label9.Text = conn_str
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Clear from Stack
    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Me.Dispose()
        Me.Close()
        Settings.Close()
        Settings.Dispose()
        GC.Collect()
        Application.Exit()
    End Sub

    'Remove from memory stack
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            Me.Dispose()
            Me.Close()
            Settings.Close()
            Settings.Dispose()
            GC.Collect()
            Application.Exit()
        Catch ex As Exception
        End Try
    End Sub

    'Displays database name (connection to)
    'Private Sub Form1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
    '    qr_txtbx.Focus()
    '    Label9.Text = "Connected = " + Settings.ConnectionId
    'End Sub

#End Region

#Region "Login"

    '                           Normal Text Input Login
    
    'Checks if userName exist in database and displays a marker "✓"
    Private Sub user_txtbx_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles user_txtbx.TextChanged
        Try
            Dim res As Boolean = False
            If user_txtbx.Text = "" Then
                user_found_lbl.Text = ""
            Else
                res = checkUsername(user_txtbx.Text)

                If (res = True) Then
                    user_found_lbl.Text = "✓"

                    'Passing value to Data.vb
                    UserID = user_txtbx.Text

                    'Continue to next form
                    Dim IDM As New Identify_Model_2
                    IDM.username.Text = UserID
                    IDM.Show()
                    Me.Hide()
                Else
                    user_found_lbl.Text = "X"
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub


    'This one the old one where user needs username and password to login

    'login_btn event
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click
    '    Try
    '        Dim res As Boolean = False
    '        If (user_found_lbl.Text = "✓" And pass_found_lbl.Text = "✓") Then

    '            res = checkUser_and_Pass(user_txtbx.Text, pass_txtbx.Text)
    '            If (res = True) Then

    '                'Passing value to Data.vb
    '                UserID = user_txtbx.Text
    '                UserPass = pass_txtbx.Text

    '                'Continue to next form
    '                Dim IDM As New Identify_Model_2
    '                IDM.username.Text = UserID
    '                IDM.Show()
    '                Me.Hide()
    '            End If
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub

    ''Checks if Password exists in database and siplays a marker "✓"
    'Private Sub pass_txtbx_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles pass_txtbx.TextChanged
    '    Try
    '        Dim res As Boolean = False
    '        If (pass_txtbx.Text = "") Then
    '            pass_found_lbl.Text = ""
    '        Else
    '            res = checkUserPass(pass_txtbx.Text)

    '            If (res = True) Then
    '                pass_found_lbl.Text = "✓"
    '            Else
    '                pass_found_lbl.Text = "X"
    '            End If
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub



    ''                             Qr Scan Login Event

    ''Auto Scans the database to find if the value of the user exist then continues to the next form
    ''if data was not found then user will prompt to re-enter correct credentials
    'Private Sub qr_txtbx_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles qr_txtbx.KeyDown
    '    Try
    '        Dim res As Boolean = False
    '        Dim userInput As String = qr_txtbx.Text

    '        If (e.KeyCode = Keys.Enter And qr_txtbx.Text IsNot Nothing) Then
    '            Dim _userName As String = userInput.Substring(0, userInput.IndexOf(",")) 'Username
    '            Dim _passWord As String = userInput.Split(",")(1) 'Password

    '            res = checkUser_and_Pass(_userName, _passWord)
    '            If (res = True) Then
    '                'Pass data to Data.vb
    '                UserID = _userName
    '                UserPass = _passWord

    '                'Open New form to Continue to next task
    '                Dim IDM As New Identify_Model_2
    '                IDM.username.Text = UserID
    '                IDM.Show()
    '                Me.Hide()
    '            Else
    '                MessageBox.Show("Invalid Credentials")
    '            End If
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub


#End Region

#Region "Misc"

    'Clears the chat inputbox for the user to type
    Private Sub userID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles user_txtbx.GotFocus
        If (user_found_lbl.Text = "X") Then
            user_txtbx.Text = ""
        End If
    End Sub

    ''Clears the chat inputbox for the user to type
    'Private Sub userPass_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If (pass_found_lbl.Text = "X") Then
    '        pass_txtbx.Text = ""
    '    End If
    'End Sub

    'Removes text from the textbox qr_login
    'Private Sub qr_txtbx_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    'qr_txtbx.Text = ""
    '    Label9.Text = "Connected = " + Settings.ConnectionId
    'End Sub

#End Region

#Region "Dropdown Menu"

    'dropdown menu
    Private Sub settings_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dropdown_pbx.Click
        Try
            If (dropdown_pnl.Size = New Size(91, 55)) Then
                dropdown_pnl.Size = New Size(91, 91) '91, 200
            Else
                dropdown_pnl.Size = New Size(91, 55)
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
            Application.Exit()
        Catch ex As Exception
        End Try
    End Sub

#End Region


End Class
