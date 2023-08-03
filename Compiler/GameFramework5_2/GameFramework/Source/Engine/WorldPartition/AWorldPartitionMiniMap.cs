#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A mini map to preview the world in world partition window. (editor-only)</summary>
[CppInclude("WorldPartition/WorldPartitionMiniMap.h")]
public partial class AWorldPartitionMiniMap : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>WorldBounds for MinMapTexture</summary>
	public FBox MiniMapWorldBounds;
	///<summary>UVOffset used to setup Virtual Texture</summary>
	public FBox2D UVOffset;
	///<summary>MiniMap Texture for displaying on world partition window</summary>
	public UTexture2D MiniMapTexture;
	///<summary>Datalayers excluded from MiniMap rendering</summary>
	public TSet<FActorDataLayer> ExcludedDataLayers;
	///<summary>Target world units per pixel for the minimap texture.</summary>
	public int WorldUnitsPerPixel;
	///<summary>Size of the loading region that will be used when iterating over the whole map during the minimap build process.</summary>
	public int BuilderCellSize;
	///<summary>Specifies which component of the scene rendering should be output to the minimap texture.</summary>
	public ESceneCaptureSource CaptureSource;
	///<summary>Number of frames to render before each capture in order to warmup various rendering systems (VT/Nanite/etc).</summary>
	public uint CaptureWarmupFrames;
	///<summary>MiniMapTileSize_DEPRECATED</summary>
	public int MiniMapTileSize_DEPRECATED;
}
