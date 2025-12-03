/// Get DataTable
/// Get a DataTable from a SQLCommand
/// DBManager, DataTable

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.Helpers.DBHelpers

' Initialize the DBManager
Dim _mgr As New AWDBManager(si, globals)

' Get a DataTable from a SQL query
Dim dt As DataTable = _mgr.GetDataTable("SELECT * FROM TableName WHERE Condition = Value")

' You can pass parameters to the query as well
Dim _params As New List(Of DbParamInfo) From { 
    New DbParamInfo("id", _parentId),
    New DbParamInfo("parentName", _parentName)
}
Dim dtWithParams As DataTable = _mgr.GetDataTable("SELECT * FROM TableName WHERE ID = @id AND ParentName = @parentName", _params)