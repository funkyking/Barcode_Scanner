Imports System.Data.SqlClient
Imports System.Data
Imports System.Diagnostics

Public Class WorkCentre_Topup_Scan_Station_6



#Region "Main"
    'cont_btn event
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cont_btn.Click
        Try
            'checkTheDb.Dispose() 'clears datatable of partlist,models, etc
            'Scan Part
            Dim Part As New WorkCentre_Topup_Scan_Part_5
            Part.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'This calls the enter key to auto execute and open next form
    Private Sub scn_stn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles userInput.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
<<<<<<< HEAD
                Dim res As Boolean = False
                Dim stn_res As Boolean

                stn_res = get_MstBOMID_(userInput.Text.ToUpper)

                If (stn_res = True) Then
                    'res = getMasterBOMId()
                    ProductionStationId = GetFinalProductionId()
                    res = UpdateProductionStation()
                End If

                'Display(Results)
                If (res = True) Then
                    'station_List = ""
=======
                Dim res As Boolean


                res = getMasterBOMId(userInput.Text)
                ProductionStationId = GetFinalProductionId()
                res = UpdateProductionStation()

                'Display Results
                If (res = True) Then
>>>>>>> 0d6055eed53b1b3304b77c91fb6f11866c034b19
                    Dim passed As New Subline_Result_3
                    passed.BackColor = Color.LawnGreen
                    passed._top_lbl = "Top Up"
                    passed._bot_lbl = "Success !"
                    passed.Show()
<<<<<<< HEAD
                    checkTheDb.Dispose() 'Clears the database of models,parts, etc
=======
>>>>>>> 0d6055eed53b1b3304b77c91fb6f11866c034b19
                    Button2_Click(sender, New EventArgs())
                    MasterBOMId = ""
                Else
                    userInput.Text = ""
                    rescan_pbx_Click(sender, New EventArgs())
                    Dim failed As New Subline_Result_3
                    failed.BackColor = Color.Red
                    failed._top_lbl = "Station"
                    failed._bot_lbl = "Not Match !"
                    failed.Show()
<<<<<<< HEAD
                    MasterBOMId = ""
=======
                    rescan_pbx_Click(sender, New EventArgs())
>>>>>>> 0d6055eed53b1b3304b77c91fb6f11866c034b19
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
<<<<<<< HEAD

    'Display The Stations to top up the Parts in
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim temp As String = "Station List : " + station_List

        MessageBox.Show(temp)
    End Sub

=======
>>>>>>> 0d6055eed53b1b3304b77c91fb6f11866c034b19
#End Region

#Region "Misc"

    'load
    Private Sub WorkCentre_Topup_Scan_Station_6_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Loading Labels
            username.Text = UserID
            mdl_lbl.Text = ModelCode 'ModelCode/ModelName
            sub_lbl.Text = LineCode 'LineCode/LineName
<<<<<<< HEAD
            'msc_lbl.Text = MasterStationCode
            part_lbl.Text = PartNo
=======
            msc_lbl.Text = MasterStationCode
            part_lbl.Text = "Part Code : " + PartNo
>>>>>>> 0d6055eed53b1b3304b77c91fb6f11866c034b19

            userInput.Focus()
            'Dropdown panel size
            dropdown_pnl.Size = New Size(91, 55)

        Catch ex As Exception
        End Try
    End Sub

    'logout
    Private Sub logout_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_pbx.Click
        Try
            rm_RunningId() 'Clears RunningID Cach
            checkTheDb.Dispose()
            Dim logout As New Form1 'Return to Login Screen (Logout)
            logout.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'back
    Private Sub back_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_pbx.Click
        Try
            'station_List = ""
            checkTheDb.Dispose() 'clears datatable of partlist,models, etc
            'rm_RunningId() 'Clears RunningID Cach
            Dim back As New WorkCentre_Topup_Scan_Part_5
            back.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'rescan
    Private Sub rescan_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rescan_pbx.Click
        Try
            userInput.Text = ""
            userInput.Refresh()
            userInput.Focus()
        Catch ex As Exception
        End Try
    End Sub

    'home
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Try
            checkTheDb.Dispose() 'clears datatable of partlist,models, etc
            rm_RunningId() 'Clears RunningID Cach
            Dim Home As New Identify_Model_2
            Home.username.Text = UserID
            Home.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub



#End Region

#Region "DropDownMenu"
    'dropdown menu
    Private Sub dropdown_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dropdown_pbx.Click
        Try
            If (dropdown_pnl.Size = New Size(91, 55)) Then
                dropdown_pnl.Size = New Size(91, 200)
            Else
                dropdown_pnl.Size = New Size(91, 55)
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
                checkTheDb.Dispose() 'clears datatable of partlist,models, etc
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