/// Get Columns
/// Get all column names from a table in the database
/// DBManager, Columns

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.Helpers.DBHelpers;

// Initialize the DBManager
AWDBManager _mgr = new AWDBManager(si, globals);

// Get all column names from a table in the database
List<string> columns = _mgr.GetColumns("TableName");