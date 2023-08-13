namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a PIE/Game streaming cell which points to external actor/data chunk packages</summary>
[CppInclude("WorldPartition/WorldPartitionRuntimeCell.h")]
public partial class UWorldPartitionRuntimeCell : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>UnsavedActorsContainer</summary>
	public UActorContainer UnsavedActorsContainer;
	///<summary>bIsAlwaysLoaded</summary>
	public bool bIsAlwaysLoaded;
	///<summary>DataLayers</summary>
	public TArray<string> DataLayers;
	///<summary>Debug Info</summary>
	public FWorldPartitionRuntimeCellDebugInfo DebugInfo;
	///<summary>Custom Priority</summary>
	public int Priority;
	///<summary>bClientOnlyVisible</summary>
	public bool bClientOnlyVisible;
	///<summary>bIsHLOD</summary>
	public bool bIsHLOD;
	///<summary>bBlockOnSlowLoading</summary>
	public bool bBlockOnSlowLoading;
	///<summary>ContentBundleID</summary>
	public FGuid ContentBundleID;
	///<summary>CellGuid</summary>
	public FGuid CellGuid;
	///<summary>RuntimeCellData</summary>
	public UWorldPartitionRuntimeCellData RuntimeCellData;
}
