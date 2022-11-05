Public Class WorkCentre_ScanStationPartScan
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim status As New Part_Match_Success
        status.Show()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Dim back As New WorkCentre_ScanStation
        back.Show()
        Me.Close()
    End Sub
End Class