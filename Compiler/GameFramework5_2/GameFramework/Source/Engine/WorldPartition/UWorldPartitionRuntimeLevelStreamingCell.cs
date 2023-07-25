#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRuntimeLevelStreamingCell.h")]
public partial class UWorldPartitionRuntimeLevelStreamingCell : UWorldPartitionRuntimeCell {
// WorldPartitionRuntimeLevelStreamingCell
	public void OnLevelShown() {}
	public void OnLevelHidden() {}
	public TArray<FWorldPartitionRuntimeCellObjectMapping> Packages;
	public UWorldPartitionLevelStreamingDynamic LevelStreaming;
}
