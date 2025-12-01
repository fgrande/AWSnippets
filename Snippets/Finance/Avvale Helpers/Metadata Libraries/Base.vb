/// Base Metadata Library
/// All methods related to Base Metadata
/// Metadata, Base

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.MetaData

' Initialize the Base Metadata Library
Dim _mdlib As New AWMetadataLibraries(si, api, globals)


' Get all base members within a specified dimension
DimTypeId dimToRead = DimTypeId.Account; ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
List(Of Member) baseMembers = _mdlib.GetBaseMembers(dimToRead, "MemberName")


' Get all base members names within a specified dimension
DimTypeId dimToRead = DimTypeId.Account ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
List(Of String) baseMemberNames = _mdlib.GetBaseMembersName(dimToRead, "MemberName")


' Check if a member is a base member
Dim isBaseMember As Boolean = _mdlib.IsBase(dimToRead, "ParentName", "MemberName") ' Dimension type of the member: A (Account), E (Entity), U1 or UD1 (UD1), etc.

Dim memberId As Integer = 10
Dim parentId As Integer = 00
Dim isBaseMember As Boolean = _mdlib.IsBase(dimToRead, parentId, memberId) ' Dimension type of the member: A (Account), E (Entity), U1 or UD1 (UD1), etc.

' Check if a member is a base member
 isBaseMember = _mdlib.IsBase(dimToRead, "ParentName", "MemberName") ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.

Dim memberId As Integer = 10
Dim parentId As Integer = 00
Dim isBaseMember As Boolean = _mdlib.IsBase(dimToRead, parentId, memberId) ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.

Dim isBaseMember As Boolean = _mdlib.IsBase("dimToReadStr", "ParentName", "MemberName") ' dimToRead as string: "A", "E", "U1" or "UD1", etc.

Dim memberId As Integer = 10
Dim parentId As Integer = 00
Dim isBaseMember As Boolean = _mdlib.IsBase("dimToReadStr", parentId, memberId) ' dimToRead as string: "A", "E", "U1" or "UD1", etc.