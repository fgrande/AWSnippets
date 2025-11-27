/// Valid time period extensions
/// You can determine if a string is a valid time period, month, quarter, or year
/// Extensions, TimePeriod, String

imports Workspace.AWCommons.Commons.Extensions;

' Determine if string is a time period
Dim timePeriod As String = "2023M01"
Dim isTimePeriod As Boolean = timePeriod.IsTimePeriod() ' this will be true

' Determine if string is a valid month
Dim monthStr As String = "2023M05"
Dim isMonth As Boolean = monthStr.IsMonth() ' this will be true
Dim notMonthStr As String = "2023M13"
Dim isNotMonth As Boolean = notMonthStr.IsMonth() ' this will be false

' Determine if string is a valid quarter
Dim quarterStr As String = "2023Q3"
Dim isQuarter As Boolean = quarterStr.IsQuarter() ' this will be true
Dim notQuarterStr As String = "2023Q5"
Dim isNotQuarter As Boolean = notQuarterStr.IsQuarter() ' this will be false

' Determine if string is a valid year
Dim yearStr As String = "2023"
Dim isYear As Boolean = yearStr.IsYear() ' this will be true