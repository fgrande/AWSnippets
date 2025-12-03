/// Integer configuration value
/// Get/Set an integer configuration value
/// Config, Int, Integer

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.Configs

' Initialize the AWConfig
Dim _cfg As New AWConfig(si, globals)

' Get an integer configuration value
Dim defaultValue As Integer = 10 ' [OPTIONAL] Default value if the configuration item does not exist
Dim forceRecalculate As Boolean = False ' [OPTIONAL] Force recalculation of the value from the database. Default is false.
Dim intValue As Integer = _cfg.GetInt("Area", "Subarea", "itemName", defaultValue, forceRecalculate)

' Set an integer configuration value
Dim newValue As Integer = 42
Dim description As String = "Description" ' [OPTIONAL] Description of the configuration item
_cfg.SetInt("Area", "Subarea", "itemName", newValue, description)