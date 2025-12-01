/// Cell Consolidate
/// Know if a cell is consolidated
/// Consolitation, Conso, Cell

' Referenced Assembly : WS\Workspace.AWCommons.Commons;
imports Workspace.AWCommons.Commons.MetaData

' Initialize the Base Metadata Library
Dim _mdlib As New AWMetadataLibraries(si, api, globals)

' Check if a cell is consolidated
Dim cell As New DataBufferCell()
Dim isConsolidated As Boolean = _mdlib.IsCellConsolidated(cell)