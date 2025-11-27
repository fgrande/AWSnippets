/// Boolean configuration value
/// Get/Set a boolean configuration value
/// Config, Boolean, Bool

using Workspace.AWCommons.Commons.Configs;

// Initialize the AWConfig
AWConfig _cfg = new AWConfig(si, globals);

// Get a boolean configuration value
bool defaultValue = true; // [OPTIONAL] Default value if the configuration item does not exist
bool forceRecalculate = false; // [OPTIONAL] Force recalculation of the value from the database. Default is false.
bool boolValue = _cfg.GetBoolean("Area", "Subarea", "itemName", defaultValue, forceRecalculate);

// Set a boolean configuration value
bool newValue = false;
string description = "Description"; // [OPTIONAL] Description of the configuration item
_cfg.SetBoolean("Area", "Subarea", "itemName", newValue, description);