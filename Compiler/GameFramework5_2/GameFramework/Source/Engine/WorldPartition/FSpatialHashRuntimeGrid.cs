#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a runtime grid (editing)</summary>
[CppInclude("WorldPartition/WorldPartitionRuntimeSpatialHash.h")]
public partial struct FSpatialHashRuntimeGrid {
	public string GridName;
	public int CellSize;
	public float LoadingRange;
	public bool bBlockOnSlowStreaming;
	public int Priority;
	public FLinearColor DebugColor;
	public bool bClientOnlyVisible;
	public UHLODLayer HLODLayer;
}
