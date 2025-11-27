/// Get Count
/// Get the number of records from a SQLCommand
/// DBManager, Count

using Workspace.AWCommons.Commons.Helpers.DBHelpers;

// Initialize the DBManager
AWDBManager _mgr = new AWDBManager(si, globals);

// Get the count of records from a SQL query
int recordCount = _mgr.GetCount("SELECT COUNT(*) FROM TableName WHERE Condition = Value");

// You can pass parameters to the query as well
List<DbParamInfo> _params = new List<DbParamInfo>() {
    new DbParamInfo("id", _parentId),
    new DbParamInfo("parentName", _parentName),
};
int recordCountWithParams = _mgr.GetCount("SELECT COUNT(*) FROM TableName WHERE ID = @id AND ParentName = @parentName", _params);