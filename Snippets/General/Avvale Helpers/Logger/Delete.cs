/// Delete log/performance
/// Delete Error Log or Performance entries
/// Logger, Log, Performance, Delete, Purge

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.Helpers.Loggers;

// First, setup the Logging system (once)
AWLog.Setup(si, globals);

// Log something

// Delete Error Log entries older than a specific date
int retentionDays = 30; // Number of days to retain. 
string userName = "Administrator"; // It can be use to delete only entries created by a specific user. "*" means all users. Default is the current user.
string appName = "Application"; // It can be use to delete only entries created by a specific application. Default is the current application.
AWLog.PurgeErrorLog(retentionDays, userName, appName);

// Delete all Error Log entries (!!USE WITH CAUTION!!)
AWLog.TruncateErrorLog();


// Delete Performance entries older than a specific date
int retentionDays = 30; // Number of days to retain. If not specified, it will use the configuration default.
AWLog.PurgeWatches(retentionDays);

// Delete all Performance entries (!!USE WITH CAUTION!!)
AWLog.TruncatePerformanceTable();