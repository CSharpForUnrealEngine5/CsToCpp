#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionLevelStreamingDynamic.h")]
public partial class UWorldPartitionLevelStreamingDynamic : ULevelStreamingDynamic {
// WorldPartitionLevelStreamingDynamic
	public ULevel RuntimeLevel;
	public bool bShouldBeAlwaysLoaded;
	public UActorContainer UnsavedActorsContainer;
	public TWeakObjectPtr<UWorldPartitionRuntimeLevelStreamingCell> StreamingCell;
	public TWeakObjectPtr<UWorldPartition> OuterWorldPartition;
}
