Public Class Choose_option
    Private Sub Choose_option_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim OBJ As New WorkCentre_Scan
        OBJ.Show()
        Me.Close()
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Dim back As New Scan
        back.Show()
        Me.Close()
    End Sub
End Class