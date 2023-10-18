namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRuntimeSpatialHash.h")]
public partial class UWorldPartitionRuntimeSpatialHash : UWorldPartitionRuntimeHash {
	public static UClass StaticClass() {return default;}
	///<summary>Grids</summary>
	public TArray<FSpatialHashRuntimeGrid> Grids;
	///<summary>Whether to preview runtime grids.</summary>
	public bool bPreviewGrids;
	///<summary>PreviewGridLevel</summary>
	public int PreviewGridLevel;
	///<summary>GridPreviewer</summary>
	public FWorldPartitionRuntimeSpatialHashGridPreviewer GridPreviewer;
	///<summary>Disable to help break the pattern caused by world partition promotion of actors to upper grid levels that are always aligned on child levels.</summary>
	public EWorldPartitionCVarProjectDefaultOverride UseAlignedGridLevels;
	///<summary>Disable to avoid snapping higher levels cells to child cells. Only used when bUseAlignedGridLevels is false.</summary>
	public EWorldPartitionCVarProjectDefaultOverride SnapNonAlignedGridLevelsToLowerLevels;
	///<summary>Enable to place actors smaller than a cell size into their corresponding cell using their location instead of their bounding box.</summary>
	public EWorldPartitionCVarProjectDefaultOverride PlaceSmallActorsUsingLocation;
	///<summary>Enable to place partitioned actors into their corresponding cell using their location instead of their bounding box.</summary>
	public EWorldPartitionCVarProjectDefaultOverride PlacePartitionActorsUsingLocation;
	///<summary>Whether this hash enables Z culling.</summary>
	public bool bEnableZCulling;
	///<summary>Represents the streaming grids (PIE or Game)</summary>
	public TArray<FSpatialHashStreamingGrid> StreamingGrids;
}
