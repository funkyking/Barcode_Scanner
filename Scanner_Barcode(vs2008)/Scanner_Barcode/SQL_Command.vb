Imports System.Data.SqlClient
Imports System.Data

Module SQL_Command

#Region "Db for ID's"
    ' Storing the Details of parts and stations
    Public PartID As String
    Public PartNo As String
    Public ModelID As String
    Public LineID As String
    Public MasterStationId As String
    Public MasterStationCode As String
    '
    Public DatabaseName As String = ""
    Public conn As New SqlConnection
    Public cmd As SqlCommand
    Public res As Boolean
    Public conn_str As String = "null"

#End Region

#Region "Commands"

    Public Function OpenDB() As Boolean
        Try
            If (conn.State = ConnectionState.Closed) Then
                conn.ConnectionString = conn_str
                conn.Open()
                res = True
            End If
        Catch ex As Exception
            res = False
        End Try
        Return res
    End Function

    Public Function Sql_Connection() As String
        Dim temp As String
        temp = conn.ConnectionString
        Return temp
    End Function

#End Region

#Region "Identify Model"

    'Function to return ModelID given ModelCode/ModeName
    Public Function GetModelId(Optional ByVal ValueFromFunc As String = Nothing) As String
        Dim returnValue As String = ValueFromFunc 'Model Name
        Using conn = New SqlConnection(conn_str)
            conn.Open()

            Dim query As String = "Select * From dbo.Model"
            cmd = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            'DataGrid1.DataSource = dt

            Dim temp As String = returnValue

            temp = String.Format("ModelCode = '{0}'", temp)

            'DataTable.Rows(RowNo).ItemArray(columnNo).ToString()
            Dim row() As DataRow = dt.Select(temp)
            If row.Count > 0 Then
                temp = row(0).Item("ModelID").ToString
                returnValue = temp
            End If
            conn.Close()
        End Using
        ModelID = returnValue
        Return ModelID
    End Function

    'Function to return lineID given LineCode/LineName
    Public Function GetLineID(Optional ByVal ValueFromFunc As String = Nothing) As String
        Dim returnValue As String = ValueFromFunc 'LineCode/LineName
        Using conn = New SqlConnection(conn_str)
            conn.Open()

            Dim query As String = "Select * From dbo.Line"
            cmd = New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            'DataGrid2.DataSource = dt

            Dim temp As String = returnValue

            temp = String.Format("LineCode = '{0}'", temp)

            'DataTable.Rows(RowNo).ItemArray(columnNo).ToString()
            Dim row() As DataRow = dt.Select(temp)
            If row.Count > 0 Then
                temp = row(0).Item("LineID").ToString
                returnValue = temp
            End If
            conn.Close()
        End Using
        LineID = returnValue 'Passing to Main function
        Return LineID
    End Function

    'Function to check if Model and Line ID Matches
    Public Function Model_and_Line_Check(ByVal ModelID, ByVal LineID) As Boolean
        Dim res As Boolean

        Try
            conn = New SqlConnection(conn_str)
            Dim query As String = "Select * From dbo.MasterBOM where ModelID=@ModelID and LineID=@LineID"
            conn.Open()
            cmd = New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ModelID", ModelID)
            cmd.Parameters.AddWithValue("@LineID", LineID)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                res = True
            Else
                res = False
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Return res
    End Function

#End Region

#Region "Topup"

    'STEP 1'
    'This is at Topup Part'
    'Get Part ID from part.dbo
    Public Function GetPartID(ByRef PartNo) As String
        Dim returnValue As String = PartNo
        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()

                Dim query As String = "Select * From dbo.Part"
                cmd = New SqlCommand(query, conn)
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                Dim temp As String = PartNo

                temp = String.Format("PartNo = '{0}'", temp)
                Dim row() As DataRow = dt.Select(temp)
                If row.Count > 0 Then
                    temp = row(0).Item("PartID").ToString
                    returnValue = temp
                End If
                conn.Close()
            End Using
        Catch ex As Exception
        End Try
        PartID = returnValue
        Return returnValue
    End Function

    'Get Master Station ID (using LineID , PartID and ModelID) from dbo.MasterBOM
    Public Function GetMasterStationID(ByRef PartID, ByRef LineID, ByRef ModelID) As String
        Dim returnValue As String = ""
        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                Dim query As String = "Select * From dbo.MasterBOM where PartID=@PartID and LineID=@LineID and ModelID=@ModelID"
                cmd = New SqlCommand(query, conn)
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@PartID", PartID)
                cmd.Parameters.AddWithValue("@LineID", LineID)
                cmd.Parameters.AddWithValue("@ModelID", ModelID)
                Dim dr As SqlDataReader
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                dr = cmd.ExecuteReader()
                Dim temp As String = PartID

                If dr.Read = True Then
                    temp = String.Format("PartID = '{0}'", temp)
                    Dim row() As DataRow = dt.Select(temp)
                    If row.Count > 0 Then
                        temp = row(0).Item("MasterStationId").ToString
                        returnValue = temp
                    End If
                End If
                conn.Close()
            End Using
        Catch ex As Exception
        End Try
        MasterStationId = returnValue
        Return returnValue
    End Function

    'Get Master Station Code (eg, E1, E2, ...)
    Public Function GetMasterStationCode(ByRef MasterStationId, ByRef LineID) As String
        Dim returnValue As String = ""
        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                Dim query As String = "Select * From dbo.MasterStation where MasterStationId=@MasterStationId and LineID=@LineID"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MasterStationId", MasterStationId)
                cmd.Parameters.AddWithValue("@LineID", LineID)
                Dim dr As SqlDataReader
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                dr = cmd.ExecuteReader()
                Dim temp As String = MasterStationId

                If dr.Read = True Then
                    temp = String.Format("MasterStationId = '{0}'", temp)
                    Dim row() As DataRow = dt.Select(temp)
                    If row.Count > 0 Then
                        temp = row(0).Item("MasterStationCode").ToString
                        returnValue = temp
                    End If
                End If
                conn.Close()
            End Using
        Catch ex As Exception
        End Try
        MasterStationCode = returnValue
        Return returnValue
    End Function

    'Check if the item exist in database
    Public Function CheckMasterStationCode(ByVal MasterStationCode) As Boolean
        Dim res As Boolean
        Dim returnValue As Boolean
        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                Dim query As String = "Select * From dbo.MasterStation where MasterStationCode=@MasterStationCode"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MasterStationCode", MasterStationCode)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()
                If (dr.Read = True) Then
                    res = True
                    returnValue = res
                Else
                    res = False
                    returnValue = res
                End If
                conn.Close()
            End Using
        Catch ex As Exception
        End Try
        Return returnValue
    End Function

#End Region

#Region "Scan Station"

    'STEP 2'
    'Scan Station (userInput = MasterStationID)(After Top_up) returns boolean
    Public Function CheckStation(Optional ByRef userInput As String = Nothing) As Boolean
        Dim res As Boolean
        Dim returnValue As Boolean

        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                Dim query As String = "Select * From dbo.MasterStation where MasterStationId=@MasterStationId and MasterStationCode=@MasterStationCode"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MasterStationId", userInput)
                cmd.Parameters.AddWithValue("@MasterStationCode", MasterStationCode)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()
                If (dr.Read = True) Then
                    res = True
                    returnValue = res
                Else
                    res = False
                    returnValue = res
                End If
            End Using
        Catch ex As Exception
        End Try
        Return returnValue
    End Function

#End Region

#Region "Scan Part"

    'STEP 3'
    'Get part name or AssemblyRef
    Public Function GetPartName(ByVal PartID) As String
        Dim returnValue As String = ""
        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                Dim query As String = "Select * From dbo.MasterBOM where PartID=@PartID"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@PartID", PartID)
                Dim dr As SqlDataReader
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                dr = cmd.ExecuteReader()
                Dim temp As String = PartID

                If dr.Read = True Then
                    temp = String.Format("PartID = '{0}'", temp)
                    Dim row() As DataRow = dt.Select(temp)
                    If row.Count > 0 Then
                        temp = row(0).Item("AssemblyRef").ToString
                        returnValue = temp
                    End If
                End If
                conn.Close()
            End Using
        Catch ex As Exception
        End Try
        Return returnValue
    End Function

    'Scan Part
    Public Function checkPartandStation(Optional ByRef userInput As String = Nothing) As Boolean
        Dim res As Boolean
        Dim returnValue As Boolean

        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                Dim query As String = "Select * From dbo.MasterBOM where PartID=@PartID and MasterStationId=@MasterStationId"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@PartID", userInput)
                cmd.Parameters.AddWithValue("@MasterStationId", MasterStationId)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()
                If (dr.Read = True) Then
                    res = True
                    returnValue = res
                Else
                    res = False
                    returnValue = res
                End If
            End Using
        Catch ex As Exception
        End Try
        Return returnValue
    End Function

#End Region

End Module
