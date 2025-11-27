/// Logger files
/// Utilities for the log files
/// Logger, Log, File

imports Workspace.AWCommons.Commons.Helpers.Loggers

' Setup the AWLog
AWLog.Setup(si, globals)

' Log a message

' Get the list of log files
Dim logFiles As FileInfo() = AWLog.GetLogFiles()

' Reset current log file, deleting it
AWLog.Reset()

' Delete a specific log file
AWLog.DeleteLogFile("logFileName.log")

' Clean up log files older than a specified number of days
Dim retentionDays As Integer = 30 ' [OPTIONAL] Number of days to retain log files. Default it reads from configuration.
AWLog.PurgeLogFiles(retentionDays)