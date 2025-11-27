/// TruncateTable
/// You can use the DBManager to truncate a table in the database
/// DBManager, TruncateTable

using Workspace.AWCommons.Commons.Helpers.DBHelpers;

// Initialize the DBManager
AWDBManager _mgr = new AWDBManager(si, globals);

// Truncate a table in the database
_mgr.TruncateTable("TableName");