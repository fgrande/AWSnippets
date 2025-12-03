/// Delete User-Pref Variable
/// Deletes a specified user-pref variable.
/// Commons, User-Pref, Delete

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.InternalUtils

' Create a UserPrefVariable instance
Dim _userPref As New AWUserPref(si, globals)

' Save some user-pref variables

' Delete user-pref variable by key and optional subkey
Dim subkeyToDelete As String = "SubKey" ' [OPTIONAL] subkey for the user-pref variable
_userPref.Delete("StringKey", subkeyToDelete)