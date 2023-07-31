#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionRuntimeLevelStreamingCell.h")]
public partial class UWorldPartitionRuntimeLevelStreamingCell : UWorldPartitionRuntimeCell {
	///<summary>OnLevelShown</summary>
	public  void OnLevelShown() {}
	///<summary>OnLevelHidden</summary>
	public  void OnLevelHidden() {}
	///<summary>Packages</summary>
	public TArray<FWorldPartitionRuntimeCellObjectMapping> Packages;
	///<summary>LevelStreaming</summary>
	public UWorldPartitionLevelStreamingDynamic LevelStreaming;
}
