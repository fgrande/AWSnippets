/// Double configuration value
/// Get/Set a Double configuration value
/// Config, Double

imports Workspace.AWCommons.Commons.Configs

' Initialize the AWConfig
Dim _cfg As New AWConfig(si, globals)

' Get a double configuration value
Dim defaultValue As Double = 10.0 ' [OPTIONAL] Default value if the configuration item does not exist
Dim forceRecalculate As Boolean = False ' [OPTIONAL] Force recalculation of the value from the database. Default is false.
Dim doubleValue As Double = _cfg.GetDouble("Area", "Subarea", "itemName", defaultValue, forceRecalculate)

' Set a double configuration value
Dim newValue As Double = 42.0
Dim description As String = "Description" ' [OPTIONAL] Description of the configuration item
_cfg.SetDouble("Area", "Subarea", "itemName", newValue, description)