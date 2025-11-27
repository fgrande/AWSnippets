/// Get DataTable
/// Get a DataTable from a SQLCommand
/// DBManager, DataTable

using Workspace.AWCommons.Commons.Helpers.DBHelpers;

// Initialize the DBManager
AWDBManager _mgr = new AWDBManager(si, globals);

// Get a DataTable from a SQL query
DataTable dt = _mgr.GetDataTable("SELECT * FROM TableName WHERE Condition = Value");

// You can pass parameters to the query as well
List<DbParamInfo> _params = new List<DbParamInfo>() { 
    new DbParamInfo("id", _parentId),
    new DbParamInfo("parentName", _parentName),
};
DataTable dtWithParams = _mgr.GetDataTable("SELECT * FROM TableName WHERE ID = @id AND ParentName = @parentName", _params);
