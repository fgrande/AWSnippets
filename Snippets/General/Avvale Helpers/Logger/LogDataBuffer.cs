/// DataBuffer Logger
/// Log DataBuffer
/// Logger, DataBuffer

using Workspace.AWCommons.Commons.Extensions;

// Create a DataBuffer
DataBuffer db = new DataBuffer();

// Add some data to the DataBuffer

// Log the DataBuffer contents, its an improvement of LogDataBuffer
XFErrorLevel errorLevel = XFErrorLevel.Information; // [OPTIONAL] log level: Information, Warning, Error, Fatal. Default is Information
int maxRows = 1000; // [OPTIONAL] maximum number of rows to log. (Default is 5000)
string separator = ","; // [OPTIONAL] separator for the logged data. (Default is semicolon ";")

db.Log(si, api, "Message", errorLevel, maxRows, separator);

