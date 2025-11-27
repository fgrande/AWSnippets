/// Double configuration value
/// Get/Set a double configuration value
/// Config, Double

using Workspace.AWCommons.Commons.Configs;

// Initialize the AWConfig
AWConfig _cfg = new AWConfig(si, globals);

// Get a double configuration value
double defaultValue = 10.0; // [OPTIONAL] Default value if the configuration item does not exist
bool forceRecalculate = false; // [OPTIONAL] Force recalculation of the value from the database. Default is false.
double doubleValue = _cfg.GetDouble("Area", "Subarea", "itemName", defaultValue, forceRecalculate);

// Set a double configuration value
double newValue = 42.0;
string description = "Description"; // [OPTIONAL] Description of the configuration item
_cfg.SetDouble("Area", "Subarea", "itemName", newValue, description);