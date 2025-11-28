/// Valid time period extensions
/// You can determine if a string is a valid time period, month, quarter, or year
/// Extensions, TimePeriod, String

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
imports Workspace.AWCommons.Commons.Extensions;

' Determine if string is a time period
Dim timePeriod As String = "2023M01"
Dim isTimePeriod As Boolean = timePeriod.IsTimePeriod()

' Determine if string is a valid month
Dim monthStr As String = "2023M05"
Dim isMonth As Boolean = monthStr.IsMonth()

' Determine if string is a valid quarter
Dim quarterStr As String = "2023Q3"
Dim isQuarter As Boolean = quarterStr.IsQuarter()

' Determine if string is a valid year
Dim yearStr As String = "2023"
Dim isYear As Boolean = yearStr.IsYear()