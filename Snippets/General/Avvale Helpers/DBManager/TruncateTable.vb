/// TruncateTable
/// You can use the DBManager to truncate a table in the database
/// DBManager, TruncateTable

imports Workspace.AWCommons.Commons.Helpers.DBHelpers

' Initialize the DBManager
Dim _mgr As New AWDBManager(si, globals)

' Truncate a table in the database
_mgr.TruncateTable("TableName")