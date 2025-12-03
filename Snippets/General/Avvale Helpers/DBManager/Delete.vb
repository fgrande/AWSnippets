/// Delete from the database
/// You can use the DBManager to delete all records or tables from a table in the database (!!USE WITH CAUTION!!)
/// DBManager, Delete, Truncate, Drop

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.Helpers.DBHelpers

' Initialize the DBManager
Dim _mgr As New AWDBManager(si, globals)

' Delete all records from a table in the database
_mgr.TruncateTable("TableName")

' Drop a table from the database
_mgr.DropTable("TableName")