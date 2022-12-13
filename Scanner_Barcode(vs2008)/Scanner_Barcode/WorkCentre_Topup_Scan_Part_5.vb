Public Class WorkCentre_Topup_Scan_Part_5

    Public part_name_temp As String 'This one is cached and moved up until last station

#Region "Data Passing"

    'Passing username credentials
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
#End Region

#Region "Main"
    'Cont_btn event
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cont_btn.Click
        If (PrtNo_txtbox.Text IsNot Nothing) Then

            'Creates new form
            Dim form As New WorkCentre_Topup_Scan_Station_6
            form.user = username.Text 'pass username label
            form._part = PrtNo_txtbox.Text 'pass part ID label
            form._subline = sub_lbl.Text 'pass subline label
            form._model = mdl_lbl.Text 'pass model label
            form._part_station = MasterStationCode 'pass part station label
            form.part_name_cache = part_name_temp 'sends the name of the part
            form.Show()
            Me.Close()

        End If
    End Sub

    'Trigger scan if enter key is pressed
    Private Sub part_ID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PrtNo_txtbox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim temp As String
                Dim res As Boolean

                PartNo = PrtNo_txtbox.Text
                If (PartNo IsNot Nothing) Then
                    temp = GetPartID(PartNo)
                    temp = GetMasterStationID(PartID, LineID, ModelID)
                    temp = GetMasterStationCode(MasterStationId, LineID)
                    res = CheckMasterStationCode(temp)
                    If (res = True) Then
                        Dim passed As New Subline_Result_3
                        passed.BackColor = Color.LawnGreen
                        passed._top_lbl = "Part Station"
                        passed._bot_lbl = String.Format("{0}", temp)
                        passed.Show()
                        Button2_Click(sender, New EventArgs())
                    Else
                        Dim failed As New Subline_Result_3
                        failed.BackColor = Color.Red
                        failed._top_lbl = "Part"
                        failed._bot_lbl = "Not Found"
                        failed.Show()
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
            dropdown_pnl.Size = New Size(76, 36)
        Catch ex As Exception
        End Try
    End Sub

    'log out
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim logout As New Form1 'Return to Login Screen (Logout)
        logout.Show()
        Me.Close()
    End Sub

    'back
    Private Sub back_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_pbx.Click
        Try
            Dim back As New choose_option_4
            back._subline = _subline
            back._model = _model
            back.username.Text = username.Text
            back.Show()
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

    'rescan
    Private Sub rescan_pbx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rescan_pbx.Click
        Try
            PrtNo_txtbox.Text = ""
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
