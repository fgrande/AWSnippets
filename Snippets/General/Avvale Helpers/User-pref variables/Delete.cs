/// Delete User-Pref Variable
/// Deletes a specified user-pref variable.
/// Commons, User-Pref, Delete

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.InternalUtils;

// Create a UserPrefVariable instance
AWUserPref _userPref = new AWUserPref(si, globals);

// Save some user-pref variables

// Delete user-pref variable by key and optional subkey
string subkeyToDelete = "SubKey"; // [OPTIONAL] subkey for the user-pref variable
_userPref.Delete("StringKey", subkeyToDelete);