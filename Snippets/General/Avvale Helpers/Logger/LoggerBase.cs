/// Log Base
/// Write log entries
/// Logger, Log

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.Helpers.Loggers;

// First, setup the Logging system (once)
AWLog.Setup(si, globals);

// Log severity is based on the following scale:
//
// - Information
// - Warning
// - Error
// - Fatal


// Write an Info log entry
AWLog.Write(si, "String To Log at Info Level");

// Write a Warning log entry
AWLog.WriteWarning(si, "String To Log at Warning Level");

// Write an Error log entry
AWLog.WriteError(si, "String To Log at Error Level");

// Write a Fatal log entry
AWLog.WriteFatal(si, "String To Log at Fatal Level");


// To be more generic you can specify the LogLevel
AWLog.WriteLog(si, XFErrorLevel.Information, "String To Log at Info Level");
AWLog.WriteLog(si, XFErrorLevel.Warning, "String To Log at Warning Level");
AWLog.WriteLog(si, XFErrorLevel.Error, "String To Log at Error Level");
AWLog.WriteLog(si, XFErrorLevel.Fatal, "String To Log at Fatal Level");


// You can also log objects
// Whatever object we have can be logged
// in this case _obj can be anything, and it will be logged in its JSON format
AWLog.Write(si, "String To Log at Info Level", _obj);
// You can use every log method with an object as well


// You can also log exceptions
try
{
    // Some code that may throw an exception
}
catch (Exception ex)
{
    // Log the exception
    AWLog.WriteException(si, "Message describing the context of the exception", ex);
}