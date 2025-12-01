/// Base Metadata Library
/// All methods related to Base Metadata
/// Metadata, Base

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.MetaData;

// Initialize the Base Metadata Library
AWMetadataLibraries _mdlib = new AWMetadataLibraries(si, api, globals);


// Get all base members within a specified dimension
DimTypeId dimToRead = DimTypeId.Account; // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
List<Member> baseMembers = _mdlib.GetBaseMembers(dimToRead, "MemberName");


// Get all base members names within a specified dimension
DimTypeId dimToRead = DimTypeId.Account; // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
List<string> baseMemberNames = _mdlib.GetBaseMembersName(dimToRead, "MemberName");


// Check if a member is a base member
bool isBaseMember = _mdlib.IsBase(dimToRead, "ParentName", "MemberName"); // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.

int memberId = 10;
int parentId = 00;
bool isBaseMember = _mdlib.IsBase(dimToRead, parentId, memberId); // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.

bool isBaseMember = _mdlib.IsBase("dimToReadStr", "ParentName", "MemberName"); // dimToRead as string: "A", "E", "U1" or "UD1", etc.

int memberId = 10;
int parentId = 00;
bool isBaseMember = _mdlib.IsBase("dimToReadStr", parentId, memberId); // dimToRead as string: "A", "E", "U1" or "UD1", etc.