/// Cell Consolidate
/// Know if a cell is consolidated
/// Consolitation, Conso, Cell

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.MetaData;

// Initialize the Base Metadata Library
AWMetadataLibraries _mdlib = new AWMetadataLibraries(si, api, globals);

// Check if a cell is consolidated
DataBufferCell cell = new DataBufferCell();
bool isConsolidated = _mdlib.IsCellConsolidated(cell);