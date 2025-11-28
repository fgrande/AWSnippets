/// Delete Session Variable
/// Deletes a specified session variable.
/// Commons, Session, Delete

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.InternalUtils;

// Create a SessionVariable instance
AWSession _session = new AWSession(si, globals);

// Save some session variables

// Delete session variable by key and optional subkey
string subkeyToDelete = "SubKey"; // [OPTIONAL] subkey for the session variable
_session.Delete("StringKey", subkeyToDelete);