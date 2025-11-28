/// Children Metadata Library
/// All methods related to Children Metadata
/// Metadata, Children

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.MetaData;

// Initialize the Children Metadata Library
AWMetadataLibraries _mdlib = new AWMetadataLibraries(si, api, globals);


// Get list of direct children of a given member
DimTypeId dimToRead = DimTypeId.Account; 
List<Member> children = _mdlib.Children(dimToRead, "ParentMemberName"); // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
List<Member> childrenStr = _mdlib.Children("dimToReadStr", "ParentMemberName"); // dimToRead as string: "A", "E", "U1" or "UD1", etc.


// Return all children from a specified dimension
List<Member> allChildren = _mdlib.DimChildren("dimensionName");


// Return a list of Children members as Member objects or just their names
List<Member> childrenMembers = _mdlib.GetChildrenMembers(dimToRead, "MemberName");
List<string> childrenMemberNames = _mdlib.GetChildrenMembersName(dimToRead, "MemberName");


// Check if a member has children
string cubeName = "CubeName"; // [OPTIONAL] the cube name
string scenarioName = "ScenarioName"; // [OPTIONAL] the scenario name
bool hasChildren = _mdlib.HasChildren(dimToRead, "MemberName", cubeName, scenarioName); // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
bool hasChildren = _mdlib.HasChildren("dimToRead", "MemberName", cubeName, scenarioName); // dimToRead as string: "A", "E", "U1" or "UD1", etc.