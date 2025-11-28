/// Get Session Variable
/// Retrieves the value of a specified session variable.
/// Commons, Session, Get

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
imports Workspace.AWCommons.Commons.InternalUtils

' Create a SessionVariable instance
Dim _session As New AWSession(si, globals)


' INTEGER SESSION VARIABLE RETRIEVAL
' Base lookup: retrieve the value stored under the main key or fall back to the default
Dim defaultValue As Integer = 10 ' [MANDATORY] default value if the session variable does not exist
Dim valueFromKey As Integer = _session.GetInt("StringKey", defaultValue)


' Scoped lookup: same key narrowed by an optional subkey, still falling back to a default
Dim subkey As String = "SubKey" ' [OPTIONAL] subkey for the session variable
Dim defaultValueWithSubkey As Integer = 10 ' [OPTIONAL] default value if the session variable does not exist
Dim valueFromKeyAndSubkey As Integer = _session.GetInt("StringKey", subkey, defaultValueWithSubkey)


' DOUBLE SESSION VARIABLE RETRIEVAL
' Base lookup: retrieve the value stored under the main key or fall back to the default
Dim defaultDoubleValue As Double = 10.5 ' [MANDATORY] default value if the session variable does not exist
Dim doubleValueFromKey As Double = _session.GetDouble("StringKey", defaultDoubleValue)


' Scoped lookup: same key narrowed by an optional subkey, still falling back to a default
Dim doubleSubkey As String = "SubKey" ' [OPTIONAL] subkey for the session variable
Dim defaultDoubleValueWithSubkey As Double = 10.5 ' [OPTIONAL] default value if the session variable does not exist
Dim doubleValueFromKeyAndSubkey As Double = _session.GetDouble("StringKey", doubleSubkey, defaultDoubleValueWithSubkey)


' DECIMAL SESSION VARIABLE RETRIEVAL
' Base lookup: retrieve the value stored under the main key or fall back to the default
Dim defaultDecimalValue As Decimal = 20.5D ' [MANDATORY] default value if the session variable does not exist
Dim decimalValueFromKey As Decimal = _session.GetDecimal("StringKey", defaultDecimalValue)


' Scoped lookup: same key narrowed by an optional subkey, still falling back to a default
Dim decimalSubkey As String = "SubKey" ' [OPTIONAL] subkey for the session variable
Dim defaultDecimalValueWithSubkey As Decimal = 20.5D ' [OPTIONAL] default value if the session variable does not exist
Dim decimalValueFromKeyAndSubkey As Decimal = _session.GetDecimal("StringKey", decimalSubkey, defaultDecimalValueWithSubkey)


' STRING SESSION VARIABLE RETRIEVAL
' Base lookup: retrieve the value stored under the main key or fall back to the default
Dim defaultStringValue As String = "DefaultValue" ' [MANDATORY] default value if the session variable does not exist
Dim stringValueFromKey As String = _session.GetString("StringKey", defaultStringValue)


' Scoped lookup: same key narrowed by an optional subkey, still falling back to a default
Dim stringSubkey As String = "SubKey" ' [OPTIONAL] subkey for the session variable
Dim defaultStringValueWithSubkey As String = "DefaultValue" ' [OPTIONAL] default value if the session variable does not exist
Dim stringValueFromKeyAndSubkey As String = _session.GetString("StringKey", stringSubkey, defaultStringValueWithSubkey)


' OBJECT SESSION VARIABLE RETRIEVAL
' Retrieve the value stored under the main key or fall back to the default
Dim defaultObjectValueWithSubkey As String = "DefaultValue" ' [OPTIONAL] default value if the session variable does not exist
Dim objectValueFromKey As Object = _session.GetObject(Of Object)("StringKey", defaultObjectValueWithSubkey)


' GET ALL SESSION VARIABLES KEYS
' Retrieve all the keys of the session variables
Dim allSessionKeys As List(Of String) = _session.GetAllKeys()