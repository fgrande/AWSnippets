/// Integer configuration value
/// Get/Set an integer configuration value
/// Config, Int, Integer

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.Configs;

// Initialize the AWConfig
AWConfig _cfg = new AWConfig(si, globals);

// Get an integer configuration value
int defaultValue = 10; // [OPTIONAL] Default value if the configuration item does not exist
bool forceRecalculate = false; // [OPTIONAL] Force recalculation of the value from the database. Default is false.
int intValue = _cfg.GetInt("Area", "Subarea", "itemName", defaultValue, forceRecalculate);

// Set an integer configuration value
int newValue = 42;
string description = "Description"; // [OPTIONAL] Description of the configuration item
_cfg.SetInt("Area", "Subarea", "itemName", newValue, description);