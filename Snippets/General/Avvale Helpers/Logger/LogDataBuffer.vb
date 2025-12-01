/// Log DataBuffer
/// DataBuffer and DataBufferCell logger
/// Logger, DataBuffer, DataBufferCell

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
imports Workspace.AWCommons.Commons.Extensions



' Create a DataBuffer
Dim db As New DataBuffer()

' Add some data to the DataBuffer

' Log the DataBuffer contents, its an improvement of LogDataBuffer
Dim errorLevel As XFErrorLevel = XFErrorLevel.Information ' [OPTIONAL] log level: Information, Warning, Error, Fatal. Default is Information
Dim maxRows As Integer = 1000 ' [OPTIONAL] maximum number of rows to log. (Default is 5000)
Dim separator As String = "," ' [OPTIONAL] separator for the logged data. (Default is semicolon ";")

db.Log(si, api, "Message", errorLevel, maxRows, separator)



' Create a DataBufferCell
Dim dbc As New DataBufferCell()

' Add some data to the DataBufferCell

' Log the DataBufferCell contents
Dim errorLevel As XFErrorLevel = XFErrorLevel.Information ' [OPTIONAL] log level: Information, Warning, Error, Fatal. Default is Information
dbc.Log(si, api, errorLevel)