/// Exists
/// Exists an element, a scalar function, a stored procedure, a table or a view in the database
/// DBManager, Exists

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.Helpers.DBHelpers

' Initialize the DBManager
Dim _mgr As New AWDBManager(si, globals)

' Check if an element exists in the database
Dim sqlQuery As String = "SELECT 1 FROM TableName WHERE Condition = Value"
Dim exists As Boolean = _mgr.Exists(sqlQuery)

' You can pass parameters to the query as well
Dim _params As New List(Of DbParamInfo)() From {
    New DbParamInfo("id", _parentId),
    New DbParamInfo("parentName", _parentName)
}
Dim existsWithParams As Boolean = _mgr.Exists("SELECT 1 FROM TableName WHERE ID = @id AND ParentName = @parentName", _params)



' There is also a method to know if a scalar function exists in the database
Dim functionExists As Boolean = _mgr.ScalarFunctionExists("FunctionName")
    
' And a method to know if a stored procedure exists in the database
Dim procedureExists As Boolean = _mgr.StoredProcedureExists("ProcedureName")

' And a method to know if a table exists in the database
Dim tableExists As Boolean = _mgr.TableExists("TableName")

' And a method to know if a view exists in the database
Dim viewExists As Boolean = _mgr.ViewExists("ViewName")

' Or there is a more general method to know if a database object exists in the database
Dim objectType As String = "FN" ' Possible values: "FN" (Scalar Function), "P" (Stored Procedure), "U" (Table), "V" (View)
Dim objectExists As Boolean = _mgr.DbObjectExists(objectType, "ObjectName")