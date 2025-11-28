/// Set Session Variable
/// Sets the value of a specified session variable.
/// Commons, Session, Set

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.InternalUtils;

// Create a SessionVariable instance
AWSession _session = new AWSession(si, globals);


// INTEGER SESSION VARIABLE SET
// Set the value under the main key and optional subkey
string intSubkey = "SubKey"; // [OPTIONAL] subkey for the session variable
int intValueToSet = 15; // value to set
_session.SetInt("StringKey", intValueToSet, intSubkey);


// DOUBLE SESSION VARIABLE SET
// Set the value under the main key and optional subkey
string doubleSubkey = "SubKey"; // [OPTIONAL] subkey for the session variable
double doubleValueToSet = 15.5; // value to set
_session.SetDouble("StringKey", doubleValueToSet, doubleSubkey);


// DECIMAL SESSION VARIABLE SET
// Set the value under the main key and optional subkey
string decimalSubkey = "SubKey"; // [OPTIONAL] subkey for the session variable
decimal decimalValueToSet = 20.5M; // value to set
_session.SetDecimal("StringKey", decimalValueToSet, decimalSubkey);


// STRING SESSION VARIABLE SET
// Set the value under the main key and optional subkey
string stringSubkey = "SubKey"; // [OPTIONAL] subkey for the session variable
string stringValueToSet = "Value"; // value to set
_session.SetString("StringKey", stringValueToSet, stringSubkey);


// OBJECT SESSION VARIABLE SET
// Set the value under the main key and optional subkey
string objectSubkey = "SubKey"; // [OPTIONAL] subkey for the session variable
object objectValueToSet = new object(); // value to set
_session.SetObject("StringKey", objectValueToSet, objectSubkey);