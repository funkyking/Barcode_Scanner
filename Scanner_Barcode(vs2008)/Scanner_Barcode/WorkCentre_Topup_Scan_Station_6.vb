Public Class WorkCentre_Topup_Scan_Station_6


#Region "Main"
    'cont_btn event
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cont_btn.Click
        Try
            'Scan Part
            Dim Resc_Part As New WorkCentre_Topup_Scan_Part_5
            'Resc_Part.mdl_lbl.Text = ModelCode
            'Resc_Part.username.Text = UserID
            'Resc_Part.sub_lbl.Text = LineCode
            'Resc_Part.part_lbl.Text = PartNo
            'Resc_Part.prtStn_lbl.Text = MasterStationCode
            Resc_Part.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'This calls the enter key to auto execute and open next form
    Private Sub scn_stn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles userInput.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim pass As Boolean

                pass = getMasterBOMId(userInput.Text)
                If (pass = True) Then
                    'Dim passed As New Subline_Result_3
                    'passed.BackColor = Color.LawnGreen
                    'passed._top_lbl = "Station"
                    'passed._bot_lbl = "Match !"
                    'passed.Show()
                    Button2_Click(sender, New EventArgs())
                Else
                    Dim failed As New Subline_Result_3
                    failed.BackColor = Color.Red
                    failed._top_lbl = "Station"
                    failed._bot_lbl = "Not Match !"
                    failed.Show()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Misc"

    'load
    Private Sub WorkCentre_Topup_Scan_Station_6_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ''Loading Labels
            'mdl_lbl.Text = ModelCode 'ModelCode/ModelName
            'sub_lbl.Text = LineCode 'LineCode/LineName
            'prtStn_lbl.Text = MasterStationCode
            'part_lbl.Text = PartNo

            userInput.Focus()
            'Dropdown panel size
            dropdown_pnl.Size = New Size(34, 32)

            Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
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

    'back
    Private Sub back_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_pbx.Click
        Try
            'rm_RunningId() 'Clears RunningID Cach
            Dim back As New Identify_Model_2
            back.username.Text = UserID
            back.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'rescan
    Private Sub rescan_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rescan_pbx.Click
        Try
            userInput.Text = ""
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