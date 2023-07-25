#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRuntimeCell.h")]
///<summary>Represents a PIE/Game streaming cell which points to external actor/data chunk packages</summary>
public partial class UWorldPartitionRuntimeCell : UObject {
// WorldPartitionRuntimeCell
	public UActorContainer UnsavedActorsContainer;
	public bool bIsAlwaysLoaded;
	public TArray<string> DataLayers;
	public FWorldPartitionRuntimeCellDebugInfo DebugInfo;
	public int Priority;
	public bool bClientOnlyVisible;
	public bool bIsHLOD;
	public bool bBlockOnSlowLoading;
	public FGuid ContentBundleID;
	public FGuid CellGuid;
	public UWorldPartitionRuntimeCellData RuntimeCellData;
}
