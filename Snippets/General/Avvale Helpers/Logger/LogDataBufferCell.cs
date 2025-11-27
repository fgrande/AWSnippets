/// DataBufferCell Logger
/// Log DataBufferCell
/// Logger, DataBufferCell

using Workspace.AWCommons.Commons.Extensions;

// Create a DataBufferCell
DataBufferCell dbc = new DataBufferCell();

// Add some data to the DataBufferCell

// Log the DataBufferCell contents
XFErrorLevel errorLevel = XFErrorLevel.Information; // [OPTIONAL] log level: Information, Warning, Error, Fatal. Default is Information
dbc.Log(si, api, errorLevel);