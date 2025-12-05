/// Get Secret Variable
/// Retrieves the value of a specified secret variable.
/// Commons, Secret, Get

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.InternalUtils

' Initialize AWSecrets object
Dim _secrets As New AWSecrets(si, globals)


' INTEGER SECRET VARIABLE RETRIEVAL
' Base lookup: retrieve the value stored under the main key or fall back to the default
Dim defaultValue As Integer = 10 ' [MANDATORY] default value if the secret variable does not exist
Dim valueFromKey As Integer = _secrets.GetInt("StringKey", defaultValue)

' Scoped lookup: same key narrowed by a version, still falling back to a default
Dim version As String = "version" ' [MANDATORY] subkey for the secret variable
Dim defaultValueWithVersion As Integer = 10 ' [OPTIONAL] default value if the secret variable does not exist
Dim valueFromKeyAndVersion As Integer = _secrets.GetInt("StringKey", version, defaultValueWithVersion)


' DOUBLE SECRET VARIABLE RETRIEVAL
' Base lookup: retrieve the value stored under the main key or fall back to the default
Dim defaultDoubleValue As Double = 10.5 ' [MANDATORY] default value if the secret variable does not exist
Dim doubleValueFromKey As Double = _secrets.GetDouble("StringKey", defaultDoubleValue)

' Scoped lookup: same key narrowed by a version, still falling back to a default
Dim doubleVersion As String = "version" ' [MANDATORY] subkey for the secret variable
Dim defaultDoubleValueWithVersion As Double = 10.5 ' [OPTIONAL] default value if the secret variable does not exist
Dim doubleValueFromKeyAndVersion As Double = _secrets.GetDouble("StringKey", doubleVersion, defaultDoubleValueWithVersion)


' DECIMAL SECRET VARIABLE RETRIEVAL
' Base lookup: retrieve the value stored under the main key or fall back to the default
Dim defaultDecimalValue As Decimal = 20.5D ' [MANDATORY] default value if the secret variable does not exist
Dim decimalValueFromKey As Decimal = _secrets.GetDecimal("StringKey", defaultDecimalValue)

' Scoped lookup: same key narrowed by a version, still falling back to a default
Dim decimalVersion As String = "version" ' [MANDATORY] subkey for the secret variable
Dim defaultDecimalValueWithVersion As Decimal = 20.5D ' [OPTIONAL] default value if the secret variable does not exist
Dim decimalValueFromKeyAndVersion As Decimal = _secrets.GetDecimal("StringKey", decimalVersion, defaultDecimalValueWithVersion)


' STRING SECRET VARIABLE RETRIEVAL
' Base lookup: retrieve the value stored under the main key or fall back to the default
Dim defaultStringValue As String = "DefaultValue" ' [OPTIONAL] default value if the secret variable does not exist
Dim stringValueFromKey As String = _secrets.GetString("StringKey", defaultStringValue)

' Scoped lookup: same key narrowed by a version, still falling back to a default
Dim stringVersion As String = "version" ' [MANDATORY] subkey for the secret variable
Dim defaultStringValueWithVersion As String = "DefaultValue" ' [OPTIONAL] default value if the secret variable does not exist
Dim stringValueFromKeyAndVersion As String = _secrets.GetString("StringKey", stringVersion, defaultStringValueWithVersion)