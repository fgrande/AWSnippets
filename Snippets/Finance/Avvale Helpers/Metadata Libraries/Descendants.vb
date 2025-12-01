/// Descendants Metadata Library
/// All methods related to Descendants Metadata
/// Metadata, Descendants

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
Imports Workspace.AWCommons.Commons.MetaData

' Initialize the Descendants Metadata Library
Dim _mdlib As New AWMetadataLibraries(si, api, globals)


' Get all descendants members within a specified dimension
Dim dimToRead As DimTypeId = DimTypeId.Account ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
Dim descendants As List(Of Member) = _mdlib.GetDescendantsMembers(dimToRead, "MemberName")


' Get all descendants members names within a specified dimension
Dim dimToRead As DimTypeId = DimTypeId.Account ' Dimension type of the member: DimTypeId.Account, DimTypeId.Entity, DimTypeId.UD1, etc.
Dim descendantsNames As List(Of String) = _mdlib.GetDescendantsMembersName(dimToRead, "MemberName")