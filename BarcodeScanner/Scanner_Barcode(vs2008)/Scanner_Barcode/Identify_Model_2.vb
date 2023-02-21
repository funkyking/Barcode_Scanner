Imports System.Data.SqlClient
Imports System.Data

Public Class Identify_Model_2

    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

#Region "Main Events"

    'Continue button event
    Private Sub Cont_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cont_btn.Click
        Try
            'Scan Part
            Dim Part As New WorkCentre_Topup_Scan_Part_5
            Part.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'Once user scan it triggers this (same as scan)
    Private Sub model_ID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles model_ID.KeyDown
        Try
            Dim result As Boolean = False

            If e.KeyCode = Keys.Enter Then
                Dim userInput As String = model_ID.Text

                'Given Variable
                Dim _LineCode As String = userInput.Substring(0, userInput.IndexOf(",")) 'Subline (num)
                Dim _ModelCode As String = userInput.Split(",")(1) 'Name of the ModelCode


                'giving the data to data.vb
                LineCode = _LineCode
                ModelCode = _ModelCode

                'Finding Variables
                Dim _LineID As String = "" 'Id of the Subline
                Dim _ModelID As String = "" 'Id of the Model

                'Functions to determine if the data was found in the system
                _LineID = GetLineID(_LineCode)
                _ModelID = GetModelId(_ModelCode)
                result = Model_and_Line_Check(_ModelID, _LineID)
                result = GetScheduleID_and_ProductionId()

                'Success screen loads if all the functions used above found the variables
                'if data was not in db then this is considered failed
                If (result = True) Then
                    Dim passed As New Subline_Result_3
                    passed.BackColor = Color.LawnGreen
                    passed._top_lbl = "Station && Model" 'top Label
                    passed._bot_lbl = "Active" 'bottom label
                    passed.Show()

                    'Passing model name to data.vb
                    _ModelCode = ModelCode 'ModelName
                    _LineCode = LineCode 'Subline Station


                    ''This on Loads a database of content that is used by
                    ''Scan Part And Scan Station Forms
                    'checkTheDb = chckQry()

                    Cont_btn_Click(sender, New EventArgs())
                Else
                    model_ID.Text = ""
                    rescan_pbx_Click(sender, New EventArgs())
                    Dim failed As New Subline_Result_3
                    failed._top_lbl = "Station && Model"
                    failed.BackColor = Color.Red
                    failed._bot_lbl = "Not Active/Not Found"
                    failed.Show()
                    rescan_pbx_Click(sender, New EventArgs())

                    'Clearing the Cache
                    LineCode = Nothing
                    LineID = Nothing
                    ModelID = Nothing
                    ModelCode = Nothing
                    ScheduleID = Nothing
                    ProductionId = Nothing
                    MasterModelID = Nothing

                End If
            End If
        Catch ex As Exception
            model_ID.Text = ""
            rescan_pbx_Click(sender, New EventArgs())
            Dim failed As New Subline_Result_3
            failed._top_lbl = "Station && Model"
            failed.BackColor = Color.Red
            failed._bot_lbl = "Not Active/Not Found"
            failed.Show()
            rescan_pbx_Click(sender, New EventArgs())

            'Clearing the Cache
            LineCode = Nothing
            LineID = Nothing
            ModelID = Nothing
            ModelCode = Nothing
            ScheduleID = Nothing
            ProductionId = Nothing
            MasterModelID = Nothing
        End Try
    End Sub

    'Rescan
    Private Sub rescan_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rescan_pbx.Click
        Try

            model_ID.Text = ""
            model_ID.Refresh()
            model_ID.Focus()
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Dropdown"
    'settings 
    Private Sub stg_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stg_btn.Click
        Try
            dropdown_pbx_Click(sender, New EventArgs())
            Dim obj As New Settings
            obj.Show()
        Catch ex As Exception
        End Try
    End Sub

    'dropdown menu
    Private Sub dropdown_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dropdown_pbx.Click
        Try
            If (stg_btn.Visible = True) Then
                If (dropdown_pnl.Size = New Size(91, 55)) Then
                    dropdown_pnl.Size = New Size(91, 164)
                Else
                    dropdown_pnl.Size = New Size(91, 55)
                End If
            Else
                If (dropdown_pnl.Size = New Size(91, 55)) Then
                    dropdown_pnl.Size = New Size(91, 128)
                Else
                    dropdown_pnl.Size = New Size(91, 55)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    'exit
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

#Region "Misc"
    'load
    Private Sub Identify_Model_2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            username.Text = UserID
            'Only Admin Can see Settings
            If (UserID = "admin" Or UserID = "Admin") Then
                stg_btn.Visible = True
            Else
                stg_btn.Visible = False
            End If

            model_ID.Focus()
            dropdown_pnl.Size = New Size(91, 55)
        Catch ex As Exception
        End Try
    End Sub

    'Log out
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_pbx.Click
        Try
            Dim logout As New Form1 'Return to Login Screen (Logout)
            logout.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
#End Region

End Class