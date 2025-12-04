/// Azure File Uploader (FileSystem)
/// Upload a File from FileSystem
/// Azure, Upload

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.WebUtils.Azure;

// This is the Config SubArea (under Area "Azure") that identifies the Azure Configuration
// for TenantID, ClientID and ClientSecret
string _azureSubArea = "Test";

// Initialize the AWAzureStorage class
AWAzureStorage _storage = new AWAzureStorage(si, globals, _azureSubArea);

// As an alternative, we can improve security loading sensitive parameters from Cloud Secrets prepending $: before key names
//AWAzureStorage _storage = new AWAzureStorage(si, globals, "$:SecretTenantIdKey", "$:SecretClientIdKey", "$:SecretClientSecretKey");

string _fileName = "FileNameToLoad.whatever";
string _storageAccount = "StorageAccount";
string _destFileName = "FinalFileName.ext";
int _chunkSize = 65535; // This is the default, can be omitted

bool _result = _storage.UploadFile(_fileName, _storageAccount, _containerName, _destFileName, _chunkSize);

if (!_result)
{
    // File wasn't uploaded, check error log
}