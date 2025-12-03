/// Azure File Uploader (Running)
/// Upload a File from an Enumeration cycle
/// Azure, Upload

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.WebUtils.Azure;
using Workspace.AWCommons.Commons.Helpers.DBHelpers;

// This is the Config SubArea (under Area "Azure") that identifies the Azure Configuration
// for TenantID, ClientID and ClientSecret
string _azureSubArea = "Test";

// Load a DataTable
AWDBManager _mgr = new AWDBManager(si, globals);
DataTable _dt = _mgr.GetDataTable("SELECT * FROM MyTable");

// Initialize the AWAzureStorage class
AWAzureStorage _storage = new AWAzureStorage(si, globals, _azureSubArea);

string _storageAccount = "StorageAccount";
string _destFileName = "FinalFileName.ext";
int _chunkSize = 65535; // This is the default, can be omitted

// Start the Upload vs Azure
_storage.ChunkUploadStart(_storageAccount, _containerName, _destFileName);

int _chunkRows = 1000; // Send data every 1000 rows
StringBuilder _sb = new StringBuilder();

int _cnt = 0;
foreach (DataRow _row in _dt.Rows)
{
    string _row = _row.GetAsCSV();
    _sb.AppendLine(_row);

    if (_cnt % _chunkRows == 0)
    {
        // Send Data to Azure
        _storage.ChunkUpload(_sb.ToString());
        _sb.Clear();
    }
}

if (_sb.Length > 0)
{
    _storage.ChunkUpload(_sb.ToString());
}

// Ends the Azure Upload
bool _result = _storage.ChunkUploadClose();

if (!_result)
{
    // File wasn't uploaded, check error log
}