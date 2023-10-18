namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavMesh/RecastNavMesh.h")]
public partial struct FRecastNavMeshTileGenerationDebug {
	public bool bEnabled;
	public FIntVector TileCoordinate;
	public bool bGenerateDebugTileOnly;
	public bool bCollisionGeometry;
	public EHeightFieldRenderMode HeightFieldRenderMode;
	public bool bHeightfieldFromRasterization;
	public bool bHeightfieldPostInclusionBoundsFiltering;
	public bool bHeightfieldPostHeightFiltering;
	public bool bHeightfieldBounds;
	public bool bCompactHeightfield;
	public bool bCompactHeightfieldEroded;
	public bool bCompactHeightfieldRegions;
	public bool bCompactHeightfieldDistances;
	public bool bTileCacheLayerAreas;
	public bool bTileCacheLayerRegions;
	public bool bTileCacheContours;
	public bool bTileCachePolyMesh;
	public bool bTileCacheDetailMesh;
}
