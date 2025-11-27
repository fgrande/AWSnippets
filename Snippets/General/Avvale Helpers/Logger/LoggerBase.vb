/// Logger Base
/// Write log entries
/// Logger, Log

Imports Workspace.AWCommons.Commons.Helpers.Loggers

' First, setup the Logging system (once)
AWLog.Setup(si, globals)

' Log severity is based on the following scale:
'
' - Information
' - Warning
' - Error
' - Fatal


' Write an Info log entry
AWLog.Write(si, "String To Log at Info Level")

' Write a Warning log entry
AWLog.WriteWarning(si, "String To Log at Warning Level")

' Write an Error log entry
AWLog.WriteError(si, "String To Log at Error Level")

' Write a Fatal log entry
AWLog.WriteFatal(si, "String To Log at Fatal Level")


' To be more generic you can specify the LogLevel
AWLog.WriteLog(si, XFErrorLevel.Information, "String To Log at Info Level")
AWLog.WriteLog(si, XFErrorLevel.Warning, "String To Log at Warning Level")
AWLog.WriteLog(si, XFErrorLevel.Error, "String To Log at Error Level")
AWLog.WriteLog(si, XFErrorLevel.Fatal, "String To Log at Fatal Level")


' You can also log exceptions
Try
    ' Some code that may throw an exception
Catch ex As Exception
    ' Log the exception
    AWLog.WriteException(si, "Message describing the context of the exception", ex)
End Try