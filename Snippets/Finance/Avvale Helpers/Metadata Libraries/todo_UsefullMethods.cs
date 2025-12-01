/// Usefull methods
/// Some usefull methods concerning Metadata
/// Metadata, Helpers, Usefull

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.MetaData;

// Initialize the Base Metadata Library
AWMetadataLibraries _mdlib = new AWMetadataLibraries(si, api, globals);


// Get DimTypeId from string representation. here are the mappings:
// ShortName: "A" ==========>  DimTypeId.Account
// ShortName: "C" ==========>  DimTypeId.Consolidation
// ShortName: "I" ==========>  DimTypeId.IC
// ShortName: "E" ==========>  DimTypeId.Entity
// ShortName: "F" ==========>  DimTypeId.Flow
// ShortName: "O" ==========>  DimTypeId.Origin
// ShortName: "P" ==========>  DimTypeId.Entity
// ShortName: "S" ==========>  DimTypeId.Scenario
// ShortName: "T" ==========>  DimTypeId.Time
// ShortName: "V" ==========>  DimTypeId.View
// ShortName: "U1" or "UD1" => DimTypeId.UD1
// ShortName: "U2" or "UD2" => DimTypeId.UD2
// ShortName: "U3" or "UD3" => DimTypeId.UD3
// ShortName: "U4" or "UD4" => DimTypeId.UD4
// ShortName: "U5" or "UD5" => DimTypeId.UD5
// ShortName: "U6" or "UD6" => DimTypeId.UD6
// ShortName: "U7" or "UD7" => DimTypeId.UD7
// ShortName: "U8" or "UD8" => DimTypeId.UD8
DimTypeId dimType = _mdlib.GetDimTypeIdFromString("A");


// Get OneStream prefix for a given dimension
// Example: for DimTypeId.Account, it will return "A#"
string dimPrefix = _mdlib.GetEntityPrefix(DimTypeId.Account); // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
