/// Children Metadata Library
/// All methods related to Children Metadata
/// Metadata, Children

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.MetaData;

// Initialize the Children Metadata Library
AWMetadataLibraries _mdlib = new AWMetadataLibraries(si, api, globals);

// Get list of direct children of a given member
DimTypeId dimToRead = DimTypeId.Account; // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
List<Member> children = _mdlib.Children(dimToRead, "ParentMemberName");
// You can also pass dimToRead as string
string dimToReadStr = "A"; // "A" for Account, "E" for Entity, "U1" or "UD1" for UD1, etc.
List<Member> childrenStr = _mdlib.Children(dimToReadStr, "ParentMemberName");

// Return all children from a specified dimension
List<Member> allChildren = _mdlib.DimChildren("dimensionName");

