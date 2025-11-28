/// Get User-Pref Variable
/// Retrieves the value of a specified user-pref variable.
/// Commons, User-Pref, Get

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.InternalUtils;

// Create a UserPrefVariable instance
AWUserPref _userPref = new AWUserPref(si, globals);


// INTEGER USER-PREF VARIABLE RETRIEVAL
// Base lookup: retrieve the value stored under the main key or fall back to the default
int defaultValue = 10; // [MANDATORY] default value if the user-pref variable does not exist
int valueFromKey = _userPref.GetInt("StringKey", defaultValue);

// Scoped lookup: same key narrowed by an optional subkey, still falling back to a default
string subkey = "SubKey"; // [OPTIONAL] subkey for the user-pref variable
int defaultValueWithSubkey = 10; // [OPTIONAL] default value if the user-pref variable does not exist
int valueFromKeyAndSubkey = _userPref.GetInt("StringKey", subkey, defaultValueWithSubkey);


// DOUBLE USER-PREF VARIABLE RETRIEVAL
// Base lookup: retrieve the value stored under the main key or fall back to the default
double defaultDoubleValue = 10.5; // [MANDATORY] default value if the user-pref variable does not exist
double doubleValueFromKey = _userPref.GetDouble("StringKey", defaultDoubleValue);

// Scoped lookup: same key narrowed by an optional subkey, still falling back to a default
string doubleSubkey = "SubKey"; // [OPTIONAL] subkey for the user-pref variable
double defaultDoubleValueWithSubkey = 10.5; // [OPTIONAL] default value if the user-pref variable does not exist
double doubleValueFromKeyAndSubkey = _userPref.GetDouble("StringKey", doubleSubkey, defaultDoubleValueWithSubkey);


// DECIMAL USER-PREF VARIABLE RETRIEVAL
// Base lookup: retrieve the value stored under the main key or fall back to the default
decimal defaultDecimalValue = 20.5m; // [MANDATORY] default value if the user-pref variable does not exist
decimal decimalValueFromKey = _userPref.GetDecimal("StringKey", defaultDecimalValue);

// Scoped lookup: same key narrowed by an optional subkey, still falling back to a default
string decimalSubkey = "SubKey"; // [OPTIONAL] subkey for the user-pref variable
decimal defaultDecimalValueWithSubkey = 20.5m; // [OPTIONAL] default value if the user-pref variable does not exist
decimal decimalValueFromKeyAndSubkey = _userPref.GetDecimal("StringKey", decimalSubkey, defaultDecimalValueWithSubkey);


// STRING USER-PREF VARIABLE RETRIEVAL
// Base lookup: retrieve the value stored under the main key or fall back to the default
string defaultStringValue = "DefaultValue"; // [MANDATORY] default value if the user-pref variable does not exist
string stringValueFromKey = _userPref.GetString("StringKey", defaultStringValue);

// Scoped lookup: same key narrowed by an optional subkey, still falling back to a default
string stringSubkey = "SubKey"; // [OPTIONAL] subkey for the user-pref variable
string defaultStringValueWithSubkey = "DefaultValue"; // [OPTIONAL] default value if the user-pref variable does not exist
string stringValueFromKeyAndSubkey = _userPref.GetString("StringKey", stringSubkey, defaultStringValueWithSubkey);


// OBJECT USER-PREF VARIABLE RETRIEVAL
// Retrieve the value stored under the main key or fall back to the default
string defaultObjectValueWithSubkey = "DefaultValue"; // [OPTIONAL] default value if the user-pref variable does not exist
object objectValueFromKey = _userPref.GetObject<object>("StringKey", defaultObjectValueWithSubkey);


// GET ALL USER-PREF VARIABLES KEYS
// Retrieve all the keys of the user-pref variables
List<string> allUserPrefKeys = _userPref.GetAllKeys();