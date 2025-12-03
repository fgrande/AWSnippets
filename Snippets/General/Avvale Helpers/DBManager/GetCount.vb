/// Get Count
/// Get the number of records from a SQLCommand
/// DBManager, Count

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.Helpers.DBHelpers;

' Initialize the DBManager
Dim _mgr As New AWDBManager(si, globals)

' Get the count of records from a SQL query
Dim recordCount As Integer = _mgr.GetCount("SELECT COUNT(*) FROM TableName WHERE Condition = Value")

' You can pass parameters to the query as well
Dim _params As New List(Of DbParamInfo) From { 
    New DbParamInfo("id", _parentId),
    New DbParamInfo("parentName", _parentName)
}
Dim recordCountWithParams As Integer = _mgr.GetCount("SELECT COUNT(*) FROM TableName WHERE ID = @id AND ParentName = @parentName", _params)