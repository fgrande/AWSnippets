/// Impact Entities
/// Impect selected entities
/// Entity,Impact

// Referenced Assembly : WS\Workspace.AWCommons.Commons;
using Workspace.AWCommons.Commons.MetaData;
using Workspace.AWCommons.Commons.Shared;

// ImpactMode is included in the Shared library and can be one of the following:
// - AWImpactMode.None: if you want to impact just the selected entity
// - AWImpactMode.Base: if you want to impact the base entities
// - AWImpactMode.Children: if you want to impact the children
// - AWImpactMode.Descendants: if you want to impact all descendants

// Impact just one entity
AWCalsStatus.Impact(si, globals, "CubeName", "EntityName", "ParentName", "ConsolidationName", "ScenarioName", "TimePeriod", ImpactMode.None);


// You need this if you want to impact multiple entities at once
AWCalsStatus _imp = new AWCalcStatus(si, globals);

// You have to add the entities you want to impact
_imp.AddImpact("CubeName", "EntityName1", "ParentName", "ConsolidationName", "ScenarioName", "TimePeriod", ImpactMode.None);
_imp.AddImpact("CubeName2", "EntityName2", "ParentName2", "ConsolidationName2", "ScenarioName2", "TimePeriod2", ImpactMode.None);

// Finally, you can impact all the added entities at once
_imp.ImpactAll();