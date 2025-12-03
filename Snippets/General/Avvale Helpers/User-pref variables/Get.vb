/// Get User-Pref Variable
/// Retrieves the value of a specified user-pref variable.
/// Commons, User-Pref, Get

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.InternalUtils

' Create a UserPrefVariable instance
Dim _userPref As New AWUserPref(si, globals)


' INTEGER USER-PREF VARIABLE RETRIEVAL
' Base lookup: retrieve the value stored under the main key or fall back to the default
Dim defaultValue As Integer = 10 ' [MANDATORY] default value if the user-pref variable does not exist
Dim valueFromKey As Integer = _userPref.GetInt("StringKey", defaultValue)


' Scoped lookup: same key narrowed by an optional subkey, still falling back to a default
Dim subkey As String = "SubKey" ' [OPTIONAL] subkey for the user-pref variable
Dim defaultValueWithSubkey As Integer = 10 ' [OPTIONAL] default value if the user-pref variable does not exist
Dim valueFromKeyAndSubkey As Integer = _userPref.GetInt("StringKey", subkey, defaultValueWithSubkey)


' DOUBLE USER-PREF VARIABLE RETRIEVAL
' Base lookup: retrieve the value stored under the main key or fall back to the default
Dim defaultDoubleValue As Double = 10.5 ' [MANDATORY] default value if the user-pref variable does not exist
Dim doubleValueFromKey As Double = _userPref.GetDouble("StringKey", defaultDoubleValue)


' Scoped lookup: same key narrowed by an optional subkey, still falling back to a default
Dim doubleSubkey As String = "SubKey" ' [OPTIONAL] subkey for the user-pref variable
Dim defaultDoubleValueWithSubkey As Double = 10.5 ' [OPTIONAL] default value if the user-pref variable does not exist
Dim doubleValueFromKeyAndSubkey As Double = _userPref.GetDouble("StringKey", doubleSubkey, defaultDoubleValueWithSubkey)


' DECIMAL USER-PREF VARIABLE RETRIEVAL
' Base lookup: retrieve the value stored under the main key or fall back to the default
Dim defaultDecimalValue As Decimal = 20.5D ' [MANDATORY] default value if the user-pref variable does not exist
Dim decimalValueFromKey As Decimal = _userPref.GetDecimal("StringKey", defaultDecimalValue)


' Scoped lookup: same key narrowed by an optional subkey, still falling back to a default
Dim decimalSubkey As String = "SubKey" ' [OPTIONAL] subkey for the user-pref variable
Dim defaultDecimalValueWithSubkey As Decimal = 20.5D ' [OPTIONAL] default value if the user-pref variable does not exist
Dim decimalValueFromKeyAndSubkey As Decimal = _userPref.GetDecimal("StringKey", decimalSubkey, defaultDecimalValueWithSubkey)


' STRING USER-PREF VARIABLE RETRIEVAL
' Base lookup: retrieve the value stored under the main key or fall back to the default
Dim defaultStringValue As String = "DefaultValue" ' [MANDATORY] default value if the user-pref variable does not exist
Dim stringValueFromKey As String = _userPref.GetString("StringKey", defaultStringValue)


' Scoped lookup: same key narrowed by an optional subkey, still falling back to a default
Dim stringSubkey As String = "SubKey" ' [OPTIONAL] subkey for the user-pref variable
Dim defaultStringValueWithSubkey As String = "DefaultValue" ' [OPTIONAL] default value if the user-pref variable does not exist
Dim stringValueFromKeyAndSubkey As String = _userPref.GetString("StringKey", stringSubkey, defaultStringValueWithSubkey)


' OBJECT USER-PREF VARIABLE RETRIEVAL
' Retrieve the value stored under the main key or fall back to the default
Dim defaultObjectValueWithSubkey As String = "DefaultValue" ' [OPTIONAL] default value if the user-pref variable does not exist
Dim objectValueFromKey As Object = _userPref.GetObject(Of Object)("StringKey", defaultObjectValueWithSubkey)


' GET ALL USER-PREF VARIABLES KEYS
' Retrieve all the keys of the user-pref variables
Dim allUserPrefKeys As List(Of String) = _userPref.GetAllKeys()