/// String configuration value
/// Get/Set a String configuration value
/// Config, String

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.Configs

' Initialize the AWConfig
Dim _cfg As New AWConfig(si, globals)

' Get a string configuration value
Dim defaultValue As String = "default" ' [OPTIONAL] Default value if the configuration item does not exist
Dim forceRecalculate As Boolean = False ' [OPTIONAL] Force recalculation of the value from the database. Default is false.
Dim stringValue As String = _cfg.GetString("Area", "Subarea", "itemName", defaultValue, forceRecalculate)

' Set a string configuration value
Dim newValue As String = "new value"
Dim description As String = "Description" ' [OPTIONAL] Description of the configuration item
_cfg.SetString("Area", "Subarea", "itemName", newValue, description)