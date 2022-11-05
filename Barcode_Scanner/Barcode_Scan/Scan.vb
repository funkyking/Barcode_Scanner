Imports System.Drawing.Imaging

Public Class Scan

    Public Property username As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim subline As String() = {"E1", "E2", "E3", "E4"}
        Dim parts As String() = {"Bowl", "Spoon", "LED", "Wire"} 'This follows the subline lineup
        Dim userInput As String = model_IDTxtBox.Text

        If (parts.Contains(userInput)) Then
            Dim indx As Int32 = Array.IndexOf(parts, userInput)
            Dim subline_indx As Int32 = Array.IndexOf(subline, subline(indx))
            Dim temp1 As String = parts(indx)
            Dim temp2 As String = subline(subline_indx)
            Dim Results As String = String.Format("{0} , {1}", temp2, temp1) 'temp2 + "," + temp1
            modelOutput.Text = Results

        Else
            model_IDTxtBox.Text = "         Item does not exist"
            model_IDTxtBox.ForeColor = Color.Gray

        End If


    End Sub

    Private Sub Scan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = username
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        Dim back As New Form1
        back.Show()
        Me.Close()
    End Sub

    Private Sub continueBtn_Click(sender As Object, e As EventArgs) Handles continueBtn.Click
        Dim OBJ As New Choose_option
        Dim Success As New Scan_SublineResult
        Success.Subline_Station = model_IDTxtBox
        Success.Show()
        OBJ.Show()
        Me.Close()

    End Sub

    Private Sub model_IDTxtBox_Click(sender As Object, e As EventArgs) Handles model_IDTxtBox.Click
        model_IDTxtBox.Text = Nothing
        model_IDTxtBox.ForeColor = Color.Black
    End Sub
End Class