/// Azure File Uploader (Running)
/// Upload a File from an Enumeration cycle
/// Azure, Upload

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.WebUtils.Azure
Imports Workspace.AWCommons.Commons.Helpers.DBHelpers

' This is the Config SubArea (under Area "Azure") that identifies the Azure Configuration
' for TenantID, ClientID and ClientSecret
Dim _azureSubArea As String = "Test"

' Load a DataTable
Dim _mgr As New AWDBManager(si, globals)
Dim _dt As DataTable = _mgr.GetDataTable("SELECT * FROM MyTable")

' Initialize the AWAzureStorage class
Dim _storage As New AWAzureStorage(si, globals, _azureSubArea)

' As an alternative, we can improve security loading sensitive parameters from Cloud Secrets prepending $: before key names
'AWAzureStorage _storage = new AWAzureStorage(si, globals, "$:SecretTenantIdKey", "$:SecretClientIdKey", "$:SecretClientSecretKey");

Dim _storageAccount As String = "StorageAccount"
Dim _destFileName As String = "FinalFileName.ext"
Dim _chunkSize As Integer = 65535 ' This is the default, can be omitted

' Start the Upload vs Azure
_storage.ChunkUploadStart(_storageAccount, _containerName, _destFileName)

Dim _chunkRows As Integer = 1000 ' Send data every 1000 rows
Dim _sb As New System.Text.StringBuilder()

Dim _cnt As Integer = 0
For Each _row As DataRow In _dt.Rows
    Dim _row As String = _row.GetAsCSV()
    _sb.AppendLine(_row)

    If _cnt Mod _chunkRows = 0 Then
        ' Send Data to Azure
        _storage.ChunkUpload(_sb.ToString())
        _sb.Clear()
    End If
Next

If _sb.Length > 0 Then
    _storage.ChunkUpload(_sb.ToString())
End If

' Ends the Azure Upload
Dim _result As Boolean = _storage.ChunkUploadClose()

If Not _result Then
    ' File wasn't uploaded, check error log
End If