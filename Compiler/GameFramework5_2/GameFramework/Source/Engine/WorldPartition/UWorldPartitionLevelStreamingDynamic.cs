#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionLevelStreamingDynamic.h")]
public partial class UWorldPartitionLevelStreamingDynamic : ULevelStreamingDynamic {
	///<summary>RuntimeLevel</summary>
	public ULevel RuntimeLevel;
	///<summary>bShouldBeAlwaysLoaded</summary>
	public bool bShouldBeAlwaysLoaded;
	///<summary>UnsavedActorsContainer</summary>
	public UActorContainer UnsavedActorsContainer;
	///<summary>StreamingCell</summary>
	public TWeakObjectPtr<UWorldPartitionRuntimeLevelStreamingCell> StreamingCell;
	///<summary>OuterWorldPartition</summary>
	public TWeakObjectPtr<UWorldPartition> OuterWorldPartition;
}
