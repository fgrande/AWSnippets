/// Encrypt string
/// Encrypt a given string using AES encryption.
/// Commons, Encryption, Encrypt, String

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.InternalUtils;

// Encrypt a string
string plainText = "This is a test";
string password = "Test"; // [OPTIONAL] password for encryption. If not provided, a default password will be used.
string encryptedText = AWCrypto.Encrypt(si, plainText, password);