/// Delete Entry
/// Delete a configuration entry
/// Config, Delete

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.Configs

' Initialize the AWConfig
Dim _cfg As New AWConfig(si, globals)

' Delete a configuration entry
_cfg.DeleteEntry("Area", "Subarea", "itemName")