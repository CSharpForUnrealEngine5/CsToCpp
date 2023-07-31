#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TraceSourceFilteringSettings.h")]
public partial class UTraceSourceFilteringSettings : UObject {
	///<summary>Whether or not the filtering state for all considered AActor&#39;s inside for a UWorld should be drawn using a wire frame box</summary>
	public bool bDrawFilteringStates;
	///<summary>Whether or not only AActor&#39;s that are not filtered out should be considered for drawing their wireframe box</summary>
	public bool bDrawOnlyPassingActors;
	///<summary>Whether or not to draw the failed UDataSourceFilter&#39;s description for AActor&#39;s that did not pass the filtering</summary>
	public bool bDrawFilterDescriptionForRejectedActors;
	///<summary>Whether or not to, whenever it changes, output the optimized filter setup state to the log</summary>
	public bool bOutputOptimizedFilterState;
}
