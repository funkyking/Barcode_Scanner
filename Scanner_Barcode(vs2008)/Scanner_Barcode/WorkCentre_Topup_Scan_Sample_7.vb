Public Class WorkCentre_Topup_Scan_Sample_7


#Region "Main"

    'If the Scan Works, This will take them back to Model Scanning
    Private Sub Repeat()
        Try
            rm_RunningId() 'Clears RunningID Cache
            Dim rpt As New Identify_Model_2
            rpt.username.Text = UserID
            rpt.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub


    'Trigger scan enter key pressed
    Private Sub scn_part_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles userInput.KeyDown

        If e.KeyCode = Keys.Enter Then

            Dim pass As Boolean

            'Gets the UUID(Unique Identifier) for the current Session
            ProductionStationId = GetFinalProductionId()

            'Check if part with other details match in dbo.MasterBOM database table
            'input is MasterBOMId
            pass = checkPartandStation(userInput.Text)

            'Tries to update in the ProductionStation database table
            'if it cant a false boolean is returned
            pass = UpdateProductionStation()
            
            If (pass = True) Then
                Dim passed As New Subline_Result_3
                passed._top_lbl = "Part Topup"
                passed._bot_lbl = "Updated !"
                passed.Show()

                'Once Finish Topup Process
                'User is sent back to model and subline scanning for next topup
                Repeat()

            Else
                Dim failed As New Subline_Result_3
                failed.BackColor = Color.Red
                failed._top_lbl = "Unable to"
                failed._bot_lbl = "Topup Part!"
                failed.Show()
            End If
        End If
    End Sub

#End Region

#Region "Misc"

    'load
    Private Sub WorkCentre_Topup_Scan_Sample_7_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            assemblyRef_lbl.Text = AssemblyRef
            userInput.Focus()
            dropdown_pnl.Size = New Size(34, 32)
        Catch ex As Exception
        End Try
    End Sub

    'Back
    Private Sub back_pbx_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_pbx.Click
        Try
            rm_RunningId() 'Clears RunningID Cach
            Dim back As New WorkCentre_Topup_Scan_Station_6
            back.mdl_lbl.Text = ModelCode
            back.username.Text = UserID
            'back.sub_lbl.Text = LineCode
            'back.part_lbl.Text = PartNo
            'back.prtStn_lbl.Text = MasterStationCode
            back.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'Rescan
    Private Sub rescan_pbx_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rescan_pbx.Click
        Try
            userInput.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    'logout
    Private Sub logout_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_pbx.Click
        Try
            rm_RunningId() 'Clears RunningID Cach
            Dim logout As New Form1 'Return to Login Screen (Logout)
            logout.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'home
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Try
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
            If (dropdown_pnl.Size = New Size(34, 32)) Then
                dropdown_pnl.Size = New Size(76, 181)
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