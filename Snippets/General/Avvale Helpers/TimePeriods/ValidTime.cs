/// Valid time period extensions
/// You can determine if a string is a valid time period, month, quarter, or year
/// Extensions, TimePeriod, String

using Workspace.AWCommons.Commons.Extensions;

// Determine if string is a time period
string timePeriod = "2023M01";
bool isTimePeriod = timePeriod.IsTimePeriod(); // this will be true

// Determine if string is a valid month
string monthStr = "2023M05";
bool isMonth = monthStr.IsMonth(); // this will be true
string notMonthStr = "2023M13";
bool isNotMonth = notMonthStr.IsMonth(); // this will be false

// Determine if string is a valid quarter
string quarterStr = "2023Q3";
bool isQuarter = quarterStr.IsQuarter(); // this will be true
string notQuarterStr = "2023Q5";
bool isNotQuarter = notQuarterStr.IsQuarter(); // this will be false

// Determine if string is a valid year
string yearStr = "2023";
bool isYear = yearStr.IsYear(); // this will be true