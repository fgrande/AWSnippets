/// Valid time period extensions
/// You can determine if a string is a valid time period, month, quarter, or year
/// Extensions, TimePeriod, String

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.Extensions;

// Determine if string is a time period
string timePeriod = "2023M01";
bool isTimePeriod = timePeriod.IsTimePeriod();

// Determine if string is a valid month
string monthStr = "2023M05";
bool isMonth = monthStr.IsMonth();

// Determine if string is a valid quarter
string quarterStr = "2023Q3";
bool isQuarter = quarterStr.IsQuarter();

// Determine if string is a valid year
string yearStr = "2023";
bool isYear = yearStr.IsYear();