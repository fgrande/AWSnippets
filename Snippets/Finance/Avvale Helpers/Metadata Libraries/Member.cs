/// Children Metadata Library
/// All methods related to Children Metadata
/// Metadata, Children

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.MetaData;

// Initialize the Children Metadata Library
AWMetadataLibraries _mdlib = new AWMetadataLibraries(si, api, globals);


// Create a new Member in a specified dimension
DimTypeId dimToRead = DimTypeId.Account; // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId
parentId = 5; // ID of the parent member
CreateMember(si, dimToRead, "dimensionName", "MemberName", "MemberDescription", parentId);


// Retrieve all members from a specified dimension, including base and parent level members
List<Member> members = _mdlib.GetDimAllMembers("dimensionName");


// Get member by his ID
int memberId = 10;
Member memberById = _mdlib.GetMemberById(dimToRead, memberId); // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.


// Get member id by his name
int memberIdByName = _mdlib.GetMemberIdByName(dimToRead, "MemberName"); // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
int memberIdByName = _mdlib.GetMemberIdByName("dimToReadStr", "MemberName"); // dimToRead as string: "A", "E", "U1" or "UD1", etc.


// Get member name by his ID
string memberNameById = _mdlib.GetMemberNameById(dimToRead, memberId); // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.


// Get member description by his name
string memberDescriptionByName = _mdlib.GetMemberDescriptionByName(dimToRead, "MemberName"); // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
string memberDescriptionByName = _mdlib.GetMemberDescriptionByName("dimToReadStr", "MemberName"); // dimToRead as string: "A", "E", "U1" or "UD1", etc.


// Get member description by his ID
string memberDescriptionById = _mdlib.GetMemberDescriptionById(dimToRead, memberId); // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.


// Get member id from a DataBufferCell
DataBufferCell dataBufferCell = /* Assume this is initialized */;
int memberIdFromCell = _mdlib.GetMemberId(dimToRead, dataBufferCell); // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.


// Get list of members from a specified dimension based on a given member name and a relationship type
using Workspace.AWCommons.Commons.Shared; /* You must import this library to use AWRelationship*/
AWRelationship relationshipType = AWRelationship.Children; // Relationship type: Base, Children, Descendants
List<Member> membersByRelationship = _mdlib.GetList(dimToRead, "MemberName", relationshipType); // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.


// Get list of members name from a specified dimension based on a given member name and a relationship type
using Workspace.AWCommons.Commons.Shared; /* You must import this library to use AWRelationship*/
AWRelationship relationshipType = AWRelationship.Children; // Relationship type: Base, Children, Descendants
List<string> membersNameByRelationship = _mdlib.GetListName(dimToRead, "MemberName", relationshipType); // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.


// Get member name from a DataBufferCell
DataBufferCell dataBufferCell = /* Assume this is initialized */;
string memberNameFromCell = _mdlib.GetMemberName(dimToRead, dataBufferCell); // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.


// Get the list of releted members of a specified member
using Workspace.AWCommons.Commons.Shared; /* You must import this library to use AWRelationship*/
AWRelationship relationshipType = AWRelationship.Base; // Relationship type: Base, Children, Descendants
List<Member> relatedMembers = _mdlib.GetRelatedMembers(dimToRead, "MemberName"); // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.


// Get the list of releted members name of a specified member
using Workspace.AWCommons.Commons.Shared; /* You must import this library to use AWRelationship*/
AWRelationship relationshipType = AWRelationship.Base; // Relationship type: Base, Children, Descendants
List<string> relatedMembersName = _mdlib.GetRelatedMembersName(dimToRead, "MemberName"); // Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
