/// Delete Entry
/// Delete a configuration entry
/// Config, Delete

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.Configs;

// Initialize the AWConfig
AWConfig _cfg = new AWConfig(si, globals);

// Delete a configuration entry
_cfg.DeleteEntry("Area", "Subarea", "itemName");