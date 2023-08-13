namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRuntimeLevelStreamingCell.h")]
public partial class UWorldPartitionRuntimeLevelStreamingCell : UWorldPartitionRuntimeCell {
	public static UClass StaticClass() {return default;}
	///<summary>OnLevelShown</summary>
	public void OnLevelShown() {}
	///<summary>OnLevelHidden</summary>
	public void OnLevelHidden() {}
	///<summary>Packages</summary>
	public TArray<FWorldPartitionRuntimeCellObjectMapping> Packages;
	///<summary>LevelStreaming</summary>
	public UWorldPartitionLevelStreamingDynamic LevelStreaming;
}
