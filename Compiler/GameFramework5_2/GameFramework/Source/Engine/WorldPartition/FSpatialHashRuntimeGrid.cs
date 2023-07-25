#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRuntimeSpatialHash.h")]
///<summary>Represents a runtime grid (editing)</summary>
public partial struct FSpatialHashRuntimeGrid {
// SpatialHashRuntimeGrid
	public string GridName;
	public int CellSize;
	public float LoadingRange;
	public bool bBlockOnSlowStreaming;
	public int Priority;
	public FLinearColor DebugColor;
	public bool bClientOnlyVisible;
	public UHLODLayer HLODLayer;
}
