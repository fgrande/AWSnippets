/// Log DataBuffer
/// DataBuffer logger
/// Logger, DataBuffer

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.Extensions;



// Create a DataBuffer
DataBuffer db = new DataBuffer();

// Add some data to the DataBuffer

// Log the DataBuffer contents, its an improvement of LogDataBuffer
XFErrorLevel errorLevel = XFErrorLevel.Information; // [OPTIONAL] log level: Information, Warning, Error, Fatal. Default is Information
int maxRows = 1000; // [OPTIONAL] maximum number of rows to log. (Default is 5000)
string separator = ","; // [OPTIONAL] separator for the logged data. (Default is semicolon ";")

db.Log(si, api, "Message", errorLevel, maxRows, separator);



// Create a DataBufferCell
DataBufferCell dbc = new DataBufferCell();

// Add some data to the DataBufferCell

// Log the DataBufferCell contents
XFErrorLevel errorLevel = XFErrorLevel.Information; // [OPTIONAL] log level: Information, Warning, Error, Fatal. Default is Information
dbc.Log(si, api, errorLevel);