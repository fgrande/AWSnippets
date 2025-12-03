/// Export DataTable in Parquet Format
/// Export DataTable in Parquet Format
/// Parquet, Exporter, DataTable

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.Helpers.DBHelpers;
using Workspace.AWCommons.Commons.DataExchange;

// Create a temporary file under Windows Temp (OS managed)
string _tmpFileName = Path.GetTempFileName();

DataTable _dt = _mgr.GetDataTable($"SELECT * FROM MyTable");
				
ParquetExporter _exp = new ParquetExporter(si, globals);
// Export DataTable into tmpFile (Parquet Format), chunking by 50000 reocrds (this is optional, defaults to 10000)
int _res = _exp.ExportFromDataTable(_dt, _tmpFileName, 50000).Result;

// _res contains the number of exported records