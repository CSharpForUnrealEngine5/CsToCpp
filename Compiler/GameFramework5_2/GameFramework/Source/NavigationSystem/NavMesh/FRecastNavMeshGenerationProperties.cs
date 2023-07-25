#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavMesh/RecastNavMesh.h")]
public partial struct FRecastNavMeshGenerationProperties {
// RecastNavMeshGenerationProperties
	public int TilePoolSize;
	public float TileSizeUU;
	public float CellSize;
	public float CellHeight;
	public float AgentRadius;
	public float AgentHeight;
	public float AgentMaxSlope;
	public float AgentMaxStepHeight;
	public float MinRegionArea;
	public float MergeRegionSize;
	public float MaxSimplificationError;
	public int TileNumberHardLimit;
	public byte RegionPartitioning;
	public byte LayerPartitioning;
	public int RegionChunkSplits;
	public int LayerChunkSplits;
	public bool bSortNavigationAreasByCost;
	public bool bPerformVoxelFiltering;
	public bool bMarkLowHeightAreas;
	public bool bUseExtraTopCellWhenMarkingAreas;
	public bool bFilterLowSpanSequences;
	public bool bFilterLowSpanFromTileCache;
	public bool bFixedTilePoolSize;
	public bool bIsWorldPartitioned;
}
