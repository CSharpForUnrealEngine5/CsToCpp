#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavMesh/RecastNavMesh.h")]
public partial class ARecastNavMesh : ANavigationData {
	public static UClass StaticClass() {return default;}
	///<summary>Draw edges of every navmesh&#39;s triangle</summary>
	public bool bDrawTriangleEdges;
	///<summary>Draw edges of every poly (i.e. not only border-edges)</summary>
	public bool bDrawPolyEdges;
	///<summary>if disabled skips filling drawn navmesh polygons</summary>
	public bool bDrawFilledPolys;
	///<summary>Draw border-edges</summary>
	public bool bDrawNavMeshEdges;
	///<summary>Draw the tile boundaries</summary>
	public bool bDrawTileBounds;
	///<summary>Draw the tile resolutions</summary>
	public bool bDrawTileResolutions;
	///<summary>Draw input geometry passed to the navmesh generator.  Recommend disabling other geometry rendering via viewport showflags in editor.</summary>
	public bool bDrawPathCollidingGeometry;
	///<summary>bDrawTileLabels</summary>
	public bool bDrawTileLabels;
	///<summary>bDrawTileBuildTimes</summary>
	public bool bDrawTileBuildTimes;
	///<summary>bDrawTileBuildTimesHeatMap</summary>
	public bool bDrawTileBuildTimesHeatMap;
	///<summary>Draw a label for every poly that indicates its poly and tile indices</summary>
	public bool bDrawPolygonLabels;
	///<summary>Draw a label for every poly that indicates its default and fixed costs</summary>
	public bool bDrawDefaultPolygonCost;
	///<summary>Draw a label for every poly that indicates its poly and area flags</summary>
	public bool bDrawPolygonFlags;
	///<summary>bDrawLabelsOnPathNodes</summary>
	public bool bDrawLabelsOnPathNodes;
	///<summary>bDrawNavLinks</summary>
	public bool bDrawNavLinks;
	///<summary>bDrawFailedNavLinks</summary>
	public bool bDrawFailedNavLinks;
	///<summary>Draw navmesh&#39;s clusters and cluster links. (Requires WITH_NAVMESH_CLUSTER_LINKS=1)</summary>
	public bool bDrawClusters;
	///<summary>Draw octree used to store navigation relevant actors</summary>
	public bool bDrawOctree;
	///<summary>Draw octree used to store navigation relevant actors with the elements bounds</summary>
	public bool bDrawOctreeDetails;
	///<summary>bDrawMarkedForbiddenPolys</summary>
	public bool bDrawMarkedForbiddenPolys;
	///<summary>if true, show currently rebuilding tiles differently when visualizing</summary>
	public bool bDistinctlyDrawTilesBeingBuilt;
	///<summary>vertical offset added to navmesh&#39;s debug representation for better readability</summary>
	public float DrawOffset;
	///<summary>TileGenerationDebug</summary>
	public FRecastNavMeshTileGenerationDebug TileGenerationDebug;
	///<summary>if true, the NavMesh will allocate fixed size pool for tiles, should be enabled to support streaming</summary>
	public bool bFixedTilePoolSize;
	///<summary>maximum number of tiles NavMesh can hold</summary>
	public int TilePoolSize;
	///<summary>size of single tile, expressed in uu</summary>
	public float TileSizeUU;
	///<summary>CellSize</summary>
	public float CellSize;
	///<summary>CellHeight</summary>
	public float CellHeight;
	///<summary>Resolution params</summary>
	public FNavMeshResolutionParam NavMeshResolutionParams;
	///<summary>Radius of smallest agent to traverse this navmesh</summary>
	public float AgentRadius;
	///<summary>Size of the tallest agent that will path with this navmesh.</summary>
	public float AgentHeight;
	///<summary>The maximum slope (angle) that the agent can move on.</summary>
	public float AgentMaxSlope;
	///<summary>Largest vertical step the agent can perform</summary>
	public float AgentMaxStepHeight;
	///<summary>The minimum dimension of area. Areas smaller than this will be discarded</summary>
	public float MinRegionArea;
	///<summary>The size limit of regions to be merged with bigger regions (watershed partitioning only)</summary>
	public float MergeRegionSize;
	///<summary>How much navigable shapes can get simplified - the higher the value the more freedom</summary>
	public float MaxSimplificationError;
	///<summary>Sets the limit for number of asynchronous tile generators running at one time, also used for some synchronous tasks</summary>
	public int MaxSimultaneousTileGenerationJobsCount;
	///<summary>Absolute hard limit to number of navmesh tiles. Be very, very careful while modifying it while</summary>
	public int TileNumberHardLimit;
	///<summary>PolyRefTileBits</summary>
	public int PolyRefTileBits;
	///<summary>PolyRefNavPolyBits</summary>
	public int PolyRefNavPolyBits;
	///<summary>PolyRefSaltBits</summary>
	public int PolyRefSaltBits;
	///<summary>Use this if you don&#39;t want your tiles to start at (0,0,0)</summary>
	public FVector NavMeshOriginOffset;
	///<summary>navmesh draw distance in game (always visible in editor)</summary>
	public float DefaultDrawDistance;
	///<summary>specifes default limit to A* nodes used when performing navigation queries.</summary>
	public float DefaultMaxSearchNodes;
	///<summary>specifes default limit to A* nodes used when performing hierarchical navigation queries.</summary>
	public float DefaultMaxHierarchicalSearchNodes;
	///<summary>partitioning method for creating navmesh polys</summary>
	public ERecastPartitioning RegionPartitioning;
	///<summary>partitioning method for creating tile layers</summary>
	public ERecastPartitioning LayerPartitioning;
	///<summary>number of chunk splits (along single axis) used for region&#39;s partitioning: ChunkyMonotone</summary>
	public int RegionChunkSplits;
	///<summary>number of chunk splits (along single axis) used for layer&#39;s partitioning: ChunkyMonotone</summary>
	public int LayerChunkSplits;
	///<summary>Controls whether Navigation Areas will be sorted by cost before application</summary>
	public bool bSortNavigationAreasByCost;
	///<summary>In a world partitioned map, is this navmesh using world partitioning</summary>
	public bool bIsWorldPartitioned;
	///<summary>controls whether voxel filtering will be applied (via FRecastTileGenerator::ApplyVoxelFilter).</summary>
	public bool bPerformVoxelFiltering;
	///<summary>mark areas with insufficient free height above instead of cutting them out (accessible only for area modifiers using replace mode)</summary>
	public bool bMarkLowHeightAreas;
	///<summary>Expand the top of the area nav modifier&#39;s bounds by one cell height when applying to the navmesh.</summary>
	public bool bUseExtraTopCellWhenMarkingAreas;
	///<summary>if set, only single low height span will be allowed under valid one</summary>
	public bool bFilterLowSpanSequences;
	///<summary>if set, only low height spans with corresponding area modifier will be stored in tile cache (reduces memory, can&#39;t modify without full tile rebuild)</summary>
	public bool bFilterLowSpanFromTileCache;
	///<summary>if set, navmesh data gathering will never happen on the game thread and will only be done on background threads</summary>
	public bool bDoFullyAsyncNavDataGathering;
	///<summary>TODO: switch to disable new code from OffsetFromCorners if necessary - remove it later</summary>
	public bool bUseBetterOffsetsFromCorners;
	///<summary>If set, tiles generated without any navmesh data will be marked to distinguish them from not generated / streamed out ones. Defaults to false.</summary>
	public bool bStoreEmptyTileLayers;
	///<summary>Indicates whether default navigation filters will use virtual functions. Defaults to true.</summary>
	public bool bUseVirtualFilters;
	///<summary>Indicates whether use the virtual methods to check if an object should generate geometry or if we should call the normal method directly (i.e. FNavigationOctreeElement::ShouldUseGeometry).</summary>
	public bool bUseVirtualGeometryFilteringAndDirtying;
	///<summary>If set, paths can end at navlink poly (not the ground one!)</summary>
	public bool bAllowNavLinkAsPathEnd;
	///<summary>The maximum number of y coords to process when time slicing filter ledge spans during navmesh regeneration.</summary>
	public int TimeSliceFilterLedgeSpansMaxYProcess;
	///<summary>If a single time sliced section of navmesh regen code exceeds this duration then it will trigger debug logging</summary>
	public double TimeSliceLongDurationDebug;
	///<summary>World partitioned navmesh are only allowed in partitioned worlds.</summary>
	public bool bAllowWorldPartitionedNavMesh;
	///<summary>Cache rasterized voxels instead of just collision vertices/indices in navigation octree</summary>
	public bool bUseVoxelCache;
	///<summary>indicates how often we will sort navigation tiles to mach players position</summary>
	public float TileSetUpdateInterval;
	///<summary>Euclidean distance heuristic scale used while pathfinding</summary>
	public float HeuristicScale;
	///<summary>Value added to each search height to compensate for error between navmesh polys and walkable geometry</summary>
	public float VerticalDeviationFromGroundCompensation;
	///<summary>@return true if any polygon/link has been touched</summary>
	public  bool K2_ReplaceAreaInTileBounds(FBox Bounds,UClass OldArea,UClass NewArea,bool ReplaceLinks/*=true*/) { return default; }
}
