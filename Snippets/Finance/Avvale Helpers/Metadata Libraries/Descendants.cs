/// Descendants Metadata Library
/// All methods related to Descendants Metadata
/// Metadata, Descendants

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.MetaData;

// Initialize the Descendants Metadata Library
AWMetadataLibraries _mdlib = new AWMetadataLibraries(si, api, globals);


// Get all descendants members within a specified dimension
DimTypeId dimToRead = DimTypeId.Account; // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
List<Member> descendants = _mdlib.GetDescendantsMembers(dimToRead, "MemberName");


// Get all descendants members names within a specified dimension
DimTypeId dimToRead = DimTypeId.Account; // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
List<string> descendantsNames = _mdlib.GetDescendantsMembersName(dimToRead, "MemberName");
