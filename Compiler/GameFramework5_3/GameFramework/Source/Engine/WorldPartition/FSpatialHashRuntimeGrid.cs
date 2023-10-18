namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a runtime grid (editing)</summary>
[CppInclude("WorldPartition/WorldPartitionRuntimeSpatialHash.h")]
public partial struct FSpatialHashRuntimeGrid {
	public FName GridName;
	public int CellSize;
	public float LoadingRange;
	public bool bBlockOnSlowStreaming;
	public FVector2D Origin;
	public int Priority;
	public FLinearColor DebugColor;
	public bool bClientOnlyVisible;
	public UHLODLayer HLODLayer;
}
