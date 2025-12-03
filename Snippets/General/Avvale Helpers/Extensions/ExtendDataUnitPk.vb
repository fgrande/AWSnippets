/// DataUnitPk Extensions
/// Extend DataUnitPk functionalities
/// Extensions, DataUnitPk

' Referenced Assembly : WS\Workspace.AWCommons.Commons
Imports Workspace.AWCommons.Commons.Extensions

' Create a DataUnitPk instance
Dim pk As New DataUnitPk("CubeId", "EntityId", "ParentId", "ConsId", "ScenarioId", "TimeId")

' Get DataUnitPk id/coordinates
Dim coordinates As String = pk.ToKey()

' Get DataUnitPk as script string
Dim scriptString As String = pk.ToKeyExt(api)