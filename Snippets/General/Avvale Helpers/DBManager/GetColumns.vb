/// Get Columns
/// Get all column names from a table in the database
/// DBManager, Columns

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
imports Workspace.AWCommons.Commons.Helpers.DBHelpers

' Initialize the DBManager
Dim _mgr As New AWDBManager(si, globals)

' Get all column names from a table in the database
Dim columns As List(Of String) = _mgr.GetColumns("TableName")