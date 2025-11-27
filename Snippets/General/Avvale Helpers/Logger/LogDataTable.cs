/// DataTable Logger
/// Log DataTable
/// Logger, DataTable

using Workspace.AWCommons.Commons.Extensions;

// Create a DataTable
DataTable dt = new DataTable();

// Add some elements to the DataTable

// Log the DataTable contents
XFErrorLevel errorLevel = XFErrorLevel.Information; // [OPTIONAL] log level: Information, Warning, Error, Fatal. Default is Information
int maxRows = 1000; // [OPTIONAL] maximum number of rows to log. (Default is 5000)
string separator = ","; // [OPTIONAL] separator for the logged data. (Default is semicolon ";")

dt.Log(si, api, "Message", errorLevel, maxRows, separator);