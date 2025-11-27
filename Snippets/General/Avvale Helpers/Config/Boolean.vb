/// Boolean configuration value
/// Get/Set a boolean configuration value
/// Config, Boolean, Bool

imports Workspace.AWCommons.Commons.Configs

' Initialize the AWConfig
Dim _cfg As New AWConfig(si, globals)

' Get a boolean configuration value
Dim defaultValue As Boolean = True ' [OPTIONAL] Default value if the configuration item does not exist
Dim forceRecalculate As Boolean = False ' [OPTIONAL] Force recalculation of the value from the database. Default is false.
Dim boolValue As Boolean = _cfg.GetBoolean("Area", "Subarea", "itemName", defaultValue, forceRecalculate)

' Set a boolean configuration value
Dim newValue As Boolean = False
Dim description As String = "Description" ' [OPTIONAL] Description of the configuration item
_cfg.SetBoolean("Area", "Subarea", "itemName", newValue, description)