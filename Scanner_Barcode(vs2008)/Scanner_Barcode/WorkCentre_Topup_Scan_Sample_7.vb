Public Class WorkCentre_Topup_Scan_Sample_7


#Region "Data Passing"

    Dim part_name_cache As String

    'passing username credentials
    Friend Property user() As String
        Get
            Return username.Text
        End Get
        Set(ByVal value As String)
            username.Text = value
        End Set
    End Property

    'Passing Model ID
    Friend Property _model() As String
        Get
            Return mdl_lbl.Text
        End Get
        Set(ByVal value As String)
            mdl_lbl.Text = value
        End Set
    End Property

    'Passing Subline detail
    Friend Property _subline() As String
        Get
            Return sub_lbl.Text
        End Get
        Set(ByVal value As String)
            sub_lbl.Text = value
        End Set
    End Property

    'Passing part detail
    Friend Property _part() As String
        Get
            Return part_lbl.Text
        End Get
        Set(ByVal value As String)
            part_lbl.Text = value
        End Set
    End Property

    'Passing station ID
    Friend Property _station() As String
        Get
            Return station_lbl.Text
        End Get
        Set(ByVal value As String)
            station_lbl.Text = value
        End Set
    End Property

    Friend Property _part_name_cache() As String
        Get
            Return part_name_cache
        End Get
        Set(ByVal value As String)
            part_name_cache = value
        End Set
    End Property

#End Region

#Region "Main"

    'Trigger scan enter key pressed
    Private Sub scn_part_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles scn_part.KeyDown

        If e.KeyCode = Keys.Enter Then

            Dim pass As Boolean

            pass = checkPartandStation(scn_part.Text)
            If (pass = True) Then
                Dim passed As New Subline_Result_3
                passed._top_lbl = "Part"
                passed._bot_lbl = "Match !"
                passed.Show()

            Else
                Dim failed As New Subline_Result_3
                failed.BackColor = Color.Red
                failed._top_lbl = "Part Does"
                failed._bot_lbl = "Not Match !"
                failed.Show()
            End If
        End If
    End Sub

#End Region

#Region "Misc"

    'load
    Private Sub WorkCentre_Topup_Scan_Sample_7_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            part_name.Text = String.Format("({0})", GetPartName(PartID))
            dropdown_pnl.Size = New Size(76, 36)
        Catch ex As Exception
        End Try
    End Sub

    'Back
    Private Sub back_pbx_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_pbx.Click
        Try
            Dim back As New WorkCentre_Topup_Scan_Station_6
            back.username.Text = username.Text
            back._subline = _subline
            back._model = mdl_lbl.Text
            back._part = _part
            back._part_station = _station
            back.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'Rescan
    Private Sub rescan_pbx_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rescan_pbx.Click
        Try
            scn_part.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    'logout
    Private Sub logout_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_pbx.Click
        Try
            Dim logout As New Form1 'Return to Login Screen (Logout)
            logout.Show()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    'home
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Try
            Dim Home As New Identify_Model_2
            Home.user = username.Text
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
            If (dropdown_pnl.Size = New Size(76, 36)) Then
                dropdown_pnl.Size = New Size(76, 181)
            Else
                dropdown_pnl.Size = New Size(76, 36)
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
            Form1.Dispose()
            GC.Collect()
        Catch ex As Exception
        End Try
    End Sub

    'home
    Private Sub home_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles home_btn.Click
        Try
            Try
                Dim Home As New Identify_Model_2
                Home.user = username.Text
                Home.Show()
                Me.Close()
            Catch ex As Exception
            End Try
        Catch ex As Exception
        End Try
    End Sub
#End Region

End Class