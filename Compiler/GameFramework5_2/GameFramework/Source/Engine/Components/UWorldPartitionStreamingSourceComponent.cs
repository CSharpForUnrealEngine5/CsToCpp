#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/WorldPartitionStreamingSourceComponent.h")]
public partial class UWorldPartitionStreamingSourceComponent : UActorComponent {
	///<summary>Enable the component</summary>
	public  void EnableStreamingSource() {}
	///<summary>Disable the component</summary>
	public  void DisableStreamingSource() {}
	///<summary>Returns true if the component is active.</summary>
	public  bool IsStreamingSourceEnabled() { return default; }
	///<summary>Returns true if streaming is completed for this streaming source component.</summary>
	public  bool IsStreamingCompleted() { return default; }
	///<summary>Value used by debug visualizer when grid loading range is chosen.</summary>
	public float DefaultVisualizerLoadingRange;
	///<summary>When TargetGrids or TargetHLODLayers are specified, this indicates the behavior.</summary>
	public EStreamingSourceTargetBehavior TargetBehavior;
	///<summary>Optional target grids affected by streaming source.</summary>
	public TArray<string> TargetGrids;
	///<summary>TargetGrid_DEPRECATED</summary>
	public string TargetGrid_DEPRECATED;
	///<summary>Color used for debugging.</summary>
	public FColor DebugColor;
	///<summary>Optional target HLODLayers affected by the streaming source.</summary>
	public TArray<UHLODLayer> TargetHLODLayers;
	///<summary>TargetHLODLayer_DEPRECATED</summary>
	public UHLODLayer TargetHLODLayer_DEPRECATED;
	///<summary>Optional aggregated shape list used to build a custom shape for the streaming source. When empty, fallbacks sphere shape with a radius equal to grid&#39;s loading range.</summary>
	public TArray<FStreamingSourceShape> Shapes;
	///<summary>Priority</summary>
	public EStreamingSourcePriority Priority;
	///<summary>Whether this component is enabled or not</summary>
	public bool bStreamingSourceEnabled;
	///<summary>TargetState</summary>
	public EStreamingSourceTargetState TargetState;
}
