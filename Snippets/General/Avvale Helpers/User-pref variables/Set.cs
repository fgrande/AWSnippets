/// Set User-Pref Variable
/// Sets the value of a specified user-pref variable.
/// Commons, User-Pref, Set

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.InternalUtils;

// Create a UserPrefVariable instance
AWUserPref _userPref = new AWUserPref(si, globals);


// INTEGER USER-PREF VARIABLE SET
// Set the value under the main key and optional subkey
string intSubkey = "SubKey"; // [OPTIONAL] subkey for the user-pref variable
int intValueToSet = 15; // value to set
_userPref.SetInt("StringKey", intValueToSet, intSubkey);


// DOUBLE USER-PREF VARIABLE SET
// Set the value under the main key and optional subkey
string doubleSubkey = "SubKey"; // [OPTIONAL] subkey for the user-pref variable
double doubleValueToSet = 15.5; // value to set
_userPref.SetDouble("StringKey", doubleValueToSet, doubleSubkey);


// DECIMAL USER-PREF VARIABLE SET
// Set the value under the main key and optional subkey
string decimalSubkey = "SubKey"; // [OPTIONAL] subkey for the user-pref variable
decimal decimalValueToSet = 20.5M; // value to set
_userPref.SetDecimal("StringKey", decimalValueToSet, decimalSubkey);


// STRING USER-PREF VARIABLE SET
// Set the value under the main key and optional subkey
string stringSubkey = "SubKey"; // [OPTIONAL] subkey for the user-pref variable
string stringValueToSet = "Value"; // value to set
_userPref.SetString("StringKey", stringValueToSet, stringSubkey);


// OBJECT USER-PREF VARIABLE SET
// Set the value under the main key and optional subkey
string objectSubkey = "SubKey"; // [OPTIONAL] subkey for the user-pref variable
object objectValueToSet = new object(); // value to set
_userPref.SetObject("StringKey", objectValueToSet, objectSubkey);