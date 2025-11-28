/// String configuration value
/// Get/Set a String configuration value
/// Config, String

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.Configs;

// Initialize the AWConfig
AWConfig _cfg = new AWConfig(si, globals);

// Get a string configuration value
string defaultValue = "default"; // [OPTIONAL] Default value if the configuration item does not exist
bool forceRecalculate = false; // [OPTIONAL] Force recalculation of the value from the database. Default is false.
string stringValue = _cfg.GetString("Area", "Subarea", "itemName", defaultValue, forceRecalculate);

// Set a string configuration value
string newValue = "new value";
string description = "Description"; // [OPTIONAL] Description of the configuration item
_cfg.SetString("Area", "Subarea", "itemName", newValue, description);