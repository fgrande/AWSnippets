/// Decimal configuration value
/// Get/Set a Decimal configuration value
/// Config, Decimal

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
imports Workspace.AWCommons.Commons.Configs

' Initialize the AWConfig
Dim _cfg As New AWConfig(si, globals)

' Get a decimal configuration value
Dim defaultValue As Decimal = 10.0D ' [OPTIONAL] Default value if the configuration item does not exist
Dim forceRecalculate As Boolean = False ' [OPTIONAL] Force recalculation of the value from the database. Default is false.
Dim decimalValue As Decimal = _cfg.GetDecimal("Area", "Subarea", "itemName", defaultValue, forceRecalculate)

' Set a decimal configuration value
Dim newValue As Decimal = 42.0D
Dim description As String = "Description" ' [OPTIONAL] Description of the configuration item
_cfg.SetDecimal("Area", "Subarea", "itemName", newValue, description)