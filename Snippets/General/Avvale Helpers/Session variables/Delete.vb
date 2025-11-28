/// Delete Session Variable
/// Deletes a specified session variable.
/// Commons, Session, Delete

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
imports Workspace.AWCommons.Commons.InternalUtils

' Create a SessionVariable instance
Dim _session As New AWSession(si, globals)

' Save some session variables

' Delete session variable by key and optional subkey
Dim subkeyToDelete As String = "SubKey" ' [OPTIONAL] subkey for the session variable
_session.Delete("StringKey", subkeyToDelete)