/// DataBufferCell Logger
/// Log DataBufferCell
/// Logger, DataBufferCell

imports Workspace.AWCommons.Commons.Extensions

' Create a DataBufferCell
Dim dbc As New DataBufferCell()

' Add some data to the DataBufferCell

' Log the DataBufferCell contents
Dim errorLevel As XFErrorLevel = XFErrorLevel.Information ' [OPTIONAL] log level: Information, Warning, Error, Fatal. Default is Information
dbc.Log(si, api, errorLevel)