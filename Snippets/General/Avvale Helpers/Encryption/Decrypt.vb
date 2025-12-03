/// Decrypt string
/// Decrypt a given string using AES encryption.
/// Commons, Encryption, Decrypt, String

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.InternalUtils

' Decrypt a string
Dim encryptedText As String = "GW/D4vlHhDNzqV9He2YYqsyGuJiVQ5l44Fo7qINLzZY="
Dim password As String = "Test" ' [OPTIONAL] password for decryption. If not provided, a default password will be used.
Dim decryptedText As String = AWCrypto.Decrypt(si, encryptedText, password)