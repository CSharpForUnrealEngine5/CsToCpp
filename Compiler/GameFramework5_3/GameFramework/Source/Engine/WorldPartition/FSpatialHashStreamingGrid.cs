namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a PIE/Game streaming grid</summary>
[CppInclude("WorldPartition/WorldPartitionRuntimeSpatialHash.h")]
public partial struct FSpatialHashStreamingGrid {
	public FName GridName;
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
