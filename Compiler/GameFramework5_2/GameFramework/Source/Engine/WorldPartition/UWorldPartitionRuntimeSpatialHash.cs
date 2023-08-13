namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRuntimeSpatialHash.h")]
public partial class UWorldPartitionRuntimeSpatialHash : UWorldPartitionRuntimeHash {
	public static UClass StaticClass() {return default;}
	///<summary>Grids</summary>
	public TArray<FSpatialHashRuntimeGrid> Grids;
	///<summary>Whether to preview runtime grids.</summary>
	public bool bPreviewGrids;
	///<summary>GridPreviewer</summary>
	public FWorldPartitionRuntimeSpatialHashGridPreviewer GridPreviewer;
	///<summary>Whether this hash enables Z culling.</summary>
	public bool bEnableZCulling;
	///<summary>Represents the streaming grids (PIE or Game)</summary>
	public TArray<FSpatialHashStreamingGrid> StreamingGrids;
	///<summary>ExternalStreamingObjects</summary>
	public TArray<TWeakObjectPtr<URuntimeSpatialHashExternalStreamingObject>> ExternalStreamingObjects;
}
