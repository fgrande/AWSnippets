/// Get Session Variable
/// Retrieves the value of a specified session variable.
/// Commons, Session, Get

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.InternalUtils;

// Create a SessionVariable instance
AWSession _session = new AWSession(si, globals);


// INTEGER SESSION VARIABLE RETRIEVAL
// Base lookup: retrieve the value stored under the main key or fall back to the default
int defaultValue = 10; // [MANDATORY] default value if the session variable does not exist
int valueFromKey = _session.GetInt("StringKey", defaultValue);

// Scoped lookup: same key narrowed by an optional subkey, still falling back to a default
string subkey = "SubKey"; // [OPTIONAL] subkey for the session variable
int defaultValueWithSubkey = 10; // [OPTIONAL] default value if the session variable does not exist
int valueFromKeyAndSubkey = _session.GetInt("StringKey", subkey, defaultValueWithSubkey);


// DOUBLE SESSION VARIABLE RETRIEVAL
// Base lookup: retrieve the value stored under the main key or fall back to the default
double defaultDoubleValue = 10.5; // [MANDATORY] default value if the session variable does not exist
double doubleValueFromKey = _session.GetDouble("StringKey", defaultDoubleValue);

// Scoped lookup: same key narrowed by an optional subkey, still falling back to a default
string doubleSubkey = "SubKey"; // [OPTIONAL] subkey for the session variable
double defaultDoubleValueWithSubkey = 10.5; // [OPTIONAL] default value if the session variable does not exist
double doubleValueFromKeyAndSubkey = _session.GetDouble("StringKey", doubleSubkey, defaultDoubleValueWithSubkey);


// DECIMAL SESSION VARIABLE RETRIEVAL
// Base lookup: retrieve the value stored under the main key or fall back to the default
decimal defaultDecimalValue = 20.5m; // [MANDATORY] default value if the session variable does not exist
decimal decimalValueFromKey = _session.GetDecimal("StringKey", defaultDecimalValue);

// Scoped lookup: same key narrowed by an optional subkey, still falling back to a default
string decimalSubkey = "SubKey"; // [OPTIONAL] subkey for the session variable
decimal defaultDecimalValueWithSubkey = 20.5m; // [OPTIONAL] default value if the session variable does not exist
decimal decimalValueFromKeyAndSubkey = _session.GetDecimal("StringKey", decimalSubkey, defaultDecimalValueWithSubkey);


// STRING SESSION VARIABLE RETRIEVAL
// Base lookup: retrieve the value stored under the main key or fall back to the default
string defaultStringValue = "DefaultValue"; // [MANDATORY] default value if the session variable does not exist
string stringValueFromKey = _session.GetString("StringKey", defaultStringValue);

// Scoped lookup: same key narrowed by an optional subkey, still falling back to a default
string stringSubkey = "SubKey"; // [OPTIONAL] subkey for the session variable
string defaultStringValueWithSubkey = "DefaultValue"; // [OPTIONAL] default value if the session variable does not exist
string stringValueFromKeyAndSubkey = _session.GetString("StringKey", stringSubkey, defaultStringValueWithSubkey);


// OBJECT SESSION VARIABLE RETRIEVAL
// Retrieve the value stored under the main key or fall back to the default
string defaultObjectValueWithSubkey = "DefaultValue"; // [OPTIONAL] default value if the session variable does not exist
object objectValueFromKey = _session.GetObject<object>("StringKey", defaultObjectValueWithSubkey);


// GET ALL SESSION VARIABLES KEYS
// Retrieve all the keys of the session variables
List<string> allSessionKeys = _session.GetAllKeys();