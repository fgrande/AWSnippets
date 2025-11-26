/// Performance Logger
/// Track execution Performances
/// Logger, Performance

using Workspace.AWCommons.Commons.Helpers.Loggers;

string _myWatchName = "MyWatch";

// Start Watch
AWLog.StartWatch(si, _myWatchName, "Starting MyWatch");

// Do Task # 1

// LogWatch - track time from start 'til the end of Task # 1
AWLog.LogWatch(_myWatchName, "Finished Task #1");

// Do Task # 2

// LogWatch - track time from start 'til the end of Task # 2
AWLog.LogWatch(_myWatchName, "Finished Task #2");

// StopWatch
AWLog.StopWatch(_myWatchName, "Finished MyWatch");

// Checkout the results in the AWPerformance Log dashboard