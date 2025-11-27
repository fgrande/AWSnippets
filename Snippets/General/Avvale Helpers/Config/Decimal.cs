/// Decimal configuration value
/// Get/Set a decimal configuration value
/// Config, Decimal

using Workspace.AWCommons.Commons.Configs;

// Initialize the AWConfig
AWConfig _cfg = new AWConfig(si, globals);

// Get a decimal configuration value
decimal defaultValue = 10.0m; // [OPTIONAL] Default value if the configuration item does not exist
bool forceRecalculate = false; // [OPTIONAL] Force recalculation of the value from the database. Default is false.
decimal decimalValue = _cfg.GetDecimal("Area", "Subarea", "itemName", defaultValue, forceRecalculate);

// Set a decimal configuration value
decimal newValue = 42.0m;
string description = "Description"; // [OPTIONAL] Description of the configuration item
_cfg.SetDecimal("Area", "Subarea", "itemName", newValue, description);