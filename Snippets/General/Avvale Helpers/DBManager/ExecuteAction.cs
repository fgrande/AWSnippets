/// Execute Action
/// Execute a query
/// DBManager, Execute

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.Helpers.DBHelpers;

// Initialize the DBManager
AWDBManager _mgr = new AWDBManager(si, globals);

// Create a query to execute
string sqlQuery = "UPDATE TableName SET ColumnName = Value WHERE Condition = SomeValue";

// Execute the query
_mgr.ExecuteAction(sqlQuery);

// You can pass parameters to the query as well
List<DbParamInfo> _params = new List<DbParamInfo>() {
    new DbParamInfo("id", _parentId),
    new DbParamInfo("parentName", _parentName),
};
_mgr.ExecuteAction("UPDATE TableName SET ColumnName = Value WHERE ID = @id AND ParentName = @parentName", _params);

// This method also is able to return a long value with the following possible values:
// - For UPDATE/INSERT/DELETE statements, it’s the number of rows involved in the Command execution.
// - For DDL commands, -1 means “Success”, while 0 means “Something weird has happened”.
// - In case of Exceptions, this method will return 0.
long rowsAffected = _mgr.ExecuteAction("DELETE FROM TableName WHERE Condition = SomeValue");
long success = _mgr.ExecuteAction("CREATE TABLE NewTable (ID INT)", _params);