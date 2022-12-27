Imports System.Data.SqlClient
Imports System.Data

Module SQL_Command

#Region "Main Commands"
    
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

#Region "Load"

    Public Sub autoSqlConn()
        Try
            Dim i As Int32 = 1

            Using conn = New SqlConnection(Settings.ComboBox1.SelectedItem.ToString)
                conn.Open()
            End Using
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Login Checks "

    'Check if username exist
    Public Function checkUsername(Optional ByVal userInput As String = Nothing) As Boolean
        Dim res As Boolean = False

        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()

                Dim query As String = "Select * From dbo.UserMaster where UserName=@UserName"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserName", userInput)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                If (dr.Read = True) Then
                    res = True
                End If
                conn.Close()
            End Using
        Catch ex As Exception
        End Try
        Return res
    End Function

    'Check if Password exist
    Public Function checkUserPass(Optional ByVal userInput As String = Nothing) As Boolean
        Dim res As Boolean = False

        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()

                Dim query As String = "Select * From dbo.UserMaster where Password=@Password"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Password", userInput)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                If (dr.Read = True) Then
                    res = True
                End If
                conn.Close()
            End Using
        Catch ex As Exception
        End Try
        Return res
    End Function

    'Check if UserName and Password Matches
    Public Function checkUser_and_Pass(Optional ByVal _userName As String = Nothing, Optional ByVal _passWord As String = Nothing) As Boolean
        Dim res As Boolean = False

        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()

                Dim query As String = "Select * From dbo.UserMaster where UserName=@UserName and Password=@Password"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserName", _userName)
                cmd.Parameters.AddWithValue("@Password", _passWord)
                Dim dr As SqlDataReader = cmd.ExecuteReader()
                If (dr.Read = True) Then
                    res = True
                End If
                conn.Close()
            End Using
        Catch ex As Exception
        End Try
        Return res
    End Function

#End Region



#Region "First Scan / Scan Subline & Model "

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
                MasterModelID = row(0).Item("MasterModelID").ToString
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
        Dim res As Boolean = False

        Try
            conn = New SqlConnection(conn_str)
            Dim query As String = "Select * From dbo.MasterBOM where ModelID=@ModelID and LineID=@LineID and MasterModelID=@MasterModelID"
            conn.Open()
            cmd = New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ModelID", ModelID)
            cmd.Parameters.AddWithValue("@LineID", LineID)
            cmd.Parameters.AddWithValue("@MasterModelID", MasterModelID)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                res = True
            End If
        Catch ex As Exception
        End Try
        Return res
    End Function

    'Function to get ScheduleID and ProductionId
    'This will check if the ProductionStatus = "Started". Else it will not run at all
    Public Function GetScheduleID_and_ProductionId() As Boolean
        Dim res As Boolean = False

        Try
            conn = New SqlConnection(conn_str)
            conn.Open()
            Dim query As String = String.Format("Select * From [dbo].[Schedule] Where LineID=@LineID and MasterModelID=@MasterModelID and ModelID=@ModelID and ProductionStatus=@ProductionStatus")
            cmd = New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@ModelID", ModelID)
            cmd.Parameters.AddWithValue("@LineID", LineID)
            cmd.Parameters.AddWithValue("@MasterModelID", MasterModelID)
            cmd.Parameters.AddWithValue("@ProductionStatus", ProductionStatus)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If (dr.Read = True) Then
                Dim row As DataRow() = dt.Select("[MasterModelID] = '" & MasterModelID & "' AND [ProductionStatus] = '" & ProductionStatus & "' AND [ModelID] = '" & ModelID & "' AND [LineID] = '" & LineID & "'")
                If row.Count > 0 Then
                    ScheduleID = row(0).Item("ScheduleID").ToString
                    ProductionId = row(0).Item("ProductionId").ToString
                    res = True
                End If
            End If
        Catch ex As Exception
        End Try
        Return res
    End Function

#End Region

#Region "Second Scan / Scan Part & AssemblyQty "

    'STEP 1'
    'This is the part where you input PartNo and AssemblyQty (eg: K1KY03BA0799,300) 
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

    'Get MasterStationID And AssemblyRef(using LineID , PartID and ModelID) from dbo.MasterBOM
    Public Function GetMasterStationID(ByRef PartID, ByRef LineID, ByRef ModelID) As String
        Dim returnValue As String = ""
        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                Dim query As String = "Select * From dbo.MasterBOM where PartID=@PartID and LineID=@LineID and ModelID=@ModelID and MasterModelID=@MasterModelID"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@PartID", PartID)
                cmd.Parameters.AddWithValue("@LineID", LineID)
                cmd.Parameters.AddWithValue("@ModelID", ModelID)
                cmd.Parameters.AddWithValue("@MasterModelID", MasterModelID)
                Dim dr As SqlDataReader
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                dr = cmd.ExecuteReader()
                Dim temp As String = PartID

                If dr.Read = True Then
                    Dim row As DataRow() = dt.Select("[MasterModelID] = '" & MasterModelID & "' AND [PartID] = '" & PartID & "' AND [ModelID] = '" & ModelID & "' AND [LineID] = '" & LineID & "'")
                    If row.Count > 0 Then
                        temp = row(0).Item("MasterStationId").ToString
                        AssemblyRef = row(0).Item("AssemblyRef")
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

    'Just Make Sure MasterStationCode exists
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

#Region "Third Scan / Scan Station "

    'STEP 2'
    'Check if userInput = MasterBOMId is found in the database
    Public Function CheckStation(Optional ByRef userInput As String = Nothing) As Boolean
        Dim res As Boolean = False

        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                Dim query As String = "Select * From dbo.MasterBOM where MasterBOMId=@MasterBOMId and MasterModelID=@MasterModelID and LineID=@LineID and MasterStationID=@MasterStationID and ModelID=@ModelID and PartID=@PartID"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MasterBOMId", userInput)
                cmd.Parameters.AddWithValue("@MasterModelID", MasterModelID)
                cmd.Parameters.AddWithValue("@LineID", LineID)
                cmd.Parameters.AddWithValue("@ModelID", ModelID)
                cmd.Parameters.AddWithValue("@PartID", PartID)
                cmd.Parameters.AddWithValue("@MasterStationID", MasterStationId)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()

                If (dr.Read = True) Then
                    res = True
                    MasterBOMId = userInput
                End If
            End Using
        Catch ex As Exception
        End Try
        Return res
    End Function

#End Region

#Region "Fourth Scan / Rescan Part "

    'Step 3
    'Scan Part
    Public Function checkPartandStation(Optional ByRef userInput As String = Nothing) As Boolean
        Dim res As Boolean = False

        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()
                Dim query As String = "Select * From dbo.MasterBOM where MasterBOMId=@MasterBOMId and MasterModelID=@MasterModelID and LineID=@LineID and MasterStationID=@MasterStationID and ModelID=@ModelID and PartID=@PartID"
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@MasterBOMId", userInput)
                cmd.Parameters.AddWithValue("@MasterModelID", MasterModelID)
                cmd.Parameters.AddWithValue("@LineID", LineID)
                cmd.Parameters.AddWithValue("@ModelID", ModelID)
                cmd.Parameters.AddWithValue("@PartID", PartID)
                cmd.Parameters.AddWithValue("@MasterStationID", MasterStationId)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader()

                If (dr.Read = True) Then
                    res = True
                End If
            End Using
        Catch ex As Exception
        End Try
        Return res
    End Function


#End Region

#Region "Last Scan"

    'This will insert the data after finishing the topup process into the dbo.ProductionStation table
    Public Function UpdateProductionStation() As Boolean
        Dim res As Boolean = False
        Try
            Using conn = New SqlConnection(conn_str)
                conn.Open()

                'Current Time
                Dim temp_time As String = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                Dim _status As String = "1"
                Dim query As String = "Insert into dbo.ProductionStation (ProductionStationId, ScheduleID, MasterBOMId, ProductionId, PartID, Qty, TDate, Status) values(@ProductionStationId, @ScheduleID, @MasterBOMId, @ProductionId, @PartID, @Qty, @TDate, @Status)"
                Dim Qty As Int32 = Convert.ToInt32(ActualQty)

                'Data insert based on where the values are stored.
                'Some names might not match the datatable
                cmd = New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ProductionStationId", ModelID)
                cmd.Parameters.AddWithValue("@ScheduleID", ScheduleID)
                cmd.Parameters.AddWithValue("@MasterBOMId", MasterBOMId)
                cmd.Parameters.AddWithValue("@ProductionId", ProductionId)
                cmd.Parameters.AddWithValue("@PartID", PartID)
                cmd.Parameters.AddWithValue("@Qty", Qty)
                cmd.Parameters.AddWithValue("@TDate", temp_time)
                cmd.Parameters.AddWithValue("@Status", _status)

                'Execute the Insert data
                Dim i As Integer = cmd.ExecuteNonQuery()
                conn.Close()

                If (i = 0) Then
                    res = False
                Else
                    res = True
                End If
            End Using
        Catch ex As Exception
        End Try
        Return res
    End Function

    'testing
    Public Sub testing()
        Using conn = New SqlConnection(conn_str)
            conn.Open()


            Dim query As String = "Insert into dbo.testing values(@name, @age)"
            Dim test As String = "James"
            Dim test2 As String = "10"

            cmd = New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", test)
            cmd.Parameters.AddWithValue("@age", test2)


            'Execute the Insert data
            cmd.ExecuteNonQuery()
            conn.Close()

        End Using
    End Sub

#End Region

End Module
