/// Logger Object
/// Write log entries with objects
/// Logger, Log

using Workspace.AWCommons.Commons.Helpers.Loggers;

// First, setup the Logging system (once)
AWLog.Setup(si, globals);

// Whatever object we have can be logged
// in this case _obj can be anything, and it will be logged in its JSON format

// Write a log entry
AWLog.Write(si, "String To Log at Info Level", _obj);

