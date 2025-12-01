/// Children Metadata Library
/// All methods related to Children Metadata
/// Metadata, Children

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.MetaData

' Initialize the Children Metadata Library
Dim _mdlib As New AWMetadataLibraries(si, api, globals)


' Create a new Member in a specified dimension
Dim dimToRead As DimTypeId = DimTypeId.Account ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId
Dim parentId As Integer = 5 ' ID of the parent member
CreateMember(si, dimToRead, "dimensionName", "MemberName", "MemberDescription", parentId)


' Retrieve all members from a specified dimension, including base and parent level members
Dim members As List(Of Member) = _mdlib.GetDimAllMembers("dimensionName")


' Get member by his ID
Dim memberId As Integer = 10
Dim memberById As Member = _mdlib.GetMemberById(dimToRead, memberId) ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.


' Get member id by his name
Dim memberIdByName As Integer = _mdlib.GetMemberIdByName(dimToRead, "MemberName") ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
Dim memberIdByName As Integer = _mdlib.GetMemberIdByName("dimToReadStr", "MemberName") ' dimToRead as string: "A", "E", "U1" or "UD1", etc.


' Get member name by his ID
Dim memberNameById As String = _mdlib.GetMemberNameById(dimToRead, memberId) ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.


' Get member description by his name
Dim memberDescriptionByName As String = _mdlib.GetMemberDescriptionByName(dimToRead, "MemberName") ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
Dim memberDescriptionByName As String = _mdlib.GetMemberDescriptionByName("dimToReadStr", "MemberName") ' dimToRead as string: "A", "E", "U1" or "UD1", etc.


' Get member description by his ID
Dim memberDescriptionById As String = _mdlib.GetMemberDescriptionById(dimToRead, memberId) ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.


' Get member id from a DataBufferCell
Dim dataBufferCell As DataBufferCell = /* Assume this is initialized */
Dim memberIdFromCell As Integer = _mdlib.GetMemberId(dimToRead, dataBufferCell) ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.


' Get list of members from a specified dimension based on a given member name and a relationship type
' Get list of members from a specified dimension based on a given member name and a relationship type
Imports Workspace.AWCommons.Commons.Shared ' You must import this library to use AWRelationship
Dim relationshipType As AWRelationship = AWRelationship.Children ' Relationship type: Base, Children, Descendants
Dim membersByRelationship As List(Of Member) = _mdlib.GetList(dimToRead, "MemberName", relationshipType) ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.


' Get list of members name from a specified dimension based on a given member name and a relationship type
Imports Workspace.AWCommons.Commons.Shared ' You must import this library to use AWRelationship
Dim relationshipType As AWRelationship = AWRelationship.Children ' Relationship type: Base, Children, Descendants
Dim membersNameByRelationship As List(Of String) = _mdlib.GetListName(dimToRead, "MemberName", relationshipType) ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.


' Get member name from a DataBufferCell
Dim dataBufferCell As DataBufferCell = /* Assume this is initialized */
Dim memberNameFromCell As String = _mdlib.GetMemberName(dimToRead, dataBufferCell) ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.


' Get the list of releted members of a specified member
Imports Workspace.AWCommons.Commons.Shared ' You must import this library to use AWRelationship
Dim relationshipType As AWRelationship = AWRelationship.Base ' Relationship type: Base, Children, Descendants
Dim relatedMembers As List(Of Member) = _mdlib.GetRelatedMembers(dimToRead, "MemberName") ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.


' Get the list of releted members name of a specified member
Imports Workspace.AWCommons.Commons.Shared ' You must import this library to use AWRelationship
Dim relationshipType As AWRelationship = AWRelationship.Base ' Relationship type: Base, Children, Descendants
Dim relatedMembersName As List(Of String) = _mdlib.GetRelatedMembersName(dimToRead, "MemberName") ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
