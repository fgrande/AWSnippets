/// Children Metadata Library
/// All methods related to Children Metadata
/// Metadata, Children

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.MetaData


' Initialize the Children Metadata Library
Dim _mdlib As New AWMetadataLibraries(si, api, globals)


' Get list of direct children of a given member
DimTypeId dimToRead = DimTypeId.Account 
Dim children As List(Of Member) = _mdlib.Children(dimToRead, "ParentMemberName") ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
Dim childrenStr As List(Of Member) = _mdlib.Children("dimToReadStr", "ParentMemberName") ' dimToRead as string: "A", "E", "U1" or "UD1", etc.


' Return all children from a specified dimension
Dim allChildren As List(Of Member) = _mdlib.DimChildren("dimensionName") ' dimensionName as string: "Account", "Entity", "UD1", etc.


' Return a list of Children members as Member objects or just their names
Dim childrenMembers As List(Of Member) = _mdlib.GetChildrenMembers(dimToRead, "MemberName")
Dim childrenMemberNames As List(Of String) = _mdlib.GetChildrenMembersName(dimToRead, "MemberName")


' Check if a member has children
Dim cubeName As String = "CubeName" ' [OPTIONAL] the cube name
Dim scenarioName As String = "ScenarioName" ' [OPTIONAL] the scenario name
Dim hasChildren As Boolean = _mdlib.HasChildren(dimToRead, "MemberName", cubeName, scenarioName) ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
Dim hasChildren As Boolean = _mdlib.HasChildren("dimToRead", "MemberName", cubeName, scenarioName) ' dimToRead as string: "A", "E", "U1" or "UD1", etc.
