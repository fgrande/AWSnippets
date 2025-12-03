/// Export DataTable in Parquet Format
/// Export DataTable in Parquet Format
/// Parquet, Exporter, DataTable

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.Helpers.DBHelpers;
using Workspace.AWCommons.Commons.DataExchange;

' Create a temporary file under Windows Temp (OS managed)
Dim _tmpFileName As String = Path.GetTempFileName();

Dim _dt As DataTable = _mgr.GetDataTable($"SELECT * FROM MyTable");
				
Dim _exp As ParquetExporter = New ParquetExporter(si, globals);
' Export DataTable into tmpFile (Parquet Format), chunking by 50000 reocrds (this is optional, defaults to 10000)
Dim _res as Integer = _exp.ExportFromDataTable(_dt, _tmpFileName, 50000).Result;

' _res contains the number of exported records