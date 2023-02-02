﻿Public Class WorkCentre_Topup_Scan_Part_5



#Region "Main"
    'Cont_btn event
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cont_btn.Click
        Try
            Dim Station As New WorkCentre_Topup_Scan_Station_6
            Station.mdl_lbl.Text = ModelCode
            'Station.sub_lbl.Text = LineCode
            'Station.part_lbl.Text = PartNo
            'Station.prtStn_lbl.Text = MasterStationCode
            Station.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'Trigger scan if enter key is pressed
    Private Sub part_ID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles userInput.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim temp As String
                Dim res As Boolean
                Dim runid_res As Boolean = False

                'Previously Used ","(Comma) but follow client format is " "(space)
                'Dim _PartNo As String = userInput.Text.Substring(0, userInput.Text.IndexOf(" ")) 'PartNo/Part's Name
                'Dim _ScannedPartQty As String = userInput.Text.Split(" ")(1) 'Quantity Given
                'PartNo = _PartNo
                'ScannedPartQty = _ScannedPartQty

                Dim strarr As String() = userInput.Text.Split(" ")
                RunningId = strarr(0)
                PartNo = strarr(1)
                ScannedPartQty = strarr(2)

                
                If (PartNo IsNot Nothing) Then
                    temp = GetPartID(PartNo)
                    temp = GetMasterStationID(PartID, LineID, ModelID)
                    temp = GetMasterStationCode(MasterStationId, LineID)
                    res = CheckMasterStationCode(temp)

                    runid_res = CheckRunningId()
                    If runid_res = True Then
                        res = UpdateProductionStation()
                    Else
                        res = False
                    End If

                    ProductionStationId = GetFinalProductionId()
                    If (res = True) Then
                        Dim passed As New Subline_Result_3
                        passed.BackColor = Color.LawnGreen
                        passed._top_lbl = "Top Up"
                        passed._bot_lbl = "Successful" 'String.Format("{0}", temp)
                        passed.Show()
                        'Button2_Click(sender, New EventArgs())
                    Else
                        Dim failed As New Subline_Result_3
                        failed.BackColor = Color.Red
                        failed._top_lbl = "TopUp Schedule"
                        failed._bot_lbl = "Invalid or Completed"
                        failed.Show()
                        rm_RunningId()
                    End If
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Misc"

    'load
    Private Sub WorkCentre_Topup_Scan_Part_5_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mdl_lbl.Text = ModelCode
            sub_lbl.Text = LineCode
            userInput.Focus()
            dropdown_pnl.Size = New Size(34, 32)
        Catch ex As Exception
        End Try
    End Sub

    'log out
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim logout As New Form1 'Return to Login Screen (Logout)
        rm_RunningId() 'Clears RunningID Cache
        logout.Show()
        Me.Close()
    End Sub

    'back
    Private Sub back_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_pbx.Click
        Try
            rm_RunningId() 'Clears RunningID Cache
            Dim back As New WorkCentre_Topup_Scan_Station_6
            back.username.Text = UserID
            back.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'home
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Try
            rm_RunningId() 'Clears RunningID Cache
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
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "DropDownMenu"
    'dropdown menu
    Private Sub dropdown_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dropdown_pbx.Click
        Try
            If (dropdown_pnl.Size = New Size(34, 32)) Then
                dropdown_pnl.Size = New Size(91, 181)
            Else
                dropdown_pnl.Size = New Size(34, 32)
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
