/// DataUnitPk Extensions
/// Extend DataUnitPk functionalities
/// Extensions, DataUnitPk

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.Extensions;

// Create a DataUnitPk instance
DataUnitPk pk = new DataUnitPk("CubeId", "EntityId", "ParentId", "ConsId", "ScenarioId", "TimeId");

// Get DataUnitPk id/coordinates
string coordinates = pk.ToKey();

// Get DataUnitPk as script string
string scriptString = pk.ToKeyExt(api);