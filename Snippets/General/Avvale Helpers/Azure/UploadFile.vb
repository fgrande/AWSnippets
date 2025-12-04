/// Azure File Uploader (FileSystem)
/// Upload a File from FileSystem
/// Azure, Upload

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.WebUtils.Azure

' This is the Config SubArea (under Area "Azure") that identifies the Azure Configuration
' for TenantID, ClientID and ClientSecret
Dim _azureSubArea As String = "Test"

' Initialize the AWAzureStorage class
Dim _storage As AWAzureStorage = New AWAzureStorage(si, globals, _azureSubArea)

' As an alternative, we can improve security loading sensitive parameters from Cloud Secrets prepending $: before key names
'AWAzureStorage _storage = new AWAzureStorage(si, globals, "$:SecretTenantIdKey", "$:SecretClientIdKey", "$:SecretClientSecretKey");

Dim _fileName As String = "FileNameToLoad.whatever"
Dim _storageAccount As String = "StorageAccount"
Dim _destFileName As String = "FinalFileName.ext"
Dim _chunkSize As Integer = 65535; ' This is the default, can be omitted

Dim _result As Boolean = _storage.UploadFile(_fileName, _storageAccount, _containerName, _destFileName, _chunkSize)

If (Not _result) Then
    ' File wasn't uploaded, check error log
End If