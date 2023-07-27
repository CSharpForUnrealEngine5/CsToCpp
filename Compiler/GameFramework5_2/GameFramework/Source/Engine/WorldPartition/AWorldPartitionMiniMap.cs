#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionMiniMap.h")]
///<summary>A mini map to preview the world in world partition window. (editor-only)</summary>
public partial class AWorldPartitionMiniMap : AInfo {
// WorldPartitionMiniMap
	public FBox MiniMapWorldBounds;
	public FBox2D UVOffset;
	public UTexture2D MiniMapTexture;
	public TSet<FActorDataLayer> ExcludedDataLayers;
	public int WorldUnitsPerPixel;
	public int BuilderCellSize;
	public ESceneCaptureSource CaptureSource;
	public uint CaptureWarmupFrames;
	public int MiniMapTileSize_DEPRECATED;
}
