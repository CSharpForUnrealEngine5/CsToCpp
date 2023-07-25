#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavMesh/RecastNavMesh.h")]
public partial class ARecastNavMesh : ANavigationData {
// RecastNavMesh
	public bool bDrawTriangleEdges;
	public bool bDrawPolyEdges;
	public bool bDrawFilledPolys;
	public bool bDrawNavMeshEdges;
	public bool bDrawTileBounds;
	public bool bDrawTileResolutions;
	public bool bDrawPathCollidingGeometry;
	public bool bDrawTileLabels;
	public bool bDrawTileBuildTimes;
	public bool bDrawTileBuildTimesHeatMap;
	public bool bDrawPolygonLabels;
	public bool bDrawDefaultPolygonCost;
	public bool bDrawPolygonFlags;
	public bool bDrawLabelsOnPathNodes;
	public bool bDrawNavLinks;
	public bool bDrawFailedNavLinks;
	public bool bDrawClusters;
	public bool bDrawOctree;
	public bool bDrawOctreeDetails;
	public bool bDrawMarkedForbiddenPolys;
	public bool bDistinctlyDrawTilesBeingBuilt;
	public float DrawOffset;
	public FRecastNavMeshTileGenerationDebug TileGenerationDebug;
	public bool bFixedTilePoolSize;
	public int TilePoolSize;
	public float TileSizeUU;
	public float CellSize;
	public float CellHeight;
	public FNavMeshResolutionParam NavMeshResolutionParams;
	public float AgentRadius;
	public float AgentHeight;
	public float AgentMaxSlope;
	public float AgentMaxStepHeight;
	public float MinRegionArea;
	public float MergeRegionSize;
	public float MaxSimplificationError;
	public int MaxSimultaneousTileGenerationJobsCount;
	public int TileNumberHardLimit;
	public int PolyRefTileBits;
	public int PolyRefNavPolyBits;
	public int PolyRefSaltBits;
	public FVector NavMeshOriginOffset;
	public float DefaultDrawDistance;
	public float DefaultMaxSearchNodes;
	public float DefaultMaxHierarchicalSearchNodes;
	public byte RegionPartitioning;
	public byte LayerPartitioning;
	public int RegionChunkSplits;
	public int LayerChunkSplits;
	public bool bSortNavigationAreasByCost;
	public bool bIsWorldPartitioned;
	public bool bPerformVoxelFiltering;
	public bool bMarkLowHeightAreas;
	public bool bUseExtraTopCellWhenMarkingAreas;
	public bool bFilterLowSpanSequences;
	public bool bFilterLowSpanFromTileCache;
	public bool bDoFullyAsyncNavDataGathering;
	public bool bUseBetterOffsetsFromCorners;
	public bool bStoreEmptyTileLayers;
	public bool bUseVirtualFilters;
	public bool bUseVirtualGeometryFilteringAndDirtying;
	public bool bAllowNavLinkAsPathEnd;
	public int TimeSliceFilterLedgeSpansMaxYProcess;
	public double TimeSliceLongDurationDebug;
	public bool bAllowWorldPartitionedNavMesh;
	public bool bUseVoxelCache;
	public float TileSetUpdateInterval;
	public float HeuristicScale;
	public float VerticalDeviationFromGroundCompensation;
	public bool K2_ReplaceAreaInTileBounds(FBox Bounds,UClass OldArea,UClass NewArea,bool ReplaceLinks/*=true*/) { return default; }
}
