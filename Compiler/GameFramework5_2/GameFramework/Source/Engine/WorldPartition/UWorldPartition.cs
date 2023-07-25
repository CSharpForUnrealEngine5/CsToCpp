#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartition.h")]
public partial class UWorldPartition : UObject {
// WorldPartition
	public UWorldPartitionEditorHash EditorHash;
	public UClass WorldPartitionStreamingPolicyClass;
	public bool bStreamingWasEnabled;
	public bool bCanBeUsedByLevelInstance;
	public UActorDescContainer ActorDescContainer;
	public UWorldPartitionRuntimeHash RuntimeHash;
	public UWorld World;
	public bool bEnableStreaming;
	public UHLODLayer DefaultHLODLayer;
	public UWorldPartitionStreamingPolicy StreamingPolicy;
	public TSet<UWorldPartitionEditorLoaderAdapter> RegisteredEditorLoaderAdapters;
}
