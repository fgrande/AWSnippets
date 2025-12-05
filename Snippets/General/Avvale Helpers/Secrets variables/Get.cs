/// Get Secret Variable
/// Retrieves the value of a specified secret variable.
/// Commons, Secret, Get

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.InternalUtils;

// Initialize AWSecrets object
AWSecrets _secrets = new AWSecrets(si, globals);


// INTEGER SECRET VARIABLE RETRIEVAL
// Base lookup: retrieve the value stored under the main key or fall back to the default
int defaultValue = 10; // [MANDATORY] default value if the secret variable does not exist
int valueFromKey = _secrets.GetInt("StringKey", defaultValue);

// Scoped lookup: same key narrowed by a version, still falling back to a default
string version = "version"; // [MANDATORY] subkey for the secret variable
int defaultValueWithVersion = 10; // [OPTIONAL] default value if the secret variable does not exist
int valueFromKeyAndVersion = _secrets.GetInt("StringKey", version, defaultValueWithVersion);


// DOUBLE SECRET VARIABLE RETRIEVAL
// Base lookup: retrieve the value stored under the main key or fall back to the default
double defaultDoubleValue = 10.5; // [MANDATORY] default value if the secret variable does not exist
double doubleValueFromKey = _secrets.GetDouble("StringKey", defaultDoubleValue);

// Scoped lookup: same key narrowed by a version, still falling back to a default
string doubleVersion = "version"; // [MANDATORY] subkey for the secret variable
double defaultDoubleValueWithVersion = 10.5; // [OPTIONAL] default value if the secret variable does not exist
double doubleValueFromKeyAndVersion = _secrets.GetDouble("StringKey", doubleVersion, defaultDoubleValueWithVersion);


// DECIMAL SECRET VARIABLE RETRIEVAL
// Base lookup: retrieve the value stored under the main key or fall back to the default
decimal defaultDecimalValue = 20.5m; // [MANDATORY] default value if the secret variable does not exist
decimal decimalValueFromKey = _secrets.GetDecimal("StringKey", defaultDecimalValue);

// Scoped lookup: same key narrowed by a version, still falling back to a default
string decimalVersion = "version"; // [MANDATORY] subkey for the secret variable
decimal defaultDecimalValueWithVersion = 20.5m; // [OPTIONAL] default value if the secret variable does not exist
decimal decimalValueFromKeyAndVersion = _secrets.GetDecimal("StringKey", decimalVersion, defaultDecimalValueWithVersion);


// STRING SECRET VARIABLE RETRIEVAL
// Base lookup: retrieve the value stored under the main key or fall back to the default
string defaultStringValue = "DefaultValue"; // [OPTIONAL] default value if the secret variable does not exist
string stringValueFromKey = _secrets.GetString("StringKey", defaultStringValue);

// Scoped lookup: same key narrowed by a version, still falling back to a default
string stringVersion = "version"; // [MANDATORY] subkey for the secret variable
string defaultStringValueWithVersion = "DefaultValue"; // [OPTIONAL] default value if the secret variable does not exist
string stringValueFromKeyAndVersion = _secrets.GetString("StringKey", stringVersion, defaultStringValueWithVersion);