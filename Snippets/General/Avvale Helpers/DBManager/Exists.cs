/// Exists
/// Exists an element, a scalar function, a stored procedure, a table or a view in the database
/// DBManager, Exists

using Workspace.AWCommons.Commons.Helpers.DBHelpers;

// Initialize the DBManager
AWDBManager _mgr = new AWDBManager(si, globals);

// Check if an element exists in the database
string sqlQuery = "SELECT 1 FROM TableName WHERE Condition = Value";
bool exists = _mgr.Exists(sqlQuery);

// You can pass parameters to the query as well
List<DbParamInfo> _params = new List<DbParamInfo>() {
    new DbParamInfo("id", _parentId),
    new DbParamInfo("parentName", _parentName),
};
bool existsWithParams = _mgr.Exists("SELECT 1 FROM TableName WHERE ID = @id AND ParentName = @parentName", _params);



// There is also a method to know if a scalar function exists in the database
bool functionExists = _mgr.ScalarFunctionExists("FunctionName");

// And a method to know if a stored procedure exists in the database
bool procedureExists = _mgr.StoredProcedureExists("ProcedureName");

// And a method to know if a table exists in the database
bool tableExists = _mgr.TableExists("TableName");

// And a method to know if a view exists in the database
bool viewExists = _mgr.ViewExists("ViewName");

// Or there is a more general method to know if a database object exists in the database
string objectType = "FN"; // Possible values: "FN" (Scalar Function), "P" (Stored Procedure), "U" (Table), "V" (View)
bool objectExists = _mgr.DbObjectExists(objectType, "ObjectName");