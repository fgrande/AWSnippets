/// Log DataTable
/// DataTable Logger
/// Logger, DataTable

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
imports Workspace.AWCommons.Commons.Extensions

' Create a DataTable
Dim dt As New DataTable()

' Add some elements to the DataTable

' Log the DataTable contents
Dim errorLevel As XFErrorLevel = XFErrorLevel.Information ' [OPTIONAL] log level: Information, Warning, Error, Fatal. Default is Information
Dim maxRows As Integer = 1000 ' [OPTIONAL] maximum number of rows to log. (Default is 5000)
Dim separator As String = "," ' [OPTIONAL] separator for the logged data. (Default is semicolon ";")

dt.Log(si, api, "Message", errorLevel, maxRows, separator)