#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRuntimeSpatialHash.h")]
///<summary>Represents a PIE/Game streaming grid</summary>
public partial struct FSpatialHashStreamingGrid {
// SpatialHashStreamingGrid
	public string GridName;
	public FVector Origin;
	public int CellSize;
	public float LoadingRange;
	public bool bBlockOnSlowStreaming;
	public FLinearColor DebugColor;
	public TArray<FSpatialHashStreamingGridLevel> GridLevels;
	public FBox WorldBounds;
	public bool bClientOnlyVisible;
	public UHLODLayer HLODLayer;
}
