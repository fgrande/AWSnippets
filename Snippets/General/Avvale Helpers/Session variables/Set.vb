/// Set Session Variable
/// Sets the value of a specified session variable.
/// Commons, Session, Set

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.InternalUtils

' Create a SessionVariable instance
Dim _session As New AWSession(si, globals)


' INTEGER SESSION VARIABLE SET
' Set the value under the main key and optional subkey
Dim intSubkey As String = "SubKey" ' [OPTIONAL] subkey for the session variable
Dim intValueToSet As Integer = 15 ' value to set
_session.SetInt("StringKey", intValueToSet, intSubkey)


' DOUBLE SESSION VARIABLE SET
' Set the value under the main key and optional subkey
Dim doubleSubkey As String = "SubKey" ' [OPTIONAL] subkey for the session variable
Dim doubleValueToSet As Double = 15.5 ' value to set
_session.SetDouble("StringKey", doubleValueToSet, doubleSubkey)


' DECIMAL SESSION VARIABLE SET
' Set the value under the main key and optional subkey
Dim decimalSubkey As String = "SubKey" ' [OPTIONAL] subkey for the session variable
Dim decimalValueToSet As Decimal = 20.5D ' value to set
_session.SetDecimal("StringKey", decimalValueToSet, decimalSubkey)


' STRING SESSION VARIABLE SET
' Set the value under the main key and optional subkey
Dim stringSubkey As String = "SubKey" ' [OPTIONAL] subkey for the session variable
Dim stringValueToSet As String = "Value" ' value to set
_session.SetString("StringKey", stringValueToSet, stringSubkey)


' OBJECT SESSION VARIABLE SET
' Set the value under the main key and optional subkey
Dim objectSubkey As String = "SubKey" ' [OPTIONAL] subkey for the session variable
Dim objectValueToSet As Object = New Object() ' value to set
_session.SetObject("StringKey", objectValueToSet, objectSubkey)