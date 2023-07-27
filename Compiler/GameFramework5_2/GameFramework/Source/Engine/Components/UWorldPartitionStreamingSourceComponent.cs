#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/WorldPartitionStreamingSourceComponent.h")]
public partial class UWorldPartitionStreamingSourceComponent : UActorComponent {
// WorldPartitionStreamingSourceComponent
	public  void EnableStreamingSource() {}
	public  void DisableStreamingSource() {}
	public  bool IsStreamingSourceEnabled() { return default; }
	public  bool IsStreamingCompleted() { return default; }
	public float DefaultVisualizerLoadingRange;
	public EStreamingSourceTargetBehavior TargetBehavior;
	public TArray<string> TargetGrids;
	public string TargetGrid_DEPRECATED;
	public FColor DebugColor;
	public TArray<UHLODLayer> TargetHLODLayers;
	public UHLODLayer TargetHLODLayer_DEPRECATED;
	public TArray<FStreamingSourceShape> Shapes;
	public EStreamingSourcePriority Priority;
	public bool bStreamingSourceEnabled;
	public EStreamingSourceTargetState TargetState;
}
