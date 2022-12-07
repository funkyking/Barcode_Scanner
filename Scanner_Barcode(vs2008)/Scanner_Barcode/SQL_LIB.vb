Imports System.Data.SqlClient
Imports System.Data

Public Class SQL_LIB
    Shared conn As SqlConnection
    Shared cmd As SqlCommand
    Shared da As SqlDataAdapter
    Shared dt As DataTable
    Shared res As Boolean
    Public Shared conn_str As String = "Data Source=192.168.8.126,1433;Password=saadmin;User ID=sa;Initial Catalog=PCC"

    'Each table is created as sqladapter and can easily access in forms
    Public Shared da_ActivityLog As New SqlDataAdapter("Select * From [dbo].[ActivityLog]", conn)
    Public Shared da_Line As New SqlDataAdapter("Select * From [dbo].[Line]", conn)
    Public Shared da_LineDetail As New SqlDataAdapter("Select * From [dbo].[LineDetail]", conn)
    Public Shared da_LineGroup As New SqlDataAdapter("Select * From [dbo].[LineGroup]", conn)
    Public Shared da_MasterBOM As New SqlDataAdapter("Select * From [dbo].[MasterBOM]", conn)
    Public Shared da_MasterModel As New SqlDataAdapter("Select * From [dbo].[MasterModel]", conn)
    Public Shared da_MasterStation As New SqlDataAdapter("Select * From [dbo].[MasterStation]", conn)
    Public Shared da_Model As New SqlDataAdapter("Select * From [dbo].[Model]", conn)
    Public Shared da_Part As New SqlDataAdapter("Select * From [dbo].[Part]", conn)
    Public Shared da_Schedule As New SqlDataAdapter("Select * From [dbo].[Schedule]", conn)
    Public Shared da_ScheduleDetail As New SqlDataAdapter("Select * From [dbo].[ScheduleDetail]", conn)
    Public Shared da_UserGroup As New SqlDataAdapter("Select * From [dbo].[UserGroup]", conn)
    Public Shared da_UserGroupFunction As New SqlDataAdapter("Select * From [dbo].[UserGroupFunction]", conn)
    Public Shared da_UserMaster As New SqlDataAdapter("Select * From [dbo].[UserMaster]", conn)

    Public Shared Sub connect()
        conn = New SqlConnection(conn_str)
    End Sub
 
End Class
