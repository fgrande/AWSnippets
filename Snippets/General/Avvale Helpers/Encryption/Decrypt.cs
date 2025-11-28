/// Decrypt string
/// Decrypt a given string using AES encryption.
/// Commons, Encryption, Decrypt, String

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.InternalUtils;

// Decrypt a string
string encryptedText = "GW/D4vlHhDNzqV9He2YYqsyGuJiVQ5l44Fo7qINLzZY=";
string password = "Test"; // [OPTIONAL] password for decryption. If not provided, a default password will be used.
string decryptedText = AWCrypto.Decrypt(si, encryptedText, password);