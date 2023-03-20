Public Class WorkCentre_Topup_Scan_Part_5

#Region "Main"
    'Cont_btn event
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cont_btn.Click
        Try
            'Station Scan
            Dim Station As New WorkCentre_Topup_Scan_Station_6
            Station.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'Trigger scan if enter key is pressed
    Private Sub part_ID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles userInput.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then

                'This on Loads a database of content that is used by
                'Scan Part And Scan Station Forms
                checkTheDb = chckQry()

                Dim res As Boolean = False
                Dim stn_res As Boolean = False

                rm_RunningId() 'clears runningId

                'Split the String to 3 inputs
                Dim strarr As String() = userInput.Text.Split(" ")
                RunningId = strarr(0)
                PartNo = strarr(1)
                ScannedPartQty = strarr(2)

                stn_res = get_Mstncode_PrtID(PartNo)

                If (stn_res = True) Then

                    ''CheckPartID()
                    'testing = GetMasterStationID()
                    ''GetMasterStationCode()
                    ''res = CheckMasterStationCode()
                    'res = GetPartID()

                    res = CheckRunningId()
                End If
                If (res = True) Then
                    Label2.Visible = True
                    Label2.Text = "✓ Part Found"
                    userInput.Text = ""
                    'Show Passed Form
                    Dim passed As New Subline_Result_3
                    passed.BackColor = Color.LawnGreen
                    passed._top_lbl = "Station = "
                    passed._bot_lbl = station_List 'MasterStationCode 'String.Format("{0}", temp)
                    passed.Show()
                    Button2_Click(sender, New EventArgs())
                Else
                    rescan_pbx_Click(sender, New EventArgs())
                    userInput.Text = ""
                    Dim failed As New Subline_Result_3
                    failed.BackColor = Color.Red
                    failed._top_lbl = "Part Invalid"
                    failed._bot_lbl = "or" + vbNewLine + vbNewLine + "MMS Label is Already Scanned"
                    failed.Show()
                    Label2.Text = "Part Invalid"
                    checkTheDb.Dispose() 'Clears old Database
                    station_List = ""
                    userInput.Focus()
                    'rm_RunningId()
                End If

            End If
        Catch ex As Exception
            rescan_pbx_Click(sender, New EventArgs())
            userInput.Text = ""
            Dim failed As New Subline_Result_3
            failed.BackColor = Color.Red
            failed._top_lbl = "Part Invalid"
            failed._bot_lbl = "or" + vbNewLine + vbNewLine + "MMS Label is Already Scanned"
            failed.Show()
            Label2.Text = "Part Invalid"
            checkTheDb.Dispose() 'Clears old Database
            station_List = ""
            userInput.Focus()
        End Try
    End Sub

    'Remove Part Form
    Private Sub rmPartTopUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rmPartTopUp.Click
        Dim _RMPART As New Remove_Part
        _RMPART.Show()
    End Sub

#End Region

#Region "Misc"

    'load
    Private Sub WorkCentre_Topup_Scan_Part_5_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mdl_lbl.Text = ModelCode
            sub_lbl.Text = LineCode
            username.Text = "User : " + EmployeeName + UserID
            'Only Admin Can see Settings
            If (User_Admin_Flag = True) Then
                stg_btn.Visible = True
            Else
                stg_btn.Visible = False
            End If

            'Enable visibility of remove part Button
            If (removePart_Flag = True) Then
                rmPartTopUp.Visible = True
            End If

            userInput.Focus()
            Label2.Visible = False
            dropdown_pnl.Size = New Size(91, 55)
        Catch ex As Exception
        End Try
    End Sub

    'Textbox Focus
    Private Sub userInput_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles userInput.GotFocus
        Label2.Visible = False
    End Sub

    'log out
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            rm_RunningId() 'Clears RunningID Cache
            checkTheDb.Dispose() 'clears datatable of partlist,models, etc
            User_Admin_Flag = False
            Form1.Show()
            Form1.user_txtbx.Focus()
            'Dim logout As New Form1 'Return to Login Screen (Logout)
            'logout.Show()
            'logout.user_txtbx.Focus()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'back
    Private Sub back_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_pbx.Click
        Try
            Dim back As New Identify_Model_2
            back.Show()
            Me.Close()
            PartID = Nothing
            PartNo = Nothing
            ModelCode = Nothing
            ModelID = Nothing
            MasterModelID = Nothing
            MasterStationCode = Nothing
            LineCode = Nothing
            LineID = Nothing
            ModelID = Nothing
            ModelCode = Nothing
            ScheduleID = Nothing
            ProductionId = Nothing
            MasterModelID = Nothing
            checkTheDb.Dispose() 'clears datatable of partlist,models, etc
        Catch ex As Exception
        End Try
    End Sub

    'home
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Try
            rm_RunningId() 'Clears RunningID Cache
            checkTheDb.Dispose() 'clears datatable of partlist,models, etc
            Dim Home As New Identify_Model_2
            Home.username.Text = UserID
            Home.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'rescan
    Private Sub rescan_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rescan_pbx.Click
        Try
            rm_RunningId() 'Clears RunningID Cache
            userInput.Text = ""
            userInput.Refresh()
            userInput.Focus()
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "DropDownMenu"
    'dropdown menu
    Private Sub dropdown_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dropdown_pbx.Click
        Try
            If (stg_btn.Visible = True) Then
                If (dropdown_pnl.Size = New Size(91, 55)) Then
                    dropdown_pnl.Size = New Size(91, 200)
                Else
                    dropdown_pnl.Size = New Size(91, 55)
                End If
            Else
                If (dropdown_pnl.Size = New Size(91, 55)) Then
                    dropdown_pnl.Size = New Size(91, 164)
                Else
                    dropdown_pnl.Size = New Size(91, 55)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    'settings
    Private Sub stg_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stg_btn.Click
        Try
            dropdown_pbx_Click(sender, New EventArgs())
            Dim obj As New Settings
            obj.Show()
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

    'home
    Private Sub home_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home_btn.Click
        Try
            Try
                checkTheDb.Dispose()
                Dim Home As New Identify_Model_2
                Home.username.Text = UserID
                Home.Show()
                Me.Close()
            Catch ex As Exception
            End Try
        Catch ex As Exception
        End Try
    End Sub
#End Region

    
End Class
