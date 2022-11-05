Public Class WorkCentre_ScanStation
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim OBJ As New WorkCentre_ScanStationPartScan
        OBJ.Show()
        Me.Close()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Dim back As New WorkCentre_Scan
        back.Show()
        Me.Close()
    End Sub
End Class