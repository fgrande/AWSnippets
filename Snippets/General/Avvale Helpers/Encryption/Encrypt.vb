/// Encrypt string
/// Encrypt a given string using AES encryption.
/// Commons, Encryption, Encrypt, String

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
imports Workspace.AWCommons.Commons.InternalUtils

' Encrypt a string
Dim plainText As String = "This is a test"
Dim password As String = "Test" ' [OPTIONAL] password for encryption. If not provided, a default password will be used.
Dim encryptedText As String = AWCrypto.Encrypt(si, plainText, password)