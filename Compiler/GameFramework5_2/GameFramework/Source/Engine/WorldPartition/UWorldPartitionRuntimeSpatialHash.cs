#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRuntimeSpatialHash.h")]
public partial class UWorldPartitionRuntimeSpatialHash : UWorldPartitionRuntimeHash {
// WorldPartitionRuntimeSpatialHash
	public TArray<FSpatialHashRuntimeGrid> Grids;
	public bool bPreviewGrids;
	public FWorldPartitionRuntimeSpatialHashGridPreviewer GridPreviewer;
	public bool bEnableZCulling;
	public TArray<FSpatialHashStreamingGrid> StreamingGrids;
	public TArray<TWeakObjectPtr<URuntimeSpatialHashExternalStreamingObject>> ExternalStreamingObjects;
}
