/// Set User-Pref Variable
/// Sets the value of a specified user-pref variable.
/// Commons, User-Pref, Set

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
imports Workspace.AWCommons.Commons.InternalUtils

' Create a UserPrefVariable instance
Dim _userPref As New AWUserPref(si, globals)


' INTEGER USER-PREF VARIABLE SET
' Set the value under the main key and optional subkey
Dim intSubkey As String = "SubKey" ' [OPTIONAL] subkey for the user-pref variable
Dim intValueToSet As Integer = 15 ' value to set
_userPref.SetInt("StringKey", intValueToSet, intSubkey)


' DOUBLE USER-PREF VARIABLE SET
' Set the value under the main key and optional subkey
Dim doubleSubkey As String = "SubKey" ' [OPTIONAL] subkey for the user-pref variable
Dim doubleValueToSet As Double = 15.5 ' value to set
_userPref.SetDouble("StringKey", doubleValueToSet, doubleSubkey)


' DECIMAL USER-PREF VARIABLE SET
' Set the value under the main key and optional subkey
Dim decimalSubkey As String = "SubKey" ' [OPTIONAL] subkey for the user-pref variable
Dim decimalValueToSet As Decimal = 20.5D ' value to set
_userPref.SetDecimal("StringKey", decimalValueToSet, decimalSubkey)


' STRING USER-PREF VARIABLE SET
' Set the value under the main key and optional subkey
Dim stringSubkey As String = "SubKey" ' [OPTIONAL] subkey for the user-pref variable
Dim stringValueToSet As String = "Value" ' value to set
_userPref.SetString("StringKey", stringValueToSet, stringSubkey)


' OBJECT USER-PREF VARIABLE SET
' Set the value under the main key and optional subkey
Dim objectSubkey As String = "SubKey" ' [OPTIONAL] subkey for the user-pref variable
Dim objectValueToSet As Object = New Object() ' value to set
_userPref.SetObject("StringKey", objectValueToSet, objectSubkey)